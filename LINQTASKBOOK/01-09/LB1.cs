using System;
using System.Linq;

namespace LINQTASKBOOK
{
    public class LB1
    {
        public static void Main1(string[] args)
        {
            int[] array = { -3, 10, 1, -1, 25, 5};

            var query1 = array.First(x => x > 0);

            var query2 = array.Last(x => x < 0);

            Console.WriteLine(query2);
        }
    }
}
