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
}
