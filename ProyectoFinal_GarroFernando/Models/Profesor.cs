using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_GarroFernando.Models
{
    public class Profesor
    {

        public int Id { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [ValidateNever]
        public Usuario Usuario { get; set; }

        public string Especialidad { get; set; }

        [Required]
        public bool Activo { get; set; }

    }
}
