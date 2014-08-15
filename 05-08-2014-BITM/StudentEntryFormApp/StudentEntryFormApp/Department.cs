using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntryFormApp
{
    class Department
    {
        private string code = "";
        private string deptName = "";
      //  private List<Student> studentList;
        private Dictionary<string, Student> aDictionary; 

        private const    int MAX_NO_OF_STUDENTS = 15;

        private Student studentObj = new Student();


        public string Code
        {
            get { return code; }

        }

        public string DeptName
        {
            get { return deptName; }

        }

        public Department(string code, string deptName) : this()
        {
            this.code = code;
            this.deptName = deptName;
        }

        public Department()
        {
           // studentList = new List<Student>();
            aDictionary = new Dictionary<string, Student>();
        }

        //public string Addstudent(Student aNewStudent)
        //{
        //    if (studentList.Count < 15)
        //    {
        //        foreach (Student aStudentReg in studentList)
        //        {
        //            if (aStudentReg.RegNo == aNewStudent.RegNo)
        //            {
        //                return "already regestered";
        //            }
                    
        //        }

        //        studentList.Add(aNewStudent);
        //        return "Successfully regestered";


        //    }
        //    else
        //    {
        //        return "Maximum no of students (" + MAX_NO_OF_STUDENTS + ") has been saved. So, provided student information is not saved.";

        //    }
        //}

        //public List<Student> GetStudentList()
        //{
        //    return studentList;
        //}

        public string Addstudent(Student StudentObj)
        {
            if (aDictionary.Count < 15)
            {
                //string reg = StudentObj.RegNo;
                //if (aDictionary.ContainsKey(reg))
                //{
                //    return "already exists";
                //}
                //aDictionary.Add(reg, StudentObj);
                //return "Successfully regestered";
                try
                {
                   string reg = StudentObj.RegNo;
                   aDictionary.Add(reg, StudentObj);
                   return "Successfully regestered";
                }
                catch (ArgumentException exception)
                {
                    return "Already Exists";
                    //throw new Exception("Already Exist");
                }

            }
            else
            {
                return "Maximum no of students (" + MAX_NO_OF_STUDENTS + ") has been saved. So, provided student information is not saved.";

            }
        }

        public Dictionary<string,Student> GetStudentList()
        {
            return aDictionary;
        }
    }
}
