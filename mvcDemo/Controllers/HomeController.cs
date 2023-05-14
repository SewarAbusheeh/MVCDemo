using mvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcDemo.Controllers
{
    public class HomeController : Controller
    {
        //private readonly Data data;
        //public HomeController (Data _data)
        //{
        //    _data = data;
        //}
        private Data db = new Data();
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
        public FileResult Index3()
        {
           

            return File(Server.MapPath("~/Content/Resume Sewar AbuSheeh (4).pdf") ,"txt/pdf" ,"CV.PDF");  // I want to make a link to make Download ,~ :Root to project and here is a Content
                                                                                  // Resume Sewar AbuSheeh (4).pdfResume Sewar AbuSheeh (4).pdf :When you publish it will change from C or D
        }
        public JsonResult Index4()
        {
            List<Models.Student> list = new List<Models.Student> 
            {
                new Models.Student() {ID =1 ,Name="ahmad"}
            };

            return Json (list, JsonRequestBehavior.AllowGet);
                                                                                                       
        }
        public ActionResult Search(string NameToSearch)
        {
            var res = db.Users.Where(a => a.UserName == NameToSearch);
          //  ViewBag.err = "sewar is no longer av ";
            return View( res);

        }
        public  PartialViewResult SearchP(string NameToSearch)
        {
            var res = db.Users.Where(a => a.UserName.StartsWith(NameToSearch));
            //  ViewBag.err = "sewar is no longer av ";
            return  PartialView("_SearchP",res);

        }
    }
}