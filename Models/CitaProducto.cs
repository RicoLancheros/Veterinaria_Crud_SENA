using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veterinaria_CRUD_Api_Rico.Models
{
    public class CitaProducto
    {
        [Key]
        public int IdCita { get; set; }

        [Required(ErrorMessage = "El campo Cita es obligatorio.")]
        [MaxLength(100)]
        public required Cita Cita { get; set; }
        [Key]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "El campo Producto es obligatorio.")]
        [MaxLength(100)]
        public required Producto Producto { get; set; }


        public int Cantidad { get; set; } = 1;
        public decimal PrecioUnitario { get; set; }

    }
}
