using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Web;
using LMSBL.Common;
using LMSBL.DBModels;

namespace LMSBL.Repository
{
    public class ReportRepository
    {
        DataRepository db = new DataRepository();
        Exceptions newException = new Exceptions();
        public List<MainReportModel> GetMainReportForLearner(int userId, int tenantId)
        {
            try
            {
                db.parameters.Clear();
                db.AddParameter("@tenantId", SqlDbType.Int, tenantId);
                db.AddParameter("@UserId", SqlDbType.Int, userId);
                DataSet ds = db.FillData("sp_MainReportList");

                List<MainReportModel> mainRpt = ds.Tables[0].AsEnumerable().Select(dr => new MainReportModel
                {
                    ActivityId = Convert.ToInt32(dr["ActivityId"]),
                    ActivityName = Convert.ToString(dr["ActivityName"]),
                    ActivityType = Convert.ToString(dr["ActivityType"]),
                    ActivityDuration = Convert.ToString(dr["ActivityDuration"]),
                    ActivityAttemptedDate = Convert.ToString(dr["ActivityAttemptedDate"]),
                    ActivityAttempts = Convert.ToString(dr["ActivityAttempts"]),
                    ActivityScore = Convert.ToString(dr["ActivityScore"]),
                    ActivityQuestionCount = Convert.ToString(dr["ActivityQuestionCount"]),
                    ActivityCompletionTime = Convert.ToString(dr["ActivityCompletionTime"])

                }).ToList();
                return mainRpt;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }

        }

        public List<MainReportModel> GetDetailReportForLearner(int userId, int tenantId, int activityId)
        {
            try
            {
                db.parameters.Clear();
                db.AddParameter("@tenantId", SqlDbType.Int, tenantId);
                db.AddParameter("@UserId", SqlDbType.Int, userId);
                db.AddParameter("@ActivityId", SqlDbType.Int, activityId);
                DataSet ds = db.FillData("sp_DetailReportList");

                List<MainReportModel> mainRpt = ds.Tables[0].AsEnumerable().Select(dr => new MainReportModel
                {
                    ActivityId = Convert.ToInt32(dr["ActivityId"]),
                    ActivityName = Convert.ToString(dr["ActivityName"]),
                    ActivityType = Convert.ToString(dr["ActivityType"]),
                    ActivityDuration = Convert.ToString(dr["ActivityDuration"]),
                    ActivityAttemptedDate = Convert.ToString(dr["ActivityAttemptedDate"]),
                    ActivityAttempts = Convert.ToString(dr["ActivityAttempts"]),
                    ActivityScore = Convert.ToString(dr["ActivityScore"]),
                    ActivityQuestionCount = Convert.ToString(dr["ActivityQuestionCount"]),
                    ActivityCompletionTime = Convert.ToString(dr["ActivityCompletionTime"])

                }).ToList();
                return mainRpt;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }

        }

        public List<UserReportModel> GetUserReportForAdmin(int tenantId, bool isActive)
        {
            try
            {
                db.parameters.Clear();
                db.AddParameter("@tenantId", SqlDbType.Int, tenantId);
                db.AddParameter("@isActive", SqlDbType.Bit, isActive);

                DataSet ds = db.FillData("sp_AdminUserReport");

                List<UserReportModel> mainUserRpt = ds.Tables[0].AsEnumerable().Select(dr => new UserReportModel
                {
                    UserId = Convert.ToInt32(dr["UserId"]),
                    FullName = Convert.ToString(dr["FullName"]),
                    EmailId = Convert.ToString(dr["emailId"]),
                    PhoneNo = Convert.ToString(dr["contactNo"]),
                    LearningAssigned = Convert.ToString(dr["assigned"]),
                    isActive = Convert.ToBoolean(dr["isActive"]),
                    DateCreated = Convert.ToString(dr["createdOn"]),
                    LastLogin = Convert.ToString(dr["LastLogin"])                   


                }).ToList();
                return mainUserRpt;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }

        }

