using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.Models;
using Microsoft.EntityFrameworkCore;

namespace AssessmentRiwi.Seeders;

public class AvailabilitySeeder
{
    public static void SeedAvailabilities(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Availability>().HasData(
        new Availability
        {
            Id = 1,
            DoctorId = 6, // Keyla
            Date = new DateTime(2024, 11, 20), // wednesday
            StartHour = new TimeSpan(9, 0, 0),  // 9:00 AM
            EndHour = new TimeSpan(12, 0, 0)    // 12:00 PM
        },
        new Availability
        {
            Id = 2,
            DoctorId = 6, // Keyla
            Date = new DateTime(2024, 11, 20), // wednesday
            StartHour = new TimeSpan(14, 0, 0),  // 2:00 PM
            EndHour = new TimeSpan(17, 0, 0)    // 5:00 PM
        },
        new Availability
        {
            Id = 3,
            DoctorId = 6, // Keyla
            Date = new DateTime(2024, 11, 21), // wednesday
            StartHour = new TimeSpan(9, 0, 0),  // 9:00 AM
            EndHour = new TimeSpan(12, 0, 0)    // 12:00 PM
        },
        new Availability
        {
            Id = 4,
            DoctorId = 6, // Keyla
            Date = new DateTime(2024, 11, 21), // thursday
            StartHour = new TimeSpan(14, 0, 0),  // 2:00 PM
            EndHour = new TimeSpan(17, 0, 0)    // 5:00 PM
        },

        // Disponibilidad de Laura (Doctor) - DoctorId = 8
        new Availability
        {
            Id = 5,
            DoctorId = 8, // Laura
            Date = new DateTime(2024, 11, 19), // tuesday
            StartHour = new TimeSpan(9, 0, 0),  // 9:00 AM
            EndHour = new TimeSpan(12, 0, 0)    // 12:00 PM
        },
        new Availability
        {
            Id = 6,
            DoctorId = 8, // Laura
            Date = new DateTime(2024, 11, 19), // tuesday
            StartHour = new TimeSpan(14, 0, 0),  // 2:00 PM
            EndHour = new TimeSpan(17, 0, 0)    // 5:00 PM
        },
        new Availability
        {
            Id = 7,
            DoctorId = 8, // Laura
            Date = new DateTime(2024, 11, 22), // friday
            StartHour = new TimeSpan(9, 0, 0),  // 9:00 AM
            EndHour = new TimeSpan(12, 0, 0)    // 12:00 PM
        },
        new Availability
        {
            Id = 8,
            DoctorId = 8, // Laura
            Date = new DateTime(2024, 11, 22), // friday
            StartHour = new TimeSpan(14, 0, 0),  // 2:00 PM
            EndHour = new TimeSpan(17, 0, 0)    // 5:00 PM
        }
    );
}


}
