using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            x = (x == 16) ? x = 0 : x = 1;

            Console.WriteLine(fun(out x));

            Console.WriteLine(x);
            Console.ReadKey();
        }
        public static int fun(out int x)
        {
            x = 10;
            return 0;
        }

        public static Tuple<int, int> NbrOfLaps(int x, int y)
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