using System;


using System.Configuration;

namespace HRS.CoursePlayer
{
    [Autofac.Integration.Web.Forms.InjectUnsetProperties]
    public partial class LaunchPlayer : System.Web.UI.Page
    {
        //public ICoursePlayerAssignmentManager CoursePlayerAssignmentManager { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
           // string aid = Request.Params["AID"];
            
            //if (Request.Params["AID"] == null || Request.Params["client"] == null ||
            //    Request.Params["LID"] == null || Request.Params["Preview"] == null)
            if (Request.Params["AID"] == null || Request.Params["LID"] == null)
            {
                Response.Write("Course Preview not available. Please Contact Administrator.");
                Response.End();
            }

            //Response.Write("<BR>AID : " + Request.Params["AID"]);
            //Response.Write("<BR>LID : " + Request.Params["LID"]);
            //Response.End();
            
            //string activityId = CommonManager.DecodeAndDecrypt(Request.Params["AID"]);
            //string clientId = CommonManager.DecodeAndDecrypt(Request.Params["client"]);
            
            string activityId = Request.Params["AID"];
            
            string learnerId = Request.Params["LID"];
            string langId = Request.Params["Lang"];
            if(string.IsNullOrEmpty(langId))
                langId="en-US";

            LMSSession.AddSessionItem (CommonManager.SESSION_MYCULTURE,langId);

            bool isReview = CheckReview();
           
            bool isForAdminPreview = false;
            bool isSsoLogin = CheckSso();
            bool isSameWindow = CheckSameWindow();
            string returnUrl = CheckReturnUrl(isForAdminPreview);
            int? gridPageSize = CheckGridPageSize();

            var session = new ContentModuleSession
            {
                ContentModuleId = activityId,
                Expiration = DateTime.UtcNow.AddDays(2), 
                IsReview = isReview,
                SystemUserGuid = learnerId,
                LaunchSite = isForAdminPreview ? LaunchSite.Admin : LaunchSite.Learner,
                SsoLogin = isSsoLogin,
                SameWindow = isSameWindow,
                ReturnUrl = returnUrl,
                GridPageSize = gridPageSize
            };
            
            Course oCourse = new Course();
            oCourse.ActivityId = activityId;
            oCourse.LearnerId = learnerId;
            var assignment = ContentModuleBLL.GetUserContentModuleTracking(oCourse);

            if (Convert.ToString(assignment.RetMessage) != "success")
            {
                Response.Write("Error Occured: " + Convert.ToString(assignment.RetMessage));
            }
            
            // checks if activity already exists.
            if (assignment.ContentTrackId != null)
            {
                Learner oLearner = new Learner();
                oLearner.ID = learnerId;
                LaunchActivity(assignment, session, oLearner);
            }
            
        }

        private string CheckReturnUrl(bool isForAdminPreview)
        {
            string returnUrl;
            if (Server.UrlDecode(Convert.ToString(Request.Params["RetURL"])) != string.Empty &&
                Request.Params["RetURL"] != null)
            {
                returnUrl = Convert.ToString((Request.Params["RetURL"]));
            }
            else
            { 
               returnUrl = "/LaunchPage.aspx";
            }
            
            return returnUrl;
        }

        private bool CheckReview()
        {
            bool review = (Request.Params["isResume"] != null &&
                           !string.IsNullOrEmpty(Convert.ToString(Request.Params["isResume"])));
            return review;
        }

        private bool CheckAdmin()
        {
            bool isAdmin = false;
            string sIsForAdminPreview = Server.UrlDecode(Request.Params["Preview"]);
            if (sIsForAdminPreview.ToLower().Equals("admin"))
            {
                isAdmin = true;
            }
            return isAdmin;
        }

        private bool CheckSso()
        {
            bool sso = false;
            if (Server.UrlDecode(Convert.ToString(Request.Params["SSOLogin"])) != string.Empty &&
                           Request.Params["SSOLogin"] != null)
            {
                sso = Convert.ToBoolean((Request.Params["SSOLogin"]));
            }
            return sso;
        }

        private bool CheckSameWindow()
        {
            bool sameWindow = false;
            if (Server.UrlDecode(Convert.ToString(Request.Params["SameWindow"])) != string.Empty && Request.Params["SameWindow"] != null)
            {
                sameWindow = Convert.ToBoolean(Request.Params["SameWindow"]);
            }
            return sameWindow;
        }

        private int? CheckGridPageSize()
        {
            int? pageSize = null;
            if (Server.UrlDecode(Convert.ToString(Request.Params["GridPageSize"])) != string.Empty && Request.Params["GridPageSize"] != null)
            {
                pageSize = Convert.ToInt16(Request.Params["GridPageSize"]);
            }
            return pageSize;
        }

        /// <summary>
        /// Launches activity
        /// </summary>
        /// <param name="activityAssignment"></param>
        private void LaunchActivity(Course activityAssignment, ContentModuleSession session, Learner currentUser) //, ContentModuleSession session
        {
            SessionManager.PopulateSessionVariables(currentUser, session, activityAssignment);

            LMSSession.RemoveSessionItem(ContentKeys.SESSION_ATTEMPT_ID);
            LMSSession.RemoveSessionItem(ContentKeys.SESSION_TOTAL_NO_PAGES);

            
            string sessionId = session.SystemUserGuid+"--"+session.ContentModuleId;
            string sLaunchPlayer;
            sLaunchPlayer = "HTMLGetSCORM.htm?sessionId=" + sessionId + "&contentmoduleid=" + session.ContentModuleId + "&learnerid=" + session.SystemUserGuid;// +"&LangId=" + langId;
            
            Response.Redirect(sLaunchPlayer);
        }
    }
}
