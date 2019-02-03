using System.Collections.Generic;
using System.Web.Mvc;
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
            return View();
        }

        public ActionResult GetTenantDetails()
        {
            //BusinessLogic BL = new BusinessLogic();

            //tblTenant tenantDetails = new tblTenant();
            //tenantDetails = BL.GetTenantById(1);
            List<tblTenant> tenantDetails = new List<tblTenant>();
            tenantDetails = tr.GetTenantById(1);

            return View();
        }

        public ActionResult GetAllActiveTenants()
        {
            //BusinessLogic BL = new BusinessLogic();

            //List<tblTenant> lstAllActiveTenants = new List<tblTenant>();
            //lstAllActiveTenants = BL.GetAllActiveTenants();
            List<tblTenant> lstAllActiveTenants = new List<tblTenant>();
            lstAllActiveTenants = tr.GetAllActiveTenants();

            return View();
        }

        public ActionResult GetAllInActiveTenants()
        {
            //BusinessLogic BL = new BusinessLogic();

            //List<tblTenant> lstAllActiveTenants = new List<tblTenant>();
            //lstAllActiveTenants = BL.GetAllInActiveTenants();
            List<tblTenant> lstAllActiveTenants = new List<tblTenant>();
            lstAllActiveTenants = tr.GetAllInActiveTenants();

            return View();
        }
    }
}