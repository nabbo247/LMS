using System;
using System.Collections.Generic;
using System.Web.Mvc;
using LMSBL.Common;
using LMSBL.DBModels;
using LMSBL.Repository;
using LMSWeb.ViewModel;

namespace LMSWeb.Controllers
{
    public class AccountController : Controller
    {
        UserRepository ur = new UserRepository();
        RolesRepository rr = new RolesRepository();
        TenantRepository tr = new TenantRepository();
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
        public ActionResult MyProfile()
        {
            LMSBL.DBModels.TblUser model = new LMSBL.DBModels.TblUser();
            model = (LMSBL.DBModels.TblUser)Session["UserSession"];

            List<TblUser> userDetails = new List<TblUser>();
            userDetails = ur.GetUserById(model.UserId);
            TblUser objEditData = new TblUser();
            objEditData = userDetails[0];
            objEditData.UserRoles = rr.GetAllRoles();
            objEditData.Tenants = tr.GetAllTenants();
            objEditData.IsMyProfile = true;
            return View(objEditData);
        }
        public ActionResult ChangePassword()
        {
            ChangePasswordViewModel CPViewModel = new ChangePasswordViewModel();
            return View(CPViewModel);
        }

        public ActionResult UpdatePassword()
        {
            TempData["Message"] = "Not Saved Successfully";
            return View("ChangePassword");
        }
    }
}