// using Microsoft.AspNetCore.Identity;
// using Microsoft.EntityFrameworkCore;
// using AssessmentRiwi.Models;
// using AssessmentRiwi.Helpers;

// namespace AssessmentRiwi.Seeders
// {
//     public class UserSeeder
//     {
//         public static void Seed(ModelBuilder modelBuilder)
//         {
//             modelBuilder.Entity<User>().HasData(
//                 new User
//                 {   
//                     Id = 5,
//                     Name = "Kevin ",
//                     LastName = "Alvarez Diaz",
//                     Email = "kev@riwi.io",
//                     Password = PasswordHasher.HashPassword("Kevin*554169"),
//                     Role = "admin"
//                 },
//                 new User
//                 {
//                     Id = 6,
//                     Name = "Keyla",
//                     LastName = "Mesa Lopera",
//                     Email = "keyla.lopera@riwi.io",
//                     Password = PasswordHasher.HashPassword("key123456"),
//                     Role = "customer"
//                 }
//             );
//         }    
//     }
// }
