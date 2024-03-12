using HospitalAutomation.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Domain.Entities
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }     

        public Guid PoliclinicId { get; set; }
        public Policlinic Policlinic { get; set; }

        public ICollection<Patient> Patients { get; set; }
        public ICollection<Protocol> Protocols { get; set; }

    }
}
