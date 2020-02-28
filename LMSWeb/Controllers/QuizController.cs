using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using LMSWeb.ViewModel;
using LMSBL.Common;
using LMSBL.DBModels;
using LMSBL.Repository;
using System.Data;

namespace LMSWeb.Controllers
{
    public class QuizController : Controller
    {
        UserRepository userRepository = new UserRepository();
        QuizRepository quizRepository = new QuizRepository();
        Exceptions newException = new Exceptions();
        // GET: Quiz
        public ActionResult Index()
        {
            try
            {

                TblUser sessionUser = (TblUser)Session["UserSession"];

                List<TblQuiz> lstAllQuiz = new List<TblQuiz>();
                lstAllQuiz = quizRepository.GetAllQuiz(sessionUser.TenantId);

                return View("QuizList", lstAllQuiz);
            }
            catch (Exception ex)
            {
                //newException.AddDummyException("222222");
                newException.AddException(ex);
                return View("QuizList");
            }
        }

        public ActionResult AddQuiz()
        {
            try
            {
                TblQuiz objQuiz = new TblQuiz();

                return View("AddNewQuiz", objQuiz);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View("AddNewQuiz");
            }
        }

        public ActionResult AssignQuiz(int id)
        {
            List<SelectListItem> userItems = new List<SelectListItem>();
            List<TblQuiz> objQuiz = new List<TblQuiz>();
            QuizAssignViewModel quizAssignVieewModel = new QuizAssignViewModel();
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
            DataSet ds = quizRepository.GetAssignedQuizUsers(id);
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (var item in userItems)
                        {
                            DataRow[] foundUsers = ds.Tables[0].Select("UserId = " + item.Value + "");
                            if (foundUsers.Length != 0)
                            {
                                item.Selected = true;
                            }
                        }
                    }
                }
            }
            quizAssignVieewModel.usetList = userItems;
            objQuiz = quizRepository.GetQuizByID(id);
            quizAssignVieewModel.quiz = objQuiz[0];
            return View(quizAssignVieewModel);
        }

        [HttpPost]
        public ActionResult AddQuiz(TblQuiz objQuiz)
        {
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            object[] objTblQue = (object[])json_serializer.DeserializeObject(objQuiz.hdnData);
            objQuiz.questionObject = objTblQue;
            try
            {
                if (ModelState.IsValid)
                {
                    TblUser sessionUser = (TblUser)Session["UserSession"];

                    if (sessionUser != null)
                    {
                        objQuiz.TenantId = sessionUser.TenantId;
                        int rows = 0;
                        if (objQuiz.QuizId == 0)
                        {
                            rows = quizRepository.CreateQuiz(objQuiz);
                        }
                        else
                        {
                            rows = quizRepository.UpdateQuiz(objQuiz);

                        }
                        if (rows != 0)
                        {
                            TempData["Message"] = "Quiz Saved Successfully";

                            return RedirectToAction("Index");
                        }
                        else if (rows == 0)
                        {
                            TempData["Message"] = "There is some problem while saving Quiz";
                            return View("AddNewQuiz",objQuiz);
                        }
                        else
                        {
                            return View("AddNewQuiz",objQuiz);
                        }
                    }
                }

                return View("AddNewQuiz",objQuiz);

            }
            catch (Exception ex)
            {
                //newException.AddDummyException("11111");
                newException.AddException(ex);
                return View("AddNewQuiz");
            }
        }
        public ActionResult EditQuiz(int id)
        {
            List<TblQuiz> objQuiz = new List<TblQuiz>();
            try
            {

                objQuiz = quizRepository.GetQuizByID(id);
                JavaScriptSerializer json_serializer = new JavaScriptSerializer();

                objQuiz[0].hdnEditData = json_serializer.Serialize(objQuiz[0]);
                return View("EditNewQuiz", objQuiz[0]);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View("EditNewQuiz", null);
            }
        }
        [HttpPost]
        public ActionResult AssignQuizToUsers(QuizAssignViewModel quizAssignViewModel)
        {
            var index = quizRepository.DeleteAssignedUser(quizAssignViewModel.quiz.QuizId);

            foreach (var userId in quizAssignViewModel.userIds)
            {
                var result = quizRepository.AssignQuiz(quizAssignViewModel.quiz.QuizId, userId, quizAssignViewModel.DueDate);

                var emailBody = quizAssignViewModel.quiz.QuizName + " - assigned to you. Please go through it. <br /> Your Due Date is - " + quizAssignViewModel.DueDate;
                var emailSubject = "Course Assigned - " + quizAssignViewModel.quiz.QuizName;
                tblEmails objEmail = new tblEmails();
                var objUser = userRepository.GetUserById(userId);
                objEmail.EmailTo = objUser[0].EmailId;
                objEmail.EmailSubject = emailSubject;
                objEmail.EmailBody = emailBody;
                var emailResult = userRepository.InsertEmail(objEmail);
            }

            return RedirectToAction("Index");
        }
        public ActionResult ViewQuiz(int id)
        {
            try
            {
                TblUser sessionUser = (TblUser)Session["UserSession"];
                List<TblQuiz> lstAllQuiz = new List<TblQuiz>();
                lstAllQuiz = quizRepository.GetQuizByID(id);

                JavaScriptSerializer json_serializer = new JavaScriptSerializer();
                lstAllQuiz[0].hdnViewData = json_serializer.Serialize(lstAllQuiz[0]);

                return View("ViewAdminQuiz", lstAllQuiz[0]);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View("ViewAdminQuiz");
            }
        }
    }
}