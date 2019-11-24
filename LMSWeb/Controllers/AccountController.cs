using System;
using System.Web.Mvc;
using LMSBL.Common;

namespace LMSWeb.Controllers
{
    public class AccountController : Controller
    {
        Exceptions newException = new Exceptions();
        // GET: Account
        public ActionResult Index()
        {
            try
            {
                LMSBL.DBModels.TblUser model = new LMSBL.DBModels.TblUser();
                model = (LMSBL.DBModels.TblUser)Session["UserSession"];
                return View(model);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }
    }
}