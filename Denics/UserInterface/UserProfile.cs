using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Denics.UserInterface
{
    public partial class UserProfile : Form
    {
        // Call database connection here
        static CallDatabase db = new CallDatabase();
        SqlConnection con = new SqlConnection(db.getDatabaseStringName());
        SqlCommand cmd;


        public UserProfile()
        {
            InitializeComponent();
            // Sidebar click functions
            HomeButton.Click += HomeButton_Click;
            PatientButton.Click += PatientButton_Click;
            DoctorButton.Click += DoctorButton_Click;
            AvailabilityButton.Click += AvailabilityButton_Click;
            AppointmentButton.Click += AppointmentButton_Click;
            ServicesButton.Click += ServicesButton_Click;
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            LoadUserProfile();
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void PatientButton_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile();
            userProfile.Show();
            this.Hide();
        }

        private void DoctorButton_Click(object sender, EventArgs e)
        {
            Doctors doctors = new Doctors();
            doctors.Show();
            this.Hide();
        }

        private void AvailabilityButton_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            this.Hide();
        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            UserBookingPage userBookingPage = new UserBookingPage();
            userBookingPage.Show();
            this.Hide();
        }

        private void ServicesButton_Click(object sender, EventArgs e)
        {
            AvailableServices availableServices = new AvailableServices();
            availableServices.Show();
            this.Hide();
        }

        // Using UserAccount to load user profile information
        private void LoadUserProfile()
        {
            // populate text fields from the UserAccount static holder
            boxFName.Text = UserAccount.GetFirstname() ?? string.Empty;
            boxLName.Text = UserAccount.GetSurname() ?? string.Empty;
            MiddleName_txtbx.Text = UserAccount.GetMiddlename() ?? string.Empty;
            boxNumber.Text = UserAccount.GetContactnumber() ?? string.Empty;
            Address_txtbx.Text = UserAccount.GetAddress() ?? string.Empty;
            boxEmail.Text = UserAccount.GetEmail() ?? string.Empty;

            // Password textbox is read-only; show placeholder dots or nothing.
            Password_txtbx.Text = "********";

            // Birthdate: UserAccount stores a formatted string. Try parse and set DateTimePicker value.
            var birthStr = UserAccount.GetBirthdate();
            if (!string.IsNullOrWhiteSpace(birthStr) && DateTime.TryParse(birthStr, out DateTime parsed))
            {
                Birthdate_cldr.Value = parsed;
            }
            else
            {
            }

            // Radio button for gender
            var gender = UserAccount.GetGender();
            if (string.Equals(gender, "Male", StringComparison.OrdinalIgnoreCase))
            {
                Male_rdbtn.Checked = true;
                Female_rdbtn.Checked = false;
            }
            else if (string.Equals(gender, "Female", StringComparison.OrdinalIgnoreCase))
            {
                Female_rdbtn.Checked = true;
                Male_rdbtn.Checked = false;
            }
            else
            {
                Male_rdbtn.Checked = false;
                Female_rdbtn.Checked = false;
            }
        }

        private void Male_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (Male_rdbtn.Checked)
            {
                Female_rdbtn.Checked = false;
            }
        }

        private void Female_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (Female_rdbtn.Checked)
            {
                Male_rdbtn.Checked = false;
            }
        }

        // Check if changes using the UserAccount class, if changes are made, update the database, if not, say no changes made
        private void SaveChanges_btn_Click(object sender, EventArgs e)
        {
            // New values from controls
            var newFirst = boxFName.Text.Trim();
            var newLast = boxLName.Text.Trim();
            var newMiddle = MiddleName_txtbx.Text.Trim();
            var newSuffix = Suffix_txtbx.Text.Trim();
            var newBirth = Birthdate_cldr.Value; // DateTime
            var newContact = boxNumber.Text.Trim();
            var newAddress = Address_txtbx.Text.Trim();
            string newGender = null;
            if (Male_rdbtn.Checked) newGender = "Male";
            else if (Female_rdbtn.Checked) newGender = "Female";

            // Compare with UserAccount current values
            bool anyFieldChanged =
                !string.Equals(newFirst, UserAccount.GetFirstname() ?? string.Empty, StringComparison.Ordinal) ||
                !string.Equals(newLast, UserAccount.GetSurname() ?? string.Empty, StringComparison.Ordinal) ||
                !string.Equals(newMiddle, UserAccount.GetMiddlename() ?? string.Empty, StringComparison.Ordinal) ||
                !string.Equals(newContact, UserAccount.GetContactnumber() ?? string.Empty, StringComparison.Ordinal) ||
                !string.Equals(newAddress, UserAccount.GetAddress() ?? string.Empty, StringComparison.Ordinal) ||
                !string.Equals(newGender ?? string.Empty, UserAccount.GetGender() ?? string.Empty, StringComparison.Ordinal);

            if (!anyFieldChanged)
            {
                MessageBox.Show("No changes made.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to save changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            var success = UpdateDatabase(newFirst, newLast, newMiddle, newSuffix, newBirth, newGender, newContact, newAddress);
            if (success)
            {
                // Update the in-memory UserAccount values so other forms reflect changes
                // Format birthdate to the same format used by UserAccount.SetUserDetails
                string formattedBirth = newBirth.ToString("MMMM dd, yyyy");

                MessageBox.Show("Changes saved successfully.");
                // Update UserAccount static holder
                UserAccount.SetUserId(UserAccount.GetUserIdOrDefault());
                LoadUserProfile();
            }
        }


        private bool UpdateDatabase(string first, string last, string middle, string suffix, DateTime birthdate, string gender, string contact, string address)
        {
            int userId = UserAccount.GetUserIdOrDefault();
            if (userId == 0)
            {
                MessageBox.Show("No user is currently logged in. Cannot save changes.");
                return false;
            }

            try
            {
                using (var connection = new SqlConnection(db.getDatabaseStringName()))
                {
                    connection.Open();
                    string query = @"UPDATE Users
                                     SET surname = @Surname,
                                         firstname = @Firstname,
                                         middlename = @Middlename,
                                         suffix = @Suffix,
                                         birthdate = @Birthdate,
                                         gender = @Gender,
                                         contact = @Contact,
                                         address = @Address
                                     WHERE user_id = @UserId";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@Surname", SqlDbType.NVarChar, 100).Value = string.IsNullOrEmpty(last) ? (object)DBNull.Value : last;
                        command.Parameters.Add("@Firstname", SqlDbType.NVarChar, 100).Value = string.IsNullOrEmpty(first) ? (object)DBNull.Value : first;
                        command.Parameters.Add("@Middlename", SqlDbType.NVarChar, 100).Value = string.IsNullOrEmpty(middle) ? (object)DBNull.Value : middle;
                        command.Parameters.Add("@Suffix", SqlDbType.NVarChar, 50).Value = string.IsNullOrEmpty(suffix) ? (object)DBNull.Value : suffix;
                        command.Parameters.Add("@Birthdate", SqlDbType.Date).Value = birthdate.Date;
                        command.Parameters.Add("@Gender", SqlDbType.NVarChar, 20).Value = string.IsNullOrEmpty(gender) ? (object)DBNull.Value : gender;
                        command.Parameters.Add("@Contact", SqlDbType.NVarChar, 50).Value = string.IsNullOrEmpty(contact) ? (object)DBNull.Value : contact;
                        command.Parameters.Add("@Address", SqlDbType.NVarChar, 500).Value = string.IsNullOrEmpty(address) ? (object)DBNull.Value : address;
                        command.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;

                        int rows = command.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating database: " + ex.Message);
                return false;
            }
        }

        private void changePassword_btn_Click(object sender, EventArgs e)
        {
            // Confirm user intent first
            var confirm = MessageBox.Show("Do you want to change your password?", "Change Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            // Prompt a small modal form for old and new password inputs
            using (var prompt = new Form())
            {
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.StartPosition = FormStartPosition.CenterParent;
                prompt.Width = 420;
                prompt.Height = 220;
                prompt.Text = "Change Password";
                prompt.MaximizeBox = false;
                prompt.MinimizeBox = false;
                prompt.ShowInTaskbar = false;

                var lblOld = new Label() { Left = 12, Top = 18, Text = "Old Password:", AutoSize = true };
                var txtOld = new TextBox() { Left = 130, Top = 14, Width = 260, UseSystemPasswordChar = true };

                var lblNew = new Label() { Left = 12, Top = 58, Text = "New Password:", AutoSize = true };
                var txtNew = new TextBox() { Left = 130, Top = 54, Width = 260, UseSystemPasswordChar = true };

                var btnOk = new Button() { Text = "OK", Left = 220, Width = 80, Top = 110, DialogResult = DialogResult.OK };
                var btnCancel = new Button() { Text = "Cancel", Left = 310, Width = 80, Top = 110, DialogResult = DialogResult.Cancel };

                prompt.Controls.Add(lblOld);
                prompt.Controls.Add(txtOld);
                prompt.Controls.Add(lblNew);
                prompt.Controls.Add(txtNew);
                prompt.Controls.Add(btnOk);
                prompt.Controls.Add(btnCancel);

                prompt.AcceptButton = btnOk;
                prompt.CancelButton = btnCancel;

                var result = prompt.ShowDialog(this);
                if (result != DialogResult.OK) return;

                var oldPwd = txtOld.Text ?? string.Empty;
                var newPwd = txtNew.Text ?? string.Empty;

                if (string.IsNullOrWhiteSpace(oldPwd) || string.IsNullOrWhiteSpace(newPwd))
                {
                    MessageBox.Show("Both old and new password are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (oldPwd == newPwd)
                {
                    MessageBox.Show("New password cannot be the same as the old password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int userId = UserAccount.GetUserIdOrDefault();
                if (userId == 0)
                {
                    MessageBox.Show("No user is currently logged in. Cannot change password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Verify old password
                    string storedHash;
                    using (var conn = new SqlConnection(db.getDatabaseStringName()))
                    {
                        conn.Open();
                        using (var cmdSel = new SqlCommand("SELECT password FROM Users WHERE user_id = @UserId", conn))
                        {
                            cmdSel.Parameters.AddWithValue("@UserId", userId);
                            var obj = cmdSel.ExecuteScalar();
                            storedHash = obj == null || obj == DBNull.Value ? string.Empty : obj.ToString();
                        }
                    }

                    var oldHash = HashPassword(oldPwd);
                    if (!string.Equals(oldHash, storedHash, StringComparison.Ordinal))
                    {
                        MessageBox.Show("Old password is incorrect.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Hash new password and update
                    var newHash = HashPassword(newPwd);
                    using (var conn = new SqlConnection(db.getDatabaseStringName()))
                    {
                        conn.Open();
                        using (var cmdUpd = new SqlCommand("UPDATE Users SET password = @Password WHERE user_id = @UserId", conn))
                        {
                            cmdUpd.Parameters.AddWithValue("@Password", newHash);
                            cmdUpd.Parameters.AddWithValue("@UserId", userId);
                            int rows = cmdUpd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to change password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error changing password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Local SHA256 hashing to match Registration.HashPassword
        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
