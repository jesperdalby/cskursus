using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber3
{
    class Program
    {
        static void Main(string[] args)
        {

            Vare v = new Vare();
            v.Pris = 10;
            v.Navn = "Mælk";

            Console.WriteLine(v.PrisMedMoms());

        }
    }

    class Vare
    {

        //Default constructor
        public Vare()
        {
        }

        //Custom constructor
        public Vare(string navn, double pris)
        {
            this.Navn = navn;
            this.Pris = pris;
        }


        //Public property, private field
        private string navn;

        public string Navn
        {
            get
            {
                Console.WriteLine("Aflæs navn");
                return navn;
            }
            set
            {
                Console.WriteLine("Tildel navn");
                navn = value;
            }
        }

        //Public property, private field
        private double pris;

        public double Pris
        {
            get
            {
                Console.WriteLine("Aflæs pris");
                return pris;
            }
            set
            {
                Console.WriteLine("Tildel pris");
                pris = value;
            }
        }
        //Public method
        public double PrisMedMoms()
        {
            return this.pris * 1.2;
        }

    }
}
