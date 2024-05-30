using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_8;

public abstract class Henkilö
{
    public string Nimi { get; set; }
    public string Työpaikka { get; set; }
    public double Palkka { get; set; }

    public Henkilö(string nimi, string työpaikka, double palkka)
    {
        Nimi = nimi;
        Työpaikka = työpaikka;
        Palkka = palkka;
    }

    public abstract void TulostaTiedot();
}