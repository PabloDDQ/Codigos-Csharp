using System.Collections.Generic;
using System;
class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> funcionarios = new List<Funcionario>();

        //Variaveis
        string opcao_menu, nome, funcao;
        int idade, horasTrabalhadas;
        double salarioHora;

        System.Console.WriteLine("Bem vindo ao software de gerenciamento de funcionários: ");
        System.Console.WriteLine("Digite 1 para adicionar um funcionário terceirizado: ");
        System.Console.WriteLine("Digite 2 para adicionar um funcionário contratado: ");
        System.Console.WriteLine("Digite 3 para listar os funcionários adicionados: ");
        System.Console.WriteLine("Digite 4 para finalizar o programa: ");

        do
        {

            Console.Write("Escolha uma opção: ");
            opcao_menu = Console.ReadLine();

            if (opcao_menu == "1")
            {
                System.Console.Write("Digite o nome do funcionario: ");
                nome = Console.ReadLine();

                System.Console.Write("Digite a função do funcionario: ");
                funcao = Console.ReadLine();

                System.Console.Write("Digite a idade do funcionario: ");
                idade = int.Parse(Console.ReadLine());

                System.Console.Write("Digite o salário hora do funcionario: ");
                salarioHora = double.Parse(Console.ReadLine());

                System.Console.Write("Digite as horas trabalhadas do funcionario: ");
                horasTrabalhadas = int.Parse(Console.ReadLine());



                funcionarios.Add(new Terceirizado(nome, funcao, idade, salarioHora, horasTrabalhadas));


            }

            else if (opcao_menu == "2")
            {
                System.Console.Write("Digite o nome do funcionario: ");
                nome = Console.ReadLine();

                System.Console.Write("Digite a função do funcionario: ");
                funcao = Console.ReadLine();

                System.Console.Write("Digite a idade do funcionario: ");
                idade = int.Parse(Console.ReadLine());

                System.Console.Write("Digite o salário hora do funcionario: ");
                salarioHora = double.Parse(Console.ReadLine());

                System.Console.Write("Digite as horas trabalhadas do funcionario: ");
                horasTrabalhadas = int.Parse(Console.ReadLine());

                funcionarios.Add(new Contratado(nome, funcao, idade, salarioHora, horasTrabalhadas));

            }

            else if (opcao_menu == "3")
            {
                listarFuncionarios(funcionarios);
            }


        } while (opcao_menu != "4");

        System.Console.WriteLine("Programa Encerrado!");






    }

    public static void listarFuncionarios(List<Funcionario> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            System.Console.WriteLine($"{i + 1} - Salário: R$ {lista[i].CalcularSalario()}");

        }
    }
}