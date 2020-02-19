
#region using statement

using System;




using System.Xml;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Net;
using System.Web.Script.Serialization;
using System.Text;
using System.IO;

#endregion

namespace HRS.CoursePlayer
{
    [Autofac.Integration.Web.Forms.InjectUnsetProperties]
    public partial class UpdateLMS : System.Web.UI.Page
    {
        string sClientId = string.Empty;
        string learnerId = string.Empty;
        string courseId = string.Empty;
        private string sessionId = string.Empty;

        #region IContentModuleTrackingManager

        //public ICoursePlayerAssignmentManager CoursePlayerAssignmentManager
        //{
        //    get;
        //    set;
        //}
        public IContentModuleTrackingManager TrackingManager
        {
            get;
            set;
        }
        #endregion

        #region Page_Load

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "GET")
            {

                ////if (LMSSession.IsInSession(Client.CLIENT_SESSION_ID))
                ////    hdnClientId.Value = EncryptionManager.Encrypt(Convert.ToString(LMSSession.GetValue(Client.CLIENT_SESSION_ID)));

                if (LMSSession.IsInSession(ContentKeys.SESSION_ACTIVITYID))
                {
                    hdnContentModuleId.Value = EncryptionManager.Encrypt(Convert.ToString(LMSSession.GetValue(ContentKeys.SESSION_ACTIVITYID)));
                    courseId = Convert.ToString(LMSSession.GetValue(ContentKeys.SESSION_ACTIVITYID));
                }
                if (LMSSession.IsInSession(ContentKeys.SESSION_LEARNER_ID))
                {
                    hdnUserId.Value = EncryptionManager.Encrypt(Convert.ToString(LMSSession.GetValue(ContentKeys.SESSION_LEARNER_ID)));
                    learnerId = Convert.ToString(LMSSession.GetValue(ContentKeys.SESSION_LEARNER_ID));
                }
                hdnCStartDate.Value = Convert.ToString(DateTime.UtcNow);
                return;
            }
            var requestXml = LoadRequestXml();
            XMLLib xLib = new XMLLib();
            if (requestXml == null)
            {
                Response.Redirect("DisplayError.aspx?error=SessionTimeout");
            }
            //sClientId = CommonManager.DecodeAndDecrypt(xLib.fGetValue(requestXml, "/Root/ClientId"));
            sessionId = xLib.fGetValue(requestXml, "/Root/SessionId");
            courseId = EncryptionManager.Decrypt(Convert.ToString(hdnContentModuleId.Value));
          
            if (LMSSession.IsInSession(ContentKeys.SESSION_LEARNER_ID))
            {
                hdnUserId.Value = EncryptionManager.Encrypt(Convert.ToString(LMSSession.GetValue(ContentKeys.SESSION_LEARNER_ID)));
                learnerId = Convert.ToString(LMSSession.GetValue(ContentKeys.SESSION_LEARNER_ID));
            }



