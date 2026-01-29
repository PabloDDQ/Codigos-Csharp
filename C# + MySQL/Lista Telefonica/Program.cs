using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        string opcao_menu, nome, cidade, estado, telefone;
        int codigo;

        Conexao conexao = new();
        TelefoneSQL telefonesql = new(conexao.ObterStringConexao());


        System.Console.WriteLine("Lista telefonica:");
        System.Console.WriteLine("Digite 01 - Adicionar: ");
        System.Console.WriteLine("Digite 02 - Listar: ");
        System.Console.WriteLine("Digite 03 - Alterar: ");
        System.Console.WriteLine("Digite 04 - Excluir: ");
        System.Console.WriteLine("Digite 'sair' para finalizar o programa");

        do
        {


            separador();

            System.Console.Write("Digite aqui a opção do menu: ");
            opcao_menu = Console.ReadLine();

            separador();
            if (opcao_menu == "01")
            {
                System.Console.Write("Digite o nome da pessoa: ");
                nome = Console.ReadLine();

                System.Console.Write("Digite o nome da cidade da pessoa: ");
                cidade = Console.ReadLine();

                System.Console.Write("Digite o nome do estado da pessoa: ");
                estado = Console.ReadLine();

                System.Console.Write("Digite o telefone da pessoa: ");
                telefone = Console.ReadLine();

                telefonesql.Criar(nome, cidade, estado, telefone);


            }

            else if (opcao_menu == "02")
            {
                telefonesql.Selecionar();
            }

            else if (opcao_menu == "03")
            {

                System.Console.Write("Digite o nome da nova pessoa: ");
                nome = Console.ReadLine();

                System.Console.Write("Digite o nome da nova cidade da pessoa: ");
                cidade = Console.ReadLine();

                System.Console.Write("Digite o nome do novo estado da pessoa: ");
                estado = Console.ReadLine();

                System.Console.Write("Digite o telefone nova da pessoa: ");
                telefone = Console.ReadLine();

                System.Console.Write("Digite o código da pessoa que irá ser substituida: ");
                codigo = int.Parse(Console.ReadLine());

                telefonesql.Alterar(nome, cidade, estado, telefone, codigo);

            }

            else if (opcao_menu == "04")
            {
                System.Console.Write("Digite o código da pessoa que irá ser deletada: ");
                codigo = int.Parse(Console.ReadLine());

                telefonesql.Deletar(codigo);

            }

        } while (opcao_menu != "sair");
        System.Console.WriteLine("Programa Encerrado!");
    }

    static void separador()
    {
        System.Console.WriteLine("============================================");
    }

}

