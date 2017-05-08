using FirstAzzureWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstAzzureWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /*
            List<Customers> CustomerData = DataAccess.DataAccessController.GetCustomerData();
            System.Diagnostics.Debug.WriteLine("CustomerData Gained");

            ViewData["CustomerName"] = CustomerData.ElementAt(0).FirstName + " " + CustomerData.ElementAt(0).LastName;
            ViewData["CustomerPhone"] = CustomerData.ElementAt(0).phoneNumber;
            ViewData["CustomerEmail"] = CustomerData.ElementAt(0).email;
            */
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
    }
}