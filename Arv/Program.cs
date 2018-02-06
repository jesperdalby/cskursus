using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
            p.Fornavn = "Jesper";

            p.Efternavn = "Dalby";

            Console.WriteLine(p.Fuldtnavn());

            Elev e = new Elev();
            e.Fornavn = "Jesper";

            e.Efternavn = "Dalby";
            e.Klasselokale = "33a";

            Console.WriteLine(e.Fuldtnavn());

            Instruktør i = new Instruktør();
            i.Fornavn = "Jens";
            i.Efternavn = "Hansen";
            i.Nøgletal = 22;
            Console.WriteLine(i.Fuldtnavn());

        }
    }

    class Person
    {

        public string Fornavn { get; set; }

        public string Efternavn { get; set; }


        public string Fuldtnavn()
        {
            return this.Fornavn + " " + this.Efternavn;

        }

    }

    public class Elev : Person
    {
        public string Klasselokale { get; set; }

    }

    public class Instruktør : Person
    {
        public int Nøgletal { get; set; }

    }


}
