using Harjoitus_8;

class Program
{
    static void Main(string[] args)
    {
        Työntekijä työntekijä1 = new Työntekijä("Matti", "Firma", 3000, 40);
        työntekijä1.TulostaTiedot();

        Pomo pomo1 = Pomo.GetInstance("Maija", "Firma", 6000, 1000, "BMW");
        pomo1.TulostaTiedot();

        // Yritetään luoda toinen Pomo
        Pomo pomo2 = Pomo.GetInstance("Toinen Pomo", "Toinen Firma", 7000, 1500, "Audi");
        pomo2.TulostaTiedot();

        // Tarkistetaan ovatko pomo1 ja pomo2 sama instanssi
        Console.WriteLine("Onko pomo1 ja pomo2 sama? " + (pomo1 == pomo2));
    }
}
