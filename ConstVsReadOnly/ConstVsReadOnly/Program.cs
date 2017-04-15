using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstVsReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(6);
            Console.WriteLine(p.readVal);
            Console.WriteLine(Person.readVal1);
            Console.WriteLine(Person.constVal);
            Console.ReadLine();
        }
    }

    class Person
    {
        public readonly int readVal;
        public const int constVal = 3;

        public static readonly int readVal1 = 4;

        public Person()
        {
            readVal = 2;             //readonly can be intialized only at declaration or in the constructor.
            //readVal1 = 5;         //cannot assign values to static readonly
        }
        public Person(int a)
        {
            readVal = a;
        }
    }

    //const
    //They can not be declared as static (they are implicitly static)
    //The value of constant is evaluated at compile time
    //constants are initialized at declaration only

    //readonly
    //They can be either instance-level or static
    //The value is evaluated at run time
    //readonly can be initialized in declaration or by code in the constructor
}
