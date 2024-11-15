using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentRiwi.Controllers.V1.Doctor
{
   
    public partial class DoctorController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll([FromServices] IDoctorService doctorService)
        {
            var doctors = await doctorService.GetAllDoctorsAsync();
            return Ok(doctors);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id, [FromServices] IDoctorService doctorService)
        {
            var doctor = await doctorService.GetDoctorByIdAsync(id);
            if (doctor == null)
                return NotFound($"Doctor con ID {id} no encontrado.");

            return Ok(doctor);
        }

        
    }
}