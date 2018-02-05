using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();

            p.Fornavn = "Jesper";
            p.Efternavn = "Dal";
            Console.WriteLine(p.FuldtNavn());
        }

       
    }


    class Person
    {
        public string Fornavn { get; set; }
        private string efternavn;     

        public string Efternavn
        {
            get { return efternavn; }

            set {

                if (value.Length > 3)
                {
                    efternavn = "";
                }
                else
                {
                    efternavn = value;
                }                
            }
        }
        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }

    }
}
