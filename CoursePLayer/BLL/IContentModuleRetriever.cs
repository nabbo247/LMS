

namespace HRS.CoursePlayer
{
    public interface IContentModuleRetriever
    {
        ContentModule GetContentModule(string courseId);
        ContentModule GetMetaData(string clientId, string courseId);
    }
}
