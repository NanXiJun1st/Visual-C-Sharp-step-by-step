﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class Pass
    {
        public static void Value(int param)
        {
            param = 42;
        }

        public static void Reference(WrappedInt param)
        {
            param.Number = 42;
        }
    }
}
