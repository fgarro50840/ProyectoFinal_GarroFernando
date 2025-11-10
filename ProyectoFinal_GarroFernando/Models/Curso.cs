using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_GarroFernando.Models
{
    public class Curso
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del curso es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre del curso no puede exceder los 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El código del curso es obligatorio")]
        [StringLength(15, ErrorMessage = "El código del curso no puede exceder los 15 caracteres")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Los créditos del curso son obligatorios")]
        [Range(1, 5, ErrorMessage = "Los créditos del curso deben estar entre 1 y 5")]
        public int Creditos { get; set; }
        [Required(ErrorMessage = "La carrera es obligatoria")]
        public int CarreraId { get; set; }

        [ValidateNever]
        public Carrera Carrera { get; set; }

    }
}
