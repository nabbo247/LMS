
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.IO;
using System.Diagnostics;
namespace HRS.CoursePlayer
{
	/// <summary>
	///     Exposes static methods for writing exception occurred, that can be stored at configurable
	///     location (DataBase/EventLog/FileSystem). This class cannot be inherited.
	/// </summary>
	public class ExceptionManager
	{
		#region Static Variables
		private static Exception _lastException;
		private static string _strClientID = string.Empty;
		private static string _strLoginID = string.Empty;
		private static ErrorStoreType _errStoreTyp = ErrorStoreType.EventLog;
		private static HttpContext _context;

		private static string _strLogNameForErr = "LCP";
		private static string _strSrcNameForErr = "LCP Error";
		private static string _strCnnStringForErr = "";
		private static string _insProcForErr = "sproc_AllLog_ups";
		private static int _iSqlParaCntForErr = 9;
		private static string[] _arrSqlParasForErr = { "@LogID", "@ServerName", "@ClientID", "@SystemUserGUID", "@EventID", "@CategoryID", "@LogInfo", "@LogDescription", "@LogType" };
		private static SqlDbType[] _arrSqlDbTypForErr = { SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.VarChar, SqlDbType.Int, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar };
		private static int[] _arrSqlParaSizeForErr = { 100, 50, 100, 100, 500, 10, -1, -1, 50 };
		private static object[] _arrSqlParameterValueObjsForErr = {SqlParameterValueObjectsForError.LogID,
												 SqlParameterValueObjectsForError.ServerName, 
												 SqlParameterValueObjectsForError.ClientID,
												 SqlParameterValueObjectsForError.SystemUserGUID,
												 SqlParameterValueObjectsForError.EventID,
												 SqlParameterValueObjectsForError.CategoryID,
												 SqlParameterValueObjectsForError.LogInfo,
												 SqlParameterValueObjectsForError.LogDescription,
												 SqlParameterValueObjectsForError.LogType};
		private static string _strFilPthForErr = string.Empty;
		#endregion
		#region enums
		/// <summary>
		/// enum ErrorStoreType
		/// </summary>
		public enum ErrorStoreType
		{
			/// <summary>
			/// For Event Log
			/// </summary>
			EventLog,
			/// <summary>
			/// For File System
			/// </summary>
			FileSystem,
			/// <summary>
			/// For Database storage
			/// </summary>
			DataBase
		}
		/// <summary>
		/// Sql Parameter Value Objects For Error
		/// </summary>
		public enum SqlParameterValueObjectsForError
		{
			/// <summary>
			/// LOg Id
			/// </summary>
			LogID = 0, //strLogID
			/// <summary>
			/// 
			/// </summary>
			ServerName = 1, //strServerName
			/// <summary>
			/// Client Id
			/// </summary>
			ClientID = 2, //_strClientID
			/// <summary>
			/// UserId
			/// </summary>
			SystemUserGUID = 3, //_strLoginID
			/// <summary>
			/// Event Id
			/// </summary>
			EventID = 4, //pEventID
			/// <summary>
			/// Category Id
			/// </summary>
			CategoryID = 5, //pCategoryID
			/// <summary>
			/// Log Info
			/// </summary>
			LogInfo = 6, //pOtherInfo
			/// <summary>
			/// Log Description
			/// </summary>
			LogDescription = 7, //ErrorMsg
			/// <summary>
			/// Log Type
			/// </summary>
			LogType = 8 //strLogType
		}
		#endregion
		#region Properties
		/// <summary>
		/// LastException
		/// </summary>
		public static Exception LastException
		{
			get
			{
				return _lastException;
			}
			set
			{
				if (value != _lastException)
				{
					_lastException = value;
				}
			}
		}
		/// <summary>
		/// Client Id
		/// </summary>
		public static string ClientID
		{
			get
			{
				return _strClientID;
			}
			set
			{
				_strClientID = value;
			}
		}
		/// <summary>
		/// Login ID
		/// </summary>
		public static string LoginID
		{
			get
			{
				return _strLoginID;
			}
			set
			{
				_strLoginID = value;
			}
		}
		/// <summary>
		/// SetErrorStoreType
		/// </summary>
		public static ErrorStoreType SetErrorStoreType
		{
			get
			{
				return _errStoreTyp;
			}
			set
			{
				_errStoreTyp = value;
			}
		}
		/// <summary>
		/// LogNameForError
		/// </summary>
		public static string LogNameForError
		{
			get
			{
				return _strLogNameForErr;
			}
			set
			{
				_strLogNameForErr = value;
			}
		}
		/// <summary>
		/// SourceNameForError
		/// </summary>
		public static string SourceNameForError
		{
			get
			{
				return _strSrcNameForErr;
			}
			set
			{
				_strSrcNameForErr = value;
			}
		}
		/// <summary>
		/// ConnectionStringForError
		/// </summary>
		public static string ConnectionStringForError
		{
			get
			{
				return _strCnnStringForErr;
			}
			set
			{
				_strCnnStringForErr = value;
			}
		}
		/// <summary>
		/// InsertProcedureForError
		/// </summary>
		public static string InsertProcedureForError
		{
			get
			{
				return _insProcForErr;
			}
			set
			{
				_insProcForErr = value;
			}
		}
		/// <summary>
		/// SqlParameterCountForError
		/// </summary>
		public static int SqlParameterCountForError
		{
			get
			{
				return _iSqlParaCntForErr;
			}
			set
			{
				_iSqlParaCntForErr = value;
			}
		}
		/// <summary>
		/// SqlParametersForError
		/// </summary>
		public static string[] SqlParametersForError
		{
			get
			{
				return _arrSqlParasForErr;
			}
			set
			{
				_arrSqlParasForErr = value;
			}
		}
		/// <summary>
		/// SqlDbTypeForError
		/// </summary>
		public static SqlDbType[] SqlDbTypeForError
		{
			get
			{
				return _arrSqlDbTypForErr;
			}
			set
			{
				_arrSqlDbTypForErr = value;
			}
		}
		/// <summary>
		/// sqlParameterSizeForError
		/// </summary>
		public static int[] sqlParameterSizeForError
		{
			get
			{
				return _arrSqlParaSizeForErr;
			}
			set
			{
				_arrSqlParaSizeForErr = value;
			}
		}
		/// <summary>
		/// SetsqlParameterValueObjectsForError
		/// </summary>
		public static object[] SetsqlParameterValueObjectsForError
		{
			get
			{
				return _arrSqlParameterValueObjsForErr;
			}
			set
			{
				_arrSqlParameterValueObjsForErr = value;
			}
		}
		/// <summary>
		/// File Path ForError
		/// </summary>
		public static string FilePathForError
		{
			get
			{
				return _strFilPthForErr;
			}
			set
			{
				_strFilPthForErr = value;
			}
		}
		#endregion
		
