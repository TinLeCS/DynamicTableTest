using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicTableTest.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int PublishYear { get; set; }
    }
}