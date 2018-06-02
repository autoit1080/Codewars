using System;
using System.Linq;

namespace ConsoleApp
{
    class FirstNonRepeatingLetter
    {
        public static string Func(string s)
        {
            foreach (var c in s.ToCharArray())
            {
                if (s.Count(x => Char.ToLower(x) == Char.ToLower(c)) == 1)
                    return c.ToString();
            }

            return "";
        }
    }
}