using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMAMVCDemo.Controllers
{
    public class LoginController : Controller
    {
        MyTestDBEntities1 myTestDBEntities = new MyTestDBEntities1();
        // GET: Login
        public ActionResult Index()
        {

            //Query Syntax

            //var a = from s in myTestDBEntities.tblStudents //Database
            //        orderby s.StudentName1 ascending
            //        select s; // Select

            //foreach (var item in a)
            //{
            //    var abc = "";
            //    abc += item.StudentName1;
            //}

            var b = myTestDBEntities.tblStudents.Where(x => x.StudentName1 == "jigar").Count(); // Method


            //var orderBy = myTestDBEntities.tblStudents.OrderByDescending(x => x.StudentName1).ThenByDescending(x => x.Course).ToList(); // Method

            var GroupBy = myTestDBEntities.tblStudents.GroupBy(x => x.StudentName1).Select(cl => new
            {
                ProductName = cl.Select(x => x.StudentID).FirstOrDefault(),
                //Quantity = cl.Count().ToString(),
                Sum = cl.Sum(c => c.Salary).ToString(),
            }).ToList();


            // Joins

            var a = (from s in myTestDBEntities.tblStudents
                     join s1 in myTestDBEntities.tblCourses
                     on s.StudentID equals s1.StudentID
                     select new
                     {
                         manthan = s.StudentName1,
                         abhisek = s1.CourseName
                     }).ToList();

            // All, Any and contain // true che ke false

            var temp = myTestDBEntities.tblStudents.All(x => x.StudentID > 33); // if all record

            var tempAny = myTestDBEntities.tblStudents.Any(x => x.StudentID > 100); // true
            //var temp = myTestDBEntities.tblStudents.All(x => x.StudentID > 10);


            int[] abv = { 1, 5, 3 };

            //tblStudent tblStudent = new tblStudent(14   Abhi    2022 - 08 - 11 00:29:22.947 1   1.NET    100);

            //var abcc = myTestDBEntities.tblStudents.Contains(tblStudent);

            //ag
            //sum
            //avg
            //max
            // min
            // count
            //aggregate

            //var abcc = myTestDBEntities.tblStudents.Sum(x => x.Salary);
            //var abcc1 = myTestDBEntities.tblStudents.Average(x => x.Salary);
            //var abcc2 = myTestDBEntities.tblStudents.Max(x => x.Salary);
            //var abcc3 = myTestDBEntities.tblStudents.Min(x => x.Salary);
            //var abcc4 = myTestDBEntities.tblStudents.Count();

            //int[] abv232 = { 1, 5, 3 };
            //var aggr = abv232.Aggregate((n1, n2) => n1 * n2);

            int[] abvAny123 = { 1, 5, 3 };

            //var adfdsf = abvAny123.ElementAt(9);


            //tblStudent tblStudent = new tblStudent { 

            //};
            //var abbbb = myTestDBEntities.tblStudents.Last();
            //var ab = myTestDBEntities.tblCourses.LastOrDefault();

            //int[] vs = { 1, 5, 3,5,6,7,8 };

            //var agfgdgd = vs.SingleOrDefault(x => x > 8);
            int[] vs = { 1, 5, 3, 10 };
            int[] vsAny123 = { 5, 6, 7, 8 };


            var except = vs.Union(vsAny123).ToList();


            bool abcccc = vs.SequenceEqual(abv); // true or false

            // partition operator

            //Skip
            int[] vsAny123dfdfdsf = { 5, 6, 7, 8, 10, 5, 6, 5, 8, 4444, 5554 };

            var ddsads = vsAny123dfdfdsf.Skip(2).ToList();

            //int[] vsAny123dfdfdsf = { 5, 6, 7, 8, 10, 5, 6, 5, 8, 4444, 5554 };

            string[] vsAny123dfdfdsfdsada = { "jiar", "manth", ".net", "abhi" };

            var fdsfsf = vsAny123dfdfdsfdsada.SkipWhile(x => x.Length < 5).ToList();


            int[] vsAny123dfdfddsadadsf = { 5, 6, 4, 8, 10, 5, 6, 5, 8, 4444, 5554 };

            var fdfdfsds = vsAny123dfdfddsadadsf.TakeWhile(x => x < 6).ToList();


            //var C3 = vs.Concat(vsAny123).ToList();

            var cco = Enumerable.Repeat(15, 100);

            var ab = myTestDBEntities.tblCourses.Distinct();

            //except




            var tempfdfsds = "";
            foreach (var item in cco)
            {
                tempfdfsds += item;
            }

            // Distinct

            int[] abc = { 1, 5, 3, 5 };

            var abcAny = abc.Distinct().ToList();







            //var abc = myTestDBEntities.tbl.First();
            //var abc11 = myTestDBEntities.tblStudents.FirstOrDefault();


            //var adfdsf2 = abvAny123.ElementAtOrDefault(9);


            //var abcc = from s in myTestDBEntities.tblStudents
            //        join s1 in myTestDBEntities.tblCourses
            //        on s.StudentID equals s1.StudentID
            //        select new 
            //        {
            //    StudentID = s.StudentID,
            //            ahisek = s1.CourseName
            //        };




            return View();

        }
    }
}