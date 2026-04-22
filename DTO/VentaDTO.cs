public class VentaDto
{
    public Guid Id { get; set; }
    public DateTime Fecha { get; set; }
    public decimal Total { get; set; }
    public string FormaDePago { get; set; } = null!;
    public Guid ClienteId { get; set; }
    public string NombreCliente { get; set; } = null!; // Aplanado
    public List<DetalleVentaDto> Detalles { get; set; } = new();
}

public class DetalleVentaDto
{
    public Guid LibroId { get; set; }
    public string TituloLibro { get; set; } = null!; // Informativo
    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }
    public decimal Subtotal => Cantidad * PrecioUnitario;
}