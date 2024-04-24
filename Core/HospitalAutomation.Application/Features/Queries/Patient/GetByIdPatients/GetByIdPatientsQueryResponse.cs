using HospitalAutomation.Domain.Entities;
using HospitalAutomation.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Application.Features.Queries.Patients.GetByIdPatients
{
    public class GetByIdPatientsQueryResponse
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string IdentificationNumber { get; set; }

        
    }
}
