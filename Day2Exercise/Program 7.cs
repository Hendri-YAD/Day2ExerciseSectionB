using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Exercise
{
    class Program7
    {
        static void Main(string[] args)
        {
            double fixCharge = 2.40;
            Console.WriteLine("Please input the distance travelled in kilometres:");
            double distance = Convert.ToDouble(Console.ReadLine());

            double fare = fixCharge + 0.4 * distance;

            Console.WriteLine("fare is: " + fare);
        }
    }
}
