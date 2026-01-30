using MySql.Data.MySqlClient;

class ContratadoSQL
{
    private readonly string _stringDeConexao;

    public ContratadoSQL(string conexao)
    {
        _stringDeConexao = conexao;
    }

    // CREATE
    public void Criar(string nome, string funcao, int idade, double salarioHora, int horasTrabalhadas, double salarioTotal)
    {
        string sql = @"
            INSERT INTO funcionarios_contratados
            (nome, funcao, idade, salario_hora, horas_trabalhadas, salario_total)
            VALUES
            (@nome, @funcao, @idade, @salario_hora, @horas_trabalhadas, @salario_total)";

        using var conexao = new MySqlConnection(_stringDeConexao);
        using var comando = new MySqlCommand(sql, conexao);

        comando.Parameters.AddWithValue("@nome", nome);
        comando.Parameters.AddWithValue("@funcao", funcao);
        comando.Parameters.AddWithValue("@idade", idade);
        comando.Parameters.AddWithValue("@salario_hora", salarioHora);
        comando.Parameters.AddWithValue("@horas_trabalhadas", horasTrabalhadas);
        comando.Parameters.AddWithValue("@salario_total", salarioTotal);

        try
        {
            conexao.Open();
            comando.ExecuteNonQuery();
            Console.WriteLine("CADASTRADO COM SUCESSO!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Falha ao cadastrar: " + e.Message);
        }
    }

    // READ
    public void Selecionar()
    {
        string sql = "SELECT * FROM funcionarios_contratados";

        using var conexao = new MySqlConnection(_stringDeConexao);
        using var comando = new MySqlCommand(sql, conexao);

        try
        {
            conexao.Open();
            using var reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("Código: " + reader["codigo"]);
                Console.WriteLine("Nome: " + reader["nome"]);
                Console.WriteLine("Função: " + reader["funcao"]);
                Console.WriteLine("Idade: " + reader["idade"]);
                Console.WriteLine("Salário hora: " + reader["salario_hora"]);
                Console.WriteLine("Horas trabalhadas: " + reader["horas_trabalhadas"]);
                Console.WriteLine("Salário total: R$ " + reader["salario_total"]);
                Console.WriteLine("----------------------------");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Falha ao selecionar: " + e.Message);
        }
    }

    // UPDATE
    public void Alterar(string nome, string funcao, int idade, double salarioHora, int horasTrabalhadas, double salarioTotal, int codigo)
    {
        string sql = @"
            UPDATE funcionarios_contratados
            SET 
                nome = @nome,
                funcao = @funcao,
                idade = @idade,
                salario_hora = @salario_hora,
                horas_trabalhadas = @horas_trabalhadas,
                salario_total = @salario_total
            WHERE codigo = @codigo";

        using var conexao = new MySqlConnection(_stringDeConexao);
        using var comando = new MySqlCommand(sql, conexao);

        comando.Parameters.AddWithValue("@nome", nome);
        comando.Parameters.AddWithValue("@funcao", funcao);
        comando.Parameters.AddWithValue("@idade", idade);
        comando.Parameters.AddWithValue("@salario_hora", salarioHora);
        comando.Parameters.AddWithValue("@horas_trabalhadas", horasTrabalhadas);
        comando.Parameters.AddWithValue("@salario_total", salarioTotal);
        comando.Parameters.AddWithValue("@codigo", codigo);

        try
        {
            conexao.Open();
            comando.ExecuteNonQuery();
            Console.WriteLine("Dados alterados com sucesso!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Falha ao alterar: " + e.Message);
        }
    }

    // DELETE
    public void Deletar(int codigo)
    {
        string sql = "DELETE FROM funcionarios_contratados WHERE codigo = @codigo";

        using var conexao = new MySqlConnection(_stringDeConexao);
        using var comando = new MySqlCommand(sql, conexao);

        comando.Parameters.AddWithValue("@codigo", codigo);

        try
        {
            conexao.Open();
            comando.ExecuteNonQuery();
            Console.WriteLine("Dados excluídos com sucesso!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Falha ao excluir: " + e.Message);
        }
    }
}
