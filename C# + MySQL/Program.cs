class Program
{
    static void Main(string[] args)
    {
        //Criar objeto da classe conexão
       Conexao c = new();

       //Criar objeto da classe PessoaSQL
       PessoaSQL p = new(c.ObterStringConexao());

       //p.Cadastrar("Alice", "Curitiba");

       //p.Alterar("Marcelo", "Belforoxo", 1);

       p.Deletar(1);

       p.Selecionar();



    }

}