using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class InitialLinq
    {
        static void Main9(string[] args)
        {
            TestSet set = new TestSet();

            var filteredSet1 = set.Where(s => s > 50);
            var filteredSet2 = set.Select(s => "'" + s.ToString() + "'");

            var res1 = set.First(s => s % 2 == 0);  // if to one -> Exception
            var res2 = set.Single(s => s % 2 == 0); // if more than one -> Exception
            var res3 = set.Aggregate(0, (accum, i ) => accum + i);

            var res4 = set.Select(i => new {Number = i, IsEven = i % 2 > 0}).OrderBy(r => r.IsEven);

        }
    }

    public class TestSet : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 100; i++)
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
