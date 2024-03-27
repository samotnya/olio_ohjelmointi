using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus6_Eläimet
{
     class kissa : eläin
    {
        private static int instanssit = 0;
        public kissa()
        {
            instanssit++;
        }
        public static new void KuinkaMonta()
        {
            Console.WriteLine("Kissoja luotu " + instanssit);
        }
        public override void Ääntele()
        {
            Console.WriteLine("Meow");
        }
    }
}
