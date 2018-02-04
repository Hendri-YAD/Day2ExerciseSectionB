using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Exercise
{
    class Program10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a, b and c:");
            Console.WriteLine("a is :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b is :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c is :");
            int c = Convert.ToInt32(Console.ReadLine());

            double s = (a + b + c) / 2;

            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine("area is {0:0}", area);

        }
    }
}
