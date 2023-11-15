using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doWork();
        }

        static void doWork()
        {
            int i = 0;
            Console.WriteLine(i);
            Pass.Value(i);
            Console.WriteLine(i);

            WrappedInt wi = new WrappedInt();
            Console.WriteLine(wi.Number);
            Pass.Reference(wi);
            Console.WriteLine(wi.Number);
            Console.WriteLine(WrappedInt.InitNumber);
        }
    }
}
