using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.MyFilter;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
     
    [HFilter]
        public ActionResult Index()
        {
            ViewBag.Captain = "Mahendra Singh Dhoni";
            return View();
        }

        public ActionResult GetDataFromService()
        {
            ServiceReference1.AddWcfServiceClient obj = new ServiceReference1.AddWcfServiceClient();
            ViewBag.Add=obj.Add(12, 35);
            var data=obj.GetData().ToList();
            return View();
        }
    }
}