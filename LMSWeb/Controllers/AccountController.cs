using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMSWeb.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            LMSBL.DBModels.TblUser model = new LMSBL.DBModels.TblUser();
            model = (LMSBL.DBModels.TblUser)Session["UserSession"];
            return View(model);
        }
    }
}