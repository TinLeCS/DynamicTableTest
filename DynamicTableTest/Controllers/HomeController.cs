using DynamicTableTest.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicTableTest.Controllers
{
    public class HomeController : Controller
    {
        private DynamicTableContext _ctx = new DynamicTableContext();
        private SqlConnection _dbConnection = Connection.GetConnection();

        public ActionResult Index()
        {
            PopulateTablessDropDownList();
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

        public JsonResult GetResult(string query)
        {
            // Open the connection
            _dbConnection.Open();

            // Create a SqlCommand object and pass the constructor the connection string and the query string.
            SqlCommand queryCommand = new SqlCommand(query, _dbConnection);

            // Use the above SqlCommand object to create a SqlDataReader object.
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();

            // Create a DataTable object to hold all the data returned by the query.
            DataTable dataTable = new DataTable();

            // Use the DataTable.Load(SqlDataReader) function to put the results of the query into a DataTable.
            dataTable.Load(queryCommandReader);

            return new CustomJsonResult()
            {
                Data = dataTable,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        private void PopulateTablessDropDownList(int? selectedTable = 1)
        {
            Dictionary<string, string> tables = new Dictionary<string, string>();

            // Open the connection
            _dbConnection.Open();
            
            var datatable = _dbConnection.GetSchema("Tables");
            foreach (DataRow row in datatable.Rows)
            {
                string tablename = (string)row[2];
                tables.Add($"Get{tablename}s",tablename);
            }
            tables.Remove(tables.Keys.Last());

            ViewBag.Table = new SelectList(tables, "Key", "Value");

        }

    }
}