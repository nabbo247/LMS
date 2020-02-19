using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml.Linq;


using System.Web;
using System.IO;
using System.Diagnostics;

namespace HRS.CoursePlayer
{
    public class SQLHelper
    {
        private static SqlConnection sqlConnectionMaster;
        //private static SqlConnection sqlConnectionClient;
        public static string MasterConnectionString = string.Empty;

        const int itryCount = 10;

        /// <summary>
        /// Log the Stored Procedure name and a stack trace to a log file
        /// </summary>
        /// <param name="sql"></param>
        private static void LogSql(string sql)
        {
            if (false)
            {
                StreamWriter sw = new StreamWriter(@"C:\logfile.txt", true);
                // StackTrace constructor arguments
                // 1 - start with the calling method (don't include this method)
                // true - include info on the file (name, path, etc)
                StackTrace callStack = new StackTrace(1, true);
                string line = sql;
                // limiting the trace depth to 12 cuts out most of the uninteresting 
                // Page and Request framework calls
                for (int i = 0; i < 12; i++)
                {
                    StackFrame sf = callStack.GetFrame(i);
                    line += "\t" + sf.GetMethod().DeclaringType.Name + "." + sf.GetMethod().Name;
                }
                sw.WriteLine(line);
                sw.Flush();
                sw.Close();
            }
        }

        public static void ReplaceWildCards(SqlCommand command)
        {
            foreach (SqlParameter parameter in command.Parameters)
            {
                var value = (parameter.Value) as string;
                if (!String.IsNullOrEmpty(value))
                {
                    parameter.Value = value.Replace('*', '%');
                }
            }
        }
        //public static string FormatUserSearchCriteria(UserSearchCriteria criteria)
        //{
        //    Func<DateTime?, string> snagDate = d => d.HasValue ? d.Value.ToString("yyyy-MM-dd") : String.Empty;
        //    return new XDocument(new XElement("search",
        //                                      new XElement("FirstName", criteria.FirstName),
        //                                      new XElement("LastName", criteria.LastName),
        //                                      new XElement("LoginId", criteria.LoginId),
        //                                      new XElement("RuleUsers", criteria.RuleUsers),
        //                                      new XElement("Email", criteria.Email),
        //                                      new XElement("RegistrationDateFrom",
        //                                                   snagDate(criteria.RegistrationDateFrom)),
        //                                      new XElement("RegistrationDateTo", snagDate(criteria.RegistrationDateTo)),
        //                                      new XElement("TerminationDateFrom", snagDate(criteria.TerminationDateFrom)),
        //                                      new XElement("TerminationDateTo", snagDate(criteria.TerminationDateTo)),
        //                                      new XElement("ManagerName", criteria.ManagerName),
        //                                      new XElement("UnitId", criteria.UnitId),
        //                                      new XElement("LevelId", criteria.LevelId),
        //                                      new XElement("Active",
        //                                                   criteria.Active.HasValue
        //                                                       ? (criteria.Active.Value ? "1" : "0")
        //                                                       : String.Empty)

        //                             )).ToString().Replace('*', '%');
        //}
        /// <summary>
        /// Execute Command on Master Database
        /// </summary>
        /// <param name="pCommand">SQL Command</param>        
        /// <returns>SqlDataReader object</returns>
        public static SqlDataReader ExecuteMasterReader(SqlCommand pCommand,bool pisConOpen)
        {     
            LogSql(pCommand.CommandText);
            pCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlreader = null;            
            if (!pisConOpen)
            {
                pCommand.Connection.Open();
            }                
            sqlreader = pCommand.ExecuteReader();            
            return sqlreader;
        }

