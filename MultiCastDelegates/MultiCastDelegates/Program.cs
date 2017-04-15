using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiCastDelegates
{
    class Program
    {
        public delegate void MCDelegate(int a, int b);
        static void Main(string[] args)
        {
            MCDelegate mc1 = new MCDelegate(AddNum);
            MCDelegate mc2 = new MCDelegate(MultiplyNum);
            MCDelegate multicast = (MCDelegate)Delegate.Combine(mc1, mc2);
            multicast.Invoke(2, 3);

            MCDelegate multicast1 = mc1 + mc2;
            multicast1.Invoke(5, 6);
        }

        public static void AddNum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void MultiplyNum(int a, int b)
        {
            Console.WriteLine(a * b);
            Console.ReadLine();
        }
    }
}
