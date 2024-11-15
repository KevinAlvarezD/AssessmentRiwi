using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentRiwi.Models;

[Table("users")]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }
    [Column("last_name")]
    public string LastName { get; set; }
    [Column("password")]
    public string Password { get; set; }
    [Column("email")]
    public string Email { get; set; }
    [Column("phone")]
    public string Role { get; set; }


    public User()
    {  
    }


}
