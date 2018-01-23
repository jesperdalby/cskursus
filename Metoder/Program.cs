using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Lægsammen(5, 2);
            Console.WriteLine(res);

            double areal = BeregnAreal(5);

            Console.WriteLine(areal);

            Udskriv("Dette er en test");

            int[] løn = { 10000, 5000, 30000 };

            double gns = Gennemsnit(løn);

            Console.WriteLine(gns);

        }


        private static double Gennemsnit(int[] løn)
        {

            double sum = 0;
            for (int i = 0; i < løn.Length; i++)
            {
                sum += løn[i];
            }

            return sum / løn.Length;
          

        }

        private static void Udskriv(string v)
        {
            Console.WriteLine(v);
        }

        private static double BeregnAreal(int radius)
        {
            return radius * radius * Math.PI;
        }

        static int Lægsammen(int a, int b)
        {
            return a + b;
        }
    }
}
