using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpelklasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Fornavn = "Jesper";
            p1.Efternavn = "Dalby";
            p1.Fødselsår = 1975;
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.Alder());

        }
    }

    public class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
        public int Alder()
        {
            int år = DateTime.Now.Year;
            return år - this.Fødselsår;
        }

        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        public Person(string fornavn, string efternavn)
        {
            this.Fornavn = fornavn.ToUpper();
            this.Efternavn = efternavn.ToUpper();

        }    
    }
}

