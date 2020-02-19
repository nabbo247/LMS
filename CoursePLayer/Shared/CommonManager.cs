
using System;
using System.Configuration;
using System.Web;



using System.Collections.Generic;


namespace HRS.CoursePlayer
{
    public class CommonManager
    {
        public const string SESSION_GRID_PAGE_SIZE = "GridPageSize";
        public static int GRID_DEFAULT_PAGE_SIZE = 5;
        public const string IS_SSO_LOGIN = "IsSSOLogin";
       
		//-aw 6/29/2011
		public const string DEFAULT_PROTOCOL = "DefaultProtocol";
        public const string LANGUAGE_TEXT_DIRECTION_LTR = "ltr";
        public const string SESSION_LEARNER_CULTURE = "LearnerCulture";
        public const string COOKIES_LANG = "Lang";
        public const string SESSION_LEARNER = "Learner";
        public const string SESSION_LEARNER_TYPE = "Learner_Type";
        
        public const string SESSION_MYCULTURE = "MyCulture";
        public const string SESSION_LANG_TEXTDIRC = "LanguageDirection";


        //public static bool IsSSL()
        //{
        //    bool isSSL;
        //    string strSSLHeaderName = "HTTP_" + ConfigurationManager.AppSettings["SSLHeader_name"];
        //    string strSSLHeaderTrue = ConfigurationManager.AppSettings["SSLHeader_true"];

        //    if (HttpContext.Current.Request.ServerVariables[strSSLHeaderName] != null)
        //    {
        //        isSSL = HttpContext.Current.Request.ServerVariables[strSSLHeaderName] == strSSLHeaderTrue;
        //    }
        //    else
        //    {
        //        isSSL = HttpContext.Current.Request.IsSecureConnection;
        //    }

        //    return isSSL;
        //}

        public static string DecodeAndDecrypt(string encryptedValue)
        {
            var decodedValue = HttpContext.Current.Server.UrlDecode(encryptedValue);
            decodedValue = decodedValue.Replace(" ", "+");
            return EncryptionManager.Decrypt(decodedValue);
        }

        public static string GetScoStatus(string trackingStatus)
        {
            switch (trackingStatus.ToLower())
            {
                case "incomplete":
                    return "Incomplete";
                case "completed":
                    return "Completed";
                case "passed":
                    return "Passed";
                case "failed":
                    return "Failed";
                case "not-started":
                    return "Not Started";
                default:
                    return trackingStatus.Replace("-", " ");
            }
        }

        #region GetPageElementsText
        /// <summary>
        /// This method return page elements text.
        /// </summary>       
        /// <param name="entListPageElements">List<UserPageElementLanguage> entListPageElements</param>
        /// <param name="string">pElementName</param>
        /// <returns>string</returns>
        /// 
        //public static string GetPageElementsText(List<UserPageElementLanguage> entListPageElements, string pElementName)
        //{
        //    string strElementText = string.Empty;
        //    UserPageElementLanguage entElementSearch = new UserPageElementLanguage();
        //    entElementSearch.ElementName = pElementName;

        //    UserPageElementLanguage entElementReturn = entListPageElements.Find(delegate(UserPageElementLanguage entElement)
        //    { return entElement.ElementName == entElementSearch.ElementName; });
        //    if (entElementReturn != null)
        //    {
        //        strElementText = entElementReturn.ElementText;
        //    }

        //    return strElementText;
        //}
        #endregion

        ////#region GetPageElements
        /////// <summary>
        /////// This method return user page elements.
        /////// </summary>       
        /////// <param name="pClientId"></param>
        /////// <param name="pPageId"></param>
        /////// <param name="pLangId"></param>
        /////// <returns>string</returns>
        /////// 
        ////public static List<UserPageElementLanguage> GetPageElements(string pClientId, string pPageId, string pLangId)
        ////{
        ////    List<UserPageElementLanguage> entListPageElements = new List<UserPageElementLanguage>();
        ////    UserPage entPage = new UserPage();
        ////    UserPageManager mgrUserPage = new UserPageManager();
        ////    entPage.ClientId = pClientId;
        ////    entPage.ID = pPageId;
        ////    entPage.ParaLanguageId = pLangId;

        ////    entPage = mgrUserPage.Execute(entPage, UserPage.Method.Get);
        ////    entListPageElements = entPage.PageElementLanguage;

        ////    return entListPageElements;
        ////}
        ////#endregion

        ////#region GetLearnerLanguage
        /////// <summary>
        /////// This method return current Learner language.
        /////// </summary>       
        /////// <returns>string</returns>
        /////// 
        ////public static string GetLearnerLanguage(Client entClient)
        ////{
        ////    string _strDefaultLanguage = string.Empty;
        ////    string _strLearnerId = string.Empty;
        ////    //Check for Learner Id in session
        ////    if (LMSSession.IsInSession(Learner.USER_SESSION_ID))
        ////    {
        ////        try
        ////        {

        ////            _strLearnerId = (string)LMSSession.GetValue(Learner.USER_SESSION_ID);
        ////            _strDefaultLanguage = CommonManager.GetLearnerDefaultLanguage(_strLearnerId);
        ////        }
        ////        catch
        ////        {
        ////            Learner entInnerlearner = (Learner)LMSSession.GetValue(Learner.USER_SESSION_ID);
        ////            if (entInnerlearner != null)
        ////                _strLearnerId = entInnerlearner.ID;

