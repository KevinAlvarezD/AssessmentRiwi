using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentRiwi.Controllers.V1.Appointment
{
    public partial class AppointmentController
    {
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var appointment = await _appointmentService.GetByIdAsync(id);
            if (appointment == null) return NotFound();

            await _appointmentService.DeleteAsync(id);
            return NoContent();
        }
    }
}