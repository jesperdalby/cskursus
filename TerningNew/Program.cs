using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningNew
{
    class Program
    {
        static void Main(string[] args)
        {

            LudoTerning[] l = new LudoTerning[2];
            Console.WriteLine("Ludo terning");
            for (int i = 0; i < l.Length; i++)
            {
                l[i] = new LudoTerning();
                l[i].Skriv();
            }

            Console.WriteLine("Terning");
            Terning[] t = new Terning[5];
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = new Terning();
                t[i].Skriv();
            }

            //for (int i = 0; i < t.Length; i++)
            //{
            //    t[i].Skriv();
            //}
            //
        }
    }

    class Terning
    {
        private int værdi;
        private static System.Random rnd = new Random();

        public int Værdi
        {
            get
            {
                return værdi;
            }
            set
            {
                if (value > 6)
                {
                    værdi = 1;
                }
                if (value < 1)
                {
                    værdi = 1;
                }
                else
                {
                    værdi = value;
                }
            }
        }


        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public virtual void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }

        public Terning()
        {
            this.Ryst();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }


    }

    class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            if (Værdi.Equals(3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ErStjerne()
        {
            if (Værdi.Equals(5))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public LudoTerning() : base()
        {
        }

        public LudoTerning(int værdi) : base(værdi)
        {
        }

        public override void Skriv()
        {
            switch (Værdi)
            {
                case 3:
                    Console.WriteLine("[S]");
                    break;
                case 5:
                    Console.WriteLine("[G]");
                    break;
                default:
                    base.Skriv();
                    break;
            }
        }

    }

}
