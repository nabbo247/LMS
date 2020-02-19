using System;
using System.Collections.Generic;



using System.Text;

namespace HRS.CoursePlayer
{
    [Autofac.Integration.Web.Forms.InjectUnsetProperties]
    public partial class ScormCourseDefaultPage : System.Web.UI.Page
    {
        public IContentModuleSessionRepository ContentModuleSessionRepository { get; set; }

        protected string totalscos = "";
        protected IEnumerable<CourseSection> sections;
        protected Dictionary<string, string> launchUrls;
        protected Dictionary<string, string> lessonStatuses;
        private string sContentFolderUrl = string.Empty;
        private string sLaunchParameter = string.Empty;
        private string sLaunchParameterQueryString = string.Empty;
        private string sLearnerLanguageId = "en-US";
        private string sLanguageCode = string.Empty;
        private string sStudentName = string.Empty;
        private int iMasteryScore = -1;
        private string sAVPath = string.Empty;
        string _sManagerEmail = string.Empty;
        /// <summary>
        /// Page Load event call of the page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(Request["clientId"]) || String.IsNullOrEmpty(Request["sessionId"]))
            if (String.IsNullOrEmpty(Request["sessionId"]))
            {
                Response.Redirect("DisplayError.aspx?error=SessionTimeout");
            }

           //~ var sClientId = CommonManager.DecodeAndDecrypt(Request["clientId"]);
            var sClientId = "HRS";
            var sessionId = Request["sessionId"];
            var contentmoduleid = Request["contentmoduleid"];
            var learnerid = Request["learnerid"];
            //Session["contentmoduleid"] = Request["contentmoduleid"];
           
            var session = ContentModuleSessionRepository.GetByIdForCourseLaunch(learnerid, contentmoduleid);
            //var session = new ContentModuleSession();

            //if (session == null)
            //{
            //    Response.Redirect("DisplayError.aspx?error=SessionTimeout");
            //}

            string sLearnerUserNameAlias = session.Learner.UserName;
            //string sManagerEmail = session.Learner.ManagerEmailId;
            //_sManagerEmail = session.Learner.ManagerEmailId;
           //~ _sManagerEmail = _sManagerEmail.Replace("'", "\'");

            //string sStudentEmail = session.Learner.EmailID;
           //~ sStudentEmail = sStudentEmail.Replace("'", "\'");


            sStudentName = session.Learner.LastName + ", " + session.Learner.FirstName;
            string sCourseID = Request["contentmoduleid"];
            //~string sCourseName = session.Assignment.ActivityName;
            string sCourseName = "HRS";
            //~string sRVSettings = session.Learner.RegionViewName;
            string sRVSettings = "HRS";
            string sIsScoreTracking = string.Empty;
            bool blnIsShortLanguageCode;

            ContentModuleTracking contModTracking = session.ContentModuleTracking;
            ContentModule entContent = session.ContentModule ; //new ContentModule();
            //blnIsShortLanguageCode = entContent.IsShortLanguageCode;

            iMasteryScore = 100;///****session.ContentModule.MasteryScore;
            ////sAVPath = session.Learner.AvPath;

            sIsScoreTracking = "";

            sContentFolderUrl = System.Configuration.ConfigurationManager.AppSettings["sAppUrl"].ToString() + System.Configuration.ConfigurationManager.AppSettings["sContentFolderUrl"].ToString() + "/" + contentmoduleid;
            
