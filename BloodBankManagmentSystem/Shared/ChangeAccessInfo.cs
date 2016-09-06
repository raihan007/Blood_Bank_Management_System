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
using BloodBankManagmentSystem.Entities;

namespace BloodBankManagmentSystem.Shared
{
    public partial class ChangeAccessInfo : Form
    {
        private int uId;
        private DataContext _context;
        private Access _access;
        public ChangeAccessInfo(int uId)
        {
            this.uId = uId;
            InitializeComponent();
            _context = new DataContext();
            _access = _context.GetAccessInfo(this.uId);
            txtCurrentPassword.Text = _access.Password.ToString();
            txtPresentUsername.Text = _access.Username.ToString();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)//Products Info
            {
                txtPresentUsername.Text = _access.Username.ToString();
                ClearInput();
            }

            if (tabControl1.SelectedIndex == 1)//Employees Info
            {
                txtCurrentPassword.Text = _access.Password.ToString();
                ClearInput();
            }
        }

        private void ClearInput()
        {
            txtConfirmPassword.Text = "";
            txtNewPassword.Text = "";

            txtNewUsername.Text = "";
            txtConfirmUsername.Text = "";
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == txtCurrentPassword.Text)
            {
                DialogResult result1 = MessageBox.Show("Are You Want To Change Your Password?", "Confirm!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    _context = new DataContext();
                    if (_context.ChangePassword(this.uId,txtNewPassword.Text))
                    {
                        MessageBox.Show("Password Successfully Updated.");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Update Password.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, Confirm Your Password First !!!!");
            }
        }

        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            if (txtNewUsername.Text == txtConfirmUsername.Text)
            {
                DialogResult result1 = MessageBox.Show("Are You Want To Change Your Username?", "Confirm!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    _context = new DataContext();
                    if (_context.ChangeUsername(this.uId, txtNewUsername.Text))
                    {
                        MessageBox.Show("Username Successfully Updated.");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Update Username.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, Confirm Your Username First !!!!");
            }
        }
    }
}
