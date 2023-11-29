using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseEnumerate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void doWork()
        {
            Month first = Month.December;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
        }
    }
}
