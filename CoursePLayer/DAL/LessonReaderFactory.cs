using System.Xml;


namespace HRS.CoursePlayer
{
    public class LessonReaderFactory
    {
        private ActivityContentType _courseType;
        public LessonReaderFactory(ActivityContentType courseType)
        {
            _courseType = courseType;
        }
        public LessonReader GetLessonReader(XmlNode lessonNode, int masteryScore)
        {
            switch (_courseType)
            {
                case ActivityContentType.Scorm12:
                case ActivityContentType.Scorm2004:
                    return new ScoReader(lessonNode, masteryScore);
                case ActivityContentType.AICC:
                    return new AuReader(lessonNode, masteryScore);
            }
            return null;
        }
    }
}
