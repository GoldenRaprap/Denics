using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Denics.Administrator;
using Denics;

namespace Denics.UserInterface
{
    public partial class UserBookingPage : Form
    {
        static CallDatabase db = new CallDatabase();
        SqlConnection con = new SqlConnection(db.getDatabaseStringName());
        private int userId;

        public UserBookingPage()
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


        private void UserBookingPage_Load(object sender, EventArgs e)
        {
            userId = Denics.UserAccount.GetUserIdOrDefault();

            SetupAppointmentPickersAndSlots();
            LoadServices();

            // If AppointmentCart contains a pre-selection from the Calendar, apply it to the booking controls.
            TryApplyAppointmentCartValues();

            LoadUserAppointments();
            LoadUserInfo();
        }

        private void TryApplyAppointmentCartValues()
        {
            try
            {
                string cartService = AppointmentCart.GetServiceType();
                string cartDate = AppointmentCart.GetDate();
                string cartTime = AppointmentCart.GetTime();
                string cartDoctor = AppointmentCart.GetDoctor();

                // Apply service (matching by text)
                if (!string.IsNullOrWhiteSpace(cartService) && ServicecomboBox.Items.Count > 0)
                {
                    for (int i = 0; i < ServicecomboBox.Items.Count; i++)
                    {
                        if (ServicecomboBox.Items[i] is ComboBoxItem item && string.Equals(item.Text, cartService, StringComparison.OrdinalIgnoreCase))
                        {
                            ServicecomboBox.SelectedIndex = i;
                            break;
                        }
                    }
                }

                // Apply date if valid
                if (!string.IsNullOrWhiteSpace(cartDate) && DateTime.TryParse(cartDate, out DateTime parsedDate))
                {
                    if (appointmenrDatePicker != null)
                    {
                        appointmenrDatePicker.Value = parsedDate.Date;
                    }
                }

                // Apply time if valid and present in time slots
                if (!string.IsNullOrWhiteSpace(cartTime))
                {
                    // Try a few formats and select using helper
                    SelectTimeInCombo(cartTime);
                }

                // If we have service, date and time now, attempt to load available doctors so we can pre-select the doctor
                if (ServicecomboBox.SelectedItem is ComboBoxItem selService &&
                    appointmenrDatePicker != null &&
                    TimeofAppointmentcomboBox != null && TimeofAppointmentcomboBox.SelectedItem != null)
                {
                    // populate available doctors (this will fill AvailableDoctorsComboBox)
                    LoadAvailableDoctors(selService.Value.ToString(), appointmenrDatePicker.Value.Date, TimeofAppointmentcomboBox.SelectedItem.ToString());

                    // try to select the doctor by name
                    if (!string.IsNullOrWhiteSpace(cartDoctor) && AvailableDoctorsComboBox.Items.Count > 0)
                    {
                        int idx = AvailableDoctorsComboBox.FindStringExact(cartDoctor);
                        if (idx >= 0)
                            AvailableDoctorsComboBox.SelectedIndex = idx;
                    }
                }
            }
            catch
            {
                // fail silently; cart is best-effort
            }
        }

        private void LoadUserInfo()
        {
            string username = Denics.UserAccount.GetFirstname() + " " + Denics.UserAccount.GetSurname();
            userName_txtbx.Text = username;
            Birthdate_txtbx.Text = Denics.UserAccount.GetBirthdate();
            Contact_txtbx.Text = Denics.UserAccount.GetContactnumber();
            Address_txtbx.Text = Denics.UserAccount.GetAddress();
        }

