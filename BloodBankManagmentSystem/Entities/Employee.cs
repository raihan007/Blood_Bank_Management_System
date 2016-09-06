using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagmentSystem.Entities
{
    public class Employee
    {
        public int UserID { get; set; }

        public String Name { get; set; }

        public int Phone { get; set; }

        public String Gender { get; set; }

        public int AddressId { get; set; }

        public String Email { get; set; }

        public int Salary { get; set; }

        public String EmpRole { get; set; }

        public int BranchId { get; set; }

        public DateTime Joindate { get; set; }

        public String Username { get; set; }

        public String Password { get; set; }

        public String Type { get; set; }

        public Locations Locations { get; set; }
    }
}
