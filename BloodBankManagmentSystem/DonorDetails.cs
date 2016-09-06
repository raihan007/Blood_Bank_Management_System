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
    public partial class DonorDetails : Form
    {
        private string _action;
        private int _branchId;
        private DataContext _context;
        private Donor donor;
        private int donorId;
        private DonorDashBoard donorForm;
        private DateTime lastDonate;

        public DonorDetails(DonorDashBoard donorForm, string _action, int donorId, int _branchId)
        {
            this.donorForm = donorForm;
            this._action = _action;
            this.donorId = donorId;
            this._branchId = _branchId;

            InitializeComponent();

            comboBloodGroup.SelectedIndex = 0;
            comboGender.SelectedIndex = 0;
            txtBirthdate.Value = DateTime.Now.AddYears(-15);
            txtLastDonateDate.Value = DateTime.Now.AddYears(-10);
            CheckAction(_action);
        }

        private void CheckAction(string _action)
        {
            if (_action == "Save" && donorId == 0)
            {
                checkboNever.Checked = true;
                btnAction.Text = _action;
            }
            else if (_action == "Update" && donorId != 0)
            {
                checkboNever.Checked = false;
                lblTitle.Text = "Update Donor Information";
                btnAction.Text = _action;
                _context = new DataContext();
                donor = _context.GetDonorById(this.donorId);
                LoadData(donor);
            }
            else
            {
                checkboNever.Checked = false;
                lblTitle.Text = "Details Donor Information";
                btnAction.Text = "Back";
                _context = new DataContext();
                donor = _context.GetDonorById(this.donorId);
                LoadData(donor);

            }
        }

        private void LoadData(Donor donor1)
        {
            txtId.Text = donor1.DrId.ToString();
            txtName.Text = donor1.Name;
            txtAddress.Text = donor1.Locations.Address;
            txtEmail.Text = donor1.Email;
            txtPhone.Text = donor1.Phone;
            txtState.Text = donor1.Locations.State;
            txtZipCode.Text = donor1.Locations.ZipCode.ToString();
            txtCity.Text = donor1.Locations.City;
            txtCountry.Text = donor1.Locations.Country;
            comboBloodGroup.SelectedIndex = comboBloodGroup.Items.IndexOf(donor1.BloodGroup);
            txtAddressId.Text = donor1.Locations.LocationId.ToString();
            txtBirthdate.Value = donor1.Birthdate;
            txtLastDonateDate.Value = donor1.LastDonetDate;
        }

        private void DonorEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void checkboNever_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboNever.Checked == true)
            {
                lblLastDonate.Visible = false;
                txtLastDonateDate.Visible = false;
                lastDonate = DateTime.Now.AddYears(-60);
            }
            else
            {
                lblLastDonate.Visible = true;
                txtLastDonateDate.Visible = true;
                lastDonate = txtLastDonateDate.Value;
            }
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

                Donor donor = new Donor()
                {
                    DrId = Convert.ToInt32(txtId.Text),
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Gender = (String)comboGender.SelectedItem,
                    BloodGroup = (String)comboBloodGroup.SelectedItem,
                    Birthdate = txtBirthdate.Value,
                    BranchId = this._branchId,
                    LastDonetDate = txtLastDonateDate.Value,
                    AddressId = Convert.ToInt32(txtAddressId.Text),
                    Locations = locations
                };

                if (btnAction.Text == "Save")
                {
                    _context = new DataContext();
                    int locationId = _context.NextSequenceNo("LOCATIONS_SEQ");

                    locations.LocationId = locationId;
                    donor.AddressId = locationId;
                    if (_context.SaveDonerLocation(locations))
                    {
                        if (_context.SaveDonerInfo(donor))
                        {
                            MessageBox.Show("Donor Info Saved!");
                            this.Dispose();
                        }
                        else
                        {
                            _context.DeleteLocation(locationId);
                            MessageBox.Show("Something Wrong!!");
                        }
                    }

                }
                else if (btnAction.Text == "Update")
                {
                    _context = new DataContext();
                    if (_context.UpdateDonerInfo(donor) && _context.UpdateDonerLocation(locations))
                    {
                        MessageBox.Show("Successfully Updated.");
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
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Something Wrong!!");
            //}
        }
    }
}
