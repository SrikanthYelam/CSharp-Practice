using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatesUsingAnonymousMethodsAndLambdaExpr
{
    delegate void Operation(int num);
    class Program
    {
        static void Main(string[] args)
        {
            Operation op = delegate(int num) { Console.WriteLine("{0} x 2 = {1}", num, num * 2); };  //Using Anonymous methods
            Operation op1 = (int num) => { Console.WriteLine("{0} x 2 = {1}", num, num * 2); };      //Using Lambda Expressions
            op(2);
            op1(3);

            //Using Generic delegates Action<> and Func<>
            //Generic delegates don't need delegate declaration at the top
            //Action delegate doesn't return any value whereas Func delegate returns a value

            Action<int> op2 = num => { Console.WriteLine("{0} x 2 = {1}", num, num * 2); };
            op2(4);

            Func<int, int> op4 = num => { return num * 2; };
            Console.WriteLine(op4(5));

            Console.ReadKey();
        }

        //static void Double(int num)
        //{
        //    Console.WriteLine("{0} x 2 = {1}", num, num * 2);
        //}
    }
}
