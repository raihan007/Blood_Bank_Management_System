using System;
using System.Windows.Forms;
using BloodBankManagmentSystem.Bloood_Request;
using BloodBankManagmentSystem.Database;
using BloodBankManagmentSystem.Shared;

namespace BloodBankManagmentSystem
{
    public partial class DonorDashBoard : Form
    {
        private int uId;
        private int _branchId;
        private DataContext _context;
        public DonorDashBoard(int uId)
        {
            InitializeComponent();
            this.uId = uId;
            clock.Start();
            String date = "Today :" + DateTime.Today.ToShortDateString();
            lblDate.Text = date;
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lblTime.Text = time.ToString("hh:mm:ss tt");
        }

        private void DonorDashBoard_Load(object sender, EventArgs e)
        {
            label6.Select();
            _context = new DataContext();
            this._branchId = _context.GetBranchId(this.uId);

        }

        private void btnOwnProfile_Click(object sender, EventArgs e)
        {
            BranchForm branchForm = new BranchForm(this,this._branchId, "View");
            branchForm.ShowDialog();
        }

        private void BranchDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void settingsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            changeSettingsMenu.Show(settingsLink, 0, settingsLink.Height);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeAccessInfo changeAccessInfo = new ChangeAccessInfo(this.uId);
            changeAccessInfo.ShowDialog();
        }

        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Entrance _entrance = new Entrance();
            _entrance.Show();
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            DonorDetails donorEntry = new DonorDetails(this, "Details", this.uId, this._branchId);
            donorEntry.ShowDialog();
        }

        

        private void btnBllodInfo_Click(object sender, EventArgs e)
        {
            DonorDonateHistory allBlood = new DonorDonateHistory(this.uId);
            allBlood.ShowDialog();
        }

    }
}
