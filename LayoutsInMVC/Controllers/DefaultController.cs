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
            //ViewData["Subject"] = "English";
            //ViewBag.Subject = "Hindi";
            TempData["Subject"] = "Sanskrit";
            return RedirectToAction("ValidationMvc");
        }

        public ActionResult ValidationMvc() {
            //string data = Convert.ToString(ViewData["Subject"]); 
            // string Data = ViewBag.Subject;
            //string Data = TempData["Subject"].ToString();
            //TempData.Keep();
            string Data = TempData.Peek("Subject").ToString();
            return View();
        }
        
    }
}