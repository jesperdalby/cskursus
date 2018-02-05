using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningApp1
{
    public class Terning
    {
        public int Værdi;
        private System.Random rnd = new Random();
        public Terning(int v)
        {
            this.Værdi = 1;
        }

        public void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }

        public void Ryst(bool snyd)
        {
            if (snyd)
            {
                this.Værdi = 6;
            }
            else
            {
                Ryst();
            }
        }


        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);

        }


    }

    public class Bæger
    {

        private Terning[] terninger = new Terning[5];

        public Bæger()
        {
            for (int i = 0; i < 5; i++)
            {
                terninger[i] = new Terning();
            }
        }

        public void Skriv()
        {
            Console.WriteLine("Bæger --- ");
            for (int i = 0; i < 5; i++)
            {
                //terninger[i].Skriv();
                Console.Write("[" + terninger[i].Værdi + "] ");
            }
            Console.WriteLine();

        }

    }
}
