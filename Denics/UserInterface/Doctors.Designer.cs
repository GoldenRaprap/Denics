namespace Denics.UserInterface
{
    partial class Doctors
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
            flowLayoutPanelDoctors = new FlowLayoutPanel();
            SideBarBackground = new Panel();
            HomeButton = new Panel();
            ServicesButton = new Panel();
            AvailabilityButton = new Panel();
            AppointmentButton = new Panel();
            PatientButton = new Panel();
            DoctorButton = new Panel();
            Header_pnl = new Panel();
            Header_lbl = new Label();
            SideBarBackground.SuspendLayout();
            Header_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelDoctors
            // 
            flowLayoutPanelDoctors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flowLayoutPanelDoctors.AutoScroll = true;
            flowLayoutPanelDoctors.Location = new Point(136, 119);
            flowLayoutPanelDoctors.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanelDoctors.Name = "flowLayoutPanelDoctors";
            flowLayoutPanelDoctors.Size = new Size(803, 460);
            flowLayoutPanelDoctors.TabIndex = 9;
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
            SideBarBackground.TabIndex = 105;
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
            // Header_pnl
            // 
            Header_pnl.BackColor = Color.RoyalBlue;
            Header_pnl.Controls.Add(Header_lbl);
            Header_pnl.Dock = DockStyle.Top;
            Header_pnl.Location = new Point(75, 0);
            Header_pnl.Name = "Header_pnl";
            Header_pnl.Size = new Size(909, 65);
            Header_pnl.TabIndex = 106;
            // 
            // Header_lbl
            // 
            Header_lbl.AutoSize = true;
            Header_lbl.Font = new Font("Sitka Subheading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Header_lbl.ForeColor = SystemColors.ControlLight;
            Header_lbl.Location = new Point(20, 9);
            Header_lbl.Name = "Header_lbl";
            Header_lbl.Size = new Size(129, 47);
            Header_lbl.TabIndex = 0;
            Header_lbl.Text = "Doctors";
            // 
            // Doctors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(Header_pnl);
            Controls.Add(SideBarBackground);
            Controls.Add(flowLayoutPanelDoctors);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Doctors";
            Text = "Doctors";
            Load += Doctors_Load;
            SideBarBackground.ResumeLayout(false);
            Header_pnl.ResumeLayout(false);
            Header_pnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnPrevWeek;
        private Button btnNextWeek;
        private Label lblWeekRange;
        private FlowLayoutPanel flowLayoutPanelDoctors;
        private Panel SideBarBackground;
        private Panel HomeButton;
        private Panel ServicesButton;
        private Panel AvailabilityButton;
        private Panel AppointmentButton;
        private Panel PatientButton;
        private Panel DoctorButton;
        private Panel Header_pnl;
        private Label Header_lbl;
    }
}