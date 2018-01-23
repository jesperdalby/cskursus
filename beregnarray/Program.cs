using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beregnarray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] test = { 10, 7, 6, 3, 1, 50, 3 };
            var res = BeregnOgSorterArray(test);
            Console.WriteLine(res.sum);
            Console.WriteLine(res.gennemsnit);
        }

        public static ArrayResultat BeregnOgSorterArray(int[] a)
        {
            ArrayResultat r;


            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            r.sum = sum;
            r.gennemsnit = sum / a.Length;
            Array.Sort(a);
            return r;

        }
    }

    struct ArrayResultat
    {
        public double sum;
        public double gennemsnit;

    }
}
