using System;
using System.Collections.Generic;
using System.Linq;
using LMSBL.DBModels;
using System.Data;

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
            try
            {               
                db.AddParameter("@QuizName", SqlDbType.Text, obj.QuizName);
                db.AddParameter("@QuizDescription", SqlDbType.Text, obj.QuizDescription);                
                db.AddParameter("@tenantId", SqlDbType.Int, obj.TenantId);
                return db.ExecuteQuery("sp_QuizAdd");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateQuiz(TblQuiz obj)
        {
            try
            {
                db.AddParameter("@QuizId", SqlDbType.Int, obj.QuizId);
                db.AddParameter("@QuizName", SqlDbType.Text, obj.QuizName);
                db.AddParameter("@QuizDescription", SqlDbType.Text, obj.QuizDescription);                
                return db.ExecuteQuery("sp_QuizUpdate");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
