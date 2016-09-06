using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagmentSystem.Entities
{
    public class Donor
    {
        public int DrId { get; set; }

        public String Name { get; set; }

        public String Phone { get; set; }

        public String Gender { get; set; }

        public int AddressId { get; set; }

        public String Email { get; set; }

        public String BloodGroup { get; set; }

        public DateTime Birthdate { get; set; }

        public int BranchId { get; set; }

        public DateTime LastDonetDate { get; set; }

        public String Username { get; set; }

        public String Password { get; set; }

        public int DonetDays { get; set; }

        public Locations Locations { get; set; }
    }
}
