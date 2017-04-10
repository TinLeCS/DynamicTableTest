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

        public JsonResult GetBooks()
        {
            var books = new List<Book>();
            books.Add(
                new Book
                {
                    Id = 1,
                    Author = "Author 1",
                    Price = 9.99,
                    PublishYear = 2015,
                    Title = "First Book"
                }
            );
            books.Add(
                new Book
                {
                    Id = 2,
                    Author = "Author 2",
                    Price = 19.99,
                    PublishYear = 2011,
                    Title = "Second Book"
                }
            );


            return new JsonResult()
            {
                Data = books,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}