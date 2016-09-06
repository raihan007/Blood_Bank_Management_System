using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagmentSystem.Entities
{
    public class Branches
    {
        public int BranchId { get; set; }

        public String BranchName { get; set; }

        public String BranchPhone { get; set; }

        public String BranchEmail { get; set; }

        public int LocationId { get; set; }

        public int ManagerId { get; set; }

        public Locations Location { get; set; }
    }
}
