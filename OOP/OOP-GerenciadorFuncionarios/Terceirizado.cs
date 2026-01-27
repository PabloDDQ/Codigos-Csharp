class Terceirizado : Funcionario
{
    public Terceirizado(string nome, string funcao, int idade, double salarioHora, int horasTrabalhadas) : base(nome, funcao, idade, salarioHora, horasTrabalhadas) { }

    public override double CalcularSalario()
    {
        return base.CalcularSalario() * 1.2;
    }

}