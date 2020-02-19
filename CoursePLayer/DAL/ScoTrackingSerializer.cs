using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Xml.Linq;


namespace HRS.CoursePlayer
{
    public class ScoTrackingSerializer : ILessonTrackingSerializer
    {
        public Dictionary<string, LessonTracking> ReadLessonTracking(string userDataXml)
        {
            var trackingDocument = new XmlDocument();
            trackingDocument.LoadXml(userDataXml);
            var lessons = new Dictionary<string, LessonTracking>();
            var nodeList = trackingDocument.SelectNodes("//sco");
            if (nodeList == null) return lessons;
            foreach (XmlNode scoNode in nodeList)
            {
                var sco = ParseLesson(scoNode);
                lessons.Add(sco.Identifier, sco);
            }
            return lessons;
        }

        public string WriteLessonTracking(ContentModuleTracking contentModuleTracking)
        {
            var lessonTracking = contentModuleTracking.LessonTracking;
            var xDoc = new XDocument(new XElement("Root",
                    lessonTracking.Values.Select(t => new XElement("sco", new XAttribute("identifier", t.Identifier),
                        new XElement("cmi",
                            new XElement("core",
                                new XElement("student_id", new XCData(t.StudentId)),
                                new XElement("student_name", new XCData(t.StudentName)),
                                new XElement("lesson_location", new XCData(t.LessonLocation)),
                                new XElement("credit", t.Credit),
                                new XElement("lesson_status", t.LessonStatus),
                                new XElement("entry", t.Entry),
                                new XElement("score",
                                    new XElement("raw", t.RawScore.HasValue ? t.RawScore.ToString() : String.Empty),
                                    new XElement("max", t.MaxScore.HasValue ? t.MaxScore.ToString() : String.Empty),
                                    new XElement("min", t.MinScore.HasValue ? t.MinScore.ToString() : String.Empty)
                                    ),
                                new XElement("total_time", new AiccTime(t.TotalTime).ToString()),
                                new XElement("lesson_mode", t.LessonMode),
                                new XElement("exit", t.Exit),
                                new XElement("session_time", t.SessionTime.HasValue ? new AiccTime(t.SessionTime.Value).ToString() : String.Empty)
                             ),
                             new XElement("suspend_data", new XCData(t.SuspendData)),
                             new XElement("launch_data", new XCData(t.LaunchData)),
                             new XElement("comments", new XCData(t.Comments)),
                             new XElement("comments_from_lms", new XCData(t.CommentsFromLms)),
                             new XElement("objectives",
                                 new XElement("_count", t.Objectives.Count),
                                 t.Objectives.Select((o, i) => new XElement("_" + i, new XElement("id", o.Identifier),
                                 new XElement("score",
                                    new XElement("raw", o.RawScore.HasValue ? o.RawScore.ToString() : String.Empty),
                                    new XElement("max", o.MaxScore.HasValue ? o.MaxScore.ToString() : String.Empty),
                                    new XElement("min", o.MinScore.HasValue ? o.MinScore.ToString() : String.Empty)
                                 ),
                                 new XElement("status", o.Status)))
                             ),
                             new XElement("student_data",
                                 new XElement("mastery_score", t.MasteryScore),
                                 new XElement("max_time_allowed", t.MaxTimeAllowed.HasValue ? new AiccTime(t.MaxTimeAllowed.Value).ToString() : String.Empty),
                                 new XElement("time_limit_action", t.TimeLimitAction)
                                ),
                            new XElement("student_preference", //TODO: get these from somewhere
                                new XElement("audio"),
                                new XElement("language", "en-US"),
                                new XElement("speed"),
                                new XElement("text")
                            ),
                            new XElement("interactions",
                                new XElement("_count", "0")
                            )
                        )))));
            if (!String.IsNullOrEmpty(contentModuleTracking.Bookmark))
            {
                xDoc.Root.Add(new XAttribute("Bookmark", contentModuleTracking.Bookmark));
            }

            //return xDoc.ToString();
            return xDoc.ToString(SaveOptions.DisableFormatting);
        }

        public LessonTracking ParseLesson(XmlNode lessonNode)
        {
            Func<string, string> snagValue = s =>
                                                 {
                                                     var xmlNode = lessonNode.SelectSingleNode("cmi/" + s);
                                                     if (xmlNode == null) return String.Empty;
                                                     return xmlNode.InnerText;
                                                 };
            Func<string, int?> snagInt = s =>
                                             {
                                                 var str = snagValue(s);
                                                 int j;
                                                 if (!int.TryParse(str, out j)) return null;
                                                 return j;
                                             };
            Func<string, decimal?> snagDecimal = s =>
                                                    {
                                                        var str = snagValue(s);
                                                        decimal d;
                                                        if (!decimal.TryParse(str, out d)) return null;
                                                        return d;
                                                    };
            Func<string, TimeSpan?> snagTime = s =>
                                                   {
                                                       var str = snagValue(s);
                                                       if (str == String.Empty) return null;
                                                       return new AiccTime(str).Time;
                                                   };
            return new LessonTracking
                       {
                           Identifier = ((XmlElement) lessonNode).GetAttribute("identifier"),
                           StudentId = snagValue("core/student_id"),
                           StudentName = snagValue("core/student_name"),
                           LessonLocation = snagValue("core/lesson_location"),
                           Credit = snagValue("core/credit"),
                           LessonStatus = snagValue("core/lesson_status"),
                           Entry = snagValue("core/entry"),
                           RawScore = snagDecimal("core/score/raw"),
                           MinScore = snagDecimal("core/score/min"),
                           MaxScore = snagDecimal("core/score/max"),
                           TotalTime = snagTime("core/total_time") ?? new TimeSpan(0),
                           LessonMode = snagValue("core/lesson_mode"),
                           Exit = snagValue("core/exit"),
                           SessionTime = snagTime("core/session_time"),
                           SuspendData = snagValue("suspend_data"),
                           LaunchData = snagValue("launch_data"),
                           Comments = snagValue("comments"),
                           CommentsFromLms = snagValue("comments_from_lms"),
                           Objectives = ParseObjectives(lessonNode.SelectSingleNode("objectives")),
                           MasteryScore = snagInt("student_data/mastery_score"),
                           MaxTimeAllowed = snagTime("student_data/max_time_allowed"),
                           TimeLimitAction = snagValue("student_data/time_limit_action")
                       };
        }

        private List<ObjectiveTracking> ParseObjectives(XmlNode objectivesNode)
        {
            var objectives = new List<ObjectiveTracking>();
            if (objectivesNode == null) return objectives;
            var nodeList = objectivesNode.SelectNodes("//id");
            if (nodeList == null) return objectives;

            foreach (XmlNode objectiveNode in nodeList)
            {
                objectives.Add(ParseObjective(objectiveNode.ParentNode));
            }
            return objectives;
        }

        private ObjectiveTracking ParseObjective(XmlNode objectiveNode)
        {
            Func<string, string> snagValue = s =>
                                                 {
                                                     var xmlNode = objectiveNode.SelectSingleNode(s);
                                                     if (xmlNode == null) return String.Empty;
                                                     return xmlNode.InnerText;
                                                 };
            Func<string, int?> snagScore = s =>
                                               {
                                                   var str = snagValue("score/" + s);
                                                   int j;
                                                   if (!int.TryParse(str, out j)) return null;
                                                   return j;
                                               };
            return new ObjectiveTracking
                       {
                           Identifier = snagValue("id"),
                           MaxScore = snagScore("max"),
                           MinScore = snagScore("min"),
                           RawScore = snagScore("raw"),
                           Status = snagValue("status")
                       };
        }


    }
}