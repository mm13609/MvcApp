using MvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult DisplayCustomer()
        {
            Customer customer = new Customer();
            customer.Amount = (decimal)1000;
            customer.CustomerId = 1;
            customer.CustomerName = "Mustafa";
            return View("CustomerView", customer);
        }
    }
}