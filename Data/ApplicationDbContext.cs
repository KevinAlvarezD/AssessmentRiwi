using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssessmentRiwi.Models;
using AssessmentRiwi.Seeders;

namespace AssessmentRiwi.Data;

public class ApplicationDbContext : DbContext
{
   
    public DbSet<User> Users { get; set; }
    public DbSet<Doctor>Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Availability> Availabilities { get; set; }
     
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        UserSeeder.Seed(modelBuilder);
        DoctorSeeder.SeedDoctors(modelBuilder);
        PatientSeeder.SeedPatients(modelBuilder);

    }
}
