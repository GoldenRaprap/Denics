using Denics.Administrator;
using Denics.UserInterface;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;



namespace Denics.FrontPage
{
    public partial class FContact : Form
    {
        static CallDatabase db = new CallDatabase();
        SqlConnection con = new SqlConnection(db.getDatabaseStringName());
        SqlCommand cmd;

        public FContact()
        {
            InitializeComponent();
        }

        private void Home_lbl_Click(object sender, EventArgs e)
        {
            FHomepage fhome = new FHomepage();
            fhome.Show();
            this.Hide();
        }

        private void AboutUs_lbl_Click(object sender, EventArgs e)
        {
            FAboutUs fabout = new FAboutUs();
            fabout.Show();
            this.Hide();
        }

        private void Contact_lbl_Click(object sender, EventArgs e)
        {
            FContact fcontact = new FContact();
            fcontact.Show();
            this.Hide();
        }
        private void Services_lbl_Click(object sender, EventArgs e)
        {
            FService fservice = new FService();
            fservice.Show();
            this.Hide();
        }
        private void Book_lbl_Click(object sender, EventArgs e)
        {
            LogInPage flogin = new LogInPage();
            flogin.Show();
            this.Hide();
        }

        private void Stafflogin_Click(object sender, EventArgs e)
        {

            {
                // Prompt for admin password stored in Properties.Settings
                var settingsPassword = Denics.Properties.Settings.Default.AdminPassword ?? string.Empty;

                using (var prompt = new Form())
                {
                    prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                    prompt.StartPosition = FormStartPosition.CenterParent;
                    prompt.Width = 380;
                    prompt.Height = 150;
                    prompt.Text = "Admin Access";
                    prompt.MaximizeBox = false;
                    prompt.MinimizeBox = false;
                    prompt.ShowInTaskbar = false;

                    var lbl = new Label() { Left = 12, Top = 12, Text = "Enter admin password:", AutoSize = true };
                    var txt = new TextBox() { Left = 12, Top = 36, Width = 340, UseSystemPasswordChar = true };

                    var btnOk = new Button() { Text = "OK", Left = 196, Width = 75, Top = 70, DialogResult = DialogResult.OK };
                    var btnCancel = new Button() { Text = "Cancel", Left = 277, Width = 75, Top = 70, DialogResult = DialogResult.Cancel };

                    prompt.Controls.Add(lbl);
                    prompt.Controls.Add(txt);
                    prompt.Controls.Add(btnOk);
                    prompt.Controls.Add(btnCancel);

                    prompt.AcceptButton = btnOk;
                    prompt.CancelButton = btnCancel;

                    if (prompt.ShowDialog(this) != DialogResult.OK)
                        return;

                    var entered = txt.Text ?? string.Empty;

                    if (string.IsNullOrEmpty(settingsPassword))
                    {
                        MessageBox.Show("Admin password is not configured. Contact the application administrator.", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.Equals(entered, settingsPassword, StringComparison.Ordinal))
                    {
                        var adminPage = new MainAdminPage();
                        adminPage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect admin password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

