using System;
using System.Collections.Generic;
using System.Web;





namespace HRS.CoursePlayer
{
    /// <summary>
    /// Cpmmon calss for handling Session
    /// </summary>
    public class LMSSession
    {
        //static string strMessageId = Services.Messages.LiveSession.DL_ERROR;
        //static CustomException expCustom;
        //static ClientManager _mgrClient = new ClientManager();
        ////static LiveSessionManager _mgrLiveSession = new LiveSessionManager();
        public static bool IS_IN_USE = true;

        /// <summary>
        /// returns value from session, always call InSession(string pKey) before calling this function 
        /// </summary>
        /// <param name="pKey">Session object Key</param>
        /// <returns>Object in Session</returns>
        public static object GetValue(string pKey)
        {
            object objReturn = null;
            bool bIsActive;
            LiveSession entSession = new LiveSession();
            if (IS_IN_USE && !String.IsNullOrEmpty(pKey))
            {
                try
                {
                    if (string.Equals(pKey, Learner.USER_SESSION_ID))
                    {
                        bIsActive = IsActive();
                    }
                    else
                    {
                        bIsActive = true;
                    }
                    if (bIsActive)
                    {
                        objReturn = HttpContext.Current.Session[pKey];
                        ////if (string.Equals(pKey, Learner.USER_SESSION_ID))
                        ////{
                        ////    entSession.ID = HttpContext.Current.Session.SessionID;
                        ////    entSession.ClientId = GetClientIdInSeesion();
                        ////    entSession = _mgrLiveSession.Execute(entSession, LiveSession.Method.SetSessionTimeStamp);
                        ////}
                    }
                    else
                    {
                        ////throw new CustomException(Services.Messages.LiveSession.NOT_ACTIVE, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Information, null, false);
                    }
                }
                ////catch (CustomException expCust)
                ////{
                ////    throw expCust;
                ////}
                catch (Exception expCommon)
                {
                    ////expCustom = new CustomException(strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Information, expCommon, true);
                }
            }
            return objReturn;
        }

        /// <summary>
        /// returns value from session without validation 
        /// </summary>
        /// <param name="pKey">Session object Key</param>
        /// <returns>Object in Session</returns>
        public static object GetDirectValue(string pKey)
        {
            object objReturn = null;
            if (IS_IN_USE && !String.IsNullOrEmpty(pKey))
            {
                try
                {
                    objReturn = HttpContext.Current.Session[pKey];
                }
                catch
                {
                    objReturn = null;
                }
            }
            return objReturn;
        }

