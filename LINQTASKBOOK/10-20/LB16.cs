using System;
using System.Linq;

namespace LINQTASKBOOK
{
    public class LB16

    {
        public static void Main16(string[] args)
        {
            int[] arr = {1, 3, - 2, 0, -3};

            var query = arr.Where(x => x > 0);

            Console.WriteLine("Result: ");
            query.ToList().ForEach(Console.WriteLine);
        }
    }
}
