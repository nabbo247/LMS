using LMSBL.DBModels;
using LMSBL.Repository;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Script.Serialization;

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

            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            lstAllQuiz[0].hdnLaunchData = json_serializer.Serialize(lstAllQuiz[0]);
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
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();

            TblUser sessionUser = (TblUser)Session["UserSession"];

            List<QueOptions> lstQueOptions = new List<QueOptions>();
            object[] objQueResponse = (object[])json_serializer.DeserializeObject(objQuiz.hdnResponseData);
            foreach (var item in objQueResponse)
            {
                QuizResponse quizResponse = new QuizResponse();
                quizResponse.QuizId = objQuiz.QuizId;
                quizResponse.UserId = sessionUser.UserId;

                foreach (Dictionary<string, object> newItem in (object[])item)
                {
                    var questionId = newItem["questionId"];
                    quizResponse.QuestionId = Convert.ToInt32(newItem["questionId"]);
                    quizResponse.QuestionFeedback = Convert.ToString(newItem["queFeedback"]);
                    if (string.IsNullOrEmpty(quizResponse.OptionIds))
                        quizResponse.OptionIds = Convert.ToString(newItem["optionId"]);
                    else
                        quizResponse.OptionIds += "," + Convert.ToString(newItem["optionId"]);
                }
                QueOptions newQueOption = new QueOptions();
                newQueOption.QuestionId = quizResponse.QuestionId;
                newQueOption.OptionsIds = quizResponse.OptionIds;
                lstQueOptions.Add(newQueOption);

                var result = quizRepository.CaptureResponses(quizResponse);
            }

            List<TblQuiz> lstAllQuiz = new List<TblQuiz>();
            lstAllQuiz = quizRepository.GetQuizForLaunch(objQuiz.QuizId, sessionUser.UserId);

            var score = 0;
            foreach (var question in lstAllQuiz[0].TblQuestions)
            {
                if (question.QuestionTypeId == 1)
                {
                    foreach (var option in question.TblQuestionOptions)
                    {
                        if (option.CorrectOption == true)
                        {
                            foreach (var que in lstQueOptions)
                            {
                                if (que.QuestionId == question.QuestionId)
                                {
                                    if (option.OptionId == Convert.ToInt32(que.OptionsIds))
                                    {
                                        score++;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    int correctCount = 0;
                    int[] Ids = new int[question.TblQuestionOptions.Count];
                    foreach (var option in question.TblQuestionOptions)
                    {

                        if (option.CorrectOption == true)
                        {                            
                            Ids[correctCount] = option.OptionId;
                            correctCount++;
                        }
                    }
                    foreach (var item in lstQueOptions)
                    {
                        if (item.QuestionId == question.QuestionId)
                        {
                            var optionIds = item.OptionsIds.Split(',');
                            if (correctCount == optionIds.Length)
                            {
                                var correct = 0;
                                foreach (var option in optionIds)
                                {
                                    foreach (var id in Ids)
                                    {
                                        if (id == Convert.ToInt32(option))
                                        {
                                            correct++;
                                        }
                                    }
                                }
                                if(correctCount== correct)
                                {
                                    score++;
                                }
                            }
                        }
                    }
                }
            }

            var scoreResult = quizRepository.CaptureScore(objQuiz.QuizId, sessionUser.UserId, score);

            TempData["Message"] = "Responses Saved Successfully";
            return RedirectToAction("ReviewQuiz", new { @QuizId = objQuiz.QuizId });

        }


        public ActionResult ReviewQuiz(int QuizId)
        {
            TblUser sessionUser = (TblUser)Session["UserSession"];
            List<TblQuiz> lstAllQuiz = new List<TblQuiz>();
            lstAllQuiz = quizRepository.GetQuizForLaunch(QuizId, sessionUser.UserId);

            List<TblRespons> quizResponses = new List<TblRespons>();
            quizResponses = quizRepository.GetQuizResponsesByUserID(QuizId, sessionUser.UserId);
            lstAllQuiz[0].TblResponses = quizResponses;

            var score = quizRepository.GetQuizScoreByUserID(QuizId, sessionUser.UserId);
            lstAllQuiz[0].Score = score;

            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            lstAllQuiz[0].hdnReviewData = json_serializer.Serialize(lstAllQuiz[0]);
            return View(lstAllQuiz[0]);
        }
    }
}