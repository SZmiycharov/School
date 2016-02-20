using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Group
    {
        private string name;
        private List<Student> students;

        public Group(string name)
        {
            this.name = name;
            this.students = new List<Student>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
        }
        public void AddStudent (Student student)
        {
            students.Add(student);
        }
        public void PrintStudents (System.IO.TextWriter output)
        {
            output.WriteLine("Group name: {0}", this.name);
            output.WriteLine("Students in group: ");
            foreach(Student student in this.students)
            {
                output.WriteLine("Name: {0}", student.Name);
            }
        }


    }
}
