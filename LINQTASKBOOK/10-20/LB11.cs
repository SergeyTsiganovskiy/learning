using System;
using System.Linq;

namespace LINQTASKBOOK
{
    public class LB11

    {
        public static void Main11(string[] args)
        {
            string[] str = {"AAA", "BBB", "CCC"};
            string z = string.Join("", str.Select(a => a[0]));
            Console.WriteLine(z);


            string s = "";
            var query = str.Aggregate(string.Empty, (a, b) => s += b[0]);
            Console.WriteLine(query);
        }
    }
}
