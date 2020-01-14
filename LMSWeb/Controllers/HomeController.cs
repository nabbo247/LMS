using LMSBL.Common;
using System;
using System.Web.Mvc;

namespace LMSWeb.Controllers
{
    public class HomeController : Controller
    {
        Exceptions newException = new Exceptions();
        public ActionResult Index()
        {
            try
            {
               
                return View();
                
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
            }
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