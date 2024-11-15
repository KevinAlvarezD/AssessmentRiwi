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
         [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, [FromServices] IDoctorService doctorService)
        {
            try
            {
                await doctorService.DeleteDoctorAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        
    }
}