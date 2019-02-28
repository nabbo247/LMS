﻿using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Web;
using System.Web.Mvc;
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
            return View();
        }


        public ActionResult GetCourseDetails()
        {
            List<TblCourse> courseDetails = new List<TblCourse>();
            courseDetails = cc.GetCourseById(1);

            return View(courseDetails);
        }

        public ActionResult GetAllActiveCourses()
        {
            List<TblCourse> listActiveCourses = new List<TblCourse>();
            listActiveCourses = cc.GetAllActiveCourses(1);

            return PartialView(listActiveCourses);
        }

        public ActionResult GetAllInActiveCourses()
        {

            List<TblCourse> listInActiveCourses = new List<TblCourse>();
            listInActiveCourses = cc.GetAllInActiveCourses(1);

            return PartialView(listInActiveCourses);
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


        public ActionResult DeleteCourse(int id, bool isActive)
        {
            ViewBag.isActive = isActive;
            List<TblCourse> CourseDetails = new List<TblCourse>();
            CourseDetails = cc.GetCourseById(id);
            TblCourse objEditData = new TblCourse();
            objEditData = CourseDetails[0];
            return View(objEditData);
        }

        [HttpPost, ActionName("DeleteCourse")]
        public ActionResult DeleteConfirmCourse(int id)
        {
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
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(objCourse);
                }
            }
            return View(objCourse);
        }


    }
}