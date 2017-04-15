using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace IEnumerableInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList lst = new MyArrayList();
            lst.Add(1);
            lst.Add("20");
            lst.Add("str");

            foreach (object o in lst)
            {
                Console.WriteLine(o);
            }
            Console.Read();
        }
    }

    public class MyArrayList : IEnumerable
    {
        object[] arr = null;
        int index = 0;
        public MyArrayList()
        {
            arr = new object[10];
        }

        public void Add(object item)
        {
            arr[index] = item;
            index++;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (object o in arr)
            {
                if (o == null)
                {
                    break;
                }

                yield return o;
            }
        }
    }
}

