using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using FastFoodResaurantMVC.Models;

namespace FastFoodResaurantMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();

        }

       

     

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Appointment()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();

        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(RegisterTbl tblUser)
        {
            using (FastFoodDBEntities db = new FastFoodDBEntities())
            {
                if (ModelState.IsValid)
                {
                    db.RegisterTbls.Add(tblUser);
                    db.SaveChanges();
                    //  ViewBag.message("Register Sucess");
                    ModelState.Clear();
                }
            }
            return View();
        }

        [HttpPost]

        public ActionResult Login(RegisterTbl tblUser)
        {
            using (FastFoodDBEntities db = new FastFoodDBEntities())
            {
                if (ModelState.IsValid)
                {
                    var log = db.RegisterTbls.Where(a => a.userName.Equals(tblUser.userName) && a.password.Equals(tblUser.password)).FirstOrDefault();
                    if (log != null)
                    {
                        return RedirectToAction("Booking");
                    }
                    db.SaveChanges();
                    // ViewBag.message("Login Sucess");
                    ModelState.Clear();
                }
            }
            return View();
        }
    }
}