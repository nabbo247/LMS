

namespace HRS.CoursePlayer
{
    public interface IContentModuleTrackingRepository
    {
        ContentModuleTracking GetContentModuleTracking(ContentModuleTracking trackingParameters);
        ContentModuleTracking GetContentModuleLessonTracking(ContentModuleTracking trackingParameters);
        ContentModuleTracking UpdateContentModuleTracking(ContentModuleTracking trackingParameters);
    }
}