        /// <summary>
        /// Check whether object with given Key exist in Session  
        /// </summary>
        /// <param name="pKey">Session object Key</param>
        /// <returns>true/false</returns>
        public static bool IsInSession(string pKey)
        {
            if (IS_IN_USE && !String.IsNullOrEmpty(pKey) && HttpContext.Current.Session[pKey] != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Abandon
        /// </summary>
        private static void AbandonSession()
        {
            if (IS_IN_USE)
            {
                HttpContext.Current.Session.Abandon();
            }
        }

        /// <summary>
        /// Clear
        /// </summary>
        public static void ClearSession()
        {
            if (IS_IN_USE)
            {
                HttpContext.Current.Session.Clear();
            }
        }

        /// <summary>
        /// Removes value from session, always call IsInSession(string pKey) before calling this function 
        /// </summary>
        /// <param name="pKey">Session object Key</param>
        public static void RemoveSessionItem(string pKey)
        {
            if (IS_IN_USE && !String.IsNullOrEmpty(pKey))
            {
                HttpContext.Current.Session.Remove(pKey);
            }
        }

        /// <summary>
        /// Add value to session
        /// </summary>
        /// <param name="pKey">Session object Key</param>
        /// <param name="pValue">Session object to add</param>
        public static void AddSessionItem(string pKey, object pValue)
        {
            if (!IS_IN_USE)
            {
                return;
            }
            if (!String.IsNullOrEmpty(pKey))
            {
                try
                {
                    HttpContext.Current.Session.Add(pKey, pValue);
                  
                    ////if (pKey == Learner.USER_SESSION_ID && pValue != null)
                    ////{
                    ////    if (pValue.GetType() == typeof(Learner))
                    ////    {
                    ////        Learner learner = (Learner)pValue;
                    ////        AddUser(learner.ID, GetUserRole(learner.UserAdminRole));
                    ////    }
                    ////    else
                    ////    {
                    ////        AddUser(pValue.ToString(), "Learner");
                    ////    }
                    ////}
                }
                catch (Exception expCommon)
                {
                    ////expCustom = new CustomException(strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Information, expCommon, true);
                    ////throw expCustom;
                }
            }
            else
            {
                ////expCustom = new CustomException(Common.INVALID_KEY, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Information, null, false);
                ////throw expCustom;
            }
        }


        public static void AddSessionItem(string pKey, object pValue,string OS,string Browser, string JavascriptVersion,string FlashVersion, bool SupportCookies, bool SupportActivexControls)
        {
            if (!IS_IN_USE)
            {
                return;
            }
            if (!String.IsNullOrEmpty(pKey))
            {
                try
                {
                    HttpContext.Current.Session.Add(pKey, pValue);

                    ////if (pKey == Learner.USER_SESSION_ID && pValue != null)
                    ////{
                    ////    if (pValue.GetType() == typeof(Learner))
                    ////    {
                    ////        Learner learner = (Learner)pValue;
                           
                    ////        AddUser(learner.ID, GetUserRole(learner.UserAdminRole),OS,Browser,JavascriptVersion,FlashVersion,SupportCookies,SupportActivexControls);

                    ////    }
                    ////    else
                    ////    {
                    ////        AddUser(pValue.ToString(), "Learner", OS,Browser,JavascriptVersion,FlashVersion,SupportCookies,SupportActivexControls);
                    ////    }
                    ////}
                }
                catch (Exception expCommon)
                {
                    ////expCustom = new CustomException(strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Information, expCommon, true);
                    ////throw expCustom;
                }
            }
            ////else
            ////{
            ////    expCustom = new CustomException(Common.INVALID_KEY, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Information, null, false);
            ////    throw expCustom;
            ////}
        }

        /// <summary>
        /// Set time out for Session
        /// </summary>
        /// <param name="pMinutes"></param>
        static void SetTimeOut(int pMinutes)
        {
            if (IS_IN_USE)
            {
                HttpContext.Current.Session.Timeout = pMinutes;
            }
        }

        /// <summary>
        /// Session starts
        /// </summary>
        /// <param name="pMinutes"></param>
        public static void Start(string pClientId)
        {
            if (!IS_IN_USE)
            {
                return;
            }
            ////Client entClient = new Client();
            ////entClient.ID = pClientId;
            ////if (!string.IsNullOrEmpty(pClientId))
            ////{
            ////    try
            ////    {
            ////        AddSessionItem(Client.CLIENT_SESSION_ID, pClientId);
            ////        entClient = _mgrClient.Execute(entClient, Client.Method.Get);
            ////        if (entClient.SessionTimeOut > 0)
            ////        {
            ////            SetTimeOut(entClient.SessionTimeOut);
            ////        }
            ////    }
            ////    catch (Exception expCommon)
            ////    {
            ////        expCustom = new CustomException(strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
            ////    }
            ////}
            ////else
            ////{
            ////    ////throw new CustomException(Services.Messages.Client.INVALID_CLIENT_ID, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, null, true);
            ////}
        }

        /// <summary>
        /// Session starts
        /// </summary>
        /// <param name="pMinutes"></param>
        private static void AddUser(string pLearnerId, string pUserType)
        {
            ////LiveSession entSession = new LiveSession();
            ////try
            ////{
            ////    ////entSession.ClientId = GetClientIdInSeesion();
            ////    entSession.ID = HttpContext.Current.Session.SessionID;
            ////    entSession.SessionStatus = true;
            ////    entSession.SessionServerIP = Environment.MachineName;
            ////    entSession.SessionStartDate = DateTime.Now;
            ////    entSession.SystemUserGUID = pLearnerId;
            ////    entSession.UserType = pUserType;

            ////    entSession = _mgrLiveSession.Execute(entSession, LiveSession.Method.Add);
            ////}
            ////catch (Exception expCommon)
            ////{
            ////    ////expCustom = new CustomException(strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
            ////}
        }

        public static void AddUser(string pLearnerId, string pUserType,string pOS, string pBrowser, string pJavascriptVersion, string pFlashVersion,bool pSupportCookies,bool pSupportActivexControls)
        {
            ////LiveSession entSession = new LiveSession();
            ////try
            ////{
            ////    entSession.ClientId = GetClientIdInSeesion();
            ////    entSession.ID = HttpContext.Current.Session.SessionID;
            ////    entSession.SessionStatus = true;
            ////    entSession.SessionServerIP = Environment.MachineName;
            ////    entSession.SessionStartDate = DateTime.Now;
            ////    entSession.SystemUserGUID = pLearnerId;
            ////    entSession.UserType = pUserType;

            ////    entSession.OperatingSystem = pOS;
            ////    entSession.Browser = pBrowser;
            ////    entSession.JavascriptVersion = pJavascriptVersion;
            ////    entSession.FlashVersion = pFlashVersion;
            ////    entSession.SupportCookies = pSupportCookies;
            ////    entSession.SupportActivexControls = pSupportActivexControls;

            ////    entSession = _mgrLiveSession.Execute(entSession, LiveSession.Method.Add);
            ////}
            ////catch (Exception expCommon)
            ////{
            ////    ////expCustom = new CustomException(strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
            ////}
        }

        /////// <summary>
        /////// Returns Role Id to Store
        /////// </summary>
        /////// <param name="list">Role List</param>
        /////// <returns>Role Id</returns>
        ////private static string GetUserRole(List<UserAdminRole> plistRole)
        ////{
        ////    string strRole = string.Empty;
        ////    foreach (UserAdminRole role in plistRole)
        ////    {
        ////        if (role.RoleId == AdminRole.SITE_ADMIN_ROLE_ID || role.RoleId == AdminRole.SUPER_ADMIN_ROLE_ID)
        ////        {
        ////            return role.RoleId;
        ////        }
        ////        else
        ////        {
        ////            strRole = role.RoleId;
        ////        }
        ////    }
        ////    return strRole;
        ////}

        /// <summary>
        /// Session Ends
        /// </summary>       
        public static void End(string pClientId)
        {
            if (!IS_IN_USE)
            {
                return;
            }
            ////LiveSession entSession = new LiveSession();
            ////try
            ////{
            ////    entSession.ID = HttpContext.Current.Session.SessionID;
            ////    entSession.ClientId = pClientId;
            ////    entSession = _mgrLiveSession.Execute(entSession, LiveSession.Method.Delete);
            ////    AbandonSession();
            ////}
            ////catch (Exception expCommon)
            ////{
            ////    expCustom = new CustomException(strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
            ////}
        }

        /// <summary>
        /// Check for IsLocked and IsActive
        /// </summary>
        /// <returns></returns>
        private static bool IsActive()
        {
            bool bIsActive = true;
            
            return bIsActive;
        }

        /////// <summary>
        /////// Client Id in Seesion
        /////// </summary>        
        ////public static string GetClientIdInSeesion()
        ////{
        ////    if (IS_IN_USE && HttpContext.Current.Session[Client.CLIENT_SESSION_ID] != null)
        ////    {
        ////        return Convert.ToString(HttpContext.Current.Session[Client.CLIENT_SESSION_ID]);
        ////    }
        ////    else
        ////        return string.Empty;
        ////}
    }
}