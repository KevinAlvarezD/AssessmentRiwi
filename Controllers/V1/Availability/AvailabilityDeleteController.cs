using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentRiwi.Controllers.V1.Availability
{
    public partial class AvailabilityController
    {
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var availability = await _availabilityService.GetByIdAsync(id);
            if (availability == null) return NotFound();

            await _availabilityService.DeleteAsync(id);
            return NoContent();
        }
    }
}