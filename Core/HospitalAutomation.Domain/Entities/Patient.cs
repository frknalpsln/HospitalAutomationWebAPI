﻿using HospitalAutomation.Domain.Entities.Common;
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
        public DateOnly BirthDate { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string IdentificationNumber { get; set; }       

        public BloodGroupType BloodGroupType { get; set; }
        public GenderType GenderType { get; set; }

        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Protocol> Protocols { get; set; }


    }
}
