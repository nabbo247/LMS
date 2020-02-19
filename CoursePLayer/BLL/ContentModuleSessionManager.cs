

using System.Collections.Generic;

namespace HRS.CoursePlayer
{
    public class ContentModuleSessionManager : IContentModuleSessionRepository
    {
        private readonly IContentModuleRetriever _contentModuleRetriever;
        private readonly IContentModuleTrackingRepository _contentModuleTrackingRepository;

        public ContentModuleSessionManager(IContentModuleRetriever contentModuleRetriever, IContentModuleTrackingRepository contentModuleTrackingRepository)
        {
            _contentModuleRetriever = contentModuleRetriever;
            _contentModuleTrackingRepository = contentModuleTrackingRepository;
        }

        public ContentModuleSession Save(string clientId, ContentModuleSession session)
        {
            var contentModuleSessionDAM = new ContentModuleSessionDAM();
            return contentModuleSessionDAM.Save(clientId, session);
        }

        public ContentModuleSession GetByIdForCourseLaunch(string learnerId, string contentmoduleId)
        {
            ContentModuleSessionDAM contentModuleSessionDAM = new ContentModuleSessionDAM();
            var session = new ContentModuleSession();//contentModuleSessionDAM.GetById(learnerId, sessionId);
           //////////////////////Session
            session.ContentModuleId = contentmoduleId;
            session.SystemUserGuid = learnerId;
            //////////////////////Learner
            session.Learner = GetLearnerHRS(session);
            //////session.Learner.FirstName = "B";
            //////session.Learner.LastName = "S";
            //////session.Learner.LearnerId = learnerId;

            session.Assignment =  new ActivityAssignment();//GetAssignment(clientId, session);
            
            ///////////////////////// ContentModule
            session.ContentModule = GetContentModule(session);
            //session.ContentModuleTracking = new ContentModuleTracking();//GetTracking(clientId, session);
            session.ContentModuleTracking = GetTrackingHRS(session);
            return session;
        }
        public ContentModuleSession GetByIdForCourseLaunch_backup_2015_01_13(string clientId, string sessionId)
        {
            ContentModuleSessionDAM contentModuleSessionDAM = new ContentModuleSessionDAM();
            var session = contentModuleSessionDAM.GetById(clientId, sessionId);
            session.Learner = GetLearner(clientId, session);
            session.Assignment = GetAssignment(clientId, session);
            session.ContentModule = GetContentModule(session);
            session.ContentModuleTracking = GetTracking(clientId, session);
            return session;
        }
        private ContentModule GetContentModule(ContentModuleSession session)
        {
            return _contentModuleRetriever.GetContentModule(session.ContentModuleId);
        }

        private ActivityAssignment GetAssignment(string clientId, ContentModuleSession session)
        {
            var assignment = new ActivityAssignment { ID = session.ContentModuleId, UserID = session.SystemUserGuid, ClientId = clientId };
            //return new ActivityAssignmentManager().Execute(assignment, ActivityAssignment.Method.CheckAssignment_CoursePlayer);
            return assignment;
        }

        private Learner GetLearner(string clientId, ContentModuleSession session)
        {
            var currentUser = new Learner { ID = session.SystemUserGuid, ClientId = clientId };
            return new LearnerManager().Execute(currentUser, Learner.Method.GetUser_CoursePlayer);
        }
        private Learner GetLearnerHRS(ContentModuleSession session)
        {
            var currentUser = new Learner { ID = session.SystemUserGuid };
            return new LearnerManager().Execute(currentUser, Learner.Method.GetUser_CoursePlayer);
        }


        private ContentModuleTracking GetTracking(string clientId, ContentModuleSession session)
        {
            var contModTracking = new ContentModuleTracking
            {
                UserID = session.SystemUserGuid,
                ContentModuleId = session.ContentModuleId,
                ClientId = clientId
            };
            if (session.Attempt.HasValue)
            {
                contModTracking.ID = session.Assignment.ID + "-" + session.SystemUserGuid + "-" + session.Attempt.Value;
            }
            contModTracking.IsResume = session.IsReview;
            contModTracking.ContentType = session.ContentModule.ContentModuleTypeId;

            contModTracking = _contentModuleTrackingRepository.GetContentModuleLessonTracking(contModTracking);

            contModTracking.IsForAdminPreview = (session.LaunchSite == LaunchSite.Admin);
            contModTracking.UserID = session.SystemUserGuid;
            contModTracking.UserFirstLastName = session.Learner.LastName + ", " + session.Learner.FirstName;
            contModTracking.ContentModuleId = session.ContentModuleId;
            contModTracking.SessionId = session.SessionId;
            contModTracking.TotalNoOfPages = session.ContentModule.TotalLessons;
            contModTracking.ContentType = session.ContentModule.ContentModuleTypeId;

            return contModTracking;
        }
        private ContentModuleTracking GetTrackingHRS(ContentModuleSession session)
        {
            var contModTracking = new ContentModuleTracking
            {
                UserID = session.SystemUserGuid,
                ContentModuleId = session.ContentModuleId
            };
            //if (session.Attempt.HasValue)
            //{
            contModTracking.ID = session.SystemUserGuid + "CTR" + IDGenerator.GetUniqueKey(16);
            //}
            contModTracking.IsResume = session.IsReview;
            contModTracking.ContentType = session.ContentModule.ContentModuleTypeId;

            contModTracking = _contentModuleTrackingRepository.GetContentModuleLessonTracking(contModTracking);

            contModTracking.IsForAdminPreview = false; // (session.LaunchSite == LaunchSite.Admin);
            contModTracking.UserID = session.SystemUserGuid;
            contModTracking.UserFirstLastName = session.Learner.LastName + ", " + session.Learner.FirstName;
            contModTracking.ContentModuleId = session.ContentModuleId;
            contModTracking.SessionId = session.SessionId;
            contModTracking.TotalNoOfPages = session.ContentModule.TotalLessons;
            contModTracking.ContentType = session.ContentModule.ContentModuleTypeId;

            return contModTracking;
        }
    }
}
