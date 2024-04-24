using HospitalAutomation.Application.Repositories.PatientRepo;
using HospitalAutomation.Application.RequestParameters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Application.Features.Queries.Patients.GetAllPatients
{
    public class GetAllPatientsQueryHandler : IRequestHandler<GetAllPatientsQueryRequest, GetAllPatientsQueryResponse>
    {
        private IPatientReadRepository _patientReadRepository;
        public GetAllPatientsQueryHandler(IPatientReadRepository patientReadRepository)
        {
            _patientReadRepository = patientReadRepository;
        }


        public async Task<GetAllPatientsQueryResponse> Handle(GetAllPatientsQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _patientReadRepository.GetAll(false).Count();
            var patients = _patientReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).Select(p => new
            {
                p.Id,
                p.Name,
                p.Surname,
                p.FatherName,
                p.MotherName,
                p.IdentificationNumber,
                p.CreatedDate,
                p.UpdatedDate,
            }).ToList();

            return new()
            {
                TotalCount = totalCount,
                Patients = patients
            };
        }

    }
}
