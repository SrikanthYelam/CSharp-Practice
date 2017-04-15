using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YieldKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in Integers())
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }

        public static IEnumerable<int> Integers()
        {
            //“Yield keyword helps us to do custom stateful iteration over .NET collections.”
            //There are two scenarios where “yield” keyword is useful:-
            //1.Customized iteration through a collection without creating a temporary collection.
            //2.Stateful iteration.
            yield return 1;
            yield return 2;
            yield return 4;
            yield return 8;
            yield return 16;
            yield return 16777216;
        }
    }
}
