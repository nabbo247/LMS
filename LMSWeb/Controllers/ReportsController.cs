using LMSWeb.ViewModel;
using LMSBL.Common;
using LMSBL.DBModels;
using LMSBL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace LMSWeb.Controllers
{
    public class ReportsController : Controller
    {
        UserRepository userRepository = new UserRepository();
        QuizRepository quizRepository = new QuizRepository();
        Exceptions newException = new Exceptions();
        // GET: Reports
        public ActionResult Index()
        {
            try
            {
                TblUser sessionUser = (TblUser)Session["UserSession"];
                newException.AddDummyException(sessionUser.EmailId);
                List<ReportModel> objReportModel = new List<ReportModel>();
                if (sessionUser.RoleId == 3)
                    objReportModel = quizRepository.GetQuizReportByUserID(sessionUser.TenantId, sessionUser.UserId);
                else
                    objReportModel = quizRepository.GetQuizReportByUserID(sessionUser.TenantId, 0);

                if(objReportModel.Count>0)
                {
                    foreach(var report in objReportModel)
                    {
                        report.QuestionCount = quizRepository.GetQuestionCount(report.quizId);
                    }
                }
                return View(objReportModel);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }
        public ActionResult ViewQuiz(int quizId, int userId, int attempt)
        {
            List<TblQuiz> lstAllQuiz = new List<TblQuiz>();
            lstAllQuiz = quizRepository.GetQuizForLaunch(quizId, userId);

            List<TblRespons> quizResponses = new List<TblRespons>();
            quizResponses = quizRepository.GetQuizResponsesByUserID(quizId, userId, attempt);
            lstAllQuiz[0].TblResponses = quizResponses;

            var score = quizRepository.GetQuizScoreByUserID(quizId, userId, attempt);
            lstAllQuiz[0].Score = score;

            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            lstAllQuiz[0].hdnReviewData = json_serializer.Serialize(lstAllQuiz[0]);
            return View(lstAllQuiz[0]);

        }

        public ActionResult DeleteQuiz(int quizId, int userId, int attempt)
        {
            int result = quizRepository.DeleteResponse(quizId, userId, attempt);
            return RedirectToAction("Index");
        }

        public ActionResult AllReports()
        {
            return View();
        }
    }
}