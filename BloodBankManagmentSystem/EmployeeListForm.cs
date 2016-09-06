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
    public partial class EmployeeListForm : Form
    {
        private int _branchId;
        private DataContext _context;
        private int employeeId;

        public EmployeeListForm(int _branchId)
        {
            this._branchId = _branchId;
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            comboSearchOptions.SelectedIndex = 0;
            LoadTableData();
        }

        public void LoadTableData()
        {
            _context = new DataContext();
            EmployeesGrid.DataSource = _context.GetAllEmployeesList(this._branchId);
            if (EmployeesGrid.CurrentRow != null) EmployeesGrid.CurrentRow.Selected = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _context = new DataContext();

            EmployeesGrid.DataSource = _context.EmployeeSearch(txtSearchKey.Text, comboSearchOptions.SelectedItem.ToString());
        }

        private void btnRefreash_Click(object sender, EventArgs e)
        {
            LoadTableData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmpEntryForm donorEntry = new EmpEntryForm(this, "Save", 0, this._branchId);
            donorEntry.ShowDialog();
        }

        private void EmployeesGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.employeeId = Convert.ToInt32(EmployeesGrid.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (EmployeesGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Specific Data First!");
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Are You Want To Update This?", "Confirm!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    EmpEntryForm donorEntry = new EmpEntryForm(this, "Update", this.employeeId, this._branchId);
                    donorEntry.ShowDialog();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (EmployeesGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Specific Data First!");
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Are You Want To Delete This?", "Confirm!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    _context = new DataContext();
                    if (_context.DeleteLogin(this.employeeId))
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
            if (EmployeesGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Specific Data First!");
            }
            else
            {
                EmpEntryForm donorEntry = new EmpEntryForm(this, "Details", this.employeeId, this._branchId);
                donorEntry.ShowDialog();
            }
        }
    }
}
