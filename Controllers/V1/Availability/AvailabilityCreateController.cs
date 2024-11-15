using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentRiwi.Controllers.V1.Availability
{
    public partial class AvailabilityController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AvailabilityDTO availabilityDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var createdAvailability = await _availabilityService.AddAsync(availabilityDto);
            return CreatedAtAction(nameof(GetById), new { id = createdAvailability.DoctorId }, createdAvailability);
        }
    }
}