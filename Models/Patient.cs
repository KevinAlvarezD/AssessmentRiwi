using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentRiwi.Models;

public class Patient
{
     public int PatientId { get; set; }  
    public int UserId { get; set; }     
    public DateTime DateOfBirth { get; set; }  
    public string MedicalHistory { get; set; }  
   
    public User User { get; set; }  
    // public ICollection<Appointment> Appointments { get; set; }  

    public Patient()
    {
    }


}
