using LMSBL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LMSBL.DBModels;
using LMSBL.Common;

namespace LMSWeb.Controllers
{
    public class LoginController : Controller
    {
        UserRepository ur = new UserRepository();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserAuthentication(string UserName, string Password)
        {
            Response response = new Response();
            TblUser tblUser = ur.IsValidUser(UserName, Password);
            
            if (tblUser!=null)
            {
                response.StatusCode = 1;
                //set User object to session
                Session["UserSession"] = tblUser; //use in layout.cshtml to hide show menus.
            }
            else
            {
                response.StatusCode = 0;
            }
            
            return Json(response.StatusCode, JsonRequestBehavior.AllowGet);
        }
    }
}