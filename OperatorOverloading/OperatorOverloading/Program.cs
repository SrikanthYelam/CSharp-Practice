using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiply m1 = new Multiply(3, 4);
            Console.WriteLine(m1.Mul());

            Multiply m2 = new Multiply(2, 3);
            Console.WriteLine(m2.Mul());

            Multiply m3 = null;
            m3 = m1 + m2;
            
            Console.WriteLine(m3.Mul());

            //Mult m;
            //Console.WriteLine(m.Mul());

            if (m1 > m2)
            {
                Console.WriteLine("m1 is greater than m2.");
            }
            else if (m1 < m2)
            {
                Console.WriteLine("m1 is less than m2.");
            }
            Console.ReadLine();
        }
    }

    public class Multiply
    {
        private int num1;
        private int num2;

        public Multiply()
        {

        }

        public Multiply(int a, int b)
        {
            num1 = a;
            num2 = b;
        }

        public int Mul()
        {
            return num1 * num2;
        }

        public static Multiply operator +(Multiply m1, Multiply m2)
        {
            Multiply m3 = new Multiply();
            m3.num1 = m1.num1 + m2.num1;
            m3.num2 = m1.num2 + m2.num2;

            return m3;
        }

        public static bool operator >(Multiply m1, Multiply m2)
        {
            if (m1.num1 > m2.num1 && m1.num2 > m2.num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Multiply m1, Multiply m2)
        {
            if (m1.num1 < m2.num1 && m1.num2 < m2.num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    //public struct Mult
    //{
    //    public int Mul()
    //    {
    //        return 1;
    //    }
    //}
}
