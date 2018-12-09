using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.lessons
{
    public class OrderBy
    {
        public static void Main13(string[] args)
        {
            var students = Student.GetAllStudents().OrderBy(x => x.LastName);
            var studentsDesc = Student.GetAllStudents().OrderByDescending(x => x.LastName);

            // like in sql
            var students3 = from student in Student.GetAllStudents()
                orderby student.LastName descending 
                select student;

            students.ToList().ForEach(x => Console.WriteLine(x.LastName + " " + x.FirstName));

            Console.ReadKey();
        }
    }
}
