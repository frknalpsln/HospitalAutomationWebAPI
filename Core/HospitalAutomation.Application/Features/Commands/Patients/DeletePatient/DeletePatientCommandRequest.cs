using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Application.Features.Commands.Patients.DeletePatient
{
    public class DeletePatientCommandRequest : IRequest<DeletePatientCommandResponse>
    {
        public string Id { get; set; }
    }
}
