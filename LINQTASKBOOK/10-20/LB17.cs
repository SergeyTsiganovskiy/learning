using System;
using System.Linq;

namespace LINQTASKBOOK
{
    public class LB17

    {
        public static void Main17(string[] args)
        {
            int[] arr = {1, 3, - 2, -2, -4, -6, -6};

            var query = arr.Where(x => x % 2 == 0).Distinct();

            Console.WriteLine("Result: ");
            query.ToList().ForEach(Console.WriteLine);
        }
    }
}
