using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class Aggregation
    {
        public static void Main10()
        {
            IList<int> numbers = new List<int> {1, 2, 10, -1000, 0, 345};
            var res = numbers.Count(x => x > 0);

            IList<string> countries = new List<string> { "RUS" , "UA", "USA", "GEM" };

            Console.WriteLine(countries.Aggregate((a,b) => a + " ," + b));
            Console.ReadKey();
        }
    }
}
