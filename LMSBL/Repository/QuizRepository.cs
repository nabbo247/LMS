using System;
using System.Collections.Generic;
using System.Linq;
using LMSBL.DBModels;
using System.Data;
using System.Data.SqlClient;
using LMSBL.Common;

namespace LMSBL.Repository
{
    public class QuizRepository
    {
        DataRepository db = new DataRepository();
        Exceptions newException = new Exceptions();

        public List<TblQuiz> GetAllQuiz(int tenantId)
        {
            try
            {
                db.AddParameter("@tenantId", SqlDbType.Int, tenantId);

                DataSet ds = db.FillData("sp_GetQuizAll");
                List<TblQuiz> quizDetails = ds.Tables[0].AsEnumerable().Select(dr => new TblQuiz
                {
                    QuizId = Convert.ToInt32(dr["QuizId"]),
                    QuizName = Convert.ToString(dr["QuizName"]),
                    QuizDescription = Convert.ToString(dr["QuizDescription"]),
                    NoOfQuestion = Convert.ToInt32(dr["NoOfQuestion"]),
                    Duration = Convert.ToInt32(dr["Duration"])
                    
                }).ToList();
                return quizDetails;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }
        }

        public List<TblQuiz> GetQuizByID(int QuizId)
        {
            try
            {
                db.parameters.Clear();
                db.AddParameter("@QuizId", SqlDbType.Int, QuizId);

                DataSet ds = db.FillData("sp_GetQuizByID");
                List<TblQuiz> quizDetails = ds.Tables[0].AsEnumerable().Select(dr => new TblQuiz
                {
                    QuizId = Convert.ToInt32(dr["QuizId"]),
                    QuizName = Convert.ToString(dr["QuizName"]),
                    QuizDescription = Convert.ToString(dr["QuizDescription"]),
                    Duration = dr["Duration"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Duration"])
                }).ToList();

                List<TblQuestion> questionsDetails = ds.Tables[1].AsEnumerable().Select(dr => new TblQuestion
                {
                    QuizId = Convert.ToInt32(dr["QuizId"]),
                    QuestionId = Convert.ToInt32(dr["QuestionId"]),
                    QuestionTypeId = Convert.ToInt32(dr["QuestionTypeId"]),
                    QuestionText = Convert.ToString(dr["QuestionText"]),
                    CorrectFeedback = Convert.ToString(dr["CorrectFeedback"]),
                    InCorrectFeedback = Convert.ToString(dr["InCorrectFeedback"]),
                    isRandomOption = Convert.ToBoolean(dr["isRandomOption"])
                }).ToList();
                quizDetails[0].TblQuestions = questionsDetails;
                foreach (var question in questionsDetails)
                {

                    List<TblQuestionOption> optionDetails = ds.Tables[2].AsEnumerable().Select(dr => new TblQuestionOption
                    {
                        OptionId = Convert.ToInt32(dr["OptionId"]),
                        QuestionId = Convert.ToInt32(dr["QuestionId"]),
                        OptionText = Convert.ToString(dr["OptionText"]),
                        CorrectOption = Convert.ToBoolean(dr["CorrectOption"]),
                        OptionFeedback = Convert.ToString(dr["OptionFeedback"])
                    }).Where(c => c.QuestionId == question.QuestionId).ToList();

                    question.TblQuestionOptions = optionDetails;
                }
                return quizDetails;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }

        }

        public DataSet GetAssignedQuizUsers(int QuizId)
        {
            try
            {
                db.parameters.Clear();
                db.AddParameter("@QuizId", SqlDbType.Int, QuizId);
                DataSet ds = db.FillData("sp_GetAssignedUsers");
                return ds;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }
        }

        public int CreateQuiz(TblQuiz obj)
        {
            int status = 0;
            try
            {
                int quizId = 0;
                List<TblQuiz> lstQuiz = new List<TblQuiz>();
                if (obj.QuizId != 0)
                    lstQuiz = GetQuizByID(obj.QuizId);

                if (obj.QuizId > 0)
                {
                    db.parameters.Clear();
                    db.AddParameter("@QuizId", SqlDbType.Int, obj.QuizId);
                    db.AddParameter("@QuizName", SqlDbType.Text, obj.QuizName);
                    db.AddParameter("@QuizDescription", SqlDbType.Text, obj.QuizDescription);
                    db.AddParameter("@Duration", SqlDbType.Int, obj.Duration);
                    status = db.ExecuteQuery("sp_QuizUpdateDelete");
                    quizId = obj.QuizId;
                }
                else
                {
                    db.parameters.Clear();
                    db.AddParameter("@OldQuizId", SqlDbType.Int, obj.QuizId);
                    db.AddParameter("@QuizName", SqlDbType.Text, obj.QuizName);
                    db.AddParameter("@QuizDescription", SqlDbType.Text, obj.QuizDescription);
                    db.AddParameter("@Duration", SqlDbType.Int, obj.Duration);
                    db.AddParameter("@tenantId", SqlDbType.Int, obj.TenantId);
                    db.AddParameter("@QuizId", SqlDbType.Int, ParameterDirection.Output);
                    status = db.ExecuteQuery("sp_QuizAdd");
                    if (Convert.ToInt32(db.parameters[5].Value) > 0)
                    {
                        quizId = Convert.ToInt32(db.parameters[5].Value);
                    }
                }
                foreach (Dictionary<string, object> item in obj.questionObject)
                {
                    int queId = 0;
                    db.parameters.Clear();
                    var oldQuestionId = 0;
                    if (obj.QuizId != 0)
                    {

                        if (!string.IsNullOrEmpty(Convert.ToString(item["QuestionId"])))
                        {
                            oldQuestionId = Convert.ToInt32(item["QuestionId"]);
                        }
                        var isExist = false;
                        if (lstQuiz.Count > 0)
                        {
                            foreach (var question in lstQuiz[0].TblQuestions)
                            {
                                if (oldQuestionId == question.QuestionId)
                                {
                                    isExist = true;
                                    break;
                                }
                            }
                        }
                        if (!isExist)
                        {
                            oldQuestionId = 0;
                        }
                    }

                    db.AddParameter("@OldQuestionId", SqlDbType.Int, oldQuestionId);
                    db.AddParameter("@QuizId", SqlDbType.Int, quizId);
                    db.AddParameter("@QuestionTypeId", SqlDbType.Int, Convert.ToInt32(item["QuestionTypeId"]));
                    db.AddParameter("@QuestionText", SqlDbType.NText, item["QuestionText"]);
                    db.AddParameter("@CorrectFeedback", SqlDbType.Text, item["CorrectFeedback"]);
                    db.AddParameter("@InCorrectFeedback", SqlDbType.Text, item["InCorrectFeedback"]);
                    db.AddParameter("@isRandomOption", SqlDbType.Bit, Convert.ToBoolean(item["isRandomOption"]));
                    db.AddParameter("@QuestionId", SqlDbType.Int, ParameterDirection.Output);
                    queId = db.ExecuteQuery("sp_QuestionAdd");
                    if (Convert.ToInt32(db.parameters[7].Value) > 0)
                    {

                        queId = Convert.ToInt32(db.parameters[7].Value);
                        foreach (Dictionary<string, object> itemNew1 in (object[])item["Options"])
                        {
                            int optionId = 0;
                            db.parameters.Clear();
                            var OldOptionId = Convert.ToInt32(itemNew1["OptionId"]);

                            db.AddParameter("@OldOptionId", SqlDbType.Int, OldOptionId);
                            db.AddParameter("@QuestionId", SqlDbType.Int, queId);
                            db.AddParameter("@OptionText", SqlDbType.Text, itemNew1["OptionText"]);
                            db.AddParameter("@CorrectOption", SqlDbType.Bit, Convert.ToBoolean(itemNew1["CorrectOption"]));
                            db.AddParameter("@OptionFeedback", SqlDbType.Text, itemNew1["OptionFeedback"]);
                            db.AddParameter("@OptionId", SqlDbType.Int, ParameterDirection.Output);
                            optionId = db.ExecuteQuery("sp_OptionAdd");

                        }
                    }

                }
                if (quizId > 0)
                {
                    status = quizId;
                }
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                //throw ex;
                status = -2;
            }
            return status;
        }

        public int UpdateQuiz(TblQuiz obj)
        {
            int status = 0;
            try
            {
                status = CreateQuiz(obj);
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }
            return status;
        }

        public int DeleteResponse(int QuizId, int UserId, int Attempt)
        {
            int status = 0;
            try
            {
                db.parameters.Clear();
                db.AddParameter("@QuizId", SqlDbType.Int, QuizId);
                db.AddParameter("@UserId", SqlDbType.Int, UserId);
                db.AddParameter("@Attempt", SqlDbType.Int, Attempt);
                status = db.ExecuteQuery("sp_ResponseDelete");

            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }
            return status;
        }

        public int DeleteAssignedUser(int QuizId)
        {
            int status = 0;
            try
            {
                db.parameters.Clear();
                db.AddParameter("@QuizId", SqlDbType.Int, QuizId);
                status = db.ExecuteQuery("sp_DeleteAssignedUsers");
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }
            return status;
        }
        public int AssignQuiz(int QuizId, int UserId, DateTime DueDate)
        {
            int status = 0;
            try
            {
                db.parameters.Clear();
                db.AddParameter("@QuizId", SqlDbType.Int, QuizId);
                db.AddParameter("@UserId", SqlDbType.Int, UserId);
                db.AddParameter("@DueDate", SqlDbType.DateTime, DueDate);
                status = db.ExecuteQuery("sp_QuizAssign");                

            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }
            return status;
        }

        public List<TblQuiz> GetQuizByUserID(int UserId)
        {
            try
            {
                db.AddParameter("@UserId", SqlDbType.Int, UserId);

                DataSet ds = db.FillData("sp_QuizGetByUserId");
                List<TblQuiz> quizDetails = ds.Tables[0].AsEnumerable().Select(dr => new TblQuiz
                {
                    QuizId = Convert.ToInt32(dr["QuizId"]),
                    QuizName = Convert.ToString(dr["QuizName"]),
                    QuizDescription = Convert.ToString(dr["QuizDescription"])
                }).ToList();
                return quizDetails;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }

        }

        public List<TblQuiz> GetQuizForLaunch(int QuizId, int UserId)
        {
            try
            {
                db.parameters.Clear();
                db.AddParameter("@QuizId", SqlDbType.Int, QuizId);
                db.AddParameter("@UserId", SqlDbType.Int, UserId);

                DataSet ds = db.FillData("sp_QuizGetAllDetails");
                List<TblQuiz> quizDetails = ds.Tables[0].AsEnumerable().Select(dr => new TblQuiz
                {
                    QuizId = Convert.ToInt32(dr["QuizId"]),
                    QuizName = Convert.ToString(dr["QuizName"]),
                    QuizDescription = Convert.ToString(dr["QuizDescription"]),
                    Duration = dr["Duration"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Duration"])
                }).ToList();

                List<TblQuestion> questionsDetails = ds.Tables[1].AsEnumerable().Select(dr => new TblQuestion
                {
                    QuizId = Convert.ToInt32(dr["QuizId"]),
                    QuestionId = Convert.ToInt32(dr["QuestionId"]),
                    QuestionTypeId = Convert.ToInt32(dr["QuestionTypeId"]),
                    QuestionText = Convert.ToString(dr["QuestionText"]),
                    CorrectFeedback = Convert.ToString(dr["CorrectFeedback"]),
                    InCorrectFeedback = Convert.ToString(dr["InCorrectFeedback"]),
                    isRandomOption = Convert.ToBoolean(dr["isRandomOption"])
                }).ToList();
                quizDetails[0].TblQuestions = questionsDetails;
                foreach (var question in questionsDetails)
                {

                    List<TblQuestionOption> optionDetails = ds.Tables[2].AsEnumerable().Select(dr => new TblQuestionOption
                    {
                        OptionId = Convert.ToInt32(dr["OptionId"]),
                        QuestionId = Convert.ToInt32(dr["QuestionId"]),
                        OptionText = Convert.ToString(dr["OptionText"]),
                        CorrectOption = Convert.ToBoolean(dr["CorrectOption"]),
                        OptionFeedback = Convert.ToString(dr["OptionFeedback"])
                    }).Where(c => c.QuestionId == question.QuestionId).ToList();

                    question.TblQuestionOptions = optionDetails;
                }

                return quizDetails;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }

        }

        public int CaptureResponses(QuizResponse obj)
        {
            int status = 0;
            try
            {
                if (obj.OptionIds != null)
                {
                    db.parameters.Clear();
                    db.AddParameter("@QuestionId", SqlDbType.Int, obj.QuestionId);
                    db.AddParameter("@OptionIds", SqlDbType.Text, obj.OptionIds);
                    db.AddParameter("@QuestionFeedback", SqlDbType.Text, obj.QuestionFeedback);
                    db.AddParameter("@UserId", SqlDbType.Int, obj.UserId);
                    db.AddParameter("@QuizId", SqlDbType.Int, obj.QuizId);
                    db.AddParameter("@Attempt", SqlDbType.Int, obj.Attempt);                    
                    status = db.ExecuteQuery("sp_ResponseAdd");
                }

            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }
            return status;
        }

        public int CaptureScore(TblQuiz objQuiz, int userId, int score, int attempt)
        {
            int status = 0;
            try
            {
                db.parameters.Clear();
                db.AddParameter("@QuizId", SqlDbType.Int, objQuiz.QuizId);
                db.AddParameter("@UserId", SqlDbType.Int, userId);
                db.AddParameter("@Score", SqlDbType.Int, score);
                db.AddParameter("@Attempt", SqlDbType.Int, attempt);
                db.AddParameter("@completedTime", SqlDbType.Text, objQuiz.completeTime);
                status = db.ExecuteQuery("sp_QuizScoreAdd");

            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }
            return status;
        }


        public List<ReportModel> GetQuizReportByUserID(int TenantId, int UserId)
        {
            try
            {
                db.parameters.Clear();
                db.AddParameter("@TenantId", SqlDbType.Int, TenantId);
                db.AddParameter("@UserId", SqlDbType.Int, UserId);


                DataSet ds = db.FillData("sp_GetUserAssignment");
                List<ReportModel> quizReportDetails = ds.Tables[0].AsEnumerable().Select(dr => new ReportModel
                {
                    quizId = Convert.ToInt32(dr["quizId"]),
                    UserId = Convert.ToInt32(dr["UserId"]),
                    QuizName = Convert.ToString(dr["QuizName"]),
                    Name = Convert.ToString(dr["Name"]),
                    Score = Convert.ToInt32(dr["Score"]),
                    AttemptedDate = Convert.ToDateTime(dr["AttemptedDate"]),
                    Attempt = Convert.ToInt32(dr["Attempt"])

                }).ToList();
                return quizReportDetails;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return null;
                //throw ex;
            }

        }

        public int GetQuestionCount(int quizId)
        {
            int count = 0;
            db.parameters.Clear();
            db.AddParameter("@QuizId", SqlDbType.Int, quizId);

            DataSet ds = db.FillData("sp_GetQuestionCount");
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                }
            }
            return count;
        }
        public List<TblRespons> GetQuizResponsesByUserID(int quizId, int userId, int attempt)
        {
            try
            {
                db.parameters.Clear();
                db.AddParameter("@QuizId", SqlDbType.Int, quizId);
                db.AddParameter("@UserId", SqlDbType.Int, userId);
                db.AddParameter("@Attempt", SqlDbType.Int, attempt);

                DataSet ds = db.FillData("sp_GetUserQuizResponses");
                List<TblRespons> quizResponseDetails = ds.Tables[0].AsEnumerable().Select(dr => new TblRespons
                {
                    ResponseId = Convert.ToInt32(dr["ResponseId"]),
                    QuestionId = Convert.ToInt32(dr["QuestionId"]),
                    OptionIds = Convert.ToString(dr["OptionIds"]),
                    QuestionFeedback = Convert.ToString(dr["QuestionFeedback"]),
                    UserId = Convert.ToInt32(dr["UserId"]),
                    QuizId = Convert.ToInt32(dr["QuizId"])

                }).ToList();
                return quizResponseDetails;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }

        }


