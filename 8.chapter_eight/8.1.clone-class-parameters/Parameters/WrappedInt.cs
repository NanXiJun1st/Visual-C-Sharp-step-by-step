using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class WrappedInt
    {
        public int Number;
        public static int InitNumber = 0;

        public WrappedInt() { InitNumber++; }
    }
}
