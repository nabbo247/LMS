using System.Collections.Generic;
using System.Xml;


namespace HRS.CoursePlayer
{
    public interface ILessonTrackingSerializer
    {
        Dictionary<string, LessonTracking> ReadLessonTracking(string userDataXml); //TODO: Read and use Bookmark attribute
        LessonTracking ParseLesson(XmlNode lessonNode);
        string WriteLessonTracking(ContentModuleTracking contentModuleTracking);
    }
}
