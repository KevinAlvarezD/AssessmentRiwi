using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentRiwi.Controllers.V1.Appointment
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public partial class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
    }
}