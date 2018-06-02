using System;
using System.Linq;

namespace ConsoleApp
{
    class ToWeirdCase
    {
        public static string Func(string s)
        {
            var ret = "";
            foreach (var item in s.Split(' '))
            {
                var cArr = item.ToCharArray().Select((value, index) => new { value, index });
                ret += new string(cArr.Select(c => c.index % 2 == 0 ? Char.ToUpper(c.value) : Char.ToLower(c.value)).ToArray()) + " ";
            }
            return ret.Substring(0, ret.Length - 1);
        }
    }
}