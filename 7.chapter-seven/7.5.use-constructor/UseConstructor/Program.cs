using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseConstructor
{
    class Program
    {
        static void doWork()
        {

            Point origin = new Point();
            Point bottomRight = new Point(2496, 1664);
            double distance = origin.DistanceTo(bottomRight);

            Console.WriteLine($"distance is: {distance}");
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
