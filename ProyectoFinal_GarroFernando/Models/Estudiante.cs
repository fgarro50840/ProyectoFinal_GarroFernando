using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_GarroFernando.Models
{
    public class Estudiante
    {

        public int Id { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [ValidateNever]
        public Usuario Usuario { get; set; }

        public DateTime FechaInscripcion { get; set; }
        [ValidateNever]
        public ICollection<Matricula> Matriculas { get; set; }

        public bool Activo { get; set; }

    }
}
