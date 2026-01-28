class ServiceMetabolismo : ICalculos
{
    public double CalcularBmrMifflin(Informacoes info)
    {
        if (info.GetSexo() == "M")
        {
            return (10 * info.GetPeso()) + (6.25 * info.GetAltura()) - (5 * info.GetIdade()) + 5;
        }

        else
        {
            return (10 * info.GetPeso()) + (6.25 * info.GetAltura()) - (5 * info.GetIdade()) - 161;
        }



    }

    public double CalcularLbm(Informacoes info)
    {
        return info.GetPeso() * (1 - (info.GetPercentualGordura() / 100));
    }

    public double CalcularBmrKatchMcArdle(Informacoes info)
    {
        double lbm = CalcularLbm(info);
        return 370 + (21.6 * lbm);
    }

    public double CalcularTdee(Informacoes info)
    {
        // Regra: Se o usuário informou BF (maior que 0), usa Katch-McArdle. 
        // Se não, usa Mifflin (padrão).
        double bmrBase;

        if (info.GetPercentualGordura() > 0)
        {
            bmrBase = CalcularBmrKatchMcArdle(info);
        }
        else
        {
            bmrBase = CalcularBmrMifflin(info);
        }

        return bmrBase * info.GetNivelAtividadeFisica();
    }


}