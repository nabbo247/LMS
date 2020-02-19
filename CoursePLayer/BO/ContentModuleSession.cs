using System;

namespace HRS.CoursePlayer
{
    public enum LaunchSite
    {
        Learner,
        Admin
    }
   [Serializable] public class ContentModuleSession
    {
        public string ContentModuleId { get; set; }

        public string SystemUserGuid { get; set; }

        public string SessionId { get; set; }

        public int? Attempt { get; set; }

        public LaunchSite LaunchSite { get; set; }

        public bool IsReview { get; set; }

        public bool SsoLogin { get; set; }

        public bool SameWindow { get; set; }

        public string ReturnUrl { get; set; }

        public int? GridPageSize { get; set; }

        public DateTime Expiration { get; set; }

        public Learner Learner { get; set; }

        public ContentModule ContentModule { get; set; }

        public ActivityAssignment Assignment { get; set; }

        public ContentModuleTracking ContentModuleTracking { get; set; }
    }
}
