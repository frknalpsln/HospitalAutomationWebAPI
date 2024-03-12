using HospitalAutomation.Application.Repositories.AppointmentRepo;
using HospitalAutomation.Application.Repositories.PatientRepo;
using HospitalAutomation.Domain.Entities;
using HospitalAutomation.Persistence.Contexts;
using Microsoft.AspNetCore.Connections.Features;
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
        private readonly IProtocolWriteRepository _protocolWriteRepository;
        private readonly IProtocolReadRepository _protocolReadRepository;

        public PatientsController(IPatientWriteRepository patientWriteRepository, IPatientReadRepository patientReadRepository, IProtocolWriteRepository protocolWriteRepository, IProtocolReadRepository protocolReadRepository)
        {
            _patientWriteRepository = patientWriteRepository;
            _patientReadRepository = patientReadRepository;
            _protocolWriteRepository = protocolWriteRepository;
            _protocolReadRepository = protocolReadRepository;
        }
        [HttpGet]
        public async Task Get()
        {
         Patient p = await  _patientReadRepository.GetSingleAsync("0b888ca3-7611-4958-9629-aa0acb74f945");
            p.Surname = "ALPASLAN";
           await _patientWriteRepository.SaveAsync();
        }
    }
}
