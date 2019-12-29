using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace LMSBL.DBModels
{
    public class QuizResponse
    {
        public int ResponseId { get; set; }

        public int QuizId { get; set; }

        public int QuestionId { get; set; }

        public int UserId { get; set; }

        public string OptionIds { get; set; }

        public string QuestionFeedback { get; set; }

        public int Attempt { get; set; }
    }
}