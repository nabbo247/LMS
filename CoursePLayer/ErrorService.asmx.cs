
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace HRS.CoursePlayer
{
    /// <summary>
    /// Summary description for ErrorService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 

     [System.Web.Script.Services.ScriptService]
    public class ErrorService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetError(string LangId,string ClientId)
        {
            try
            {
                
                ClientId = EncryptionManager.Decrypt(ClientId);
                string msg = "COURSE_INTERNET_CONNECTION_ERROR";// MessageAdaptor.GetMessage(Services.Messages.ContentModule.COURSE_INTERNET_CONNECTION_ERROR, LangId, ClientId);
                return string.IsNullOrEmpty(msg) ? "Internet Connection error" : msg;
            }
            catch
            {
                return "Internet Connection error";
            }
        }
    }
}
