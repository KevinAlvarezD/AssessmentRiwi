using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentRiwi.Models;

[Table("availabilities")]
public class Availability
{
    [Column("id")]
    public int Id { get; set; }

    [Column("doctor_id")]
    [ForeignKey("Doctor")]
    public int DoctorId { get; set; }

    public Doctor Doctor { get; set; }

    [Column("date")]
    
    public DateTime Date { get; set; }

    [Column("start_hour")]
    
    public TimeSpan StartHour { get; set; }

    [Column("end_hour")]

    public TimeSpan EndHour { get; set; }

    public Availability()
    {
    }

    

}
