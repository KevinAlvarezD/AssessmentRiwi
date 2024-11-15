using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssessmentRiwi.DTOs;

public class UserDTO
{
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "El apellido es obligatorio.")]
    [StringLength(50, ErrorMessage = "El apellido no puede exceder los 50 caracteres.")]
    public required string LastName { get; set; }

    [Required(ErrorMessage = "La contraseña es obligatoria.")]
    [StringLength(100, ErrorMessage = "La contraseña no puede exceder los 100 caracteres.")]
    public required string Password { get; set; }

    [Required(ErrorMessage = "El email es obligatorio.")]
    [EmailAddress(ErrorMessage = "El email no es válido.")]
    public required string Email { get; set; }

    [Required(ErrorMessage = "El rol es requerido.")]
    [ValidRole(ErrorMessage = "El rol debe ser 'admin', 'doctor' o 'patient'.")]
    public required string Role { get; set; }

    public class ValidRoleAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is string role)
            {
                if (role.Equals("admin", StringComparison.OrdinalIgnoreCase) ||
                    role.Equals("doctor", StringComparison.OrdinalIgnoreCase) ||
                    role.Equals("patient", StringComparison.OrdinalIgnoreCase))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(ErrorMessage);
        }
    }
}
