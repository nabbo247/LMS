using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;


namespace HRS.CoursePlayer
{
    public class CourseDAL
    {
        public static List<Course> GetUserContentModule(CurriculumGeneral Curriculum)
        {
            try
            {
                Course objContentModule;
                List<Course> lstContentModule = new List<Course>();
                DbProviderFactory fact = DbProviderFactories.GetFactory("System.Data.SqlClient");
                //string LearnerID = "";
                using (DbConnection conn = Config.GetConnection())
                {
                    DbCommand cmd = fact.CreateCommand();
                    cmd.CommandTimeout = 0;
                    cmd.Connection = conn;
                    cmd.CommandText = "GetUserContentModule";
                    cmd.Parameters.Add(Config.GetParameter(fact, "@LearnerId", Curriculum.LearnerId));
                    cmd.Parameters.Add(Config.GetParameter(fact, "@CurriculumId", Curriculum.CurriculumId));
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            objContentModule = new Course();
                            objContentModule.ActivityId = reader["ActivityId"].ToString();
                            objContentModule.CurriculumId = Curriculum.CurriculumId;
                            objContentModule.ContentModuleName = reader["ContentModuleName"].ToString();
                            objContentModule.ContentModuleDescription = reader["ContentModuleDescription"].ToString();
                            objContentModule.ContentTrackId = reader["ContentTrackId"].ToString();
                            objContentModule.CompletionStatus = reader["CompletionStatus"].ToString();
                            objContentModule.DateOfCompletion = reader["DateOfCompletion"].ToString();
                            objContentModule.DateOfStart = reader["DateOfStart"].ToString();
                            objContentModule.NoOfPagesCompleted = reader["NoOfPagesCompleted"].ToString();
                            objContentModule.percentCompleted = reader["percentCompleted"].ToString();
                            objContentModule.TotalNoOfPages = reader["TotalNoOfPages"].ToString();
                            objContentModule.Score = reader["Score"].ToString();
                            objContentModule.PassFailStatus = reader["PassFailStatus"].ToString();
                            objContentModule.IsHTML5 = reader["IsHTML5"].ToString();
                            objContentModule.DisplayOrder = reader["DisplayOrder"].ToString();
                            lstContentModule.Add(objContentModule);
                        }
                    }
                }
                return lstContentModule;
            }
            catch (Exception ex)
            {
                clsErrorhandling objerror = new clsErrorhandling();
                objerror.LogException(ex, "ContentModule", "GetUserContentModule");
                return null;
            }
        }

        public static Course GetUserContentModuleTracking(Course objCourse)
        {
            try
            {
                Course objContentModuleTracking = new Course();
                DbProviderFactory fact = DbProviderFactories.GetFactory("System.Data.SqlClient");
                //string LearnerID = "";
                using (DbConnection conn = Config.GetConnection())
                {
                    DbCommand cmd = fact.CreateCommand();
                    cmd.CommandTimeout = 0;
                    cmd.Connection = conn;
                    cmd.CommandText = "procGetActivityDetails";
                    cmd.Parameters.Add(Config.GetParameter(fact, "@LearnerId", objCourse.LearnerId));
                    cmd.Parameters.Add(Config.GetParameter(fact, "@ActivityId", objCourse.ActivityId));
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            objContentModuleTracking = new Course();
                            if (Convert.ToString(reader["message"]) == "success")
                            {
                                objContentModuleTracking.ActivityId = reader["ActivityId"].ToString();
                                objContentModuleTracking.LearnerId = reader["LearnerId"].ToString();
                                objContentModuleTracking.ContentTrackId = reader["ContentTrackId"].ToString();
                                objContentModuleTracking.CompletionStatus = reader["CompletionStatus"].ToString();
                                objContentModuleTracking.RetMessage ="success";
                            }
                            else
                            {
                                objContentModuleTracking.RetMessage = Convert.ToString(reader["message"]);
                            }
                            //objContentModuleTracking.Add(objContentModule);
                        }
                    }
                }
                return objContentModuleTracking;
            }
            catch (Exception ex)
            {
                clsErrorhandling objerror = new clsErrorhandling();
                objerror.LogException(ex, "ContentModule", "GetUserContentModule");
                return null;
            }
        }

      public static List<Course> GetOtherCurriculumModule(Learner learner)
      {
          try
          {
              Course objContentModule;
              List<Course> lstContentModule = new List<Course>();
              DbProviderFactory fact = DbProviderFactories.GetFactory("System.Data.SqlClient");
              //string LearnerID = "";
              using (DbConnection conn = Config.GetConnection())
              {
                  DbCommand cmd = fact.CreateCommand();
                  cmd.CommandTimeout = 0;
                  cmd.Connection = conn;
                  cmd.CommandText = "Getothercurriculum";
                  cmd.Parameters.Add(Config.GetParameter(fact, "@LearnerId", learner.LearnerId));
                  cmd.CommandType = CommandType.StoredProcedure;
                  using (DbDataReader reader = cmd.ExecuteReader())
                  {
                      while (reader.Read())
                      {
                          objContentModule = new Course();
                          objContentModule.ActivityId = reader["ActivityId"].ToString();
                          objContentModule.CurriculumId = reader["curriculumid"].ToString();
                          objContentModule.ContentModuleName = reader["ContentModuleName"].ToString();
                          objContentModule.ContentModuleDescription = reader["ContentModuleDescription"].ToString();
                          objContentModule.ContentTrackId = reader["ContentTrackId"].ToString();
                          objContentModule.CompletionStatus = reader["CompletionStatus"].ToString();
                          objContentModule.DateOfCompletion = reader["DateOfCompletion"].ToString();
                          objContentModule.DateOfStart = reader["DateOfStart"].ToString();
                          objContentModule.NoOfPagesCompleted = reader["NoOfPagesCompleted"].ToString();
                          objContentModule.percentCompleted = reader["percentCompleted"].ToString();
                          objContentModule.TotalNoOfPages = reader["TotalNoOfPages"].ToString();
                          objContentModule.Score = reader["Score"].ToString();
                          objContentModule.PassFailStatus = reader["PassFailStatus"].ToString();
                          objContentModule.IsHTML5 = reader["IsHTML5"].ToString();
                          lstContentModule.Add(objContentModule);
                      }
                  }
              }
              return lstContentModule;
          }
          catch (Exception ex)
          {
              clsErrorhandling objerror = new clsErrorhandling();
              objerror.LogException(ex, "ContentModule", "GetOtherCurriculumModule");
              return null;
          }
      }

      
    }
}
