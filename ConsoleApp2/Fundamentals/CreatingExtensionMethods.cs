using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Fundamentals
{
    public class CreatingExtensionMethods
    {
        public static void Main2(string[] args)
        {
            IEnumerable<Employee> arrayEmployees = new[] {
                new Employee{ Id = 1, Name = "Scott"},
                new Employee{ Id = 2, Name = "Chris"}
            };

            Console.WriteLine(arrayEmployees.Count());

            // NAMED METHOD APPROACH

            foreach (var emploee in arrayEmployees.Where(GetNames))
            {
                   
            }


            // AN ANONYMOUS METHOD

            foreach (var emploee in arrayEmployees.Where(
                delegate (Employee emploee) { return emploee.Name.StartsWith("S"); }))
            {

            }

            // LAMBDA 

            foreach (var emploee in arrayEmployees.Where(e => e.Name.StartsWith("S")))
            {

            }
        }

        private static bool GetNames(Employee emp)
        {
            return emp.Name.StartsWith("S");
        }

    }
}
