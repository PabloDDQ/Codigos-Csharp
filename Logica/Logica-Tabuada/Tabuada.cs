class Tabuada
{
    public static void Main(string[] args){
        String opcao_sair, numEscolhido, numInteracoes;
        double numEscolhidoConvertido;
        int numInteracoesConvertido;

        do
        {
            Console.Write("Digite o número que deseja ver na tabuada: ");
            numEscolhido = Console.ReadLine();
            numEscolhidoConvertido = double.Parse(numEscolhido);

            Console.Write("Digite o número de interações: ");
            numInteracoes = Console.ReadLine();
            numInteracoesConvertido = int.Parse(numInteracoes);

            LogicaTabuada(numInteracoesConvertido, numEscolhidoConvertido);
            
            Console.Write("Deseja rodar novamente? (S/N): ");
            opcao_sair = Console.ReadLine();

        } while (opcao_sair != "N");

        Console.Write("Programa Encerrado!");

        

        
    }

    public static void LogicaTabuada(int numeroInteracoes, double numEscolhido)
    {

        for (int i = 0; i <= numeroInteracoes; i++)
        {
            Console.WriteLine(numEscolhido + " X " + i + " = " + (i*numEscolhido));
            
        }
        
    }

    
}