using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SudentEntryApp.Models
{
    public class StudentContext : ApplicationDbContext
    {
        DbSet<Student> aStudents { get; set; }  
    }
}