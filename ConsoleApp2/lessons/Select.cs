using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.lessons
{
    public class Select
    {
        public static void Main11(string[] args)
        {
            IList<int> numbers = new List<int> { 1, 2, 10, -1000, 0, 345 };

            Console.WriteLine("Position\tValue");
            foreach (var number in numbers.Select((x, idx) => new { Number = x, Index = idx }).Where(x => x.Number % 2 == 0))
            {
                Console.WriteLine(number.Index.ToString() + "\t\t" + number.Number.ToString());
            }
            Console.WriteLine();
            Console.ReadKey();

            const string Chars = "0123456789";
            Random random = new Random();

            Console.WriteLine(new string(Enumerable.Repeat(Chars, 5).Select(s => s[random.Next(s.Length)]).ToArray()));
            Console.ReadKey();
        }
    }
}
