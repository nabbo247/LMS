using System;
using System.Collections.Generic;
using System.Web.Mvc;
using LMSBL.Common;
using LMSBL.DBModels;
using LMSBL.Repository;


namespace LMSWeb.Controllers
{
    public class QuizController : Controller
    {
        QuizRepository quizRepository = new QuizRepository();
        RolesRepository rr = new RolesRepository();
        TenantRepository tr = new TenantRepository();
        // GET: Quiz
        public ActionResult Index()
        {
            TblUser sessionUser = (TblUser)Session["UserSession"];
            List<tblQuiz> lstAllQuiz = new List<tblQuiz>();
            lstAllQuiz = quizRepository.GetAllQuiz(sessionUser.TenantId);

            return View(lstAllQuiz);
        }

        public ActionResult AddQuiz()
        {
            tblQuiz objQuiz = new tblQuiz();

            return View(objQuiz);
        }
        public ActionResult EditQuiz(tblQuiz objQuiz)
        {
            return View(objQuiz);
        }

        public ActionResult ViewQuiz(tblQuiz objQuiz)
        {
            return View(objQuiz);
        }
    }
}