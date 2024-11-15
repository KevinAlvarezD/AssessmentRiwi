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
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] PatientDTO patientDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var createdPatient = await _patientService.AddAsync(patientDto);
            return CreatedAtAction(nameof(GetById), new { id = createdPatient.UserId }, createdPatient);
        }
    }
}