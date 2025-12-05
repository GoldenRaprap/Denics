namespace Denics.UserInterface
{
    partial class HomePage
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
            Welcome_pnl = new Panel();
            Username_lbl = new Label();
            DoctorButton = new Panel();
            PatientButton = new Panel();
            AppointmentButton = new Panel();
            AvailabilityButton = new Panel();
            ServicesButton = new Panel();
            HomeButton = new Panel();
            Exit_pnl = new Panel();
            Exit_btn = new Panel();
            SideBarBackground = new Panel();
            TopHeader = new Panel();
            Top_lbl = new Label();
            Services_pnl = new Panel();
            Service_lbl = new Label();
            Service_pnl_img = new Panel();
            backViewAppointments_pnl = new Panel();
            ViewAppointment_lbl = new Label();
            Booking_pnl_img = new Panel();
            Schedule_pnl = new Panel();
            Schedulepanel_lbl = new Label();
            Schedule_pnl_img = new Panel();
            Doctors_pnl = new Panel();
            Doctorpanel_lbl = new Label();
            Doctor_pnl_img = new Panel();
            User_Panel = new Panel();
            User_lbl = new Label();
            User_pnl_img = new Panel();
            UserAppointments = new DataGridView();
            Appontment_pbl = new Panel();
            YourAppontment_lbl = new Label();
            Logo = new PictureBox();
            Welcome_pnl.SuspendLayout();
            Exit_pnl.SuspendLayout();
            SideBarBackground.SuspendLayout();
            TopHeader.SuspendLayout();
            Services_pnl.SuspendLayout();
            backViewAppointments_pnl.SuspendLayout();
            Schedule_pnl.SuspendLayout();
            Doctors_pnl.SuspendLayout();
            User_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserAppointments).BeginInit();
            Appontment_pbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Welcome_pnl
            // 
            Welcome_pnl.BackColor = Color.CornflowerBlue;
            Welcome_pnl.Controls.Add(Username_lbl);
            Welcome_pnl.Location = new Point(95, 84);
            Welcome_pnl.Name = "Welcome_pnl";
            Welcome_pnl.Size = new Size(428, 61);
            Welcome_pnl.TabIndex = 3;
            // 
            // Username_lbl
            // 
            Username_lbl.AutoSize = true;
            Username_lbl.Font = new Font("Sitka Subheading", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username_lbl.ForeColor = Color.White;
            Username_lbl.Location = new Point(14, 9);
            Username_lbl.Name = "Username_lbl";
            Username_lbl.Size = new Size(264, 39);
            Username_lbl.TabIndex = 1;
            Username_lbl.Text = "Welcome, username!";
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
            // Exit_pnl
            // 
            Exit_pnl.Controls.Add(Exit_btn);
            Exit_pnl.Dock = DockStyle.Bottom;
            Exit_pnl.Location = new Point(0, 592);
            Exit_pnl.Name = "Exit_pnl";
            Exit_pnl.Size = new Size(75, 69);
            Exit_pnl.TabIndex = 9;
            // 
            // Exit_btn
            // 
            Exit_btn.Anchor = AnchorStyles.Top;
            Exit_btn.BackgroundImage = Properties.Resources.IconLogout;
            Exit_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Exit_btn.Cursor = Cursors.Hand;
            Exit_btn.Location = new Point(16, 17);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(40, 40);
            Exit_btn.TabIndex = 8;
            Exit_btn.Click += Logout_btn_Click;
            // 
            // SideBarBackground
            // 
            SideBarBackground.BackColor = Color.CornflowerBlue;
            SideBarBackground.Controls.Add(Exit_pnl);
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
            SideBarBackground.TabIndex = 25;
            // 
            // TopHeader
            // 
            TopHeader.BackColor = Color.RoyalBlue;
            TopHeader.Controls.Add(Top_lbl);
            TopHeader.Dock = DockStyle.Top;
            TopHeader.Location = new Point(75, 0);
            TopHeader.Name = "TopHeader";
            TopHeader.Size = new Size(909, 65);
            TopHeader.TabIndex = 26;
            // 
            // Top_lbl
            // 
            Top_lbl.AutoSize = true;
            Top_lbl.Font = new Font("Sitka Subheading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Top_lbl.ForeColor = SystemColors.ControlLight;
            Top_lbl.Location = new Point(20, 9);
            Top_lbl.Name = "Top_lbl";
            Top_lbl.Size = new Size(102, 47);
            Top_lbl.TabIndex = 0;
            Top_lbl.Text = "Home";
            // 
            // Services_pnl
            // 
            Services_pnl.BackColor = Color.RoyalBlue;
            Services_pnl.Controls.Add(Service_lbl);
            Services_pnl.Controls.Add(Service_pnl_img);
            Services_pnl.Cursor = Cursors.Hand;
            Services_pnl.Location = new Point(95, 485);
            Services_pnl.Name = "Services_pnl";
            Services_pnl.Size = new Size(246, 69);
            Services_pnl.TabIndex = 28;
            Services_pnl.Click += ServicesButton_Click;
            // 
            // Service_lbl
            // 
            Service_lbl.AutoSize = true;
            Service_lbl.Font = new Font("Sitka Subheading", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Service_lbl.ForeColor = SystemColors.ControlLight;
            Service_lbl.Location = new Point(69, 11);
            Service_lbl.Name = "Service_lbl";
            Service_lbl.Size = new Size(115, 39);
            Service_lbl.TabIndex = 3;
            Service_lbl.Text = "Services";
            Service_lbl.Click += ServicesButton_Click;
            // 
            // Service_pnl_img
            // 
            Service_pnl_img.BackColor = Color.CornflowerBlue;
            Service_pnl_img.BackgroundImage = Properties.Resources.IconService;
            Service_pnl_img.BackgroundImageLayout = ImageLayout.Stretch;
            Service_pnl_img.Location = new Point(3, 3);
            Service_pnl_img.Name = "Service_pnl_img";
            Service_pnl_img.Size = new Size(63, 63);
            Service_pnl_img.TabIndex = 2;
            Service_pnl_img.Click += ServicesButton_Click;
            // 
            // backViewAppointments_pnl
            // 
            backViewAppointments_pnl.BackColor = Color.RoyalBlue;
            backViewAppointments_pnl.Controls.Add(ViewAppointment_lbl);
            backViewAppointments_pnl.Controls.Add(Booking_pnl_img);
            backViewAppointments_pnl.Cursor = Cursors.Hand;
            backViewAppointments_pnl.Location = new Point(95, 165);
            backViewAppointments_pnl.Name = "backViewAppointments_pnl";
            backViewAppointments_pnl.Size = new Size(428, 69);
            backViewAppointments_pnl.TabIndex = 29;
            backViewAppointments_pnl.Click += AppointmentButton_Click;
            // 
            // ViewAppointment_lbl
            // 
            ViewAppointment_lbl.AutoSize = true;
            ViewAppointment_lbl.Font = new Font("Sitka Subheading", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViewAppointment_lbl.ForeColor = SystemColors.ControlLight;
            ViewAppointment_lbl.Location = new Point(72, 11);
            ViewAppointment_lbl.Name = "ViewAppointment_lbl";
            ViewAppointment_lbl.Size = new Size(247, 39);
            ViewAppointment_lbl.TabIndex = 3;
            ViewAppointment_lbl.Text = "View Appointments";
            ViewAppointment_lbl.Click += AppointmentButton_Click;
            // 
            // Booking_pnl_img
            // 
            Booking_pnl_img.BackColor = Color.CornflowerBlue;
            Booking_pnl_img.BackgroundImage = Properties.Resources.IconBook;
            Booking_pnl_img.BackgroundImageLayout = ImageLayout.Stretch;
            Booking_pnl_img.Location = new Point(3, 3);
            Booking_pnl_img.Name = "Booking_pnl_img";
            Booking_pnl_img.Size = new Size(63, 63);
            Booking_pnl_img.TabIndex = 2;
            Booking_pnl_img.Click += AppointmentButton_Click;
            // 
            // Schedule_pnl
            // 
            Schedule_pnl.BackColor = Color.RoyalBlue;
            Schedule_pnl.Controls.Add(Schedulepanel_lbl);
            Schedule_pnl.Controls.Add(Schedule_pnl_img);
            Schedule_pnl.Cursor = Cursors.Hand;
            Schedule_pnl.Location = new Point(95, 240);
            Schedule_pnl.Name = "Schedule_pnl";
            Schedule_pnl.Size = new Size(428, 69);
            Schedule_pnl.TabIndex = 30;
            Schedule_pnl.Click += AvailabilityButton_Click;
            // 
            // Schedulepanel_lbl
            // 
            Schedulepanel_lbl.AutoSize = true;
            Schedulepanel_lbl.Font = new Font("Sitka Subheading", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Schedulepanel_lbl.ForeColor = SystemColors.ControlLight;
            Schedulepanel_lbl.Location = new Point(69, 11);
            Schedulepanel_lbl.Name = "Schedulepanel_lbl";
            Schedulepanel_lbl.Size = new Size(122, 39);
            Schedulepanel_lbl.TabIndex = 3;
            Schedulepanel_lbl.Text = "Schedule";
            Schedulepanel_lbl.Click += AvailabilityButton_Click;
            // 
            // Schedule_pnl_img
            // 
            Schedule_pnl_img.BackColor = Color.CornflowerBlue;
            Schedule_pnl_img.BackgroundImage = Properties.Resources.Iconcalendar;
            Schedule_pnl_img.BackgroundImageLayout = ImageLayout.Stretch;
            Schedule_pnl_img.Location = new Point(3, 3);
            Schedule_pnl_img.Name = "Schedule_pnl_img";
            Schedule_pnl_img.Size = new Size(63, 63);
            Schedule_pnl_img.TabIndex = 2;
            Schedule_pnl_img.Click += AvailabilityButton_Click;
            // 
            // Doctors_pnl
            // 
            Doctors_pnl.BackColor = Color.RoyalBlue;
            Doctors_pnl.Controls.Add(Doctorpanel_lbl);
            Doctors_pnl.Controls.Add(Doctor_pnl_img);
            Doctors_pnl.Cursor = Cursors.Hand;
            Doctors_pnl.Location = new Point(95, 560);
            Doctors_pnl.Name = "Doctors_pnl";
            Doctors_pnl.Size = new Size(246, 69);
            Doctors_pnl.TabIndex = 31;
            Doctors_pnl.Click += DoctorButton_Click;
            // 
            // Doctorpanel_lbl
            // 
            Doctorpanel_lbl.AutoSize = true;
            Doctorpanel_lbl.Font = new Font("Sitka Subheading", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Doctorpanel_lbl.ForeColor = SystemColors.ControlLight;
            Doctorpanel_lbl.Location = new Point(69, 11);
            Doctorpanel_lbl.Name = "Doctorpanel_lbl";
            Doctorpanel_lbl.Size = new Size(108, 39);
            Doctorpanel_lbl.TabIndex = 3;
            Doctorpanel_lbl.Text = "Doctors";
            Doctorpanel_lbl.Click += DoctorButton_Click;
            // 
            // Doctor_pnl_img
            // 
            Doctor_pnl_img.BackColor = Color.CornflowerBlue;
            Doctor_pnl_img.BackgroundImage = Properties.Resources.IconDoctor;
            Doctor_pnl_img.BackgroundImageLayout = ImageLayout.Stretch;
            Doctor_pnl_img.Location = new Point(3, 3);
            Doctor_pnl_img.Name = "Doctor_pnl_img";
            Doctor_pnl_img.Size = new Size(63, 63);
            Doctor_pnl_img.TabIndex = 2;
            Doctor_pnl_img.Click += DoctorButton_Click;
            // 
            // User_Panel
            // 
            User_Panel.BackColor = Color.RoyalBlue;
            User_Panel.Controls.Add(User_lbl);
            User_Panel.Controls.Add(User_pnl_img);
            User_Panel.Cursor = Cursors.Hand;
            User_Panel.Location = new Point(95, 408);
            User_Panel.Name = "User_Panel";
            User_Panel.Size = new Size(246, 69);
            User_Panel.TabIndex = 27;
            User_Panel.Click += PatientButton_Click;
            // 
            // User_lbl
            // 
            User_lbl.AutoSize = true;
            User_lbl.Font = new Font("Sitka Subheading", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            User_lbl.ForeColor = SystemColors.ControlLight;
            User_lbl.Location = new Point(69, 11);
            User_lbl.Name = "User_lbl";
            User_lbl.Size = new Size(96, 39);
            User_lbl.TabIndex = 3;
            User_lbl.Text = "Profile";
            User_lbl.Click += PatientButton_Click;
            // 
            // User_pnl_img
            // 
            User_pnl_img.BackColor = Color.CornflowerBlue;
            User_pnl_img.BackgroundImage = Properties.Resources.IconPatient;
            User_pnl_img.BackgroundImageLayout = ImageLayout.Stretch;
            User_pnl_img.Location = new Point(3, 3);
            User_pnl_img.Name = "User_pnl_img";
            User_pnl_img.Size = new Size(63, 63);
            User_pnl_img.TabIndex = 2;
            User_pnl_img.Click += PatientButton_Click;
            // 
            // UserAppointments
            // 
            UserAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserAppointments.Location = new Point(402, 408);
            UserAppointments.Name = "UserAppointments";
            UserAppointments.Size = new Size(553, 221);
            UserAppointments.TabIndex = 32;
            // 
            // Appontment_pbl
            // 
            Appontment_pbl.BackColor = Color.CornflowerBlue;
            Appontment_pbl.Controls.Add(YourAppontment_lbl);
            Appontment_pbl.Location = new Point(562, 338);
            Appontment_pbl.Name = "Appontment_pbl";
            Appontment_pbl.Size = new Size(393, 61);
            Appontment_pbl.TabIndex = 4;
            // 
            // YourAppontment_lbl
            // 
            YourAppontment_lbl.AutoSize = true;
            YourAppontment_lbl.Font = new Font("Sitka Subheading", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YourAppontment_lbl.ForeColor = Color.White;
            YourAppontment_lbl.Location = new Point(78, 10);
            YourAppontment_lbl.Name = "YourAppontment_lbl";
            YourAppontment_lbl.Size = new Size(244, 39);
            YourAppontment_lbl.TabIndex = 1;
            YourAppontment_lbl.Text = "Your Appointments";
            YourAppontment_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Logo
            // 
            Logo.BackColor = Color.CornflowerBlue;
            Logo.BackgroundImage = Properties.Resources.Logo__no_bg___Denics;
            Logo.BackgroundImageLayout = ImageLayout.Zoom;
            Logo.Location = new Point(562, 84);
            Logo.Name = "Logo";
            Logo.Size = new Size(393, 225);
            Logo.TabIndex = 33;
            Logo.TabStop = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(Logo);
            Controls.Add(Appontment_pbl);
            Controls.Add(UserAppointments);
            Controls.Add(Services_pnl);
            Controls.Add(backViewAppointments_pnl);
            Controls.Add(Schedule_pnl);
            Controls.Add(Doctors_pnl);
            Controls.Add(User_Panel);
            Controls.Add(TopHeader);
            Controls.Add(SideBarBackground);
            Controls.Add(Welcome_pnl);
            Name = "HomePage";
            Text = "Homepage";
            Load += HomePage_Load;
            Welcome_pnl.ResumeLayout(false);
            Welcome_pnl.PerformLayout();
            Exit_pnl.ResumeLayout(false);
            SideBarBackground.ResumeLayout(false);
            TopHeader.ResumeLayout(false);
            TopHeader.PerformLayout();
            Services_pnl.ResumeLayout(false);
            Services_pnl.PerformLayout();
            backViewAppointments_pnl.ResumeLayout(false);
            backViewAppointments_pnl.PerformLayout();
            Schedule_pnl.ResumeLayout(false);
            Schedule_pnl.PerformLayout();
            Doctors_pnl.ResumeLayout(false);
            Doctors_pnl.PerformLayout();
            User_Panel.ResumeLayout(false);
            User_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserAppointments).EndInit();
            Appontment_pbl.ResumeLayout(false);
            Appontment_pbl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel Welcome_pnl;
        private Label Username_lbl;
        private Panel DoctorButton;
        private Panel PatientButton;
        private Panel AppointmentButton;
        private Panel AvailabilityButton;
        private Panel ServicesButton;
        private Panel HomeButton;
        private Panel Exit_pnl;
        private Panel Exit_btn;
        private Panel SideBarBackground;
        private Panel TopHeader;
        private Label Top_lbl;
        private Panel Services_pnl;
        private Label Service_lbl;
        private Panel Service_pnl_img;
        private Panel backViewAppointments_pnl;
        private Label ViewAppointment_lbl;
        private Panel Booking_pnl_img;
        private Panel Schedule_pnl;
        private Label Schedulepanel_lbl;
        private Panel Schedule_pnl_img;
        private Panel Doctors_pnl;
        private Label Doctorpanel_lbl;
        private Panel Doctor_pnl_img;
        private Panel User_Panel;
        private Label User_lbl;
        private Panel User_pnl_img;
        private DataGridView UserAppointments;
        private Panel Appontment_pbl;
        private Label YourAppontment_lbl;
        private PictureBox Logo;
    }
}