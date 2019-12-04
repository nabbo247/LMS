using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LMSBL.Common;
using LMSBL.DBModels;
using LMSBL.Repository;

namespace LMSWeb.ViewModel
{
    public class QuizViewModel
    {
        public List<TblQuestion> lstQuestions { get; set; }
    }
}