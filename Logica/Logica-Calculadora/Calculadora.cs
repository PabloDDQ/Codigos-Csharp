using System.ComponentModel;

class Calculadora
{
    public static void Main(string[] args)
    {

        //Variaveis
        String opcao_sair, operador, num1, num2;

        Console.WriteLine("Iniciando Calculadora");

        do
        {
            do
            {
                Console.Write("Digite um dos seguintes operadores (+, -, *, /, ^): ");
                operador = Console.ReadLine();

                if (operador != "+" && operador != "-" && operador != "/" && operador != "*" && operador != "^")
                {
                    Console.WriteLine("Digite um operador válido");

                }

            } while (operador != "+" && operador != "-" && operador != "/" && operador != "*" && operador != "^");

            Console.Write("Digite o primeiro número: ");
            num1 = Console.ReadLine();
            double num1Convertido = double.Parse(num1);

            Console.Write("Digite o segundo número: ");
            num2 = Console.ReadLine();
            double num2Convertido = double.Parse(num2);

            if (operador == "+")
            {
                Console.WriteLine("A soma de " + num1 + " e " + num2 + " resulta em: " + Soma(num1Convertido, num2Convertido));
            }
            else if (operador == "-")
            {
                Console.WriteLine("A subtração de " + num1 + " e " + num2 + " resulta em: " + Subtracao(num1Convertido, num2Convertido));

            }

            else if (operador == "*")
            {
                Console.WriteLine("A multiplicação de " + num1 + " e " + num2 + " resulta em: " + Multiplicacao(num1Convertido, num2Convertido));

            }

            else if (operador == "/")
            {
                Console.WriteLine("A divisão de " + num1 + " e " + num2 + " resulta em: " + Divisao(num1Convertido, num2Convertido));

            }

            else if (operador == "^")
            {
                Console.WriteLine("A potenciação de " + num1 + " e " + num2 + " resulta em: " + Potenciacao(num1Convertido, num2Convertido));

            }




            Console.Write("Deseja rodar novamente o programa?(S/N): ");
            opcao_sair = Console.ReadLine();

        } while (opcao_sair != "N");



        System.Console.WriteLine("Programa Encerrado!");
    }

    public static double Soma(double num1, double num2)
    {
        return num1 + num2;
    }

    public static double Subtracao(double num1, double num2)
    {
        return num1 - num2;
    }

    public static double Multiplicacao(double num1, double num2)
    {
        return num1 * num2;
    }

    public static double Divisao(double num1, double num2)
    {
        if (num2 == 0)
        {
            return double.NaN;

        }

        else
        {
            return num1 / num2;
        }
    }

    public static double Potenciacao(double num1, double num2)
    {
        return Math.Pow(num1, num2);
    }


}