using LMSBL.DBModels;
using LMSBL.Repository;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LMSWeb.Controllers
{
    public class AssignmentController : Controller
    {
        QuizRepository quizRepository = new QuizRepository();
        // GET: Assignment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyAssignments()
        {
            //Learner's Assigned Courses. 
            TblUser sessionUser = (TblUser)Session["UserSession"];
            List<TblQuiz> lstAllQuiz = new List<TblQuiz>();
            lstAllQuiz = quizRepository.GetQuizByUserID(sessionUser.UserId);

            return View(lstAllQuiz);
          
        }

        public ActionResult AssignCources()
        {
            //Admin -> show selected course details in popup with user list. 
            return View();
        }

        public ActionResult LaunchQuiz(int QuizId)
        {
            TblUser sessionUser = (TblUser)Session["UserSession"];
            List<TblQuiz> lstAllQuiz = new List<TblQuiz>();
            lstAllQuiz = quizRepository.GetQuizForLaunch(QuizId, sessionUser.UserId);
            return View(lstAllQuiz[0]);
        }

        [HttpPost]
        public ActionResult SubmitAssignCources()
        {
            //Admin -> in popup submit click. 
            //assign select course to selected users. 
            return View();
        }

        [HttpPost]
        public ActionResult SubmitQuiz(TblQuiz objQuiz)
        {
           
            return View();
        }
    }
}