        ////            _strDefaultLanguage = CommonManager.GetLearnerDefaultLanguage(_strLearnerId);

        ////        }
        ////    }
        ////    else //Get Clients Language
        ////    {
        ////        if (LMSSession.IsInSession(CommonManager.SESSION_MYCULTURE))
        ////        {
        ////            _strDefaultLanguage = Convert.ToString(LMSSession.GetValue(CommonManager.SESSION_MYCULTURE));
        ////        }
        ////        else
        ////        {
        ////            //Check client cookie is present
        ////            string strClientID = entClient.ID;
        ////            if (LMSCookie.CheckCookie(strClientID))
        ////            {
        ////                _strDefaultLanguage = LMSCookie.GetCookieParam(strClientID, CommonManager.COOKIES_LANG);
        ////                LMSSession.AddSessionItem(CommonManager.SESSION_MYCULTURE, _strDefaultLanguage);
        ////            }
        ////            else //Create client cookie and set its value
        ////            {
        ////                LMSSession.AddSessionItem(CommonManager.SESSION_MYCULTURE, entClient.DefaultLanguageId);
        ////                _strDefaultLanguage = entClient.DefaultLanguageId;
        ////            }
        ////        }
        ////    }
        ////    string strLangTextDirection = CommonManager.LANGUAGE_TEXT_DIRECTION_LTR;

        ////    if (!String.IsNullOrEmpty(entClient.Language.TextDirection))
        ////        strLangTextDirection = entClient.Language.TextDirection;
        ////    LMSSession.AddSessionItem(CommonManager.SESSION_LANG_TEXTDIRC, strLangTextDirection);

        ////    entClient = null;
        ////    return _strDefaultLanguage;
        ////}
        ////#endregion

        ////public static string GetLearnerDefaultLanguage(string strLearnerId)
        ////{
        ////    string _strDefaultLanguage = string.Empty;
        ////    //Get Learner Language is in Cookie
        ////    if (LMSCookie.CheckCookie(strLearnerId))
        ////    {
        ////        _strDefaultLanguage = LMSCookie.GetCookieParam(strLearnerId, CommonManager.COOKIES_LANG);
        ////        LMSSession.AddSessionItem(CommonManager.SESSION_LEARNER_CULTURE, _strDefaultLanguage);
        ////        LMSSession.AddSessionItem(CommonManager.SESSION_MYCULTURE, _strDefaultLanguage);
        ////    }
        ////    else
        ////    {
        ////        //Get Learner Language in Session
        ////        if (LMSSession.IsInSession(CommonManager.SESSION_LEARNER_CULTURE))
        ////        {
        ////            _strDefaultLanguage = Convert.ToString(LMSSession.GetValue(CommonManager.SESSION_LEARNER_CULTURE));
        ////            LMSSession.AddSessionItem(CommonManager.SESSION_MYCULTURE, _strDefaultLanguage);
        ////        }
        ////        else
        ////        {
        ////            //Get Learner Language from Database
        ////            Learner entLearner = new Learner();
        ////            entLearner = CommonManager.GetLearnerById(strLearnerId);
        ////            if (entLearner != null && !string.IsNullOrEmpty(entLearner.DefaultLanguageId))
        ////            {
        ////                _strDefaultLanguage = entLearner.DefaultLanguageId;
        ////            }
        ////            else
        ////            {
        ////                Client _entClient = new Client();
        ////                _entClient = CommonManager.GetClient();
        ////                _strDefaultLanguage = _entClient.DefaultLanguageId;
        ////            }
        ////            LMSSession.AddSessionItem(CommonManager.SESSION_LEARNER_CULTURE, _strDefaultLanguage);
        ////            LMSSession.AddSessionItem(CommonManager.SESSION_MYCULTURE, _strDefaultLanguage);
        ////            LMSCookie.CreateUserCookies(strLearnerId);
        ////            LMSCookie.SetCookieParam(strLearnerId, CommonManager.COOKIES_LANG, _strDefaultLanguage);
        ////        }
        ////    }
        ////    return _strDefaultLanguage;
        ////}

        #region GetLearnerById
        /// <summary>
        /// Get Learner
        /// </summary>
        /// <param name="pstrUserId"></param>
        /// <returns>Learner</returns>
        public static Learner GetLearnerById(string pstrUserId)
        {
            Learner entLearner = new Learner();
            if (LMSSession.IsInSession(CommonManager.SESSION_LEARNER))
            {
                entLearner = (Learner)LMSSession.GetValue(CommonManager.SESSION_LEARNER);
            }
            else
            {
                LearnerManager mgrLearner = new LearnerManager();
                entLearner.ID = pstrUserId;
                
                entLearner = mgrLearner.Execute(entLearner, Learner.Method.Get);
                //Add learner into session
                LMSSession.AddSessionItem(CommonManager.SESSION_LEARNER, entLearner);
            }
            return entLearner;
        }
        #endregion
        
        

      
    }


}
