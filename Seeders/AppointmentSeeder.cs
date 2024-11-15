using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.Models;
using Microsoft.EntityFrameworkCore;

namespace AssessmentRiwi.Seeders;

public class AppointmentSeeder
{
    public static void SeedAppointments(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Appointment>().HasData(
        new Appointment
        {
            Id = 1,
            DoctorId = 6, 
            PatientId = 7, 
            AppointmentDate = new DateTime(2024, 11, 20, 10, 30, 0), 
            Reason = "Consulta general"
        },
        new Appointment
        {
            Id = 2,
            DoctorId = 6, 
            PatientId = 9, 
            AppointmentDate = new DateTime(2024, 11, 21, 14, 0, 0),
            Reason = "Revisión de control"
        },
        new Appointment
        {
            Id = 3,
            DoctorId = 8, 
            PatientId = 11, 
            AppointmentDate = new DateTime(2024, 11, 22, 9, 0, 0),
            Reason = "Consulta de seguimiento"
        },
        new Appointment
        {
            Id = 4,
            DoctorId = 6, 
            PatientId = 13, 
            AppointmentDate = new DateTime(2024, 11, 23, 15, 30, 0),
            Reason = "Chequeo de diabetes"
        },
        new Appointment
        {
            Id = 5,
            DoctorId = 6, 
            PatientId = 7, 
            AppointmentDate = new DateTime(2024, 11, 24, 11, 0, 0),
            Reason = "Control de hipertensión"
        }
    );
}


}
