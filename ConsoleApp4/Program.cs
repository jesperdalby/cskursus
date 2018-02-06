using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statiskemetoder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ArealBeregninger.BeregnArealFirkant(10, 10));
            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(10));
        }
    }

    static class ArealBeregninger
    {
       public static double BeregnArealFirkant(double højde, double brede)
        {
            return højde * brede;
         }

       public static double BeregnArealCirkel(double radius)
        {
            return Math.PI * radius * radius;
        }



    }


}
