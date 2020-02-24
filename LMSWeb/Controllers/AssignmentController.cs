using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Configuration;
using System.Net.Mail;
using System.Web.Mvc;
using LMSBL.Common;
using LMSBL.DBModels;
using LMSBL.Repository;
using LMSWeb.App_Start;
using LMSWeb.ViewModel;
using System.Linq;
using System.Web.Script.Serialization;

namespace LMSWeb.Controllers
{
    public class AssignmentController : Controller
    {
        QuizRepository quizRepository = new QuizRepository();
        UserRepository ur = new UserRepository();
        Exceptions newException = new Exceptions();

        HomeRepository hm = new HomeRepository();
        // GET: Assignment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyAssignments()
        {
            try
            {
                var model = (TblUser)Session["UserSession"];
                HomeViewModel homeViewModel = new HomeViewModel();
                homeViewModel.lstActivities = hm.GetAllLearnerActivities(model.TenantId, model.UserId, "Total");



                //MyLearningViewModel learningViewModel = new MyLearningViewModel();
                //TblUser sessionUser = (TblUser)Session["UserSession"];
                //if (sessionUser == null)
                //{
                //    sessionUser = ur.IsValidUser("Don@gmail.com", "123123");
                //    //Session["UserSession"] = sessionUser;
                //    newException.AddDummyException("222");
                //}
                ////Learner's Assigned Quiz. 
                //learningViewModel.lstQuiz = quizRepository.GetQuizByUserID(sessionUser.UserId);
                return View("MyLearning", homeViewModel.lstActivities);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View("MyLearning");
            }

        }

        public ActionResult AssignCources()
        {
            //Admin -> show selected course details in popup with user list. 
            return View();
        }

