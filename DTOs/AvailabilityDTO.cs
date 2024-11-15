using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentRiwi.DTOs;

public class AvailabilityDTO
{
    [Required]
    public int DoctorId { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public TimeSpan StartHour { get; set; }

    [Required]
    public TimeSpan EndHour { get; set; }


}
