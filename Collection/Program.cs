using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person { Id = 1, Navn = "Jesper" });
            list.Add(new Person { Id = 2, Navn = "Svend" });
            list.Add(new Person { Id = 3, Navn = "Kurt" });

            foreach (var item in list)

            {
                Console.WriteLine(item.Navn);
            }

            Dictionary<int, Person> dic = new Dictionary<int, Person>();

            dic.Add(1, new Person { Id = 1, Navn = "Jesper" });
            dic.Add(2, new Person { Id = 2, Navn = "Svend" });
            dic.Add(3, new Person { Id = 3, Navn = "Kurt" });

            var p = dic[2];
            Console.WriteLine(p.Navn);

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }




    }

}


