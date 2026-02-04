using Microsoft.AspNetCore.Mvc;
using Service;
using Models;


namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivroController : ControllerBase
    {
        private readonly LivroService _service = new LivroService();
        [HttpGet]
        public List<Livro> Get()
        {
            return _service.Get();
        }
        [HttpPost]
        public string Post(Livro novoLivro)
        {
            return _service.Post(novoLivro);
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _service.Delete(id);
        }

        [HttpPut("{id}")]
        public string Put(int id, Livro livroAtualizado)
        {
            return _service.Put(id, livroAtualizado);
        }

    }
}