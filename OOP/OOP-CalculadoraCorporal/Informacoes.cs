class Informacoes
{
    private string sexo;
    private int peso;
    private int altura;
    private int idade;
    private double percentualGordura;
    private double nivelAtividadeFisica;

    public Informacoes(string sexo, int peso, int altura, int idade, double percentualGordura, double nivelAtividadeFisica)
    {
        this.sexo = sexo;
        this.peso = peso;
        this.altura = altura;
        this.idade = idade;
        this.percentualGordura = percentualGordura;
        this.nivelAtividadeFisica = nivelAtividadeFisica;

    }

    public string GetSexo() { return sexo; }
    public void SetSexo(string value) { sexo = value; }

    public int GetPeso() { return peso; }
    public void SetPeso(int value) { peso = value; }

    public int GetAltura() { return altura; }
    public void SetAltura(int value) { altura = value; }

    public int GetIdade() { return idade; }
    public void SetIdade(int value) { idade = value; }

    public double GetPercentualGordura() { return percentualGordura; }
    public void SetPercentualGordura(double value) { percentualGordura = value; }

    public double GetNivelAtividadeFisica() { return nivelAtividadeFisica; }
    public void SetNivelAtividadeFisica(double value) { nivelAtividadeFisica = value; }




}