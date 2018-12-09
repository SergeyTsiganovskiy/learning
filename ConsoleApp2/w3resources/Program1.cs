using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class Program1
    {
        public static void Main20()
        {
            int[] array1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var nQuery1 =
                from vrNum in array1
                where vrNum % 2 == 0
                select vrNum;

            nQuery1.ToList().ForEach(x => Console.Write(x + " "));

            int[] array2 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var nQuery2 =
                from vrNum in array2
                where vrNum > 0
                where vrNum < 12
                select vrNum;

            nQuery2.ToList().ForEach(x => Console.Write(x + " "));

            var array3 = new[] { 3, 9, 2, 8, 6, 5 };

            var sqNo = from int number in array3
                       let sqrt = number * number
                       where sqrt > 20
                       select new { number, sqrt };

            sqNo.ToList().ForEach(x => Console.Write(x + " "));

            int[] array4 = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            Console.Write("\nLINQ : Display the number and frequency of number from given array : \n");
            Console.Write("The numbers in the array  are : \n");
            Console.Write(" 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2\n");

            var meetingFrequency = from x in array4
                                   group x by x into y
                                   select y;

            Console.WriteLine("\nThe number and the Frequency are : \n");
            meetingFrequency.ToList().ForEach(x => Console.WriteLine("Number " + x.Key + " appears " + x.Count() + " times"));



            Console.ReadKey();
        }
    }
}
