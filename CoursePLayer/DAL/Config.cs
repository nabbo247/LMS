using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.Common;
using System.Web;
namespace HRS.CoursePlayer
{
    public class Config
    {
        public static string ConnectionString
        {
            get
            {

                string val = "";

                if (ConfigurationManager.AppSettings["ConnString"] != null)
                    val = ConfigurationManager.AppSettings["ConnString"];

                return val;
            }
        }
        public static string DbType
        {
            get
            {
                return ConfigurationManager.AppSettings["DbType"];
            }
        }
        public static DbConnection GetConnection()
        {
            DbProviderFactory fact = DbProviderFactories.GetFactory("System.Data.SqlClient");//"System.Data.SqlClient"
            DbConnection conn = fact.CreateConnection();
            conn.ConnectionString = Config.ConnectionString;
            conn.Open();
            return conn;
        }
        public static DbParameter GetParameter(DbProviderFactory fact, string ParameterName, string Parametervalue)
        {
            DbParameter objparam = fact.CreateParameter();
            objparam.ParameterName = ParameterName;
            objparam.Value = Parametervalue;
            return objparam;
        }

        public static string LearnerID
        {
            get
            {
                if (HttpContext.Current.Session["LearnerID"] != null)
                    return HttpContext.Current.Session["LearnerID"].ToString();
                else
                    return "";
            }
        }
        public static int PageSize
        {
            get
            {
                if (ConfigurationManager.AppSettings["PageSize"] != null)
                    return Convert.ToInt32(ConfigurationManager.AppSettings["PageSize"]);
                else
                    return 20;
            }
        }

        public static string ApplicationURL
        {
            get
            {
                return HttpContext.Current.Request.Url.AbsoluteUri;
            }
        }

    }
}
