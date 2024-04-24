using HospitalAutomation.Application.Features.Command.Patients.UpdatePatient;
using HospitalAutomation.Application.Repositories.PatientRepo;
using HospitalAutomation.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Application.Features.Commands.Patients.UpdatePatient
{
    public class UpdatePatientCommandHandler : IRequestHandler<UpdatePatientCommandRequest, UpdatePatientCommandResponse>
    {
        readonly IPatientWriteRepository _patientWriteRepository;
        readonly IPatientReadRepository _patientReadRepository;

        public UpdatePatientCommandHandler(IPatientWriteRepository patientWriteRepository, IPatientReadRepository patientReadRepository)
        {
            _patientWriteRepository = patientWriteRepository;
            _patientReadRepository = patientReadRepository;
        }
        public async Task<UpdatePatientCommandResponse> Handle(UpdatePatientCommandRequest request, CancellationToken cancellationToken)
        {

            Patient p = await _patientReadRepository.GetSingleAsync(request.Id);
            p.Name = request.Name;
            p.Surname = request.Surname;
            p.IdentificationNumber = request.IdentificationNumber;
            p.FatherName = request.FatherName;
            p.MotherName = request.MotherName;

           await _patientWriteRepository.SaveAsync();

            return new();

        }


    }
}
