using System;
using System.Linq;

namespace LINQTASKBOOK
{
    public class LB13

    {
        public static void Main13(string[] args)
        {
            int l = 3;

            Console.WriteLine(Enumerable.Range(2, 2).Aggregate(1.0, (a, b) => a + (double)1 / b));
        }
    }
}
