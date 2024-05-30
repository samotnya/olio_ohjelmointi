using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus13_SM_Liiga
{
    internal class Joukkue
    {
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        private Dictionary<int, Pelaaja> pelaajat;

        public Joukkue()
        {
            pelaajat = new Dictionary<int, Pelaaja>();
        }

        public Pelaaja HaePelaaja(int pelaajaNumero)
        {
            if (pelaajat.ContainsKey(pelaajaNumero))
                return pelaajat[pelaajaNumero];
            else
            {
                Console.WriteLine("Pelaajaa ei löytynyt annetulla numerolla.");
                return null;
            }
        }

        public void LisääPelaaja(Pelaaja pelaaja)
        {
            if (pelaajat.ContainsKey(pelaaja.PelaajaNumero))
            {
                Console.WriteLine("Pelaaja on jo lisätty joukkueeseen.");
            }
            else
            {
                pelaajat.Add(pelaaja.PelaajaNumero, pelaaja);
                Console.WriteLine("Pelaaja lisätty onnistuneesti.");
            }
        }

        public void PoistaPelaaja(int pelaajaNumero)
        {
            if (pelaajat.ContainsKey(pelaajaNumero))
            {
                pelaajat.Remove(pelaajaNumero);
                Console.WriteLine("Pelaaja poistettu onnistuneesti.");
            }
            else
            {
                Console.WriteLine("Pelaajaa ei löytynyt annetulla numerolla.");
            }
        }

        public List<Pelaaja> HaePelaajat()
        {
            return new List<Pelaaja>(pelaajat.Values);
        }
    }
}