        /// <summary>
        /// Execute Command with Scalar method on Master Database
        /// </summary>
        /// <param name="pCommand">SQL Command</param>        
        /// <returns>Object</returns>
        public static Object ExecuteMasterScalar(SqlCommand pCommand)
        {
            LogSql(pCommand.CommandText);

            sqlConnectionMaster = new SqlConnection(GetMasterDBConnString());
            pCommand.CommandType = CommandType.StoredProcedure;
            Object objScalarReturn = null;
            int iTry =0 ;
            try
            {
                pCommand.Connection = sqlConnectionMaster;                
                while (sqlConnectionMaster.State != ConnectionState.Open && iTry < itryCount)
                {
                    if (sqlConnectionMaster.State != ConnectionState.Connecting)
                    {
                        sqlConnectionMaster.Open();
                    }
                    if (sqlConnectionMaster.State == ConnectionState.Open)
                    {                        
                        objScalarReturn = pCommand.ExecuteScalar();
                        break; 
                    }
                    iTry++;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (sqlConnectionMaster!=null && sqlConnectionMaster.State != ConnectionState.Closed)
                    sqlConnectionMaster.Close();                
            }
            return objScalarReturn;
        }

        /// <summary>
        /// Execute Command with Scalar method on Master Database
        /// </summary>
        /// <param name="pCommand">SQL Command</param>        
        /// <returns>Object</returns>
        public static Object ExecuteScalar(SqlCommand pCommand, bool pIsConnOpen)
        {
            LogSql(pCommand.CommandText);

            pCommand.CommandType = CommandType.StoredProcedure;
            Object objScalarReturn = null;
            try
            {
                if (!pIsConnOpen)
                {
                    pCommand.Connection.Open();
                }
                objScalarReturn = pCommand.ExecuteScalar();
            }
            catch
            {
                throw;
            }
            return objScalarReturn;
        }

        
        /// <summary>
        /// Method with Client Database connectionstring 
        /// It is the responsibility of the caller to close reader when finished.
        /// </summary>
        /// <param name="pCommand">SQL Command</param>
        /// <param name="pIsConnOpen">Is Connection Open</param>
        /// <returns>SqlDataReader object</returns>
        public static SqlDataReader SqlDataReader(SqlCommand pCommand, bool pIsConnOpen)
        {
            LogSql(pCommand.CommandText);

            SqlDataReader sqlreader;
            pCommand.CommandType = CommandType.StoredProcedure;
            if (!pIsConnOpen)
            {
                pCommand.Connection.Open();   
            }
            sqlreader = pCommand.ExecuteReader();
            return sqlreader;
        }

        /// <summary>
        /// Execute Command for Single Update
        /// </summary>
        /// <param name="pCommand">SQL Command</param>
        /// <param name="pConnString">Connection string</param>
        /// <returns>returns true if success</returns>
        public static int ExecuteNonQuery(SqlCommand pCommand, string pConnString)
        {
            LogSql(pCommand.CommandText);

            int i = 0;
            pCommand.CommandType = CommandType.StoredProcedure;
            //SqlTransaction sqltransaction = null;
            //bool bIsExecuted = false;
            using (SqlConnection sqlcon = new SqlConnection(pConnString))
            {
                sqlcon.Open();
                //sqltransaction = sqlcon.BeginTransaction();
                pCommand.Connection = sqlcon;
                //pCommand.Transaction = sqltransaction;
                i = pCommand.ExecuteNonQuery();
                //sqltransaction.Commit();
                //bIsExecuted = true;
            }
            return i;
        }

        /// <summary>
        /// Execute Command for Single Update
        /// </summary>
        /// <param name="pCommand">SQL Command</param>
        /// <param name="pConnString">Connection string</param>
        /// <param name="pIsExecuted">boolean Is Executed</param>
        /// <returns>returns true if success</returns>
        public static bool ExecuteNonQuery(SqlCommand pCommand, string pConnString, bool pIsExecuted)
        {
            LogSql(pCommand.CommandText);

            pCommand.CommandType = CommandType.StoredProcedure;
            pIsExecuted = false;
            using (SqlConnection sqlcon = new SqlConnection(pConnString))
            {
                sqlcon.Open();
                pCommand.Connection = sqlcon;
                pCommand.ExecuteNonQuery();                
                pIsExecuted = true;
            }
            return pIsExecuted;
        }

        /// <summary>
        /// To execute DML/DDL statements
        /// </summary>
        /// <param name="pCommand"></param>
        /// <returns>Returns true if success</returns>
        public static bool ExecuteNonQuery(SqlCommand pCommand)
        {
            LogSql(pCommand.CommandText);

            pCommand.CommandType = CommandType.StoredProcedure;
            bool bReturnVal = false;
            try
            {
                int i = pCommand.ExecuteNonQuery();
                bReturnVal = true;
            }
            catch 
            { 
                bReturnVal = false;
                throw;
            }
            return bReturnVal;
        }

        /// <summary>
        /// To execute DML/DDL statements
        /// </summary>
        /// <param name="pCommand"></param>
        /// <returns>Returns true if success</returns>
        public static int ExecuteNonQueryCount(SqlCommand pCommand)
        {
            LogSql(pCommand.CommandText);

            pCommand.CommandType = CommandType.StoredProcedure;
            int i = 0;
            i = pCommand.ExecuteNonQuery();
            return i;
        }

        /// <summary>
        /// To create Master database connnection string
        /// </summary>
        /// <returns> connnection string</returns>
        public static string GetMasterDBConnString()
        {
            try
            {
                //if (string.IsNullOrEmpty(MasterConnectionString))
                //{
                    MasterConnectionString = ConfigurationManager.AppSettings["ConnString"];
                    return MasterConnectionString;//ErrorHandling.EncryptionManager.Decrypt(MasterConnectionString);
                //}
                //else
                //{
                //    return ErrorHandling.EncryptionManager.Decrypt(MasterConnectionString); 
                //}
            }
            catch
            {
                return null; 
            }
        }

        /// <summary>
        /// To get requested client database connection string
        /// </summary>
        /// <param name="pClientId"></param>
        /// <returns>returns Client database connection string</returns>
        //public static string GetClientDBConnString(string pClientId)
        //{
        //    string sessionKey = "CLIENT_CONNECTION_STRING_" + pClientId;
        //    // look for it in session
        //    // make sure HttpContext.Current exists (it will not for non-web data loads)
        //    if (HttpContext.Current != null )
        //    {
        //        if (HttpContext.Current.Session !=null && HttpContext.Current.Session[sessionKey] != null)
        //        //if ( HttpContext.Current.Session[sessionKey] != null)
        //        {
        //            return HttpContext.Current.Session[sessionKey].ToString();
        //        }
        //    }

        //    string strConnection = string.Empty;
        //    BVLMS.Entity.Client entClient;
        //    if (string.IsNullOrEmpty(pClientId))
        //    {
        //        throw new CustomException(BVLMS.Services.Messages.Client.INVALID_CLIENT_ID, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, null, true);
        //    }
        //    if (LMSCache.IsInCache(pClientId))
        //    {
        //        entClient = (BVLMS.Entity.Client)LMSCache.GetValue(pClientId);
        //    }
        //    else
        //    {
        //        ClientDAM entClientDAM = new ClientDAM();
        //        entClient = new BVLMS.Entity.Client();
        //        entClient.ID = pClientId;
        //        entClient = entClientDAM.GetClientByID(entClient);
        //        entClientDAM = null;
        //    }
        //    strConnection = GetClientDBConnString(entClient);
        //    entClient = null;
        //    // store connection string in Session for next time
        //    // make sure HttpContext.Current exists (it will not for non-web data loads)

        //    if (HttpContext.Current != null && HttpContext.Current.Session != null )
        //    //if (HttpContext.Current != null)
        //    {
        //        HttpContext.Current.Session.Add(sessionKey, strConnection);
        //    }
        //    return strConnection;
        //}

        /// <summary>
        /// To get requested client database connection string from Client
        /// </summary>
        /// <param name="pClient">Client</param>
        /// <returns>returns Client database connection string</returns>
        //public static string GetClientDBConnString(Client pClient)
        //{
        //    // Unknown source for this return line
        //    //return "Data Source=" + pClient.DBIPAddress.Trim() + ";Initial Catalog=" + pClient.DatabaseName.Trim() + ";User ID=" + pClient.DBUID.Trim() + ";password=" + pClient.DBPassword.Trim() + ";Max Pool Size=10;Min Pool Size=4;";                       
        //    // This return line was originally in SQLObject.GetClientDBConnString(Client).  It specifies a network library.
        //    //return "Data Source=" + pClient.DBIPAddress.Trim() + ";Network Library=DBMSSOCN" + ";Initial Catalog=" + pClient.DatabaseName.Trim() + ";User ID=" + pClient.DBUID.Trim() + ";password=" + pClient.DBPassword.Trim() + ";";
        //    //return "Data Source=" + pClient.DBIPAddress.Trim() + ";Initial Catalog=" + pClient.DatabaseName.Trim() + ";User ID=" + pClient.DBUID.Trim() + ";password=" + pClient.DBPassword.Trim() + ";";
        //    return "Data Source=" + pClient.DBIPAddress.Trim() + ";Initial Catalog=" + pClient.DatabaseName.Trim() + ";User ID=" + pClient.DBUID.Trim() + ";password=" + pClient.DBPassword.Trim() + ";";
        //}

        /// <summary>
        /// Returns DataSet result from Command
        /// </summary>
        /// <param name="pCommand">SQL Command</param>
        /// <param name="pConnString">Connection string</param>
        /// <returns>DataSet</returns>
        public static DataSet SqlDataAdapter(SqlCommand pCommand, string pConnString)
        {
            LogSql(pCommand.CommandText);

            DataSet dSet = null;
            pCommand.CommandType = CommandType.StoredProcedure;
            using (SqlConnection sqlconn = new SqlConnection(pConnString))
            {
                pCommand.Connection = sqlconn;
                dSet = SqlDataAdapter(pCommand);
            }
            return dSet;
        }


        public static DataSet SqlDataAdapter(SqlCommand pCommand)
        {
            LogSql(pCommand.CommandText);

            DataSet dSet = null;
            pCommand.CommandType = CommandType.StoredProcedure;
            dSet = new DataSet();
            using (SqlDataAdapter dataAdaptor = new SqlDataAdapter(pCommand))
            {
                dataAdaptor.Fill(dSet);
            }
            return dSet;
        }

        /// <summary>
        /// Check for Column 
        /// </summary>
        /// <param name="reader">Reader to Check</param>
        /// <param name="pColumnName">Name</param>
        /// <returns></returns>
        public static bool ReaderHasColumn(IDataReader reader, string pColumnName)
        {
            reader.GetSchemaTable().DefaultView.RowFilter = "ColumnName= '" + pColumnName + "'";
            return (reader.GetSchemaTable().DefaultView.Count > 0);

        }

        /// <summary>
        /// Convert ReportParameter to SQl Param
        /// </summary>
        /// <param name="pParam"></param>
        /// <returns></returns>
        //public static SqlParameter ConvertToSQLPara(ReportParameter pParam)
        //{
        //    SqlParameter sqlPara = new SqlParameter();
        //    sqlPara.ParameterName = pParam.Name;
        //    if (pParam.Value != null)
        //    {
        //        switch (pParam.DataType)
        //        {
        //            case ReportDataType.Date:
        //                sqlPara.Value = Convert.ToDateTime(pParam.Value);
        //                break;
        //            case ReportDataType.Numeric:
        //                sqlPara.Value = Convert.ToInt32(pParam.Value);
        //                break;
        //            case ReportDataType.Boolean:
        //                sqlPara.Value = Convert.ToBoolean(pParam.Value);
        //                break;
        //            case ReportDataType.NVarChar:
        //            case ReportDataType.VarChar:
        //            default:
        //                sqlPara.Value = Convert.ToString(pParam.Value);
        //                break;
        //        }
        //    }
        //    else
        //    {
        //        sqlPara.Value = null;
        //    }
        //    return sqlPara;
        //}

    }
}