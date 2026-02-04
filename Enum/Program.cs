class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Listando Planetas: ");
        System.Console.WriteLine("=====================");
        var lista = (Planetas[])Enum.GetValues(typeof(Planetas));
        var lista_circunferencia = (PlanetasCircunferencia[])Enum.GetValues(typeof(PlanetasCircunferencia));
        for (int i = 0; i < lista.Length; i++)
        {
            int km = (int)lista_circunferencia[i];
            System.Console.WriteLine(lista[i] + " tem " + km + " km de circunferencia");
        }

    }

    enum Planetas
    {
        Mercurio,
        Venus,
        Terra,
        Marte,
        Jupiter,
        Saturno,
        Urano,
        Netuno



    }

    enum PlanetasCircunferencia
    {
        Mercurio = 15329,       // 15.329 km
        Venus = 38025,          // 38.025 km
        Terra = 40075,          // 40.075 km
        Marte = 21344,          // 21.344 km
        Jupiter = 439264,       // 439.264 km
        Saturno = 365882,       // 365.882 km
        Urano = 159354,         // 159.354 km
        Netuno = 154704         // 154.704 km
    }


}