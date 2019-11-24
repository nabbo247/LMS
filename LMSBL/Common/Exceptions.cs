using System;
using System.Data;
using LMSBL.Repository;
using context = System.Web.HttpContext;

namespace LMSBL.Common
{
    public class Exceptions
    {
        private static String exepurl = "";
        public void AddException(Exception ex)
        {
            exepurl = context.Current.Request.Url.AbsolutePath;
            DataRepository db = new DataRepository();
            db.AddParameter("@ExceptionMsg", SqlDbType.Text, ex.Message.ToString());
            db.AddParameter("@ExceptionType", SqlDbType.Text, ex.GetType().Name.ToString());
            db.AddParameter("@ExceptionURL", SqlDbType.Text, exepurl);
            db.AddParameter("@ExceptionSource", SqlDbType.Text, ex.StackTrace.ToString());
            db.ExecuteQuery("sp_AddError");
        }
    }
}
