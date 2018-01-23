using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    int tal1 = ((i + 1) * (1 + j));

                    if (50 < tal1)

                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.Write(tal1.ToString().PadLeft(4));
                }

                Console.WriteLine();

            }


        }
    }
}
