using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AssessmentRiwi.Models;
using AssessmentRiwi.Helpers;

namespace AssessmentRiwi.Seeders
{
    public class UserSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {   
                    Id = 5,
                    Name = "Kevin ",
                    LastName = "Alvarez Diaz",
                    Email = "kev@riwi.io",
                    Password = PasswordHasher.HashPassword("Kevin*554169"),
                    Phone = "3132145678",
                    Address = "Cra 40 50 60",
                    Role = "admin"
                },
                new User
                {
                    Id = 6,
                    Name = "Keyla",
                    LastName = "Mesa Lopera",
                    Email = "keyla.lopera@riwi.io",
                    Password = PasswordHasher.HashPassword("key123456"),
                    Phone = "3221234567",
                    Address = "Cra 55 33 44",
                    Role = "customer"
                }
            );
        }    
    }
}
