namespace Biblioteca.Entidades;

public class Libro
{
    public Guid Id { get; set; }
    public string Titulo { get; set; } = null!;
    public string Autor { get; set; } = null!;
    public string Categoria { get; set; } = null!;
    public string ISBN { get; set; } = null!;
    public decimal Precio { get; set; }
    public int Stock { get; set; }

    public ICollection<DetallePrestamo> DetallePrestamos { get; set; } = new List<DetallePrestamo>();
    public ICollection<DetalleVenta> DetalleVentas { get; set; } = new List<DetalleVenta>();
}