        public ActionResult LaunchQuiz(int QuizId)
        {
            try
            {
                TblUser sessionUser = (TblUser)Session["UserSession"];
                //newException.AddDummyException("111");
                if (sessionUser == null)
                {
                    CommonFunctions common = new CommonFunctions();
                    var password = common.GetEncodePassword("123456");
                    sessionUser = ur.IsValidUser("Don@gmail.com", password);
                    //Session["UserSession"] = sessionUser;
                    //newException.AddDummyException("222");
                }
                List<TblQuiz> lstAllQuiz = new List<TblQuiz>();
                lstAllQuiz = quizRepository.GetQuizForLaunch(QuizId, sessionUser.UserId);
                //newException.AddDummyException("333");

                JavaScriptSerializer json_serializer = new JavaScriptSerializer();
                lstAllQuiz[0].hdnLaunchData = json_serializer.Serialize(lstAllQuiz[0]);
                //newException.AddDummyException(lstAllQuiz[0].QuizDescription);
                return View("LaunchQuizNew", lstAllQuiz[0]);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return View("LaunchQuizNew");
            }
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
            if (sessionUser == null)
            {
                CommonFunctions common = new CommonFunctions();
                var password = common.GetEncodePassword("123456");
                sessionUser = ur.IsValidUser("Don@gmail.com", password);
                newException.AddDummyException("Login");
            }
            if (sessionUser.RoleId == 2)
            {
                int result = quizRepository.DeleteResponse(objQuiz.QuizId, sessionUser.UserId, 1);
            }
            List<QueOptions> lstQueOptions = new List<QueOptions>();
            object[] objQueResponse = (object[])json_serializer.DeserializeObject(objQuiz.hdnResponseData);
            var attempt = quizRepository.GetQuizAttemptByUserID(objQuiz.QuizId, sessionUser.UserId);
            attempt = attempt + 1;

            if (objQuiz.completeTime == "0")
            {
                var durationInSeconds = Convert.ToInt32(objQuiz.Duration) * 60;
                TimeSpan t = TimeSpan.FromSeconds(durationInSeconds);
                objQuiz.completeTime = string.Format("{0:D2}:{1:D2}", (int)t.Minutes, t.Seconds);
            }
            else
            {

                var cTime = objQuiz.completeTime;
                int index1 = cTime.IndexOf(":");
                int index2 = cTime.IndexOf("Minutes");
                int index3 = cTime.IndexOf(",");
                int index4 = cTime.IndexOf("Seconds");
                var cMin = cTime.Substring(index1 + 1, (index2 - (index1 + 2)));
                var cSec = cTime.Substring(index3 + 1, (index4 - (index3 + 2)));
                var remainingTime = (Convert.ToInt32(cMin) * 60) + Convert.ToInt32(cSec);
                remainingTime = Convert.ToInt32(objQuiz.Duration * 60) - remainingTime;
                TimeSpan t = TimeSpan.FromSeconds(remainingTime);
                objQuiz.completeTime = string.Format("{0:D2}:{1:D2}", (int)t.Minutes, t.Seconds);
            }


            foreach (var item in objQueResponse)
            {
                QuizResponse quizResponse = new QuizResponse();
                quizResponse.QuizId = objQuiz.QuizId;
                quizResponse.UserId = sessionUser.UserId;
                quizResponse.Attempt = attempt;

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
                                if (correctCount == correct)
                                {
                                    score++;
                                }
                            }
                        }
                    }
                }
            }

            var scoreResult = quizRepository.CaptureScore(objQuiz, sessionUser.UserId, score, attempt);

            var emailBody = "Thank you for taking Quiz. </br> Your score is " + ((score * 100) / lstAllQuiz[0].TblQuestions.Count) + "% <br />";
            var emailSubject = "Quiz Result";
            tblEmails objEmail = new tblEmails();
            objEmail.EmailTo = sessionUser.EmailId;
            objEmail.EmailSubject = emailSubject;
            objEmail.EmailBody = emailBody;

            var emailResult = ur.InsertEmail(objEmail);

            newException.AddDummyException("Responses Saved Successfully");
            TempData["Message"] = "Responses Saved Successfully";
            return RedirectToAction("ReviewQuiz", new { @QuizId = objQuiz.QuizId});
        }

        public ActionResult RatingAndFeedback(int ActivityId, string LearningType)
        {
            tblRatings objRating = new tblRatings();
            objRating.ActivityId = ActivityId;
            objRating.ActivityType = LearningType;
            //objRating.Attempt = attempt;
            return View(objRating);
        }

        public ActionResult SubmitRating(tblRatings objRating)
        {
            TblUser sessionUser = (TblUser)Session["UserSession"];
            objRating.UserId = sessionUser.UserId;
            objRating.TenantId = sessionUser.TenantId;
            //objRating.ActivityType = "Quiz";
            var result = quizRepository.CaptureRatings(objRating);
            return RedirectToAction("MyAssignments");
        }
       
        public ActionResult ReviewQuiz(int QuizId)
        {
            TblUser sessionUser = (TblUser)Session["UserSession"];
            if (sessionUser == null)
            {
                CommonFunctions common = new CommonFunctions();
                var password = common.GetEncodePassword("123456");
                sessionUser = ur.IsValidUser("Don@gmail.com", password);
                //newException.AddDummyException("222");
            }
            List<TblQuiz> lstAllQuiz = new List<TblQuiz>();

            newException.AddDummyException("222");
            newException.AddDummyException(Convert.ToString(sessionUser.UserId));

            lstAllQuiz = quizRepository.GetQuizForLaunch(QuizId, sessionUser.UserId);
            var attempt = quizRepository.GetQuizAttemptByUserID(QuizId, sessionUser.UserId);
            List<TblRespons> quizResponses = new List<TblRespons>();
            quizResponses = quizRepository.GetQuizResponsesByUserID(QuizId, sessionUser.UserId, attempt);
            lstAllQuiz[0].TblResponses = quizResponses;

            var score = quizRepository.GetQuizScoreByUserID(QuizId, sessionUser.UserId, attempt);
            lstAllQuiz[0].Score = Convert.ToInt32(score.Score);

            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            lstAllQuiz[0].hdnReviewData = json_serializer.Serialize(lstAllQuiz[0]);
            return View("ReviewQuizLearner", lstAllQuiz[0]);
        }
    }
}