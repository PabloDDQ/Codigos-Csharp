var builder = WebApplication.CreateBuilder(args);

// Adiciona apenas o essencial para os Controllers funcionarem
builder.Services.AddControllers();

var app = builder.Build();



app.UseHttpsRedirection();
app.MapControllers();

// Rota de teste para confirmar que o servidor subiu
app.MapGet("/", () => "Sistema de Biblioteca Rodando com Sucesso! Use /api/livro para listar.");

app.Run();