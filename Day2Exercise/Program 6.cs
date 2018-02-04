using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Exercise
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input (x,y) coordinates:");
            Console.WriteLine("X1 is:");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Y1 is:");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("X2 is:");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Y2 is:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
            Console.WriteLine("distance is: " + distance);
        }
    }
}
