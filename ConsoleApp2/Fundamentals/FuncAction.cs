using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Fundamentals
{
    public class FuncAction
    {
        public static void Main3(string[] args)
        {
            IEnumerable<Employee> arrayEmployees = new[] {
                new Employee{ Id = 1, Name = "Scott"},
                new Employee{ Id = 2, Name = "Chris"}
            };

            Func<int, int> f = x => x * x;

            Func<int, int> f1 = delegate (int i) { return i * i; };

            Func<int, int, int> f3 = (x, y) =>
            {
                int temp = x + y;
                return temp;
            };


            Console.WriteLine(f1(3));
            Console.WriteLine(f(3));

            Action<int> f4 = x => Console.WriteLine(x);
        }
    }
}
