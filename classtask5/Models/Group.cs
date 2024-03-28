using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtask5.Models
{
    internal class Group
    {
        public string Name;
        public Student[] Students;

        public Group(string name)
        {
             Name = name;
        }

        public void AddStudent(Student student) 
        {
            Array.Resize(ref Students, Students.Length+1);
            Students[Students.Length-1]=student;
        }

        public void ShowAllStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student.Name+" "+student.Surname);
            }
        }
    }
}
