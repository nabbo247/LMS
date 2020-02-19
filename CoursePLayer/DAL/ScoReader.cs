using System.Xml;


namespace HRS.CoursePlayer
{
    public class ScoReader : LessonReader
    {
        public ScoReader(XmlNode lessonNode, int masteryScore) : base(lessonNode, masteryScore)
        {
        }

        public override Lesson ReadLesson()
        {
            var sco = new Sco
            {
                DataFromLms = ItemElement.GetAttribute("datafromlms"),
                MaxTimeAllowed = GetTime(ItemElement.GetAttribute("maxtimeallowed")),
                TimeLimitAction = ItemElement.GetAttribute("timelimitaction"),
                Prerequisites = ItemElement.GetAttribute("prerequisites"),
                TargetWindow = ItemElement.GetAttribute("winTarget")
            };
            FillStandardProperties(sco);

            var identifierRef = ItemElement.GetAttribute("identifierref");
            var resourceElement = GetResourceElement(identifierRef);

            if (resourceElement != null)
            {
                sco.Resource = new ScormResource
                {
                    Base = resourceElement.GetAttribute("base"),
                    Href = resourceElement.GetAttribute("href"),
                    Identifier = IdentifierRef,
                    ScormType = resourceElement.GetAttribute("scormtype"),
                    Type = resourceElement.GetAttribute("type")
                };
            }
            return sco;
        }
    }
}
