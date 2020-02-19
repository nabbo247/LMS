using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBL.DBModels
{
    public class UserReportModel
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNo { get; set; }
        public string LearningAssigned { get; set; }
        public bool isActive { get; set; }
        public string DateCreated { get; set; }
        public string LastLogin { get; set; }


    }
    public class UserProgressReportModel
    {
        public int ActivityId { get; set; }
        public string LearningName { get; set; }
        public string LearningType { get; set; }
        public string ActivityStatus { get; set; }
        public string Attempts { get; set; }
        public string Score { get; set; }
        public int QuestionCount { get; set; }
        public string AttemptedOn { get; set; }
        public string Rating { get; set; }
        public string Comments { get; set; }
        public string Duration { get; set; }
        public string CompletionTime { get; set; }

    }

    public class LearningCompletionReportModel
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string ActivityType { get; set; }
        public string ActivityDescription { get; set; }
        public string ActivityUserCount { get; set; }
        public string ActivityLearningAssigned { get; set; }        
    }

    public class LearningCompletionProgressReportModel
    {
       
        public string FullName { get; set; }
        public string CompletionDate { get; set; }
        public string DueDate { get; set; }
        public string ActivityDuration { get; set; }
        public string ActivityStatus { get; set; }
        public string TimeSpent { get; set; }
        public string Rating { get; set; }
        public string Comments { get; set; }
    }

    public class HighScoreUsersReportModel
    {
        public string ActivityName { get; set; }
        public string ActivityType { get; set; }
        public string FullName { get; set; }       
        public string Score { get; set; }
        public string TotalQuestion { get; set; }
        public string CompletedTime { get; set; }
        public string Duration { get; set; }
    }
}
