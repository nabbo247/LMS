using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;



namespace HRS.CoursePlayer
{
    public interface ICourseConfigurationRepository
    {
        CourseConfiguration GetConfiguration(string clientId);
        int GetMasteryScore(string clientId);
    }
    public class CourseConfigurationAdaptor:IDataManager<CourseConfiguration>, ICourseConfigurationRepository
    {
        #region Global Declaration
        string _strConnString = string.Empty;
        SqlCommand _sqlcmd = null;
        SqlParameter _sqlpara;
        SqlDataReader _sqlreader = null;
        CourseConfiguration _entCourseConfiguration = null;
        string _strMessageId = "ERROR_Course_Config";//Services.Messages.CourseConfiguration.ERROR_MSG_ID;
        SQLObject _sqlObject = null;
        #endregion

        /// <summary>
        /// Get Course Configuration List
        /// </summary>
        /// <param name="pEntCourseConfiguration"></param>
        /// <returns></returns>
        public List<CourseConfiguration> GetCourseConfigurationList(CourseConfiguration pEntCourseConfiguration)
        {
            _sqlObject = new SQLObject();
            List<CourseConfiguration> entListCourseConfiguration = new List<CourseConfiguration>();
            SqlConnection sqlConnection = null;
            try
            {
                _strConnString = _sqlObject.GetClientDBConnString(pEntCourseConfiguration.ClientId);
                sqlConnection = new SqlConnection(_strConnString);
                _sqlcmd = new SqlCommand();
                _sqlcmd.Connection = sqlConnection;
                if (!String.IsNullOrEmpty(pEntCourseConfiguration.ID))
                {
                    _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_COURSE_CONFIGURATION_ID, pEntCourseConfiguration.ID);
                    _sqlcmd.Parameters.Add(_sqlpara);
                    _sqlcmd.CommandText = Schema.CourseConfiguration.PROC_GET_COURSE_CONFIGURATION_BY_ID;
                }
                else
                {
                    _sqlcmd.CommandText = Schema.CourseConfiguration.PROC_GET_ALL_COURSE_CONFIGURATION;
                }
                _sqlreader = null;
                _sqlreader = _sqlObject.SqlDataReader(_sqlcmd, false);
                while (_sqlreader.Read())
                {
                    _entCourseConfiguration = FillObject(_sqlreader, _sqlObject);
                    entListCourseConfiguration.Add(_entCourseConfiguration);
                }
            }
            catch (Exception expCommon)
            {
                //expCommon = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;
            }
            finally
            {
                if (_sqlreader != null && !_sqlreader.IsClosed) _sqlreader.Close();
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                    sqlConnection.Close();
            }
            return entListCourseConfiguration;
        }

        /// <summary>
        /// Get AVPath
        /// </summary>
        /// <param name="pEntCourseConfiguration"></param>
        /// <returns></returns>
        public CourseConfiguration GetAVPath(CourseConfiguration pEntCourseConfiguration)
        {
            _sqlObject = new SQLObject();
            CourseConfiguration entCourseConfiguration = new CourseConfiguration();
            SqlConnection sqlConnection = null;
            try
            {
                _strConnString = _sqlObject.GetClientDBConnString(pEntCourseConfiguration.ClientId);
                sqlConnection = new SqlConnection(_strConnString);
                _sqlcmd = new SqlCommand();
                _sqlcmd.Connection = sqlConnection;                
                _sqlcmd.CommandText = Schema.CourseConfiguration.PROC_GET_AV_PATH_COURSE_CONFIGURATION;                
                Object obj = null;
                obj = _sqlObject.ExecuteScalar(_sqlcmd, false);
                if (obj != null)
                {
                    entCourseConfiguration.AVPath = Convert.ToString(obj);
                }
            }
            catch (Exception expCommon)
            {
                //expCommon = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                    sqlConnection.Close();
            }
            return entCourseConfiguration;
        }

