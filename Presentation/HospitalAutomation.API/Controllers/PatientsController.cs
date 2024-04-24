using HospitalAutomation.Application.Features.Command.Patients.UpdatePatient;
using HospitalAutomation.Application.Features.Commands.CreatePatient;
using HospitalAutomation.Application.Features.Commands.Patients.DeletePatient;
using HospitalAutomation.Application.Features.Commands.Patients.UpdatePatient;
using HospitalAutomation.Application.Features.Queries.Patients.GetAllPatients;
using HospitalAutomation.Application.Features.Queries.Patients.GetByIdPatients;
using HospitalAutomation.Application.Repositories.PatientRepo;
using HospitalAutomation.Application.RequestParameters;
using HospitalAutomation.Application.ViewModels.Patients;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HospitalAutomation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {

        private readonly IPatientReadRepository _patientReadRepository;
        private readonly IPatientWriteRepository _patientWriteRepository;
        readonly IMediator _mediator;

        public PatientsController(IPatientWriteRepository patientWriteRepository, IPatientReadRepository patientReadRepository, IMediator mediator)
        {
            _patientWriteRepository = patientWriteRepository;
            _patientReadRepository = patientReadRepository;
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllPatientsQueryRequest getAllPatientsQueryRequest)
        {
            GetAllPatientsQueryResponse response = await _mediator.Send(getAllPatientsQueryRequest);
            return Ok(response);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdPatientsQueryRequest getByIdPatientsQueryRequest)
        {
            GetByIdPatientsQueryResponse response = await _mediator.Send(getByIdPatientsQueryRequest);

            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreatePatientsCommandRequest createPatientsCommandRequest)
        {
            CreatePatientsCommandResponse response = await _mediator.Send(createPatientsCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);

        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdatePatientCommandRequest updatePatientCommandRequest)
        {
            UpdatePatientCommandResponse response = await _mediator.Send(updatePatientCommandRequest);

            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeletePatientCommandRequest deletePatientCommandRequest)
        {
            DeletePatientCommandResponse response = await _mediator.Send(deletePatientCommandRequest);

            return Ok();

        }
    }
}
