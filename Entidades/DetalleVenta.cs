namespace Biblioteca.Entidades;

public class DetalleVenta
{
    public Guid Id { get; set; }

    public Guid VentaId { get; set; }
    public Venta Venta { get; set; } = null!;

    public Guid LibroId { get; set; }
    public Libro Libro { get; set; } = null!;

    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }
}