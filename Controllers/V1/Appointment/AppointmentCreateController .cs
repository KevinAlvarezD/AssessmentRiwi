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
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AppointmentDTO appointmentDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var createdAppointment = await _appointmentService.AddAsync(appointmentDto);
            return CreatedAtAction(nameof(GetById), new { id = createdAppointment.PatientId }, createdAppointment);
        }
    }
}