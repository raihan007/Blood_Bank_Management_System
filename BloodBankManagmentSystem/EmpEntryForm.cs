using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBankManagmentSystem.Database;
using BloodBankManagmentSystem.Entities;

namespace BloodBankManagmentSystem
{
    public partial class EmpEntryForm : Form
    {
        private string _action;
        private int _branchId;
        private DataContext _context;
        private Employee employee;
        private int employeeId;
        private EmployeeListForm empForm;
        private DateTime lastDonate;

        public EmpEntryForm(EmployeeListForm empForm, string _action, int employeeId, int _branchId)
        {
            this.empForm = empForm;
            this._action = _action;
            this.employeeId = employeeId;
            this._branchId = _branchId;

            InitializeComponent();

            
            comboGender.SelectedIndex = 0;
            txtJoinDate.Value = DateTime.Now.AddYears(-5);
            CheckAction(_action);
        }

        private void CheckAction(string _action)
        {
            if (_action == "Save" && employeeId == 0)
            {
                btnAction.Text = _action;
            }
            else if (_action == "Update" && employeeId != 0)
            {
                lblTitle.Text = "Update Employee Information";
                btnAction.Text = _action;
                _context = new DataContext();
                employee = _context.GetEmployeeId(this.employeeId);
                LoadData(employee);
            }
            else
            {
                lblTitle.Text = "Details Employee Information";
                btnAction.Text = "Back";
                _context = new DataContext();
                employee = _context.GetEmployeeId(this.employeeId);
                LoadData(employee);

            }
        }

        private void LoadData(Employee employee)
        {
            txtId.Text = employee.UserID.ToString();
            txtName.Text = employee.Name;
            txtAddress.Text = employee.Locations.Address;
            txtEmail.Text = employee.Email;
            txtPhone.Text = employee.Phone.ToString();
            txtState.Text = employee.Locations.State;
            txtZipCode.Text = employee.Locations.ZipCode.ToString();
            txtSalary.Text = employee.Salary.ToString();
            txtCity.Text = employee.Locations.City;
            txtCountry.Text = employee.Locations.Country;
            txtRole.Text = employee.EmpRole;
            txtBranchId.Text = employee.BranchId.ToString();
            comboGender.SelectedIndex = comboGender.Items.IndexOf(employee.Gender);
            txtAddressId.Text = employee.Locations.LocationId.ToString();
            txtJoinDate.Value = employee.Joindate;
            txtAddressId.Text = employee.AddressId.ToString();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            //try
            //{
                Locations locations = new Locations()
                {
                    LocationId = Convert.ToInt32(txtAddressId.Text),
                    Address = txtAddress.Text,
                    State = txtState.Text,
                    City = txtCity.Text,
                    ZipCode = Convert.ToInt32(txtZipCode.Text),
                    Country = txtCountry.Text
                };

                Employee employee = new Employee()
                {
                    UserID = Convert.ToInt32(txtId.Text),
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Phone = Convert.ToInt32(txtPhone.Text),
                    Gender = (String)comboGender.SelectedItem,
                    Joindate = txtJoinDate.Value,
                    BranchId = Convert.ToInt32(txtBranchId.Text),
                    Salary = Convert.ToInt32(txtSalary.Text),
                    EmpRole = txtRole.Text,
                    AddressId = Convert.ToInt32(txtAddressId.Text),
                    Locations = locations
                };

                if (btnAction.Text == "Save")
                {
                    _context = new DataContext();
                    int locationId = _context.NextSequenceNo("LOCATIONS_SEQ");

                    locations.LocationId = locationId;
                    employee.AddressId = locationId;
                    if (_context.SaveDonerLocation(locations))
                    {
                        if (_context.SaveEmployeeInfo(employee))
                        {
                            MessageBox.Show("Employee Info Saved!");
                            this.empForm.LoadTableData();
                            this.Dispose();
                        }
                        else
                        {
                            _context.DeleteLocation(locationId);
                            MessageBox.Show("Something Wrong!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong!!");
                    }

                }
                else if (btnAction.Text == "Update")
                {
                    _context = new DataContext();
                    if (_context.UpdateEmployeeInfo(employee) && _context.UpdateDonerLocation(locations))
                    {
                        MessageBox.Show("Successfully Updated.");
                        this.empForm.LoadTableData();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Update.");
                    }
                }
                else
                {
                    this.Dispose();
                }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
