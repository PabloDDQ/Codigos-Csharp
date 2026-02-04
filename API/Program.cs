var builder = WebApplication.CreateBuilder(args);

// Registra o serviço para que a API possa usá-lo (Injeção de Dependência)
builder.Services.AddSingleton<LivroService>();

var app = builder.Build();

// Rota para listar todos
app.MapGet("/livros", (LivroService service) =>
{
    return Results.Ok(service.ListarTodos());
});

// Rota para criar (POST)
app.MapPost("/livros", (LivroService service, Livro livro) =>
{
    var resultado = service.Adicionar(livro);

    if (resultado.StartsWith("Erro"))
    {
        return Results.BadRequest(resultado);
    }

    return Results.Created($"/livros/{livro.Id}", resultado);
});

// Rota para deletar (DELETE)
app.MapDelete("/livros/{id}", (LivroService service, int id) =>
{
    var resultado = service.Deletar(id);

    if (resultado.StartsWith("Erro"))
    {
        return Results.NotFound(resultado);
    }

    return Results.NoContent();
});

app.Run();