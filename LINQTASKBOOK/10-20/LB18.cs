using System;
using System.Linq;

namespace LINQTASKBOOK
{
    public class LB18

    {
        public static void Main18(string[] args)
        {
            int[] arr = {1, 3, - 2, -2, -4, -6, -6};

            var query = arr.Where(x => x % 2 == 0).Reverse();

            Console.WriteLine("Result: ");
            query.ToList().ForEach(Console.WriteLine);
        }
    }
}
