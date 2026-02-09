public class Transacao
{
    public int Id {get; set;}
    public string Descricao {get; set;} = string.Empty;
    public Decimal Valor {get; set;}
    public DateTime data {get; set;}
     public TipoTransacao Tipo {get; set;}

     public int CategoriaId {get; set;}
     
}