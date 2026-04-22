namespace Biblioteca.Entidades;

public class DetallePrestamo
{
    public Guid Id { get; set; }

    public Guid PrestamoId { get; set; }
    public Prestamo Prestamo { get; set; } = null!;

    public Guid LibroId { get; set; }
    public Libro Libro { get; set; } = null!;

    public int Cantidad { get; set; }
}