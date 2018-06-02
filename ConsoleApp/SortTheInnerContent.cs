using System;
using System.Linq;

namespace ConsoleApp
{
    class SortTheInnerContent
    {
        public static string sort(string words)
        {
            var ret = "";
            var wArray = words.Split(' ');
            for (int i = 0; i < wArray.Length; i++)
            {
                var cArray = wArray[i].ToList();
                var first = Char.MinValue;
                var last = Char.MinValue;
                if (cArray.Count > 1)
                {
                    first = cArray[0];
                    last = cArray[cArray.Count - 1];
                    cArray.RemoveAt(0);
                    cArray.RemoveAt(cArray.Count - 1);
                    cArray.Sort();
                    cArray.Reverse();
                }
                if (first != Char.MinValue)
                    ret += first;
                ret += String.Join("", cArray);
                if (last != Char.MinValue)
                    ret += last;
                ret += " ";
            }
            return ret.Remove(ret.Length - 1, 1);
        }
    }
}