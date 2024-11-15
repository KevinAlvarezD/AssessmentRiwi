using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentRiwi.Controllers.V1.Patient
{
    public partial class PatientController
    {
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] PatientDTO patientDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var updatedPatient = await _patientService.UpdateAsync(id, patientDto);
            if (updatedPatient == null) return NotFound();

            return Ok(updatedPatient);
        }
    }
}