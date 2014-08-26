using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntryWithDatabaseApp
{
    class Department
    {
        private string code = "";
        private string deptName = "";
       
        private Dictionary<string, Student> aDictionary;

        private const int MAX_NO_OF_STUDENTS = 15;

        private Student studentObj = new Student();


        public string Code
        {
            get { return code; }

        }

        public string DeptName
        {
            get { return deptName; }

        }

        public Department(string code, string deptName)
            : this()
        {
            this.code = code;
            this.deptName = deptName;
        }

        public Department()
        {
         
            aDictionary = new Dictionary<string, Student>();
        }

       
        public string Addstudent(Student StudentObj)
        {
            if (aDictionary.Count < 15)
            {
                
                try
                {
                    string reg = StudentObj.RegNo;
                    aDictionary.Add(reg, StudentObj);
                    return "Successfully regestered";
                }
                catch (ArgumentException exception)
                {
                    return "Already Exists";
                    
                }

            }
            else
            {
                return "Maximum no of students (" + MAX_NO_OF_STUDENTS + ") has been saved. So, provided student information is not saved.";

            }
        }

        public Dictionary<string, Student> GetStudentList()
        {
            return aDictionary;
        }
    }
}
