using System;
using System.Linq;

namespace LINQTASKBOOK
{
    public class LB10

    {
        public static void Main10(string[] args)
        {
            string[] str = {"AAA", "BBB", "CCC"};

            int l = 4;

            var query = str.Where(x => x.Length.Equals(l)).OrderBy(x => x).LastOrDefault();

            Console.WriteLine(query);
        }
    }
}
