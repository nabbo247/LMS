using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LMSBL.Common;
using LMSBL.DBModels;
using LMSBL.Repository;

namespace LMSWeb.ViewModel
{
    public class MyLearningViewModel
    {
        public List<TblQuiz> lstQuiz { get; set; }
        public List<tblCourse> lstCourse { get; set; }

    }
}