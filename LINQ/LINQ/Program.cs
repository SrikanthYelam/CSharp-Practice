using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var sample = "I enjoy writing uber-software in C#";

            var results = from c in sample.ToLower()
                          where c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
                          orderby c descending
                          select c;

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------------------------------------------------");

            var results1 = from c in sample.ToLower()
                           where c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
                           orderby c ascending
                           group c by c;

            foreach (var item in results1)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Count());
            }

            Console.WriteLine("-------------------------------------------------------------------------------");

            var people = new List<Person>
            {
                new Person{FirstName = "Srikanth", LastName = "Yelam", Age = 25},
                new Person{FirstName = "Anil", LastName = "Yelam", Age = 24},
                new Person{FirstName = "Sai", LastName = "Yelam", Age = 12},
                new Person{FirstName = "Ram", LastName = "Athota", Age = 29},
                new Person{FirstName = "Hanu", LastName = "Athota", Age = 31},
            };

            var results2 = from p in people
                           where p.Age < 26
                           orderby p.FirstName
                           select p;

            var results3 = from p in people
                           orderby p.LastName descending
                           group p by p.LastName;

            foreach (var item in results2)
            {
                Console.WriteLine("{0}, {1}", item.FirstName, item.LastName);
            }

            Console.WriteLine("-------------------------------------------------------------------------------");

            foreach (var item in results3)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Count());
                foreach (var p in item)
                {
                    Console.WriteLine("\t{0}, {1}", p.FirstName, p.LastName);
                }
            }

            Console.Read();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
