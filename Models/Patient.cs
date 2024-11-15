using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AssessmentRiwi.Models;

[Table("patients")]
public class Patient
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]

     public int Id { get; set; }  
    [Column("user_id")]
    [ForeignKey("UserId")]
    public int UserId { get; set; }
    [Column("date_of_birth")]     
    public DateTime DateOfBirth { get; set; } 
    [Column("medical_history")] 
    public string MedicalHistory { get; set; }  
   
    public User User { get; set; } 
    [JsonIgnore] 
    public ICollection<Appointment> Appointments { get; set; }  

    public Patient()
    {
    }


}
