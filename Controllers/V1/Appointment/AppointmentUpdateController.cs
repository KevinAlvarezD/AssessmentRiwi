using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentRiwi.Controllers.V1.Appointment
{
    public partial class AppointmentController
    {
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] AppointmentDTO appointmentDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var updatedAppointment = await _appointmentService.UpdateAsync(id, appointmentDto);
            if (updatedAppointment == null) return NotFound();

            return Ok(updatedAppointment);
        }
    }
}