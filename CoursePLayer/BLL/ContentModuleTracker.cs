using System;



namespace HRS.CoursePlayer
{
    public class ContentModuleTracker : IContentModuleTrackingManager
    {
        private readonly IContentModuleTrackingRepository _dataManager;
        private readonly ICourseTrackingUpdater _trackingUpdater;
        private readonly IContentModuleSessionRepository _sessionRepository;
        private readonly ICourseConfigurationRepository _courseConfigurationRepository;
        
        public ContentModuleTracker(IContentModuleTrackingRepository dataManager, ICourseTrackingUpdater trackingUpdater, IContentModuleSessionRepository sessionRepository, ICourseConfigurationRepository configurationRepository)
        {
            _dataManager = dataManager;
            _trackingUpdater = trackingUpdater;
            _sessionRepository = sessionRepository;
            _courseConfigurationRepository = configurationRepository;
        }

        public ContentModuleTracking SaveTracking(LessonTracking tracking, TrackingSessionMetaData metaData)
        {
            ContentModuleTracking trackingToGet = new ContentModuleTracking
                                                      {
                                                              ClientId = metaData.ClientId,
                                                              ContentType = metaData.ContentType,
                                                              SessionId = metaData.SessionId,
                                                              UserID = metaData.LearnerId,
                                                              ContentModuleId = metaData.CourseId
                                                      };
                                                      
            var currentTracking = _dataManager.GetContentModuleLessonTracking(trackingToGet);

            if (String.IsNullOrEmpty(currentTracking.ID))
            {
                var session = _sessionRepository.GetByIdForCourseLaunch(metaData.LearnerId, metaData.CourseId);
                currentTracking = session.ContentModuleTracking;
            }

            currentTracking.SessionId = metaData.SessionId;
            currentTracking.ClientId = metaData.ClientId;
            currentTracking.ContentType = metaData.ContentType;
            
            if (tracking.RawScore.HasValue)
            {
                //var clientCourseConfig = _courseConfigurationRepository.GetConfiguration(metaData.ClientId);
                int iMasteryScore;
                bool bGetMasteryScore = Int32.TryParse(System.Configuration.ConfigurationSettings.AppSettings["MasteryScore"].ToString(), out iMasteryScore);

                tracking.MasteryScore = iMasteryScore;  //clientCourseConfig.MasteryScore;
                //if (!clientCourseConfig.ScoreTracking)
                //{
                //    tracking.RawScore = null;
                //}
            }
            //if (currentTracking.LessonTracking == null)
            //{
            //    currentTracking.LessonTracking = tracking;
            //}
            var trackingToSave = _trackingUpdater.UpdateTracking(tracking, currentTracking);

            return _dataManager.UpdateContentModuleTracking(trackingToSave);
            //return new ContentModuleTracking();
        }
    }
}