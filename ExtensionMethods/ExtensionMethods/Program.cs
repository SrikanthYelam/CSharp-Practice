using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "srikanth";
            value = value.Capitalize("Yelam");
            Console.WriteLine(value);

            Person p1 = new Person { ID = 1, Name = "Srikanth" };
            Person p2 = new Person { ID = 2, Name = "Anil" };
            p1.sayHello(p2);

            Console.Read();            
        }
    }
}
