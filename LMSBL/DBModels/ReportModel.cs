using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBL.DBModels
{
    public partial class ReportModel
    {
        public int quizId { get; set; }
        public int UserId { get; set; }
        public int Score { get; set; }
        public string Name { get; set; }
        public string QuizName { get; set; }

        public int QuestionCount { get; set; }

        public DateTime AttemptedDate { get; set; }
        public int Attempt { get; set; }

    }

    public class MainReportModel
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string ActivityType { get; set; }
        public string ActivityDuration { get; set; }
        public string ActivityAttemptedDate { get; set; }
        public string ActivityAttempts { get; set; }
        public string ActivityScore { get; set; }
        public string ActivityQuestionCount { get; set; }
        
        public string ActivityCompletionTime { get; set; }
    }
}
