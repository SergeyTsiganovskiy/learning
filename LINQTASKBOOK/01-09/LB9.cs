using System;
using System.Linq;

namespace LINQTASKBOOK
{
    public class LB9
    {
        public static void Main9(string[] args)
        {

            int[] arr = { 2, 3, 5, 5, 10};

            try
            {
                var q1 = arr.Where(x => x < 0).Min();
                Console.WriteLine(q1);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message + " 0");
            }
        }
    }
}
