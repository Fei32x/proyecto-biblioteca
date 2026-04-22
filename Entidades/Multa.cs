namespace Biblioteca.Entidades;

public class Multa
{
    public Guid Id { get; set; }

    public Guid PrestamoId { get; set; }
    public Prestamo Prestamo { get; set; } = null!;

    public int DiasAtraso { get; set; }
    public decimal Monto { get; set; }
    public bool Pagado { get; set; } = false;
}