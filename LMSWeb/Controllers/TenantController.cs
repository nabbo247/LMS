using System.Collections.Generic;
using System.Web.Mvc;
using LMSBL.Common;
using LMSBL.DBModels;
using LMSBL.Repository;


namespace LMSWeb.Controllers
{

    
    public class TenantController : Controller
    {
        TenantRepository tr = new TenantRepository();

        // GET: Tenant
        public ActionResult Index()
        {
            List<TblTenant> lstAllTenants = new List<TblTenant>();
            lstAllTenants = tr.GetAllActiveTenants();
            return View(lstAllTenants);
        }

        public ActionResult GetAllActiveTenants()
        {
            List<TblTenant> lstAllActiveTenants = new List<TblTenant>();
            lstAllActiveTenants = tr.GetAllActiveTenants();

            return PartialView(lstAllActiveTenants);
        }

        public ActionResult GetAllInActiveTenants()
        {
            List<TblTenant> lstAllInActiveTenants = new List<TblTenant>();
            lstAllInActiveTenants = tr.GetAllInActiveTenants();
            return PartialView(lstAllInActiveTenants);
        }

        public ActionResult AddTenant()
        {
            TblTenant objEditData = new TblTenant();
            return View(objEditData);
        }

        [HttpPost]
        public ActionResult AddTenant(TblTenant objTenant)
        {
            if (ModelState.IsValid)
            {
                objTenant.TenantDomain = "http://"+objTenant.TenantDomain + "." + Request.Url.Host;
                int rows = tr.AddTenant(objTenant);
                if (rows != 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(objTenant);
                }
            }
            return View(objTenant);
        }

        public ActionResult EditTenant(int id)
        {
            List<TblTenant> tenantDetails = new List<TblTenant>();
            tenantDetails = tr.GetTenantById(id);
            TblTenant objEditData = new TblTenant();
            objEditData = tenantDetails[0];
            return View(objEditData);
        }

        [HttpPost]
        public ActionResult EditTenant(TblTenant objTenant)
        {
            if (ModelState.IsValid)
            {
                int rows = tr.EditTenants(objTenant);
                if (rows != 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(objTenant);
                }
            }
            return View(objTenant);
        }

        //public ActionResult DeleteTenant(int id,bool isActive)
        //{
        //    ViewBag.isActive = isActive;
        //    List<TblTenant> tenantDetails = new List<TblTenant>();
        //    tenantDetails = tr.GetTenantById(id);
        //    TblTenant objEditData = new TblTenant();
        //    objEditData = tenantDetails[0];
        //    return View(objEditData);
        //}

        [HttpPost,ActionName("DeleteTenant")]
        public ActionResult DeleteConfirmTenant(int id)
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
                    //return RedirectToAction("Index");
                }
                else
                {
                    response.StatusCode = 0;
                    //return View(objTenant);
                }
            }
            //return View(objTenant);
            return Json(response.StatusCode, JsonRequestBehavior.AllowGet);
        }

        public ActionResult VerifyTenantDomain(string Domain)
        {
            //string isAvailable = string.Empty;
            int isAvailable= tr.VerifyTenantDomain(Domain);

            return Json(isAvailable, JsonRequestBehavior.AllowGet);
        }
    }


}