using MySql.Data.MySqlClient;
public class PessoaRepository
{
    //Atributo contendo a string de conexão
    private readonly string? _stringDeConexao;

    public PessoaRepository(string stringDeConexao)
    {
        _stringDeConexao = stringDeConexao;
    }

    public Pessoa CadastrarPessoa(Pessoa pessoa)
    {
        using var conexao = new MySqlConnection(_stringDeConexao);

        conexao.Open();

        string ComandoSQL = "INSERT INTO pessoas (nome, cidade, idade) VALUES (@nome, @cidade, @idade);";
        ComandoSQL += "SELECT LAST_INSERT_ID();";

        using var comando = new MySqlCommand(ComandoSQL, conexao);

        comando.Parameters.AddWithValue("@nome", pessoa.Nome);
        comando.Parameters.AddWithValue("@cidade", pessoa.Cidade);
        comando.Parameters.AddWithValue("@idade", pessoa.Idade);

        int codigoGerado = Convert.ToInt32(comando.ExecuteScalar());

        pessoa.Codigo = codigoGerado;

        return pessoa;
    }

    public List<Pessoa> SelecionarPessoas()
    {
        // Cria uma variável chamada pessoas do tipo List<Pessoa>
        List<Pessoa> pessoas = [];

        // Configurar a conexão
        using var conexao = new MySqlConnection(_stringDeConexao);

        // Realizar a conexão
        conexao.Open();

        // Criar comando SQL para seleção de todas as pessoas
        using var comandoSQL = new MySqlCommand("SELECT * FROM pessoas", conexao);

        // Executar comando SQL e armazenar todos os registros
        using var registros = comandoSQL.ExecuteReader();

        // Laço de repetição
        while (registros.Read())
        {
            // Adicionar cada linha da tabela na variável pessoas
            pessoas.Add(new Pessoa
            {
                Codigo = registros.GetInt32("codigo"),
                Nome = registros.GetString("nome"),
                Cidade = registros.GetString("cidade"),
                Idade = registros.GetInt32("idade")
            });

        }

        // Retorno
        return pessoas;
    }

    // Método para alterar
    public void AlterarPessoa(Pessoa pessoa)
    {
        // Configurar a conexão
        using var conexao = new MySqlConnection(_stringDeConexao);

        // Realizar a conexão
        conexao.Open();

        // Criar comando SQL para alterar dados
        using var comandoSQL = new MySqlCommand("UPDATE pessoas SET nome = @nome, cidade = @cidade, idade = @idade WHERE codigo = @codigo", conexao);

        // Especificar os parâmetros do comando SQL
        comandoSQL.Parameters.AddWithValue("@codigo", pessoa.Codigo);
        comandoSQL.Parameters.AddWithValue("@nome", pessoa.Nome);
        comandoSQL.Parameters.AddWithValue("@cidade", pessoa.Cidade);
        comandoSQL.Parameters.AddWithValue("@idade", pessoa.Idade);

        // Executar comando SQL
        comandoSQL.ExecuteNonQuery();
    }

    // Método para remover
    public void RemoverPessoa(int codigo)
    {
        // Configurar a conexão
        using var conexao = new MySqlConnection(_stringDeConexao);

        // Realizar a conexão
        conexao.Open();

        // Criar comando SQL para remover pessoas
        using var comandoSQL = new MySqlCommand("DELETE FROM pessoas WHERE codigo = @codigo", conexao);

        // Especificar o valor do parâmetro código
        comandoSQL.Parameters.AddWithValue("@codigo", codigo);

        // Executar comando SQL
        comandoSQL.ExecuteNonQuery();
    }





}