using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Models.Helpers
{
    public class CategoriaAtributte : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            if ((Categoria)value != Categoria.Desayuno)
            {
                return new ValidationResult("Solo se permite ingresar la categoría desayuno!");
            }

            return ValidationResult.Success;
        }
    }
}