        private void LoadServices()
        {
            try
            {
                con.Open();
                string query = "SELECT service_id, service_name FROM Services";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    ServicecomboBox.Items.Clear();
                    while (reader.Read())
                    {
                        ServicecomboBox.Items.Add(new ComboBoxItem
                        {
                            Text = reader["service_name"].ToString(),
                            Value = reader["service_id"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading services: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void LoadAvailableDoctors(string serviceId, DateTime selectedDate, string selectedTime)
        {
            try
            {
                con.Open();

                string query = @"
                SELECT DISTINCT d.doctor_id, d.full_name
                FROM Doctors d
                INNER JOIN DoctorServices ds ON d.doctor_id = ds.doctor_id
                INNER JOIN Availability a ON d.doctor_id = a.doctor_id
                WHERE ds.service_id = @serviceId
                  AND a.date = @date
                  AND a.hour_slot = @hourSlot
                  AND a.status = 'Available'
                  AND a.is_blocked = 0";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@serviceId", serviceId);
                    cmd.Parameters.AddWithValue("@date", selectedDate);
                    // robustly parse the time string to TimeSpan (supports "3:00 PM", "15:00", "03:00")
                    cmd.Parameters.Add("@hourSlot", SqlDbType.Time).Value = ParseTimeTextToTimeSpan(selectedTime);

                    SqlDataReader reader = cmd.ExecuteReader();
                    AvailableDoctorsComboBox.Items.Clear();

                    while (reader.Read())
                    {
                        AvailableDoctorsComboBox.Items.Add(new DoctorItem
                        {
                            DoctorId = Convert.ToInt32(reader["doctor_id"]),
                            FullName = reader["full_name"].ToString()
                        });
                    }

                    if (AvailableDoctorsComboBox.Items.Count == 0)
                    {
                        MessageBox.Show("No doctors are available for the selected service, date, and time.");
                    }
                    else
                    {
                        AvailableDoctorsComboBox.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading available doctors: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void SetupAppointmentPickersAndSlots()
        {
            // Use the designer DateTimePicker named `appointmenrDatePicker` (note: it's declared in the .Designer file).
            if (appointmenrDatePicker != null)
            {
                appointmenrDatePicker.Format = DateTimePickerFormat.Short;
                // Do NOT set Value here - that would override the user's pick. Leave Value untouched.
            }

            // TimeofAppointmentcomboBox is created by the designer; Populate time slots below.
            PopulateHourlyTimeSlots(TimeSpan.FromHours(9), TimeSpan.FromHours(15));
        }

        private void PopulateHourlyTimeSlots(TimeSpan start, TimeSpan end)
        {
            string previousSelection = TimeofAppointmentcomboBox.SelectedItem?.ToString();

            TimeofAppointmentcomboBox.Items.Clear();
            for (TimeSpan t = start; t <= end; t = t.Add(TimeSpan.FromHours(1)))
            {
                // display times in 12-hour format with AM/PM for user friendliness
                TimeofAppointmentcomboBox.Items.Add(DateTime.Today.Add(t).ToString("h:mm tt", CultureInfo.CurrentCulture));
            }

            // Prefer restoring previous selection by exact match using helper.
            if (!string.IsNullOrEmpty(previousSelection))
            {
                SelectTimeInCombo(previousSelection);
            }
            else if (TimeofAppointmentcomboBox.Items.Count > 0)
            {
                TimeofAppointmentcomboBox.SelectedIndex = 0;
            }
        }

        // Helper tries several formats and lookups to robustly select the requested time.
        private void SelectTimeInCombo(string timeText)
        {
            if (TimeofAppointmentcomboBox == null) return;
            if (string.IsNullOrWhiteSpace(timeText)) return;

            // direct exact match first
            int idx = TimeofAppointmentcomboBox.FindStringExact(timeText);
            if (idx >= 0)
            {
                TimeofAppointmentcomboBox.SelectedIndex = idx;
                return;
            }

            // try to parse then try multiple canonical formats that we populate with
            if (ParseTimeTextToTimeSpan(timeText) is TimeSpan ts && ts != TimeSpan.Zero)
            {
                var candidates = new[]
                {
                    DateTime.Today.Add(ts).ToString("h:mm tt", CultureInfo.CurrentCulture), // "3:00 PM"
                    DateTime.Today.Add(ts).ToString("hh:mm", CultureInfo.InvariantCulture),   // "03:00"
                    ts.ToString(@"hh\:mm"), // "15:00"
                    ts.ToString(@"h\:mm")   // "3:00"
                };

                foreach (var c in candidates)
                {
                    if (string.IsNullOrEmpty(c)) continue;
                    int found = TimeofAppointmentcomboBox.FindStringExact(c);
                    if (found >= 0)
                    {
                        TimeofAppointmentcomboBox.SelectedIndex = found;
                        return;
                    }
                }
            }

            // fallback: try partial match (FindString)
            int partial = TimeofAppointmentcomboBox.FindString(timeText);
            if (partial >= 0)
            {
                TimeofAppointmentcomboBox.SelectedIndex = partial;
            }
        }

        // Robust parser that accepts "3:00 PM", "15:00", "03:00", "3:00"
        private TimeSpan ParseTimeTextToTimeSpan(string timeText)
        {
            if (string.IsNullOrWhiteSpace(timeText)) return TimeSpan.Zero;

            // Try TimeSpan first (handles "15:00" and "03:00")
            if (TimeSpan.TryParse(timeText, out var ts)) return ts;

            // Try general DateTime parse (handles "3:00 PM", "3:00")
            if (DateTime.TryParse(timeText, CultureInfo.CurrentCulture, DateTimeStyles.None, out var dt))
                return dt.TimeOfDay;

            // Try invariant formats explicitly
            var formats = new[] { "h:mm tt", "hh:mm tt", "h:mm", "hh:mm" };
            foreach (var f in formats)
            {
                if (DateTime.TryParseExact(timeText, f, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
                    return dt.TimeOfDay;
            }

            // last-resort: try to extract numbers like "3" or "15" -> treat as hour
            var digits = new string(timeText.Where(c => char.IsDigit(c) || c == ':').ToArray());
            if (TimeSpan.TryParse(digits, out ts)) return ts;

            return TimeSpan.Zero;
        }

        private DateTime GetSelectedAppointmentFromCombo()
        {
            if (appointmenrDatePicker == null)
                throw new InvalidOperationException("Date picker is not available.");

            if (TimeofAppointmentcomboBox == null)
                throw new InvalidOperationException("Time slots control is not available.");

            if (TimeofAppointmentcomboBox.SelectedItem == null)
                throw new InvalidOperationException("Please select a time slot.");

            DateTime selectedDate = appointmenrDatePicker.Value.Date;
            string timeText = TimeofAppointmentcomboBox.SelectedItem.ToString();

            var ts = ParseTimeTextToTimeSpan(timeText);
            if (ts == TimeSpan.Zero)
                throw new InvalidOperationException("Invalid time slot format.");

            return selectedDate + ts;
        }
        private void Check_Click(object sender, EventArgs e)
        {
            if (ServicecomboBox.SelectedItem is not ComboBoxItem selectedService)
            {
                MessageBox.Show("Please select a service first.");
                return;
            }

            if (appointmenrDatePicker == null || TimeofAppointmentcomboBox == null)
            {
                MessageBox.Show("Appointment controls are not ready.");
                return;
            }

            if (TimeofAppointmentcomboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a time slot.");
                return;
            }

            DateTime selectedDate = appointmenrDatePicker.Value.Date;
            string selectedTime = TimeofAppointmentcomboBox.SelectedItem.ToString();

            MessageBox.Show($"Checking availability for {selectedDate:yyyy-MM-dd} at {selectedTime}");

            LoadAvailableDoctors(selectedService.Value.ToString(), selectedDate, selectedTime);
        }
        private void LoadUserAppointments()
        {
            try
            {
                con.Open();

                // Include cancelled appointments and order by latest update first
                string query = @"
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

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    AppointmentDataGridView.DataSource = table;

                    // Hide internal ID & LastUpdated columns
                    if (AppointmentDataGridView.Columns.Contains("appointment_id"))
                        AppointmentDataGridView.Columns["appointment_id"].Visible = false;
                    if (AppointmentDataGridView.Columns.Contains("LastUpdated"))
                        AppointmentDataGridView.Columns["LastUpdated"].Visible = false;

                    // Add Cancel button column if not already added
                    if (!AppointmentDataGridView.Columns.Contains("Cancel"))
                    {
                        DataGridViewButtonColumn cancelColumn = new DataGridViewButtonColumn
                        {
                            Name = "Cancel",
                            HeaderText = "Action",
                            UseColumnTextForButtonValue = false, // allow per-cell text
                            FlatStyle = FlatStyle.Standard
                        };
                        AppointmentDataGridView.Columns.Add(cancelColumn);
                    }

                    // Ensure the Cancel column is last (optional)
                    if (AppointmentDataGridView.Columns.Contains("Cancel"))
                    {
                        AppointmentDataGridView.Columns["Cancel"].DisplayIndex = AppointmentDataGridView.Columns.Count - 1;
                    }

                    // Style rows and set per-row Cancel button text/behavior
                    int statusColIndex = AppointmentDataGridView.Columns.Contains("Status") ? AppointmentDataGridView.Columns["Status"].Index : -1;
                    int cancelColIndex = AppointmentDataGridView.Columns.Contains("Cancel") ? AppointmentDataGridView.Columns["Cancel"].Index : -1;

                    foreach (DataGridViewRow row in AppointmentDataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string status = statusColIndex >= 0 && row.Cells[statusColIndex].Value != null
                            ? row.Cells[statusColIndex].Value.ToString().Trim().ToLowerInvariant()
                            : string.Empty;

                        // Treat cancelled, no-show and completed as immutable (not changeable)
                        if (TryGetImmutableStatusDisplay(status, out string displayStatus))
                        {
                            // show status label instead of Cancel button and grey out
                            if (cancelColIndex >= 0)
                            {
                                var cell = row.Cells[cancelColIndex] as DataGridViewCell;
                                cell.Value = displayStatus;
                                cell.Style.ForeColor = Color.Gray;
                                cell.Style.BackColor = Color.Transparent;
                                cell.ReadOnly = true;
                            }

                            // grey-out entire row for clarity
                            row.DefaultCellStyle.ForeColor = Color.Gray;
                        }
                        else
                        {
                            if (cancelColIndex >= 0)
                            {
                                var cell = row.Cells[cancelColIndex] as DataGridViewCell;
                                cell.Value = "Cancel";
                                cell.Style.ForeColor = Color.DarkRed;
                                cell.ReadOnly = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void CancelAppointment(int appointmentId)
        {
            string sql = "UPDATE Appointments SET status = 'cancelled' WHERE appointment_id = @AppointmentId";

            using (SqlConnection con = new SqlConnection(db.getDatabaseStringName()))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void AppointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header clicks

            var row = AppointmentDataGridView.Rows[e.RowIndex];

            // Ensure Status column exists and read status
            string status = string.Empty;
            if (AppointmentDataGridView.Columns.Contains("Status") && row.Cells["Status"].Value != null)
                status = row.Cells["Status"].Value.ToString().Trim().ToLowerInvariant();

            // If Cancel button clicked
            if (AppointmentDataGridView.Columns[e.ColumnIndex].Name == "Cancel")
            {
                // If appointment is immutable (cancelled / no-show / completed), ignore click and show message
                if (TryGetImmutableStatusDisplay(status, out string displayStatus))
                {
                    // More specific message per status
                    MessageBox.Show($"This appointment is {displayStatus} and cannot be changed.");
                    return;
                }

                var appointmentIdObj = row.Cells["appointment_id"].Value;
                if (appointmentIdObj == null || !int.TryParse(appointmentIdObj.ToString(), out int appointmentId))
                {
                    MessageBox.Show("Unable to determine appointment id.");
                    return;
                }

                var service = row.Cells["Service"].Value?.ToString() ?? "<unknown>";
                var doctor = row.Cells["Doctor"].Value?.ToString() ?? "<unknown>";

                DateTime date = DateTime.MinValue;
                TimeSpan time = TimeSpan.Zero;
                try
                {
                    if (row.Cells["Date"].Value != null)
                        date = Convert.ToDateTime(row.Cells["Date"].Value);
                    if (row.Cells["Time"].Value != null)
                        time = TimeSpan.Parse(row.Cells["Time"].Value.ToString());
                }
                catch
                {
                    // ignore parse errors, proceed with what we have
                }

                var confirm = MessageBox.Show(
                    $"Cancel appointment for {service} with {doctor} on {date:MM/dd/yyyy} at {time}",
                    "Confirm Cancellation", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    CancelAppointment(appointmentId);
                    LoadUserAppointments(); // refresh table

                    // send cancellation email in background
                    Task.Run(() =>
                    {
                        try
                        {
                            string recipientEmail = Denics.UserAccount.GetEmail();
                            string patientName = Denics.UserAccount.GetFirstname() + " " + Denics.UserAccount.GetSurname();
                            string apntTime = time.ToString(@"hh\:mm");
                            string note = "You have cancelled this appointment. If this was a mistake or you need assistance, please contact Denics Dental.";
                            AppointmentServices.SendCancelledEmail(recipientEmail, patientName, service, date, apntTime, doctor, note);
                        }
                        catch
                        {
                            // swallow — do not block UI
                        }
                    });
                }
            }
            else
            {
                // For other cells: prevent reschedule if appointment is immutable (cancelled/no-show/completed)
                if (TryGetImmutableStatusDisplay(status, out string displayStatus))
                {
                    MessageBox.Show($"This appointment is {displayStatus} and cannot be rescheduled. Book a new appointment instead.");
                    return;
                }

                // ✅ If any other cell clicked, prepare for reschedule
                selectedAppointmentId = Convert.ToInt32(row.Cells["appointment_id"].Value);

                DateTime date = Convert.ToDateTime(row.Cells["Date"].Value);
                TimeSpan time = TimeSpan.Parse(row.Cells["Time"].Value.ToString());

                appointmenrDatePicker.Value = date;
                // set combo box using helper so it matches "3:00 PM" style items
                SelectTimeInCombo(DateTime.Today.Add(time).ToString("h:mm tt", CultureInfo.CurrentCulture));

                string doctorName = row.Cells["Doctor"].Value.ToString();
                string serviceName = row.Cells["Service"].Value.ToString();

                AvailableDoctorsComboBox.SelectedIndex = AvailableDoctorsComboBox.FindStringExact(doctorName);
                ServicecomboBox.SelectedIndex = ServicecomboBox.FindStringExact(serviceName);

                MessageBox.Show("Appointment details loaded. Change date/time and press Book to reschedule.");
            }
        }
        public class DoctorItem
        {
            public int DoctorId { get; set; }
            public string FullName { get; set; }

            public override string ToString()
            {
                return FullName;
            }
        }
        private int selectedAppointmentId = -1; // set when user clicks a row in the DataGridView

        // --- NEW/CHANGED: helper checks for availability & bookings used by bookbtn_Click ---

        private bool IsServiceAvailable(int serviceId)
        {
            const string sql = "SELECT status FROM Services WHERE service_id = @serviceId";
            try
            {
                if (con.State != ConnectionState.Open) con.Open();
                using var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@serviceId", serviceId);
                var val = cmd.ExecuteScalar();
                if (val == null || val == DBNull.Value) return false;
                var status = val.ToString();
                return !string.IsNullOrWhiteSpace(status) &&
                       (status.Equals("available", StringComparison.OrdinalIgnoreCase)
                        || status.Equals("true", StringComparison.OrdinalIgnoreCase)
                        || status.Equals("1", StringComparison.OrdinalIgnoreCase));
            }
            catch
            {
                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private bool IsDoctorOffersService(int doctorId, int serviceId)
        {
            const string sql = "SELECT COUNT(*) FROM DoctorServices WHERE doctor_id = @doctorId AND service_id = @serviceId";
            try
            {
                if (con.State != ConnectionState.Open) con.Open();
                using var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                cmd.Parameters.AddWithValue("@serviceId", serviceId);
                var res = cmd.ExecuteScalar();
                return res != null && Convert.ToInt32(res) > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private bool IsSlotAvailableForDoctor(int doctorId, DateTime date, TimeSpan time)
        {
            // Check Availability table for a matching entry that is not blocked and has status Available (or null)
            const string sql = @"
                SELECT TOP 1 is_blocked, status
                FROM Availability
                WHERE doctor_id = @doctorId AND [date] = @date AND hour_slot = @time";

            try
            {
                if (con.State != ConnectionState.Open) con.Open();
                using var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.Add("@time", SqlDbType.Time).Value = time;

                using var r = cmd.ExecuteReader();
                if (!r.Read()) return false; // no availability record -> treat as not available

                bool isBlocked = !r.IsDBNull(r.GetOrdinal("is_blocked")) && Convert.ToBoolean(r["is_blocked"]);
                var status = r.IsDBNull(r.GetOrdinal("status")) ? string.Empty : r["status"].ToString();

                if (isBlocked) return false;
                if (string.IsNullOrWhiteSpace(status)) return true;
                return status.Equals("available", StringComparison.OrdinalIgnoreCase)
                       || status.Equals("true", StringComparison.OrdinalIgnoreCase)
                       || status.Equals("1", StringComparison.OrdinalIgnoreCase);
            }
            catch
            {
                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private bool IsSlotBooked(int doctorId, DateTime date, TimeSpan time, int excludeAppointmentId = 0)
        {
            var sql = @"
                SELECT COUNT(*) FROM Appointments
                WHERE doctor_id = @doctorId
                  AND appointment_date = @date
                  AND appointment_time = @time
                  AND status != 'cancelled'";

            if (excludeAppointmentId > 0)
                sql += " AND appointment_id != @excludeId";

            try
            {
                if (con.State != ConnectionState.Open) con.Open();
                using var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.Add("@time", SqlDbType.Time).Value = time;
                if (excludeAppointmentId > 0)
                    cmd.Parameters.AddWithValue("@excludeId", excludeAppointmentId);

                var res = cmd.ExecuteScalar();
                return res != null && Convert.ToInt32(res) > 0;
            }
            catch
            {
                return true; // on error be conservative and report booked
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        // NEW helper: Treat certain appointment statuses as immutable (cannot be changed/cancelled/rescheduled)
        // Accepts various textual variants (e.g., "no-show", "no show", "noshow", "completed", "cancelled")
        private bool TryGetImmutableStatusDisplay(string rawStatus, out string display)
        {
            display = null;
            if (string.IsNullOrWhiteSpace(rawStatus)) return false;

            string s = rawStatus.Trim().ToLowerInvariant();
            // normalize by removing spaces and dashes for comparison
            string normalized = new string(s.Where(c => c != ' ' && c != '-').ToArray());

            if (normalized == "cancelled" || normalized == "cancel")
            {
                display = "Cancelled";
                return true;
            }

            if (normalized == "noshow" || normalized == "no") // "no" unlikely but safe to ignore
            {
                display = "No-show";
                return true;
            }

            if (normalized == "completed" || normalized == "complete")
            {
                display = "Completed";
                return true;
            }

            return false;
        }

        // --- END helpers ---

        private void bookbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (AvailableDoctorsComboBox.SelectedItem is not DoctorItem selectedDoctor ||
                    ServicecomboBox.SelectedItem is not ComboBoxItem selectedService)
                {
                    MessageBox.Show("Please select a doctor and service.");
                    return;
                }

                DateTime fullAppointmentDateTime = GetSelectedAppointmentFromCombo();
                DateTime appointmentDate = fullAppointmentDateTime.Date;
                TimeSpan appointmentTime = fullAppointmentDateTime.TimeOfDay;

                int doctorId = selectedDoctor.DoctorId;
                if (!int.TryParse(selectedService.Value?.ToString(), out int serviceId))
                {
                    MessageBox.Show("Invalid service selection.");
                    return;
                }

                // Validate service is currently available
                if (!IsServiceAvailable(serviceId))
                {
                    MessageBox.Show("Selected service is not available. Choose another service.");
                    return;
                }

                // Optional: verify doctor actually offers the service (defensive)
                if (!IsDoctorOffersService(doctorId, serviceId))
                {
                    MessageBox.Show("The selected doctor does not offer the selected service.");
                    return;
                }

                // Verify availability record (not blocked / status available)
                if (!IsSlotAvailableForDoctor(doctorId, appointmentDate, appointmentTime))
                {
                    MessageBox.Show("The selected time slot is not available for this doctor (blocked or no availability).");
                    return;
                }

                // Reschedule flow: check booking excluding current appointment
                if (selectedAppointmentId > 0)
                {
                    var confirm = MessageBox.Show("Do you want to reschedule this appointment?",
                                                  "Reschedule", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        if (IsSlotBooked(doctorId, appointmentDate, appointmentTime, selectedAppointmentId))
                        {
                            MessageBox.Show("This doctor is already booked at the selected time.");
                            return;
                        }

                        string updateQuery = @"
                        UPDATE Appointments
                        SET doctor_id = @doctorId,
                            service_id = @serviceId,
                            appointment_date = @date,
                            appointment_time = @time,
                            status = 'reschedule',
                            last_updated = @updated
                        WHERE appointment_id = @appointmentId";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@doctorId", doctorId);
                            updateCmd.Parameters.AddWithValue("@serviceId", serviceId);
                            updateCmd.Parameters.AddWithValue("@date", appointmentDate);
                            updateCmd.Parameters.Add("@time", SqlDbType.Time).Value = appointmentTime;
                            updateCmd.Parameters.AddWithValue("@updated", DateTime.Now);
                            updateCmd.Parameters.AddWithValue("@appointmentId", selectedAppointmentId);

                            con.Open();
                            int rows = updateCmd.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show(rows > 0 ? "Appointment rescheduled successfully!" : "Reschedule failed.");

                            if (rows > 0)
                            {
                                // Send reschedule email in background to both user and Denics
                                Task.Run(() =>
                                {
                                    try
                                    {
                                        string recipientEmail = Denics.UserAccount.GetEmail();
                                        string patientName = Denics.UserAccount.GetFirstname() + " " + Denics.UserAccount.GetSurname();
                                        string serviceName = selectedService.Text;
                                        string doctorName = selectedDoctor.FullName;
                                        DateTime apntDate = appointmentDate;
                                        string apntTime = appointmentTime.ToString(@"hh\:mm");
                                        string apntNote = "Your appointment has been rescheduled. Please review the updated date and time below. If you did not request this change, contact Denics Dental immediately.";

                                        AppointmentServices.SendRescheduleEmail(recipientEmail, patientName, serviceName, apntDate, apntTime, doctorName, apntNote);
                                    }
                                    catch
                                    {
                                        // ignore failures — do not block UI
                                    }
                                });
                            }
                        }

                        LoadUserAppointments();
                        selectedAppointmentId = -1; // reset after reschedule
                        return;
                    }
                }

                // Normal booking flow: check existing bookings
                if (IsSlotBooked(doctorId, appointmentDate, appointmentTime))
                {
                    MessageBox.Show("This doctor is already booked at the selected time.");
                    return;
                }

                string insertQuery = @"
                INSERT INTO Appointments 
                (user_id, doctor_id, service_id, appointment_date, appointment_time, status, date_created, last_updated)
                VALUES 
                (@userId, @doctorId, @serviceId, @appointmentDate, @appointmentTime, @status, @created, @updated)";

                using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                {
                    insertCmd.Parameters.AddWithValue("@userId", userId);
                    insertCmd.Parameters.AddWithValue("@doctorId", doctorId);
                    insertCmd.Parameters.AddWithValue("@serviceId", serviceId);
                    insertCmd.Parameters.AddWithValue("@appointmentDate", appointmentDate);
                    insertCmd.Parameters.Add("@appointmentTime", SqlDbType.Time).Value = appointmentTime;
                    insertCmd.Parameters.AddWithValue("@status", "pending");
                    insertCmd.Parameters.AddWithValue("@created", DateTime.Now);
                    insertCmd.Parameters.AddWithValue("@updated", DateTime.Now);

                    con.Open();
                    int rows = insertCmd.ExecuteNonQuery();
                    con.Close();

                    if (rows > 0)
                    {

                        // Refresh UI first
                        LoadUserAppointments();

                        // Prepare email details
                        string recipientEmail = Denics.UserAccount.GetEmail();
                        string patientName = Denics.UserAccount.GetFirstname() + " " + Denics.UserAccount.GetSurname();
                        string serviceName = selectedService.Text;
                        string doctorName = selectedDoctor.FullName;
                        DateTime apntDate = appointmentDate;
                        string apntTime = appointmentTime.ToString(@"hh\:mm");
                        string apntNote = string.Empty; // no notes control — keep empty or populate if you add one

                        // Send pending confirmation email in background to avoid blocking UI
                        Task.Run(() =>
                        {

                            try
                            {
                                AppointmentServices.SendPendingEmail(recipientEmail, patientName, serviceName, apntDate, apntTime, doctorName, apntNote);
                            }
                            catch (Exception ex)
                            {
                                // marshal back to UI thread for the message
                                try { this.Invoke(() => MessageBox.Show("Failed to send confirmation email: " + ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)); } catch { }
                            }
                        });

                        MessageBox.Show("Appointment booked successfully! A confirmation email will be sent shortly.");
                    }
                    else
                    {
                        MessageBox.Show("Booking failed.");
                    }
                }

                LoadUserAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving appointment: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private void ViewCalendar_btn_Click(object sender, EventArgs e)
        {
            Calendar cal = new Calendar();
            cal.Show();
            this.Hide();
        }
    }
}