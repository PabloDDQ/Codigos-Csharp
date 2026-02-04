using Models;
namespace Service;
public class LivroService
{
    private static readonly List<Livro> _biblioteca = new();

    public List<Livro> Get()
    {
        return _biblioteca;
    }

    public string Post(Livro novoLivro)
    {
        novoLivro.Id = _biblioteca.Count + 1;
        _biblioteca.Add(novoLivro);
        return $"Sucesso: Livro '{novoLivro.Titulo}' adicionado!";
    }

    public string Delete(int id)
    {

        for (int i = 0; i < _biblioteca.Count; i++)
        {
            if (_biblioteca[i].Id == id)
            {
                string nomeRemovido = _biblioteca[i].Titulo;
                _biblioteca.RemoveAt(i);
                return $"Sucesso: Livro '{nomeRemovido}' removido!";
            }

        }
        return "Erro: Livro não encontrado.";

    }

    public string Put(int id, Livro livroAtualizado)
    {

        for (int i = 0; i < _biblioteca.Count; i++)
        {
            if (_biblioteca[i].Id == id)
            {
                _biblioteca[i].Titulo = livroAtualizado.Titulo;
                _biblioteca[i].Autor = livroAtualizado.Autor;
                _biblioteca[i].AnoLancamento = livroAtualizado.AnoLancamento;
                _biblioteca[i].Disponibilidade = livroAtualizado.Disponibilidade;

                return "Sucesso: Livro atualizado!";
            }
        }

        return "Erro: Livro não encontrado.";

    }

}

//Delete = Deletar
//Get = mostrar
//Post = publicar
//Put = Substituir