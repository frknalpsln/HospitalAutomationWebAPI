using HospitalAutomation.Application.Repositories.PatientRepo;
using HospitalAutomation.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Application.Features.Commands.Patients.DeletePatient
{
    public class DeletePatientCommandHandler : IRequestHandler<DeletePatientCommandRequest, DeletePatientCommandResponse>
    {
        readonly IPatientWriteRepository _patientWriteRepository;

        public DeletePatientCommandHandler(IPatientWriteRepository patientWriteRepository)
        {
            _patientWriteRepository = patientWriteRepository;
             
        }

        public async Task<DeletePatientCommandResponse> Handle(DeletePatientCommandRequest request, CancellationToken cancellationToken)
        {
            await _patientWriteRepository.RemoveAsync(request.Id);
            await _patientWriteRepository.SaveAsync();
            return new();


        }
    }
}
