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

namespace BloodBankManagmentSystem.Shared
{
    public partial class LogActivityForm : Form
    {
        private int _branchId;
        private DataContext _context;
        public LogActivityForm(int _branchId)
        {
            this._branchId = _branchId;
            InitializeComponent();
            comboDSearchOptions.SelectedIndex = 0;
            comboSearchOptions.SelectedIndex = 0;
            DLoginDate.Value = DateTime.Now;
            LoginDate.Value = DateTime.Now;
        }

        private void LogActivityForm_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void LoadAllData()
        {
            _context = new DataContext();

            EmpLogActivityGrid.DataSource = _context.GetEmpLogActivityInfo(this._branchId);

            DonorLoginActivityGrid.DataSource = _context.GetDonorLogActivityInfo(this._branchId);

        }

        private void comboSearchOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSearchOptions.SelectedIndex != 0)
            {
                LoginDate.Visible = false;
                txtSearchKey.Visible = true;
            }
            else
            {
                LoginDate.Visible = true;
                txtSearchKey.Visible = false;
            }
        }

        private void comboDSearchOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDSearchOptions.SelectedIndex != 0)
            {
                DLoginDate.Visible = false;
                txtDSearchKey.Visible = true;
            }
            else
            {
                DLoginDate.Visible = true;
                txtDSearchKey.Visible = false;
            }
        }

        private void btnEmpLogSearch_Click(object sender, EventArgs e)
        {
            _context = new DataContext();
            int s = comboSearchOptions.SelectedIndex;

            if (s == 0)
            {
                EmpLogActivityGrid.DataSource = _context.SearchEmpLogActivityInfo(LoginDate.Value, this._branchId);
            }

            if (s == 1)
            {
                EmpLogActivityGrid.DataSource = _context.SearchEmpLogActivityInfo(txtSearchKey.Text, this._branchId);
            }

            if (s == 2)
            {
                int uId;

                if (Int32.TryParse(txtSearchKey.Text,out uId))
                {
                    EmpLogActivityGrid.DataSource = _context.SearchEmpLogActivityInfo(uId, this._branchId);
                }
                else
                {
                    MessageBox.Show("Please Insert Valid User Id No.!");
                }
                
            }

        }

        private void btnDSearch_Click(object sender, EventArgs e)
        {
            _context = new DataContext();
            int s = comboDSearchOptions.SelectedIndex;

            if (s == 0)
            {
                DonorLoginActivityGrid.DataSource = _context.SearchDonorLogActivityInfo(DLoginDate.Value, this._branchId);
            }

            if (s == 1)
            {
                DonorLoginActivityGrid.DataSource = _context.SearchDonorLogActivityInfo(txtDSearchKey.Text, this._branchId);
            }

            if (s == 2)
            {
                int dId;

                if (Int32.TryParse(txtDSearchKey.Text, out dId))
                {
                    DonorLoginActivityGrid.DataSource = _context.SearchDonorLogActivityInfo(dId,this._branchId);
                }
                else
                {
                    MessageBox.Show("Please Insert Valid Donor Id No.!");
                }

            }
        }
    }
}
