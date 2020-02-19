


namespace HRS.CoursePlayer
{
    public interface IContentModuleTrackingManager
    {
        ContentModuleTracking SaveTracking(LessonTracking tracking, TrackingSessionMetaData metaData);
    }
}