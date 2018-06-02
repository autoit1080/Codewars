using System;
using System.Linq;

namespace ConsoleApp
{
    class DnaStrand
    {
        public static string MakeComplement(string dna)
        {
            string ret = "";
            for (int i = 0; i < dna.Length; i++)
            {
                var x = dna[i].ToString();

                if (x == "A") x = x.Replace("A", "T");
                else if (x == "T") x = x.Replace("T", "A");
                else if (x == "C") x = x.Replace("C", "G");
                else if (x == "G") x = x.Replace("G", "C");

                ret += x;
            }
            return ret;
        }
    }
}