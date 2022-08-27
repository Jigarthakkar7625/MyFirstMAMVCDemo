using MyFirstMAMVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMAMVCDemo.Controllers
{
    public class EmployeeController : Controller
    {

        MyTestDBEntities myTestDBEntities = new MyTestDBEntities();
        // GET: Employee
        /// <summary>
        /// Employee/Index
        /// </summary>
        /// <returns></returns>
        //[ActionName("jigar")]

        public ActionResult Index()
        {

            List<tblStudent> tblStudents = myTestDBEntities.tblStudents.ToList();

            tblStudent tblStudents1 = new tblStudent();
            tblStudents1.StudentName1 = "dsdsad";
            tblStudents1.StudentDOB = DateTime.Now;
            tblStudents1.Gender = 1;
            tblStudents1.IsPass = true;
            tblStudents1.Course = "asp.nettt";
            tblStudents1.Salary = 1250;
            myTestDBEntities.tblStudents.Add(tblStudents1);
            myTestDBEntities.SaveChanges();

            //List<EmployeeModels> employees = new List<EmployeeModels> {
            //    new EmployeeModels { Id = 10, Name = "Jigar" },
            //    new EmployeeModels { Id = 11, Name = "Manthan" }
            //};
            return View();
            //return View(employees);
            //return RedirectToRoute("","");
            //return RedirectToAction("Details", "Employee");
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            EmployeeModels employee = new EmployeeModels();
            //employee.Name = "Manthan";
            return View(employee);
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(EmployeeModels employee)
        {
            try
            {
                //dATABASE MA INSERT
                // sTOREprocedure

                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            //Get record from database based on this iD
            //
            EmployeeModels employee = new EmployeeModels();
            //employee.Name = "Manthan";
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
