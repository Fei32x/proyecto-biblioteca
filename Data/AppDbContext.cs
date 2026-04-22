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

    // En Postgres, decimal(18,2) o numeric es estándar
    modelBuilder.Entity<Venta>().Property(x => x.Total).HasColumnType("numeric(18,2)");
    modelBuilder.Entity<Libro>().Property(x => x.Precio).HasColumnType("numeric(18,2)");
    modelBuilder.Entity<Multa>().Property(x => x.Monto).HasColumnType("numeric(18,2)");
    modelBuilder.Entity<DetalleVenta>().Property(x => x.PrecioUnitario).HasColumnType("numeric(18,2)");

    // Configuración de Clientes
    modelBuilder.Entity<Cliente>().ToTable("Clientes");
    modelBuilder.Entity<Cliente>().Property(x => x.Nombre).HasMaxLength(50);
}
}