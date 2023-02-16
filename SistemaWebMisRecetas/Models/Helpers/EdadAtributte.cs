using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Models.Helpers
{
    public class EdadAtributte : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            int edad = (int)value;

            if (edad < 18)
            {
                return new ValidationResult("Solo se aceptan edades mayores o iguales a 18!");
            }

            return ValidationResult.Success;
        }
    }
}
