using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentRiwi.Models;

[Table("appointments")]

public class Appointment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }  
    [Column("patient_id")]
    [ForeignKey("PatientId")]
    public int PatientId { get; set; } 
     [Column("doctor_id")]
    [ForeignKey("DoctorId")]     
    public int DoctorId { get; set; }    
    [Column("appointment_date")]   
    public DateTime AppointmentDate { get; set; }  
    [Column("reason")]    
    public string Reason { get; set; }  
    [Column("status")]       
    public string Status { get; set; }      
    public Patient Patient { get; set; }  
    public Doctor Doctor { get; set; }  


}
