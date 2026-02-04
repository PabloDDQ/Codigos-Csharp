public class LivroService 
{
    private readonly List<Livro> _biblioteca = new();

    public List<Livro> ListarTodos() => _biblioteca;

    public string Adicionar(Livro novoLivro) 
    {
        if (string.IsNullOrWhiteSpace(novoLivro.Titulo)) 
            return "Erro: O livro precisa de um título";

        novoLivro.Id = _biblioteca.Count + 1;
        _biblioteca.Add(novoLivro);
        return $"Sucesso: Livro '{novoLivro.Titulo}' adicionado!";
    }

    public string Deletar(int id)
    {
        var livro = _biblioteca.FirstOrDefault(l => l.Id == id);
        if (livro == null) return "Erro: Livro não encontrado";

        _biblioteca.Remove(livro);
        return $"Sucesso: Livro '{livro.Titulo}' removido!";
    }
}