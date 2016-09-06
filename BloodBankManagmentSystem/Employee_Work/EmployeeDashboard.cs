using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagmentSystem.Employee_Work
{
    public partial class EmployeeDashboard : Form
    {
        private Entrance entrance;
        private int uId;
        public EmployeeDashboard(Entrance entrance, int uId)
        {
            InitializeComponent();
            this.entrance = entrance;
            this.uId = uId;
        }
    }
}
