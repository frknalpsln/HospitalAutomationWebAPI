using HospitalAutomation.Application.Features.Commands.Patients.UpdatePatient;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Application.Features.Command.Patients.UpdatePatient
{
    public class UpdatePatientCommandRequest : IRequest<UpdatePatientCommandResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string IdentificationNumber { get; set; }
    }
}