        public List<UserProgressReportModel> GetUserProgressReportForAdmin(int tenantId, int UserId)
        {
            try
            {
                db.parameters.Clear();
                db.AddParameter("@tenantId", SqlDbType.Int, tenantId);
                db.AddParameter("@UserId", SqlDbType.Int, UserId);

                DataSet ds = db.FillData("sp_UserProgressReport");

                List<UserProgressReportModel> mainUserProgressRpt = ds.Tables[0].AsEnumerable().Select(dr => new UserProgressReportModel
                {
                    ActivityId = Convert.ToInt32(dr["ActivityId"]),
                    LearningName = Convert.ToString(dr["LearningName"]),
                    LearningType = Convert.ToString(dr["LearningType"]),
                    ActivityStatus = Convert.ToString(dr["ActivityStatus"]),
                    Attempts = Convert.ToString(dr["Attempts"]),
                    Score = Convert.ToString(dr["Score"]),
                    QuestionCount = Convert.ToInt32(dr["QuestionCount"]),
                    AttemptedOn = Convert.ToString(dr["AttemptedOn"]),
                    Rating = Convert.ToString(dr["Rating"]),
                    Comments = Convert.ToString(dr["Comments"]),
                    Duration = Convert.ToString(dr["Duration"]),
                    CompletionTime = Convert.ToString(dr["CompletionTime"])


                }).ToList();
                return mainUserProgressRpt;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }

        }

        public List<LearningCompletionReportModel> GetLearningCompletionReportForAdmin(int tenantId)
        {
            try
            {
                db.parameters.Clear();
                db.AddParameter("@tenantId", SqlDbType.Int, tenantId);                

                DataSet ds = db.FillData("sp_LearningCompletionReport");

                List<LearningCompletionReportModel> mainLearningCompletionRpt = ds.Tables[0].AsEnumerable().Select(dr => new LearningCompletionReportModel
                {
                    ActivityId = Convert.ToInt32(dr["ActivityId"]),
                    ActivityName = Convert.ToString(dr["ActivityName"]),
                    ActivityType = Convert.ToString(dr["ActivityType"]),
                    ActivityDescription = Convert.ToString(dr["ActivityDescription"]),
                    ActivityUserCount = Convert.ToString(dr["ActivityUserCount"]),                    
                    ActivityLearningAssigned = Convert.ToString(dr["ActivityLearningAssigned"])

                }).ToList();
                return mainLearningCompletionRpt;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }
        }

        public List<LearningCompletionProgressReportModel> GetLearningCompletionProgressReportForAdmin(int tenantId, int activityId, string type)
        {
            try
            {
                db.parameters.Clear();
                db.AddParameter("@tenantId", SqlDbType.Int, tenantId);
                db.AddParameter("@activityId", SqlDbType.Int, activityId);
                db.AddParameter("@type", SqlDbType.NVarChar, type);

                DataSet ds = db.FillData("sp_LearningProgressCompletionReport");

                List<LearningCompletionProgressReportModel> mainLearningCompletionProgressRpt = ds.Tables[0].AsEnumerable().Select(dr => new LearningCompletionProgressReportModel
                {
                    FullName = Convert.ToString(dr["FullName"]),
                    CompletionDate = Convert.ToString(dr["CompletionDate"]),
                    DueDate = Convert.ToString(dr["DueDate"]),
                    ActivityDuration = Convert.ToString(dr["ActivityDuration"]),
                    ActivityStatus = Convert.ToString(dr["ActivityStatus"]),
                    TimeSpent = Convert.ToString(dr["TimeSpent"]),
                    Rating = Convert.ToString(dr["Rating"]),
                    Comments = Convert.ToString(dr["Comments"])

                }).ToList();
                return mainLearningCompletionProgressRpt;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }

        }

        public List<HighScoreUsersReportModel> GetHighScoreUsersReportForAdmin(int tenantId)
        {
            try
            {
                db.parameters.Clear();
                db.AddParameter("@tenantId", SqlDbType.Int, tenantId);               

                DataSet ds = db.FillData("sp_HighScoreUsersReport");
                List<HighScoreUsersReportModel> highScoreUsersReport = ds.Tables[0].AsEnumerable().Select(dr => new HighScoreUsersReportModel
                {
                    ActivityName = Convert.ToString(dr["ActivityName"]),
                    ActivityType = Convert.ToString(dr["ActivityType"]),
                    FullName = Convert.ToString(dr["FullName"]),
                    Score = Convert.ToString(dr["Score"]),
                    TotalQuestion = Convert.ToString(dr["TotalQuestion"]),
                    CompletedTime = Convert.ToString(dr["completedTime"]),
                    Duration = Convert.ToString(dr["duration"])

                }).ToList();
                return highScoreUsersReport;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }

        }

    }
}
