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
    public partial class BranchForm : Form
    {
        private int _branchId;
        private DataContext _context;
        private String _actionType;
        private Branches _branches;
        private AllBranchesForm allBranchesForm;
        public BranchForm(Form f,int _branchId, String _actionType)
        {
            try
            {
                this.allBranchesForm = (AllBranchesForm)f;
            }
            catch (Exception)
            {
                this.allBranchesForm = new AllBranchesForm();
            }
            
            this._branchId = _branchId;
            this._actionType = _actionType;
            InitializeComponent();

        }

        private void BranchForm_Load(object sender, EventArgs e)
        {
            _context = new DataContext();
            managerBindingData.DataSource = _context.GetAllManagersInfo();
            comboManagerId.DataSource = managerBindingData.DataSource;
            comboManagerId.DisplayMember = "EMP_NAME";
            comboManagerId.ValueMember = "USERID";

            _branches = _context.GetBranchInfoById(this._branchId);
            
            CheckAction();
        }

        private void CheckAction()
        {
            if (_actionType == "View" && _branchId != 0)
            {
                label6.Select();
                ShowData(_branches);
                btnAction.Visible = false;
            }
            if (_actionType == "Save" && _branchId == 0)
            {
                btnAction.Visible = true;
                btnAction.Text = _actionType;
            }
            if (_actionType == "Update" && _branchId != 0)
            {
                btnAction.Visible = true;
                btnAction.Text = _actionType;
                ShowData(_branches);
            }
        }

        private void ShowData(Branches _branches)
        {
            txtId.Text = _branches.BranchId.ToString();
            txtName.Text = _branches.BranchName;
            txtAddress.Text = _branches.Location.Address;
            txtEmail.Text = _branches.BranchEmail;
            txtPhone.Text = _branches.BranchPhone;
            txtState.Text = _branches.Location.State;
            txtZipCode.Text = _branches.Location.ZipCode.ToString();
            txtCity.Text = _branches.Location.City;
            txtCountry.Text = _branches.Location.Country;
            txtAddressId.Text = _branches.Location.LocationId.ToString();
            foreach (DataRowView index in comboManagerId.Items)
            {

                if (index.Row["USERID"].ToString() == _branches.ManagerId.ToString())
                {
                    comboManagerId.SelectedItem = index;
                }
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            Locations locations = new Locations()
            {
                LocationId = Convert.ToInt32(txtAddressId.Text),
                Address = txtAddress.Text,
                State = txtState.Text,
                City = txtCity.Text,
                ZipCode = Convert.ToInt32(txtZipCode.Text),
                Country = txtCountry.Text
            };

            Branches branches = new Branches()
            {
                BranchId = Convert.ToInt32(txtId.Text),
                BranchName = txtName.Text,
                BranchEmail = txtEmail.Text,
                BranchPhone = txtPhone.Text,
                LocationId = Convert.ToInt32(txtAddressId.Text),
                ManagerId = Convert.ToInt32(comboManagerId.SelectedValue),
                Location = locations
            };

            if (btnAction.Text == "Save")
            {
                _context = new DataContext();
                int locationId = _context.NextSequenceNo("LOCATIONS_SEQ");

                locations.LocationId = locationId;
                branches.LocationId = locationId;
                if (_context.SaveDonerLocation(locations))
                {
                    if (_context.SaveBranchInfo(branches))
                    {
                        MessageBox.Show("Branche Info Saved!");
                        this.allBranchesForm.LoadTableData();
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
            else
            {
                _context = new DataContext();
                if (_context.UpdateBranchInfo(branches) && _context.UpdateDonerLocation(locations))
                {
                    MessageBox.Show("Successfully Updated.");
                    this.allBranchesForm.LoadTableData();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Failed to Update.");
                }
            }
        }
    }
}
