class Contratado : ICalculoSalario
{
    public double CalcularSalario(Funcionarios funcionarios)
    {
        return funcionarios.SalarioHora * funcionarios.HorasTrabalhadas;
    }
}