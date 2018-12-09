using System;
using System.Collections.Generic;
//using System.Linq;
//using ConsoleApp2.Fundamentals;

namespace ConsoleApp2.Fundamentals
{
    public class PowerOfIEnumerable
    {
        public static void Main1(string[] args)
        {
            IEnumerable<Employee> arrayEmployees = new[] {
                new Employee{ Id = 1, Name = "Scott"},
                new Employee{ Id = 2, Name = "Chris"}
            };

            IEnumerable<Employee> listEmployees = new List<Employee>
            {
                new Employee{Id =1, Name = "Alex"}
            };

            int count = arrayEmployees.Count();

            Console.WriteLine(count);

            IEnumerator<Employee> enumerator = arrayEmployees.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current?.Name);
            }

        }
    }


    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
