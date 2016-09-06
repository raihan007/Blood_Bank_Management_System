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
    public partial class OwnProfileForm : Form
    {
        private int _uId;
        private Employee _employee;
        private DataContext _context;
        private String _actionType;
        private int _branchIndex = -1;

        public OwnProfileForm(int uId,String actionType)
        {
            this._uId = uId;
            this._actionType = actionType;
            InitializeComponent();
            LoadData();
        }

        private void OwnProfileForm_Load(object sender, EventArgs e)
        {
            if (_actionType == "View")
            {
                ShowEmpData(_employee);
                btnAction.Visible = false;
            }
            else if (_actionType == "Add")
            {
                
            }
            else
            {
                
            }
        }

        private void ShowEmpData(Employee employee)
        {
            txtId.Text = _employee.UserID.ToString();
            txtName.Text = _employee.Name;
            txtAddress.Text = _employee.Locations.LocationId.ToString();
            cmbGender.SelectedIndex = cmbGender.Items.IndexOf(_employee.Gender);
            txtEmail.Text = _employee.Email;
            txtPhone.Text = _employee.Phone.ToString();
            txtBirthdate.Value = _employee.Joindate;
            txtUsername.Text = _employee.Username;
            txtPassword.Text = _employee.Password;
            txtSalary.Text = _employee.Salary.ToString();
            txtJobRole.Text = _employee.EmpRole;

            foreach (DataRowView index in comboBranchId.Items)
            {

                if (index.Row["BR_ID"].ToString() == _employee.BranchId.ToString())
                {
                    comboBranchId.SelectedItem = index;
                }
            }
        }

        private void LoadData()
        {
            _context = new DataContext();
            branchBindingData.DataSource = _context.GetBranchesInfo();
            comboBranchId.DataSource = branchBindingData.DataSource;
            comboBranchId.DisplayMember = "BR_NAME";
            comboBranchId.ValueMember = "BR_ID";

            _employee = _context.GetEmployeeId(this._uId);
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBranchId.SelectedValue.ToString());
        }
    }
}
