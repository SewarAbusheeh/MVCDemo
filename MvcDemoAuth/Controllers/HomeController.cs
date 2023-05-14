using MvcDemoAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemoAuth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Students()
        {

            List<Student> students = new List<Student>()
            {
            new Student()
            {
                ID=1 ,StudentName="Ahmad" ,age="32"
            },
            new Student()
             {
                ID=2 ,StudentName="Omer" ,age="32"
            },
            new Student()
            {
                ID=1 ,StudentName="salma" ,age="32"
            },

            };
            return View(students);
           // return Json(students, JsonRequestBehavior.AllowGet);// i id not make a view for json 
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
    }
}