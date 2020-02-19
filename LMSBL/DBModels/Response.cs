using System.Collections.Generic;
using LMSBL.DBModels;

namespace LMSBL
{
    public class Response
    {
        public string ResponseText { get; set; }
        public bool ResponseStatus { get; set; }
        public TblTenant TblTenant { get; set; }
        public List<TblTenant> LstTenants { get; set; }
        public List<TblUser> LstUsers { get; set; }
        public List<TblUserRole> LstUserRoles { get; set; }
        public List<TblStatus> LstStatus { get; set; }
        public List<tblCourse> LstCourses { get; set; }
        public List<TblNotificationTemplate> LstNotificationTemplate { get; set; }
        public List<TblAssignmentAndTracking> LstAssignmentAndTracking { get; set; }        

    }
}
