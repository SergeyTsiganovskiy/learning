using System;
using System.Linq;

namespace LINQTASKBOOK
{
    public class LB7
    {
        public static void Main7(string[] args)
        {

            int[] arr = {2, 3, -5, -5, -10, 0, 8};

            var quantity = arr.Count(x => x < 0);
            var sum1 = arr.Where(x => x < 0).Sum();


        }
    }
}
