using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Exercise
{
    class Program9
    {
        static void Main(string[] args)
        {
            double fixCharge = 2.40;
            Console.WriteLine("Please input the distance travelled in kilometres:");
            double distance = Convert.ToDouble(Console.ReadLine());

            double fare = fixCharge + 0.4 * distance;

            fare = Math.Ceiling(fare * 10) / 10;

            Console.WriteLine("fare is: {0:###0.0}" ,fare);
        }
    }
}
