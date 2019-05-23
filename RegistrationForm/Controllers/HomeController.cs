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

            if (person.Coffee == "Cappucino")
            {
                person.Coffee = "There are 120 calories in 1 serving of Starbucks Cappuccino (Grande). \nCalorie breakdown: 31% fat\n 41% carbs 28% protein.";
            }
            if (person.Coffee == "Mocha")
            {
                person.Coffee = "There are 290 calories in 1 serving  of Starbucks Caffe Mocha w/ Whole Milk & Whipped Cream 1 tall. ";
            }
            if (person.Coffee == "Caffe Latte")
            {
                person.Coffee = "There are 190 calories in 1 serving of Starbucks Caffe Latte. ";
            }
            return View(person);

        }

        public ActionResult PersonView(Person person)
        {
            ViewBag.UserName = person.UserName;
            ViewBag.Email = person.Email;
            ViewBag.Password = person.Password;
            ViewBag.Phone = person.Phone;
            ViewBag.Gender = person.Gender;
            ViewBag.Coffee = person.Coffee;

            return View();
        }
    }
}