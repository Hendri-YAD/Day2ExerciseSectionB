using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Exercise
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a salary:");
            double salary = Convert.ToDouble(Console.ReadLine());
            double totalIncome = 1.13 * salary;
            Console.WriteLine("The total income is: ${0:#,##0.00}", totalIncome);
        }
    }
}
