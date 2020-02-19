using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using LMSBL.DBModels;

namespace LMSWeb.ViewModel
{
    public class HomeViewModel
    {
        public int TotalCount { get; set; }
        public int NotStartedCount { get; set; }
        public int InProgressCount { get; set; }
        public int CompletedCount { get; set; }

        public List<HomeModel> lstActivities { get; set; }
    }

    public class AdminHomeViewModel
    {       
        public AdminHomeCountModel allCounts { get; set; }
        public List<AdminHomeListModel> lstActivities { get; set; }        
        
    }
}