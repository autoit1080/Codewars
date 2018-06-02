using System;
using System.Linq;

namespace ConsoleApp
{
    class BinaryArrayToNumber
    {
        public static int Func(int[] BinaryArray)
        {
            int ret = 0;
            int pos = 1;
            foreach (var bin in BinaryArray.Reverse())
            {
                ret += pos * bin;
                pos *= 2;
            }
            return ret;
        }
    }
}