using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagmentSystem.Entities
{
    public class BloodRequest
    {
        public int BloodReqId { get; set; }

        public String Name { get; set; }

        public String Email { get; set; }

        public String Phone { get; set; }

        public DateTime RequestDate { get; set; }

        public String NeededBloodGrp { get; set; }

        public int NeededBloodAmount { get; set; }

        public int GivenBloodAmount { get; set; }

        public String RequestStatus { get; set; }

        public DateTime DeliveryDate { get; set; }

        public int BranchId { get; set; }

        public String Remarks { get; set; }

        public Branches Branches { get; set; }
    }
}
