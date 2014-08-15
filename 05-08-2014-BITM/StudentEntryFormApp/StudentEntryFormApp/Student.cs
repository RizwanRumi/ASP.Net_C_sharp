using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntryFormApp
{
    class Student
    {
        private string regNo = "";
        private string name = "";
        private string email = "";

        public string RegNo
        {
            get { return regNo; }
        }

        public string Name
        {
            get { return name; }

        }

        public string Email
        {
            get { return email; }
        }

        public Student(string regNo, string name, string email)
            : this()
        {
            this.name = name;
            this.regNo = regNo;
            this.email = email;
        }

        public Student()
        {

        }
    }
}
