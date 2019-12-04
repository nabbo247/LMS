using System;
using System.Collections.Generic;
using System.Linq;
using LMSBL.DBModels;
using System.Data;
using System.Data.SqlClient;

namespace LMSBL.Repository
{
    public class QuizRepository
    {
        DataRepository db = new DataRepository();

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
                    QuizDescription = Convert.ToString(dr["QuizDescription"])
                }).ToList();
                return quizDetails;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TblQuiz> GetQuizByID(int QuizId)
        {
            try
            {
                db.AddParameter("@QuizId", SqlDbType.Int, QuizId);

                DataSet ds = db.FillData("sp_GetQuizByID");
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
                throw;
            }

        }
        public int CreateQuiz(TblQuiz obj)
        {
            int status = 0;
            try
            {
                db.AddParameter("@QuizName", SqlDbType.Text, obj.QuizName);
                db.AddParameter("@QuizDescription", SqlDbType.Text, obj.QuizDescription);
                db.AddParameter("@tenantId", SqlDbType.Int, obj.TenantId);
                db.AddParameter("@QuizId", SqlDbType.Int, ParameterDirection.Output);
                status = db.ExecuteQuery("sp_QuizAdd");
                if (Convert.ToInt32(db.parameters[3].Value) > 0)
                {
                    int quizId = Convert.ToInt32(db.parameters[3].Value);
                    foreach (Dictionary<string, object> item in obj.questionObject)
                    {
                        int queId = 0;
                        db.parameters.Clear();
                        db.AddParameter("@QuizId", SqlDbType.Int, quizId);
                        db.AddParameter("@QuestionTypeId", SqlDbType.Int, Convert.ToInt32(item["QuestionTypeId"]));
                        db.AddParameter("@QuestionText", SqlDbType.Text, item["QuestionText"]);
                        db.AddParameter("@QuestionId", SqlDbType.Int, ParameterDirection.Output);
                        queId = db.ExecuteQuery("sp_QuestionAdd");
                        if (Convert.ToInt32(db.parameters[3].Value) > 0)
                        {
                            queId = Convert.ToInt32(db.parameters[3].Value);
                            foreach (Dictionary<string, object> itemNew1 in (object[])item["Options"])
                            {
                                int optionId = 0;
                                db.parameters.Clear();
                                db.AddParameter("@QuestionId", SqlDbType.Int, queId);
                                db.AddParameter("@OptionText", SqlDbType.Text, itemNew1["OptionText"]);
                                db.AddParameter("@CorrectOption", SqlDbType.Bit, Convert.ToBoolean(itemNew1["CorrectOption"]));
                                db.AddParameter("@OptionId", SqlDbType.Int, ParameterDirection.Output);
                                optionId = db.ExecuteQuery("sp_OptionAdd");
                                if (Convert.ToInt32(db.parameters[3].Value) > 0)
                                {

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return status;
        }

        public int UpdateQuiz(TblQuiz obj)
        {
            int status = 0;
            try
            {
                db.AddParameter("@QuizId", SqlDbType.Int, obj.QuizId);
                db.AddParameter("@QuizName", SqlDbType.Text, obj.QuizName);
                db.AddParameter("@QuizDescription", SqlDbType.Text, obj.QuizDescription);
                status = db.ExecuteQuery("sp_QuizUpdate");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return status;
        }
    }
}
