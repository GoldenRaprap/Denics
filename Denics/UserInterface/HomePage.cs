using System;
using System.Windows.Forms;
using Denics.FrontPage;
using System.Data;
using System.Data.SqlClient;
using Denics.Administrator;
using System.Drawing;

namespace Denics.UserInterface
{
    public partial class HomePage : Form
    {
        private string userName;

        // Allow constructing with an explicit userId
        public HomePage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // Sidebar click functions
            HomeButton.Click += HomeButton_Click;
            PatientButton.Click += PatientButton_Click;
            DoctorButton.Click += DoctorButton_Click;
            AvailabilityButton.Click += AvailabilityButton_Click;
            AppointmentButton.Click += AppointmentButton_Click;
            ServicesButton.Click += ServicesButton_Click;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // Load username from UserAccount getters
            LoadUsername();
            LoadUserAppointments();
        }

        private void LoadUsername()
        {
            try
            {
                var first = Denics.UserAccount.GetFirstname();
                if (!string.IsNullOrWhiteSpace(first))
                {
                    userName = first;
                    Username_lbl.Text = $"Welcome, {userName}!";
                }
                else
                {
                    Username_lbl.Text = "Welcome!";
                }
            }
            catch (Exception ex)
            {
                // Keep behavior simple and consistent with other UI code
                MessageBox.Show("Error loading username: " + ex.Message);
            }
        }
        
        private void LoadUserAppointments()
        {
            try
            {
                int userId = Denics.UserAccount.GetUserIdOrDefault();

                var db = new CallDatabase();
                using (var conn = new SqlConnection(db.getDatabaseStringName()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();

                    // Select relevant columns and format time to HH:mm for display
                    cmd.CommandText = @"
                        SELECT 
                            a.appointment_id,
                            s.service_name AS [Service],
                            d.full_name AS [Doctor],
                            a.appointment_date AS [Date],
                            a.appointment_time AS [Time],
                            a.status AS [Status],
                            a.last_updated AS [LastUpdated]
                        FROM Appointments a
                        INNER JOIN Doctors d ON a.doctor_id = d.doctor_id
                        INNER JOIN Services s ON a.service_id = s.service_id
                        WHERE a.user_id = @userId
                        ORDER BY a.last_updated DESC, a.appointment_date, a.appointment_time";

                    cmd.Parameters.AddWithValue("@userId", userId);

                    DataTable table = new DataTable();
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                        // Hide internal ID & LastUpdated columns
                        UserAppointments.DataSource = table;
                        if (UserAppointments.Columns.Contains("appointment_id"))
                            UserAppointments.Columns["appointment_id"].Visible = false;
                        if (UserAppointments.Columns.Contains("LastUpdated"))
                            UserAppointments.Columns["LastUpdated"].Visible = false;

                    }

                    UserAppointments.DataSource = table;

                    if (table.Rows.Count == 0)
                    {
                        // no appointments
                        YourAppontment_lbl.Text = "Book Appointment Now";

                        // clear grid
                        UserAppointments.DataSource = null;
                    }
                    else
                    {
                        YourAppontment_lbl.Text = "Your Appointments";

                        // hide internal id column when present
                        if (UserAppointments.Columns.Contains("appointment_id"))
                            UserAppointments.Columns["appointment_id"].Visible = false;

                        // ensure common column order if needed
                        // (Service, Doctor, Date, Time, Status)
                    }

                    // Mark completed/cancelled/no-show rows as gray so they appear immutable/done
                    int statusColIndex = UserAppointments.Columns.Contains("Status") ? UserAppointments.Columns["Status"].Index : -1;
                    foreach (DataGridViewRow row in UserAppointments.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string status = statusColIndex >= 0 && row.Cells[statusColIndex].Value != null
                            ? row.Cells[statusColIndex].Value.ToString()
                            : string.Empty;

                        if (IsDoneStatus(status))
                        {
                            row.DefaultCellStyle.ForeColor = Color.Gray;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message);
            }
        }

        private static bool IsDoneStatus(string rawStatus)
        {
            if (string.IsNullOrWhiteSpace(rawStatus)) return false;

            var s = rawStatus.Trim().ToLowerInvariant();
            var normalized = s.Replace(" ", "").Replace("-", "");

            return normalized == "cancelled"
                   || normalized == "cancel"
                   || normalized == "noshow"
                   || normalized == "complete"
                   || normalized == "completed";
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
        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Denics.UserAccount.Clear(); // Clear current user on logout
            LogInPage loginPage = new LogInPage();
            loginPage.Show();
            this.Hide();
        }


    }
}
