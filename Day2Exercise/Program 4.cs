using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Exercise
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a temperature in Centigrade scale:");
            double temp = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = 1.8 * temp + 32;
            Console.WriteLine("The temperature in Fahrenheit is: {0:###0}", fahrenheit);
        }
    }
}
