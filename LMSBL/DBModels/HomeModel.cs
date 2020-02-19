using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBL.DBModels
{
    public class HomeModel
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string ActivityType { get; set; }
        public string ActivityDescription { get; set; }
        public string ActivityDuration { get; set; }
        public string ActivityStartDate { get; set; }
        public string ActivityCompletionDate { get; set; }
        public string ActivityStatus { get; set; }
    }
    public class AdminHomeListModel
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string ActivityType { get; set; }
        public string ActivityDescription { get; set; }
        public string ActivityDuration { get; set; }
        public string ActivityCreationDate { get; set; }
        public int ActivityAssignedUsers { get; set; }

    }
    public class AdminHomeCountModel
    {
        public int TotalUserCount { get; set; }
        public int ActiveUserCount { get; set; }
        public int TotalQuizCount { get; set; }
        public int TotalCourseCount { get; set; }
        public int TotalHighScoreQuizUserCount { get; set; }
        public int TotalHighScoreCourseUserCount { get; set; }

    }
}
