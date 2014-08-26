using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldInMVC.Controllers
{
    public class StudentController : Controller
    {
        public string Info()
        {
            return "Hello world in ASP.Net MVC";
        }
	}
}