

namespace HRS.CoursePlayer
{
    public interface IContentModuleSessionRepository
    {
        ContentModuleSession GetByIdForCourseLaunch(string clientId, string sessionId);
        ContentModuleSession Save(string clientId, ContentModuleSession session);
    }
}
