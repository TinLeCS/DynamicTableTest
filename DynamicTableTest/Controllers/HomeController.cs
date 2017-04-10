using DynamicTableTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicTableTest.Controllers
{
    public class HomeController : Controller
    {
        private DynamicTableContext _ctx = new DynamicTableContext();

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

        public JsonResult GetStudents()
        {

            var students = _ctx.Students.ToList();


            return new CustomJsonResult()
            {
                Data = students,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        public JsonResult GetCourses()
        {

            var courses = _ctx.Courses.ToList();


            return new CustomJsonResult()
            {
                Data = courses,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}