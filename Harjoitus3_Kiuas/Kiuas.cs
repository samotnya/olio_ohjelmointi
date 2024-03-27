using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3_Kiuas
{
    internal class Kiuas
    {
        private int onkoPäällä;
        private int lämpötila;
        private int kosteus;

        public Kiuas()
        {
            onkoPäällä = 0; // 0 = pois päältä, 1 = päällä
            lämpötila = 20; // Oletuslämpötila
            kosteus = 50;   // Oletuskosteus
        }

        public void KytkePäälle()
        {
            onkoPäällä = 1;
            Console.WriteLine("Kiuas on nyt päällä.");
        }

        public void KytkePoisPäältä()
        {
            onkoPäällä = 0;
            Console.WriteLine("Kiuas on nyt pois päältä.");
        }

        public void AsetaLämpötila(int lämpö)
        {
            lämpötila = lämpö;
            Console.WriteLine("Lämpötila asetettu: " + lämpötila + " astetta.");
        }

        public void AsetaKosteus(int kosteudet)
        {
            kosteus = kosteudet;
            Console.WriteLine("Kosteus asetettu: " + kosteus + "%.");
        }
    }
}

