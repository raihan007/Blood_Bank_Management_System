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

namespace BloodBankManagmentSystem.Bloood_Request
{
    public partial class BloodReqEntryForm : Form
    {
        private string _action;
        private int _branchId;
        private DataContext _context;
        private BloodRequest blooodRequest;
        private int BloodReqId;
        private BloodRequestForm blReqForm;

        public BloodReqEntryForm(BloodRequestForm blReqForm, string _action, int BloodReqId, int _branchId)
        {
            this.blReqForm = blReqForm;
            this._action = _action;
            this.BloodReqId = BloodReqId;
            this._branchId = _branchId;
            InitializeComponent();

            comboBloodGroup.SelectedIndex = 0;
            comboStatus.SelectedIndex = 0;
            

            CheckAction(_action);
        }

        private void CheckAction(string _action)
        {
            if (_action == "Save" && BloodReqId==0)
            {
                comboStatus.Enabled = false;
                btnAction.Text = _action;
            }
            else
            {
                deliveryDate.Enabled = true;
                label6.Text = "Update Blood Request Information";
                btnAction.Text = _action;
                _context = new DataContext();
                blooodRequest = _context.GetBloodReqById(this.BloodReqId);
                LoadData(blooodRequest);
            }
        }

        private void LoadData(BloodRequest blooodRequest)
        {
            txtId.Text = blooodRequest.BloodReqId.ToString();
            txtName.Text = blooodRequest.Name;
            txtRemarks.Text = blooodRequest.Remarks;
            comboBloodGroup.SelectedIndex = comboBloodGroup.Items.IndexOf(blooodRequest.NeededBloodGrp);
            comboStatus.SelectedIndex = comboStatus.Items.IndexOf(blooodRequest.RequestStatus);
            txtEmail.Text = blooodRequest.Email;
            txtPhone.Text = blooodRequest.Phone;
            if (blooodRequest.DeliveryDate == null)
            {
                deliveryDate.Value = DateTime.Now;
            }
            else
            {
                deliveryDate.Value = (DateTime) blooodRequest.DeliveryDate;
            }

            txtNeededUnit.Text = blooodRequest.NeededBloodAmount.ToString();
            txtGivenUnit.Text = blooodRequest.GivenBloodAmount.ToString();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            BloodRequest bloodRequest = new BloodRequest()
            {
                BloodReqId = Convert.ToInt32(txtId.Text),
                Name = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                Remarks = txtRemarks.Text,
                RequestDate = DateTime.Now,
                NeededBloodGrp = (String) comboBloodGroup.SelectedItem,
                NeededBloodAmount = Convert.ToInt32(txtNeededUnit.Text),
                GivenBloodAmount = Convert.ToInt32(txtGivenUnit.Text),
                RequestStatus = (String) comboStatus.SelectedItem,
                DeliveryDate = deliveryDate.Value,
                BranchId = this._branchId
            };

            if (_action == "Save")
            {
                _context = new DataContext();
                if (_context.SaveBloodRequest(bloodRequest))
                {
                    MessageBox.Show("Successfully Saved.");
                    this.blReqForm.LoadTableData();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Failed to Save.");
                }
            }
            else
            {
                _context = new DataContext();
                if (_context.UpdateBloodRequest(bloodRequest))
                {
                    MessageBox.Show("Successfully Updated.");
                    this.blReqForm.LoadTableData();
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
