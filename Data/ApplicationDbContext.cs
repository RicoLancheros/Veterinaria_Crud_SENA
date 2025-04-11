using Microsoft.EntityFrameworkCore;
using Veterinaria_CRUD_Api_Rico.Models;

namespace Veterinaria_CRUD_Api_Rico.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<CitaProducto> CitaProductos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CitaProducto>()
                .HasKey(cp => new { cp.IdCita, cp.IdProducto });

            modelBuilder.Entity<CitaProducto>()
                .HasOne(cp => cp.Cita)
                .WithMany(c => c.Productos)
                .HasForeignKey(cp => cp.IdCita);

            modelBuilder.Entity<CitaProducto>()
                .HasOne(cp => cp.Producto)
                .WithMany(p => p.CitaProductos)
                .HasForeignKey(cp => cp.IdProducto);
        }
    }
}
