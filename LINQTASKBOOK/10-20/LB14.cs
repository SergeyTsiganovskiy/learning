using System;
using System.Linq;

namespace LINQTASKBOOK
{
    public class LB14

    {
        public static void Main14  (string[] args)
        {
            int a = 3;
            int b = 5;

            Console.WriteLine(Enumerable.Range(a, b - a).Average(x => Math.Pow(x, 2)));
        }
    }
}
