using System;
using System.Collections.Generic;
using System.Web.Mvc;
using LMSBL.Common;
using LMSBL.DBModels;
using LMSBL.Repository;

namespace LMSWeb.Controllers
{
    public class LoginController : Controller
    {
        TenantRepository tr = new TenantRepository();
        UserRepository ur = new UserRepository();
        Exceptions newException = new Exceptions();
        // GET: Login
        public ActionResult Index()
        {
            TblUser user = new TblUser();
            var subDomain = Request.Url;
            List<TblTenant> tenantDetails = new List<TblTenant>();
            //tenantDetails = tr.GetTenantById(subDomain);
            try
            {
                return View(user);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View(user);
            }
        }

        public ActionResult UserAuthentication(TblUser loginUser)
        {
            Response response = new Response();
            try
            {                
                TblUser tblUser = ur.IsValidUser(loginUser.EmailId, loginUser.Password);

                if (tblUser != null)
                {
                    response.StatusCode = 1;
                    //set User object to session
                    Session["UserSession"] = tblUser; //use in layout.cshtml to hide show menus.
                    return RedirectToAction("Index","Home");
                }
                TempData["Message"] = "Wrong UserName or Password";
                return RedirectToAction("Index");
                //return Json(response.StatusCode, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                //newException.AddException(ex);
                response.StatusCode = 0;
                response.Message = ex.Message;
                //return Json(response, JsonRequestBehavior.AllowGet);
                TempData["Message"] = "Wrong UserName or Password";
                return RedirectToAction("Index");
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