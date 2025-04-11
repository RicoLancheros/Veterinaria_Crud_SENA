using System.ComponentModel.DataAnnotations;

namespace Veterinaria_CRUD_Api_Rico.Models
{
    public class Proveedor
    {
        [Key]
        public int IdProveedor { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public required string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Telefono es obligatorio.")]
        public required string Telefono { get; set; }

        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "El campo Direccion es obligatorio.")]
        public required string Direccion { get; set; }

        [Required(ErrorMessage = "El campo RUC es obligatorio.")]
        public required string RUC { get; set; }

        public List<Producto> Productos { get; set; } = new List<Producto>();
    }
}
