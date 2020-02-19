using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;


namespace HRS.CoursePlayer
{
    public class CurriculumGeneralDAL
    {
        public static List<CurriculumGeneral> GetUserCurriculum(Learner objLeaner)
        {
            try
            {
                CurriculumGeneral objCurriculumGeneral;
                List<CurriculumGeneral> lstCurriculumGeneral = new List<CurriculumGeneral>();
                DbProviderFactory fact = DbProviderFactories.GetFactory(Config.DbType);
                //string LearnerID = "";
                using (DbConnection conn = Config.GetConnection())
                {
                    DbCommand cmd = fact.CreateCommand();
                    cmd.CommandTimeout = 0;
                    cmd.Connection = conn;
                    cmd.CommandText = "GetUserCurriculum";
                    cmd.Parameters.Add(Config.GetParameter(fact, "@LearnerId", objLeaner.LearnerId));
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            objCurriculumGeneral = new CurriculumGeneral();
                            objCurriculumGeneral.CurriculumId = reader["CurriculumId"].ToString();
                            objCurriculumGeneral.CurriculumName = reader["CurriculumName"].ToString();
                            objCurriculumGeneral.CurriculumDescription = reader["CurriculumDescription"].ToString();
                            //objCurriculumGeneral.CreateDate = reader["CreateDate"].ToString();
                            //objCurriculumGeneral.LastmodifiedDate = reader["LastmodifiedDate"].ToString();
                            objCurriculumGeneral.CurriculumTrackId = reader["CurriculumTrackId"].ToString();
                            objCurriculumGeneral.CompletionStatus = reader["CompletionStatus"].ToString();
                            objCurriculumGeneral.DateOfStart = reader["DateOfStart"].ToString();
                            objCurriculumGeneral.DateOfCompletion = reader["DateOfCompletion"].ToString();
                            objCurriculumGeneral.EnableSequencing = Convert.ToString(reader["enableSequencing"]);
                            objCurriculumGeneral.LearnerId = objLeaner.LearnerId;
                            lstCurriculumGeneral.Add(objCurriculumGeneral);
                        }
                    }
                }
                return lstCurriculumGeneral;
            }
            catch (Exception ex)
            {
                clsErrorhandling objerror = new clsErrorhandling();
                objerror.LogException(ex, "CurriculumGeneral", "GetUserCurriculum");
                return null;
            }
        }
    }
}
