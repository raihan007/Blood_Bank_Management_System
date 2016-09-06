using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagmentSystem.Entities
{
    public class Blood
    {
        public int BlId { get; set; }

        public DateTime ReceivedDate { get; set; }

        public int DonorId { get; set; }

        public int BranchId { get; set; }

        public Donor Donor { get; set; }

        public Branches Branches { get; set; }

        
    }
}
