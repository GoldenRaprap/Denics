namespace Denics.UserInterface
{
    partial class UserProfile
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
            SideBarBackground = new Panel();
            HomeButton = new Panel();
            ServicesButton = new Panel();
            AvailabilityButton = new Panel();
            AppointmentButton = new Panel();
            PatientButton = new Panel();
            DoctorButton = new Panel();
            Header_pnl = new Panel();
            Header_lbl = new Label();
            Body_sctn = new TableLayoutPanel();
            Edit_logo = new Panel();
            Info_sctn = new TableLayoutPanel();
            TopFormInfo_pnl = new TableLayoutPanel();
            Address_pnl = new Panel();
            Address_lbl = new Label();
            Address_txtbx = new TextBox();
            conact_pnl = new Panel();
            Contactnumber_lbl = new Label();
            boxNumber = new TextBox();
            Birthday_pnl = new Panel();
            Birthdate_cldr = new DateTimePicker();
            birthday_lbl = new Label();
            Gender_pnl = new Panel();
            Female_rdbtn = new RadioButton();
            Male_rdbtn = new RadioButton();
            Gender_lbl = new Label();
            Suffix_pnl = new Panel();
            Suffix_lbl = new Label();
            Suffix_txtbx = new TextBox();
            Lastname_pnl = new Panel();
            labelLName = new Label();
            boxLName = new TextBox();
            Middlename_pnl = new Panel();
            MiddleName_lbl = new Label();
            MiddleName_txtbx = new TextBox();
            Firstname_pnl = new Panel();
            labelFName = new Label();
            boxFName = new TextBox();
            email_pnl = new TableLayoutPanel();
            panel2 = new Panel();
            Password_txtbx = new TextBox();
            changePassword_btn = new Button();
            Password_lbl = new Label();
            panel1 = new Panel();
            Email_lbl = new Label();
            boxEmail = new TextBox();
            filler = new Panel();
            Register_pnl = new TableLayoutPanel();
            GoBack_btn = new Button();
            SaveChanges_btn = new Button();
            SideBarBackground.SuspendLayout();
            Header_pnl.SuspendLayout();
            Body_sctn.SuspendLayout();
            Info_sctn.SuspendLayout();
            TopFormInfo_pnl.SuspendLayout();
            Address_pnl.SuspendLayout();
            conact_pnl.SuspendLayout();
            Birthday_pnl.SuspendLayout();
            Gender_pnl.SuspendLayout();
            Suffix_pnl.SuspendLayout();
            Lastname_pnl.SuspendLayout();
            Middlename_pnl.SuspendLayout();
            Firstname_pnl.SuspendLayout();
            email_pnl.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            Register_pnl.SuspendLayout();
            SuspendLayout();
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
            SideBarBackground.TabIndex = 26;
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
            Header_pnl.TabIndex = 27;
            // 
            // Header_lbl
            // 
            Header_lbl.AutoSize = true;
            Header_lbl.Font = new Font("Sitka Subheading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Header_lbl.ForeColor = SystemColors.ControlLight;
            Header_lbl.Location = new Point(20, 9);
            Header_lbl.Name = "Header_lbl";
            Header_lbl.Size = new Size(188, 47);
            Header_lbl.TabIndex = 0;
            Header_lbl.Text = "Your Profile";
            // 
            // Body_sctn
            // 
            Body_sctn.ColumnCount = 3;
            Body_sctn.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Body_sctn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Body_sctn.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Body_sctn.Controls.Add(Edit_logo, 1, 0);
            Body_sctn.Controls.Add(Info_sctn, 1, 1);
            Body_sctn.Controls.Add(Register_pnl, 1, 2);
            Body_sctn.Dock = DockStyle.Fill;
            Body_sctn.Location = new Point(75, 65);
            Body_sctn.Name = "Body_sctn";
            Body_sctn.RowCount = 3;
            Body_sctn.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            Body_sctn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Body_sctn.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            Body_sctn.Size = new Size(909, 596);
            Body_sctn.TabIndex = 28;
            // 
            // Edit_logo
            // 
            Edit_logo.Anchor = AnchorStyles.None;
            Edit_logo.BackColor = Color.RoyalBlue;
            Edit_logo.BackgroundImage = Properties.Resources.IconPatient;
            Edit_logo.BackgroundImageLayout = ImageLayout.Zoom;
            Edit_logo.Cursor = Cursors.Hand;
            Edit_logo.Location = new Point(230, 3);
            Edit_logo.Name = "Edit_logo";
            Edit_logo.Size = new Size(449, 69);
            Edit_logo.TabIndex = 10;
            // 
            // Info_sctn
            // 
            Info_sctn.BackColor = Color.CornflowerBlue;
            Info_sctn.ColumnCount = 3;
            Info_sctn.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Info_sctn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Info_sctn.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Info_sctn.Controls.Add(TopFormInfo_pnl, 1, 0);
            Info_sctn.Controls.Add(email_pnl, 1, 2);
            Info_sctn.Controls.Add(filler, 1, 1);
            Info_sctn.Dock = DockStyle.Fill;
            Info_sctn.Location = new Point(23, 78);
            Info_sctn.Name = "Info_sctn";
            Info_sctn.RowCount = 4;
            Info_sctn.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            Info_sctn.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            Info_sctn.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Info_sctn.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Info_sctn.Size = new Size(863, 390);
            Info_sctn.TabIndex = 0;
            // 
            // TopFormInfo_pnl
            // 
            TopFormInfo_pnl.ColumnCount = 2;
            TopFormInfo_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TopFormInfo_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TopFormInfo_pnl.Controls.Add(Address_pnl, 1, 4);
            TopFormInfo_pnl.Controls.Add(conact_pnl, 0, 4);
            TopFormInfo_pnl.Controls.Add(Birthday_pnl, 1, 3);
            TopFormInfo_pnl.Controls.Add(Gender_pnl, 0, 3);
            TopFormInfo_pnl.Controls.Add(Suffix_pnl, 1, 1);
            TopFormInfo_pnl.Controls.Add(Lastname_pnl, 0, 1);
            TopFormInfo_pnl.Controls.Add(Middlename_pnl, 1, 0);
            TopFormInfo_pnl.Controls.Add(Firstname_pnl, 0, 0);
            TopFormInfo_pnl.Dock = DockStyle.Fill;
            TopFormInfo_pnl.Location = new Point(23, 3);
            TopFormInfo_pnl.Name = "TopFormInfo_pnl";
            TopFormInfo_pnl.RowCount = 6;
            TopFormInfo_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TopFormInfo_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TopFormInfo_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TopFormInfo_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TopFormInfo_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TopFormInfo_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            TopFormInfo_pnl.Size = new Size(817, 282);
            TopFormInfo_pnl.TabIndex = 1;
            // 
            // Address_pnl
            // 
            Address_pnl.Anchor = AnchorStyles.None;
            Address_pnl.Controls.Add(Address_lbl);
            Address_pnl.Controls.Add(Address_txtbx);
            Address_pnl.Location = new Point(411, 213);
            Address_pnl.Name = "Address_pnl";
            Address_pnl.Size = new Size(403, 54);
            Address_pnl.TabIndex = 17;
            // 
            // Address_lbl
            // 
            Address_lbl.AutoSize = true;
            Address_lbl.Font = new Font("Sitka Text", 11.249999F);
            Address_lbl.ForeColor = Color.White;
            Address_lbl.Location = new Point(3, 0);
            Address_lbl.Name = "Address_lbl";
            Address_lbl.Size = new Size(72, 21);
            Address_lbl.TabIndex = 28;
            Address_lbl.Text = "Address:";
            // 
            // Address_txtbx
            // 
            Address_txtbx.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Address_txtbx.Location = new Point(2, 26);
            Address_txtbx.Multiline = true;
            Address_txtbx.Name = "Address_txtbx";
            Address_txtbx.Size = new Size(388, 25);
            Address_txtbx.TabIndex = 27;
            // 
            // conact_pnl
            // 
            conact_pnl.Anchor = AnchorStyles.None;
            conact_pnl.Controls.Add(Contactnumber_lbl);
            conact_pnl.Controls.Add(boxNumber);
            conact_pnl.Location = new Point(3, 213);
            conact_pnl.Name = "conact_pnl";
            conact_pnl.Size = new Size(402, 54);
            conact_pnl.TabIndex = 16;
            // 
            // Contactnumber_lbl
            // 
            Contactnumber_lbl.AutoSize = true;
            Contactnumber_lbl.Font = new Font("Sitka Text", 11.249999F);
            Contactnumber_lbl.ForeColor = Color.White;
            Contactnumber_lbl.Location = new Point(4, 0);
            Contactnumber_lbl.Name = "Contactnumber_lbl";
            Contactnumber_lbl.Size = new Size(130, 21);
            Contactnumber_lbl.TabIndex = 19;
            Contactnumber_lbl.Text = "Contact Number:";
            // 
            // boxNumber
            // 
            boxNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxNumber.Location = new Point(4, 26);
            boxNumber.Multiline = true;
            boxNumber.Name = "boxNumber";
            boxNumber.Size = new Size(387, 25);
            boxNumber.TabIndex = 18;
            // 
            // Birthday_pnl
            // 
            Birthday_pnl.Anchor = AnchorStyles.None;
            Birthday_pnl.Controls.Add(Birthdate_cldr);
            Birthday_pnl.Controls.Add(birthday_lbl);
            Birthday_pnl.Location = new Point(411, 150);
            Birthday_pnl.Name = "Birthday_pnl";
            Birthday_pnl.Size = new Size(403, 54);
            Birthday_pnl.TabIndex = 15;
            // 
            // Birthdate_cldr
            // 
            Birthdate_cldr.CalendarFont = new Font("Sitka Text", 12F);
            Birthdate_cldr.Location = new Point(3, 26);
            Birthdate_cldr.Name = "Birthdate_cldr";
            Birthdate_cldr.Size = new Size(388, 23);
            Birthdate_cldr.TabIndex = 26;
            // 
            // birthday_lbl
            // 
            birthday_lbl.AutoSize = true;
            birthday_lbl.Font = new Font("Sitka Text", 11.249999F);
            birthday_lbl.ForeColor = Color.White;
            birthday_lbl.Location = new Point(3, 0);
            birthday_lbl.Name = "birthday_lbl";
            birthday_lbl.Size = new Size(76, 21);
            birthday_lbl.TabIndex = 25;
            birthday_lbl.Text = "Birthday:";
            // 
            // Gender_pnl
            // 
            Gender_pnl.Anchor = AnchorStyles.None;
            Gender_pnl.Controls.Add(Female_rdbtn);
            Gender_pnl.Controls.Add(Male_rdbtn);
            Gender_pnl.Controls.Add(Gender_lbl);
            Gender_pnl.Location = new Point(3, 150);
            Gender_pnl.Name = "Gender_pnl";
            Gender_pnl.Size = new Size(402, 54);
            Gender_pnl.TabIndex = 14;
            // 
            // Female_rdbtn
            // 
            Female_rdbtn.AutoSize = true;
            Female_rdbtn.Font = new Font("Sitka Text", 11.249999F);
            Female_rdbtn.ForeColor = Color.White;
            Female_rdbtn.Location = new Point(112, 26);
            Female_rdbtn.Name = "Female_rdbtn";
            Female_rdbtn.Size = new Size(79, 25);
            Female_rdbtn.TabIndex = 31;
            Female_rdbtn.TabStop = true;
            Female_rdbtn.Text = "Female";
            Female_rdbtn.UseVisualStyleBackColor = true;
            Female_rdbtn.CheckedChanged += Female_rdbtn_CheckedChanged;
            // 
            // Male_rdbtn
            // 
            Male_rdbtn.AutoSize = true;
            Male_rdbtn.Font = new Font("Sitka Text", 11.249999F);
            Male_rdbtn.ForeColor = Color.White;
            Male_rdbtn.Location = new Point(39, 26);
            Male_rdbtn.Name = "Male_rdbtn";
            Male_rdbtn.Size = new Size(63, 25);
            Male_rdbtn.TabIndex = 30;
            Male_rdbtn.TabStop = true;
            Male_rdbtn.Text = "Male";
            Male_rdbtn.UseVisualStyleBackColor = true;
            Male_rdbtn.CheckedChanged += Male_rdbtn_CheckedChanged;
            // 
            // Gender_lbl
            // 
            Gender_lbl.AutoSize = true;
            Gender_lbl.Font = new Font("Sitka Text", 11.249999F);
            Gender_lbl.ForeColor = Color.White;
            Gender_lbl.Location = new Point(4, 0);
            Gender_lbl.Name = "Gender_lbl";
            Gender_lbl.Size = new Size(67, 21);
            Gender_lbl.TabIndex = 29;
            Gender_lbl.Text = "Gender:";
            // 
            // Suffix_pnl
            // 
            Suffix_pnl.Anchor = AnchorStyles.None;
            Suffix_pnl.Controls.Add(Suffix_lbl);
            Suffix_pnl.Controls.Add(Suffix_txtbx);
            Suffix_pnl.Location = new Point(411, 67);
            Suffix_pnl.Name = "Suffix_pnl";
            Suffix_pnl.Size = new Size(403, 54);
            Suffix_pnl.TabIndex = 11;
            // 
            // Suffix_lbl
            // 
            Suffix_lbl.AutoSize = true;
            Suffix_lbl.BackColor = Color.Transparent;
            Suffix_lbl.Font = new Font("Sitka Text", 11.249999F);
            Suffix_lbl.ForeColor = Color.White;
            Suffix_lbl.Location = new Point(3, 0);
            Suffix_lbl.Name = "Suffix_lbl";
            Suffix_lbl.Size = new Size(56, 21);
            Suffix_lbl.TabIndex = 23;
            Suffix_lbl.Text = "Suffix:";
            // 
            // Suffix_txtbx
            // 
            Suffix_txtbx.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Suffix_txtbx.Location = new Point(3, 26);
            Suffix_txtbx.Multiline = true;
            Suffix_txtbx.Name = "Suffix_txtbx";
            Suffix_txtbx.Size = new Size(387, 25);
            Suffix_txtbx.TabIndex = 22;
            // 
            // Lastname_pnl
            // 
            Lastname_pnl.Anchor = AnchorStyles.None;
            Lastname_pnl.Controls.Add(labelLName);
            Lastname_pnl.Controls.Add(boxLName);
            Lastname_pnl.Location = new Point(3, 67);
            Lastname_pnl.Name = "Lastname_pnl";
            Lastname_pnl.Size = new Size(402, 54);
            Lastname_pnl.TabIndex = 10;
            // 
            // labelLName
            // 
            labelLName.AutoSize = true;
            labelLName.BackColor = Color.Transparent;
            labelLName.Font = new Font("Sitka Text", 11.249999F);
            labelLName.ForeColor = Color.Transparent;
            labelLName.Location = new Point(4, 0);
            labelLName.Name = "labelLName";
            labelLName.Size = new Size(89, 21);
            labelLName.TabIndex = 8;
            labelLName.Text = "Last Name:";
            // 
            // boxLName
            // 
            boxLName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxLName.Location = new Point(3, 26);
            boxLName.Multiline = true;
            boxLName.Name = "boxLName";
            boxLName.Size = new Size(386, 25);
            boxLName.TabIndex = 7;
            // 
            // Middlename_pnl
            // 
            Middlename_pnl.Anchor = AnchorStyles.None;
            Middlename_pnl.Controls.Add(MiddleName_lbl);
            Middlename_pnl.Controls.Add(MiddleName_txtbx);
            Middlename_pnl.Location = new Point(411, 4);
            Middlename_pnl.Name = "Middlename_pnl";
            Middlename_pnl.Size = new Size(403, 54);
            Middlename_pnl.TabIndex = 9;
            // 
            // MiddleName_lbl
            // 
            MiddleName_lbl.AutoSize = true;
            MiddleName_lbl.BackColor = Color.Transparent;
            MiddleName_lbl.Font = new Font("Sitka Text", 11.249999F);
            MiddleName_lbl.ForeColor = Color.White;
            MiddleName_lbl.Location = new Point(0, 0);
            MiddleName_lbl.Name = "MiddleName_lbl";
            MiddleName_lbl.Size = new Size(109, 21);
            MiddleName_lbl.TabIndex = 22;
            MiddleName_lbl.Text = "Middle Name:";
            // 
            // MiddleName_txtbx
            // 
            MiddleName_txtbx.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MiddleName_txtbx.Location = new Point(0, 26);
            MiddleName_txtbx.Multiline = true;
            MiddleName_txtbx.Name = "MiddleName_txtbx";
            MiddleName_txtbx.Size = new Size(390, 25);
            MiddleName_txtbx.TabIndex = 21;
            // 
            // Firstname_pnl
            // 
            Firstname_pnl.Anchor = AnchorStyles.None;
            Firstname_pnl.Controls.Add(labelFName);
            Firstname_pnl.Controls.Add(boxFName);
            Firstname_pnl.Location = new Point(3, 4);
            Firstname_pnl.Name = "Firstname_pnl";
            Firstname_pnl.Size = new Size(402, 54);
            Firstname_pnl.TabIndex = 8;
            // 
            // labelFName
            // 
            labelFName.AutoSize = true;
            labelFName.BackColor = Color.Transparent;
            labelFName.Font = new Font("Sitka Text", 11.249999F);
            labelFName.ForeColor = Color.White;
            labelFName.Location = new Point(4, 0);
            labelFName.Name = "labelFName";
            labelFName.Size = new Size(93, 21);
            labelFName.TabIndex = 7;
            labelFName.Text = "First Name:";
            // 
            // boxFName
            // 
            boxFName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxFName.Location = new Point(4, 26);
            boxFName.Multiline = true;
            boxFName.Name = "boxFName";
            boxFName.Size = new Size(387, 25);
            boxFName.TabIndex = 6;
            // 
            // email_pnl
            // 
            email_pnl.ColumnCount = 2;
            email_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            email_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            email_pnl.Controls.Add(panel2, 1, 0);
            email_pnl.Controls.Add(panel1, 0, 0);
            email_pnl.Dock = DockStyle.Fill;
            email_pnl.Location = new Point(23, 301);
            email_pnl.Name = "email_pnl";
            email_pnl.RowCount = 1;
            email_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            email_pnl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            email_pnl.Size = new Size(817, 66);
            email_pnl.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(Password_txtbx);
            panel2.Controls.Add(changePassword_btn);
            panel2.Controls.Add(Password_lbl);
            panel2.Location = new Point(411, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 54);
            panel2.TabIndex = 18;
            // 
            // Password_txtbx
            // 
            Password_txtbx.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password_txtbx.Location = new Point(4, 26);
            Password_txtbx.Multiline = true;
            Password_txtbx.Name = "Password_txtbx";
            Password_txtbx.ReadOnly = true;
            Password_txtbx.Size = new Size(251, 25);
            Password_txtbx.TabIndex = 18;
            Password_txtbx.UseSystemPasswordChar = true;
            // 
            // changePassword_btn
            // 
            changePassword_btn.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changePassword_btn.Location = new Point(261, 24);
            changePassword_btn.Name = "changePassword_btn";
            changePassword_btn.Size = new Size(128, 28);
            changePassword_btn.TabIndex = 20;
            changePassword_btn.Text = "Change Password";
            changePassword_btn.UseVisualStyleBackColor = true;
            changePassword_btn.Click += changePassword_btn_Click;
            // 
            // Password_lbl
            // 
            Password_lbl.AutoSize = true;
            Password_lbl.Font = new Font("Sitka Text", 11.249999F);
            Password_lbl.ForeColor = Color.White;
            Password_lbl.Location = new Point(4, 0);
            Password_lbl.Name = "Password_lbl";
            Password_lbl.Size = new Size(83, 21);
            Password_lbl.TabIndex = 19;
            Password_lbl.Text = "Password:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(Email_lbl);
            panel1.Controls.Add(boxEmail);
            panel1.Location = new Point(3, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 54);
            panel1.TabIndex = 17;
            // 
            // Email_lbl
            // 
            Email_lbl.AutoSize = true;
            Email_lbl.Font = new Font("Sitka Text", 11.249999F);
            Email_lbl.ForeColor = Color.White;
            Email_lbl.Location = new Point(4, 0);
            Email_lbl.Name = "Email_lbl";
            Email_lbl.Size = new Size(55, 21);
            Email_lbl.TabIndex = 19;
            Email_lbl.Text = "Email:";
            // 
            // boxEmail
            // 
            boxEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxEmail.Location = new Point(4, 26);
            boxEmail.Multiline = true;
            boxEmail.Name = "boxEmail";
            boxEmail.ReadOnly = true;
            boxEmail.Size = new Size(387, 25);
            boxEmail.TabIndex = 18;
            // 
            // filler
            // 
            filler.BackColor = SystemColors.GradientInactiveCaption;
            filler.Dock = DockStyle.Fill;
            filler.Location = new Point(23, 291);
            filler.Name = "filler";
            filler.Size = new Size(817, 4);
            filler.TabIndex = 19;
            // 
            // Register_pnl
            // 
            Register_pnl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Register_pnl.BackColor = Color.CornflowerBlue;
            Register_pnl.ColumnCount = 5;
            Register_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Register_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            Register_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6F));
            Register_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            Register_pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Register_pnl.Controls.Add(GoBack_btn, 1, 0);
            Register_pnl.Controls.Add(SaveChanges_btn, 3, 0);
            Register_pnl.Location = new Point(23, 491);
            Register_pnl.Name = "Register_pnl";
            Register_pnl.RowCount = 1;
            Register_pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Register_pnl.Size = new Size(863, 84);
            Register_pnl.TabIndex = 9;
            // 
            // GoBack_btn
            // 
            GoBack_btn.Anchor = AnchorStyles.None;
            GoBack_btn.BackColor = Color.CornflowerBlue;
            GoBack_btn.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold);
            GoBack_btn.ForeColor = Color.White;
            GoBack_btn.Location = new Point(218, 14);
            GoBack_btn.Name = "GoBack_btn";
            GoBack_btn.Size = new Size(183, 55);
            GoBack_btn.TabIndex = 14;
            GoBack_btn.Text = "Go Back";
            GoBack_btn.UseVisualStyleBackColor = false;
            GoBack_btn.Click += HomeButton_Click;
            // 
            // SaveChanges_btn
            // 
            SaveChanges_btn.Anchor = AnchorStyles.None;
            SaveChanges_btn.BackColor = Color.CornflowerBlue;
            SaveChanges_btn.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold);
            SaveChanges_btn.ForeColor = Color.White;
            SaveChanges_btn.Location = new Point(458, 14);
            SaveChanges_btn.Name = "SaveChanges_btn";
            SaveChanges_btn.Size = new Size(183, 55);
            SaveChanges_btn.TabIndex = 13;
            SaveChanges_btn.Text = "Save";
            SaveChanges_btn.UseVisualStyleBackColor = false;
            SaveChanges_btn.Click += SaveChanges_btn_Click;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(984, 661);
            Controls.Add(Body_sctn);
            Controls.Add(Header_pnl);
            Controls.Add(SideBarBackground);
            Name = "UserProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserProfile";
            Load += UserProfile_Load;
            SideBarBackground.ResumeLayout(false);
            Header_pnl.ResumeLayout(false);
            Header_pnl.PerformLayout();
            Body_sctn.ResumeLayout(false);
            Info_sctn.ResumeLayout(false);
            TopFormInfo_pnl.ResumeLayout(false);
            Address_pnl.ResumeLayout(false);
            Address_pnl.PerformLayout();
            conact_pnl.ResumeLayout(false);
            conact_pnl.PerformLayout();
            Birthday_pnl.ResumeLayout(false);
            Birthday_pnl.PerformLayout();
            Gender_pnl.ResumeLayout(false);
            Gender_pnl.PerformLayout();
            Suffix_pnl.ResumeLayout(false);
            Suffix_pnl.PerformLayout();
            Lastname_pnl.ResumeLayout(false);
            Lastname_pnl.PerformLayout();
            Middlename_pnl.ResumeLayout(false);
            Middlename_pnl.PerformLayout();
            Firstname_pnl.ResumeLayout(false);
            Firstname_pnl.PerformLayout();
            email_pnl.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Register_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel SideBarBackground;
        private Panel HomeButton;
        private Panel ServicesButton;
        private Panel AvailabilityButton;
        private Panel AppointmentButton;
        private Panel PatientButton;
        private Panel DoctorButton;
        private Panel Header_pnl;
        private Label Header_lbl;
        private TableLayoutPanel Body_sctn;
        private TableLayoutPanel Info_sctn;
        private TableLayoutPanel TopFormInfo_pnl;
        private Panel Address_pnl;
        private Label Address_lbl;
        private TextBox Address_txtbx;
        private Panel conact_pnl;
        private Label Contactnumber_lbl;
        private TextBox boxNumber;
        private Panel Birthday_pnl;
        private DateTimePicker Birthdate_cldr;
        private Label birthday_lbl;
        private Panel Gender_pnl;
        private RadioButton Female_rdbtn;
        private RadioButton Male_rdbtn;
        private Label Gender_lbl;
        private Panel Suffix_pnl;
        private Label Suffix_lbl;
        private TextBox Suffix_txtbx;
        private Panel Lastname_pnl;
        private Label labelLName;
        private TextBox boxLName;
        private Panel Middlename_pnl;
        private Label MiddleName_lbl;
        private TextBox MiddleName_txtbx;
        private Panel Firstname_pnl;
        private Label labelFName;
        private TextBox boxFName;
        private TableLayoutPanel email_pnl;
        private Panel panel2;
        private Label Password_lbl;
        private Panel panel1;
        private Label Email_lbl;
        private TextBox boxEmail;
        private Panel filler;
        private Button changePassword_btn;
        private TableLayoutPanel Register_pnl;
        private Button GoBack_btn;
        private Button SaveChanges_btn;
        private Panel Edit_logo;
        private TextBox Password_txtbx;
    }
}