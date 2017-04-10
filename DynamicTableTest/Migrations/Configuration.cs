namespace DynamicTableTest.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DynamicTableTest.Models.DynamicTableContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DynamicTableTest.Models.DynamicTableContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.

            var students = new List<Student>
            {
                new Student { FirstName = "Tin",   LastName = "Le",
                    EnrollmentDate = DateTime.Parse("2017-04-10") },
                new Student { FirstName = "Gray", LastName = "Fullbuster",
                    EnrollmentDate = DateTime.Parse("2016-12-10") },
                new Student { FirstName = "Attack",   LastName = "Titan",
                    EnrollmentDate = DateTime.Parse("2017-04-01") },
                new Student { FirstName = "Lambo",    LastName = "San",
                    EnrollmentDate = DateTime.Parse("2015-09-02") },
                new Student { FirstName = "Dragon",      LastName = "Quest",
                    EnrollmentDate = DateTime.Parse("2017-04-09") },
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            //    var courses = new List<Course>
            //    {
            //        new Course{CourseId=1050,Title="Chemistry",Credits=3,},
            //        new Course{CourseId=4022,Title="Microeconomics",Credits=3,},
            //        new Course{CourseId=4041,Title="Macroeconomics",Credits=3,},
            //        new Course{CourseId=1045,Title="Calculus",Credits=4,},
            //        new Course{CourseId=3141,Title="Trigonometry",Credits=4,},
            //        new Course{CourseId=2021,Title="Composition",Credits=3,},
            //        new Course{CourseId=2042,Title="Literature",Credits=4,}
            //    };
            //    courses.ForEach(s => context.Courses.Add(s));
            //    context.SaveChanges();
            //}
        }
    }
}
