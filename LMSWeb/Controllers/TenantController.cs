using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
using LMSBL.Common;
using LMSBL.DBModels;
using LMSBL.Repository;


namespace LMSWeb.Controllers
{


    public class TenantController : Controller
    {
        TenantRepository tr = new TenantRepository();
        Exceptions newException = new Exceptions();
        UserRepository ur = new UserRepository();
        RolesRepository rr = new RolesRepository();

        // GET: Tenant
        public ActionResult Index()
        {
            try
            {
                List<TblTenant> lstAllTenants = new List<TblTenant>();
                lstAllTenants = tr.GetAllTenants();
                return View(lstAllTenants);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        public ActionResult AddTenant()
        {
            try
            {
                TblTenant objEditData = new TblTenant();
                return View(objEditData);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        [HttpPost]
        public ActionResult AddTenant(TblTenant objTenant, HttpPostedFileBase file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (objTenant.TenantId == 0)
                    {
                        var result = tr.GetTenantByName(objTenant.TenantName);
                        if (!result)
                        {
                            TempData["Message"] = "Tenant Already Exist";
                            return View(objTenant);
                        }
                    }
                    if (file != null)
                    {
                        var logoURL = System.Configuration.ConfigurationManager.AppSettings["LogoURL"];
                        var logoPhysicalURL = System.Configuration.ConfigurationManager.AppSettings["logoPhysicalURL"];                        
                        string filePhysicalPath = System.IO.Path.Combine(logoPhysicalURL + "\\" + objTenant.TenantName + ".jpg");
                        string path = System.IO.Path.Combine(logoURL + "\\" + objTenant.TenantName + ".jpg");
                        file.SaveAs(filePhysicalPath);                        
                        objTenant.Logo = path;
                    }
                    
                    int rows = 0;
                    if (objTenant.TenantId == 0)
                        rows = tr.AddTenant(objTenant);
                    else
                        rows = tr.EditTenants(objTenant);
                    if (rows != 0)
                    {
                        return RedirectToAction("AddTenantUser", new { @id = objTenant.TenantId });
                    }
                    else
                    {
                        return View(objTenant);
                    }

                }
                return View(objTenant);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        public ActionResult EditTenant(int id)
        {
            try
            {
                List<TblTenant> tenantDetails = new List<TblTenant>();
                tenantDetails = tr.GetTenantById(id);
                TblTenant objEditData = new TblTenant();
                objEditData = tenantDetails[0];
                return View(objEditData);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        [HttpPost]
        public ActionResult EditTenant(TblTenant objTenant)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int rows = tr.EditTenants(objTenant);
                    if (rows != 0)
                    {
                        return RedirectToAction("AddTenantUser", new { @id = objTenant.TenantId });
                    }
                    else
                    {
                        return View(objTenant);
                    }
                }
                return View(objTenant);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        [HttpPost, ActionName("DeleteTenant")]
        public ActionResult DeleteConfirmTenant(int id)
        {
            try
            {
                Response response = new Response();
                List<TblTenant> objTenantList = tr.GetTenantById(id);
                TblTenant objTenant = objTenantList[0];
                if (ModelState.IsValid)
                {
                    if (objTenant.IsActive == true)
                    {
                        objTenant.IsActive = false;
                    }
                    else
                    {
                        objTenant.IsActive = true;
                    }
                    int rows = tr.DeleteTenants(objTenant);
                    if (rows != 0)
                    {
                        response.StatusCode = 1;
                    }
                    else
                    {
                        response.StatusCode = 0;
                    }
                }
                return Json(response.StatusCode, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();

            }
        }

        public ActionResult VerifyTenantDomain(string Domain)
        {
            try
            {
                int isAvailable = 0;//Need to change this tr.VerifyTenantDomain(Domain);
                return Json(isAvailable, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        public ActionResult AddTenantUser(int id)
        {
            try
            {
                TblUser objUserData = new TblUser
                {
                    UserRoles = rr.GetAllRoles(),
                    Tenants = tr.GetAllTenants()
                };
                objUserData.TenantId = id;
                return View(objUserData);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        [HttpPost]
        public ActionResult SaveTenantUser(TblUser objUser)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TblUser sessionUser = (TblUser)Session["UserSession"];
                    objUser.CreatedBy = sessionUser.UserId;
                    objUser.IsActive = true;
                    int rows = 0;
                    if (objUser.UserId == 0)
                        rows = ur.AddUser(objUser);
                    else
                        rows = ur.EditUser(objUser);
                    if (rows != 0)
                    {
                        TempData["Message"] = "Saved Successfully";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["Message"] = "Not Saved Successfully";
                        return View(objUser);
                    }
                }
                return View("AddTenantUser", objUser);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View(objUser);
            }

        }
    }
}