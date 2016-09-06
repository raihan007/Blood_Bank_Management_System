using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagmentSystem.Entities
{
    public class Locations
    {
        public int LocationId { get; set; }

        public String Address { get; set; }

        public String State { get; set; }

        public String City { get; set; }

        public int ZipCode { get; set; }

        public String Country { get; set; }
    }
}
