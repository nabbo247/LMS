using System;
using System.Xml;


namespace HRS.CoursePlayer
{
    public abstract class LessonReader
    {
        protected XmlDocument ManifestXml;
        protected XmlElement ItemElement;
        protected int MasteryScore;
        protected string IdentifierRef;

        public LessonReader(XmlNode lessonNode, int masteryScore)
        {
            ManifestXml = lessonNode.OwnerDocument;
            ItemElement = (XmlElement)lessonNode;
            var masteryNode = ItemElement.SelectSingleNode("masteryscore");
            if (masteryScore <= 0 && masteryNode != null)
            {
                int.TryParse(masteryNode.InnerText, out masteryScore);
            }
            MasteryScore = masteryScore;
        }

        public abstract Lesson ReadLesson();

        protected XmlElement GetResourceElement(string identifier)
        {
            return ManifestXml.SelectSingleNode("/manifest/resources/resource[@identifier='" + identifier.Trim() + "']") as XmlElement;
        }

        protected TimeSpan? GetTime(string time)
        {
            if (String.IsNullOrEmpty(time))
                return null;
            return new AiccTime(time).Time;
        }

        protected void FillStandardProperties(Lesson lesson)
        {
            var titleNode = ItemElement.SelectSingleNode("title");
            lesson.Title = titleNode == null ? String.Empty : titleNode.InnerText;
            lesson.Identifier = ItemElement.GetAttribute("identifier");
            lesson.MasteryScore = MasteryScore;
        }
    }
}
