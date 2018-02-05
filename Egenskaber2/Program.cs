using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber2
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t = new Trekant();

            Console.WriteLine(t.Areal);
        }
    }

    class Trekant
    {

        public double Grundlinje { get; private set; }

        public double Højde { get; private set; }

        public double Areal
        {
            get { return Grundlinje * Højde * 0.5; }
        }

        public Trekant()
        {
            this.Højde = 5;
            this.Grundlinje = 7;
        }

    }
}
