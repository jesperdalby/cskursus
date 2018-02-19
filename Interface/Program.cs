using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] array = new IDbFunktioner[3];

            array[0] = new Hund();
            array[1] = new Hund();
            array[2] = new Ubåd();

            foreach (var item in array)
            {
                item.Gem();
            }
        }
    }

    class Hund : IDbFunktioner
    {
        public int Navn { get; set; }
        public void Gem()
        {
            Console.WriteLine("Gemmer hund...");
        }
    }

    class Ubåd : IDbFunktioner
    {

        public int Nummer { get; set; }
        public int Turbine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd...");
        }
    }

    public interface IDbFunktioner
    {
        void Gem();        
    }
}
