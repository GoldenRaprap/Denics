namespace Denics.UserInterface
{
    partial class UserBookingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ServicecomboBox = new ComboBox();
            TimeofAppointmentcomboBox = new ComboBox();
            AvailableDoctorsComboBox = new ComboBox();
            labelService = new Label();
            Check = new Button();
            AppointmentDataGridView = new DataGridView();
            bookbtn = new Button();
            appointmenrDatePicker = new DateTimePicker();
            label1 = new Label();
            SideBarBackground = new Panel();
            HomeButton = new Panel();
            ServicesButton = new Panel();
            AvailabilityButton = new Panel();
            AppointmentButton = new Panel();
            PatientButton = new Panel();
            DoctorButton = new Panel();
            panel2 = new Panel();
            Bookinglbl = new Label();
            userName_txtbx = new TextBox();
            Info_lbl = new Label();
            Birthdate_txtbx = new TextBox();
            Contact_txtbx = new TextBox();
            Address_txtbx = new TextBox();
            Info_sctn = new Panel();
            Service_sctn = new Panel();
            Reschedule_Title = new Label();
            ReschedeInfo = new Label();
            Info_panel = new TableLayoutPanel();
            Cancel_lbl = new Label();
            label2 = new Label();
            label3 = new Label();
            ViewCalendar_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)AppointmentDataGridView).BeginInit();
            SideBarBackground.SuspendLayout();
            panel2.SuspendLayout();
            Info_sctn.SuspendLayout();
            Service_sctn.SuspendLayout();
            Info_panel.SuspendLayout();
            SuspendLayout();
            // 
            // ServicecomboBox
            // 
            ServicecomboBox.FormattingEnabled = true;
            ServicecomboBox.Location = new Point(16, 47);
            ServicecomboBox.Margin = new Padding(3, 2, 3, 2);
            ServicecomboBox.Name = "ServicecomboBox";
            ServicecomboBox.Size = new Size(251, 23);
            ServicecomboBox.TabIndex = 13;
            ServicecomboBox.Text = "Service";
            // 
            // TimeofAppointmentcomboBox
            // 
            TimeofAppointmentcomboBox.FormattingEnabled = true;
            TimeofAppointmentcomboBox.Location = new Point(16, 138);
            TimeofAppointmentcomboBox.Margin = new Padding(3, 2, 3, 2);
            TimeofAppointmentcomboBox.Name = "TimeofAppointmentcomboBox";
            TimeofAppointmentcomboBox.Size = new Size(251, 23);
            TimeofAppointmentcomboBox.TabIndex = 14;
            TimeofAppointmentcomboBox.Text = "Time of Appointment";
            // 
            // AvailableDoctorsComboBox
            // 
            AvailableDoctorsComboBox.FormattingEnabled = true;
            AvailableDoctorsComboBox.Location = new Point(16, 222);
            AvailableDoctorsComboBox.Margin = new Padding(3, 2, 3, 2);
            AvailableDoctorsComboBox.Name = "AvailableDoctorsComboBox";
            AvailableDoctorsComboBox.Size = new Size(251, 23);
            AvailableDoctorsComboBox.TabIndex = 16;
            AvailableDoctorsComboBox.Text = "Preferred Doctor";
            // 
            // labelService
            // 
            labelService.AutoSize = true;
            labelService.Location = new Point(16, 19);
            labelService.Name = "labelService";
            labelService.Size = new Size(50, 15);
            labelService.TabIndex = 17;
            labelService.Text = "Service: ";
            // 
            // Check
            // 
            Check.BackColor = SystemColors.ControlLightLight;
            Check.Location = new Point(16, 167);
            Check.Margin = new Padding(3, 2, 3, 2);
            Check.Name = "Check";
            Check.Size = new Size(251, 26);
            Check.TabIndex = 19;
            Check.Text = "Check";
            Check.UseVisualStyleBackColor = false;
            Check.Click += Check_Click;
            // 
            // AppointmentDataGridView
            // 
            AppointmentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AppointmentDataGridView.Location = new Point(95, 480);
            AppointmentDataGridView.Margin = new Padding(3, 2, 3, 2);
            AppointmentDataGridView.Name = "AppointmentDataGridView";
            AppointmentDataGridView.RowHeadersWidth = 51;
            AppointmentDataGridView.Size = new Size(628, 150);
            AppointmentDataGridView.TabIndex = 20;
            AppointmentDataGridView.CellContentClick += AppointmentDataGridView_CellContentClick;
            // 
            // bookbtn
            // 
            bookbtn.BackColor = Color.CornflowerBlue;
            bookbtn.Cursor = Cursors.Hand;
            bookbtn.Font = new Font("Sitka Text", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookbtn.ForeColor = Color.White;
            bookbtn.Location = new Point(418, 397);
            bookbtn.Margin = new Padding(3, 2, 3, 2);
            bookbtn.Name = "bookbtn";
            bookbtn.Size = new Size(305, 48);
            bookbtn.TabIndex = 21;
            bookbtn.Text = "Book";
            bookbtn.UseVisualStyleBackColor = false;
            bookbtn.Click += bookbtn_Click;
            // 
            // appointmenrDatePicker
            // 
            appointmenrDatePicker.Format = DateTimePickerFormat.Short;
            appointmenrDatePicker.Location = new Point(16, 109);
            appointmenrDatePicker.Margin = new Padding(3, 2, 3, 2);
            appointmenrDatePicker.Name = "appointmenrDatePicker";
            appointmenrDatePicker.Size = new Size(251, 23);
            appointmenrDatePicker.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 81);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 23;
            label1.Text = "Appointment:";
            // 
            // SideBarBackground
            // 
            SideBarBackground.BackColor = Color.CornflowerBlue;
            SideBarBackground.Controls.Add(HomeButton);
            SideBarBackground.Controls.Add(ServicesButton);
            SideBarBackground.Controls.Add(AvailabilityButton);
            SideBarBackground.Controls.Add(AppointmentButton);
            SideBarBackground.Controls.Add(PatientButton);
            SideBarBackground.Controls.Add(DoctorButton);
            SideBarBackground.Dock = DockStyle.Left;
            SideBarBackground.Location = new Point(0, 0);
            SideBarBackground.Name = "SideBarBackground";
            SideBarBackground.Size = new Size(75, 661);
            SideBarBackground.TabIndex = 24;
            // 
            // HomeButton
            // 
            HomeButton.BackgroundImage = Properties.Resources.IconWhiteHome;
            HomeButton.BackgroundImageLayout = ImageLayout.Stretch;
            HomeButton.Cursor = Cursors.Hand;
            HomeButton.Location = new Point(16, 16);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(40, 40);
            HomeButton.TabIndex = 2;
            // 
            // ServicesButton
            // 
            ServicesButton.BackgroundImage = Properties.Resources.IconService;
            ServicesButton.BackgroundImageLayout = ImageLayout.Stretch;
            ServicesButton.Cursor = Cursors.Hand;
            ServicesButton.Location = new Point(16, 303);
            ServicesButton.Name = "ServicesButton";
            ServicesButton.Size = new Size(40, 40);
            ServicesButton.TabIndex = 2;
            // 
            // AvailabilityButton
            // 
            AvailabilityButton.BackgroundImage = Properties.Resources.Iconcalendar;
            AvailabilityButton.BackgroundImageLayout = ImageLayout.Stretch;
            AvailabilityButton.Cursor = Cursors.Hand;
            AvailabilityButton.Location = new Point(16, 211);
            AvailabilityButton.Name = "AvailabilityButton";
            AvailabilityButton.Size = new Size(40, 40);
            AvailabilityButton.TabIndex = 2;
            // 
            // AppointmentButton
            // 
            AppointmentButton.BackgroundImage = Properties.Resources.IconBook;
            AppointmentButton.BackgroundImageLayout = ImageLayout.Stretch;
            AppointmentButton.Cursor = Cursors.Hand;
            AppointmentButton.Location = new Point(16, 165);
            AppointmentButton.Name = "AppointmentButton";
            AppointmentButton.Size = new Size(40, 40);
            AppointmentButton.TabIndex = 1;
            // 
            // PatientButton
            // 
            PatientButton.BackgroundImage = Properties.Resources.IconPatient;
            PatientButton.BackgroundImageLayout = ImageLayout.Stretch;
            PatientButton.Cursor = Cursors.Hand;
            PatientButton.Location = new Point(16, 119);
            PatientButton.Name = "PatientButton";
            PatientButton.Size = new Size(40, 40);
            PatientButton.TabIndex = 1;
            // 
            // DoctorButton
            // 
            DoctorButton.BackgroundImage = Properties.Resources.IconDoctor;
            DoctorButton.BackgroundImageLayout = ImageLayout.Stretch;
            DoctorButton.Cursor = Cursors.Hand;
            DoctorButton.Location = new Point(16, 257);
            DoctorButton.Name = "DoctorButton";
            DoctorButton.Size = new Size(40, 40);
            DoctorButton.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(Bookinglbl);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(75, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(909, 65);
            panel2.TabIndex = 25;
            // 
            // Bookinglbl
            // 
            Bookinglbl.AutoSize = true;
            Bookinglbl.Font = new Font("Sitka Subheading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Bookinglbl.ForeColor = SystemColors.ControlLight;
            Bookinglbl.Location = new Point(20, 7);
            Bookinglbl.Name = "Bookinglbl";
            Bookinglbl.Size = new Size(134, 47);
            Bookinglbl.TabIndex = 1;
            Bookinglbl.Text = "Booking";
            // 
            // userName_txtbx
            // 
            userName_txtbx.Location = new Point(16, 49);
            userName_txtbx.Name = "userName_txtbx";
            userName_txtbx.ReadOnly = true;
            userName_txtbx.Size = new Size(251, 23);
            userName_txtbx.TabIndex = 26;
            // 
            // Info_lbl
            // 
            Info_lbl.AutoSize = true;
            Info_lbl.Location = new Point(16, 19);
            Info_lbl.Name = "Info_lbl";
            Info_lbl.Size = new Size(96, 15);
            Info_lbl.TabIndex = 27;
            Info_lbl.Text = "User Information";
            // 
            // Birthdate_txtbx
            // 
            Birthdate_txtbx.Location = new Point(16, 93);
            Birthdate_txtbx.Name = "Birthdate_txtbx";
            Birthdate_txtbx.ReadOnly = true;
            Birthdate_txtbx.Size = new Size(251, 23);
            Birthdate_txtbx.TabIndex = 28;
            // 
            // Contact_txtbx
            // 
            Contact_txtbx.Location = new Point(16, 136);
            Contact_txtbx.Name = "Contact_txtbx";
            Contact_txtbx.ReadOnly = true;
            Contact_txtbx.Size = new Size(251, 23);
            Contact_txtbx.TabIndex = 29;
            // 
            // Address_txtbx
            // 
            Address_txtbx.Location = new Point(16, 176);
            Address_txtbx.Multiline = true;
            Address_txtbx.Name = "Address_txtbx";
            Address_txtbx.ReadOnly = true;
            Address_txtbx.Size = new Size(251, 69);
            Address_txtbx.TabIndex = 30;
            // 
            // Info_sctn
            // 
            Info_sctn.BackColor = SystemColors.ControlLight;
            Info_sctn.Controls.Add(Info_lbl);
            Info_sctn.Controls.Add(Address_txtbx);
            Info_sctn.Controls.Add(userName_txtbx);
            Info_sctn.Controls.Add(Contact_txtbx);
            Info_sctn.Controls.Add(Birthdate_txtbx);
            Info_sctn.Location = new Point(95, 94);
            Info_sctn.Name = "Info_sctn";
            Info_sctn.Size = new Size(305, 269);
            Info_sctn.TabIndex = 31;
            // 
            // Service_sctn
            // 
            Service_sctn.BackColor = SystemColors.ControlLight;
            Service_sctn.Controls.Add(labelService);
            Service_sctn.Controls.Add(ServicecomboBox);
            Service_sctn.Controls.Add(TimeofAppointmentcomboBox);
            Service_sctn.Controls.Add(AvailableDoctorsComboBox);
            Service_sctn.Controls.Add(label1);
            Service_sctn.Controls.Add(Check);
            Service_sctn.Controls.Add(appointmenrDatePicker);
            Service_sctn.Location = new Point(418, 94);
            Service_sctn.Name = "Service_sctn";
            Service_sctn.Size = new Size(305, 269);
            Service_sctn.TabIndex = 32;
            // 
            // Reschedule_Title
            // 
            Reschedule_Title.Anchor = AnchorStyles.Left;
            Reschedule_Title.AutoSize = true;
            Reschedule_Title.Location = new Point(23, 22);
            Reschedule_Title.Name = "Reschedule_Title";
            Reschedule_Title.Size = new Size(79, 15);
            Reschedule_Title.TabIndex = 33;
            Reschedule_Title.Text = "To Reschdule:";
            // 
            // ReschedeInfo
            // 
            ReschedeInfo.AllowDrop = true;
            ReschedeInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ReschedeInfo.AutoSize = true;
            ReschedeInfo.Location = new Point(23, 40);
            ReschedeInfo.Name = "ReschedeInfo";
            ReschedeInfo.Size = new Size(171, 60);
            ReschedeInfo.TabIndex = 34;
            ReschedeInfo.Text = "To reschedule, select already existing appoinment. Reselect the desired changes on the service section. ";
            // 
            // Info_panel
            // 
            Info_panel.BackColor = SystemColors.ControlLight;
            Info_panel.ColumnCount = 3;
            Info_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Info_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Info_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Info_panel.Controls.Add(Reschedule_Title, 1, 1);
            Info_panel.Controls.Add(ReschedeInfo, 1, 2);
            Info_panel.Controls.Add(Cancel_lbl, 1, 3);
            Info_panel.Controls.Add(label2, 1, 4);
            Info_panel.Controls.Add(label3, 1, 6);
            Info_panel.Location = new Point(755, 94);
            Info_panel.Name = "Info_panel";
            Info_panel.RowCount = 8;
            Info_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Info_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Info_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Info_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Info_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Info_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Info_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Info_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Info_panel.Size = new Size(217, 536);
            Info_panel.TabIndex = 35;
            // 
            // Cancel_lbl
            // 
            Cancel_lbl.Anchor = AnchorStyles.Left;
            Cancel_lbl.AutoSize = true;
            Cancel_lbl.Location = new Point(23, 187);
            Cancel_lbl.Name = "Cancel_lbl";
            Cancel_lbl.Size = new Size(61, 15);
            Cancel_lbl.TabIndex = 35;
            Cancel_lbl.Text = "To Cancel:";
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(23, 205);
            label2.Name = "label2";
            label2.Size = new Size(171, 45);
            label2.TabIndex = 36;
            label2.Text = "To cancel, click the cancel button on the side of the section.";
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(23, 370);
            label3.Name = "label3";
            label3.Size = new Size(171, 60);
            label3.TabIndex = 37;
            label3.Text = "NOTE: Making a cancellation and reschedule must be 48 hours before original appointment.";
            // 
            // ViewCalendar_btn
            // 
            ViewCalendar_btn.BackColor = Color.CornflowerBlue;
            ViewCalendar_btn.Cursor = Cursors.Hand;
            ViewCalendar_btn.Font = new Font("Sitka Text", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViewCalendar_btn.ForeColor = Color.White;
            ViewCalendar_btn.Location = new Point(95, 397);
            ViewCalendar_btn.Margin = new Padding(3, 2, 3, 2);
            ViewCalendar_btn.Name = "ViewCalendar_btn";
            ViewCalendar_btn.Size = new Size(305, 48);
            ViewCalendar_btn.TabIndex = 36;
            ViewCalendar_btn.Text = "Veiw Available Schedule";
            ViewCalendar_btn.UseVisualStyleBackColor = false;
            ViewCalendar_btn.Click += ViewCalendar_btn_Click;
            // 
            // UserBookingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(ViewCalendar_btn);
            Controls.Add(Info_panel);
            Controls.Add(Service_sctn);
            Controls.Add(Info_sctn);
            Controls.Add(panel2);
            Controls.Add(SideBarBackground);
            Controls.Add(bookbtn);
            Controls.Add(AppointmentDataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserBookingPage";
            Text = "UserBookingPage";
            Load += UserBookingPage_Load;
            ((System.ComponentModel.ISupportInitialize)AppointmentDataGridView).EndInit();
            SideBarBackground.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Info_sctn.ResumeLayout(false);
            Info_sctn.PerformLayout();
            Service_sctn.ResumeLayout(false);
            Service_sctn.PerformLayout();
            Info_panel.ResumeLayout(false);
            Info_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox ServicecomboBox;
        private ComboBox TimeofAppointmentcomboBox;
        private ComboBox AvailableDoctorsComboBox;
        private Label labelService;
        private Button Check;
        private DataGridView AppointmentDataGridView;
        private Button bookbtn;
        private DateTimePicker appointmenrDatePicker;
        private Label label1;
        private Panel SideBarBackground;
        private Panel HomeButton;
        private Panel ServicesButton;
        private Panel AvailabilityButton;
        private Panel AppointmentButton;
        private Panel PatientButton;
        private Panel DoctorButton;
        private Panel panel2;
        private Label Bookinglbl;
        private TextBox userName_txtbx;
        private Label Info_lbl;
        private TextBox Birthdate_txtbx;
        private TextBox Contact_txtbx;
        private TextBox Address_txtbx;
        private Panel Info_sctn;
        private Panel Service_sctn;
        private Label Reschedule_Title;
        private Label ReschedeInfo;
        private TableLayoutPanel Info_panel;
        private Label Cancel_lbl;
        private Label label2;
        private Label label3;
        private Button ViewCalendar_btn;
    }
}