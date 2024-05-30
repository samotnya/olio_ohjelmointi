using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_8;

public class Työntekijä : Henkilö
{
    public int ViikottaisetTunnit { get; set; }

    public Työntekijä(string nimi, string työpaikka, double palkka, int viikottaisetTunnit)
        : base(nimi, työpaikka, palkka)
    {
        ViikottaisetTunnit = viikottaisetTunnit;
    }

    public override void TulostaTiedot()
    {
        Console.WriteLine("Nimi: " + Nimi + ", Tunnit: " + ViikottaisetTunnit);
    }
}
