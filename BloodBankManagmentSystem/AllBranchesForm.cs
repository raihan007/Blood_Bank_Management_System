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
    public partial class AllBranchesForm : Form
    {
        private DataContext _context;
        private int branchId;
        public AllBranchesForm()
        {
            InitializeComponent();
            comboSearchOptions.SelectedIndex = 0;
        }

        private void AllBranchesForm_Load(object sender, EventArgs e)
        {
            LoadTableData();
        }

        public void LoadTableData()
        {
            _context = new DataContext();
            BranchesGrid.DataSource = _context.GetAllBranchesList();

            //List<int> totalEmp = _context.TotalEmpList(0);
            //List<int> totalDon = _context.TotalDonList(0);
            //DataGridViewColumn totalEmpColumn = new DataGridViewColumn();
            //totalEmpColumn.Name = "Total_Employees";
            //totalEmpColumn.HeaderText = "Total Employees";
            //totalEmpColumn.CellTemplate = new DataGridViewTextBoxCell();
            //BranchesGrid.Columns.Insert(3, totalEmpColumn);

            //DataGridViewColumn totalDonColumn = new DataGridViewColumn();
            //totalDonColumn.Name = "Total_Donors";
            //totalDonColumn.HeaderText = "Total Donors";
            //totalDonColumn.CellTemplate = new DataGridViewTextBoxCell();
            //BranchesGrid.Columns.Insert(4, totalDonColumn);

            //foreach (DataGridViewRow row in BranchesGrid.Rows)
            //{
            //    row.Cells[3].Value = totalEmp[row.Index].ToString();
            //    row.Cells[4].Value = totalDon[row.Index].ToString();
            //}

            if (BranchesGrid.CurrentRow != null) BranchesGrid.CurrentRow.Selected = false;
        }


        private void BranchesGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.branchId = Convert.ToInt32(BranchesGrid.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BranchForm branchForm = new BranchForm(this,0, "Save");
            branchForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (BranchesGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Specific Data First!");
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Are You Want To Update This?", "Confirm!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    BranchForm branchForm = new BranchForm(this, this.branchId, "Update");
                    branchForm.ShowDialog();
                }
            }
            
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (BranchesGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Specific Data First!");
            }
            else
            {
                BranchForm branchForm = new BranchForm(this, this.branchId, "View");
                branchForm.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (BranchesGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Specific Data First!");
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Are You Want To Delete This?", "Confirm!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    _context = new DataContext();
                    if (_context.DeleteBranchInfo(this.branchId))
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _context = new DataContext();

            BranchesGrid.DataSource = _context.SearchBranch(txtSearchKey.Text, comboSearchOptions.SelectedItem.ToString());
        }

        
    }
}
