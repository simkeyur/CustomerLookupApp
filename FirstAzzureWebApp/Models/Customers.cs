using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstAzzureWebApp.Models
{
    public class Customers
    {
        public int customerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
    }
}