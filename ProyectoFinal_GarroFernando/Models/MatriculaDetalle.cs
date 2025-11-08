using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_GarroFernando.Models
{
    public class MatriculaDetalle
    {

        public int Id { get; set; }
        public int MatriculaId { get; set; }
        public Matricula Matricula { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        [Required(ErrorMessage = "El detalle del grupo es obligatorio.")]
        [StringLength(10, ErrorMessage = "El detalle del grupo no puede exceder los 10 caracteres.")]
        public string Grupo { get; set; }
    }
}
