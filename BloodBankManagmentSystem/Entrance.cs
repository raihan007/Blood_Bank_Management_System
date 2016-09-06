using System;
using System.Windows.Forms;
using BloodBankManagmentSystem.Database;
using BloodBankManagmentSystem.Employee_Work;

namespace BloodBankManagmentSystem
{
    public partial class Entrance : Form
    {
        private DataContext _db;
        public Entrance()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            _db = new DataContext();

            int uId = _db.GetLogger(txtUsername.Text, txtPassword.Text);

            if (uId == 0)
            {
                MessageBox.Show("Wrong Username or Password", "Invalid Login");
            }
            else
            {
                String type = _db.CheckUserType(uId);
                bool log = true; 
                _db.InsertLogActivity(uId);
                if (log == true && type == "bloodbank")
                {
                    AdminDashBoard adminDashboard = new AdminDashBoard(uId);
                    adminDashboard.Show();
                    this.Hide();
                }
                if (log == true && type == "DONOR")
                {
                    DonorDashBoard adminDashboard = new DonorDashBoard(uId);
                    adminDashboard.Show();
                    this.Hide();
                }
                if (log == true && type == "EMPLOYEE")
                {
                    BranchDashBoard branchDashboard = new BranchDashBoard(uId);
                    branchDashboard.Show();
                    this.Hide();
                }
            }
        }

        private void Entrance_Load(object sender, EventArgs e)
        {
            
        }

        private void Entrance_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSarch_Click(object sender, EventArgs e)
        {
            PublicSearchForm p = new PublicSearchForm();
            p.Show();
            this.Hide();
        }
    }
}
