using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentRiwi.Controllers.V1.Patient
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public partial class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }
    }
}