using System;
using System.Configuration;
using System.Web;
using System.Web.UI;



namespace HRS.CoursePlayer
{
    public partial class LMSExitPlayer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnExitServer.Visible = false;
            if (!LMSSession.IsInSession(ContentKeys.SESSION_LEARNER_ID))
            {
                if (String.IsNullOrEmpty(Request["clientId"]) || String.IsNullOrEmpty(Request["sessionId"]))
                {
                    Response.Redirect("DisplayError.aspx?error=SessionTimeout");
                }
                string sessionId = Request["sessionId"];
                string clientId = CommonManager.DecodeAndDecrypt(Request["clientId"]);
                //if (!SessionManager.RestoreAspSession(clientId, sessionId))
                //{
                //    Response.Redirect("DisplayError.aspx?error=SessionTimeout");
                //}
            }
            if (Request.QueryString["ExitType"] != null && Convert.ToString(Request.QueryString["ExitType"]).Trim() != string.Empty)
            {
                if (LMSSession.IsInSession(ContentKeys.SESSION_IS_SAME_WINDOW))
                {
                    string sDefaultLang = "en-US";
                    if (LMSSession.IsInSession(ContentKeys.SESSION_LERNER_LANGUAGE_ID))
                        sDefaultLang = Convert.ToString(LMSSession.GetValue(ContentKeys.SESSION_LERNER_LANGUAGE_ID));

                    btnExitServer.Text = "Back To Home"; //MessageAdaptor.GetMessage(Services.Messages.Content.BACK_TO_HOME, sDefaultLang);

                    btnExitServer.Visible = Convert.ToBoolean(LMSSession.GetValue(ContentKeys.SESSION_IS_SAME_WINDOW));
                }
                else
                {
                    btnExitServer.Visible = false;
                }
            }
        }

        protected void btnExitServer_Click(object sender, EventArgs e)
        {
            //Client entClient = CommonManager.GetClient();
            string sClientId = "";// Convert.ToString(LMSSession.GetValue(Client.CLIENT_SESSION_ID));
            string sUserName = Convert.ToString(LMSSession.GetValue(CommonKeys.SESSION_LOGEDUSERNAME));
            string sLearnerId = Convert.ToString(LMSSession.GetValue(ContentKeys.SESSION_LEARNER_ID));
            bool blnIsAdminPreview = Convert.ToBoolean(LMSSession.GetValue(ContentKeys.SESSION_IS_FOR_ADMIN_PREVIEW));
            string CourseId = Convert.ToString(LMSSession.GetValue(ContentKeys.SESSION_ACTIVITYID));
            bool bIsSSOLogin = false; //This value will be initially passed to player from Application
            if (LMSSession.IsInSession(CommonManager.IS_SSO_LOGIN))
            {
                bIsSSOLogin = Convert.ToBoolean(LMSSession.GetValue(CommonManager.IS_SSO_LOGIN));
            }
            string sessionId = Request["sessionId"];

            if (!String.IsNullOrEmpty(sessionId))
            {
                new ContentModuleSessionDAM().Expire(sClientId, sessionId);
            }

            //LoginKey entLoginKey = new LoginKey();
            //entLoginKey.SystemUserGUID = sLearnerId;
            //entLoginKey.UserNameAlias = sUserName;
            //entLoginKey.IsSSOLogin = bIsSSOLogin;
            ////Issue No # 127
            ////entLoginKey.StartUrl = "http://" + entClient.ClientAccessURL + LMSSession.GetValue(ContentKeys.SESSION_RET_TOSERVER_URL).ToString() ;
            //if (blnIsAdminPreview) //If from Admin Site
            //{
            //    entLoginKey.StartUrl = "/pages/content/managecourses.aspx?Id=8s9";
            //}
            //else
            //{
            //    entLoginKey.StartUrl = "/Pages/mainpage.aspx";
            //}


            //entLoginKey.ClientId = sClientId;
            ////This value will be initially passed to player from Application 
            //if (LMSSession.IsInSession(CommonManager.SESSION_GRID_PAGE_SIZE))
            //{
            //    entLoginKey.PageSize = Convert.ToInt32(LMSSession.GetValue(CommonManager.SESSION_GRID_PAGE_SIZE));
            //}
            //else
            //{
            //    entLoginKey.PageSize = CommonManager.GRID_DEFAULT_PAGE_SIZE;
            //}
            //LoginKeyManager mgrLoginKey = new LoginKeyManager();
            //entLoginKey = mgrLoginKey.Execute(entLoginKey, LoginKey.Method.Add);
            string sResponseRedirect = string.Empty;

            //////////-aw 6/29/2011 Return to the default protocol
            ////////string sProtocol;

            ////////sProtocol = entClient.IsHTTPSAllowed
            ////////                ? ConfigurationManager.ConnectionStrings[CommonManager.DEFAULT_PROTOCOL].ConnectionString
            ////////                : "http";

            ////////if (blnIsAdminPreview) //If from Admin Site
            ////////{
            ////////    //-aw 6/29/2011 Return to the default protocol
            ////////    //sResponseRedirect = Request.Url.Scheme + "://" + entClient.ClientAccessURL + "/Admin/SSOLogin.aspx?lid=" + HttpUtility.UrlEncode(entLoginKey.ID);
            ////////    sResponseRedirect = sProtocol + "://" + entClient.ClientAccessURL + "/Admin/SSOLogin.aspx?lid=" + HttpUtility.UrlEncode(entLoginKey.ID) + "&AID=" + HttpUtility.UrlEncode(CourseId); ;
            ////////}
            ////////else //for Learner Site
            ////////{
            ////////    //-aw 6/29/2011 Return to the default protocol
            ////////    //sResponseRedirect = Request.Url.Scheme + "://" + entClient.ClientAccessURL + "/SSOLogin.aspx?lid=" + HttpUtility.UrlEncode(entLoginKey.ID);

            ////////    sResponseRedirect = sProtocol + "://" + entClient.ClientAccessURL + "/SSOLogin.aspx?lid=" + HttpUtility.UrlEncode(entLoginKey.ID) + "&AID=" + HttpUtility.UrlEncode(CourseId); ;
            ////////}
            sResponseRedirect = System.Configuration.ConfigurationManager.AppSettings["sAppUrl"] + System.Configuration.ConfigurationManager.AppSettings["Launchlink"].ToString();
            ScriptManager.RegisterClientScriptBlock(Page, this.Page.GetType(), "", "parent.fnExitFrame();parent.ChangeURL('" + sResponseRedirect + "')", true);
        }
    }
}