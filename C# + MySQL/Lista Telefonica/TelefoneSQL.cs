using MySql.Data.MySqlClient;

class TelefoneSQL
{
    private readonly string? _stringDeConexao;

    public TelefoneSQL(string conexao)
    {
        _stringDeConexao = conexao;
    }

    //Método para criar

    public void Criar(string nome, string cidade, string estado, string telefone)
    {
        //Comando SQL
        string sql = "INSERT INTO informacoes(nome, cidade, estado, telefone) VALUES (@nome, @cidade, @estado, @telefone)";

        using var conexao = new MySqlConnection(_stringDeConexao);
        using var comando = new MySqlCommand(sql, conexao);

        comando.Parameters.AddWithValue("@nome", nome);
        comando.Parameters.AddWithValue("@cidade", cidade);
        comando.Parameters.AddWithValue("@estado", estado);
        comando.Parameters.AddWithValue("@telefone", telefone);

        try
        {
            conexao.Open();
            comando.ExecuteNonQuery();
            System.Console.WriteLine("CADASTRADO COM SUCESSO!");
        }
        catch (System.Exception e)
        {

            System.Console.WriteLine("Falha ao cadastrar: " + e.Message);

        }

    }

    public void Selecionar()
    {
        string sql = "SELECT * FROM informacoes";

        using var conexao = new MySqlConnection(_stringDeConexao);
        using var comando = new MySqlCommand(sql, conexao);

        try
        {
            //Abrir conexão mysql
            conexao.Open();
            using (var informacoes = comando.ExecuteReader())
            {
                while (informacoes.Read())
                {
                    Console.WriteLine("Código: " + informacoes["codigo"]);
                    Console.WriteLine("Nome: " + informacoes["nome"]);
                    Console.WriteLine("Cidade: " + informacoes["cidade"]);
                    Console.WriteLine("estado: " + informacoes["estado"]);
                    Console.WriteLine("Telefone: " + informacoes["telefone"]);

                }
            }

        }
        catch (Exception e)
        {

            System.Console.WriteLine("Falha ao selecionar " + e.Message);
        }
    }

    public void Alterar(string nome, string cidade,string estado, string telefone, int codigo)
    {
        //Comando SQL
        string sql = "UPDATE informacoes SET nome = @nome, cidade = @cidade, estado = @estado, telefone = @telefone WHERE codigo = @codigo";

        //Conexão com o banco de dados e execução do comando SQL
        using var conexao = new MySqlConnection(_stringDeConexao);
        using var comando = new MySqlCommand(sql, conexao);

        //Especificar os paramentros do sql
        comando.Parameters.AddWithValue("@nome", nome);
        comando.Parameters.AddWithValue("@cidade", cidade);
        comando.Parameters.AddWithValue("@estado", estado);
        comando.Parameters.AddWithValue("@telefone", telefone);
        comando.Parameters.AddWithValue("@codigo", codigo);


        try
        {
            conexao.Open();
            comando.ExecuteNonQuery();
            System.Console.WriteLine("Dados alterados com sucesso!");

        }
        catch (Exception e)
        {

            System.Console.WriteLine("Falha ao alterar: " + e.Message);
        }



    }

    public void Deletar(int codigo)
    {
        //Comando SQL
        string sql = "DELETE FROM informacoes WHERE codigo = @codigo";

        //Conexão com o banco de dados e execução do comando SQL
        using var conexao = new MySqlConnection(_stringDeConexao);
        using var comando = new MySqlCommand(sql, conexao);

        //Especificar os paramentros do sql
        comando.Parameters.AddWithValue("@codigo", codigo);

        try
        {
            conexao.Open();
            comando.ExecuteNonQuery();
            System.Console.WriteLine("Dados excluidos com sucesso!");

        }
        catch (Exception e)
        {

            System.Console.WriteLine("Falha ao alterar: " + e.Message);
        }



    }

}