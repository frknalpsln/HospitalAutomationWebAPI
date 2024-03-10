using HospitalAutomation.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Domain.Entities
{
    public class InsuranceType : BaseEntity
    {
        public string Definition { get; set; }       
        public bool Worker { get; set; }
        public bool Retired { get; set; }
        public bool SskStaff { get; set; }
        public bool Other {  get; set; }

        public ICollection<Patient> Patients { get; set; }


    }
}
