using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    public static class Extensions
    {
        public static string Capitalize(this string value, string r)
        {
            char[] chrArray = value.ToCharArray();
            chrArray[0] = char.ToUpper(chrArray[0]);
            return new string(chrArray) + " " + r;
        }

        public static void sayHello(this Person p1, Person p2)
        {
            //Console.WriteLine(p1.Name + " says Hello to " + p2.Name);
            Console.WriteLine("{0} says Hello to {1}", p1.Name, p2.Name);
        }
    }
}
