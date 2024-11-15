using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentRiwi.Models;

public class Doctor
{
     public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } 
    public string Specialty { get; set; } 
    public string OfficeHours { get; set; }
    // public ICollection<Appointment> Appointments { get; set; } 
    // public ICollection<Availability> Availabilities { get; set; } 

    public Doctor()
    {
    }

}
