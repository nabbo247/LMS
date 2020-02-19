using System;
using System.Xml;


namespace HRS.CoursePlayer
{
    public class AuReader : LessonReader
    {
        public AuReader(XmlNode lessonNode, int masteryScore) : base(lessonNode, masteryScore)
        {
        }

        public override Lesson ReadLesson()
        {
            var au = new Au
                         {
                             AuPassword = SnagValue("au_password"),
                             CoreVendor = SnagValue("core_vendor"),
                             MaxTimeAllowed = GetTime(SnagValue("max_time_allowed")),
                             TimeLimitAction = SnagValue("time_limit_action")
                         };
            FillStandardProperties(au);
            var resourceElement = GetResourceElement(au.Identifier);
            if (resourceElement != null)
            {
                au.Href = resourceElement.GetAttribute("href");
                au.WebLaunch = resourceElement.GetAttribute("web_launch");
            }
            return au;
        }

        private string SnagValue(string nodeName)
        {
            var xmlNode = ItemElement.SelectSingleNode(nodeName);
            if (xmlNode == null) return String.Empty;
            return xmlNode.InnerText;
        }
    }
}
