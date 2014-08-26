using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorldInMVC.Models;

namespace HelloWorldInMVC.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/
        public string Greetings(string name, string address)
        {
            return "Hello" + name;
        }

        public ActionResult SayHello()
        {
            return View();
        }

        public ActionResult MyDataPassing()
        {
            return View();
        }
        public ActionResult DataPassing(Person aPerson)
        {
         //   ViewBag.Person = aPerson;

            //ViewBag.PersonName = name;
            //ViewBag.PersonAge = age;
            //ViewBag.Email = email;


            List<Person> persons = new List<Person>();

            Person p1 = new Person();
            p1.Name = "Sumi";

            Person p2 = new Person();
            p2.Name = "Sumi";


            persons.Add(p1);
            persons.Add(p2);

            return View(persons);
        }



        public string CreatePerson(Person aPerson)
        {
            return aPerson.Name + " " + aPerson.Email;
        }

        //public string CreatePerson()
        //{
        //    return "Nothing";
        //}



        public string FindCities(int noOfCities =10)
        {
            //int? i = null;
            return "No.....";
        }
    }
}