        /// <summary>
        /// Get MasteryScore
        /// </summary>
        /// <param name="pEntCourseConfiguration"></param>
        /// <returns></returns>
        public CourseConfiguration GetMasteryScore(CourseConfiguration pEntCourseConfiguration)
        {
            _sqlObject = new SQLObject();
            CourseConfiguration entCourseConfiguration = new CourseConfiguration();
            SqlConnection sqlConnection = null;
            try
            {
                _strConnString = _sqlObject.GetClientDBConnString(pEntCourseConfiguration.ClientId);
                sqlConnection = new SqlConnection(_strConnString);
                _sqlcmd = new SqlCommand();
                _sqlcmd.Connection = sqlConnection;
                _sqlcmd.CommandText = Schema.CourseConfiguration.PROC_GET_MASTERY_SCORE_COURSE_CONFIGURATION;
                Object obj = null;
                obj = _sqlObject.ExecuteScalar(_sqlcmd, false);
                if (obj != null)
                {
                    entCourseConfiguration.MasteryScore = Convert.ToInt32(obj);
                }
            }
            catch (Exception expCommon)
            {
                //expCommon = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                    sqlConnection.Close();
            }
            return entCourseConfiguration;
        }


        /// <summary>
        /// Fill Object
        /// </summary>
        /// <param name="pSqlreader"></param>
        /// <param name="pSqlObject"></param>
        /// <returns></returns>
        private CourseConfiguration FillObject(SqlDataReader pSqlreader, SQLObject pSqlObject)
        {
            _entCourseConfiguration = new CourseConfiguration();
            int iIndex;
            if (pSqlreader.HasRows)
            {
                iIndex = pSqlreader.GetOrdinal(Schema.CourseConfiguration.COL_ALLOW_RESIZE);
                if (!pSqlreader.IsDBNull(iIndex))
                    _entCourseConfiguration.AllowResize = pSqlreader.GetBoolean(iIndex);

                iIndex = pSqlreader.GetOrdinal(Schema.CourseConfiguration.COL_ALLOW_SCROLL);
                if (!pSqlreader.IsDBNull(iIndex))
                    _entCourseConfiguration.AllowScroll = pSqlreader.GetBoolean(iIndex);

                iIndex = pSqlreader.GetOrdinal(Schema.CourseConfiguration.COL_AV_PATH);
                if (!pSqlreader.IsDBNull(iIndex))
                    _entCourseConfiguration.AVPath = pSqlreader.GetString(iIndex);

                iIndex = pSqlreader.GetOrdinal(Schema.CourseConfiguration.COL_CLIENT_ID);
                if (!pSqlreader.IsDBNull(iIndex))
                    _entCourseConfiguration.ClientId = pSqlreader.GetString(iIndex);

                iIndex = pSqlreader.GetOrdinal(Schema.CourseConfiguration.COL_COURSE_CONFIGURATION_ID);
                if (!pSqlreader.IsDBNull(iIndex))
                    _entCourseConfiguration.ID = pSqlreader.GetString(iIndex);

                iIndex = pSqlreader.GetOrdinal(Schema.CourseConfiguration.COL_COURSE_LAUNCH_NEW_WINDOW);
                if (!pSqlreader.IsDBNull(iIndex))
                    _entCourseConfiguration.CourseLaunchNewWindow = pSqlreader.GetBoolean(iIndex);

                iIndex = pSqlreader.GetOrdinal(Schema.CourseConfiguration.COL_COURSE_LAUNCH_SAME_WINDOW);
                if (!pSqlreader.IsDBNull(iIndex))
                    _entCourseConfiguration.CourseLaunchSameWindow = pSqlreader.GetBoolean(iIndex);

                iIndex = pSqlreader.GetOrdinal(Schema.CourseConfiguration.COL_COURSE_WINDOW_HEIGHT);
                if (!pSqlreader.IsDBNull(iIndex))
                    _entCourseConfiguration.CourseWindowHeight = pSqlreader.GetInt32(iIndex);

                iIndex = pSqlreader.GetOrdinal(Schema.CourseConfiguration.COL_COURSE_WINDOW_WIDTH);
                if (!pSqlreader.IsDBNull(iIndex))
                    _entCourseConfiguration.CourseWindowWidth = pSqlreader.GetInt32(iIndex);

                iIndex = pSqlreader.GetOrdinal(Schema.CourseConfiguration.COL_IS_COURSE_SESSION_NO_EXPIRY);
                if (!pSqlreader.IsDBNull(iIndex))
                    _entCourseConfiguration.IsCourseSessionNoExpiry = pSqlreader.GetBoolean(iIndex);

                iIndex = pSqlreader.GetOrdinal(Schema.CourseConfiguration.COL_MASTERY_SCORE);
                if (!pSqlreader.IsDBNull(iIndex))
                    _entCourseConfiguration.MasteryScore = pSqlreader.GetInt32(iIndex);

                iIndex = pSqlreader.GetOrdinal(Schema.CourseConfiguration.COL_MAX_FILE_UPLOAD_SIZE_MB);
                if (!pSqlreader.IsDBNull(iIndex))
                    _entCourseConfiguration.MaxFileUploadSizeMB = pSqlreader.GetInt32(iIndex);

                iIndex = pSqlreader.GetOrdinal(Schema.CourseConfiguration.COL_QUESTION_RESPONSE_TRACKING);
                if (!pSqlreader.IsDBNull(iIndex))
                    _entCourseConfiguration.QuestionResponseTracking = pSqlreader.GetBoolean(iIndex);

                iIndex = pSqlreader.GetOrdinal(Schema.CourseConfiguration.COL_SCORE_TRACKING);
                if (!pSqlreader.IsDBNull(iIndex))
                    _entCourseConfiguration.ScoreTracking = pSqlreader.GetBoolean(iIndex);

                iIndex = pSqlreader.GetOrdinal(Schema.Common.COL_CREATED_BY);
                if (!pSqlreader.IsDBNull(iIndex))
                    _entCourseConfiguration.CreatedById = pSqlreader.GetString(iIndex);

                iIndex = pSqlreader.GetOrdinal(Schema.Common.COL_CREATED_ON);
                if (!pSqlreader.IsDBNull(iIndex))
                    _entCourseConfiguration.DateCreated = pSqlreader.GetDateTime(iIndex);

                iIndex = pSqlreader.GetOrdinal(Schema.Common.COL_MODIFIED_BY);
                if (!pSqlreader.IsDBNull(iIndex))
                    _entCourseConfiguration.LastModifiedById = pSqlreader.GetString(iIndex);

                iIndex = pSqlreader.GetOrdinal(Schema.Common.COL_MODIFIED_ON);
                if (!pSqlreader.IsDBNull(iIndex))
                    _entCourseConfiguration.LastModifiedDate = pSqlreader.GetDateTime(iIndex);

                if (pSqlObject.ReaderHasColumn(pSqlreader, Schema.AVPathSetting.COL_IS_SAME_FOR_ALL))
                {
                    iIndex = pSqlreader.GetOrdinal(Schema.AVPathSetting.COL_IS_SAME_FOR_ALL);
                    if (!pSqlreader.IsDBNull(iIndex))
                        _entCourseConfiguration.IsSameAVPathForAll = pSqlreader.GetBoolean(iIndex);
                }

				//-aw 6/15/2011 Added course protocol
				iIndex = pSqlreader.GetOrdinal(Schema.CourseConfiguration.COL_PROTOCOL);
				if (!pSqlreader.IsDBNull(iIndex))
					_entCourseConfiguration.Protocol = pSqlreader.GetString(iIndex);
			
			}
            return _entCourseConfiguration;
        }

