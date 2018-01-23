using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int heltal = 10;

            heltal++;
            heltal--;

            heltal += 20;

            Console.WriteLine(heltal.ToString());

            double kommatal = 12.5;

            kommatal++;
            kommatal--;
            kommatal *= 2;

            Console.WriteLine(kommatal.ToString());


            FilTyper ft = FilTyper.pdf;


            Console.WriteLine(ft);


            Console.WriteLine((int)ft);

            DateTime dato = DateTime.Now;
            Console.WriteLine(dato.ToString("ddMMyy"));


            Person p = new Person();
            p.id = 1;
            p.navn = "Mikkel";

            Console.WriteLine(p.navn);

        }
    }

    enum FilTyper
    {
        csv,
        pdf,
        txt

    }

    struct Person
    {
        public int id;
        public string navn;

    }
}
