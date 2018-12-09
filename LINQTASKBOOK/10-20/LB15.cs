using System;
using System.Linq;

namespace LINQTASKBOOK
{
    public class LB15

    {
        public static void Main15(string[] args)
        {
            Console.WriteLine(Enumerable.Range(1, 15).Aggregate(1.0, (a , b) => a * b));
        }
    }
}
