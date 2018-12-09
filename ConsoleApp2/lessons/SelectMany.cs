using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.lessons
{
    public class SelectMany
    {
        public static void Main12(string[] args)
        {
            //Take from all objects Course property into one Enumerable and delete copies
              IEnumerable<string> names = Student.GetAllStudents().SelectMany(s => s.Courses).Distinct();

           // names.ToList().ForEach(Console.WriteLine);

            
            //the same with SQL like syntacsis
            IEnumerable<string> namesSQL = (from student in Student.GetAllStudents()
                                            from course in student.Courses
                                            select course).Distinct();

            //namesSQL.ToList().ForEach(Console.WriteLine);

            var anumous = Student.GetAllStudents().SelectMany(s => s.Courses, (s, course) =>
                new {Name = s.FirstName + " " + s.LastName, Course = course});

            var anumousSql = from student in Student.GetAllStudents()
                from courses in student.Courses
                select new {Name = student.FirstName + " " + student.LastName, Course = courses};

            //anumous.ToList().ForEach(x => Console.WriteLine(x.Name + "\t" + x.Course));
            anumousSql.ToList().ForEach(x => Console.WriteLine(x.Name + "\t" + x.Course));

            Console.ReadKey();
        }
    }
     
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public ICollection<string> Courses { get; set;}

        public static IEnumerable<Student> GetAllStudents()
        {
            List<Student> result = new List<Student>
            {
                new Student
                {
                    FirstName = "AAAAA1",
                    LastName = "BBBBB1",
                    Courses = new Collection<string> {"Course11", "Course12", "Course13", "Course14"},
                    Gender = "DDDDD1"
                },

                new Student
                {
                    FirstName = "AAAAA2",
                    LastName = "BBBBB2",
                    Courses = new Collection<string> {"Course21", "Course22", "Course23", "Course24"},
                    Gender = "DDDDD2"
                },
                new Student
                {
                    FirstName = "AAAAA3", 
                    LastName = "BBBBB3",
                    Courses = new Collection<string> {"Course31", "Course32", "Course33", "Course34"},
                    Gender = "DDDDD3"
                },
                new Student
                {
                    FirstName = "AAAAA4",
                    LastName = "BBBBB4",
                    Courses = new Collection<string> {"Course41", "Course42", "Course43", "Course44"},
                    Gender = "DDDDD4"
                }
            };
            return result;
        }

    }
}
