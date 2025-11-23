using TrabalhoInterface;

class Program
{
    static void Main(string[] args)
    {
        ContaCorrente cc = new ContaCorrente(1000);
        SeguroDeVida sv = new SeguroDeVida();

        TotalizadorDeTributos totalizador = new TotalizadorDeTributos();

        totalizador.Adiciona(cc);
        totalizador.Adiciona(sv);

        Console.WriteLine("Tributo Conta Corrente: " + cc.CalculaTributos());
        Console.WriteLine("Tributo Seguro de Vida: " + sv.CalculaTributos());
        Console.WriteLine("Total Tributos: " + totalizador.Total);

        Console.ReadLine();
    }
}

