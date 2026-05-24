using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElmplotyeesManagment
{
    partial class frmModifyEmployeeInfo : Form
    {
        public clsEmployee employee = new clsEmployee();
        public bool isModifyCompleted = false;
        public clsEmployee OriginalEmployee;
        public frmModifyEmployeeInfo(in clsEmployee OriginalEmployee1)
        {
            this.OriginalEmployee = OriginalEmployee1;
            InitializeComponent();
        }
        private clsEmployee GetNewEmployeeInformation()
        {
            clsEmployee employee = new clsEmployee();
            employee.FullName = txtFullName.Text;
            employee.Email = txtEmail.Text;
            employee.Phone = txtPhone.Text;
            employee.BirthDate = BirthDatePicker.Value;
            if (rbMale.Checked)
                employee.Gender = rbMale.Text;
            else
                employee.Gender = rbFemale.Text;

                return employee;
        }
        private bool isInformationFilled()
        {
            return !(string.IsNullOrEmpty(txtFullName.Text)
                || string.IsNullOrEmpty(txtPhone.Text)
                || string.IsNullOrEmpty(txtEmail.Text));
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (isInformationFilled())
            {
                if (MessageBox.Show("Are you sure from this changes?", "Modify information",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    employee = GetNewEmployeeInformation();
                    isModifyCompleted = true;
                    this.Close();
                }
            }
            else
                MessageBox.Show("Please fill employee information!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ShowBadTextMessage(TextBox text)
        {
            text.Clear();
            MessageBox.Show($"Please enter a valid text!", "Bad input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            text.Focus();
        }
        public void PerformeBadTextMessage(TextBox text)
        {
            string Namepattern = @"^[a-zA-Z\s\'\-]*$";
            string EmailPattern = @"^(([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+))?$";
            string PhonePattern = @"^(\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4}))?$";

            if (text == txtFullName && !Regex.IsMatch(text.Text, Namepattern))
            {
                ShowBadTextMessage(text);
            }
            else if (text == txtEmail && !Regex.IsMatch(text.Text, EmailPattern))
            {
                ShowBadTextMessage(text);
            }
            else if (text == txtPhone && !Regex.IsMatch(text.Text, PhonePattern))
            {
                ShowBadTextMessage(text);
            }

        }
        private void Check_BadText(object sender, EventArgs e)
        {
            if (sender == txtFullName)
                PerformeBadTextMessage(sender as TextBox);
            else if (sender == txtPhone)
                PerformeBadTextMessage(sender as TextBox);
            else if (sender == txtEmail)
                PerformeBadTextMessage(sender as TextBox);
        }

        private void frmModifyEmployeeInfo_Load(object sender, EventArgs e)
        {
            this.txtFullName.Text = this.OriginalEmployee.FullName;
            this.txtEmail.Text = this.OriginalEmployee.Email;
            this.txtPhone.Text = this.OriginalEmployee.Phone;
            this.BirthDatePicker.Value = this.OriginalEmployee.BirthDate;
            if (this.OriginalEmployee.Gender != rbMale.Text)
                rbFemale.Checked = true;

        }

        private void frmModifyEmployeeInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (employee == null)
            isModifyCompleted = false;
        }

        private void Information_Change_Captured(object sender, EventArgs e)
        {
            btnModify.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isModifyCompleted = false;
            this.Close();
        }
    }
}
