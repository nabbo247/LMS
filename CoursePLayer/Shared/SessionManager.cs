using System;




namespace HRS.CoursePlayer
{
    public static class SessionManager
    {
        public static void PopulateSessionVariables(Learner learner, ContentModuleSession session, Course assignment)
        {
            LMSSession.AddSessionItem(CommonKeys.SESSION_LOGEDUSERNAME, learner.UserName);
            LMSSession.AddSessionItem(ContentKeys.SESSION_USER_LAST_FIRST_NAME, learner.LastName + ", " + learner.FirstName);
            //LMSSession.AddSessionItem(Client.CLIENT_SESSION_ID, learner.ClientId);
            LMSSession.AddSessionItem(ContentKeys.SESSION_LEARNER_ID, session.SystemUserGuid);
            LMSSession.AddSessionItem(ContentKeys.SESSION_USERNAMEALIAS, learner.UserName);
           // LMSSession.AddSessionItem(ContentKeys.SESSION_LERNER_LANGUAGE_ID, learner.DefaultLanguageId);
            //LMSSession.AddSessionItem(ContentKeys.SESSION_RVSETTINGS, learner.RegionViewName);

            LMSSession.AddSessionItem(ContentKeys.SESSION_RET_TOSERVER_URL, session.ReturnUrl);
            LMSSession.AddSessionItem(ContentKeys.SESSION_ISREVIEW, session.IsReview);
            LMSSession.AddSessionItem(ContentKeys.SESSION_IS_FOR_ADMIN_PREVIEW, (session.LaunchSite == LaunchSite.Admin));
            LMSSession.AddSessionItem(CommonManager.IS_SSO_LOGIN, session.SsoLogin);
            LMSSession.AddSessionItem(ContentKeys.SESSION_IS_SAME_WINDOW, session.SameWindow);
            if (session.GridPageSize.HasValue)
            {
                LMSSession.AddSessionItem(CommonManager.SESSION_GRID_PAGE_SIZE, session.GridPageSize.Value);
            }
            if (session.Attempt.HasValue)
            {
                LMSSession.AddSessionItem(ContentKeys.SESSION_ATTEMPT_ID, assignment.ActivityId + "-" + learner.EmployeeId + "-" + session.Attempt.Value);
            }
            LMSSession.AddSessionItem(ContentKeys.SESSION_ACTIVITYID, assignment.ActivityId);
            LMSSession.AddSessionItem(ContentKeys.SESSION_COURSENAME, assignment.ContentModuleName);
            LMSSession.AddSessionItem(ContentKeys.SESSION_ACTIVITY_ISAUTH, true);
        }

        //public static bool RestoreAspSession(string clientId, string sessionId)
        //{
        //    //if (LMSSession.IsInSession(Client.CLIENT_SESSION_ID))
        //    //{
        //    //    return true;
        //    //}

        //    var sessionDam = new ContentModuleSessionDAM();
        //    var session = sessionDam.GetById(clientId, sessionId);
        //    if (session == null)
        //    {
        //        return false;
        //    }

        //    var mgrLearner = new LearnerManager();
        //    var currentUser = new Learner { ID = session.SystemUserGuid, ClientId = clientId };
        //    currentUser = mgrLearner.Execute(currentUser, Learner.Method.GetUser_CoursePlayer);

        //    var assignmentManager = new ActivityAssignmentManager();
        //    var assignment = new ActivityAssignment { ID = session.ContentModuleId, UserID = session.SystemUserGuid, ClientId = clientId };
        //    assignment = assignmentManager.Execute(assignment, ActivityAssignment.Method.CheckAssignment_CoursePlayer);

        //    PopulateSessionVariables(currentUser, session, assignment);

        //    if (assignment.ActivityType == ActivityContentType.Scorm12)
        //    {
        //        LMSSession.AddSessionItem(ContentKeys.SESSION_TOTAL_NO_PAGES, ManifestReader.GetTotalPages(clientId, assignment.ID));
        //    }

        //    return true;
        //}

        public static string CreateSession(string clientId, ContentModuleSession session)
        {
            var sessionDam = new ContentModuleSessionDAM();
            session = sessionDam.Save(clientId, session);

            return session.SessionId;
        }

        public static void AddAttemptNumberToSession(string clientId, string sessionId, string attemptId)
        {
            if (LMSSession.IsInSession(ContentKeys.SESSION_ATTEMPT_ID))
            {
                return;
            }
            var idParts = attemptId.Split(new[] { '-' });
            if (idParts.Length > 2)
            {
                var sessionDam = new ContentModuleSessionDAM();
                sessionDam.AddAttemptNumber(clientId, sessionId, Convert.ToInt16(idParts[2]));
            }
        }
    }
}
