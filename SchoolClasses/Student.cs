using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Student
    {
        private string FirstName;
        private string LastName;

        public Student(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        public string Name
        {
            get
            {
                return this.FirstName + " " + this.LastName;    
            }
        }
    }
}
