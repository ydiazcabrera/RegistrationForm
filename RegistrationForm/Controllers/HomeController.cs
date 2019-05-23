using RegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Registration()
        {
                                        
            return View();
        }
        public ActionResult Result(Person person)
        {
            ViewBag.UserName = person.UserName;
            ViewBag.Email = person.Email;
            ViewBag.Password = person.Password;
            ViewBag.Phone = person.Phone;
            ViewBag.Gender = person.Gender;
            ViewBag.Coffee = person.Coffee;
            
            return View(person);
           
        }
    }
}