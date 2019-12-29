using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using LMSWeb.ViewModel;
using LMSBL.Common;
using LMSBL.DBModels;
using LMSBL.Repository;


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

                return View(lstAllQuiz);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        public ActionResult AddQuiz()
        {
            try
            {
                TblQuiz objQuiz = new TblQuiz();

                return View(objQuiz);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
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
                    Text = Convert.ToString(user.FirstName),
                    Value = Convert.ToString(user.UserId)
                });
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
                        else
                        {
                            return View(objQuiz);
                        }
                    }
                }
                return View(objQuiz);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
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
                return View("EditQuiz", objQuiz[0]);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View("EditQuiz", null);
            }
        }
        [HttpPost]
        public ActionResult AssignQuizToUsers(QuizAssignViewModel quizAssignViewModel)
        {
            int assigned = 0;
            int notAssigned = 0;
            foreach(var userId in quizAssignViewModel.userIds)
            {
                var result = quizRepository.AssignQuiz(quizAssignViewModel.quiz.QuizId, userId);
                if (result > 0)
                    assigned++;
                else
                    notAssigned++;
            }
            string message = "Quiz Assigned to - " + assigned + " User/s";
            if (notAssigned > 0)
                message += " And Not Assigned to - " + notAssigned + " User/s";
            
            TempData["Message"] = message;
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

                return View(lstAllQuiz[0]);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }
    }
}