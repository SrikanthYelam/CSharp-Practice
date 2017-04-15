using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhereClause
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 6, 7, 3, 8, 9, 1 };

            var queryLowNums = from num in numbers
                               where num < 5 && num % 2 == 0
                               select num;
            //var queryLowNums = numbers.Where(num => num < 5 && num % 2 == 0);

            foreach (var i in queryLowNums)
            {
                Console.WriteLine(i);
            }

            //-------------------------------------------------------

            List<string> fruits = new List<string> { "Apple", "Mango", "Banana", "Guava", "Strawberry" };
            List<string> lst = fruits.Where(fruit => fruit.Length == 5).ToList();
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
