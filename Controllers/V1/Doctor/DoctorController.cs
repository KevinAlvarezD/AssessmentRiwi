using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.Data;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentRiwi.Controllers.V1.Doctor
{
    [ApiController]
    [Route("api/[controller]")]
    public partial class DoctorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DoctorController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}