using System;
using System.Windows.Forms;
using BloodBankManagmentSystem.Bloood_Request;
using BloodBankManagmentSystem.Database;
using BloodBankManagmentSystem.Shared;

namespace BloodBankManagmentSystem
{
    public partial class BranchDashBoard : Form
    {
        private int uId;
        private int _branchId;
        private DataContext _context;
        public BranchDashBoard(int uId)
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

        private void BranchDashBoard_Load(object sender, EventArgs e)
        {
            label6.Select();
            _context = new DataContext();
            this._branchId = _context.GetBranchId(this.uId);
            //CheckPrivilege(this._branchId);
            GetAllInfoCunt(this._branchId);
        }

        //private void CheckPrivilege(int p)
        //{
        //    throw new NotImplementedException();
        //}

        private void GetAllInfoCunt(int branchId)
        {
            lblTotalEmpNo.Text = GetTotalEmpNo(branchId);
            label13.Text = GetTotalBlBagNo(branchId);
            label14.Text = GetTotalDonorNo(branchId);
            label15.Text = GetTotalBloodReqNo(branchId);
            label16.Text = GetTotalActiveDonorNo(branchId);
        }

        private string GetTotalEmpNo(int bId)
        {
            _context = new DataContext();
            return _context.TotalNo("SELECT EMPLOYEE_COUNT("+ bId +") FROM dual");
        }

        private string GetTotalBlBagNo(int bId)
        {
            _context = new DataContext();
            return _context.TotalNo("SELECT BLOODS_COUNT(" + bId + ") FROM dual");
        }

        private string GetTotalDonorNo(int bId)
        {
            _context = new DataContext();
            return _context.TotalNo("SELECT DONOR_COUNT(" + bId + ") FROM dual");
        }

        private string GetTotalActiveDonorNo(int bId)
        {
            _context = new DataContext();
            return _context.TotalNo("SELECT ACTIVE_DONORS_COUNT(" + bId + ") FROM dual");
        }

        private string GetTotalBloodReqNo(int bId)
        {
            _context = new DataContext();
            return _context.TotalNo("SELECT BLOOD_REQ_COUNT(" + bId + ") FROM dual");
        }

        private void btnRefreash_Click(object sender, EventArgs e)
        {
            GetAllInfoCunt(this._branchId);
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
            OwnProfileForm ownProfileForm = new OwnProfileForm(this.uId, "View");
            ownProfileForm.ShowDialog();
        }

        private void btnLogInfo_Click(object sender, EventArgs e)
        {
            LogActivityForm logActivityForm = new LogActivityForm(this._branchId);
            logActivityForm.ShowDialog();
        }

        private void btnBloodReqInfo_Click(object sender, EventArgs e)
        {
            BloodRequestForm bloodRequestForm = new BloodRequestForm(this._branchId);
            bloodRequestForm.ShowDialog();
        }

        private void btnDonorInfo_Click(object sender, EventArgs e)
        {
            DonorsListForm donorsList = new DonorsListForm(this._branchId);
            donorsList.ShowDialog();
        }

        private void btnBranchInfo_Click(object sender, EventArgs e)
        {
            AllBranchesForm a = new AllBranchesForm();
            a.ShowDialog();
        }

        private void btnBllodInfo_Click(object sender, EventArgs e)
        {
            AllBloodDonateForm allBlood = new AllBloodDonateForm(this._branchId);
            allBlood.ShowDialog();
        }

        private void btnEmpInfo_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm(this._branchId);
            employeeListForm.ShowDialog();
        }

    }
}
