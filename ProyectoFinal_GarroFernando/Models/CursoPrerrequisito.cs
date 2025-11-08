using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_GarroFernando.Models
{
    public class CursoPrerrequisito
    {
        [Required]
        public int CursoId { get; set; }
        [ValidateNever]
        public Curso Curso { get; set; }
        [Required]
        public int RequisitoId { get; set; }
        [ValidateNever]
        public Curso Requisito { get; set; }


    }
}
