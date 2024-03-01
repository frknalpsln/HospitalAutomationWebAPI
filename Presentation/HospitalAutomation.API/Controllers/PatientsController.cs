using HospitalAutomation.Application.Repositories.PatientRepo;
using HospitalAutomation.Persistence.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAutomation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientReadRepository _patientReadRepository;
        private readonly IPatientWriteRepository _patientWriteRepository;

        public PatientsController(IPatientWriteRepository patientWriteRepository, IPatientReadRepository patientReadRepository)
        {
            _patientWriteRepository = patientWriteRepository;
            _patientReadRepository = patientReadRepository;
        }
        [HttpGet]
        public async Task GetResult()
        {
            await _patientWriteRepository.AddAsync(new()
            {
                Id = Guid.NewGuid(), Name = "Furkan" , Surname = "Alpaslan" , Age = 25, Gender = "Erkek", IdentificationNumber = 11164004322
            });
           await _patientWriteRepository.SaveAsync();

        }
    }
}
