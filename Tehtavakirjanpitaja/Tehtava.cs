using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavakirjanpitaja
{
    public class Tehtava
    {
        public string Nimi { get; set; }
        public string Kuvaus { get; set; }
        public DateTime Määräaika { get; set; }

        public Tehtava(string nimi, string kuvaus, DateTime määräaika)
        {
            Nimi = nimi;
            Kuvaus = kuvaus;
            Määräaika = määräaika;
        }

        public override string ToString()
        {
            return Nimi + " - " + Kuvaus + " - " + Määräaika.ToShortDateString();
        }
    }
}
