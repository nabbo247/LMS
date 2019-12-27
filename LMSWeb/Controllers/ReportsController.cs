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
        // GET: Reports
        public ActionResult Index()
        {
            TblUser sessionUser = (TblUser)Session["UserSession"];
            var ReportModel = quizRepository.GetQuizReportByUserID(sessionUser.TenantId);
            return View(ReportModel);
        }
        public ActionResult ViewQuiz(int quizId, int userId)
        {
            
            List<TblQuiz> lstAllQuiz = new List<TblQuiz>();
            lstAllQuiz = quizRepository.GetQuizForLaunch(quizId, userId);

            List<TblRespons> quizResponses = new List<TblRespons>();
            quizResponses = quizRepository.GetQuizResponsesByUserID(quizId, userId);
            lstAllQuiz[0].TblResponses = quizResponses;

            var score = quizRepository.GetQuizScoreByUserID(quizId, userId);
            lstAllQuiz[0].Score = score;

            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            lstAllQuiz[0].hdnReviewData = json_serializer.Serialize(lstAllQuiz[0]);
            return View(lstAllQuiz[0]);

        }

    }
}