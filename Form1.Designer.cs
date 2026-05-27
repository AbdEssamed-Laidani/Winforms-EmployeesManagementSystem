using System;

namespace ElmplotyeesManagment
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.EmployeePicture = new System.Windows.Forms.PictureBox();
            this.MainLogo = new System.Windows.Forms.PictureBox();
            this.gpEmployeeInformation = new System.Windows.Forms.GroupBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.gpGenderPicker = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.gpEmployeeCard = new System.Windows.Forms.GroupBox();
            this.CardEmail = new System.Windows.Forms.Label();
            this.CardGender = new System.Windows.Forms.Label();
            this.CardAge = new System.Windows.Forms.Label();
            this.CardPhone = new System.Windows.Forms.Label();
            this.CardName = new System.Windows.Forms.Label();
            this.CardID = new System.Windows.Forms.Label();
            this.gpTools = new System.Windows.Forms.GroupBox();
            this.cbViewType = new System.Windows.Forms.ComboBox();
            this.lblModifyBtn = new System.Windows.Forms.Label();
            this.lblRemoveBtn = new System.Windows.Forms.Label();
            this.lblAddBtn = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.ImListTools = new System.Windows.Forms.ImageList(this.components);
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblView = new System.Windows.Forms.Label();
            this.ImListGenderSmall = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImListGenderLarge = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).BeginInit();
            this.gpEmployeeInformation.SuspendLayout();
            this.gpGenderPicker.SuspendLayout();
            this.gpEmployeeCard.SuspendLayout();
            this.gpTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(109, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 15);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(109, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(109, 65);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 15);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(109, 84);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 15);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(109, 103);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(35, 15);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Age:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(109, 122);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(58, 15);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender:";
            // 
            // EmployeePicture
            // 
            this.EmployeePicture.BackColor = System.Drawing.Color.LightGray;
            this.EmployeePicture.Image = ((System.Drawing.Image)(resources.GetObject("EmployeePicture.Image")));
            this.EmployeePicture.Location = new System.Drawing.Point(10, 26);
            this.EmployeePicture.Name = "EmployeePicture";
            this.EmployeePicture.Size = new System.Drawing.Size(90, 115);
            this.EmployeePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmployeePicture.TabIndex = 1;
            this.EmployeePicture.TabStop = false;
            // 
            // MainLogo
            // 
            this.MainLogo.BackColor = System.Drawing.Color.Gainsboro;
            this.MainLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainLogo.Image = ((System.Drawing.Image)(resources.GetObject("MainLogo.Image")));
            this.MainLogo.Location = new System.Drawing.Point(0, 0);
            this.MainLogo.Name = "MainLogo";
            this.MainLogo.Size = new System.Drawing.Size(800, 72);
            this.MainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainLogo.TabIndex = 0;
            this.MainLogo.TabStop = false;
            // 
            // gpEmployeeInformation
            // 
            this.gpEmployeeInformation.Controls.Add(this.lblNote);
            this.gpEmployeeInformation.Controls.Add(this.gpGenderPicker);
            this.gpEmployeeInformation.Controls.Add(this.BirthDatePicker);
            this.gpEmployeeInformation.Controls.Add(this.lblBirthDate);
            this.gpEmployeeInformation.Controls.Add(this.txtEmail);
            this.gpEmployeeInformation.Controls.Add(this.txtPhone);
            this.gpEmployeeInformation.Controls.Add(this.txtFullName);
            this.gpEmployeeInformation.Controls.Add(this.lbl_Email);
            this.gpEmployeeInformation.Controls.Add(this.lbl_Phone);
            this.gpEmployeeInformation.Controls.Add(this.lblFullName);
            this.gpEmployeeInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpEmployeeInformation.Location = new System.Drawing.Point(409, 78);
            this.gpEmployeeInformation.Name = "gpEmployeeInformation";
            this.gpEmployeeInformation.Size = new System.Drawing.Size(379, 160);
            this.gpEmployeeInformation.TabIndex = 9;
            this.gpEmployeeInformation.TabStop = false;
            this.gpEmployeeInformation.Text = "Employee Information";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lblNote.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblNote.Location = new System.Drawing.Point(102, 128);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(89, 13);
            this.lblNote.TabIndex = 19;
            this.lblNote.Text = "Must be over 18y";
            // 
            // gpGenderPicker
            // 
            this.gpGenderPicker.Controls.Add(this.rbFemale);
            this.gpGenderPicker.Controls.Add(this.rbMale);
            this.gpGenderPicker.Location = new System.Drawing.Point(274, 96);
            this.gpGenderPicker.Name = "gpGenderPicker";
            this.gpGenderPicker.Size = new System.Drawing.Size(99, 58);
            this.gpGenderPicker.TabIndex = 18;
            this.gpGenderPicker.TabStop = false;
            this.gpGenderPicker.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(6, 39);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(67, 19);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(6, 20);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(53, 19);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.CustomFormat = "dd / MM / yyyy";
            this.BirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthDatePicker.Location = new System.Drawing.Point(105, 102);
            this.BirthDatePicker.MaxDate = new System.DateTime(2026, 5, 27, 23, 30, 17, 707);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(144, 21);
            this.BirthDatePicker.TabIndex = 17;
            this.BirthDatePicker.Value = new System.DateTime(2026, 5, 27, 23, 30, 17, 707);
            this.BirthDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.BirthDatePicker_Validating);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(6, 102);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(90, 15);
            this.lblBirthDate.TabIndex = 16;
            this.lblBirthDate.Text = "Date of birth:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(105, 74);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 20);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextChanged += new System.EventHandler(this.TextBoxesChanged);
            this.txtEmail.Validated += new System.EventHandler(this.Check_BadText);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(105, 49);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(228, 20);
            this.txtPhone.TabIndex = 14;
            this.txtPhone.TextChanged += new System.EventHandler(this.TextBoxesChanged);
            this.txtPhone.Validated += new System.EventHandler(this.Check_BadText);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(105, 24);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(228, 20);
            this.txtFullName.TabIndex = 13;
            this.txtFullName.TextChanged += new System.EventHandler(this.TextBoxesChanged);
            this.txtFullName.Validated += new System.EventHandler(this.Check_BadText);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(43, 77);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(53, 15);
            this.lbl_Email.TabIndex = 12;
            this.lbl_Email.Text = "E-mail:";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.Location = new System.Drawing.Point(43, 52);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(52, 15);
            this.lbl_Phone.TabIndex = 11;
            this.lbl_Phone.Text = "Phone:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(18, 27);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(77, 15);
            this.lblFullName.TabIndex = 10;
            this.lblFullName.Text = "Full Name:";
            // 
            // gpEmployeeCard
            // 
            this.gpEmployeeCard.Controls.Add(this.CardEmail);
            this.gpEmployeeCard.Controls.Add(this.CardGender);
            this.gpEmployeeCard.Controls.Add(this.CardAge);
            this.gpEmployeeCard.Controls.Add(this.CardPhone);
            this.gpEmployeeCard.Controls.Add(this.CardName);
            this.gpEmployeeCard.Controls.Add(this.CardID);
            this.gpEmployeeCard.Controls.Add(this.EmployeePicture);
            this.gpEmployeeCard.Controls.Add(this.lblID);
            this.gpEmployeeCard.Controls.Add(this.lblGender);
            this.gpEmployeeCard.Controls.Add(this.lblName);
            this.gpEmployeeCard.Controls.Add(this.lblAge);
            this.gpEmployeeCard.Controls.Add(this.lblPhone);
            this.gpEmployeeCard.Controls.Add(this.lblEmail);
            this.gpEmployeeCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpEmployeeCard.Location = new System.Drawing.Point(12, 78);
            this.gpEmployeeCard.Name = "gpEmployeeCard";
            this.gpEmployeeCard.Size = new System.Drawing.Size(377, 160);
            this.gpEmployeeCard.TabIndex = 10;
            this.gpEmployeeCard.TabStop = false;
            this.gpEmployeeCard.Text = "Employee Card";
            // 
            // CardEmail
            // 
            this.CardEmail.AutoSize = true;
            this.CardEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardEmail.ForeColor = System.Drawing.Color.DimGray;
            this.CardEmail.Location = new System.Drawing.Point(166, 84);
            this.CardEmail.Name = "CardEmail";
            this.CardEmail.Size = new System.Drawing.Size(0, 15);
            this.CardEmail.TabIndex = 14;
            // 
            // CardGender
            // 
            this.CardGender.AutoSize = true;
            this.CardGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardGender.ForeColor = System.Drawing.Color.DimGray;
            this.CardGender.Location = new System.Drawing.Point(166, 122);
            this.CardGender.Name = "CardGender";
            this.CardGender.Size = new System.Drawing.Size(0, 15);
            this.CardGender.TabIndex = 13;
            // 
            // CardAge
            // 
            this.CardAge.AutoSize = true;
            this.CardAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardAge.ForeColor = System.Drawing.Color.DimGray;
            this.CardAge.Location = new System.Drawing.Point(166, 104);
            this.CardAge.Name = "CardAge";
            this.CardAge.Size = new System.Drawing.Size(0, 15);
            this.CardAge.TabIndex = 12;
            // 
            // CardPhone
            // 
            this.CardPhone.AutoSize = true;
            this.CardPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardPhone.ForeColor = System.Drawing.Color.DimGray;
            this.CardPhone.Location = new System.Drawing.Point(166, 67);
            this.CardPhone.Name = "CardPhone";
            this.CardPhone.Size = new System.Drawing.Size(0, 15);
            this.CardPhone.TabIndex = 11;
            // 
            // CardName
            // 
            this.CardName.AutoSize = true;
            this.CardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardName.ForeColor = System.Drawing.Color.DimGray;
            this.CardName.Location = new System.Drawing.Point(166, 48);
            this.CardName.Name = "CardName";
            this.CardName.Size = new System.Drawing.Size(0, 15);
            this.CardName.TabIndex = 10;
            // 
            // CardID
            // 
            this.CardID.AutoSize = true;
            this.CardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardID.ForeColor = System.Drawing.Color.DimGray;
            this.CardID.Location = new System.Drawing.Point(166, 26);
            this.CardID.Name = "CardID";
            this.CardID.Size = new System.Drawing.Size(0, 15);
            this.CardID.TabIndex = 9;
            // 
            // gpTools
            // 
            this.gpTools.Controls.Add(this.cbViewType);
            this.gpTools.Controls.Add(this.lblModifyBtn);
            this.gpTools.Controls.Add(this.lblRemoveBtn);
            this.gpTools.Controls.Add(this.lblAddBtn);
            this.gpTools.Controls.Add(this.btnModify);
            this.gpTools.Controls.Add(this.btnRemove);
            this.gpTools.Controls.Add(this.btnAdd);
            this.gpTools.Controls.Add(this.lblView);
            this.gpTools.Location = new System.Drawing.Point(15, 244);
            this.gpTools.Name = "gpTools";
            this.gpTools.Size = new System.Drawing.Size(772, 47);
            this.gpTools.TabIndex = 11;
            this.gpTools.TabStop = false;
            // 
            // cbViewType
            // 
            this.cbViewType.FormattingEnabled = true;
            this.cbViewType.Items.AddRange(new object[] {
            "Details",
            "Large icon",
            "List",
            "Small icon",
            "Tail"});
            this.cbViewType.Location = new System.Drawing.Point(641, 18);
            this.cbViewType.Name = "cbViewType";
            this.cbViewType.Size = new System.Drawing.Size(111, 21);
            this.cbViewType.TabIndex = 17;
            this.cbViewType.SelectedIndexChanged += new System.EventHandler(this.cbViewType_SelectedIndexChanged);
            // 
            // lblModifyBtn
            // 
            this.lblModifyBtn.AutoSize = true;
            this.lblModifyBtn.BackColor = System.Drawing.Color.White;
            this.lblModifyBtn.Enabled = false;
            this.lblModifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyBtn.Location = new System.Drawing.Point(378, 19);
            this.lblModifyBtn.Name = "lblModifyBtn";
            this.lblModifyBtn.Size = new System.Drawing.Size(49, 15);
            this.lblModifyBtn.TabIndex = 16;
            this.lblModifyBtn.Text = "Modify";
            // 
            // lblRemoveBtn
            // 
            this.lblRemoveBtn.AutoSize = true;
            this.lblRemoveBtn.BackColor = System.Drawing.Color.White;
            this.lblRemoveBtn.Enabled = false;
            this.lblRemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveBtn.Location = new System.Drawing.Point(208, 19);
            this.lblRemoveBtn.Name = "lblRemoveBtn";
            this.lblRemoveBtn.Size = new System.Drawing.Size(59, 15);
            this.lblRemoveBtn.TabIndex = 15;
            this.lblRemoveBtn.Text = "Remove";
            // 
            // lblAddBtn
            // 
            this.lblAddBtn.AutoSize = true;
            this.lblAddBtn.BackColor = System.Drawing.Color.White;
            this.lblAddBtn.Enabled = false;
            this.lblAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBtn.Location = new System.Drawing.Point(52, 19);
            this.lblAddBtn.Name = "lblAddBtn";
            this.lblAddBtn.Size = new System.Drawing.Size(31, 15);
            this.lblAddBtn.TabIndex = 9;
            this.lblAddBtn.Text = "Add";
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.ImageIndex = 1;
            this.btnModify.ImageList = this.ImListTools;
            this.btnModify.Location = new System.Drawing.Point(341, 12);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(109, 29);
            this.btnModify.TabIndex = 14;
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // ImListTools
            // 
            this.ImListTools.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImListTools.ImageStream")));
            this.ImListTools.TransparentColor = System.Drawing.Color.Transparent;
            this.ImListTools.Images.SetKeyName(0, "Add-removebg-preview.png");
            this.ImListTools.Images.SetKeyName(1, "modify-removebg-preview.png");
            this.ImListTools.Images.SetKeyName(2, "Trash-removebg-preview.png");
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.ImageIndex = 2;
            this.btnRemove.ImageList = this.ImListTools;
            this.btnRemove.Location = new System.Drawing.Point(174, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(109, 29);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageIndex = 0;
            this.btnAdd.ImageList = this.ImListTools;
            this.btnAdd.Location = new System.Drawing.Point(7, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 29);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(599, 19);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(41, 15);
            this.lblView.TabIndex = 12;
            this.lblView.Text = "View:";
            // 
            // ImListGenderSmall
            // 
            this.ImListGenderSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImListGenderSmall.ImageStream")));
            this.ImListGenderSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ImListGenderSmall.Images.SetKeyName(0, "man-removebg-preview.png");
            this.ImListGenderSmall.Images.SetKeyName(1, "woman-removebg-preview.png");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colFullName,
            this.colPhone,
            this.colEmail,
            this.colGender,
            this.colBirthDate,
            this.colAge});
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.ImListGenderLarge;
            this.listView1.Location = new System.Drawing.Point(15, 296);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(772, 200);
            this.listView1.SmallImageList = this.ImListGenderSmall;
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 130;
            // 
            // colFullName
            // 
            this.colFullName.Text = "Full Name";
            this.colFullName.Width = 130;
            // 
            // colPhone
            // 
            this.colPhone.Text = "Phone";
            this.colPhone.Width = 85;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.Width = 164;
            // 
            // colGender
            // 
            this.colGender.Text = "Gender";
            this.colGender.Width = 70;
            // 
            // colBirthDate
            // 
            this.colBirthDate.Text = "Date of birth";
            this.colBirthDate.Width = 130;
            // 
            // colAge
            // 
            this.colAge.Text = "Age";
            // 
            // ImListGenderLarge
            // 
            this.ImListGenderLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImListGenderLarge.ImageStream")));
            this.ImListGenderLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.ImListGenderLarge.Images.SetKeyName(0, "man-removebg-preview.png");
            this.ImListGenderLarge.Images.SetKeyName(1, "woman-removebg-preview.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gpTools);
            this.Controls.Add(this.gpEmployeeCard);
            this.Controls.Add(this.gpEmployeeInformation);
            this.Controls.Add(this.MainLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Employees Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).EndInit();
            this.gpEmployeeInformation.ResumeLayout(false);
            this.gpEmployeeInformation.PerformLayout();
            this.gpGenderPicker.ResumeLayout(false);
            this.gpGenderPicker.PerformLayout();
            this.gpEmployeeCard.ResumeLayout(false);
            this.gpEmployeeCard.PerformLayout();
            this.gpTools.ResumeLayout(false);
            this.gpTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainLogo;
        private System.Windows.Forms.PictureBox EmployeePicture;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.GroupBox gpEmployeeInformation;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.GroupBox gpGenderPicker;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.GroupBox gpEmployeeCard;
        private System.Windows.Forms.GroupBox gpTools;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ImageList ImListGenderSmall;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ImageList ImListTools;
        private System.Windows.Forms.Label lblRemoveBtn;
        private System.Windows.Forms.Label lblAddBtn;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblModifyBtn;
        private System.Windows.Forms.ComboBox cbViewType;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList ImListGenderLarge;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colFullName;
        private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colGender;
        private System.Windows.Forms.ColumnHeader colAge;
        private System.Windows.Forms.ColumnHeader colBirthDate;
        private System.Windows.Forms.Label CardEmail;
        private System.Windows.Forms.Label CardGender;
        private System.Windows.Forms.Label CardAge;
        private System.Windows.Forms.Label CardPhone;
        private System.Windows.Forms.Label CardName;
        private System.Windows.Forms.Label CardID;
    }
}

