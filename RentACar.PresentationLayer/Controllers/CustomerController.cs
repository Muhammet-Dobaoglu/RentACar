
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar.PresentationLayer.Controllers
{
    public class CustomerController : Controller
    {

        public ActionResult Index()
        {
            var values = customerManager.TGetList();
            return View(values);
        }


    }
}