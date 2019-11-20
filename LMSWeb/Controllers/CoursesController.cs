using System.Collections.Generic;
using System.Web.Mvc;
using LMSBL.Common;
using LMSBL.DBModels;
using LMSBL.Repository;

namespace LMSWeb.Controllers
{
    public class CoursesController : Controller
    {
        CoursesRepository cc = new CoursesRepository();
        TenantRepository tr = new TenantRepository();
        // GET: Courses
        public ActionResult Index()
        {
            List<TblCourse> listInActiveCourses = new List<TblCourse>();
            TblUser sessionUser = (TblUser)Session["UserSession"];
            listInActiveCourses = cc.GetAllCourses(sessionUser.TenantId);

            return View(listInActiveCourses);
        }


        public ActionResult GetCourseDetails()
        {
            List<TblCourse> courseDetails = new List<TblCourse>();
            TblUser sessionUser = (TblUser)Session["UserSession"];
            courseDetails = cc.GetCourseById(1);

            return View(courseDetails);
        }

        public ActionResult AddCourse()
        {
            TblCourse objEditData = new TblCourse
            {
                Tenants = tr.GetAllActiveTenants()
            };
            return View(objEditData);
        }

        [HttpPost]
        public ActionResult AddCourse(TblCourse objCourse)
        {
            if (ModelState.IsValid)
            {
                int rows = cc.AddCourse(objCourse);
                if (rows != 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(objCourse);
                }
            }
            return View(objCourse);
        }


        //public ActionResult DeleteCourse(int id, bool isActive)
        //{
        //    ViewBag.isActive = isActive;
        //    List<TblCourse> CourseDetails = new List<TblCourse>();
        //    CourseDetails = cc.GetCourseById(id);
        //    TblCourse objEditData = new TblCourse();
        //    objEditData = CourseDetails[0];
        //    return View(objEditData);
        //}

        [HttpPost, ActionName("DeleteCourse")]
        public ActionResult DeleteConfirmCourse(int id)
        {
            Response response = new Response();
            List<TblCourse> objCourseList = cc.GetCourseById(id);
            TblCourse objCourse = objCourseList[0];
            if (ModelState.IsValid)
            {
                if (objCourse.IsActive == true)
                {
                    objCourse.IsActive = false;
                }
                else
                {
                    objCourse.IsActive = true;
                }
                int rows = cc.DeleteCourse(objCourse);
                if (rows != 0)
                {
                    response.StatusCode = 1;
                    //return RedirectToAction("Index");
                }
                else
                {
                    response.StatusCode = 0;
                    //return View(objCourse);
                }
            }
            //return View(objTenant);
            return Json(response.StatusCode, JsonRequestBehavior.AllowGet);
        }


    }
}