using System;
using System.Text.RegularExpressions;

namespace RegExpression
{
    class Program
    {
        private static void showMatch(string text, string exp)
        {
            Console.WriteLine("The Expression: {0}", exp);
            MatchCollection mc = Regex.Matches(text, exp);
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            string str = "make maze and manage to measure it";

            Console.WriteLine("Matching words start with 'm' and end with 'e':");
            showMatch(str, @"\bm\S*e\b");
            Console.ReadKey();
        }
    }
}