            if (requestXml != null)
            {
                XmlNode oRootNode = null;

                if (xLib.fCreateFirstContext(requestXml, "Root", ref oRootNode))
                {
                    string useCase = xLib.fGetValue(requestXml, "/Root/Case");
                    ProcessRequest(requestXml, useCase);
                }
            }
        }

        #endregion

        #region LoadRequestXml

        private XmlDocument LoadRequestXml()
        {
            string xmlFromPost = Request["TARecords"];
            if (string.IsNullOrEmpty(xmlFromPost))
            {
                return null;
            }
            var requestXml = new XmlDocument();
            requestXml.LoadXml(xmlFromPost);
            return requestXml;
        }
        #endregion

        #region ProcessRequest

        private void ProcessRequest(XmlDocument RequestXMLObj, string useCase)
        {
            switch (useCase)
            {
                case "SaveCurrentSco":
                    try
                    {
                        string strContentModuleId = string.Empty;
                        string strLearnerId = string.Empty;
                        ////string strClientId = string.Empty;

                        if (LMSSession.IsInSession(ContentKeys.SESSION_ACTIVITYID))
                            strContentModuleId = Convert.ToString(LMSSession.GetValue(ContentKeys.SESSION_ACTIVITYID));

                        if (LMSSession.IsInSession(ContentKeys.SESSION_LEARNER_ID))
                            strLearnerId = Convert.ToString(LMSSession.GetValue(ContentKeys.SESSION_LEARNER_ID));

                        ////if (LMSSession.IsInSession(Client.CLIENT_SESSION_ID))
                        ////    strClientId = Convert.ToString(LMSSession.GetValue(Client.CLIENT_SESSION_ID));

                        ////if (string.IsNullOrEmpty(strClientId) && !string.IsNullOrEmpty(hdnClientId.Value))
                        ////{
                        ////    strClientId = EncryptionManager.Decrypt(hdnClientId.Value);
                        ////}

                        if (!string.IsNullOrEmpty(hdnContentModuleId.Value))
                        {
                            strContentModuleId = EncryptionManager.Decrypt(hdnContentModuleId.Value);
                        }

                        if (!String.IsNullOrEmpty(strContentModuleId))
                        {
                            bool flag = false;
                            if (hdnContentModuleIdIsA.Value == String.Empty)
                            {
                                ContentModuleManager _CMManager = new ContentModuleManager();
                                ContentModule entContentModule = new ContentModule();
                                entContentModule.ID = strContentModuleId;
                                ////entContentModule.ClientId = strClientId;
                                entContentModule = _CMManager.Execute(entContentModule, ContentModule.Method.GetByIDCoursePlayer);
                                flag = entContentModule.IsAssessment;
                                hdnContentModuleIdIsA.Value = entContentModule.IsAssessment.ToString();
                            }
                            else
                            {
                                flag = Convert.ToBoolean(hdnContentModuleIdIsA.Value);
                            }

                            if (flag)
                                SaveSuspendData(RequestXMLObj);

                        }
                        else
                        {
                            RedirectToMainPage();
                        }
                    }
                    catch(Exception ex)
                    { 
                        
                    }

                    SaveCurrentSco(RequestXMLObj);
                    ////string xmlFromPost = Request["TARecords"];

                    break;
            }
        }
        #endregion

        public void RedirectToMainPage()//if invalid client
        {
            int cnt = 0;
            int.TryParse(hdnScriptRegCount.Value, out cnt);

            if (cnt == 0)
            {
                hdnScriptRegCount.Value = "1";
                CoursePlayerErrorLog();
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "EXCurrentSession", "CloseCoursePlayer();", true);
            }


        }

        public void CoursePlayerErrorLog()
        {
            try
            {
                string strContentModuleId = string.Empty;
                string strClientId = string.Empty;
                string strSystemUserGUID = "";

                DateTime d1;
                DateTime.TryParse(Convert.ToString(hdnCStartDate.Value), out d1);
                DateTime d2 = DateTime.UtcNow;
                TimeSpan ts = d2 - d1;

                if (string.IsNullOrEmpty(strClientId) && !string.IsNullOrEmpty(hdnClientId.Value))
                {
                    strClientId = EncryptionManager.Decrypt(hdnClientId.Value);
                }

                if (string.IsNullOrEmpty(strClientId) && !string.IsNullOrEmpty(hdnContentModuleId.Value))
                {
                    strContentModuleId = EncryptionManager.Decrypt(hdnContentModuleId.Value);
                }
                if (string.IsNullOrEmpty(strClientId) && !string.IsNullOrEmpty(hdnUserId.Value))
                {
                    strSystemUserGUID = EncryptionManager.Decrypt(hdnUserId.Value);
                }

                string _strMessageId = "Course Session Expired";
                StringBuilder sb = new StringBuilder();
                sb.Append("Course Start Date time : " + hdnCStartDate.Value);
                sb.Append(" Error Log Date time : " + DateTime.UtcNow);
                sb.Append(" ClientId : " + strClientId);
                sb.Append(" LoginName : " + strSystemUserGUID);
                sb.Append(" CourseId : " + strContentModuleId);
                sb.Append(" FunctionName :  Course Player");
                sb.Append(" Duration in Minutes : " + ts.TotalMinutes);
                sb.Append(" Error :  Session expired at course player launch.");
                sb.Append(" Error from page:  /CoursePlayer/ControlFrame.aspx.");

                Exception expCommon = new Exception(sb.ToString());

                //var _expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
            }
            catch
            {

            }

        }

        #region SaveCurrentSco

        private void SaveCurrentSco(XmlDocument requestXml)
        {
            //TrackingSessionMetaData trackingMetaData = new TrackingSessionMetaData(); //// ///*** GetTrackingMetaData();
            TrackingSessionMetaData trackingMetaData = GetTrackingMetaData();
            //trackingMetaData.CourseId = "COM22A5EFEB602941E0";
            //trackingMetaData.LearnerId = "LERDE6B953039A04B17"; ///*** CHANGE THIS hardcode
            //Since only SCORM clients will call this, initializing the serializer is ok
            var lesson = new ScoTrackingSerializer().ParseLesson(requestXml.SelectSingleNode("//sco"));
            string strContentModuleId = string.Empty;
            //string strClientId = string.Empty;


            //if (LMSSession.IsInSession(Client.CLIENT_SESSION_ID))
            //    strClientId = Convert.ToString(LMSSession.GetValue(Client.CLIENT_SESSION_ID));

            //if (string.IsNullOrEmpty(strClientId) && !string.IsNullOrEmpty(hdnClientId.Value))
            //{
            //    strClientId = EncryptionManager.Decrypt(hdnClientId.Value);
            //}

            //int hCount = 0;
            //int.TryParse(Convert.ToString(hdnCount.Value), out hCount);

            //if (hCount == 2)
            //    strClientId = "";

            //if (!string.IsNullOrEmpty(strClientId))
            //{
                ContentModuleTracking objTrack = null;
                //For Not update data in second attempt
                if (ViewState["objTrack"] == null)
                {
                    objTrack = new ContentModuleTracking();
                    //objTrack.ClientId = strClientId;
                    //objTrack.ActivityId = trackingMetaData.CourseId;
                    objTrack.ContentModuleId = trackingMetaData.CourseId;
                    //objTrack.LearnerId = trackingMetaData.LearnerId;
                    objTrack.UserID = trackingMetaData.LearnerId;
                    objTrack.SessionId = trackingMetaData.SessionId;
                    objTrack = new ContentModuleTrackingManager().Execute(objTrack, ContentModuleTracking.Method.Get);

                }
                else
                {
                    objTrack = (ContentModuleTracking)ViewState["objTrack"];
                }

                //if (objTrack != null)
                //{
                    //string userdataxml = objTrack.UserDataXML;
                objTrack = new ContentModuleTrackingManager().Execute(objTrack, ContentModuleTracking.Method.GenerateLog);
                //}
                if (objTrack == null || objTrack.CompletionStatus != ActivityCompletionStatus.Completed)
                TrackingManager.SaveTracking(lesson, trackingMetaData);
               

        }
        #endregion

        #region GetTrackingMetaData

        private TrackingSessionMetaData GetTrackingMetaData()
        {
            var metaData = new TrackingSessionMetaData
                       {
                           SessionId = sessionId,
                           LearnerId = learnerId,
                           CourseId = courseId,
                           ContentType = ActivityContentType.Scorm12.ToString()
                       };
            return metaData;
        }
        #endregion

        #region SaveSuspendData

        private void SaveSuspendData(XmlDocument requestXml)
        {
            string strContentModuleId = string.Empty;
            string strAttempId = string.Empty;
            string strSystemUserGUID = string.Empty;
            string strClientId = string.Empty;

            if (LMSSession.IsInSession(ContentKeys.SESSION_ACTIVITYID))
                strContentModuleId = Convert.ToString(LMSSession.GetValue(ContentKeys.SESSION_ACTIVITYID));
            if (LMSSession.IsInSession(ContentKeys.SESSION_ATTEMPT_ID))
                strAttempId = Convert.ToString(LMSSession.GetValue(ContentKeys.SESSION_ATTEMPT_ID));
            if (LMSSession.IsInSession(ContentKeys.SESSION_LEARNER_ID))
                strSystemUserGUID = Convert.ToString(LMSSession.GetValue(ContentKeys.SESSION_LEARNER_ID));
            if (LMSSession.IsInSession("CLIENT_SESSION_ID"))
                strClientId = Convert.ToString(LMSSession.GetValue("CLIENT_SESSION_ID"));

            if (string.IsNullOrEmpty(strClientId) && !string.IsNullOrEmpty(hdnClientId.Value))
            {
                strClientId = EncryptionManager.Decrypt(hdnClientId.Value);
            }

            if (string.IsNullOrEmpty(strClientId) && !string.IsNullOrEmpty(hdnContentModuleId.Value))
            {
                strContentModuleId = EncryptionManager.Decrypt(hdnContentModuleId.Value);
            }

            if (string.IsNullOrEmpty(strClientId) && !string.IsNullOrEmpty(hdnUserId.Value))
            {
                strSystemUserGUID = EncryptionManager.Decrypt(hdnUserId.Value);
            }


            if (string.IsNullOrEmpty(strContentModuleId) || string.IsNullOrEmpty(strSystemUserGUID) || string.IsNullOrEmpty(strClientId))
            {
                RedirectToMainPage();
            }
            else
            {
                //var activityAssignment = CoursePlayerAssignmentManager.GetAssignmentForLaunch(strClientId, strContentModuleId, strSystemUserGUID, LaunchSite.Learner);
                //if (activityAssignment.ActivityStatus != ActivityCompletionStatus.Completed)
                //{
                    //List<UserAssessmentQuestionTracking> lstQTrack = BusinessManager.UserDataXMLUtil.GetSuspendData(requestXml, strContentModuleId, strAttempId, strSystemUserGUID, strClientId);

                    //#region SaveTracking
                    //if (lstQTrack != null && lstQTrack.Count > 0)
                    //{
                    //    try
                    //    {
                    //        UserAssessmentQuestionTrackingManager objAssessmentQTrackMgr = new UserAssessmentQuestionTrackingManager();
                    //        List<UserAssessmentQuestionTracking> lstRetAssessmentQTrack = new List<UserAssessmentQuestionTracking>();

                    //        lstRetAssessmentQTrack = objAssessmentQTrackMgr.Execute(lstQTrack, UserAssessmentQuestionTracking.ListMethod.BulkAdd);
                    //    }
                    //    catch
                    //    {

                    //    }
                    //}
                    //#endregion
                //}
            }
        }

        #endregion

        #region getSuspendData

        //Not being Used
        private string[] getSuspendData(XmlDocument requestXml)
        {
            string[] strSuspendedData = null;
            string strUserDataXml = requestXml.InnerXml;
            char[] chartext = { '#' };
            if (!string.IsNullOrEmpty(strUserDataXml) && (strUserDataXml.Contains("#")))
            {
                strSuspendedData = strUserDataXml.Split(chartext);
            }
            return strSuspendedData;
        }
        #endregion

        #region getData

        private string[] getData(string[] strSuspendedData)
        {
            string strReturn = string.Empty;
            string[] strsplit = null;
            char[] chartext = { ',' };
            if (strSuspendedData.Length > 0)
            {
                foreach (string strDta in strSuspendedData)
                {
                    strsplit = strDta.Split(chartext);
                }
            }
            return strsplit;
        }
        #endregion

        #region GetUserCourseStatusData

        #endregion

       

       

    }

    [Serializable]
    public class MedKeyCompletionDetail
    {
        string _struser_id = string.Empty;
        public string user_id
        {
            get { return _struser_id; }
            set { _struser_id = value; }
        }
        string _strcode = string.Empty;
        public string code
        {
            get { return _strcode; }
            set { _strcode = value; }
        }

        string _stracc_points = string.Empty;
        public string acc_points
        {
            get { return _stracc_points; }
            set { _stracc_points = value; }
        }

        string _strcourse_status = string.Empty;
        public string course_status
        {
            get { return _strcourse_status; }
            set { _strcourse_status = value; }
        }

        string _strcourse_name = string.Empty;
        public string course_name
        {
            get { return _strcourse_name; }
            set { _strcourse_name = value; }
        }

        string _strcourse_id = string.Empty;
        public string course_id
        {
            get { return _strcourse_id; }
            set { _strcourse_id = value; }
        }
    }


    [Serializable]
    public class CompletionDetails
    {
        string _strcourseid = string.Empty;
        public string course_id
        {
            get { return _strcourseid; }
            set { _strcourseid = value; }
        }

        string _strcompleted_datetime = string.Empty;
        public string completed_datetime
        {
            get { return _strcompleted_datetime; }
            set { _strcompleted_datetime = value; }
        }
    }

    [Serializable]
    public class Result
    {
        string _strstatus = string.Empty;
        public string status
        {
            get { return _strstatus; }
            set { _strstatus = value; }
        }

        string _strdata = string.Empty;
        public string message
        {
            get { return _strdata; }
            set { _strdata = value; }
        }

        int _intcode;
        public int code
        {
            get { return _intcode; }
            set { _intcode = value; }
        }

    }
    [Serializable]
    public class MedKeyResult
    {
        string _strstatus = string.Empty;
        public string status
        {
            get { return _strstatus; }
            set { _strstatus = value; }
        }

        string _strerror_nr;
        public string error_nr
        {
            get { return _strerror_nr; }
            set { _strerror_nr = value; }
        }

        string _strerror_type = string.Empty;
        public string error_type
        {
            get { return _strerror_type; }
            set { _strerror_type = value; }
        }


        string _strerror_message = string.Empty;
        public string error_message
        {
            get { return _strerror_message; }
            set { _strerror_message = value; }
        }

    }
}
