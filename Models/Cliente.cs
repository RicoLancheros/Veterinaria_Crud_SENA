using System.ComponentModel.DataAnnotations;

namespace Veterinaria_CRUD_Api_Rico.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public required string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Telefono es obligatorio.")]
        public required string Telefono { get; set; }
        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        public required string Email { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;
        public List<Mascota> Mascotas { get; set; } = new List<Mascota>();
    }
}