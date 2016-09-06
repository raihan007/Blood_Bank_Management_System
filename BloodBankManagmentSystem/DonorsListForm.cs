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
    public partial class DonorsListForm : Form
    {
        private int _branchId;
        private DataContext _context;
        private int donorId;

        public DonorsListForm(int _branchId)
        {
            this._branchId = _branchId;
            InitializeComponent();
        }

        private void DonorsListForm_Load(object sender, EventArgs e)
        {
            comboSearchOptions.SelectedIndex = 0;
            LoadTableData();
        }

        public void LoadTableData()
        {
            _context = new DataContext();
            DonorsGrid.DataSource = _context.GetAllDonorsList(this._branchId);
            if (DonorsGrid.CurrentRow != null) DonorsGrid.CurrentRow.Selected = false;
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
                DonorsGrid.DataSource = _context.GetSearchedDonorsList(this._branchId, searchKey, comboSearchOptions.SelectedItem.ToString());
                if (DonorsGrid.CurrentRow != null) DonorsGrid.CurrentRow.Selected = false;
            }

            if (comboSearchOptions.SelectedIndex == 1)
            {
                DonorsGrid.DataSource = _context.GetSearchedDonorsList(this._branchId, searchKey, comboSearchOptions.SelectedItem.ToString());
                if (DonorsGrid.CurrentRow != null) DonorsGrid.CurrentRow.Selected = false;
            }

            if (comboSearchOptions.SelectedIndex == 2)
            {
                DonorsGrid.DataSource = _context.GetSearchedDonorsList(this._branchId, searchKey, comboSearchOptions.SelectedItem.ToString());
                if (DonorsGrid.CurrentRow != null) DonorsGrid.CurrentRow.Selected = false;
            }

            if (comboSearchOptions.SelectedIndex == 3)
            {
                DonorsGrid.DataSource = _context.GetSearchedDonorsList(this._branchId, searchKey, comboSearchOptions.SelectedItem.ToString());
                if (DonorsGrid.CurrentRow != null) DonorsGrid.CurrentRow.Selected = false;
            }
        }

        private void btnRefreash_Click(object sender, EventArgs e)
        {
            LoadTableData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DonorEntryForm donorEntry = new DonorEntryForm(this, "Save", 0, this._branchId);
            donorEntry.ShowDialog();
        }

        private void DonorsGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.donorId = Convert.ToInt32(DonorsGrid.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DonorsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Specific Data First!");
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Are You Want To Update This?", "Confirm!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    DonorEntryForm donorEntry = new DonorEntryForm(this, "Update", this.donorId, this._branchId);
                    donorEntry.ShowDialog();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (DonorsGrid.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Please Select Specific Data First!");
            //}
            //else
            //{
            //    DialogResult result1 = MessageBox.Show("Are You Want To Delete This?", "Confirm!", MessageBoxButtons.YesNo);
            //    if (result1 == DialogResult.Yes)
            //    {
            //        _context = new DataContext();
            //        if (_context.DeleteLogin(this.donorId))
            //        {
            //            MessageBox.Show("Successfully Deleted.");
            //            LoadTableData();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Failed to Delete.");
            //        }
            //    }
            //}
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (DonorsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Specific Data First!");
            }
            else
            {
                DonorEntryForm donorEntry = new DonorEntryForm(this, "Details", this.donorId, this._branchId);
                donorEntry.ShowDialog();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
