using System;
using System.Linq;

namespace LINQTASKBOOK
{
    public class LB2
    {
        public static void Main2(string[] args)
        {
            int[] array = { -3, 10, 1, -1, 25, 5};

            int d = 20;

            var query1 = array.FirstOrDefault(x => x > 0 && x == d);

            Console.WriteLine(query1);
        }
    }
}
