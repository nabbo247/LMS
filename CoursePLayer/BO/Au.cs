using System;
namespace HRS.CoursePlayer
{
   [Serializable] public class Au : Lesson
    {
        public string Href { get; set; }
        public string WebLaunch { get; set; }
        public string AuPassword { get; set; }
        public string CoreVendor { get; set; }
    }
}
