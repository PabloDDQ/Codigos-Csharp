using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("categorias")]

public class CategoriaController : ControllerBase
{
    private readonly CategoriaRepository _categoriaRepository;

    public CategoriaController(CategoriaService service)
    {

        _service = service;
    }

    //Rota de Cadastro
    [HttpPost]

    public IActionResult POST([FromBody] Categoria categoria)
    {
        try
        {
            var resultado = _service.Criar(categoria);
            return Created(string.Empty, resultado);
        }
        catch (Exception ex)
        {
            
            return BadRequest(new {mensagem = ex.Message});
        }
    }

    //Rota de Mostrar
    [HttpGet]

    public List<Categoria> GET()
    {
        return _categoriaRepository.READ();
    }

    [HttpPut("{id}")]

    public Categoria PUT(int id, [FromBody] Categoria categoria)
    {
        categoria.Id = id;
        _categoriaRepository.UPDATE(categoria);
        return categoria;
    }

    [HttpDelete("{id}")]

    public void DELETE(int id)
    {
        _categoriaRepository.DELETE(id);
    }


}