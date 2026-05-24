using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ElmplotyeesManagment
{
    public partial class Form1 : Form
    {
        private List<clsEmployee> ListEmployees = new List<clsEmployee>();
        private HashSet<string> EmployeesSet = new HashSet<string>();
        private enum ViewType
        {
            Details = 0,
            Largeicon,
            Smallicon,
            List,
            Tail
        }

        private enum GenderType
        {
            Male = 0,
            Female
        }
        public Form1()
        {
            InitializeComponent();
        }
        private bool isInformationFilled()
        {
            return !(string.IsNullOrEmpty(txtFullName.Text)
                || string.IsNullOrEmpty(txtPhone.Text)
                || string.IsNullOrEmpty(txtEmail.Text));
        }
        private bool isInformationExists(string InfoToCheck)
        {
            return EmployeesSet.Contains(InfoToCheck);
        }
        private bool isEmployeeExist(clsEmployee employee)
        {
            if (isInformationExists(employee.Email) || isInformationExists(employee.Phone))
                return true;

            return false;
        }
        private ListViewItem FillEmployeeViewList(clsEmployee Employee)
        {
            ListViewItem ListViewEmployee = new ListViewItem(Employee.ID.ToString().Trim());
            if (Employee.Gender == rbMale.Text)
                ListViewEmployee.ImageIndex = (int)GenderType.Male;
            else
                ListViewEmployee.ImageIndex = (int)GenderType.Female;

            ListViewEmployee.SubItems.Add(Employee.FullName.ToLower().Trim());
            ListViewEmployee.SubItems.Add(Employee.Phone.Trim());
            ListViewEmployee.SubItems.Add(Employee.Email.ToLower().Trim());
            ListViewEmployee.SubItems.Add(Employee.Gender.Trim());
            ListViewEmployee.SubItems.Add(Employee.BirthDate.ToShortDateString());
            ListViewEmployee.SubItems.Add(Employee.GetAge().ToString());
            return ListViewEmployee;
        }

        private void AddEmployee(clsEmployee Employee)
        {
            EmployeesSet.Add(Employee.Email);
            EmployeesSet.Add(Employee.Phone);
            ListEmployees.Add(Employee);
            listView1.Items.Add(FillEmployeeViewList(Employee));
        }
        private bool TryAddEmployee(in string FullName, in string Phone, in int ID, in string Gender, in DateTime BirthDate, in string Email)
        {
            clsEmployee employee = new clsEmployee();
            employee.FullName = FullName;
            employee.Phone = Phone;
            employee.ID = ID;
            employee.Gender = Gender;
            employee.BirthDate = BirthDate;
            employee.Email = Email;

            if (!isEmployeeExist(employee))
            {
                AddEmployee(employee);
                return true;
            }
            return false;
        }
        private void PerformInvalidInput(TextBox text)
        {
            text.ForeColor = Color.Red;
            text.Focus();
            SystemSounds.Beep.Play();
        }
        private bool IsValidInput(TextBox text)
        {
            string Namepattern = @"^[a-zA-Z\s\'\-]*$";
            string EmailPattern = @"^(([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+))?$";
            string PhonePattern = @"^(\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4}))?$";

            if (text == txtFullName && !Regex.IsMatch(text.Text, Namepattern)
                || text == txtEmail && !Regex.IsMatch(text.Text, EmailPattern)
                || text == txtPhone && !Regex.IsMatch(text.Text, PhonePattern))
            {
                PerformInvalidInput(text);
                return false;
            }
            return true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (isInformationFilled() && IsValidInput(txtEmail) && IsValidInput(txtPhone)) 
            {
                if (TryAddEmployee(txtFullName.Text, txtPhone.Text, new Random().Next(1000, int.MaxValue),
                    gpGenderPicker.Controls.OfType<RadioButton>().Where(rb => rb.Checked).FirstOrDefault().Text,
                    BirthDatePicker.Value, txtEmail.Text))
                {
                    txtFullName.Clear();
                    txtPhone.Clear();
                    txtEmail.Clear();
                }
                else
                {
                    MessageBox.Show("Employee with this information already exists!", "Employee information"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill employee information!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Check_BadText(object sender, EventArgs e)
        {
            if (sender == txtFullName)
                IsValidInput(sender as TextBox);
            else if (sender == txtPhone)
                IsValidInput(sender as TextBox);
            else if (sender == txtEmail)
                IsValidInput(sender as TextBox);

        }
        private void cbViewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewType type = (ViewType)cbViewType.SelectedIndex;

            switch (type)
            {
                case ViewType.Details:
                    listView1.View = View.Details;
                    break;
                case ViewType.Tail:
                    listView1.View = View.Tile;
                    break;
                case ViewType.Largeicon:
                    listView1.View = View.LargeIcon;
                    break;
                case ViewType.Smallicon:
                    listView1.View = View.SmallIcon;
                    break;
                case ViewType.List:
                    listView1.View = View.List;
                    break;
                default:
                    listView1.View = View.Details;
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbViewType.SelectedIndex = (int)ViewType.Details;
        }
        private void FillSelectedEmployeeCard(in clsEmployee employee)
        {
            CardID.Text = employee.ID.ToString();
            CardEmail.Text = employee.Email.ToString();
            CardPhone.Text = employee.Phone.ToString();
            CardName.Text = employee.FullName.ToString();
            CardGender.Text = employee.Gender.ToString();
            CardAge.Text = employee.GetAge().ToString();
            if (employee.Gender == rbMale.Text)
                EmployeePicture.Image = ImListGenderLarge.Images[(int)GenderType.Male];
            else
                EmployeePicture.Image = ImListGenderLarge.Images[(int)GenderType.Female];

        }
        private void ClearEmployeeCard()
        {
            CardID.Text = string.Empty;
            CardEmail.Text = string.Empty;
            CardPhone.Text = string.Empty;
            CardName.Text = string.Empty;
            CardGender.Text = string.Empty;
            CardAge.Text = string.Empty;
            EmployeePicture.Image = ImListGenderLarge.Images[(int)GenderType.Male];
        }

        private void RemoveEmployee(int Index)
        {
            EmployeesSet.Remove(ListEmployees[Index].Phone);
            EmployeesSet.Remove(ListEmployees[Index].Email);
            listView1.Items.RemoveAt(Index);
            ListEmployees.RemoveAt(Index);
            ClearEmployeeCard();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            var SelectedEmployee = listView1.SelectedIndices;
            if (SelectedEmployee.Count > 0)
            {
                if (MessageBox.Show("Do you wnat to remove these items?", "Remove items",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    for (int i = SelectedEmployee.Count - 1; i >= 0; i--)
                        RemoveEmployee(SelectedEmployee[i]);
                }
            }

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            FillSelectedEmployeeCard(ListEmployees[e.ItemIndex]);
        }

        private void ShowEmployeeExistsMessage(in string text, in string caption)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ApplyModification(int ItemIndex, clsEmployee employee)
        {
            EmployeesSet.Remove(ListEmployees[ItemIndex].Email);
            EmployeesSet.Remove(ListEmployees[ItemIndex].Phone);
            employee.ID = ListEmployees[ItemIndex].ID;
            ListEmployees[ItemIndex] = employee;
            listView1.Items[ItemIndex] = FillEmployeeViewList(employee);
            EmployeesSet.Add(employee.Email);
            EmployeesSet.Add(employee.Phone);
        }
        private void Modify(int ItemIndex)
        {
            frmModifyEmployeeInfo form = new frmModifyEmployeeInfo(ListEmployees[ItemIndex]);
            form.ShowDialog();
            if (form.isModifyCompleted)
            {


                if ((form.employee.Email != ListEmployees[ItemIndex].Email) && isInformationExists(form.employee.Email))
                {
                    ShowEmployeeExistsMessage("Employee with this Email already exists!", "Employee information");
                    return;
                }
                if ((form.employee.Phone != ListEmployees[ItemIndex].Phone) && isInformationExists(form.employee.Phone))
                {
                    ShowEmployeeExistsMessage("Employee with this Phone already exists!", "Employee information");
                    return;
                }

                ApplyModification(ItemIndex, form.employee);

            }

        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 1 || listView1.SelectedItems.Count < 1)
                MessageBox.Show("Please select 1 employee!", "Modify employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Modify(listView1.SelectedItems[0].Index);
            }
        }

        private void TextBoxesChanged(object sender, EventArgs e)
        {
            (sender as TextBox).ForeColor = default;
        }
    }
}
