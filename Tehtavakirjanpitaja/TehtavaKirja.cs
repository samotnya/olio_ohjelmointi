using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavakirjanpitaja
{
    public class TehtavaKirja
    {
        private List<Tehtava> tehtavat = new List<Tehtava>();
        private string tiedostoPolku = "tehtavat.txt";

        public void LisääTehtava(Tehtava tehtava)
        {
            tehtavat.Add(tehtava);
        }

        public void PoistaTehtava(Tehtava tehtava)
        {
            tehtavat.Remove(tehtava);
        }

        public List<Tehtava> HaeKaikkiTehtavat()
        {
            return tehtavat;
        }

        public void TallennaTiedostoon()
        {
            using (StreamWriter sw = new StreamWriter(tiedostoPolku))
            {
                foreach (Tehtava tehtava in tehtavat)
                {
                    sw.WriteLine(tehtava.Nimi + ";" + tehtava.Kuvaus + ";" + tehtava.Määräaika);
                }
            }
        }
    }
}
