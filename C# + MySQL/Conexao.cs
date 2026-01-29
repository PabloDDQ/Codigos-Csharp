using MySql.Data.MySqlClient;

//Classe de conexão com o banco

class Conexao
{



    //Credenciais de conexao
    private const string _servidor = "localhost";
    private const string _base = "base";
    private const string _usuario = "root";
    private const string _senha = "PANELAA89a@";

    //Método Construtor

    public Conexao()
    {
        _stringDeConexao = $"Server={_servidor};Database={_base};User ID={_usuario};Password={_senha};";
    }

    //String de conexão para conectar ao banco de dados
    private readonly string _stringDeConexao;


    //Método para retornar a string de conexão

    public string ObterStringConexao()
    {
        return _stringDeConexao;
    }

    //Método para testar a conexão

    public void TestarConexao()
    {
        try
        {
            using (var connection = new MySqlConnection(_stringDeConexao))
            {
                connection.Open();
                Console.WriteLine("SUCESSO NA CONEXÃO!");
            }

        }
        catch (Exception ex)
        {

            System.Console.WriteLine("FALHA AO CONECTAR: " + ex.Message);
        }
    }


}



