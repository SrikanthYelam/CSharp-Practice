using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    //delegate void MyDelegate(string name);

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        MyDelegate del = SayHello;
    //        del("Srikanth");
    //        Test(SayHello);
    //        SayHello("Sai");
    //        Console.Read();
    //    }

    //    static void SayHello(string name)
    //    {
    //        Console.WriteLine("Hey there!, {0}", name);
    //    }

    //    static void Test(MyDelegate del)
    //    {
    //        del("Anil");
    //    }
    //}

    delegate void MyDelegate(int num);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del = Double;
            //ExecuteOperation(2, del);

            //del = Triple;
            del = del + Triple;       //chaining of methods
            ExecuteOperation(2, del); //Invokes one after the other

            Console.ReadKey();
        }

        static void Double(int num)
        {
            Console.WriteLine("{0} x 2 = {1}", num, num * 2);
        }

        static void Triple(int num)
        {
            Console.WriteLine("{0} x 3 = {1}", num, num * 3);
        }

        static void ExecuteOperation(int num, MyDelegate del)
        {
            del(num);
        }
    }
}
