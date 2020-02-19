using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LMSBL.Common;
using LMSBL.DBModels;
using LMSBL.Repository;

namespace LMSWeb.ViewModel
{
    public class QuizAssignViewModel
    {
        public int[] userIds { get; set; }
        public List<SelectListItem> usetList { get; set; }
        public List<TblUser> lstUsers { get; set; }
        public TblQuiz quiz { get; set; }
        public DateTime DueDate { get; set; }
    }
    public class CourseAssignViewModel
    {
        public int[] userIds { get; set; }
        public List<SelectListItem> usetList { get; set; }
        public List<TblUser> lstUsers { get; set; }
        public tblCourse course { get; set; }
        public DateTime DueDate { get; set; }
    }
}