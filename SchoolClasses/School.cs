using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class School
    {
        private string name;
        private List<Teacher> teachers;
        private List<Group> groups;
        private List<Student> students;

        public School(string name)
        {
            this.name = name;
            this.teachers = new List<Teacher>();
            this.groups = new List<Group>();
            this.students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
        }
        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public void AddGroup (Group group)
        {
            groups.Add(group);
            foreach(Student student in group.Students)
            {
                if(!this.students.Contains(student))
                {
                    this.students.Add(student);
                }
            }
        }

    }
}
