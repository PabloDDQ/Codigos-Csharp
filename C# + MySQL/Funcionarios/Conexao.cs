using MySql.Data.MySqlClient;
class Conexao
{
    private const string _servidor = "localhost";
    private const string _funcionarios = "funcionarios";
    private const string _usuario = "root";
    private const string _senha = "PANELAA89a@";

    public Conexao()
    {
        _stringDeConexao = $"Server={_servidor};Database={_funcionarios};User ID={_usuario};Password={_senha};";
    }

    private readonly string _stringDeConexao;

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