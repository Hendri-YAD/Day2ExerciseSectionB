using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Exercise
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number:");
            int x = (int) Convert.ToDouble(Console.ReadLine());
            int y = 5 * (int) Math.Pow(x, 2) - 4 * x + 3;
            Console.WriteLine("y is: {0}", y);
        }
    }
}
