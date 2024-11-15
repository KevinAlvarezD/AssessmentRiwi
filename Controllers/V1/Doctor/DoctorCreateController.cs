using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.DTOs;
using AssessmentRiwi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentRiwi.Controllers.V1.Doctor
{
    
    public partial class DoctorController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] DoctorDTO doctorDto, [FromServices] IDoctorService doctorService)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await doctorService.AddDoctorAsync(doctorDto);
            return CreatedAtAction(nameof(GetById), new { id = doctorDto.UserId }, doctorDto);
        }
        
    }
}