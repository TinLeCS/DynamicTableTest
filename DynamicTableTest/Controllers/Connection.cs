using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DynamicTableTest.Controllers
{
    public class Connection
    {
        public static SqlConnection GetConnection()
        {
            // Create a String to hold the database connection string.
            // NOTE: Put in a real database connection string here or runtime won't work

            string connectionString = @"Data Source = (LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DynamicTableContext.mdf;Initial Catalog=DynamicTableContext;Integrated Security=True";

            // Create a connection
            return new SqlConnection(connectionString);
        }
    }
}