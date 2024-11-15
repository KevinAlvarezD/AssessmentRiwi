using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentRiwi.DTOs;

public class PatientDTO
{
     public int UserId { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string MedicalHistory { get; set; }

}
