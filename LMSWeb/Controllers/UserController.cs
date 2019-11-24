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
        Exceptions newException = new Exceptions();
        // GET: Tenant
        public ActionResult Index()
        {
            try
            {
                TblUser sessionUser = (TblUser)Session["UserSession"];
                List<TblUser> lstAllUsers = new List<TblUser>();
                lstAllUsers = ur.GetAllUsers(sessionUser.TenantId);

                return View(lstAllUsers);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        public ActionResult GetUserDetails()
        {
            try
            {
                List<TblUser> userDetails = new List<TblUser>();
                TblUser sessionUser = (TblUser)Session["UserSession"];
                userDetails = ur.GetUserById(sessionUser.TenantId);

                return View(userDetails);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        public ActionResult GetAllUsers()
        {
            try
            {
                TblUser sessionUser = (TblUser)Session["UserSession"];
                List<TblUser> lstAllActiveUsers = new List<TblUser>();
                lstAllActiveUsers = ur.GetAllUsers(sessionUser.TenantId);

                return PartialView(lstAllActiveUsers);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        public ActionResult AddUser()
        {
            try
            {
                TblUser objEditData = new TblUser
                {
                    UserRoles = rr.GetAllRoles(),
                    Tenants = tr.GetAllTenants()
                };
                return View(objEditData);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        [HttpPost]
        public ActionResult AddUser(TblUser objUser)
        {
            try
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
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        public ActionResult EditUser(int id)
        {
            try
            {
                List<TblUser> userDetails = new List<TblUser>();
                userDetails = ur.GetUserById(id);
                TblUser objEditData = new TblUser();
                objEditData = userDetails[0];
                objEditData.UserRoles = rr.GetAllRoles();
                objEditData.Tenants = tr.GetAllTenants();
                return View(objEditData);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        [HttpPost]
        public ActionResult EditUser(TblUser objUser)
        {
            try
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
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        [HttpPost, ActionName("DeleteUser")]
        public ActionResult DeleteConfirmUser(int id)
        {
            try
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
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }
    }
}