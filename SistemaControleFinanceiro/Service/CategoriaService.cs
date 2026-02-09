public class CategoriaService
{
    private readonly CategoriaRepository _repository;

    public CategoriaService(CategoriaRepository repository)
    {
        _repository = repository;
    }

    public Categoria Criar(Categoria categoria)
    {
        if (string.IsNullOrWhiteSpace(categoria.Nome))
        {
            throw new Exception("O nome da categoria é obrigatório");
        }

        return _repository.CREATE(categoria);
    }
}