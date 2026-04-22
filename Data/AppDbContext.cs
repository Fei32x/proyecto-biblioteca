using Microsoft.EntityFrameworkCore;
using Biblioteca.Entidades;

namespace Biblioteca.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Venta> Ventas { get; set; }
    public DbSet<Libro> Libros { get; set; }
    public DbSet<Prestamo> Prestamos { get; set; }
    public DbSet<DetalleVenta> DetalleVentas { get; set; }
    public DbSet<DetallePrestamo> DetallePrestamos { get; set; }
    public DbSet<Multa> Multas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuración de Decimales (Evita errores de truncado)
        modelBuilder.Entity<Venta>().Property(v => v.Total).HasColumnType("decimal(18,2)");
        modelBuilder.Entity<DetalleVenta>().Property(dv => dv.PrecioUnitario).HasColumnType("decimal(18,2)");
        modelBuilder.Entity<Libro>().Property(l => l.Precio).HasColumnType("decimal(18,2)");
        modelBuilder.Entity<Multa>().Property(m => m.Monto).HasColumnType("decimal(18,2)");

        // Mapeo de nombres de tablas (Opcional, para que coincidan con tus entidades)
        modelBuilder.Entity<Cliente>().ToTable("Clientes");
        modelBuilder.Entity<Libro>().ToTable("Libros");
    }
}