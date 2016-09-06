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
    public partial class DonorDonateHistory : Form
    {
        private DataContext _context;
        private int donorId;
        public DonorDonateHistory(int donorId)
        {
            this.donorId = donorId;
            InitializeComponent();
            txtDonateDate.Value = DateTime.Now;
        }

        private void DonorDonateHistory_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void LoadAllData()
        {
            _context = new DataContext();

            SearchGrid.DataSource = _context.GetDonorDonateHistroyData(this.donorId);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _context = new DataContext();

            SearchGrid.DataSource = _context.SearchDonorDonateHistroyData(txtDonateDate.Value,this.donorId);

        }

        private void btnRefreash_Click(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SearchGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

    }
}
