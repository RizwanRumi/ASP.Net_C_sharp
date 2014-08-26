using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Antlr.Runtime.Tree;

namespace FirstMVCApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }
        public int Age { get; set; }


        public string Email { get; set; }

        public Student()
        {
            Name = "Faisal";
            PhoneNumber = "45542121";
        }
    }
}