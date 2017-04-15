using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    struct books
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;

        public void getValues(string t, string a, string s, int b)
        {
            title = t;
            author = a;
            subject = s;
            book_id = b;
        }

        public void display()
        {
            Console.WriteLine("Title is: {0}", title);
            Console.WriteLine("Author is: {0}", author);
            Console.WriteLine("Subject is: {0}", subject);
            Console.WriteLine("BookID is: {0}\n", book_id);
        }
    };

    class Program
    {
        static void Main(string[] args)
        {
            books book1 = new books();
            books book2 = new books();

            book1.getValues("1984", "George Orwell", "Fiction", 123);
            book2.getValues("The Immortals of Meluha", "Amish Tripathi", "Mythology", 456);

            book1.display();
            book2.display();

            Console.ReadKey();
        }
    }

    //A struct type is a value type that is typically used to encapsulate small groups of related variables, 
    //such as the coordinates of a rectangle or the characteristics of an item in an inventory. 

    //Structs can also contain constructors, constants, fields, methods, properties, indexers, operators, events, and nested types, 
    //although if several such members are required, you should consider making your type a class instead.

    //Structs can implement an interface but they cannot inherit from another struct. For that reason, struct members cannot be declared as protected.

}
