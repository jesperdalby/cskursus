﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] løn = { 1000, 2000, 3000, 2000 };
            double sum = 0;
            for (int i = 0; i < løn.Length; i++)
            {
                sum += løn[i];
            }
           
            double gennemsnit = sum / løn.Length;

            for (int i = 0; i < løn.Length; i++)
            {
                Console.WriteLine("Månedsløn " + (1+i) + ": "+ løn[i]);
            }
       
            Console.WriteLine("Gennemsnit " + gennemsnit.ToString("N2"));
        }
    }
}
