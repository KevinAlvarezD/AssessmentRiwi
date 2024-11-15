using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.Models;
using Microsoft.EntityFrameworkCore;

namespace AssessmentRiwi.Seeders;

public class PatientSeeder
{
    public static void SeedPatients(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Patient>().HasData(
        new Patient
        {
            UserId = 7,  
            DateOfBirth = new DateTime(1985, 7, 15),
            MedicalHistory = "Alergia a ciertos medicamentos, hipertensión controlada."
        },
        new Patient
        {
            UserId = 9,  
            DateOfBirth = new DateTime(1990, 5, 22),
            MedicalHistory = "No tiene antecedentes médicos graves."
        },
        new Patient
        {
            UserId = 11, 
            DateOfBirth = new DateTime(1988, 11, 3),
            MedicalHistory = "Asma leve, no requiere medicación regular."
        },
        new Patient
        {
            UserId = 13, 
            DateOfBirth = new DateTime(1995, 12, 10),
            MedicalHistory = "Diabetes tipo 2, en tratamiento con insulina."
        }
    );
}


}
