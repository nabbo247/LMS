using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LMSBL;
using LMSBL.DBModels;

namespace LMSWeb.Controllers
{
    
    public class TenantController : Controller
    {
        // GET: Tenant
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTenantDetails()
        {
            BusinessLogic BL = new BusinessLogic();
            
            tblTenant tenantDetails = new tblTenant();
            tenantDetails = BL.GetTenantById(1);
            return View();
        }

        public ActionResult GetAllActiveTenants()
        {
            BusinessLogic BL = new BusinessLogic();

            List<tblTenant> lstAllActiveTenants = new List<tblTenant>();
            lstAllActiveTenants = BL.GetAllActiveTenants();

            return View();
        }
    }
}