using System;
using System.Linq;

namespace LINQTASKBOOK
{
    public class LB6
    {
        public static void Main6(string[] args)
        {

            string[] strarr = { "asfd","s25", "1"};

            int tl1 = strarr.Aggregate((a, b) => a + b).Length;

            int tl2 = strarr.Sum(x => x.Length);

            Console.WriteLine(tl1);
            Console.WriteLine(tl2);
        }
    }
}
