using MySql.Data.MySqlClient;


//Classe responsavel por conectar ao banco de dados

class Conexao
{

    //Credenciais de conexao
    private const string _servidor = "localhost";
    private const string _informacoes = "listatelefonica";
    private const string _usuario = "root";
    private const string _senha = "PANELAA89a@";


    //Método Construtor
    public Conexao()
    {
        _stringDeConexao = $"Server={_servidor};Database={_informacoes};User ID={_usuario};Password={_senha};";
    }

    //String de conexão para conectar ao banco de dados
    private readonly string _stringDeConexao;

    //Método para retornar a string de conexão
    public string ObterStringConexao()
    {
        return _stringDeConexao;
    }

    public void TestarConexao()
    {
        try
        {
            using var connection = new MySqlConnection(_stringDeConexao);

            connection.Open();
            System.Console.WriteLine("CONEXÃO BEM SUCEDIDA!");

        }
        catch (Exception ex)
        {
            System.Console.WriteLine("FALHA NA CONEXÃO: " + ex.Message);


        }
    }
}