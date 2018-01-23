using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {


            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string[] navn = { fornavn, efternavn };
            
            //string[] navn = string[2]
            string samletNavn = string.Join(" ", navn);

            Console.WriteLine(samletNavn);

            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);

            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);

            string del = samletNavn.Substring(7, 4);

            Console.WriteLine(del);


            string[] arrayNavn = samletNavn.Split(' ');
            for (int i = 0; i < arrayNavn.Length; i++)
            {
                Console.WriteLine(arrayNavn[i]);
            }


        }
    }
}
