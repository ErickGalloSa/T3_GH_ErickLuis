using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace T3_GH_ErickLuis.Models
{
    public class Libro
    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "El titulo del Libro es obligatorio")]
        public String Titulo { get; set; }

        [Required(ErrorMessage = "El autor del Libro es obligatorio")]
        public String Autor { get; set; }

        [Required(ErrorMessage = "El tema del Libro es obligatorio")]
        public String Tema { get; set; }

        [Required(ErrorMessage = "El editorial del Libro es obligatorio")]
        public String Editorial { get; set; }

        [Required(ErrorMessage = "El año de publicacion del Libro es obligatorio")]
        public DateTime AnioPublicacion { get; set; }

        [Required(ErrorMessage = "El numero de paginas del Libro es obligatorio")]
        [Range(10, 1000, ErrorMessage = "El numero de paginas del Libro es entre 10 y 1000")]
        public int Paginas { get; set; }

        [Required(ErrorMessage = "La categoria del Libro es obligatorio")]
        public String Categoria { get; set; }
    }
}
