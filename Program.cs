using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static int[] array = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
        public static void Main(string[] args)
        {
            var sp = new Stats();
            sp.Numbers = array;

            var x = sp.Mean();
            Console.WriteLine($"Mean is {x}");
            var y = sp.Median();
            Console.WriteLine("Median is " + y);
            var z = sp.Mode();
            Console.WriteLine("Mode is " + z);
        }
    }
}