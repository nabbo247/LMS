using System;
using System.Web.Mvc;
using LMSBL.Common;
using LMSBL.DBModels;
using LMSBL.Repository;

namespace LMSWeb.Controllers
{
    public class LoginController : Controller
    {
        UserRepository ur = new UserRepository();
        Exceptions newException = new Exceptions();
        // GET: Login
        public ActionResult Index()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        public ActionResult UserAuthentication(string UserName, string Password)
        {
            try
            {
                Response response = new Response();
                TblUser tblUser = ur.IsValidUser(UserName, Password);

                if (tblUser != null)
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
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        public ActionResult Logout()
        {
            try
            {
                Session.Remove("UserSession");
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }
    }
}