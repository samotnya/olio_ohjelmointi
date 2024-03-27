using Harjoitus4_Albumi;

internal class Program
{
    private static void Main(string[] args)
    {
        Kappale kappale1 = new Kappale("Kappale1",3.5);
        Kappale kappale2 = new Kappale("Kappale2", 4.0);
        Kappale kappale3 = new Kappale("Kappale3", 2.2);
        List<Kappale> Kappaleet = new List<Kappale>();
        Kappaleet.Add(kappale1);
        Kappaleet.Add(kappale2);
        Kappaleet.Add(kappale3);

        Albumi albumi = new Albumi("Albumi 1", "Artisti 1", "Pop", 12.99, Kappaleet);

    
        // Tulostetaan koko albumi
        albumi.TulostaAlbumi();
    }
}