using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Denics.Administrator;


namespace Denics
{
    internal class AddNewAppointment
    {
        // Database connection
        static CallDatabase db = new CallDatabase();
        SqlConnection con = new SqlConnection(db.getDatabaseStringName());
        SqlCommand cmd;
        public void BookingDetailes()
        {
            int userid = UserAccount.GetUserIdOrDefault();
            int serviceid = AppointmentCart.GetServiceId();
            int doctorid = AppointmentCart.GetDoctorId();
            string dateStr = AppointmentCart.GetDate();
            string timeStr = AppointmentCart.GetTime();

            DateTime appointmentDate;
            TimeSpan appointmentTime;
            if (!DateTime.TryParseExact(dateStr, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out appointmentDate) ||
                !TimeSpan.TryParseExact(timeStr, @"hh\:mm", CultureInfo.InvariantCulture, out appointmentTime))
            {
                MessageBox.Show("Invalid date or time format in booking details.", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Insert appointment into database
            const string insertSql = @"
                INSERT INTO Appointments (user_id, service_id, doctor_id, appointment_date, appointment_time, status)
                VALUES (@userid, @serviceType, @doctorName, @appointmentDate, @appointmentTime, 'pending')";
            try
            {
                if (con.State != ConnectionState.Open) con.Open();
                using var cmd = new SqlCommand(insertSql, con);
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.Parameters.AddWithValue("@serviceType", serviceid);
                cmd.Parameters.AddWithValue("@doctorName", doctorid);
                cmd.Parameters.AddWithValue("@appointmentDate", appointmentDate.Date);
                cmd.Parameters.AddWithValue("@appointmentTime", appointmentTime);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment booked successfully and is pending confirmation.", "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear the AppointmentCart after successful booking
                AppointmentCart.Clear();


                // Send email confirmation
                string recipientEmail = UserAccount.GetEmail();
                string patientName = $"{UserAccount.GetFirstname()} {UserAccount.GetSurname()}";
                string serviceType = AppointmentCart.GetServiceType();
                DateTime apntDate = appointmentDate;
                string apntTime = timeStr;
                string doctor = AppointmentCart.GetDoctor();
                string doctorTime = timeStr;
                string apntNote = "";
                AppointmentServices.SendPendingEmail(recipientEmail, patientName, serviceType, apntDate, apntTime, doctor, apntNote);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error booking appointment: " + ex.Message, "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }
    }
}
