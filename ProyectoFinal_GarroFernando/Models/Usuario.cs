using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_GarroFernando.Models
{
    public class Usuario
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(20, ErrorMessage = "El nombre no puede tener más de 20 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El primer apellido es obligatorio")]
        [StringLength(20, ErrorMessage = "El primer no puede tener más de 20 caracteres")]
        public string Apellido1 { get; set; }

        [StringLength(20, ErrorMessage = "El segundo no puede tener más de 20 caracteres")]
        public string Apellido2 { get; set; }

        [Required(ErrorMessage = "La identificación es obligatoria")]
        [StringLength(15, ErrorMessage = "La identificación no puede tener más de 15 caracteres")]
        public string Identificacion { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "El email no es válido")]
        [StringLength(50, ErrorMessage = "El email no puede tener más de 50 caracteres")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "El teléfono no es válido")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        public DateTime FechaNacimiento { get; set; }

    }
}
