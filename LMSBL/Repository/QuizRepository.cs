using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMSBL.DBModels;
using System.Data;
using LMSBL.Common;

namespace LMSBL.Repository
{
    public class QuizRepository
    {
        DataRepository db = new DataRepository();
        Exceptions newException = new Exceptions();


        public List<tblQuiz> GetAllQuiz(int tenantId)
        {
            try
            {
                db.AddParameter("@tenantId", SqlDbType.Int, tenantId);

                DataSet ds = db.FillData("GetAllQuiz");
                List<tblQuiz> quizDetails = ds.Tables[0].AsEnumerable().Select(dr => new tblQuiz
                {
                    QuizId = Convert.ToInt32(dr["QuizId"]),
                    QuizName = Convert.ToString(dr["QuizName"]),
                    QuizDescription = Convert.ToString(dr["QuizDescription"])                    
                }).ToList();
                return quizDetails;
            }
            catch (Exception ex)
            {
                newException.AddException(ex.Message, ex.StackTrace);
                return null;
            }
        }
    }
}
