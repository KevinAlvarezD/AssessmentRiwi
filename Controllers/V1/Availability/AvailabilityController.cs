using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentRiwi.Controllers.V1.Availability
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public partial class AvailabilityController : ControllerBase
    {
        private readonly IAvailabilityService _availabilityService;

        public AvailabilityController(IAvailabilityService availabilityService)
        {
            _availabilityService = availabilityService;
        }
    }
}