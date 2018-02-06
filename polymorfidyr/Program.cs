using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfidyr
{
    class Program
    {
        static void Main(string[] args)
        {
            Dyr[] d = new Dyr[20];
            for (int i = 0; i < 20; i++)
            {
                d[i] = Dyr.TilFældigtDyr();
            }

            foreach (var item in d)
            {
                item.SigNoget();
            }
        }
    }

    class Dyr
    {
        public string Navn { get; set; }
        static System.Random rnd = new Random();

        public static Dyr TilFældigtDyr()
        {
            string sti = @"x:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);
            int rndnumber = rnd.Next(0, navne.Length);
            if (rndnumber % 2 == 0)
            {
                return new Hund() { Navn = navne[rndnumber] };
            }
            else
            {
                return new Kat() { Navn = navne[rndnumber] };
            }
        }

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder " + Navn);
        }
    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hund og hedder " + Navn);
        }
    }

    class Kat : Dyr
    {
        public override void SigNoget()
        {
            {
                Console.WriteLine("Jeg er en kat og hedder " + Navn);
            }
        }
    }
}
