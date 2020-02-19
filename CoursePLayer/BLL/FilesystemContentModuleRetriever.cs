using System;
using System.Collections.Generic;
using System.Xml;



using System.Configuration;
using System.Web;

namespace HRS.CoursePlayer
{
    public class FilesystemContentModuleRetriever : IContentModuleRetriever
    {
        private readonly ICacheProvider _cache;
        private readonly IContentModuleRepository _contentModuleRepository;
        private readonly ICourseConfigurationRepository _courseConfigurationRepository;

        public FilesystemContentModuleRetriever(ICacheProvider cacheProvider, IContentModuleRepository contentModuleRepository, ICourseConfigurationRepository courseConfigurationRepository)
        {
            _cache = cacheProvider;
            _contentModuleRepository = contentModuleRepository;
            _courseConfigurationRepository = courseConfigurationRepository;
        }

        public ContentModule GetContentModule(string courseId)
        {

            var course = _contentModuleRepository.GetByIdForCoursePlayer(courseId);

            course.MasteryScore = 0;
            //var manifestPath = @"E:\Projects\LMS\CoursePLayer\ContentModules\4\imsmanifest.xml";
            var manifestPath = System.Configuration.ConfigurationSettings.AppSettings["sAppRootPath"].ToString() + System.Configuration.ConfigurationSettings.AppSettings["ContentRootPath"].ToString() + "ContentModules\\" + courseId + "\\imsmanifest.xml";

            var contentType = (ActivityContentType)Enum.Parse(typeof(ActivityContentType), course.ContentModuleTypeId);
            course.Sections = ReadSectionsFromManifest(manifestPath, course.MasteryScore, contentType);
            
            return course;
        }

        public ContentModule GetMetaData(string clientId, string courseId)
        {
            return _contentModuleRepository.GetById(clientId, courseId);
        }


        private Dictionary<string, CourseSection> ReadSectionsFromManifest(string manifestPath, int masteryScore, ActivityContentType courseType)
        {
            var sections = new Dictionary<string, CourseSection>();
            var manifestXml = new XmlDocument();

            try
            {
                manifestXml.Load(manifestPath);
                manifestXml = new XMLLib().StripDocumentNamespace(manifestXml);
            }
            catch (Exception ex)
            {
               
            }

            XmlNodeList sectionNodeList =
                manifestXml.SelectNodes("/manifest/organizations/organization");
            if (sectionNodeList == null) return sections;

            var lessonReaderFactory = new LessonReaderFactory(courseType);

            int sectionNumber = 1;

            foreach (XmlNode sectionNode in sectionNodeList)
            {
                var titleNode = sectionNode.SelectSingleNode("title");
                string title = titleNode == null ? String.Empty : titleNode.InnerText;
                string identifier = ((XmlElement)sectionNode).GetAttribute("identifier");
                var lessons = new Dictionary<string, Lesson>();
                XmlNodeList lessonNodeList = sectionNode.SelectNodes("//item[@identifierref | @resourceref]");
                if (lessonNodeList != null)
                {
                    int lessonNumber = 1;
                    foreach (XmlNode lessonNode in lessonNodeList)
                    {
                        var lessonReader = lessonReaderFactory.GetLessonReader(lessonNode, masteryScore);
                        var lesson = lessonReader.ReadLesson();
                        lesson.SortOrder = lessonNumber;
                        lessons.Add(lesson.Identifier, lesson);
                        lessonNumber++;
                    }
                }

                sections.Add(identifier, new CourseSection
                {
                    Lessons = lessons,
                    Identifier = identifier,
                    Title = title,
                    SortOrder = sectionNumber
                });
                sectionNumber++;
            }
            return sections;
        }
    }
}
