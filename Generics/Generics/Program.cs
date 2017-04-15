using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Result<int,string>();
            result.Success = true;
            result.Data = 4;
            result.Data1 = "test";
            var result1 = new Result<string, int> { Success = false, Data = "Srikanth", Data1 = 10 };

            var print = new PrintResult();
            print.Print(result);
            Console.WriteLine("------------------------");
            print.Print(result1);
            Console.Read();
        }
    }

    public class Result<type,type1>
    {
        public bool Success { get; set; }
        public type Data { get; set; }
        public type1 Data1 { get; set; }
    }

    public class PrintResult
    {
        public void Print<T,U>(Result<T,U> result)
        {
            Console.WriteLine(result.Success);
            Console.WriteLine(result.Data);
            Console.WriteLine(result.Data1);
        }
    }
}
