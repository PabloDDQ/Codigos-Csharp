using System.Collections.Generic;

class GerenciadorTarefas
{
    public static void Main(string[] args)
    {
        List<String> lista = new List<string>();
        String numeroCatalogo, tarefa, opcao_sair;


        //Menu de apresentação do programa
        divisoria();
        Console.WriteLine("Gerenciador de Tarefas");
        divisoria();
        Console.WriteLine("Digite 1 para adicionar uma tarefa: ");
        Console.WriteLine("Digite 2 para remover uma tarefa: ");
        Console.WriteLine("Digite 3 para listar as tarefas: ");

        divisoria();
        do
        {
            Console.Write("Digite a opção: ");
            numeroCatalogo = Console.ReadLine();

            if (numeroCatalogo == "1")
            {
                do
                {
                    Console.Write("Digite uma tarefa ou 'sair' para voltar ao catalogo: ");
                    tarefa = Console.ReadLine();
                    if (tarefa != "sair")
                    {
                        adicionarTarefa(lista, tarefa);
                    }

                } while (tarefa != "sair");
            }

            else if (numeroCatalogo == "2")
            {
                do
                {
                    Console.Write("Digite a tarefa que deseja remover ou 'sair' para voltar ao catalogo: ");
                    tarefa = Console.ReadLine();
                    if (tarefa != "sair")
                    {
                        removerTarefa(lista, tarefa);
                    }

                } while (tarefa != "sair");
            }

            else if (numeroCatalogo == "3")
            {
                mostrarLista(lista);

            }

            Console.Write("Deseja rodar novamente o programa?(S/N): ");
            opcao_sair = Console.ReadLine();


        } while (opcao_sair == "S");

        System.Console.WriteLine("Programa Encerrado!");


    }

    public static void divisoria()
    {
        System.Console.WriteLine("=============================");

    }

    public static void adicionarTarefa(List<String> lista, String tarefa)
    {
        lista.Add(tarefa);
    }

    public static void removerTarefa(List<String> lista, String tarefa)
    {
        lista.Remove(tarefa);
    }

    public static void mostrarLista(List<String> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            System.Console.WriteLine("Tarefa " + (i + 1) + " : " + lista[i]);

        }

    }
}