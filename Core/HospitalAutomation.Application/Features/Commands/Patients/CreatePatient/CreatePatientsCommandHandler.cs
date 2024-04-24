using HospitalAutomation.Application.Repositories.PatientRepo;
using HospitalAutomation.Application.ViewModels.Patients;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Application.Features.Commands.CreatePatient
{
    public class CreatePatientsCommandHandler : IRequestHandler<CreatePatientsCommandRequest, CreatePatientsCommandResponse>
    {
         readonly IPatientWriteRepository _patientWriteRepository;

        public CreatePatientsCommandHandler(IPatientWriteRepository patientWriteRepository)
        {
            _patientWriteRepository = patientWriteRepository;
        }
        public async Task<CreatePatientsCommandResponse>Handle(CreatePatientsCommandRequest request, CancellationToken cancellationToken)
        {
            await _patientWriteRepository.AddAsync(new()
            {
                Name = request.Name,
                Surname = request.Surname,
                FatherName = request.FatherName,
                MotherName = request.MotherName,
                IdentificationNumber = request.IdentificationNumber,


            });

            await _patientWriteRepository.SaveAsync();
            return new();

        }
    }
}
