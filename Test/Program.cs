using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
   
            public static void Main(string[] args)
            {

                Console.WriteLine("Hello World!");
                int a = 42;
                int b = 119;
                int c = a + b;
                int x = Max(a, b);
                Console.WriteLine(c);
                Console.WriteLine(x);
                Console.WriteLine(test());

            var p = new Person("Eric Arthur Blair");
            Console.WriteLine("p: " + p);

            var ints = new int[] { 1, 2, 3 };
            Console.WriteLine("ints: " + ints);

            Console.ReadKey();

            }

            public static string test()
            {
                string Surname = "", Forenames = "", FormattedName = "";
                string format = "Hello";
                FormattedName = string.Format(format, Surname, Forenames);
                return FormattedName;
            }
            public static int Max(int a, int b)
            {
                return a > a ? a : b;
            }
        class Person
        {
            private string Name;

            public Person(string name)
            {
                this.Name = name;
            }
        }


    }


}

