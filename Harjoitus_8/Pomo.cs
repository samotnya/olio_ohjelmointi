using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_8;
public class Pomo : Henkilö
{
    private static Pomo instance = null;
    public double Boonus { get; set; }
    public string Auto { get; set; }

    private Pomo(string nimi, string työpaikka, double palkka, double boonus, string auto)
        : base(nimi, työpaikka, palkka)
    {
        Boonus = boonus;
        Auto = auto;
    }

    public static Pomo GetInstance(string nimi, string työpaikka, double palkka, double boonus, string auto)
    {
        if (instance == null)
        {
            instance = new Pomo(nimi, työpaikka, palkka, boonus, auto);
        }
        return instance;
    }

    public override void TulostaTiedot()
    {
        Console.WriteLine("Nimi: " + Nimi + ", Auto: " + Auto);
    }
}

