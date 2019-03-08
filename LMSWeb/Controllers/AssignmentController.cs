using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMSWeb.Controllers
{
    public class AssignmentController : Controller
    {
        // GET: Assignment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyAssignments()
        {
            //Learner's Assigned Courses. 
            return View();
        }

        public ActionResult AssignCources()
        {
            //Admin -> show selected course details in popup with user list. 
            return View();
        }
        [HttpPost]
        public ActionResult SubmitAssignCources()
        {
            //Admin -> in popup submit click. 
            //assign select course to selected users. 
            return View();
        }
    }
}