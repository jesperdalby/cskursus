using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int res = Beregn(1, 2);
            Console.WriteLine(res);
            int res1 = Beregn(1, 2, 3);
            Console.WriteLine(res1);
            int res2 = Beregn(1, 2, 4, 5);
            Console.WriteLine(res2);

        }

        private static int Beregn(int v1, int v2, int v3, int v4)
        {
            //return v1 + v2 + v3 + v4;
            return v4 + Beregn(v1, v2, v3);
        }

        private static int Beregn(int v1, int v2, int v3)
        {
            //return v1 + v2 + v3;
            return v3 + Beregn(v1, v2);
        }

        private static int Beregn(int v1, int v2)
        {
            return v1 + v2;
        }

       
    }
}
