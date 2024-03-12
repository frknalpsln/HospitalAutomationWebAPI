using HospitalAutomation.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Domain.Entities
{
    public class Policlinic : BaseEntity
    {
        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Protocol> Protocols { get; set; }
    
    }
}
