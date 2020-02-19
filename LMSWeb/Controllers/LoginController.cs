using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Configuration;
using System.Net.Mail;
using System.Web.Mvc;
using LMSBL.Common;
using LMSBL.DBModels;
using LMSBL.Repository;
using LMSWeb.App_Start;

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
            
            List<TblTenant> tenantDetails = new List<TblTenant>();
            //tenantDetails = tr.GetTenantById(subDomain);
            try
            {
                return View("Login", user);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View("Login",user);
            }
        }

        public ActionResult UserAuthentication(TblUser loginUser)
        {
            Response response = new Response();
            try
            {
                CommonFunctions common = new CommonFunctions();
                loginUser.Password = common.GetEncodePassword(loginUser.Password);
                TblUser tblUser = ur.IsValidUser(loginUser.EmailId, loginUser.Password);
               

                if (tblUser != null)
                {
                    response.StatusCode = 1;
                    //set User object to session
                    Session["UserSession"] = tblUser; //use in layout.cshtml to hide show menus.
                    if (tblUser.IsNew)
                    {
                        return RedirectToAction("ChangePassword", "Login");
                    }
                    else
                    {
                        ur.AddLoginLog(tblUser.UserId);
                        return RedirectToAction("Index", "Home");
                    }
                    
                }
                TempData["Message"] = "The Username/Password does not match.";
                return RedirectToAction("Index");
                //return Json(response.StatusCode, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                response.StatusCode = 0;
                response.Message = ex.Message;
                //return Json(response, JsonRequestBehavior.AllowGet);
                TempData["Message"] = "The Username/Password does not match.";
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
                return RedirectToAction("Index");
            }
        }

        public ActionResult ResetPassword()
        {
            TblUser loginUser = new TblUser();
            return View(loginUser);
        }

        public ActionResult SendResetLink(TblUser loginUser)
        {
            try
            {                
                Guid guid = Guid.NewGuid();
                string token = guid.ToString();
                var result = ur.AddToken(loginUser.EmailId, token);
                //send email
                var baseURL = System.Configuration.ConfigurationManager.AppSettings["BaseURL"];
                var url = baseURL + @Url.Action("ChangePassword", "Login", new { t = token });
                var link = "<a href='" + url + "'>Click here to reset your password</a>";               

                var emailSubject = System.Configuration.ConfigurationManager.AppSettings["PasswordRecovery"];
                tblEmails objEmail = new tblEmails();
                objEmail.EmailTo = loginUser.EmailId;
                objEmail.EmailSubject = emailSubject;
                objEmail.EmailBody = link;
                result = ur.InsertEmail(objEmail);

                TempData["Message"] = "Reset Link sent to your registered email. Please check your Inbox";
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
            }
            return View("ResetPassword", loginUser);
        }

        public ActionResult ChangePassword(string t)
        {
            
            TblUser loginUser = new TblUser();
            try
            {
                var emailid = string.Empty;
                var model = (TblUser)Session["UserSession"];
                if (model != null)
                {
                    emailid = model.EmailId;
                }
                if (!string.IsNullOrEmpty(t))
                {
                    emailid = ur.VerifyToken(t);
                }
                if (!string.IsNullOrEmpty(emailid))
                {
                    loginUser.EmailId = emailid;
                }
                else
                {
                    TempData["Message"] = "Link already used or expired";
                }
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
            }
            return View(loginUser);
        }

        public ActionResult SubmitChangePassword(TblUser loginUser)
        {
            try
            {
                CommonFunctions common = new CommonFunctions();
                loginUser.Password = common.GetEncodePassword(loginUser.Password);
                var row = ur.UpdatePassword(loginUser);
                if (row != 0)
                {
                    TempData["Message"] = "Password Updated Successfully";
                    var model = (TblUser)Session["UserSession"];
                    if(model==null)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    TempData["Message"] = "Oops! There is some problem";
                    return View("ChangePassword");
                }
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
            }
            return View("ChangePassword");
        }
    }
}