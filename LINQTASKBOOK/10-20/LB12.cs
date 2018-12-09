using System;
using System.Linq;

namespace LINQTASKBOOK
{
    public class LB12

    {
        public static void Main12(string[] args)
        {
            int[] str = {123, 333, 453, 1, 22};

            float s = 1;
            var query1 = str.Aggregate(s,(a, b) => s *= b % 10);

            Console.WriteLine(query1);
        }
    }
}
