class Terceirizado : ICalculoSalario
{
    public double CalcularSalario(Funcionarios funcionarios)
    {
        return ((funcionarios.SalarioHora * funcionarios.HorasTrabalhadas) + 300);
    }
}