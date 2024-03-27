using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4_Albumi
{
    internal class Kappale
    {
        public string Nimi { get; set; }
        public double Kesto { get; set; }

        public Kappale(string nimi, double kesto)
        {
            Nimi = nimi;
           Kesto = kesto;
        }
        public void TulostaKappale()
        {
            Console.WriteLine("Nimi: " + Nimi + " - " + Kesto);
            
        }
    }
}
