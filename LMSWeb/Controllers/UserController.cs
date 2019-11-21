using System;
using System.Collections.Generic;
using System.Web.Mvc;
using LMSBL.Common;
using LMSBL.DBModels;
using LMSBL.Repository;

namespace LMSWeb.Controllers
{
    public class UserController : Controller
    {
        UserRepository ur = new UserRepository();
        RolesRepository rr = new RolesRepository();
        TenantRepository tr = new TenantRepository();

        // GET: Tenant
        public ActionResult Index()
        {
            TblUser sessionUser = (TblUser)Session["UserSession"];
            List<TblUser> lstAllUsers = new List<TblUser>();
            lstAllUsers = ur.GetAllActiveUsers(sessionUser.TenantId);

            return View(lstAllUsers);
        }

        public ActionResult GetUserDetails()
        {
            List<TblUser> userDetails = new List<TblUser>();
            TblUser sessionUser = (TblUser)Session["UserSession"];
            userDetails = ur.GetUserById(sessionUser.TenantId);

            return View(userDetails);
        }

        public ActionResult GetAllActiveUsers()
        {
            TblUser sessionUser = (TblUser)Session["UserSession"];
            List<TblUser> lstAllActiveUsers = new List<TblUser>();
            lstAllActiveUsers = ur.GetAllActiveUsers(sessionUser.TenantId);

            return PartialView(lstAllActiveUsers);
        }

        public ActionResult GetAllInActiveUsers()
        {
            TblUser sessionUser = (TblUser)Session["UserSession"];
            List<TblUser> lstAllInActiveUsers = new List<TblUser>();
            lstAllInActiveUsers = ur.GetAllInActiveUsers(sessionUser.TenantId);
            return PartialView(lstAllInActiveUsers);
        }

        public ActionResult AddUser()
        {
            TblUser objEditData = new TblUser
            {
                UserRoles = rr.GetAllRoles(),
                Tenants = tr.GetAllActiveTenants()
             };
            return View(objEditData);
        }

        [HttpPost]
        public ActionResult AddUser(TblUser objUser)
        {
            if (ModelState.IsValid)
            {
                TblUser sessionUser = (TblUser)Session["UserSession"];
                objUser.TenantId = sessionUser.TenantId;
                objUser.CreatedBy = sessionUser.UserId;
               // objUser.DOB = objUser.DOB;
                objUser.IsActive = true;
                int rows = ur.AddUser(objUser);
                if (rows != 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(objUser);
                }
            }
            return View(objUser);
        }

        public ActionResult EditUser(int id)
        {
            List<TblUser> userDetails = new List<TblUser>();
            userDetails = ur.GetUserById(id);
            TblUser objEditData = new TblUser();
            objEditData = userDetails[0];
            objEditData.UserRoles = rr.GetAllRoles();
            objEditData.Tenants = tr.GetAllActiveTenants();
            return View(objEditData);
        }

        [HttpPost]
        public ActionResult EditUser(TblUser objUser)
        {
            if (ModelState.IsValid)
            {
                int rows = ur.EditUser(objUser);
                if (rows != 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(objUser);
                }
            }
            return View(objUser);
        }

        //public ActionResult DeleteUser(int id,bool isActive)
        //{
        //    ViewBag.isActive = isActive;
        //    List<TblUser> userDetails = new List<TblUser>();
        //    userDetails = ur.GetUserById(id);
        //    TblUser objEditData = new TblUser();
        //    objEditData = userDetails[0];
        //    return View(objEditData);
        //}

        [HttpPost, ActionName("DeleteUser")]
        public ActionResult DeleteConfirmUser(int id)
        {
            Response response = new Response();
            List<TblUser> objUserList = ur.GetUserById(id);
            TblUser objUser = objUserList[0];
            if (ModelState.IsValid)
            {
                if (objUser.IsActive == true)
                {
                    objUser.IsActive = false;
                }
                else
                {
                    objUser.IsActive = true;
                }
                int rows = ur.DeleteUser(objUser);
                if (rows != 0)
                {
                    response.StatusCode = 1;
                    //return RedirectToAction("Index");
                }
                else
                {
                    response.StatusCode = 0;
                    //return View(objUser);
                }
            }
            //return View(objTenant);
            return Json(response.StatusCode, JsonRequestBehavior.AllowGet);
        }
    }
}