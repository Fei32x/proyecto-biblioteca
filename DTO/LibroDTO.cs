public class LibroDto
{
    public Guid Id { get; set; }
    public string Titulo { get; set; } = null!;
    public string Autor { get; set; } = null!;
    public string Categoria { get; set; } = null!;
    public string ISBN { get; set; } = null!;
    public decimal Precio { get; set; }
    public int Stock { get; set; }
}