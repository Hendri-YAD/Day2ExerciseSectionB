using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Exercise
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number:");
            double num = Convert.ToDouble(Console.ReadLine());
            num = Math.Sqrt(num);
            Console.WriteLine("The square root of the number is: {0:0.###}", num);            
        }
    }
}
