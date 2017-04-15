using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.FullName);

            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine("Type : " + type.Name + " BaseType : " + type.BaseType);

                var props = type.GetProperties();
                foreach (var prop in props)
                {
                    Console.WriteLine("\tProperty : " + prop.Name + " PropertyType : " + prop.PropertyType);
                }

                var fields = type.GetFields();
                foreach (var field in fields)
                {
                    Console.WriteLine("\tField : " + field.Name);
                }

                var methods = type.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine("\tMethod : " + method.Name);
                }
            }

            var sample = new sample { Name = "Srikanth", Age = 25 };
            var sampleType = typeof(sample);

            var nameProperty = sampleType.GetProperty("Name");
            Console.WriteLine("Property Value : " + nameProperty.GetValue(sample, null));

            var myMethod = sampleType.GetMethod("MyMethod");
            myMethod.Invoke(sample, null);

            //Attributes using Reflection---------------------------------------------------------------------------

            var attrClassTypes = assembly.GetTypes().Where(t => t.GetCustomAttributes(typeof(MyClassAttribute),true).Count() > 0);
            foreach (var attrClassType in attrClassTypes)
            {
                Console.WriteLine("Attribute Class : " + attrClassType.Name);

                var attrMethodTypes = attrClassType.GetMethods().Where(t => t.GetCustomAttributes(typeof(MyMethodAttribute), true).Count() > 0);
                foreach (var attrMethodType in attrMethodTypes)
                {
                    Console.WriteLine("Attribute Method : " + attrMethodType.Name);
                }
            }
            
            Console.ReadLine();
        }
    }

    public class sample
    {
        public string Name { get; set; }
        public int Age;

        public void MyMethod()
        {
            Console.WriteLine("Hello from MyMethod!");
        }
    }

    [MyClass]
    public class sample1
    {
        public string Name { get; set; }
        public int Age;

        [MyMethod]
        public void MyMethod()
        {
           
        }

        public void NoAttributeMethod()
        {

        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class MyClassAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Method)]
    public class MyMethodAttribute : Attribute
    {

    }
}
