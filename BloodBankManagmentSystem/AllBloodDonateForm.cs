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

namespace BloodBankManagmentSystem
{
    public partial class AllBloodDonateForm : Form
    {
        private int _branchId;
        private DataContext _context;
        private int donateId;

        public AllBloodDonateForm(int _branchId)
        {
            this._branchId = _branchId;
            InitializeComponent();
        }

        private void AllBloodDonateForm_Load(object sender, EventArgs e)
        {
            comboSearchOptions.SelectedIndex = 0;
            LoadTableData();
        }

        public void LoadTableData()
        {
            _context = new DataContext();
            DonateBloodGrid.DataSource = _context.GetAllDonateList(this._branchId);
            if (DonateBloodGrid.CurrentRow != null) DonateBloodGrid.CurrentRow.Selected = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _context = new DataContext();
            String searchKey = "";
            if (txtSearchKey.Text!="")
            {
                searchKey = txtSearchKey.Text;
            }
            if (comboSearchOptions.SelectedIndex == 0)
            {
                DonateBloodGrid.DataSource = _context.GetSearchedBloodDonatList(this._branchId, txtSearchDate.Value);
                if (DonateBloodGrid.CurrentRow != null) DonateBloodGrid.CurrentRow.Selected = false;
            }

            if (comboSearchOptions.SelectedIndex == 1)
            {
                DonateBloodGrid.DataSource = _context.GetSearchedBloodDonatList(this._branchId, searchKey);
                if (DonateBloodGrid.CurrentRow != null) DonateBloodGrid.CurrentRow.Selected = false;
            }
        }

        private void btnRefreash_Click(object sender, EventArgs e)
        {
            LoadTableData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DonateBloodEntry doneBloodEntry = new DonateBloodEntry(this, "Save", 0, this._branchId);
            doneBloodEntry.ShowDialog();
        }

        private void DonateBloodGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.donateId = Convert.ToInt32(DonateBloodGrid.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DonateBloodGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Specific Data First!");
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Are You Want To Update This?", "Confirm!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    DonateBloodEntry donorEntry = new DonateBloodEntry(this, "Update", this.donateId, this._branchId);
                    donorEntry.ShowDialog();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DonateBloodGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Specific Data First!");
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Are You Want To Delete This?", "Confirm!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    _context = new DataContext();
                    if (_context.DeleteDonateBlood(this.donateId))
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

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (DonateBloodGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Specific Data First!");
            }
            else
            {
                DonateBloodEntry donorEntry = new DonateBloodEntry(this, "Details", this.donateId, this._branchId);
                donorEntry.ShowDialog();
            }
        }

        private void comboSearchOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSearchOptions.SelectedIndex == 0)
            {
                txtSearchKey.Visible = false;
                txtSearchDate.Visible = true;
            }
            else
            {
                txtSearchKey.Visible = true;
                txtSearchDate.Visible = false;
            }

        }
    }
}
