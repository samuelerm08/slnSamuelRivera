using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SistemaWebMisRecetas.Models.Helpers;

namespace SistemaWebMisRecetas.Models
{
    public enum Categoria
    {
        Desayuno, Almuerzo, Cena
    }

    [Table("Receta")]
    public class Receta
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Titulo { get; set; }

        [CategoriaAtributte]
        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public Categoria Categoria { get; set; }        
        
        [Required(ErrorMessage = "El campo es obligatorio")]
        [DataType(DataType.MultilineText)]
        public string Instrucciones { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]        
        [DataType(DataType.MultilineText)]
        public string Ingredientes { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        [Display(Name = "Nombre Autor")]
        public string NombreAutor { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        [Display(Name = "Apellido Autor")]
        public string ApellidoAutor { get; set; }
        
        [Required(ErrorMessage = "El campo es obligatorio")]
        [Display(Name = "Edad Autor")]
        [EdadAtributte] //Se valida que la edad del autor sea mayor a 18 años
        public int EdadAutor { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        [Display(Name = "Email Autor")]        
        [EmailAddress(ErrorMessage = "Se debe ingresar un email valido")] //Validacion email
        public string EmailAutor { get; set; }
    }
}