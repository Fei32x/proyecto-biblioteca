namespace Biblioteca.Entidades;

public class Prestamo
{
    public Guid Id { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime FechaDevolucionEstimada { get; set; }
    public DateTime? FechaDevolucionReal { get; set; }
    public string Estado { get; set; } = "activo";

    public Guid ClienteId { get; set; }
    public Cliente Cliente { get; set; } = null!;

    public ICollection<DetallePrestamo> Detalles { get; set; } = new List<DetallePrestamo>();
    public Multa? Multa { get; set; }
}