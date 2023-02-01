using SistemaWebMisRecetas.Helpers;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Models
{
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
        public string Categoria { get; set; }        

        [Column(TypeName = "varchar(200)")]
        [Required(ErrorMessage = "El campo es obligatorio")]        
        public string Instrucciones { get; set; }

        [Column(TypeName = "varchar(200)")]
        [Required(ErrorMessage = "El campo es obligatorio")]        
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
        [EdadAtributte]
        [Display(Name = "Edad Autor")]
        public int EdadAutor { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Se debe ingresar un email")]
        [Display(Name = "Email Autor")]
        public string EmailAutor { get; set; }
    }
}