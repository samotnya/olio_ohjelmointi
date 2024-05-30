using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus12_Korttipakka
{
    internal class Korttipakka
    {
        private List<Kortti> kortit;

        public Korttipakka()
        {
            kortit = LuoKorttiPakka();
        }

        // Luo ja palauttaan uuden korttipakan
        // oli virheet ja ongelmat katsoin netissä ja korjasin ohjeiden mukaan 
        private List<Kortti> LuoKorttiPakka()
        {
            List<Kortti> uusiPakka = new List<Kortti>();

            string[] maat = { "Hertta", "Ruutu", "Pata", "Risti" };
            string[] arvot = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jätkä", "Kuningatar", "Kuningas", "Ässä" };

            foreach (string maa in maat)
            {
                foreach (string arvo in arvot)
                {
                    uusiPakka.Add(new Kortti(maa, arvo));
                }
            }

            return uusiPakka;
        }

        // Tulostaan korttipakan
        public void Tulosta()
        {
            foreach (Kortti kortti in kortit)
            {
                Console.WriteLine(kortti);
            }
        }

       
        
    }
}
