using HospitalAutomation.Application.Repositories.DoctorRepo;
using HospitalAutomation.Application.RequestParameters;
using HospitalAutomation.Application.ViewModels.Doctors;
using HospitalAutomation.Domain.Entities;
using HospitalAutomation.Persistence.Repositories.DoctorRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAutomation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorReadRepository _doctorReadRepository;
        private readonly IDoctorWriteRepository _doctorWriteRepository;


        public DoctorsController(IDoctorWriteRepository doctorWriteRepository, IDoctorReadRepository doctorReadRepository)
        {
            _doctorWriteRepository = doctorWriteRepository;
            _doctorReadRepository = doctorReadRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] Pagination pagination)
        {
            var totalCount = _doctorReadRepository.GetAll(false).Count();
            var doctors = _doctorReadRepository.GetAll(false).Skip(pagination.Page * pagination.Size).Take(pagination.Size).Select(d => new
            {
               d.Name,
               d.Surname,
               d.IdentificationNumber,
               d.CreatedDate,
               d.UpdatedDate

            });
            return Ok(new
            {
                totalCount,
                doctors
            });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _doctorReadRepository.GetSingleAsync(id, false));
        }

        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Doctor model)
        {
            await _doctorWriteRepository.AddAsync(new()
            {
                Name = model.Name,
                Surname = model.Surname,
                IdentificationNumber = model.IdentificationNumber
            });
            await _doctorWriteRepository.SaveAsync();
            return Ok();
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(string id)
        {

            await _doctorWriteRepository.RemoveAsync(id);
            await _doctorWriteRepository.SaveAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(VM_Update_Doctor model)
        {
            Doctor doctor = await _doctorReadRepository.GetSingleAsync(model.Id);
            doctor.Name = model.Name;
            doctor.Surname = model.Surname;
            await _doctorWriteRepository.SaveAsync();
            return Ok();

        }
    }
}
