using System;


namespace HRS.CoursePlayer
{
    public partial class SessionPoller : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (LMSSession.IsInSession(ContentKeys.SESSION_LEARNER_ID) || Request["firstLoad"] == "true")
            {
                if (Request.QueryString["SessionTimeOut"] != null &&
                    Convert.ToString(Request.QueryString["SessionTimeOut"]) != string.Empty)
                {
                    string sSessionTimeout = Convert.ToString(Request.QueryString["SessionTimeOut"]);
                    bodyMain.Attributes.Add("onload", "fnSetSessionPoller(" + sSessionTimeout + ")");
                }
            } 
            else
            {
                Response.Redirect("DisplayError.aspx?error=SessionTimeout");
            }
        }
    }
}
