using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4_Albumi
{

    internal class Albumi
    {
        public string Nimi { get; set; }
        public string Artisti { get; set; }
        public List<Kappale> Kappaleet { get; set; }
        public string Genre { get; set; }
        public double Hinta { get; set; }

        public Albumi(string nimi, string artisti, string genre, double hinta, List<Kappale> _kappaleet)
        {
            Nimi = nimi;
            Artisti = artisti;
            Kappaleet = _kappaleet;
            Genre = genre;
            Hinta = hinta;
        }

        public void LisääKappale(Kappale kappale)
        {
            Kappaleet.Add(kappale);
        }

        public void TulostaAlbumi()
        {
            Console.WriteLine("Albumi: " + Nimi);
            Console.WriteLine("Artisti: " + Artisti);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("Hinta: " + Hinta);
            Console.WriteLine("Kappaleet:");
            foreach (var kappale in Kappaleet)
            {
               kappale.TulostaKappale();

            }
        }
    }
}
               /*Tehtävä oli tosi vaikkea, käytin vähän chat gbt mutta en ole kopioinut suoraan vain tein ite ja se näytti missä oli virhet ja korjasi koska oli tosi vaikea löytä virhet 
                         itse siksi olen käyttänyt sitä*/ 
