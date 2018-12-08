using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVCDEMO.Models;

namespace MVCDEMO.Controllers
{
    public class LoadCustomerController : Controller
    {
        // GET: LoadCustomer
        public ActionResult Index()
        {
            Customer objCustomer = new Customer();
            objCustomer.id = 1001;
            objCustomer.CustomerCode = "C001";
            objCustomer.Amount = 2000;

            return View(objCustomer);
        }
    }
}