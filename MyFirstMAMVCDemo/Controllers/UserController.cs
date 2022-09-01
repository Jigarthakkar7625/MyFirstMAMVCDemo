using MyFirstMAMVCDemo.Auth;
using MyFirstMAMVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMAMVCDemo.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [AuthenticationAttr]
        public ActionResult Index()
        {
            List<UserModels> um = new List<UserModels> {
                new UserModels { UserId = 1, UserName = "jigar" },
                new UserModels { UserId = 2, UserName = "jigar123" }
            };

            ViewData["Message"] = "jigar";
            ViewBag.Items = um;
            TempData["name"] = "Bill";
            return View(um);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            List<EmpModels> um = new List<EmpModels> {
                new EmpModels { EmpId = 1, EmpName = "jigar" },
                new EmpModels { EmpId = 2, EmpName = "jigar123" }
            };


            ViewBag.List = um;
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(UserModels models)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
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

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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

        public ActionResult RenderPartial()
        {
            try
            {
                List<EmpModels> um = new List<EmpModels> {
                new EmpModels { EmpId = 1, EmpName = "jigar" },
                new EmpModels { EmpId = 2, EmpName = "jigar123" }
            };
                // TODO: Add delete logic here

                return PartialView("PartialViewDemo");
            }
            catch
            {
                return View();
            }
        }
    }
}
