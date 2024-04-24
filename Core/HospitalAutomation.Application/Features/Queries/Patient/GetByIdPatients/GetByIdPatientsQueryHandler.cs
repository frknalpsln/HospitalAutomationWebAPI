using HospitalAutomation.Application.Features.Queries.Patients.GetByIdPatients;
using HospitalAutomation.Application.Repositories.PatientRepo;
using p = HospitalAutomation.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Application.Features.Queries.Patient.GetByIdPatients
{
    public class GetByIdPatientsQueryHandler : IRequestHandler<GetByIdPatientsQueryRequest, GetByIdPatientsQueryResponse>
    {
        readonly IPatientReadRepository _patientReadRepository;

        public GetByIdPatientsQueryHandler(IPatientReadRepository patientReadRepository)
        {
            _patientReadRepository = patientReadRepository;
        }

        public async Task<GetByIdPatientsQueryResponse> Handle(GetByIdPatientsQueryRequest request, CancellationToken cancellationToken)
        {
          p.Patient patient = await _patientReadRepository.GetSingleAsync(request.Id, false);

            return new()
            {
                Name = patient.Name,
                Surname = patient.Surname,
                FatherName = patient.FatherName,
                MotherName = patient.MotherName,
                IdentificationNumber = patient.IdentificationNumber,
            };

        }
    }
}
