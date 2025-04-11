using System.ComponentModel.DataAnnotations;

namespace Veterinaria_CRUD_Api_Rico.Models
{
    public class Cita
    {
        [Key]
        public int IdCita { get; set; }
        public DateTime FechaHora { get; set; }
        public string Estado { get; set; } = "Pendiente";
        public required string Notas { get; set; }

        public int IdMascota { get; set; }

        [Required(ErrorMessage = "El campo Mascota es obligatorio.")]
        public required Mascota Mascota { get; set; }


        public int IdServicio { get; set; }

        [Required(ErrorMessage = "El campo Servicio es obligatorio.")]
        public required Servicio Servicio { get; set; }


        public List<CitaProducto> Productos { get; set; } = new List<CitaProducto>();
    }
}
