using HospitalAutomation.Application.ViewModels.Patients;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Application.Features.Commands.CreatePatient
{
    public class CreatePatientsCommandRequest : IRequest<CreatePatientsCommandResponse>
    {
        //public VM_Create_Patient Create_Patient { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string IdentificationNumber { get; set; }
    }
}
