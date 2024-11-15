using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentRiwi.Controllers.V1.Availability
{
    public partial class AvailabilityController
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var availability = await _availabilityService.GetByIdAsync(id);
            if (availability == null) return NotFound();

            return Ok(availability);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var availabilities = await _availabilityService.GetAllAsync();
            return Ok(availabilities);
        }
    }
}