class Program
{
    static void Main(string[] args)
    {
        Conexao conexao = new();
        ContratadoSQL contratadoSQL = new(conexao.ObterStringConexao());
        TerceirizadoSQL terceirizadoSQL = new(conexao.ObterStringConexao());

        string opcao, nome, funcao, opcao_menu01;
        int idade, horasTrabalhadas, codigo;
        double salarioHora, salarioTotal;

        System.Console.WriteLine(
            "Por favor, digite se quer trabalhar com a base de contratado, terceirizado ou 'sair' para encerrar o programa!"
        );

        do
        {
            System.Console.Write("Digite aqui: ");
            opcao = Console.ReadLine();

            if (opcao == "contratado")
            {
                ExibirMenu();

                do
                {
                    System.Console.Write("Digite a opção aqui: ");
                    opcao_menu01 = Console.ReadLine();

                    if (opcao_menu01 == "01")
                    {
                        System.Console.Write("Digite o nome do colaborador: ");
                        nome = Console.ReadLine();

                        System.Console.Write("Digite a função do colaborador: ");
                        funcao = Console.ReadLine();

                        System.Console.Write("Digite a idade do colaborador: ");
                        idade = int.Parse(Console.ReadLine());

                        System.Console.Write("Digite o salário por hora do colaborador: ");
                        salarioHora = double.Parse(Console.ReadLine());

                        System.Console.Write("Digite o número de horas trabalhadas pelo colaborador: ");
                        horasTrabalhadas = int.Parse(Console.ReadLine());

                        Funcionarios funcionario = new Funcionarios(
                            nome, funcao, idade, salarioHora, horasTrabalhadas
                        );

                        ICalculoSalario calculo = new Contratado();
                        salarioTotal = calculo.CalcularSalario(funcionario);

                        contratadoSQL.Criar(
                            nome, funcao, idade, salarioHora, horasTrabalhadas, salarioTotal
                        );
                    }
                    else if (opcao_menu01 == "02")
                    {
                        contratadoSQL.Selecionar();
                    }
                    else if (opcao_menu01 == "03")
                    {
                        System.Console.Write("Digite o nome do novo colaborador: ");
                        nome = Console.ReadLine();

                        System.Console.Write("Digite a função do novo colaborador: ");
                        funcao = Console.ReadLine();

                        System.Console.Write("Digite a idade do novo colaborador: ");
                        idade = int.Parse(Console.ReadLine());

                        System.Console.Write("Digite o salário por hora do novo colaborador: ");
                        salarioHora = double.Parse(Console.ReadLine());

                        System.Console.Write("Digite o número de horas trabalhadas pelo novo colaborador: ");
                        horasTrabalhadas = int.Parse(Console.ReadLine());

                        System.Console.Write("Digite o código da pessoa que será substituída: ");
                        codigo = int.Parse(Console.ReadLine());

                        Funcionarios funcionario = new Funcionarios(
                            nome, funcao, idade, salarioHora, horasTrabalhadas
                        );

                        ICalculoSalario calculo = new Contratado();
                        salarioTotal = calculo.CalcularSalario(funcionario);

                        contratadoSQL.Alterar(
                            nome, funcao, idade, salarioHora, horasTrabalhadas, salarioTotal, codigo
                        );
                    }
                    else if (opcao_menu01 == "04")
                    {
                        System.Console.Write("Digite o código da pessoa que será deletada: ");
                        codigo = int.Parse(Console.ReadLine());

                        contratadoSQL.Deletar(codigo);
                    }

                } while (opcao_menu01 != "sair");
            }
            else if (opcao == "terceirizado")
            {
                ExibirMenu();

                do
                {
                    System.Console.Write("Digite a opção aqui: ");
                    opcao_menu01 = Console.ReadLine();

                    if (opcao_menu01 == "01")
                    {
                        System.Console.Write("Digite o nome do colaborador: ");
                        nome = Console.ReadLine();

                        System.Console.Write("Digite a função do colaborador: ");
                        funcao = Console.ReadLine();

                        System.Console.Write("Digite a idade do colaborador: ");
                        idade = int.Parse(Console.ReadLine());

                        System.Console.Write("Digite o salário por hora do colaborador: ");
                        salarioHora = double.Parse(Console.ReadLine());

                        System.Console.Write("Digite o número de horas trabalhadas pelo colaborador: ");
                        horasTrabalhadas = int.Parse(Console.ReadLine());

                        Funcionarios funcionario = new Funcionarios(
                            nome, funcao, idade, salarioHora, horasTrabalhadas
                        );

                        ICalculoSalario calculo = new Terceirizado();
                        salarioTotal = calculo.CalcularSalario(funcionario);

                        terceirizadoSQL.Criar(
                            nome, funcao, idade, salarioHora, horasTrabalhadas, salarioTotal
                        );
                    }
                    else if (opcao_menu01 == "02")
                    {
                        terceirizadoSQL.Selecionar();
                    }
                    else if (opcao_menu01 == "03")
                    {
                        System.Console.Write("Digite o nome do novo colaborador: ");
                        nome = Console.ReadLine();

                        System.Console.Write("Digite a função do novo colaborador: ");
                        funcao = Console.ReadLine();

                        System.Console.Write("Digite a idade do novo colaborador: ");
                        idade = int.Parse(Console.ReadLine());

                        System.Console.Write("Digite o salário por hora do novo colaborador: ");
                        salarioHora = double.Parse(Console.ReadLine());

                        System.Console.Write("Digite o número de horas trabalhadas pelo novo colaborador: ");
                        horasTrabalhadas = int.Parse(Console.ReadLine());

                        System.Console.Write("Digite o código da pessoa que será substituída: ");
                        codigo = int.Parse(Console.ReadLine());

                        Funcionarios funcionario = new Funcionarios(
                            nome, funcao, idade, salarioHora, horasTrabalhadas
                        );

                        ICalculoSalario calculo = new Terceirizado();
                        salarioTotal = calculo.CalcularSalario(funcionario);

                        terceirizadoSQL.Alterar(
                            nome, funcao, idade, salarioHora, horasTrabalhadas, salarioTotal, codigo
                        );
                    }
                    else if (opcao_menu01 == "04")
                    {
                        System.Console.Write("Digite o código da pessoa que será deletada: ");
                        codigo = int.Parse(Console.ReadLine());

                        terceirizadoSQL.Deletar(codigo);
                    }

                } while (opcao_menu01 != "sair");
            }

        } while (opcao != "sair");

        System.Console.WriteLine("Programa encerrado!");
    }

    public static void ExibirMenu()
    {
        System.Console.WriteLine("=========== MENU ===========");
        System.Console.WriteLine("01 - Adicionar colaborador!");
        System.Console.WriteLine("02 - Exibir colaboradores!");
        System.Console.WriteLine("03 - Alterar colaborador!");
        System.Console.WriteLine("04 - Deletar colaborador!");
        System.Console.WriteLine("Digite 'sair' para encerrar esta sessão!");
    }
}