        public TblQuizScore GetQuizScoreByUserID(int quizId, int userId, int attempt)
        {
            TblQuizScore objQuizScore = new TblQuizScore();            
            try
            {
                db.parameters.Clear();
                db.AddParameter("@QuizId", SqlDbType.Int, quizId);
                db.AddParameter("@UserId", SqlDbType.Int, userId);
                db.AddParameter("@Attempt", SqlDbType.Int, attempt);

                DataSet ds = db.FillData("sp_QuizScoreGet");
                if (ds.Tables.Count > 0)
                {
                    objQuizScore.Score = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                    objQuizScore.completedTime = Convert.ToString(ds.Tables[0].Rows[0][1]);
                }
                return objQuizScore;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }

        }

        public int GetQuizAttemptByUserID(int quizId, int userId)
        {
            int attempt = 0;
            try
            {
                db.parameters.Clear();
                db.AddParameter("@QuizId", SqlDbType.Int, quizId);
                db.AddParameter("@UserId", SqlDbType.Int, userId);

                DataSet ds = db.FillData("sp_QuizAttemptGet");
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        attempt = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                    }
                    else
                        attempt = 0;
                }
                return attempt;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }

        }

        public int CaptureRatings(tblRatings objRatings)
        {
            int status = 0;

            try
            {
                db.parameters.Clear();
                db.AddParameter("@ActivityId", SqlDbType.Int, objRatings.ActivityId);
                db.AddParameter("@UserId", SqlDbType.Int, objRatings.UserId);
                db.AddParameter("@Attempt", SqlDbType.Int, objRatings.Attempt);
                db.AddParameter("@ActivityType", SqlDbType.Text, objRatings.ActivityType);
                db.AddParameter("@Rating", SqlDbType.Decimal, objRatings.Rating);
                db.AddParameter("@Comment", SqlDbType.NText, objRatings.Comment);
                db.AddParameter("@TenantId", SqlDbType.Int, objRatings.TenantId);

                status = db.ExecuteQuery("sp_RatingsAdd");

            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }
            return status;

        }


    }
}