		#region ErrorOperations
		/// <summary>
		/// Write the error to the configured location. 
		/// </summary>
		/// <param name="pExc">The System.Exception that holds the error occur during application execution.</param>
		/// <param name="pEventID">Represents interger for event identification.</param>
		/// <param name="pCategoryID">Represents short for category identification.</param>
		/// <param name="pOtherInfo">Represents Additional inforamation or comments.</param>
		/// <returns>Returns the error code, or an empty string("").</returns>
		public static string WriteError(Exception pExc, string pEventID, short pCategoryID, string pOtherInfo)
		{
			string strErrCode = "";
			_context = HttpContext.Current;

			switch (SetErrorStoreType)
			{
				case ErrorStoreType.DataBase:
					{
						strErrCode = WriteErrorToDataBase(pExc, pEventID, pCategoryID, pOtherInfo);
						break;
					}
				case ErrorStoreType.EventLog:
					{
						strErrCode = WriteErrorToEventLog(pExc, pEventID, pCategoryID, pOtherInfo);
						break;
					}
				case ErrorStoreType.FileSystem:
					{
						strErrCode = WriteErrorToFile(pExc, pEventID, pCategoryID, pOtherInfo);
						break;
					}
			}
			return strErrCode;
		}
		/// <summary>
		/// Write Error To Event Log
		/// </summary>
		/// <param name="pExc"></param>
		/// <param name="pEventID"></param>
		/// <param name="pCategoryID"></param>
		/// <param name="pOtherInfo"></param>
		/// <returns></returns>
		private static string WriteErrorToEventLog(Exception pExc, string pEventID, short pCategoryID, string pOtherInfo)
		{
			if (_strSrcNameForErr == "" && _strLogNameForErr == "")
			{
				if (_context == null)
				{
					_strSrcNameForErr = "MortgageU Application";
					_strLogNameForErr = "Application";
				}
				else
				{
					_strSrcNameForErr = Convert.ToString(_context.Request.ApplicationPath) + " Error";
					_strLogNameForErr = Convert.ToString(_context.Request.ApplicationPath);
				}
			}
			if (!EventLog.SourceExists(_strSrcNameForErr))
			{
				EventSourceCreationData data = new EventSourceCreationData(_strSrcNameForErr, _strLogNameForErr);
				EventLog.CreateEventSource(data);
			}

			string ErrorMsg = FormatErrorMessage(pEventID, pOtherInfo, pExc);

			if (EventLog.Exists(_strLogNameForErr))
			{
				EventLog.WriteEntry(_strSrcNameForErr, ErrorMsg, EventLogEntryType.Error, 0, pCategoryID);
			}
			return string.Empty;
		}
		/// <summary>
		/// Write Error T oFile
		/// </summary>
		/// <param name="pExc"></param>
		/// <param name="pEventID"></param>
		/// <param name="pCategoryID"></param>
		/// <param name="pOtherInfo"></param>
		/// <returns></returns>
		private static string WriteErrorToFile(Exception pExc, string pEventID, short pCategoryID, string pOtherInfo)
		{
			string strErrCode = string.Empty;

			if (_strFilPthForErr == "" || _strLogNameForErr == null)
			{
				try
				{
					if (!Directory.Exists("C:\\Temp"))
					{
						Directory.CreateDirectory("C:\\Temp\\ErrorLog");
					}
					if (!Directory.Exists("C:\\Temp\\ErrorLog"))
					{
						Directory.CreateDirectory("C:\\Temp\\ErrorLog");
					}
					_strFilPthForErr = "C:\\Temp\\ErrorLog\\Errorlog.txt";
				}
				catch (Exception ExcFc)
				{
					strErrCode = WriteErrorToEventLog(pExc, pEventID, pCategoryID, pOtherInfo);
					strErrCode = WriteErrorToEventLog(ExcFc, pEventID, pCategoryID, pOtherInfo);
				}
			}
			string ErrorMsg = FormatErrorMessage(pEventID, pOtherInfo, pExc);

			if (_strFilPthForErr != string.Empty)
			{
				try
				{
					string strErrFilePath = _strFilPthForErr;
					StreamWriter swFile = new StreamWriter(strErrFilePath, true);
					swFile.WriteLine(ErrorMsg);
					swFile.Close();
				}
				catch (Exception ExcFw)
				{
					try
					{
						System.Threading.Thread.Sleep(1500);
						string strErrFilePath1 = _strFilPthForErr;
						StreamWriter swFile1 = new StreamWriter(strErrFilePath1, true);
						swFile1.WriteLine(ErrorMsg);
						swFile1.Close();
					}
					catch (Exception ExcFw1)
					{
						strErrCode = WriteErrorToEventLog(pExc, pEventID, pCategoryID, pOtherInfo);
						strErrCode = WriteErrorToEventLog(ExcFw, pEventID, pCategoryID, pOtherInfo);
						strErrCode = WriteErrorToEventLog(ExcFw1, pEventID, pCategoryID, pOtherInfo);
					}
				}
			}
			else
			{
			}
			return string.Empty;
		}
		/// <summary>
		/// Write Error T oDataBase
		/// </summary>
		/// <param name="pExc"></param>
		/// <param name="pEventID"></param>
		/// <param name="pCategoryID"></param>
		/// <param name="pOtherInfo"></param>
		/// <returns></returns>
		private static string WriteErrorToDataBase(Exception pExc, string pEventID, short pCategoryID, string pOtherInfo)
		{
			string strLogID = System.Guid.NewGuid().ToString();
			string strLogType = "Error";
			string ErrorMsg = FormatErrorMessage(pEventID, pOtherInfo, pExc);
			string strServerName = Convert.ToString(Environment.MachineName);
			object[] sqlObj = { strLogID, strServerName, _strClientID, _strLoginID, pEventID, pCategoryID, pOtherInfo, ErrorMsg, strLogType };
			SqlParameter[] sqlPara = new SqlParameter[_iSqlParaCntForErr];
			for (int i = 0; i < _iSqlParaCntForErr; i++)
			{
				sqlPara[i] = new SqlParameter(_arrSqlParasForErr[i], _arrSqlDbTypForErr[i], _arrSqlParaSizeForErr[i]);
				sqlPara[i].SqlValue = sqlObj[(int)_arrSqlParameterValueObjsForErr[i]];
			}
			SqlCommand sqlCmd = new SqlCommand();
			sqlCmd.CommandType = CommandType.StoredProcedure;
			sqlCmd.CommandText = _insProcForErr;
			sqlCmd.Parameters.AddRange(sqlPara);


			int iRowIns = ExecuteCommand(sqlCmd);
			return string.Empty;
		}
		/// <summary>
		/// ExecuteCommand 
		/// </summary>
		/// <param name="pCommand"></param>
		/// <returns></returns>
		public static int ExecuteCommand(SqlCommand pCommand)
		{
			string sqlConnectionStr = string.Empty;
			SqlConnection sqlcon = null;
			int iRowIns;
			try
			{
				sqlConnectionStr = EncryptionManager.Decrypt(ConnectionStringForError);
				sqlcon = new SqlConnection(sqlConnectionStr);
				pCommand.Connection = sqlcon;
				sqlcon.Open();
				iRowIns = pCommand.ExecuteNonQuery();
			}
			catch (Exception exc)
			{
				throw exc;
			}
			finally
			{
				pCommand.Dispose();
				if (sqlcon.State != ConnectionState.Closed)
					sqlcon.Close();
			}
			return iRowIns;
		}

