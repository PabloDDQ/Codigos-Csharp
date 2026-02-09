using MySql.Data.MySqlClient;

public class CategoriaRepository
{
    private readonly string? _stringDeConexao;

    public CategoriaRepository(string stringDeConexao)
    {
        _stringDeConexao = stringDeConexao;
    }

    //CREATE DO C RUD
    public Categoria CREATE(Categoria categoria)
    {
        using var conexao = new MySqlConnection(_stringDeConexao);

        conexao.Open();

        string ComandoSQL = "INSERT INTO categoria(nome) VALUES (@nome);";
        ComandoSQL += "SELECT LAST_INSERT_ID();";

        using ValueTask comando = new MySqlCommand(ComandoSQL, conexao);
        comando.Parameters.AddWithValue("@nome", categoria.Nome);

        int codigoGerado = Convert.ToInt32(comando.ExecuteScalar());

        categoria.Codigo = codigoGerado;

        return categoria;

    }

    //READ DO C R UD
    public List<Categoria> READ()
    {
        List<Categoria> categoria = [];

        using var conexao = new MySqlConnection(_stringDeConexao);
        conexao.Open();

        using var ComandoSQL = new MySqlCommand("SELECT * FROM categoria", conexao);
        using var registros = ComandoSQL.ExecuteReader();

        while (registros.Read())
        {
            categoria.Add(new Categoria
            {
                Id = registros.GetInt32("id"),
                Nome = registros.GetString("nome")
            });

        }
        return categoria;
    }

    //UPDATE CR U D

    public void UPDATE(Categoria categoria)
    {
        using var conexao = new MySqlConnection(_stringDeConexao);
        conexao.Open();

        using var ComandoSQL = new MySqlCommand("UPDATE categoria SET nome = @nome WHERE id = @id", conexao);

        ComandoSQL.Parameters.AddWithValue("@id", categoria.Id);

        ComandoSQL.ExecuteNonQuery();

    }

    //DELETE CRU D

    public void DELETE(int id)
    {
        using var conexao = new MySqlConnection(_stringDeConexao);
        conexao.Open();

        using var ComandoSQL = new MySqlCommand("DELETE FROM categoria WHERE id = @id", conexao);

        comandoSQL.Parameters.AddWithValue("@id", id);
        comandoSQL.ExecuteNonQuery();

    }




}