using System.Collections.Generic;
class Main
{
    static void Main(string[] args)
    {
        List<Terceirizado> funcionarios_terceirizados = new List<Terceirizado>();
        List<Contratado> funcionarios_contratados = new List<Contratado>();

        //Variaveis
        string opcao_menu, nome, funcao;
        int idade, horasTrabalhadas;
        double salarioHora;

        System.Console.WriteLine("Bem vindo ao software de gerenciamento de funcionários: ");
        System.Console.WriteLine("Digite 1 para adicionar um funcionário terceirizado: ");
        System.Console.WriteLine("Digite 2 para adicionar um funcionário contratado: ");
        System.Console.WriteLine("Digite 3 para listar os funcionários adicionados: ");
        System.Console.WriteLine("Digite 4 para finalizar o programa: ");

        Console.Write("Escolha uma opção: ");
        opcao_menu = Console.ReadLine();


        do
        {
            if (opcao_menu == "1")
            {
                System.Console.Write("Digite o nome do funcionario: ");
                nome = Console.ReadLine();

                System.Console.Write("Digite a função do funcionario: ");
                funcao = Console.ReadLine();

                System.Console.Write("Digite a idade do funcionario: ");
                idade = int.Parse(Console.ReadLine());

                System.Console.Write("Digite as horas trabalhadas do funcionario: ");
                horasTrabalhadas = int.Parse(Console.ReadLine());

                System.Console.Write("Digite o salário hora do funcionario: ");
                salarioHora = int.Parse(Console.ReadLine());

                funcionarios_terceirizados.Add(new Terceirizado(nome, funcao, idade, horasTrabalhadas, salarioHora));


            }

        } while (opcao_menu != "4");






    }
}