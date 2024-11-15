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
         [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] DoctorDTO doctorDto, [FromServices] IDoctorService doctorService)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                await doctorService.UpdateDoctorAsync(id, doctorDto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        
    }
}