        /// <summary>
        /// Edit Course Configuration 
        /// </summary>
        /// <param name="pEntCourseConfiguration"></param>
        /// <returns></returns>
        public CourseConfiguration EditCourseConfiguration(CourseConfiguration pEntCourseConfiguration)
        {
            _entCourseConfiguration = new CourseConfiguration();
            _entCourseConfiguration = Update(pEntCourseConfiguration, Schema.Common.VAL_UPDATE_MODE);
            return _entCourseConfiguration;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="pEntCourseConfiguration"></param>
        /// <param name="pUpdateMode"></param>
        /// <returns></returns>
        private CourseConfiguration Update(CourseConfiguration pEntCourseConfiguration, string pUpdateMode)
        {
            int iRows = 0;
            _sqlObject = new SQLObject();
            _sqlcmd = new SqlCommand();
            _sqlcmd.CommandText = Schema.CourseConfiguration.PROC_UPDATE_COURSE_CONFIGURATION;
            try
            {
                _strConnString = _sqlObject.GetClientDBConnString(pEntCourseConfiguration.ClientId);

                if (pUpdateMode == Schema.Common.VAL_INSERT_MODE)
                {
                    _sqlpara = new SqlParameter(Schema.Common.PARA_UPDATE_MODE, Schema.Common.VAL_INSERT_MODE);
                    pEntCourseConfiguration.ID = IDGenerator.GetStringGUID();
                }
                else
                    _sqlpara = new SqlParameter(Schema.Common.PARA_UPDATE_MODE, Schema.Common.VAL_UPDATE_MODE);

                _sqlcmd.Parameters.Add(_sqlpara);

                // Allowresize Parameter
                _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_ALLOW_RESIZE, pEntCourseConfiguration.AllowResize);
                _sqlcmd.Parameters.Add(_sqlpara);

                // AllowResize paramater
                _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_ALLOW_SCROLL, pEntCourseConfiguration.AllowScroll);
                _sqlcmd.Parameters.Add(_sqlpara);

                // Avpath paramater
                if (!string.IsNullOrEmpty(pEntCourseConfiguration.AVPath))
                    _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_AV_PATH, pEntCourseConfiguration.AVPath);
                else
                    _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_AV_PATH, System.DBNull.Value);
                _sqlcmd.Parameters.Add(_sqlpara);

                // ClientID paramater
                if (!string.IsNullOrEmpty(pEntCourseConfiguration.ClientId))
                    _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_CLIENT_ID, pEntCourseConfiguration.ClientId);
                else
                    _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_CLIENT_ID, System.DBNull.Value);
                _sqlcmd.Parameters.Add(_sqlpara);

                // Course launch New Window paramater
                _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_COURSE_LAUNCH_NEW_WINDOW, pEntCourseConfiguration.CourseLaunchNewWindow);
                _sqlcmd.Parameters.Add(_sqlpara);

                // Course Launch Same Window paramater
                _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_COURSE_LAUNCH_SAME_WINDOW, pEntCourseConfiguration.CourseLaunchSameWindow);
                _sqlcmd.Parameters.Add(_sqlpara);

                // Course Window Height paramater
                if (pEntCourseConfiguration.CourseWindowHeight != 0)
                    _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_COURSE_WINDOW_HEIGHT, pEntCourseConfiguration.CourseWindowHeight);
                else
                    _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_COURSE_WINDOW_HEIGHT, System.DBNull.Value);
                _sqlcmd.Parameters.Add(_sqlpara);

                // Course Window Width paramater
                if (pEntCourseConfiguration.CourseWindowWidth != 0)
                    _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_COURSE_WINDOW_WIDTH, pEntCourseConfiguration.CourseWindowWidth);
                else
                    _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_COURSE_WINDOW_WIDTH, System.DBNull.Value);
                _sqlcmd.Parameters.Add(_sqlpara);

                // Is Course Session No Expiry paramater
                _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_IS_COURSE_SESSION_NO_EXPIRY, pEntCourseConfiguration.IsCourseSessionNoExpiry);
                _sqlcmd.Parameters.Add(_sqlpara);

                // Mastery Score paramater
                if (pEntCourseConfiguration.MasteryScore != 0)
                    _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_MASTERY_SCORE, pEntCourseConfiguration.MasteryScore);
                else
                    _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_MASTERY_SCORE, System.DBNull.Value);
                _sqlcmd.Parameters.Add(_sqlpara);

                // Max File upload Size paramater
                if (pEntCourseConfiguration.MaxFileUploadSizeMB != 0)
                    _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_MAX_FILE_UPLOAD_SIZE_MB, pEntCourseConfiguration.MaxFileUploadSizeMB);
                else
                    _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_MAX_FILE_UPLOAD_SIZE_MB, System.DBNull.Value);
                _sqlcmd.Parameters.Add(_sqlpara);

                // Course Question Response Tracking paramater
                _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_QUESTION_RESPONSE_TRACKING, pEntCourseConfiguration.QuestionResponseTracking);
                _sqlcmd.Parameters.Add(_sqlpara);

                // Course Launch Same Window paramater
                _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_SCORE_TRACKING, pEntCourseConfiguration.ScoreTracking);
                _sqlcmd.Parameters.Add(_sqlpara);

                // Last Modified by ID paramater
                if (!string.IsNullOrEmpty(pEntCourseConfiguration.LastModifiedById))
                    _sqlpara = new SqlParameter(Schema.Common.PARA_MODIFIED_BY, pEntCourseConfiguration.LastModifiedById);
                else
                    _sqlpara = new SqlParameter(Schema.Common.PARA_MODIFIED_BY, System.DBNull.Value);
                _sqlcmd.Parameters.Add(_sqlpara);

                // Course Configuration ID paramater
                if (!string.IsNullOrEmpty(pEntCourseConfiguration.ID))
                    _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_COURSE_CONFIGURATION_ID, pEntCourseConfiguration.ID);
                else
                    _sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_COURSE_CONFIGURATION_ID, System.DBNull.Value);
                _sqlcmd.Parameters.Add(_sqlpara);

				//-aw 6/15/2011 Added course protocol
				_sqlpara = new SqlParameter(Schema.CourseConfiguration.PARA_PROTOCOL, pEntCourseConfiguration.Protocol);
				_sqlcmd.Parameters.Add(_sqlpara);

                iRows = _sqlObject.ExecuteNonQuery(_sqlcmd, _strConnString);
            }
            catch (Exception expCommon)
            {
                //expCommon = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;
            }
            return pEntCourseConfiguration;
        }

        /// <summary>
        /// Get Course Configuration Entity
        /// </summary>
        /// <param name="pEntCourseConfiguration"></param>
        /// <returns></returns>
        public CourseConfiguration GetCourseConfigurationByID(CourseConfiguration pEntCourseConfiguration)
        {
            List<CourseConfiguration> entListCourseConfiguration = new List<CourseConfiguration>();
            try
            {
                entListCourseConfiguration = GetCourseConfigurationList(pEntCourseConfiguration);
                if (entListCourseConfiguration != null && entListCourseConfiguration.Count > 0)
                    _entCourseConfiguration = entListCourseConfiguration[0];
            }
            catch (Exception expCommon)
            {
                //expCommon = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;
            }
            return _entCourseConfiguration;
        }

        #region Interface Methods
        /// <summary>
        /// Get By ID
        /// </summary>
        /// <param name="pEntCourseConfiguration"></param>
        /// <returns></returns>
        public CourseConfiguration Get(CourseConfiguration pEntCourseConfiguration)
        {
            return GetCourseConfigurationByID(pEntCourseConfiguration);
        }
        /// <summary>
        /// Update CourseConfiguration
        /// </summary>
        /// <param name="pEntCourseConfiguration"></param>
        /// <returns></returns>
        public CourseConfiguration Update(CourseConfiguration pEntCourseConfiguration)
        {
            return EditCourseConfiguration(pEntCourseConfiguration);
        }
        #endregion

        public CourseConfiguration GetConfiguration(string clientId)
        {
            return GetCourseConfigurationByID(new CourseConfiguration {ClientId = clientId});
        }

        public int GetMasteryScore(string clientId)
        {
            return GetMasteryScore(new CourseConfiguration { ClientId = clientId }).MasteryScore;
        }
    }
}