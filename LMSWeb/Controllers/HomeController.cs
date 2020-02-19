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
using LMSWeb.ViewModel;
using System.Linq;

namespace LMSWeb.Controllers
{
    public class HomeController : Controller
    {
        Exceptions newException = new Exceptions();
        HomeRepository hm = new HomeRepository();
        public ActionResult Index()
        {
            try
            {
                var model = (TblUser)Session["UserSession"];
                if (model.RoleId == 1)
                {
                    return View();
                }
                if (model.RoleId == 2)
                {
                    AdminHomeViewModel adminHomeViewModel = new AdminHomeViewModel();
                    adminHomeViewModel.lstActivities = hm.GetAllAdminActivities(model.TenantId);
                    adminHomeViewModel.allCounts = hm.GetAllAdminHomeCounts(model.TenantId);
                    return View("AdminHome", adminHomeViewModel);
                }
                if (model.RoleId == 3)
                {
                    HomeViewModel homeViewModel = new HomeViewModel();
                    homeViewModel.lstActivities = hm.GetAllLearnerActivities(model.TenantId, model.UserId, "Total");
                    homeViewModel.TotalCount = homeViewModel.lstActivities.Count;                    
                    homeViewModel.CompletedCount = homeViewModel.lstActivities.Count(p => p.ActivityStatus== "Completed");
                    homeViewModel.InProgressCount = homeViewModel.lstActivities.Count(p => p.ActivityStatus == "InProgress");
                    homeViewModel.NotStartedCount = homeViewModel.lstActivities.Count(p => p.ActivityStatus == "Not Started");
                    return View("LearnerHome", homeViewModel);
                }                
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
            }
            return RedirectToAction("Index", "Login");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult GetFilteredData(string status)
        {
            var model = (TblUser)Session["UserSession"];
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.lstActivities = hm.GetAllLearnerActivities(model.TenantId, model.UserId, status);            
            return PartialView("_ActivityData", homeViewModel.lstActivities);
        }
    }
}