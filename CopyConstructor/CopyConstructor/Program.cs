using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopyConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Srikanth", 25);
            Person p2 = new Person(p1);
            p2.Age = 26;
            Console.WriteLine(p1.Details());
            Console.WriteLine("\n");
            Console.WriteLine(p2.Details());
            Console.ReadLine();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(Person p)
        {
            Name = p.Name;
            Age = p.Age;
        }

        public string Details()
        {
            return "Name = " + Name + "\nAge = " + Age;
        }
    }
}