            lblErr.Text = "";
            if (!Page.IsPostBack)
            {
                lblWelcome.Text = sLearnerUserNameAlias;
                 
                string strIMSCourseBasePath = sContentFolderUrl + "/";

                string sAttempId = string.Empty;

                if (contModTracking.ID != null)
                {
                    sAttempId = contModTracking.ID;
                    LMSSession.AddSessionItem(ContentKeys.SESSION_ATTEMPT_ID, sAttempId);
                    SessionManager.AddAttemptNumberToSession(sClientId, sessionId, contModTracking.ID);
                }

                int TotalNoOfPages = entContent.TotalLessons;
                totalscos = TotalNoOfPages.ToString();
                LMSSession.AddSessionItem(ContentKeys.SESSION_TOTAL_NO_PAGES, TotalNoOfPages);

                lblContentModuleName.Text = sCourseName;
                lblMessage.Text = "To receive your certificate of completion you must view each screen in each section.";
                Response.Write("<script language='Javascript'>\n\tvar gLearnerId = \"" + sLearnerUserNameAlias + "\";\n");
                Response.Write("\tvar gStudentId = \"" + sLearnerUserNameAlias + "\";\n");
                Response.Write("\tvar sessionId = \"" + sessionId + "\";\n");
                Response.Write("\tvar clientId = \"" + Request["clientId"] + "\";\n");
                Response.Write("\tgLearnerName = \"" + sStudentName + "\";\n");
                Response.Write("\tgContentPath=\"" + strIMSCourseBasePath + "\";\n");
                Response.Write("\tvar gTrackScoreSettingFromLMS=\"" + sIsScoreTracking + "\";\n");

                
                var sbLaunchParameter = new StringBuilder();
                sbLaunchParameter.Append("LMSID=SAI");
                if (!string.IsNullOrEmpty(sAVPath))
                {
                    sbLaunchParameter.Append("&AVPath=" + sAVPath);
                    sbLaunchParameter.Append("&AudioPath=" + sAVPath);
                    sbLaunchParameter.Append("&VideoPath=" + sAVPath);
                }
                if (!string.IsNullOrEmpty(sRVSettings))
                {
                    sbLaunchParameter.Append("&rip=" + sRVSettings);
                }
                if (!string.IsNullOrEmpty(sLearnerLanguageId))
                {
                    sLanguageCode = "en-US";
                    sbLaunchParameter.Append("&lang=" + sLanguageCode);
                }

                sLaunchParameter = sbLaunchParameter.ToString();
                
                Response.Write("\tvar sLearnerLanguageId='" + sLanguageCode + "';\n");
                Response.Write("\tvar gManifestId='" + sCourseID + "';\n</script>\n");
                Response.Write("<script language='Javascript' src='ScormLibrary/js/ClientScripts.js'></script>\n");
                Response.Write("<script language='Javascript' src='ScormLibrary/js/LMSRTEWrapperJS.js'></script>\n");
                Response.Write("<script language='Javascript' src='ScormLibrary/js/Master.js'></script>\n");
                Response.Write("<script language='Javascript' src='ScormLibrary/js/ScormValidations.js'></script>\n");
                Response.Write("<script language='Javascript' src='ScormLibrary/js/RTEMaster.js'></script>\n");
                Response.Write("<script language='Javascript' src='js/NewScormJS.js'></script>\n");
                Response.Write("<script language='Javascript'>\n");

                launchUrls = new Dictionary<string, string>();
                lessonStatuses = new Dictionary<string, string>();
                sections = entContent.Sections.SortedValues();
                foreach (var section in sections)
                {
                    foreach (var lesson in section.Lessons.SortedValues())
                    {
                        var sco = (Sco) lesson;
                        string sTempAVPath = sLaunchParameter != string.Empty ? sLaunchParameter : sco.DataFromLms;
                        string siTempMasterScore;
                        if (iMasteryScore > -1) 
                        {
                            siTempMasterScore = Convert.ToString(iMasteryScore);
                        }
                        else
                        {
                            siTempMasterScore = sco.MasteryScore.HasValue ? sco.MasteryScore.ToString() : String.Empty;
                        }
                        var sUrl = sco.Resource.Href;
                        if (sUrl.IndexOf(strIMSCourseBasePath) <= 0)
                        {
                            sUrl = sUrl.AppendUrlParameter("passingScore", siTempMasterScore) + "&" +
                                   sLaunchParameterQueryString;
                        }
                        launchUrls[lesson.Identifier] = sUrl;

                        var arrOfNodeProp =
                            String.Format(
                                "['{0}','','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}']",
                                sco.Identifier, sco.TargetWindow, sco.Prerequisites, sTempAVPath, siTempMasterScore,
                                sco.MaxTimeAllowed, sco.TimeLimitAction, sco.Resource.Identifier, sco.Resource.ScormType,
                                sco.Resource.Type, sco.Resource.Base, sUrl);
                        Response.Write("\tarrManifestNodes[arrManifestNodes.length] = new ManifestNode(" + arrOfNodeProp +
                                       ");\n");
                        if (contModTracking.LessonTracking != null &&
                            contModTracking.LessonTracking.ContainsKey(lesson.Identifier))
                        {
                            var scoTracking = contModTracking.LessonTracking[lesson.Identifier];
                            lessonStatuses[lesson.Identifier] = CommonManager.GetScoStatus(scoTracking.LessonStatus);
                            WriteScoTracking(scoTracking);
                        } 
                        else
                        {
                            lessonStatuses[lesson.Identifier] = CommonManager.GetScoStatus("not-started");
                        }
                    }
                }
                Response.Write("</script>\n");
            }
        }

        private void WriteScoTracking(LessonTracking scoTracking)
        {
            var objectiveTracking = String.Empty;
            for (int k = 0; k < scoTracking.Objectives.Count; k++)
            {
                objectiveTracking = objectiveTracking + String.Format("{0},{1},{2},{3},{4}",
                                                                      scoTracking.Objectives[k].Identifier,
                                                                      scoTracking.Objectives[k].RawScore,
                                                                      scoTracking.Objectives[k].MaxScore,
                                                                      scoTracking.Objectives[k].MinScore,
                                                                      scoTracking.Objectives[k].Status);
                if (k != scoTracking.Objectives.Count - 1)
                    objectiveTracking = objectiveTracking + " #&bv&#";
            }
            string siTempMasterScore;
            if (iMasteryScore > -1) 
            {
                siTempMasterScore = Convert.ToString(iMasteryScore);
            }
            else
            {
                siTempMasterScore = scoTracking.MasteryScore.HasValue
                                        ? scoTracking.MasteryScore.ToString()
                                        : String.Empty;
            }

            Response.Write(string.Format(
                "\tarrParams = ['{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}',\"{24}\"];\n"
                , scoTracking.Identifier, scoTracking.StudentId,
                ValidationManager.MaskCharForJS(scoTracking.StudentName),
                scoTracking.LessonLocation, scoTracking.Credit, scoTracking.LessonStatus, scoTracking.Entry,
                scoTracking.RawScore, scoTracking.MaxScore, scoTracking.MinScore, scoTracking.TotalTime,
                scoTracking.LessonMode, scoTracking.Exit, scoTracking.SessionTime, scoTracking.SuspendData,
                sLaunchParameter == string.Empty ? scoTracking.LaunchData : sLaunchParameter,
                scoTracking.Comments, scoTracking.CommentsFromLms, scoTracking.Objectives.Count,
                objectiveTracking, siTempMasterScore, scoTracking.MaxTimeAllowed,
                scoTracking.TimeLimitAction, "", _sManagerEmail));
            Response.Write("\tarrSCO[arrSCO.length] = new CSCO(arrParams);\n");
        }
    }
}