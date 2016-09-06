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
    public partial class DonateBloodEntry : Form
    {
        private string _action;
        private int _branchId;
        private DataContext _context;
        private Blood blood;
        private int donateId;
        private AllBloodDonateForm allBloodDonateForm;
        private DateTime lastDonate;

        public DonateBloodEntry(AllBloodDonateForm allBloodDonateForm, string _action, int donateId, int _branchId)
        {
            this.allBloodDonateForm = allBloodDonateForm;
            this._action = _action;
            this.donateId = donateId;
            this._branchId = _branchId;

            InitializeComponent();

            comboDonorID.SelectedIndex = 0;
            txtReceiveDate.Value = DateTime.Now;
            
        }

        private void CheckAction(string _action)
        {
            if (_action == "Save" && donateId == 0)
            {
                btnAction.Text = _action;
            }
            else
            {
                lblTitle.Text = "Update Donate Blood Information";
                btnAction.Text = _action;
                _context = new DataContext();
                blood = _context.GetDonateBloodById(this.donateId);
                LoadData(blood);
            }
        }

        private void LoadData(Blood donor1)
        {
            txtId.Text = donor1.BlId.ToString();
            txtReceiveDate.Value = donor1.ReceivedDate;
            foreach (DataRowView index in comboDonorID.Items)
            {

                if (index.Row["DRID"].ToString() == donor1.DonorId.ToString())
                {
                    comboDonorID.SelectedItem = index;
                }
            }
        }

        private void DonorEntryForm_Load(object sender, EventArgs e)
        {
            _context = new DataContext();
            donorList.DataSource = _context.GetAllDonorsList(0);
            comboDonorID.DataSource = donorList.DataSource;
            comboDonorID.DisplayMember = "DR_NAME";
            comboDonorID.ValueMember = "DRID";

            CheckAction(_action);
        }


        private void btnAction_Click(object sender, EventArgs e)
        {
                Blood blood = new Blood()
                {
                    BlId = Convert.ToInt32(txtId.Text),
                    ReceivedDate = txtReceiveDate.Value,
                    DonorId = Convert.ToInt32(comboDonorID.SelectedValue),
                    BranchId = this._branchId
                };

                

                if (btnAction.Text == "Save")
                {
                    _context = new DataContext();
                    Donor d = _context.GetDonorById(blood.DonorId);
                    d.LastDonetDate = blood.ReceivedDate;
                    if (_context.SaveDonateBlood(blood) && _context.UpdateDonerInfo(d))
                    {
                        MessageBox.Show("Donate Blood Info Saved!");
                        this.allBloodDonateForm.LoadTableData();
                        this.Dispose();
                        
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong!!");
                    }

                }
                else if (btnAction.Text == "Update")
                {
                    _context = new DataContext();
                    Donor d = _context.GetDonorById(blood.DonorId);
                    d.LastDonetDate = blood.ReceivedDate;
                    if (_context.UpdateDonateBlood(blood) && _context.UpdateDonerInfo(d))
                    {
                        MessageBox.Show("Donate Blood Info Updated!");
                        this.allBloodDonateForm.LoadTableData();
                        this.Dispose();

                    }
                    else
                    {
                        MessageBox.Show("Something Wrong!!");
                    }
                }
                else
                {
                    this.Dispose();
                }
        }
    }
}