		public static string FormatErrorMessage(string pEventID, string pOtherInfo, Exception exceptionToLog)
		{

			string strErrorPagePath = String.Empty;
			string exceptionMessage = "An exception was not generated.";
			string exceptionStackTrace = String.Empty;

			if (exceptionToLog == null)
			{ 
				StackTrace trace = new System.Diagnostics.StackTrace();
				exceptionStackTrace = trace.ToString();
			}
			else{
				strErrorPagePath = exceptionToLog.Source;
				exceptionMessage = exceptionToLog.Message;
				if (String.IsNullOrEmpty(exceptionToLog.GetBaseException().StackTrace))
				{
					exceptionStackTrace = exceptionToLog.StackTrace;
				}
				else
				{
					exceptionStackTrace = exceptionToLog.GetBaseException().StackTrace;
				}
				
			}
			string strApplicationPath = "Scheduler";
			if (_context != null)
			{
				strErrorPagePath = _context.Request.RawUrl;
				strApplicationPath = _context.Request.ApplicationPath;
			}

			return String.Format("Server: {0}\nDate time : {1}\nClientID: {2}\n\nLoginName: {3}\n\nFunction Name: {9}\nError Code: {4}\n\nServer Error in '{5}' Application.\n\n{6}\n\nError from page: {7}\n\nStack Trace: {8}",
				Environment.MachineName, DateTime.Now, _strClientID, _strLoginID, pOtherInfo, strApplicationPath, exceptionMessage, strErrorPagePath, exceptionStackTrace, pEventID);

		}
		
#endregion
	}
	/// <summary>
	///     Exposes static methods for writing log, that can be stored at configurable
	///     location (DataBase/EventLog/FileSystem). This class cannot be inherited.    
	/// </summary>
	public class LogManager
	{
		#region Static Variables
		private static Exception _LastException;
		private static string strClientID = "";
		private static string strLoginID = "";
		private static LogStoreType LogStoreTyp = LogStoreType.DataBase;
		private static string strLogNameForLog = "LCP";
		private static string strSrcNameForLog = "LCP Error";
		private static string strCnnStringForLog = string.Empty;
		private static string insProcForLog = "sproc_AllLog_ups";
		private static int iSqlParaCntForLog = 9;
		private static string[] arrSqlParasForLog = { "@LogID", "@ServerName", "@ClientID", "@SystemUserGUID", "@EventID", "@CategoryID", "@LogInfo", "@LogDescription", "@LogType" };
		private static SqlDbType[] arrSqlDbTypForLog = { SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.Int, SqlDbType.Int, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar };
		private static int[] arrSqlParaSizeForLog = { 100, 50, 100, 100, 10, 10, -1, -1, 50 };
		private static object[] arrSqlParameterValueObjsForLog ={sqlParameterValueObjectsForLog.LogID,
												 sqlParameterValueObjectsForLog.ServerName, 
												 sqlParameterValueObjectsForLog.ClientID,
												 sqlParameterValueObjectsForLog.SystemUserGUID,
												 sqlParameterValueObjectsForLog.EventID,
												 sqlParameterValueObjectsForLog.CategoryID,
												 sqlParameterValueObjectsForLog.LogInfo,
												 sqlParameterValueObjectsForLog.LogDescription,
												 sqlParameterValueObjectsForLog.LogType};
		private static string strFilPthForLog = string.Empty;
		#endregion
		#region enums
		/// <summary>
		/// enum Log Store Type
		/// </summary>
		public enum LogStoreType
		{
			/// <summary>
			/// For Event Log
			/// </summary>
			EventLog,
			/// <summary>
			/// For File System
			/// </summary>
			FileSystem,
			/// <summary>
			/// Database
			/// </summary>
			DataBase
		}
		/// <summary>
		/// 
		/// </summary>
		public enum sqlParameterValueObjectsForLog
		{
			/// <summary>
			/// Log ID
			/// </summary>
			LogID = 0,
			/// <summary>
			/// For Server Name
			/// </summary>
			ServerName = 1,
			/// <summary>
			/// For Client Id
			/// </summary>
			ClientID = 2,
			/// <summary>
			/// For User Id
			/// </summary>
			SystemUserGUID = 3,
			/// <summary>
			/// For event Id
			/// </summary>
			EventID = 4,
			/// <summary>
			/// For Category Id
			/// </summary>
			CategoryID = 5,
			/// <summary>
			/// For Log Info
			/// </summary>
			LogInfo = 6,
			/// <summary>
			/// For Log Description
			/// </summary>
			LogDescription = 7,
			/// <summary>
			/// For Log Type
			/// </summary>
			LogType = 8
		}
		#endregion
		#region Properties
		/// <summary>
		/// Last Exception
		/// </summary>
		public static Exception LastException
		{
			get
			{
				return _LastException;
			}
			set
			{
				if (value != _LastException)
				{
					_LastException = value;
				}
			}
		}
		/// <summary>
		/// ClientID
		/// </summary>
		public static string ClientID
		{
			get
			{
				return strClientID;
			}
			set
			{
				strClientID = value;
			}
		}
		/// <summary>
		/// LoginID
		/// </summary>
		public static string LoginID
		{
			get
			{
				return strLoginID;
			}
			set
			{
				strLoginID = value;
			}
		}
		/// <summary>
		/// Set Log Store Type
		/// </summary>
		public static LogStoreType SetLogStoreType
		{
			get
			{
				return LogStoreTyp;
			}
			set
			{
				LogStoreTyp = value;
			}
		}
		/// <summary>
		/// Log Name For Log
		/// </summary>
		public static string LogNameForLog
		{
			get
			{
				return strLogNameForLog;
			}
			set
			{
				strLogNameForLog = value;
			}
		}
		/// <summary>
		/// Source Name For Log
		/// </summary>
		public static string SourceNameForLog
		{
			get
			{
				return strSrcNameForLog;
			}
			set
			{
				strSrcNameForLog = value;
			}
		}
		/// <summary>
		/// Connection String For Log
		/// </summary>
		public static string ConnectionStringForLog
		{
			get
			{
				return strCnnStringForLog;
			}
			set
			{
				strCnnStringForLog = value;
			}
		}
		/// <summary>
		/// Insert Procedure For Log
		/// </summary>
		public static string InsertProcedureForLog
		{
			get
			{
				return insProcForLog;
			}
			set
			{
				insProcForLog = value;
			}
		}
		/// <summary>
		/// Sql Parameter Count For Log
		/// </summary>
		public static int SqlParameterCountForLog
		{
			get
			{
				return iSqlParaCntForLog;
			}
			set
			{
				iSqlParaCntForLog = value;
			}
		}
		/// <summary>
		/// Sql Parameters For Log
		/// </summary>
		public static string[] SqlParametersForLog
		{
			get
			{
				return arrSqlParasForLog;
			}
			set
			{
				arrSqlParasForLog = value;
			}
		}
		/// <summary>
		/// Sql DbType For Log
		/// </summary>
		public static SqlDbType[] SqlDbTypeForLog
		{
			get
			{
				return arrSqlDbTypForLog;
			}
			set
			{
				arrSqlDbTypForLog = value;
			}
		}
		/// <summary>
		/// SqlParameterSizeForLog
		/// </summary>
		public static int[] SqlParameterSizeForLog
		{
			get
			{
				return arrSqlParaSizeForLog;
			}
			set
			{
				arrSqlParaSizeForLog = value;
			}
		}
		/// <summary>
		/// Set Sql Parameter Value Objects ForLog
		/// </summary>
		public static object[] SetSqlParameterValueObjectsForLog
		{
			get
			{
				return arrSqlParameterValueObjsForLog;
			}
			set
			{
				arrSqlParameterValueObjsForLog = value;
			}
		}
		/// <summary>
		/// File Path For Log
		/// </summary>
		public static string FilePathForLog
		{
			get
			{
				return strFilPthForLog;
			}
			set
			{
				strFilPthForLog = value;
			}
		}
		#endregion
	}
}