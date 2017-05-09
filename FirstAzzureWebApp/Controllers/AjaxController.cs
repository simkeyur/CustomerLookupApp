using FirstAzzureWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstAzzureWebApp.Controllers
{
    public class AjaxController : Controller
    {
        [HttpPost]
        public JsonResult getCustomerByPhone(string phoneNumber)
        {

            List<Customers> CustomerData = DataAccess.DataAccessController.GetCustomerData(phoneNumber);
            System.Diagnostics.Debug.WriteLine("CustomerData Gained with length " + CustomerData.Count);
            if (CustomerData.Count > 0)
            {
                Customers customer = new Customers
                {
                    FirstName = CustomerData.ElementAt(0).FirstName,
                    LastName = CustomerData.ElementAt(0).LastName,
                    phoneNumber = CustomerData.ElementAt(0).phoneNumber,
                    email = CustomerData.ElementAt(0).email
                    
                };
                return Json(customer, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("NA", JsonRequestBehavior.AllowGet);
            }
            
        }
    }
}