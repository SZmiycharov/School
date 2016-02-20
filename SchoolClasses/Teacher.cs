using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Teacher
    {
        private string firstname;
        private string lastname;
        private List<Group> groups;

        public Teacher(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.groups = new List<Group>();
        }
        public void AddGroup(Group group)
        {
            this.groups.Add(group);
        }
        public void PrintGroups (System.IO.TextWriter output)
        {
            output.WriteLine("Teacher name: {0} {1}", this.firstname, this.lastname);
            output.WriteLine("Groups of teacher: ");
            foreach(Group group in groups)
            {
                group.PrintStudents(output);
            }
        }

    }
}
