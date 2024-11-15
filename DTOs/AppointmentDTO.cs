using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentRiwi.DTOs;

public class AppointmentDTO
{
    public int PatientId { get; set; }      
    public int DoctorId { get; set; }       
    public DateTime AppointmentDate { get; set; }  
    public required string Reason { get; set; }       
    public required string Status { get; set; }  


}
