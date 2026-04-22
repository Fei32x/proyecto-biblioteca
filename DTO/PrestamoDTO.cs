public class PrestamoDto
{
    public Guid Id { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime FechaDevolucionEstimada { get; set; }
    public DateTime? FechaDevolucionReal { get; set; }
    public string Estado { get; set; } = null!;
    public Guid ClienteId { get; set; }
    public string NombreCliente { get; set; } = null!;
    
    public List<DetallePrestamoDto> Detalles { get; set; } = new();
    public MultaDto? Multa { get; set; }
}

public class DetallePrestamoDto
{
    public Guid LibroId { get; set; }
    public string TituloLibro { get; set; } = null!;
    public int Cantidad { get; set; }
}

public class MultaDto
{
    public Guid Id { get; set; }
    public int DiasAtraso { get; set; }
    public decimal Monto { get; set; }
    public bool Pagado { get; set; }
}