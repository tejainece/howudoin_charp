using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using NameSpaced;

namespace ConsoleApp1
{
    class Hello
    {
        private string name = "Hello";
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                Console.WriteLine("Name changed from " + name + " to " + value + "!");
                name = value;
            }

        }

        public int AddMethod(int a, int b)
        {
            return a + b;
        }

        public static int AddClassMethod(int a, int b)
        {
            return a + b;
        }

        public static void ForLoopExample()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public static void Arrays()
        {
            int[] tables = new int[10];

            for(int i = 0; i < tables.Length; i++)
            {
                tables[i] = i;
            }

            foreach (int i in tables)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(tables.Average() + " is average!");

            Console.WriteLine("Sum is " + tables.Aggregate((a,b) => a + b));
        }

        public static void StringArray()
        {
            string[] tables = new string[10];

            for (int i = 0; i < tables.Length; i++)
            {
                tables[i] = i.ToString();
            }

            foreach (string i in tables)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(tables.Average((a) => int.Parse(a)) + " is average!");
        }

        public static void DynamicExample()
        {
            dynamic tables = new int[10];

            for (int i = 0; i < tables.Length; i++)
            {
                tables[i] = i;
            }

            //WONT_WORK: Console.WriteLine(tables.Average() + " is average!");

            Console.WriteLine(Enumerable.Average(tables) + " is average!");
        }

        public static void DynamicArray()
        {
            dynamic[] tables = new dynamic[10];

            for (int i = 0; i < (tables.Length/2); i++)
            {
                tables[i] = i;
            }

            for (int i = (tables.Length/2); i < tables.Length; i++)
            {
                tables[i] = i.ToString();
            }

            foreach(dynamic obj in tables)
            {
                if (obj is int)
                {
                    Console.WriteLine(obj);
                } else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Change console background color and foreground color
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // Print to stdout
            Console.WriteLine("Hello world!");

            // Create an instance of an object
            Hello hello = new Hello();

            // Call Add method on Hello object
            Console.WriteLine(hello.AddMethod(5, 4));

            // Call static method on Hello class
            Console.WriteLine(Hello.AddClassMethod(5, 5));

            Hello.ForLoopExample();

            Hello.Arrays();

            Hello.StringArray();

            Hello.DynamicExample();

            Hello.DynamicArray();

            Console.WriteLine(hello.Name);
            hello.Name = "Teja";
            Console.WriteLine(hello.Name);

            hello.sayHello();

            Class1 class1 = new Class1();

            NameSpaced.NamespacedClass nameSpacedClass = new NameSpaced.NamespacedClass();
            nameSpacedClass.Print();

            NamespacedClass nameSpacedClass1 = new NamespacedClass();
            nameSpacedClass1.Print();

            FromClassLibrary fromClassLibrary = new FromClassLibrary();

            Console.WriteLine(fromClassLibrary.IntToString(5));
            try
            {
                Console.WriteLine(fromClassLibrary.IntToString(6));
            } catch(Exception exp)
            {
                Console.WriteLine(exp);
            }

            Console.ReadLine();
        }
    }

    static class Extensions
    {
        static public void sayHello(this Hello hello)
        {
            Console.WriteLine("Saying hello!");
        }
    }
}
