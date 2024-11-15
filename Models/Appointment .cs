using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentRiwi.Models;

public class Appointment
{
    public int AppointmentId { get; set; }  
    public int PatientId { get; set; }      
    public int DoctorId { get; set; }       
    public DateTime AppointmentDate { get; set; }  
    public string Reason { get; set; }         
    public string Status { get; set; }      
    public Patient Patient { get; set; }  
    public Doctor Doctor { get; set; }  


}
