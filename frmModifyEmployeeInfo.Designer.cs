using System;

namespace ElmplotyeesManagment
{
    partial class frmModifyEmployeeInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifyEmployeeInfo));
            this.gpEmployeeInformation = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
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
            this.gpEmployeeInformation.SuspendLayout();
            this.gpGenderPicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpEmployeeInformation
            // 
            this.gpEmployeeInformation.Controls.Add(this.btnCancel);
            this.gpEmployeeInformation.Controls.Add(this.btnModify);
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
            this.gpEmployeeInformation.Location = new System.Drawing.Point(12, 12);
            this.gpEmployeeInformation.Name = "gpEmployeeInformation";
            this.gpEmployeeInformation.Size = new System.Drawing.Size(460, 337);
            this.gpEmployeeInformation.TabIndex = 10;
            this.gpEmployeeInformation.TabStop = false;
            this.gpEmployeeInformation.Text = "Employee Information";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tan;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(237, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 51);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Tan;
            this.btnModify.Enabled = false;
            this.btnModify.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(29, 229);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(169, 51);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lblNote.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblNote.Location = new System.Drawing.Point(269, 164);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(89, 13);
            this.lblNote.TabIndex = 19;
            this.lblNote.Text = "Must be over 18y";
            // 
            // gpGenderPicker
            // 
            this.gpGenderPicker.Controls.Add(this.rbFemale);
            this.gpGenderPicker.Controls.Add(this.rbMale);
            this.gpGenderPicker.Location = new System.Drawing.Point(291, 50);
            this.gpGenderPicker.Name = "gpGenderPicker";
            this.gpGenderPicker.Size = new System.Drawing.Size(115, 74);
            this.gpGenderPicker.TabIndex = 18;
            this.gpGenderPicker.TabStop = false;
            this.gpGenderPicker.Text = "Gender";
            this.gpGenderPicker.MouseCaptureChanged += new System.EventHandler(this.Information_Change_Captured);
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
            this.rbFemale.MouseCaptureChanged += new System.EventHandler(this.Information_Change_Captured);
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
            this.rbMale.MouseCaptureChanged += new System.EventHandler(this.Information_Change_Captured);
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.CustomFormat = "dd / MM / yyyy";
            this.BirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthDatePicker.Location = new System.Drawing.Point(113, 161);
            this.BirthDatePicker.MaxDate = new System.DateTime(2026, 5, 27, 23, 49, 30, 613);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(144, 21);
            this.BirthDatePicker.TabIndex = 17;
            this.BirthDatePicker.Value = new System.DateTime(2026, 5, 27, 23, 49, 30, 613);
            this.BirthDatePicker.MouseCaptureChanged += new System.EventHandler(this.Information_Change_Captured);
            this.BirthDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.BirthDatePicker_Validating);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(14, 161);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(90, 15);
            this.lblBirthDate.TabIndex = 16;
            this.lblBirthDate.Text = "Date of birth:";
            this.lblBirthDate.MouseCaptureChanged += new System.EventHandler(this.Information_Change_Captured);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(113, 124);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 20);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.MouseCaptureChanged += new System.EventHandler(this.Information_Change_Captured);
            this.txtEmail.Validated += new System.EventHandler(this.Check_BadText);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(113, 87);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(147, 20);
            this.txtPhone.TabIndex = 14;
            this.txtPhone.MouseCaptureChanged += new System.EventHandler(this.Information_Change_Captured);
            this.txtPhone.Validated += new System.EventHandler(this.Check_BadText);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(113, 50);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(147, 20);
            this.txtFullName.TabIndex = 13;
            this.txtFullName.MouseCaptureChanged += new System.EventHandler(this.Information_Change_Captured);
            this.txtFullName.Validated += new System.EventHandler(this.Check_BadText);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(51, 125);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(53, 15);
            this.lbl_Email.TabIndex = 12;
            this.lbl_Email.Text = "E-mail:";
            this.lbl_Email.MouseCaptureChanged += new System.EventHandler(this.Information_Change_Captured);
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.Location = new System.Drawing.Point(51, 89);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(52, 15);
            this.lbl_Phone.TabIndex = 11;
            this.lbl_Phone.Text = "Phone:";
            this.lbl_Phone.MouseCaptureChanged += new System.EventHandler(this.Information_Change_Captured);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(26, 53);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(77, 15);
            this.lblFullName.TabIndex = 10;
            this.lblFullName.Text = "Full Name:";
            this.lblFullName.MouseCaptureChanged += new System.EventHandler(this.Information_Change_Captured);
            // 
            // frmModifyEmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.gpEmployeeInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModifyEmployeeInfo";
            this.Text = "Modify Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmModifyEmployeeInfo_FormClosing);
            this.Load += new System.EventHandler(this.frmModifyEmployeeInfo_Load);
            this.gpEmployeeInformation.ResumeLayout(false);
            this.gpEmployeeInformation.PerformLayout();
            this.gpGenderPicker.ResumeLayout(false);
            this.gpGenderPicker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpEmployeeInformation;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.GroupBox gpGenderPicker;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnCancel;
    }
}