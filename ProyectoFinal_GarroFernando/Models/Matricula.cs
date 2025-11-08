using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_GarroFernando.Models
{
    public class Matricula
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "El estudiante es obligatorio.")]
        public int EstudianteId { get; set; }
        [ValidateNever]
        public Estudiante Estudiante { get; set; }
        [Required(ErrorMessage = "El semestre es obligatorio.")]
        [StringLength(20, ErrorMessage = "El semestre no puede exceder los 20 caracteres.")]
        public string Semestre { get; set; }

        public DateTime FechaMatricula { get; set; }
        public EstadoMatricula Estado { get; set; }
        [ValidateNever]
        public ICollection<MatriculaDetalle> Detalles { get; set; }

    }
}
