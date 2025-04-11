using System.ComponentModel.DataAnnotations;

namespace Veterinaria_CRUD_Api_Rico.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public required string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Descripcion es obligatorio.")]
        public required string Descripcion { get; set; }

        public decimal Precio { get; set; }
        public int Stock { get; set; } = 0;
        public int StockMinimo { get; set; } = 5;
        public DateTime? FechaCaducidad { get; set; }

        public int? IdProveedor { get; set; }
        [Required(ErrorMessage = "El campo Proveedor es obligatorio.")]
        public required Proveedor Proveedor { get; set; }

        public List<CitaProducto> CitaProductos { get; set; } = new List<CitaProducto>();
    }
}
