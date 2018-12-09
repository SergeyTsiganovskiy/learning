using System;
using System.Linq;

namespace LINQTASKBOOK
{
    public class LB19

    {
        public static void Main(string[] args)
        {
            int k = 1;
            
            int[] arr = {1, 1, 31, 61, 31, - 2, -2, 41, 41, -6, 61, 61, 61, 61};

            var query = arr.Where(x => x > 0 && x % 10 == k).Reverse().Distinct().Reverse();

            Console.WriteLine("Result: ");
            query.ToList().ForEach(Console.WriteLine);
        }
    }
}
