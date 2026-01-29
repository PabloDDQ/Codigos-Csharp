//Importar pacote MySQL
using MySql.Data.MySqlClient;

//Classe

class PessoaSQL
{
    //Atributo contendo a string de conexão
    private readonly string? _stringDeConexao;

    //Método construtor
    public PessoaSQL(string conexao)
    {
        _stringDeConexao = conexao;
    }

    //Método para efetuar o cadastro

    public void Cadastrar(string nome, string cidade)
    {
        //Comando SQL
        string sql = "INSERT INTO pessoas(nome, cidade) VALUES(@nome, @cidade)";

        //Conexão com o banco de dados e execução do comando SQL
        using var conexao = new MySqlConnection(_stringDeConexao);
        using var comando = new MySqlCommand(sql, conexao);

        //Especificar os paramentros do sql
        comando.Parameters.AddWithValue("@nome", nome);
        comando.Parameters.AddWithValue("@cidade", cidade);

        try
        {
            conexao.Open();
            comando.ExecuteNonQuery();
            System.Console.WriteLine("Cadastrado com sucesso!");

        }
        catch (Exception e)
        {

            System.Console.WriteLine("Falha ao cadastrar: " + e.Message);
        }



    }

    public void Selecionar()
    {
        string sql = "SELECT * FROM pessoas";
        using var conexao = new MySqlConnection(_stringDeConexao);
        using var comando = new MySqlCommand(sql, conexao);

        try
        {
            //Abrir conexão mysql
            conexao.Open();
            using (var pessoas = comando.ExecuteReader())
            {
                while (pessoas.Read())
                {
                    Console.WriteLine("Código " + pessoas["codigo"]);
                    Console.WriteLine("Nome " + pessoas["nome"]);
                    Console.WriteLine("Cidade " + pessoas["cidade"]);
                }
            }

        }
        catch (Exception e)
        {

            System.Console.WriteLine("Falha ao selecionar " + e.Message);
        }

    }

    public void Alterar(string nome, string cidade, int codigo)
    {
        //Comando SQL
        string sql = "UPDATE pessoas SET nome = @nome, cidade = @cidade WHERE codigo = @codigo";

        //Conexão com o banco de dados e execução do comando SQL
        using var conexao = new MySqlConnection(_stringDeConexao);
        using var comando = new MySqlCommand(sql, conexao);

        //Especificar os paramentros do sql
        comando.Parameters.AddWithValue("@nome", nome);
        comando.Parameters.AddWithValue("@cidade", cidade);
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
        string sql = "DELETE FROM pessoas WHERE codigo = @codigo";

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