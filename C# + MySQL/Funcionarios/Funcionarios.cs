class Funcionarios
{
    private string nome;
    private string funcao;
    private int idade;
    private double salarioHora;
    private int horasTrabalhadas;

    //Construtor

    public Funcionarios(string nome, string funcao, int idade, double salarioHora, int horasTrabalhadas)
    {
        Nome = nome;
        Funcao = funcao;
        Idade = idade;
        SalarioHora = salarioHora;
        HorasTrabalhadas = horasTrabalhadas;
    }

    public string Nome { get => nome; set => nome = value; }
    public string Funcao { get => funcao; set => funcao = value; }
    public int Idade { get => idade; set => idade = value; }
    public double SalarioHora { get => salarioHora; set => salarioHora = value; }
    public int HorasTrabalhadas { get => horasTrabalhadas; set => horasTrabalhadas = value; }
}