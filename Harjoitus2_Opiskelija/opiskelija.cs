using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2_Opiskelija
{
    internal class opiskelija
    {
        private string Nimi {  get; set; }
        private string OpiskelijaID { get; set;}
        private int Opintopisteet {  get; set;}

        //Konstruktori Opiskelija -luokalle
        public opiskelija(string _nimi, string _id, int _op)
        {
            this.Nimi = _nimi;
            this.OpiskelijaID = _id;
            this.Opintopisteet = _op;
        }

        public void TulostaData()
        {
            Console.WriteLine("");
            Console.WriteLine("opiskelija");
            Console.WriteLine("--Nimi: " + Nimi);
            Console.WriteLine("--OpiskelijanID " + OpiskelijaID);
            Console.WriteLine("--Opintopisteet: " + Opintopisteet);
            Console.WriteLine();
        }

        //Metodi, joka ottaa parametriksi integer - arvon.
        public void MuokkaOpintopisteitä(int i)
        {
            Opintopisteet += i;
            if (Opintopisteet > 0)
            {
                Opintopisteet = 0;
            }
        }
    }
}
