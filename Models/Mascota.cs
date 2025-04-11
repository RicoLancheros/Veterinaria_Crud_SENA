using System.ComponentModel.DataAnnotations;

namespace Veterinaria_CRUD_Api_Rico.Models
{
    public class Mascota
    {
        [Key]
        public int IdMascota { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public required string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Especio es obligatorio.")]
        public required string Especie { get; set; }
        [Required(ErrorMessage = "El campo Raza es obligatorio.")]
        public required string Raza { get; set; }
        public int Edad { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;

        public int IdCliente { get; set; }
        [Required(ErrorMessage = "El campo Cliente es obligatorio.")]
        public required Cliente Cliente { get; set; }

        public List<Cita> Citas { get; set; } = new List<Cita>();
    }
}
