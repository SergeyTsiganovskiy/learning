using System;
using System.Linq;

namespace LINQTASKBOOK
{
    public class LB8
    {
        public static void Main8(string[] args)
        {

            int[] arr = { 2, 3, -5, -5, -10, 0, 8 , 22, 33};

            var q1 = arr.Count(x => x > 0 && x >= 10 && x <= 99);
            var q2 = arr.Where(x => x > 0 && x >= 10 && x <= 99).Average();

            if (q1 != 0)
            {
                double x = 0.0;
                Console.WriteLine((int) x);
                Console.WriteLine(x);
            }

            Console.WriteLine(q2);
        }
    }
}
