using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AssessmentRiwi.Models;

[Table("doctors")]
public class Doctor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]

     public int Id { get; set; }

    [Column("user_id")]
    [ForeignKey("UserId")]
    public int UserId { get; set; }
    public User User { get; set; } 
    [Column("specialty")]
    public string Specialty { get; set; } 
    [Column("office_hours")]
    public string OfficeHours { get; set; }

    [JsonIgnore]
    public ICollection<Appointment> Appointments { get; set; } 
    [JsonIgnore]
    public ICollection<Availability> Availabilities { get; set; } 

    public Doctor()
    {
    }

}
