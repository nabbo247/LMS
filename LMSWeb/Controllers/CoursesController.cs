using System;
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
        Exceptions newException = new Exceptions();
        // GET: Courses
        public ActionResult Index()
        {
            try
            {
                List<TblCourse> listInActiveCourses = new List<TblCourse>();
                TblUser sessionUser = (TblUser)Session["UserSession"];
                listInActiveCourses = cc.GetAllCourses(sessionUser.TenantId);

                return View(listInActiveCourses);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }


        public ActionResult GetCourseDetails()
        {
            try
            {
                List<TblCourse> courseDetails = new List<TblCourse>();
                TblUser sessionUser = (TblUser)Session["UserSession"];
                courseDetails = cc.GetCourseById(1);

                return View(courseDetails);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        public ActionResult AddCourse()
        {
            try
            {
                TblCourse objEditData = new TblCourse
                {
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
        public ActionResult AddCourse(TblCourse objCourse)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TblUser sessionUser = (TblUser)Session["UserSession"];
                    objCourse.CreatedBy = sessionUser.UserId;
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
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        public ActionResult EditCourse(int id)
        {
            try
            {
                List<TblCourse> CourseDetails = new List<TblCourse>();
                CourseDetails = cc.GetCourseById(id);
                TblCourse objEditData = new TblCourse
                {
                    Tenants = tr.GetAllTenants()
                };
                CourseDetails[0].Tenants = objEditData.Tenants;
                objEditData = CourseDetails[0];
                if (CourseDetails[0].CoursePath != null)
                {
                    ViewBag.JavaScriptFunction = string.Format("showFileName('{0}');", CourseDetails[0].CoursePath);
                }

                return View(objEditData);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }

        }

        [HttpPost]
        public ActionResult EditCourse(TblCourse objCourse)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TblUser sessionUser = (TblUser)Session["UserSession"];
                    objCourse.CreatedBy = sessionUser.UserId;
                    int rows = cc.EditCourse(objCourse);
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
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        [HttpPost, ActionName("DeleteCourse")]
        public ActionResult DeleteConfirmCourse(int id)
        {
            try
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
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }


    }
}