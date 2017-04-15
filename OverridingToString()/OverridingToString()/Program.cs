using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverridingToString__
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { Name = "Srikanth", Age = 25 };
            Console.WriteLine(p);
            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "Name : " + Name + ", Age : " + Age;
        }
    }

    //Every class or struct in C# implicitly inherits the Object class. 
    //Therefore, every object in C# gets the ToString method, which returns a string representation of that object.
}
