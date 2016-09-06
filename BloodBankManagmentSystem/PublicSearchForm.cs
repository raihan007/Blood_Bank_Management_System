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
    public partial class PublicSearchForm : Form
    {
        private DataContext _context;
        public PublicSearchForm()
        {
            InitializeComponent();
            comboSearchOptions.SelectedIndex = 0;
        }

        private void PublicSearchForm_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void LoadAllData()
        {
            _context = new DataContext();

            SearchGrid.DataSource = _context.GetPublicViewData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _context = new DataContext();
            int s = comboSearchOptions.SelectedIndex;

            SearchGrid.DataSource = _context.PublicSearch(txtSearchKey.Text, comboSearchOptions.SelectedItem.ToString());

        }

        private void btnRefreash_Click(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Entrance en = new Entrance();
            en.Show();
        }

    }
}
