namespace Models;
public class Livro
{
    public int Id { get; set; }
    public string Autor { get; set; } = string.Empty;
    public string Titulo { get; set; } = string.Empty;
    public int AnoLancamento { get; set; }
    public Status Disponibilidade { get; set; }
}