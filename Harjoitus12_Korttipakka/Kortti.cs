using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus12_Korttipakka
{
     class Kortti
    {
        public string Maa { get; set; }
        public string Arvo { get; set; }

        public Kortti(string maa, string arvo)
        {
            Maa = maa;
            Arvo = arvo;
        }

        public override string ToString()
        {
            return Arvo + " - " + Maa;
        }
    }
}
