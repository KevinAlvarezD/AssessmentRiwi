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
                    Role = "admin"
                },
                new User
                {
                    Id = 6,
                    Name = "Keyla",
                    LastName = "Mesa Lopera",
                    Email = "keyla.lopera@riwi.io",
                    Password = PasswordHasher.HashPassword("key123456"),
                    Role = "doctor"
                },
                new User
        {
            Id = 7,
            Name = "Juan",
            LastName = "Perez",
            Email = "juan.perez@riwi.io",
            Password = PasswordHasher.HashPassword("juan1234"),
            Role = "patient"
        },
        new User
        {
            Id = 8,
            Name = "Marta",
            LastName = "Gomez",
            Email = "marta.gomez@riwi.io",
            Password = PasswordHasher.HashPassword("marta5678"),
            Role = "doctor"
        },
        new User
        {
            Id = 9,
            Name = "Carlos",
            LastName = "Lopez",
            Email = "carlos.lopez@riwi.io",
            Password = PasswordHasher.HashPassword("carlos1122"),
            Role = "patient"
        },
        new User
        {
            Id = 10,
            Name = "Ana",
            LastName = "Martinez",
            Email = "ana.martinez@riwi.io",
            Password = PasswordHasher.HashPassword("ana3344"),
            Role = "doctor"
        },
        new User
        {
            Id = 11,
            Name = "Luis",
            LastName = "Ramirez",
            Email = "luis.ramirez@riwi.io",
            Password = PasswordHasher.HashPassword("luis4455"),
            Role = "patient"
        },
        new User
        {
            Id = 12,
            Name = "Sofia",
            LastName = "Diaz",
            Email = "sofia.diaz@riwi.io",
            Password = PasswordHasher.HashPassword("sofia6677"),
            Role = "doctor"
        },
        new User
        {
            Id = 13,
            Name = "Felipe",
            LastName = "Mendez",
            Email = "felipe.mendez@riwi.io",
            Password = PasswordHasher.HashPassword("felipe8899"),
            Role = "patient"
        }


            );
        }    
    }
}
