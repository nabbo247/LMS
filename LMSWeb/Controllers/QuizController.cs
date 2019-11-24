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

        public ActionResult EditQuiz(TblQuiz objQuiz)
        {
            try
            {
                return View(objQuiz);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }

        public ActionResult ViewQuiz(TblQuiz objQuiz)
        {
            try
            {
                return View(objQuiz);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View();
            }
        }
    }
}