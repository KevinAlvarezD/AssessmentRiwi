using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.Models;
using Microsoft.EntityFrameworkCore;

namespace AssessmentRiwi.Seeders
{
    public class DoctorSeeder
    {
        public static void SeedDoctors(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    UserId = 6,  
                    Specialty = "Cardiología",
                    OfficeHours = "Lunes a Viernes, 9:00 AM - 5:00 PM"
                },
                new Doctor
                {
                    UserId = 8,  
                    Specialty = "Dermatología",
                    OfficeHours = "Lunes a Viernes, 10:00 AM - 4:00 PM"
                },
                new Doctor
                {
                    UserId = 10, 
                    Specialty = "Pediatría",
                    OfficeHours = "Martes y Jueves, 8:00 AM - 3:00 PM"
                },
                new Doctor
                {
                    UserId = 12, 
                    Specialty = "Psiquiatría",
                    OfficeHours = "Lunes, Miércoles y Viernes, 11:00 AM - 6:00 PM"
                }
            );
        }

    }
}