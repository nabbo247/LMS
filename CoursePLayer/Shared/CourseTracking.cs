using System;
using System.Configuration;
using System.Web;




namespace HRS.CoursePlayer
{
    public class CourseTracking
    {
        

        public static string UserDataXmlPath
        {
            get { return EncryptionManager.Decrypt(ConfigurationManager.AppSettings[CommonKeys.USER_DATA_XML_PATH]); }
        }

        public enum UserDataXmlStoreType
        {
            DATABASE,
            CONTENTSERVER
        }

        public static bool IsStoreToContentServer()
        {
            return (GetUserDataXmlType() == UserDataXmlStoreType.CONTENTSERVER);
        }


       
        private static UserDataXmlStoreType GetUserDataXmlType()
        {
            string _strClientId = string.Empty;
            const string cacheKey = "UserDataXmlStoreType";
            var storeType = UserDataXmlStoreType.CONTENTSERVER;
            if (HttpContext.Current.Session[cacheKey] == null)
            {
                HttpContext.Current.Session[cacheKey] = storeType;
            } 
            else
            {
                storeType = (UserDataXmlStoreType)HttpContext.Current.Session[cacheKey];
            }
            return storeType;
        }
    }
}
