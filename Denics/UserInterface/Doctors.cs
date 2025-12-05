using Denics.Administrator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Denics.UserInterface
{
    public partial class Doctors : Form
    {
        static CallDatabase db = new CallDatabase();
        SqlConnection con = new SqlConnection(db.getDatabaseStringName());


        public Doctors()
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

            // Setup default week picker value => today
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            LoadDoctorCards();
        }
        
        private void LoadDoctorCards()
        {
            string doctorQuery = "SELECT doctor_id, full_name, email, phone_number FROM Doctors WHERE is_active = 1";
            string serviceQuery = @"
            SELECT S.service_name 
            FROM DoctorServices DS
            JOIN Services S ON DS.service_id = S.service_id
            WHERE DS.doctor_id = @DoctorId";

            try
            {
                con.Open();

                List<(int doctorId, string fullName, string email, string phone)> doctors = new List<(int, string, string, string)>();

                using (SqlCommand doctorCmd = new SqlCommand(doctorQuery, con))
                using (SqlDataReader doctorReader = doctorCmd.ExecuteReader())
                {
                    while (doctorReader.Read())
                    {
                        doctors.Add((
                            Convert.ToInt32(doctorReader["doctor_id"]),
                            doctorReader["full_name"].ToString(),
                            doctorReader["email"].ToString(),
                            doctorReader["phone_number"].ToString()
                        ));
                    }
                }

                int index = 0; // counter for alternating colors and image selection
                foreach (var doc in doctors)
                {
                    // choose profile image by card index (1-based description from user)
                    Image profileImage = Properties.Resources.IconDoctor; // fallback default

                    switch (index)
                    {
                        case 0:
                            // Doctor card 1 -> Dct1 (Ana Reyes)
                            profileImage = Properties.Resources.Dct1___Ana_Reyes;
                            break;
                        case 1:
                            // Doctor card 2 -> Doc2 (Cruz Juan)
                            profileImage = Properties.Resources.Dct2___Cruz_Juan;
                            break;
                        case 2:
                            // Doctor card 3 -> Doc3 (Jose Santors)
                            profileImage = Properties.Resources.Dct3___Jose_Santos;
                            break;
                        case 3:
                            // Doctor card 4 -> Doc4 (Maria Dela Cruz)
                            profileImage = Properties.Resources.Dct4___Maria_Dela_Cruz;
                            break;
                        default:
                            // any further cards use default avatar
                            profileImage = Properties.Resources.IconDoctor;
                            break;
                    }

                    DoctorCard card = new DoctorCard
                    {
                        FullName = doc.fullName,
                        Email = doc.email,
                        PhoneNumber = doc.phone,
                        ProfilePhoto = profileImage, // set according to index
                        DoctorId = doc.doctorId
                    };

                    // alternate background colors
                    card.BackColor = (index % 2 == 0) ? Color.LightBlue : Color.LightGray;

                    // Get services for this doctor
                    using (SqlCommand serviceCmd = new SqlCommand(serviceQuery, con))
                    {
                        serviceCmd.Parameters.AddWithValue("@DoctorId", doc.doctorId);
                        using (SqlDataReader serviceReader = serviceCmd.ExecuteReader())
                        {
                            List<string> services = new List<string>();
                            while (serviceReader.Read())
                            {
                                services.Add(serviceReader["service_name"].ToString());
                            }
                            card.Services = services.ToArray();
                        }
                    }

                    flowLayoutPanelDoctors.Controls.Add(card);

                    index++; // move to next card
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctor cards: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
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

    }
}
