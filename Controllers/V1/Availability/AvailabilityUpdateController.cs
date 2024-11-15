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
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] AvailabilityDTO availabilityDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var updatedAvailability = await _availabilityService.UpdateAsync(id, availabilityDto);
            if (updatedAvailability == null) return NotFound();

            return Ok(updatedAvailability);
        }
    }
}