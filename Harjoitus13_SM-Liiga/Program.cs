using Harjoitus13_SM_Liiga;

internal class Program
{
     static void Main(string[] args)
    {
        Joukkue joukkue = new Joukkue();
        joukkue.Nimi = "Esimerkki Joukkue";
        joukkue.Kotikaupunki = "Esimerkkikaupunki";

       
        Pelaaja pelaaja1 = new Pelaaja("Matti", "Meikäläinen", 1);
        Pelaaja pelaaja2 = new Pelaaja("Mikko", "Virtanen", 2);

        joukkue.LisääPelaaja(pelaaja1);
        joukkue.LisääPelaaja(pelaaja2);

        
        Console.WriteLine("Joukkueen pelaajat:");
        foreach (var pelaaja in joukkue.HaePelaajat())
        {
            Console.WriteLine("{0} {1}, pelaajanumero: {2}", pelaaja.Etunimi, pelaaja.Sukunimi, pelaaja.PelaajaNumero);
        }

        joukkue.PoistaPelaaja(2);
        joukkue.HaePelaaja(2);

        Console.ReadLine();
    }
}
