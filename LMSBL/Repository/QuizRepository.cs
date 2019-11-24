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
    }
}
