using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_GarroFernando.Models
{
    public class Carrera
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la carrera es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre de la carrera no puede exceder los 50 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El código de la carrera es obligatorio.")]
        [StringLength(10, ErrorMessage = "El código de la carrera no puede exceder los 10 caracteres.")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El estado de la carrera es obligatorio.")]
        public bool Activa { get; set; }

        [ValidateNever]
        public ICollection<Curso> Cursos { get; set; }

    }
}
