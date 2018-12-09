using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.lessons
{
    public class ThenBy_Reverse
    {
        public static void Main14(string[] args)
        {
            var students = Student.GetAllStudents().OrderBy(x => x.LastName).ThenBy(x => x.FirstName);

            // same like in sql
            var studentsSql = from student in Student.GetAllStudents()
                              orderby student.LastName, student.FirstName
                              select student;

            students.ToList().ForEach(x => Console.WriteLine(x.LastName + " " + x.FirstName));

            var studentsRev = Student.GetAllStudents().Reverse();
            
            // same like in sql
            var studentsRevSql = (from student in Student.GetAllStudents()
                select student).Reverse();

            Console.ReadKey();
        }
    }
}
