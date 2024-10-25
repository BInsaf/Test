using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class EqualsArray
    {
        public static void EqualsArrayTest(string[] args)
        {
            string[] strings = { "hello", "world" };
            string[] moreStrings = { "hello", "world" };
            Console.WriteLine(strings.Equals(moreStrings));
        }
    }
}
