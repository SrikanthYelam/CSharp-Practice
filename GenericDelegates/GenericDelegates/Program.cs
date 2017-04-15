using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericDelegates
{
    class Program
    {
        public delegate string GenericAdd<T1, T2>(T1 a, T2 b);
        static void Main(string[] args)
        {
            GenericAdd<int, int> intAdd = new GenericAdd<int, int>(AddInt);
            GenericAdd<string, string> stringAdd = new GenericAdd<string, string>(AddString);

            Console.WriteLine(intAdd(2, 3));
            Console.WriteLine(AddString("Srikanth", "Yelam"));
            Console.Read();
        }

        public static string AddInt(int a, int b)
        {
            return a + b.ToString();
        }

        public static string AddString(string a, string b)
        {
            return a + b.ToString();
        }
    }
}
