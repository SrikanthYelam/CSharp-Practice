using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    class Program
    {
        enum Days { Sun = 9, Mon, Tue, Wed, Thu, Fri, Sat };

        enum Range : long { Max = 1000000L, Min = 100L };

        static void Main(string[] args)
        {
            int WeekDayStart = (int)Days.Mon;
            int WeekDayEnd = (int)Days.Fri;

            Console.WriteLine("WeekDayStart: {0}", WeekDayStart);
            Console.WriteLine("WeekDayEnd: {0}", WeekDayEnd);

            //Console.WriteLine("WeekDayStart and WeekDayEnd are: {0},{1}", WeekDayStart, WeekDayEnd);

            Console.WriteLine((long)Range.Max);
            Console.WriteLine((long)Range.Min);

            Console.ReadKey();
        }
    }
}
