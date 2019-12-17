using SalesOrdersProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesOrdersProject.Controllers
{
    public class RegisterController : Controller
    {
        private SalesOrdersDatabase2Entities db = new SalesOrdersDatabase2Entities();
        
        // GET: Register
        public ActionResult Index()
        {
            return View(new Customer());
        }

        [HttpPost]
        public RedirectToRouteResult Register(Customer customer)
        {
            
            db.Customers.Add(customer);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}