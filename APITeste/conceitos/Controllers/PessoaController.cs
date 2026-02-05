using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("pessoa")]
public class PessoaController : ControllerBase
{
    //Atributo PessoaRepositorio
    private readonly PessoaRepository _pessoaRepository;

    public PessoaController(PessoaRepository pessoaRepository)
    {
        _pessoaRepository = pessoaRepository;
    }

    //Rota de Cadastro
    [HttpPost]

    public Pessoa Cadastrar([FromBody] Pessoa pessoa)
    {
        var objeto = _pessoaRepository.CadastrarPessoa(pessoa);
        return objeto;

    }

    //Rota de Mostrar
    [HttpGet]

    public List<Pessoa> Selecionar()
    {
        return _pessoaRepository.SelecionarPessoas();
    }

    [HttpPut("{codigo}")]

    public Pessoa Alterar(int codigo, [FromBody] Pessoa pessoa)
    {
        pessoa.Codigo = codigo;

        _pessoaRepository.AlterarPessoa(pessoa);

        return pessoa;
    }

    //Rota de remoção

    [HttpDelete("{codigo}")]

    public void Remover(int codigo)
    {
        _pessoaRepository.RemoverPessoa(codigo);
    }

     
}