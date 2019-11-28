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

        [HttpPost]
        public ActionResult AddQuiz(TblQuiz objQuiz)
        {
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
                return View("AddQuiz", objQuiz[0]);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View("AddQuiz", null);
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