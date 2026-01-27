class Funcionario
{
    //Atributos
    protected string Nome { get; set; }
    protected string Funcao { get; set; }
    protected int Idade { get; set; }
    protected double SalarioHora { get; set; }
    protected int HorasTrabalhadas {get; set; }

    //Construtor
    public Funcionario(string nome, string funcao, int idade, double salarioHora, int horasTrabalhadas)
    {
        Nome = nome;
        Funcao = funcao;
        Idade = idade;
        SalarioHora = salarioHora;
        HorasTrabalhadas = horasTrabalhadas;

    }

    //Métodos utilizados

    //Método de calcular salario
    public virtual double CalcularSalario()
    {
        return HorasTrabalhadas * SalarioHora;
        
    }


}