using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Honda h = new Honda();
            Honda h1 = new Honda(1);
            Honda h2 = new Honda("1");

            h.Add();
            h.Substract();
            h.Multiply();

            Console.ReadLine();
        }
    }

    abstract class Car
    {
        public Car()
        {
            Console.WriteLine("Base class constructor");
        }

        public Car(int a)
        {
            Console.WriteLine("Base class Parameterized int constructor");
        }

        public Car(string a)
        {
            Console.WriteLine("Base class Parameterized string constructor");
        }

        public void Add()
        {
            Console.WriteLine("Base class Add");
        }

        public virtual void Substract()
        {
            Console.WriteLine("Base class Substract");
        }

        public abstract void Multiply();
    }

    class Honda : Car
    {
        public Honda()
        {
            Console.WriteLine("Child class constructor");
        }

        public Honda(int a) : base(a)
        {
            Console.WriteLine("Child class Parameterized int constructor");
        }

        public Honda(string a) : base(a)
        {
            Console.WriteLine("Child class Parameterized string constructor");
        }

        public void Add()
        {
            Console.WriteLine("Child class Add");
        }

        public override void Substract()
        {
            Console.WriteLine("Child class Substract");
        }

        public override void Multiply()
        {
            Console.WriteLine("Child class Multiply");
        }
    }

    //Virtual methods have an implementation and provide the derived classes with the option of overriding it. 
    //Abstract methods do not provide an implementation and forces the derived classes to override the method. 
    //So, abstract methods have no actual code in them, and subclasses HAVE TO override the method.
}
