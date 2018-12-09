using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program4
    {
        static void Main4(string[] args)
        {
            string[] arr1;
            int n, i;

            Console.Write("\nLINQ : Convert a string array to a string : ");
            Console.Write("\n------------------------------------------\n");
            Console.Write("Input number of strings to  store in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            arr1 = new string[n];
            Console.Write("Input {0} strings for the array  :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Element[{0}] : ", i);
                arr1[i] = Console.ReadLine();
            }

            var newstring = string.Join(", ", arr1);

            Console.Write("\nHere is the string below created with elements of the above array  :\n\n");
            Console.WriteLine(newstring);
            Console.Write("\n");
            Console.ReadLine();
        }
    }
}
