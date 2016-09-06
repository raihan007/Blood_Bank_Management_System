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

namespace BloodBankManagmentSystem.Bloood_Request
{
    public partial class BloodRequestForm : Form
    {
        private int _branchId;
        private DataContext _context;
        private int BloodReqId;
        public BloodRequestForm(int _branchId)
        {
            this._branchId = _branchId;
            InitializeComponent();
        }

        private void BloodRequestForm_Load(object sender, EventArgs e)
        {
            comboBloodGroup.SelectedIndex = 0;
            comboSearchOptions.SelectedIndex = 0;
            DeliveryDate.Value = DateTime.Now;
            ReceiveDate.Value = DateTime.Now;
            LoadTableData();
        }

        public void LoadTableData()
        {
            _context = new DataContext();
            BloodRequestGrid.DataSource = _context.GetAllBloodRequest(this._branchId);
            BloodRequestGrid.CurrentRow.Selected = false;
        }

        private void comboSearchOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSearchOptions.SelectedIndex == 0)
            {
                ReceiveDate.Visible = true;
                DeliveryDate.Visible = false;
                comboBloodGroup.Visible = false;
            }

            if (comboSearchOptions.SelectedIndex == 1)
            {
                ReceiveDate.Visible = false;
                DeliveryDate.Visible = true;
                comboBloodGroup.Visible = false;
            }

            if (comboSearchOptions.SelectedIndex == 2)
            {
                ReceiveDate.Visible = false;
                DeliveryDate.Visible = false;
                comboBloodGroup.Visible = true;
            }
        }

        private void btnRefreash_Click(object sender, EventArgs e)
        {
            LoadTableData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _context = new DataContext();
            
            if (comboSearchOptions.SelectedIndex == 0)
            {
                BloodRequestGrid.DataSource = _context.SearchBloodRequestByDate("ReceiveDate",ReceiveDate.Value,this._branchId);
                if (BloodRequestGrid.CurrentRow != null) BloodRequestGrid.CurrentRow.Selected = false;
            }
            else if (comboSearchOptions.SelectedIndex == 1)
            {
                BloodRequestGrid.DataSource = _context.SearchBloodRequestByDate("DeliveryDate", DeliveryDate.Value, this._branchId);
                if (BloodRequestGrid.CurrentRow != null) BloodRequestGrid.CurrentRow.Selected = false;
            }
            else
            {
                String searchText = (String)comboBloodGroup.SelectedItem;
                BloodRequestGrid.DataSource = _context.SearchBloodRequestByBloodGroup(searchText, this._branchId);
                if (BloodRequestGrid.CurrentRow != null) BloodRequestGrid.CurrentRow.Selected = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BloodReqEntryForm bloodReqEntry = new BloodReqEntryForm(this,"Save",0,this._branchId);
            bloodReqEntry.ShowDialog();
        }

        private void BloodRequestGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.BloodReqId = Convert.ToInt32(BloodRequestGrid.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (BloodRequestGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Specific Data First!");
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Are You Want To Update This?", "Confirm!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    BloodReqEntryForm bloodReqEntry = new BloodReqEntryForm(this,"Update", this.BloodReqId , this._branchId);
                    bloodReqEntry.ShowDialog();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (BloodRequestGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Specific Data First!");
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Are You Want To Delete This?", "Confirm!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    _context = new DataContext();
                    if (_context.DeleteBloodReq(this.BloodReqId))
                    {
                        MessageBox.Show("Successfully Deleted.");
                        LoadTableData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete.");
                    }
                }
            }
        }
    }
}
