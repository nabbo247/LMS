using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMSBL.DBModels;

namespace LMSBL
{
    public class Response
    {
        public string ResponseText { get; set; }
        public bool ResponseStatus { get; set; }
        public tblTenant tblTenant { get; set; }
        public List<tblTenant> lstTenants { get; set; }
        public List<tblUser> lstUsers { get; set; }
        public List<tblUserRole> lstUserRoles { get; set; }
        public List<tblStatus> lstStatus { get; set; }
        public List<tblCourse> lstCourses { get; set; }
        public List<tblNotificationTemplate> lstNotificationTemplate { get; set; }
        public List<tblAssignmentAndTracking> lstAssignmentAndTracking { get; set; }        

    }
}
