using System.ComponentModel.DataAnnotations;

namespace Veterinaria_CRUD_Api_Rico.Models
{
    public class Servicio
    {
        [Key]
        public int IdServicio { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public required string Nombre { get; set; }

        public decimal Precio { get; set; }
        public int DuracionEstimada { get; set; }
        [Required(ErrorMessage = "El campo Descripcion es obligatorio.")]
        public required string Descripcion { get; set; }

        public List<Cita> Citas { get; set; } = new List<Cita>();
    }
}
