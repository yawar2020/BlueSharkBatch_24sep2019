using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutsInMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUS()
        {
            return View();
        }

        public ActionResult HtmlHelperExample() {
            return View();
        }

        public ActionResult ValidationMvc() {

            return View();
        }
        
    }
}