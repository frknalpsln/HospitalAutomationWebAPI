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
        private readonly DoctorReadRepository _doctorReadRepository;
        private readonly DoctorWriteRepository _doctorWriteRepository;

        public DoctorsController(DoctorWriteRepository doctorWriteRepository, DoctorReadRepository doctorReadRepository)
        {
            _doctorWriteRepository = doctorWriteRepository;
            _doctorReadRepository = doctorReadRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok( _doctorReadRepository.GetAll(false));
        }
        [HttpGet("id")]
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
            });
            await _doctorWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpDelete("id")]
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
