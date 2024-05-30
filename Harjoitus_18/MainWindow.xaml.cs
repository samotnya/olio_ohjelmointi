using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Harjoitus_18
{
    public static class Laskin
    {
        public static double Summa(double a, double b)
        {
            return a + b;
        }

        public static double Erotus(double a, double b)
        {
            return a - b;
        }

        public static double Kertolasku(double a, double b)
        {
            return a * b;
        }

        public static double Jakolasku(double a, double b)
        {
            return a / b;
        }
    }
}
