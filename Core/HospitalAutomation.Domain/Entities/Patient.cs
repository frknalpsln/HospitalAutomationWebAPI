using HospitalAutomation.Domain.Entities.Common;
using HospitalAutomation.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Domain.Entities
{
    public class Patient : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int BirthDate { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public long IdentificationNumber { get; set; }
        public string BloodGroup { get; set; }
        public string Image { get; set; }

        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Protocol> Protocols { get; set; }


    }
}
