using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentRiwi.DTOs;

public class DoctorDTO
{
    public int UserId { get; set; }

    [Required(ErrorMessage = "La especialidad es obligatoria")]
    [StringLength(100, ErrorMessage = "La especialidad no puede superar los 100 caracteres")]
    public required string Specialty { get; set; }

    [Required(ErrorMessage = "Las horas de atención son obligatorias")]
    public required string OfficeHours { get; set; }


}
