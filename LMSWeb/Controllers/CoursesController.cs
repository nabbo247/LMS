using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.Mvc;
using LMSBL.Common;
using LMSBL.DBModels;
using LMSBL.Repository;
using LMSWeb.ViewModel;


namespace LMSWeb.Controllers
{
    public class CoursesController : Controller
    {
        UserRepository userRepository = new UserRepository();
        CoursesRepository cc = new CoursesRepository();
        TenantRepository tr = new TenantRepository();
        Exceptions newException = new Exceptions();
        // GET: Courses
        public ActionResult Index()
        {
            try
            {
                List<tblCourse> listInActiveCourses = new List<tblCourse>();
                TblUser sessionUser = (TblUser)Session["UserSession"];
                listInActiveCourses = cc.GetAllCourses(sessionUser.TenantId);

                return View("CourseList", listInActiveCourses);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View("CourseList");
            }
        }

        public ActionResult AddCourse()
        {
            try
            {
                tblCourse objEditData = new tblCourse();

                return View("AddNewCourse", objEditData);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View("AddNewCourse");
            }
        }

        [HttpPost]
        public ActionResult AddCourse(tblCourse objCourse, HttpPostedFileBase file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int rows = 0;
                    TblUser sessionUser = (TblUser)Session["UserSession"];
                    objCourse.createdBy = sessionUser.UserId;
                    objCourse.tenantId = sessionUser.TenantId;
                    newException.AddDummyException(":- " + objCourse.tenantId);
                    objCourse.ZipFile = file;
                    if (objCourse.ContentModuleId > 0)
                    {
                        rows = cc.EditCourse(objCourse);
                    }
                    else
                    {
                        rows = cc.AddCourse(objCourse);
                    }


                    if (rows != 0)
                    {
                        TempData["Message"] = "Course Saved Successfully";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View("AddNewCourse", objCourse);
                    }
                }
                return View("AddNewCourse", objCourse);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View("AddNewCourse");
            }
        }

        public ActionResult EditCourse(int id)
        {
            try
            {
                List<tblCourse> CourseDetails = new List<tblCourse>();
                CourseDetails = cc.GetCourseById(id);

                return View("AddNewCourse", CourseDetails[0]);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View("AddNewCourse");
            }

        }

        [HttpPost, ActionName("DeleteCourse")]
        public ActionResult DeleteConfirmCourse(int id)
        {
            try
            {
                Response response = new Response();
                List<tblCourse> objCourseList = cc.GetCourseById(id);
                tblCourse objCourse = objCourseList[0];
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

        public ActionResult AssignCourse(int id)
        {
            List<SelectListItem> userItems = new List<SelectListItem>();
            List<tblCourse> objCourse = new List<tblCourse>();
            CourseAssignViewModel courseAssignVieewModel = new CourseAssignViewModel();
            TblUser sessionUser = (TblUser)Session["UserSession"];

            var Users = userRepository.GetAllUsers(sessionUser.TenantId);

            foreach (var user in Users)
            {
                userItems.Add(new SelectListItem
                {
                    Text = Convert.ToString(user.FirstName + " " + user.LastName),
                    Value = Convert.ToString(user.UserId)
                });
            }

            DataSet ds = cc.GetAssignedCourseUsers(id);
            bool isDueDate = false;
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (var item in userItems)
                        {
                            DataRow[] foundUsers = ds.Tables[0].Select("LearnerId = " + item.Value + "");
                            if (foundUsers.Length != 0)
                            {
                                item.Selected = true;
                                isDueDate = true;
                            }
                        }
                    }
                }
            }
            courseAssignVieewModel.usetList = userItems;
            if (isDueDate)
                if (ds != null)
                {
                    if (ds.Tables[0] != null)
                    {
                        if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0][1])))
                            courseAssignVieewModel.DueDate = Convert.ToDateTime(ds.Tables[0].Rows[0][1]);
                    }
                }
            objCourse = cc.GetCourseById(id);
            
            courseAssignVieewModel.course = objCourse[0];
            return View(courseAssignVieewModel);
        }

        public ActionResult AssignCourseToUsers(CourseAssignViewModel courseAssignViewModel)
        {
            var index = cc.DeleteAssignedUserForCourse(courseAssignViewModel.course.ContentModuleId);           

            foreach (var userId in courseAssignViewModel.userIds)
            {
                var result = cc.AssignCourse(courseAssignViewModel.course.ContentModuleId, userId, courseAssignViewModel.DueDate);

                var emailBody = courseAssignViewModel.course.ContentModuleName + " - assigned to you. Please go through it. <br /> Your Due Date is - " + courseAssignViewModel.DueDate;
                var emailSubject = "Course Assigned - " + courseAssignViewModel.course.ContentModuleName;
                tblEmails objEmail = new tblEmails();
                var objUser = userRepository.GetUserById(userId);
                objEmail.EmailTo = objUser[0].EmailId;
                objEmail.EmailSubject = emailSubject;
                objEmail.EmailBody = emailBody;
                var emailResult = userRepository.InsertEmail(objEmail);
            }          

            return RedirectToAction("Index");
        }
    }
}