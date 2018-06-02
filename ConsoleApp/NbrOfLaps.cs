using System;
using System.Linq;

namespace ConsoleApp
{
    class NbrOfLaps
    {
        public static Tuple<int, int> Func(int x, int y)
        {
            var bobLap = 0;
            var charlesLap = 0;
            var bobDistance = 0;
            var charlesDistance = 0;

            do
            {
                if (bobDistance < charlesDistance)
                {
                    bobDistance += x;
                    bobLap++;
                }
                else
                {
                    charlesDistance += y;
                    charlesLap++;
                }

            } while (bobDistance != charlesDistance);

            return new Tuple<int, int>(bobLap, charlesLap);
        }
    }
}