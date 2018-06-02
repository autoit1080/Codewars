using System;
using System.Linq;

namespace ConsoleApp
{
    class IQ
    {
        public static int Test(string numbers)
        {
            UInt16 even = 0;
            UInt16 odd = 0;
            Int16 index = 1;
            Int16 evenPos = -1;
            Int16 oddPos = -1;

            var nums = numbers.Split(' ');
            foreach (var c in nums)
            {
                if (Int32.Parse(c) % 2 == 0)
                {
                    evenPos = index;
                    even++;
                }
                else
                {
                    oddPos = index;
                    odd++;
                }
                if (odd > 0 && even > 0)
                {
                    if (odd > 1 || even > 1)
                    {
                        return odd == 1 ? oddPos : evenPos;
                    }

                }
                index++;
            }
            return -1;
        }
    }
}