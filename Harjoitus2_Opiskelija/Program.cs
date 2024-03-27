using Harjoitus2_Opiskelija;

internal class Program
{
    private static void Main(string[] args)
    {
        // luodaan opiskelija olio
       opiskelija opiskelija1 = new opiskelija("Matti", "TVT1234", 0);

        opiskelija1.TulostaData();
        opiskelija1.MuokkaOpintopisteitä(5);
        opiskelija1.TulostaData();
    }
}