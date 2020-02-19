
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;



namespace HRS.CoursePlayer
{
    public interface IContentModuleRepository
    {
        ContentModule GetById(string clientId, string courseId);
        ContentModule GetByIdForCoursePlayer(string courseId);
    }
    /// <summary>
    /// class ContentModuleAdaptor
    /// </summary>
    public class ContentModuleAdaptor : IDataManager<ContentModule>, IContentModuleRepository
    {
        #region Declaration
        //CustomException _expCustom = null;
        SqlDataReader _sqlreader = null;
        SqlCommand _sqlcmd = null;
        SqlParameter _sqlpara = null;
        SqlDataAdapter _sqladapter = null;
        SqlConnection _sqlcon = null;       
        EntityRange _entRange = null;        
        ContentModule _entContentModule = null;
        DataTable _dtable = null;
        SQLObject _sqlObject = null;
        string _strMessageId = "CONT_MOD_BL_ERROR";//Services.Messages.Content.CONT_MOD_BL_ERROR;
        string _strConnString = string.Empty;
        #endregion

        /// <summary>
        /// To Get Content Module details by condent module id.
        /// </summary>
        /// <param name="pEntContModule"></param>
        /// <returns>ContentModule Object</returns>
        public ContentModule GetContentModuleByID(ContentModule pEntContModule)
        {
            _sqlObject = new SQLObject();
            ContentModule entContModule = new ContentModule();
            //ContentModuleLanguages entCML = new ContentModuleLanguages();
            string sConnString = string.Empty;
            SqlConnection sqlConnection = null;
            try
            {
                sConnString = _sqlObject.GetMasterDBConnString();
                sqlConnection = new SqlConnection(sConnString);
                _sqlcmd = new SqlCommand(Schema.ContentModule.PROC_GET_CONTENT_MODULE, sqlConnection);
                _sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_ID, pEntContModule.ID);
                _sqlcmd.Parameters.Add(_sqlpara);
                //if (!string.IsNullOrEmpty(pEntContModule.LanguageId))
                //{
                //    _sqlpara = new SqlParameter(Schema.Language.PARA_LANGUAGE_ID, pEntContModule.LanguageId);
                //    _sqlcmd.Parameters.Add(_sqlpara);
                //}
                //else
                //{
                    _sqlpara = new SqlParameter(Schema.Language.PARA_LANGUAGE_ID, "en-US");
                    _sqlcmd.Parameters.Add(_sqlpara);
                //}
                _sqlreader = _sqlObject.SqlDataReader(_sqlcmd, false);
                _sqlreader.Read();
                _entContentModule = FillObject(_sqlreader, false);
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;// _expCustom;
            }
            finally
            {
                if (_sqlreader != null && !_sqlreader.IsClosed)
                    _sqlreader.Close();
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) sqlConnection.Close();
            }
            return _entContentModule;
        }

        /// <summary>
        /// To Get Content Module details by condent module id.
        /// </summary>
        /// <param name="pEntContModule"></param>
        /// <returns>ContentModule Object</returns>
        public ContentModule GetContentModuleByID_CoursePlayer(ContentModule pEntContModule)
        {
            _entContentModule = new ContentModule();
            _sqlObject = new SQLObject();                        
            string sConnString = string.Empty;
            SqlConnection sqlConnection = null;
            try
            {
                sConnString = _sqlObject.GetMasterDBConnString();
                sqlConnection = new SqlConnection(sConnString);
                _sqlcmd = new SqlCommand(Schema.ContentModule.PROC_GET_CONTENT_MODULE_COURSE_PLAYER, sqlConnection);
                _sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_ID, pEntContModule.ID);
                _sqlcmd.Parameters.Add(_sqlpara);
                //if (!string.IsNullOrEmpty(pEntContModule.LanguageId))
                //{
                //    _sqlpara = new SqlParameter(Schema.Language.PARA_LANGUAGE_ID, pEntContModule.LanguageId);
                //    _sqlcmd.Parameters.Add(_sqlpara);
                //}
                //else
                //{
                    //_sqlpara = new SqlParameter(Schema.Language.PARA_LANGUAGE_ID, "en-US");
                    //_sqlcmd.Parameters.Add(_sqlpara);
                //}
                _sqlreader = _sqlObject.SqlDataReader(_sqlcmd, false);
                _sqlreader.Read();
                _entContentModule = FillObject_CoursePlayer(_sqlreader, false);
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;
            }
            finally
            {
                if (_sqlreader != null && !_sqlreader.IsClosed)
                    _sqlreader.Close();
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) sqlConnection.Close();
            }
            return _entContentModule;
        }

        /// <summary>
        /// To Get Content Module details by condent module id.
        /// </summary>
        /// <param name="pEntContModule"></param>
        /// <returns>ContentModule Object</returns>
        public ContentModule GetContentModuleURL(ContentModule pEntContModule)
        {
            _sqlObject = new SQLObject();
            ContentModule entContModule = new ContentModule();            
            string sConnString = string.Empty;
            SqlConnection sqlConnection = null;
            try
            {
                sConnString = _sqlObject.GetClientDBConnString(pEntContModule.ClientId);
                sqlConnection = new SqlConnection(sConnString);
                _sqlcmd = new SqlCommand(Schema.ContentModule.PROC_GET_CONTENT_MODULE_URL, sqlConnection);
                _sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_ID, pEntContModule.ID);
                _sqlcmd.Parameters.Add(_sqlpara);
                //if (!string.IsNullOrEmpty(pEntContModule.LanguageId))
                //{
                //    _sqlpara = new SqlParameter(Schema.Language.PARA_LANGUAGE_ID, pEntContModule.LanguageId);
                //    _sqlcmd.Parameters.Add(_sqlpara);
                //}
                //else
                //{
                    _sqlpara = new SqlParameter(Schema.Language.PARA_LANGUAGE_ID, "en-US");
                    _sqlcmd.Parameters.Add(_sqlpara);
                //}
                Object obj = null;
                obj = _sqlObject.ExecuteScalar(_sqlcmd, false);
                if (obj != null)
                {
                    entContModule.ContentModuleURL = Convert.ToString(obj);
                }
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) sqlConnection.Close();
            }
            return entContModule;
        }

        /// <summary>
        /// To Get Content Module details by condent module id.
        /// </summary>
        /// <param name="pEntContModule"></param>
        /// <returns>ContentModule Object</returns>
        public ContentModule GetContentModuleByID_Learner(ContentModule pEntContModule)
        {
            _sqlObject = new SQLObject();
            ContentModule entContModule = new ContentModule();
           // ContentModuleLanguages entCML = new ContentModuleLanguages();
            string sConnString = string.Empty;
            SqlConnection sqlConnection = null;
            try
            {
                sConnString = _sqlObject.GetClientDBConnString(pEntContModule.ClientId);
                sqlConnection = new SqlConnection(sConnString);
                _sqlcmd = new SqlCommand(Schema.ContentModule.PROC_GET_CONTENT_MODULE_LEARNER, sqlConnection);
                _sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_ID, pEntContModule.ID);
                _sqlcmd.Parameters.Add(_sqlpara);
                //if (!string.IsNullOrEmpty(pEntContModule.LanguageId))
                //{
                //    _sqlpara = new SqlParameter(Schema.Language.PARA_LANGUAGE_ID, pEntContModule.LanguageId);
                //    _sqlcmd.Parameters.Add(_sqlpara);
                //}
                //else
                //{
                    _sqlpara = new SqlParameter(Schema.Language.PARA_LANGUAGE_ID, "en-US");
                    _sqlcmd.Parameters.Add(_sqlpara);
                //}
                _sqlreader = _sqlObject.SqlDataReader(_sqlcmd, false);
                _sqlreader.Read();
                //_entContentModule = FillObject(_sqlreader, false);
                _entContentModule = FillObject_Learner(_sqlreader, false);
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;
            }
            finally
            {
                if (_sqlreader != null && !_sqlreader.IsClosed)
                    _sqlreader.Close();
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) sqlConnection.Close();
            }
            return _entContentModule;
        }        

        /// <summary>
        /// Find Content Module By Name or Type or Both
        /// </summary>
        /// <param name="pEntContModule"></param>
        /// <returns>ContentModule Object</returns>
        public ContentModule FindContentModuleByName(ContentModule pEntContModule)
        {
            _sqlObject = new SQLObject();
            //ContentModuleLanguages entCML = new ContentModuleLanguages();
            ContentModule entContModule = new ContentModule();
            SqlConnection sqlConnection = null;
            try
            {
                _strConnString = _sqlObject.GetClientDBConnString(pEntContModule.ClientId);
                sqlConnection = new SqlConnection(_strConnString);
                _sqlcmd = new SqlCommand(Schema.ContentModule.PROC_FIND_CONTENT_MODULE_NAME, sqlConnection);
                _sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_ENGLISH_NAME, pEntContModule.ContentModuleEnglishName);
                _sqlcmd.Parameters.Add(_sqlpara);
                _sqlreader = _sqlObject.SqlDataReader(_sqlcmd, false);
                _sqlreader.Read();
                _entContentModule = FillObject(_sqlreader, false);
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;
            }
            finally
            {
                if (_sqlreader != null && !_sqlreader.IsClosed)
                    _sqlreader.Close();
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) sqlConnection.Close();
            }
            return _entContentModule;
        }

        /// <summary>
        ///  To Fill Content module object properties valus from reader data 
        /// </summary>
        /// <param name="pReader"></param>
        /// <returns>ContentModule Object</returns>
        private ContentModule FillObject(SqlDataReader pSqlReader, bool pRangeList)
        {
            ContentModule entContentModule = new ContentModule();
            int iIndex;
            if (pSqlReader.HasRows)
            {
                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_ID);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.ID = pSqlReader.GetString(iIndex);

                if (_sqlObject != null && _sqlObject.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_CONTENT_MODULE_NAME))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_NAME);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.ContentModuleEnglishName = pSqlReader.GetString(iIndex);
                }
                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_ENGLISH_NAME);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.ContentModuleEnglishName = pSqlReader.GetString(iIndex);
                else
                    entContentModule.ContentModuleEnglishName = "";

                //if (_sqlObject != null && _sqlObject.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_CONTENT_MODULE_DESC))
                //{
                //    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_DESC);
                //    if (!pSqlReader.IsDBNull(iIndex))
                //        entContentModule.ContentModuleDescription = pSqlReader.GetString(iIndex);
                //}

                //if (_sqlObject != null && _sqlObject.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_KEY_WORDS))
                //{
                //    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_KEY_WORDS);
                //    if (!pSqlReader.IsDBNull(iIndex))
                //        entContentModule.ContentModuleKeyWords = pSqlReader.GetString(iIndex);
                //}
                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_TYPE);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.ContentModuleTypeId = pSqlReader.GetString(iIndex);
                else
                    entContentModule.ContentModuleTypeId = "";

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_URL);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.ContentModuleURL = pSqlReader.GetString(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_ACTIVE);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.IsActive = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_UPLOADED);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.IsUploaded = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_AVPATH);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.AVPath = pSqlReader.GetString(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_ALLOW_RESIZE);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.AllowResize = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_ALLOW_SCROLL);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.AllowScroll = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_COURSE_LAUNCH_NEW_WIND0W);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.CourseLaunchNewWindow = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_COURSE_LAUNCH_SAME_WIND0W);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.CourseLaunchSameWindow = pSqlReader.GetBoolean(iIndex);

                //iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_COURSE_LAUNCH_SAME_WIND0W);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.CourseLaunchSameWindow = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_COURSE_WINDOW_HEIGHT);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.CourseWindowHeight = pSqlReader.GetInt32(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_COURSE_WINDOW_WIDTH);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.CourseWindowWidth = pSqlReader.GetInt32(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_MASTERY_SCORE);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.MasteryScore = pSqlReader.GetInt32(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_SCORE_TRACKING);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.ScoreTracking = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_QUESTION_RESPONSE_TRACKING);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.QuestionResponseTracking = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_SUB_TYPE_ID);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.ContentModuleSubTypeId = pSqlReader.GetString(iIndex);
                else
                    entContentModule.ContentModuleSubTypeId = "";

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_PRINT_CERTIFICATE);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.IsPrintCertificate = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_COURSE_SESSION_NO_EXPIRY);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.IsCourseSessionNoExpiry = pSqlReader.GetBoolean(iIndex);

                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_COURSE_GROUP_ID))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_COURSE_GROUP_ID);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.CourseGroupId = pSqlReader.GetString(iIndex);
                }
                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_IMANIFEST_URL))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IMANIFEST_URL);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.ImanifestUrl = pSqlReader.GetString(iIndex);
                }

                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_IS_SHORT_LANGUAGE_CODE))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_SHORT_LANGUAGE_CODE);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.IsShortLanguageCode = pSqlReader.GetBoolean(iIndex);
                }

                //if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.Language.COL_LANGUAGE_ID))
                //{
                //    iIndex = pSqlReader.GetOrdinal(Schema.Language.COL_LANGUAGE_ID);
                //    if (!pSqlReader.IsDBNull(iIndex))
                //        entContentModule.LanguageId = pSqlReader.GetString(iIndex);
                //}
                iIndex = pSqlReader.GetOrdinal(Schema.Common.COL_CREATED_BY);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.CreatedById = pSqlReader.GetString(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.Common.COL_CREATED_ON);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.DateCreated = pSqlReader.GetDateTime(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.Common.COL_MODIFIED_BY);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.LastModifiedById = pSqlReader.GetString(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.Common.COL_MODIFIED_ON);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.LastModifiedDate = pSqlReader.GetDateTime(iIndex);              

                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_IS_ALLOCATED))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_ALLOCATED);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.IsAllocated = pSqlReader.GetBoolean(iIndex);
                }
                else
                    entContentModule.IsAllocated = false;

                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_IS_COURSE_MODIFIED_BY_ADMIN))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_COURSE_MODIFIED_BY_ADMIN);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.IsCourseModifiedByAdmin = pSqlReader.GetBoolean(iIndex);
                    else
                        entContentModule.IsCourseModifiedByAdmin = false;
                }

				//-aw 6/15/2011 Added course protocol
				iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_PROTOCOL);
				if (!pSqlReader.IsDBNull(iIndex))
					entContentModule.Protocol = pSqlReader.GetString(iIndex);

                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_ISASSESSMENT))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_ISASSESSMENT);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.IsAssessment = pSqlReader.GetBoolean(iIndex);
                }
                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_ISMIDDLEPAGE))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_ISMIDDLEPAGE);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.IsMiddlePage = pSqlReader.GetBoolean(iIndex);
                }

                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_IS_HTML_5))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_HTML_5);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.IsHTML5 = pSqlReader.GetBoolean(iIndex);
                }
                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_KEEP_ZIP_FILE))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_KEEP_ZIP_FILE);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.KeepZipFile = pSqlReader.GetBoolean(iIndex);
                }
                if (pRangeList)
                {
                    _entRange = new EntityRange();
                    if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.Common.COL_TOTAL_COUNT))
                    {
                        iIndex = pSqlReader.GetOrdinal(Schema.Common.COL_TOTAL_COUNT);
                        if (!pSqlReader.IsDBNull(iIndex))
                            _entRange.TotalRows = pSqlReader.GetInt32(iIndex);
                    }
                    entContentModule.ListRange = _entRange;
                }
            }
            return entContentModule;
        }

        /// <summary>
        ///  To Fill Content module object properties valus from reader data 
        /// </summary>
        /// <param name="pReader"></param>
        /// <returns>ContentModule Object</returns>
        private ContentModule FillObject_CoursePlayer(SqlDataReader pSqlReader, bool pRangeList)
        {
            ContentModule entContentModule = new ContentModule();
            int iIndex;
            if (pSqlReader.HasRows)
            {
                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_ID);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.ID = pSqlReader.GetString(iIndex);                

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_URL);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.ContentModuleURL = pSqlReader.GetString(iIndex);
                
                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_SCORE_TRACKING);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.ScoreTracking = pSqlReader.GetBoolean(iIndex);                

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_COURSE_SESSION_NO_EXPIRY);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.IsCourseSessionNoExpiry = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_TYPE);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.ContentModuleTypeId = pSqlReader.GetString(iIndex);
                else
                    entContentModule.ContentModuleTypeId = "";

                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_IMANIFEST_URL))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IMANIFEST_URL);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.ImanifestUrl = pSqlReader.GetString(iIndex);
                }

                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_IS_SHORT_LANGUAGE_CODE))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_SHORT_LANGUAGE_CODE);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.IsShortLanguageCode = pSqlReader.GetBoolean(iIndex);
                }

                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_ISASSESSMENT))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_ISASSESSMENT);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.IsAssessment = pSqlReader.GetBoolean(iIndex);
                }
                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_ISMIDDLEPAGE))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_ISMIDDLEPAGE);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.IsMiddlePage = pSqlReader.GetBoolean(iIndex);
                }
                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_CONTENT_MODULE_ENGLISH_NAME))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_ENGLISH_NAME);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.ContentModuleEnglishName = pSqlReader.GetString(iIndex);
                }
            }
            return entContentModule;
        }

        /// <summary>
        ///  To Fill Content module object properties valus from reader data 
        /// </summary>
        /// <param name="pReader"></param>
        /// <returns>ContentModule Object</returns>
        private ContentModule FillObjectAdminHome(SqlDataReader pSqlReader, bool pRangeList)
        {
            ContentModule entContentModule = new ContentModule();
            int iIndex;
            if (pSqlReader.HasRows)
            {
                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_CONTENT_MODULE_ID))
                {

                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_ID);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.ID = pSqlReader.GetString(iIndex);
                }

                //if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_CONTENT_MODULE_NAME))
                //{

                //    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_NAME);
                //    if (!pSqlReader.IsDBNull(iIndex))
                //        entContentModule.ContentModuleName = pSqlReader.GetString(iIndex);
                //}

                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_CONTENT_MODULE_ENGLISH_NAME))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_ENGLISH_NAME);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.ContentModuleEnglishName = pSqlReader.GetString(iIndex);
                    else
                        entContentModule.ContentModuleEnglishName = "";
                }

                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_IS_ALLOCATED))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_ALLOCATED);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.IsAllocated = pSqlReader.GetBoolean(iIndex);
                }
                else
                    entContentModule.IsAllocated = false;

                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.Common.COL_MODIFIED_ON))
                {

                    iIndex = pSqlReader.GetOrdinal(Schema.Common.COL_MODIFIED_ON);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.LastModifiedDate = pSqlReader.GetDateTime(iIndex);
                }
               
                if (pRangeList)
                {
                    if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.Common.COL_TOTAL_COUNT))
                    {
                        _entRange = new EntityRange();
                        iIndex = pSqlReader.GetOrdinal(Schema.Common.COL_TOTAL_COUNT);
                        if (!pSqlReader.IsDBNull(iIndex))
                            _entRange.TotalRows = pSqlReader.GetInt32(iIndex);
                        entContentModule.ListRange = _entRange;
                    }
                }
            }
            return entContentModule;
        }

        /// <summary>
        ///  To Fill Content module object properties valus from reader data 
        /// </summary>
        /// <param name="pReader"></param>
        /// <returns>ContentModule Object</returns>
        private ContentModule FillObject_Learner(SqlDataReader pSqlReader, bool pRangeList)
        {
            ContentModule entContentModule = new ContentModule();
            int iIndex;
            if (pSqlReader.HasRows)
            {
                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_ID);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.ID = pSqlReader.GetString(iIndex);

                //iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_NAME);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.ContentModuleName = pSqlReader.GetString(iIndex);

                //iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_ENGLISH_NAME);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.ContentModuleEnglishName = pSqlReader.GetString(iIndex);
                //else
                //    entContentModule.ContentModuleEnglishName = "";

                //iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_DESC);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.ContentModuleDescription = pSqlReader.GetString(iIndex);

                //iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_KEY_WORDS);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.ContentModuleKeyWords = pSqlReader.GetString(iIndex);

                //iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_TYPE);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.ContentModuleTypeId = pSqlReader.GetString(iIndex);
                //else
                //    entContentModule.ContentModuleTypeId = "";               

                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_CONTENT_MODULE_URL))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_URL);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.ContentModuleURL = pSqlReader.GetString(iIndex);
                }

                //iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_ACTIVE);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.IsActive = pSqlReader.GetBoolean(iIndex);

                //iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_UPLOADED);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.IsUploaded = pSqlReader.GetBoolean(iIndex);

                //iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_AVPATH);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.AVPath = pSqlReader.GetString(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_ALLOW_RESIZE);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.AllowResize = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_ALLOW_SCROLL);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.AllowScroll = pSqlReader.GetBoolean(iIndex);

                //iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_COURSE_LAUNCH_NEW_WIND0W);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.CourseLaunchNewWindow = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_COURSE_LAUNCH_SAME_WIND0W);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.CourseLaunchSameWindow = pSqlReader.GetBoolean(iIndex);

                //iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_COURSE_LAUNCH_SAME_WIND0W);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.CourseLaunchSameWindow = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_COURSE_WINDOW_HEIGHT);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.CourseWindowHeight = pSqlReader.GetInt32(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_COURSE_WINDOW_WIDTH);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.CourseWindowWidth = pSqlReader.GetInt32(iIndex);

                //iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_MASTERY_SCORE);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.MasteryScore = pSqlReader.GetInt32(iIndex);

                //iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_SCORE_TRACKING);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.ScoreTracking = pSqlReader.GetBoolean(iIndex);

                //iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_QUESTION_RESPONSE_TRACKING);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.QuestionResponseTracking = pSqlReader.GetBoolean(iIndex);

                //iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_SUB_TYPE_ID);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.ContentModuleSubTypeId = pSqlReader.GetString(iIndex);
                //else
                //    entContentModule.ContentModuleSubTypeId = "";

                //iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_PRINT_CERTIFICATE);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.IsPrintCertificate = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_COURSE_SESSION_NO_EXPIRY);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.IsCourseSessionNoExpiry = pSqlReader.GetBoolean(iIndex);

                //if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_COURSE_GROUP_ID))
                //{
                //    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_COURSE_GROUP_ID);
                //    if (!pSqlReader.IsDBNull(iIndex))
                //        entContentModule.CourseGroupId = pSqlReader.GetString(iIndex);
                //}
                //if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_IMANIFEST_URL))
                //{
                //    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IMANIFEST_URL);
                //    if (!pSqlReader.IsDBNull(iIndex))
                //        entContentModule.ImanifestUrl = pSqlReader.GetString(iIndex);
                //}

                //iIndex = pSqlReader.GetOrdinal(Schema.Language.COL_LANGUAGE_ID);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.LanguageId = pSqlReader.GetString(iIndex);

                //iIndex = pSqlReader.GetOrdinal(Schema.Common.COL_CREATED_BY);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.CreatedById = pSqlReader.GetString(iIndex);

                //iIndex = pSqlReader.GetOrdinal(Schema.Common.COL_CREATED_ON);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.DateCreated = pSqlReader.GetDateTime(iIndex);

                //iIndex = pSqlReader.GetOrdinal(Schema.Common.COL_MODIFIED_BY);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.LastModifiedById = pSqlReader.GetString(iIndex);

                //iIndex = pSqlReader.GetOrdinal(Schema.Common.COL_MODIFIED_ON);
                //if (!pSqlReader.IsDBNull(iIndex))
                //    entContentModule.LastModifiedDate = pSqlReader.GetDateTime(iIndex);

                //if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_IS_ALLOCATED))
                //{
                //    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_ALLOCATED);
                //    if (!pSqlReader.IsDBNull(iIndex))
                //        entContentModule.IsAllocated = pSqlReader.GetBoolean(iIndex);
                //}
                //else
                //    entContentModule.IsAllocated = false;


                //if (pRangeList)
                //{
                //    _entRange = new EntityRange();
                //    iIndex = pSqlReader.GetOrdinal(Schema.Common.COL_TOTAL_COUNT);
                //    if (!pSqlReader.IsDBNull(iIndex))
                //        _entRange.TotalRows = pSqlReader.GetInt32(iIndex);
                //    entContentModule.ListRange = _entRange;
                //}

                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_IS_SHORT_LANGUAGE_CODE))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_SHORT_LANGUAGE_CODE);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.IsShortLanguageCode = pSqlReader.GetBoolean(iIndex);
                }

				//-aw 6/15/2011 Added course protocol
				iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_PROTOCOL);
				if (!pSqlReader.IsDBNull(iIndex))
					entContentModule.Protocol = pSqlReader.GetString(iIndex);

                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_ISASSESSMENT))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_ISASSESSMENT);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.IsAssessment = pSqlReader.GetBoolean(iIndex);
                }
                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_ISMIDDLEPAGE))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_ISMIDDLEPAGE);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.IsMiddlePage= pSqlReader.GetBoolean(iIndex);
                }
			}
            return entContentModule;
        }

        /// <summary>
        /// Fill Find Object
        /// </summary>
        /// <param name="pSqlReader"></param>
        /// <param name="pRangeList"></param>
        /// <returns></returns>
        private ContentModule FillFindObject(SqlDataReader pSqlReader, bool pRangeList)
        {
            ContentModule entContentModule = new ContentModule();
            int iIndex;
            if (pSqlReader.HasRows)
            {
                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_ID);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.ID = pSqlReader.GetString(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_ENGLISH_NAME);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.ContentModuleEnglishName = pSqlReader.GetString(iIndex);
                else
                    entContentModule.ContentModuleEnglishName = "";

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_TYPE);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.ContentModuleTypeId = pSqlReader.GetString(iIndex);
                else
                    entContentModule.ContentModuleTypeId = "";

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_URL);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.ContentModuleURL = pSqlReader.GetString(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_ACTIVE);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.IsActive = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_UPLOADED);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.IsUploaded = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_AVPATH);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.AVPath = pSqlReader.GetString(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_ALLOW_RESIZE);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.AllowResize = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_ALLOW_SCROLL);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.AllowScroll = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_COURSE_LAUNCH_NEW_WIND0W);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.CourseLaunchNewWindow = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_COURSE_LAUNCH_SAME_WIND0W);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.CourseLaunchSameWindow = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_COURSE_LAUNCH_SAME_WIND0W);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.CourseLaunchSameWindow = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_COURSE_WINDOW_HEIGHT);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.CourseWindowHeight = pSqlReader.GetInt32(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_COURSE_WINDOW_WIDTH);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.CourseWindowWidth = pSqlReader.GetInt32(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_MASTERY_SCORE);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.MasteryScore = pSqlReader.GetInt32(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_SCORE_TRACKING);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.ScoreTracking = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_QUESTION_RESPONSE_TRACKING);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.QuestionResponseTracking = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_SUB_TYPE_ID);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.ContentModuleSubTypeId = pSqlReader.GetString(iIndex);
                else
                    entContentModule.ContentModuleSubTypeId = "";

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_PRINT_CERTIFICATE);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.IsPrintCertificate = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_COURSE_SESSION_NO_EXPIRY);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.IsCourseSessionNoExpiry = pSqlReader.GetBoolean(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.Common.COL_CREATED_BY);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.CreatedById = pSqlReader.GetString(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.Common.COL_CREATED_ON);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.DateCreated = pSqlReader.GetDateTime(iIndex);

                iIndex = pSqlReader.GetOrdinal(Schema.Common.COL_MODIFIED_BY);
                if (!pSqlReader.IsDBNull(iIndex))
                    entContentModule.LastModifiedById = pSqlReader.GetString(iIndex);

                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_IS_ALLOCATED))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_ALLOCATED);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.IsAllocated = pSqlReader.GetBoolean(iIndex);
                    else
                        entContentModule.IsAllocated = false;
                }
                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_IS_COURSE_MODIFIED_BY_ADMIN))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IS_COURSE_MODIFIED_BY_ADMIN);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.IsCourseModifiedByAdmin = pSqlReader.GetBoolean(iIndex);
                    else
                        entContentModule.IsCourseModifiedByAdmin = false;
                }

                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_COURSE_GROUP_ID))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_COURSE_GROUP_ID);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.CourseGroupId = pSqlReader.GetString(iIndex);
                }
                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_IMANIFEST_URL))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_IMANIFEST_URL);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.ImanifestUrl = pSqlReader.GetString(iIndex);
                }

				//-aw 6/15/2011
				iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_PROTOCOL);
				if (!pSqlReader.IsDBNull(iIndex))
					entContentModule.Protocol = pSqlReader.GetString(iIndex);

                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_ISASSESSMENT))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_ISASSESSMENT);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.IsAssessment = pSqlReader.GetBoolean(iIndex);
                    else
                        entContentModule.IsAssessment = false;
                }
                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.ContentModule.COL_ISMIDDLEPAGE))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.ContentModule.COL_ISMIDDLEPAGE);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.IsMiddlePage= pSqlReader.GetBoolean(iIndex);
                    else
                        entContentModule.IsMiddlePage = false;
                }

                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.Category.COL_CATEGORYNAME))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.Category.COL_CATEGORYNAME);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.CategoryName = pSqlReader.GetString(iIndex);
                   
                }
                if (SQLHelper.ReaderHasColumn(pSqlReader, Schema.SubCategory.COL_SUBCATEGORYNAME))
                {
                    iIndex = pSqlReader.GetOrdinal(Schema.SubCategory.COL_SUBCATEGORYNAME);
                    if (!pSqlReader.IsDBNull(iIndex))
                        entContentModule.SubCategoryName = pSqlReader.GetString(iIndex);

                }
                if (pRangeList)
                {
                    _entRange = new EntityRange();
                    iIndex = pSqlReader.GetOrdinal(Schema.Common.COL_TOTAL_COUNT);
                    if (!pSqlReader.IsDBNull(iIndex))
                        _entRange.TotalRows = pSqlReader.GetInt32(iIndex);
                    entContentModule.ListRange = _entRange;
                }
            }
            return entContentModule;
        }

        /// <summary>
        /// To Add new content module 
        /// </summary>
        /// <param name="pEntContModule"></param>
        /// <returns>ContentModule Object</returns>
        public ContentModule AddContentModule(ContentModule pEntContModule)
        {
            ContentModule entContentModule = new ContentModule();
            try
            {
                entContentModule = Update(pEntContModule, Schema.Common.VAL_INSERT_MODE);
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;
            }
            return entContentModule;
        }

        /// <summary>
        /// To Edit the content module data 
        /// </summary>
        /// <param name="pEntContModule"></param>
        /// <returns>ContentModule Object</returns>
        public ContentModule EditContentModule(ContentModule pEntContModule)
        {
            ContentModule entContentModule = new ContentModule();
            try
            {
                entContentModule = Update(pEntContModule, Schema.Common.VAL_UPDATE_MODE);
            }
            catch (Exception expCommon)
            {
               // _expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;
            }
            return entContentModule;
        }


        /// <summary>
        /// To delete selected content modules.
        /// </summary>
        /// <param name="pEntListContModule"></param>
        /// <returns></returns>
        //public List<ContentModule> BulkDelete(List<ContentModule> pEntListContentModule)
        //{
        //    _sqlObject = new SQLObject();
        //    List<ContentModule> entListContentModule = new List<ContentModule>();
        //    SqlDataAdapter sqladapter = null;
        //    DataTable dtable;
        //    SqlCommand sqlcmdDel;
        //    int iBatchSize = 0;
        //    DataRow drow = null;
        //    EntityRange entRange = new EntityRange();
        //    try
        //    {
        //        _strConnString = _sqlObject.GetClientDBConnString(pEntListContentModule[0].ClientId);
        //        _sqlcon = new SqlConnection(_strConnString);
        //        dtable = new DataTable();
        //        dtable.Columns.Add(Schema.ContentModule.COL_CONTENT_MODULE_ID);
        //        if (pEntListContentModule.Count > 0)
        //        {
        //            //Add Dummy Record in Table, Bcoz if records which is all asssign then it will not execute nonquery so not get count
        //            drow = dtable.NewRow();
        //            drow[Schema.ContentModule.COL_CONTENT_MODULE_ID] = "Temp0123456789";
        //            dtable.Rows.Add(drow);
        //            iBatchSize++;
        //        }
        //        foreach (ContentModule entContentModule in pEntListContentModule)
        //        {
        //            drow = dtable.NewRow();
        //            drow[Schema.ContentModule.COL_CONTENT_MODULE_ID] = entContentModule.ID;
        //            dtable.Rows.Add(drow);
        //            entListContentModule.Add(entContentModule);
        //            iBatchSize++;
        //        }
        //        if (dtable.Rows.Count > 0)
        //        {
        //            sqlcmdDel = new SqlCommand(Schema.ContentModule.PROC_DELETE_CONTENT_MODULE, _sqlcon);
        //            sqlcmdDel.CommandType = CommandType.StoredProcedure;
        //            sqlcmdDel.Parameters.Add(Schema.ContentModule.PARA_CONTENT_MODULE_ID, SqlDbType.NVarChar, 100, Schema.ContentModule.COL_CONTENT_MODULE_ID);
        //            sqladapter = new SqlDataAdapter();
        //            sqladapter.InsertCommand = sqlcmdDel;
        //            sqladapter.InsertCommand.UpdatedRowSource = UpdateRowSource.None;
        //            sqladapter.UpdateBatchSize = iBatchSize;
        //            entRange.TotalRows = sqladapter.Update(dtable);
        //        }
        //        entListContentModule[0].ListRange = entRange;
        //    }
        //    catch (Exception expCommon)
        //    {
        //        _expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
        //        throw _expCustom;
        //    }
        //    return entListContentModule;
        //}

        public List<ContentModule> BulkDelete(List<ContentModule> pEntListContentModule)
        {
            _sqlObject = new SQLObject();
            List<ContentModule> entListContentModule = new List<ContentModule>();            
            DataTable dtable;
            SqlCommand sqlcmdDel;           
            DataRow drow = null;
            EntityRange entRange = new EntityRange();
            try
            {
                _strConnString = _sqlObject.GetClientDBConnString(pEntListContentModule[0].ClientId);
                _sqlcon = new SqlConnection(_strConnString);
                dtable = new DataTable();
                dtable.Columns.Add(Schema.ContentModule.COL_CONTENT_MODULE_ID);
              
                foreach (ContentModule entContentModule in pEntListContentModule)
                {
                    drow = dtable.NewRow();
                    drow[Schema.ContentModule.COL_CONTENT_MODULE_ID] = entContentModule.ID;
                    dtable.Rows.Add(drow);
                    entListContentModule.Add(entContentModule);

                    sqlcmdDel = new SqlCommand(Schema.ContentModule.PROC_DELETE_CONTENT_MODULE, _sqlcon);
                    sqlcmdDel.CommandType = CommandType.StoredProcedure;
                    _sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_ID, entContentModule.ID);
                    sqlcmdDel.Parameters.Add(_sqlpara);
                  
                    int iDelStatus = _sqlObject.ExecuteNonQuery(sqlcmdDel, _strConnString);
                    if (iDelStatus > 0)
                    {
                        entListContentModule.Remove(entContentModule);
                    }
                }               
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;
            }
            return entListContentModule;
        }

        /// <summary>
        /// private method to support both Add and Edit content module transactions.
        /// </summary>
        /// <param name="pEntContModule"></param>
        /// <param name="pUpdateMode"></param>
        /// <returns>ContentModule Object</returns>
        private ContentModule Update(ContentModule pEntContModule, string pStrUpdateMode)
        {
            _sqlObject = new SQLObject();
            _sqlcmd = new SqlCommand();
            _sqlcmd.CommandText = Schema.ContentModule.PROC_UPDATE_CONTENT_MODULE;
            _strConnString = _sqlObject.GetClientDBConnString(pEntContModule.ClientId);
            if (pStrUpdateMode == Schema.Common.VAL_INSERT_MODE)
            {
                pEntContModule.ID = pEntContModule.ID;
                _sqlpara = new SqlParameter(Schema.Common.PARA_UPDATE_MODE, Schema.Common.VAL_INSERT_MODE);
            }
            else
                _sqlpara = new SqlParameter(Schema.Common.PARA_UPDATE_MODE, null);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_ID, pEntContModule.ID);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_URL, pEntContModule.ContentModuleURL);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_TYPE, pEntContModule.ContentModuleTypeId);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_IS_ACTIVE, pEntContModule.IsActive);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_IS_UPLOADED, pEntContModule.IsUploaded);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.Client.PARA_CLIENT_ID, pEntContModule.ClientId);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_ENGLISH_NAME, pEntContModule.ContentModuleEnglishName);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_COURSE_LAUNCH_NEW_WIND0W, pEntContModule.CourseLaunchNewWindow);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_COURSE_LAUNCH_SAME_WIND0W, pEntContModule.CourseLaunchSameWindow);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_COURSE_WINDOW_HEIGHT, pEntContModule.CourseWindowHeight);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_COURSE_WINDOW_WIDTH, pEntContModule.CourseWindowWidth);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_MASTERY_SCORE, pEntContModule.MasteryScore);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_SCORE_TRACKING, pEntContModule.ScoreTracking);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_QUESTION_RESPONSE_TRACKING, pEntContModule.QuestionResponseTracking);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_AVPATH, pEntContModule.AVPath);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_ALLOW_SCROLL, pEntContModule.AllowScroll);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_ALLOW_RESIZE, pEntContModule.AllowResize);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_IS_PRINT_CERTIFICATE, pEntContModule.IsPrintCertificate);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_IS_COURSE_SESSION_NO_EXPIRY, pEntContModule.IsCourseSessionNoExpiry);
            _sqlcmd.Parameters.Add(_sqlpara);

            if (!string.IsNullOrEmpty(pEntContModule.ContentModuleSubTypeId))
                _sqlpara = new SqlParameter(Schema.ContentModule.PARA_SUB_TYPE_ID, pEntContModule.ContentModuleSubTypeId);
            else
                _sqlpara = new SqlParameter(Schema.ContentModule.PARA_SUB_TYPE_ID, null);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.Common.PARA_CREATED_BY, pEntContModule.CreatedById);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.Common.PARA_MODIFIED_BY, pEntContModule.LastModifiedById);
            _sqlcmd.Parameters.Add(_sqlpara);

            //_sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_DESC, pEntContModule.ContentModuleDescription);
            //_sqlcmd.Parameters.Add(_sqlpara);

            //_sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_NAME, pEntContModule.ContentModuleName);
            //_sqlcmd.Parameters.Add(_sqlpara);

            //_sqlpara = new SqlParameter(Schema.ContentModule.PARA_KEY_WORDS, pEntContModule.ContentModuleKeyWords);
            //_sqlcmd.Parameters.Add(_sqlpara);

            if (pEntContModule.IsShortLanguageCode)
            {
                _sqlpara = new SqlParameter(Schema.ContentModule.PARA_IS_SHORT_LANGUAGE_CODE, pEntContModule.IsShortLanguageCode);
                _sqlcmd.Parameters.Add(_sqlpara);       
            }

            if (pEntContModule.IsCourseModifiedByAdmin)
            {
                _sqlpara = new SqlParameter(Schema.ContentModule.PARA_IS_COURSE_MODIFIED_BY_ADMIN, pEntContModule.IsCourseModifiedByAdmin);
                _sqlcmd.Parameters.Add(_sqlpara);     
            }
            
            //_sqlpara = new SqlParameter(Schema.Language.PARA_LANGUAGE_ID, pEntContModule.LanguageId);
            //_sqlcmd.Parameters.Add(_sqlpara);

            if (!string.IsNullOrEmpty(pEntContModule.ImanifestUrl))
                _sqlpara = new SqlParameter(Schema.ContentModule.PARA_IMANIFEST_URL, pEntContModule.ImanifestUrl);
            else
                _sqlpara = new SqlParameter(Schema.ContentModule.PARA_IMANIFEST_URL, null);
            _sqlcmd.Parameters.Add(_sqlpara);

            if (!string.IsNullOrEmpty(pEntContModule.CourseGroupId))
                _sqlpara = new SqlParameter(Schema.ContentModule.PARA_COURSE_GROUP_ID, pEntContModule.CourseGroupId);
            else
                _sqlpara = new SqlParameter(Schema.ContentModule.PARA_COURSE_GROUP_ID, null);
            _sqlcmd.Parameters.Add(_sqlpara);

			//-aw 6/15/2011
			_sqlpara = new SqlParameter(Schema.ContentModule.PARA_PROTOCOL, pEntContModule.Protocol);
			_sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_ISASSESSMENT, pEntContModule.IsAssessment);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_ISMIDDLEPAGE, pEntContModule.IsMiddlePage);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_ISHTML5, pEntContModule.IsHTML5);
            _sqlcmd.Parameters.Add(_sqlpara);

            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_KEEPZIPFILE, pEntContModule.KeepZipFile);
            _sqlcmd.Parameters.Add(_sqlpara);

            int iRows = _sqlObject.ExecuteNonQuery(_sqlcmd, _strConnString);

            return pEntContModule;
        }

        /// <summary>
        /// Get All Content Module Not Subscribed
        /// </summary>
        /// <param name="pEntContentModule"></param>
        /// <returns>List of ContentModule Object</returns>
        public List<ContentModule> GetContentModuleList(ContentModule pEntContentModule)
        {
            _sqlObject = new SQLObject();
            List<ContentModule> entListContentModules = new List<ContentModule>();
            SqlConnection sqlConnection = null;
            try
            {
                _strConnString = _sqlObject.GetClientDBConnString(pEntContentModule.ClientId);
                sqlConnection = new SqlConnection(_strConnString);
                _sqlcmd = new SqlCommand(Schema.ContentModule.PROC_GET_ALL_CONTENT_MODULES, sqlConnection);
                if (pEntContentModule.ListRange != null)
                {
                    if (pEntContentModule.ListRange.PageIndex > 0)
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_PAGE_INDEX, pEntContentModule.ListRange.PageIndex);
                        _sqlcmd.Parameters.Add(_sqlpara);
                    }
                    if (pEntContentModule.ListRange.PageSize > 0)
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_PAGE_SIZE, pEntContentModule.ListRange.PageSize);
                        _sqlcmd.Parameters.Add(_sqlpara);
                    }
                    if (!string.IsNullOrEmpty(pEntContentModule.ListRange.SortExpression))
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_SORT_EXP, pEntContentModule.ListRange.SortExpression);
                        _sqlcmd.Parameters.Add(_sqlpara);
                    }
                   
                    if (pEntContentModule.ListRange.RequestedById != null)
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_REQUESTED_BY_ID, pEntContentModule.ListRange.RequestedById);                    
                        _sqlcmd.Parameters.Add(_sqlpara);
                    }
                }
                //if (!string.IsNullOrEmpty(pEntContentModule.LanguageId))
                //{
                //    _sqlpara = new SqlParameter(Schema.Language.PARA_LANGUAGE_ID, pEntContentModule.LanguageId);
                //    _sqlcmd.Parameters.Add(_sqlpara);
                //}
                if (pEntContentModule.IsActive != null)
                {
                    _sqlpara = new SqlParameter(Schema.ContentModule.PARA_IS_ACTIVE, pEntContentModule.IsActive);
                    _sqlcmd.Parameters.Add(_sqlpara);
                }
                _sqlreader = _sqlObject.SqlDataReader(_sqlcmd, false);
                while (_sqlreader.Read())
                {
                    _entContentModule = FillObject(_sqlreader, true);
                    entListContentModules.Add(_entContentModule);
                }
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;
            }
            finally
            {
                if (_sqlreader != null && !_sqlreader.IsClosed)
                    _sqlreader.Close();
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) sqlConnection.Close();
            }
            return entListContentModules;
        }


        /// <summary>
        /// Get All Content Module Not Subscribed
        /// </summary>
        /// <param name="pEntContentModule"></param>
        /// <returns>List of ContentModule Object</returns>
        public List<ContentModule> GetContentModuleListNotCompletedList(ContentModule pEntContentModule)
        {
            _sqlObject = new SQLObject();
            List<ContentModule> entListContentModules = new List<ContentModule>();
            SqlConnection sqlConnection = null;
            try
            {
                _strConnString = _sqlObject.GetClientDBConnString(pEntContentModule.ClientId);
                sqlConnection = new SqlConnection(_strConnString);
                _sqlcmd = new SqlCommand(Schema.ContentModule.PROC_GET_USER_ASSIGN_ACTIVITY_LIST, sqlConnection);
                if (!string.IsNullOrEmpty(pEntContentModule.SystemUserGUID))
                {
                    _sqlpara = new SqlParameter(Schema.ContentModule.PARA_SYSTEM_USER_GUID,  pEntContentModule.SystemUserGUID);
                    _sqlcmd.Parameters.Add(_sqlpara);
                }
                if (pEntContentModule.ListRange != null)
                {
                    if (pEntContentModule.ListRange.PageIndex > 0)
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_PAGE_INDEX, pEntContentModule.ListRange.PageIndex);
                        _sqlcmd.Parameters.Add(_sqlpara);
                    }
                    if (pEntContentModule.ListRange.PageSize > 0)
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_PAGE_SIZE, pEntContentModule.ListRange.PageSize);
                        _sqlcmd.Parameters.Add(_sqlpara);
                    }
                    if (!string.IsNullOrEmpty(pEntContentModule.ListRange.SortExpression))
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_SORT_EXP, pEntContentModule.ListRange.SortExpression);
                        _sqlcmd.Parameters.Add(_sqlpara);
                    }
                    
                    if (pEntContentModule.ListRange.RequestedById != null)
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_REQUESTED_BY_ID, pEntContentModule.ListRange.RequestedById);
                        _sqlcmd.Parameters.Add(_sqlpara);
                    }
                }
                //if (!string.IsNullOrEmpty(pEntContentModule.LanguageId))
                //{
                //    _sqlpara = new SqlParameter(Schema.Language.PARA_LANGUAGE_ID, pEntContentModule.LanguageId);
                //    _sqlcmd.Parameters.Add(_sqlpara);
                //}
                //if (pEntContentModule.IsActive != null)
                //{
                //    _sqlpara = new SqlParameter(Schema.ContentModule.PARA_IS_ACTIVE, pEntContentModule.IsActive);
                //    _sqlcmd.Parameters.Add(_sqlpara);
                //}
                _sqlreader = _sqlObject.SqlDataReader(_sqlcmd, false);
                while (_sqlreader.Read())
                {
                    _entContentModule = FillObject(_sqlreader, true);
                    entListContentModules.Add(_entContentModule);
                }
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;
            }
            finally
            {
                if (_sqlreader != null && !_sqlreader.IsClosed)
                    _sqlreader.Close();
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) sqlConnection.Close();
            }
            return entListContentModules;
        }

        /// <summary>
        /// Get All Content Module Not Subscribed
        /// </summary>
        /// <param name="pEntContentModule"></param>
        /// <returns>List of ContentModule Object</returns>
        public List<ContentModule> GetContentModuleListAdminHome(ContentModule pEntContentModule)
        {
            _sqlObject = new SQLObject();
            List<ContentModule> entListContentModules = new List<ContentModule>();
            SqlConnection sqlConnection = null;
            try
            {
                _strConnString = _sqlObject.GetClientDBConnString(pEntContentModule.ClientId);
                sqlConnection = new SqlConnection(_strConnString);
                _sqlcmd = new SqlCommand(Schema.ContentModule.PROC_GET_ALL_CONTENT_MODULES_ADMIN_HOME, sqlConnection);
                if (pEntContentModule.ListRange != null)
                {
                    if (pEntContentModule.ListRange.PageIndex > 0)
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_PAGE_INDEX, pEntContentModule.ListRange.PageIndex);
                        _sqlcmd.Parameters.Add(_sqlpara);
                    }
                    if (pEntContentModule.ListRange.PageSize > 0)
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_PAGE_SIZE, pEntContentModule.ListRange.PageSize);
                        _sqlcmd.Parameters.Add(_sqlpara);
                    }
                    if (!string.IsNullOrEmpty(pEntContentModule.ListRange.SortExpression))
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_SORT_EXP, pEntContentModule.ListRange.SortExpression);
                        _sqlcmd.Parameters.Add(_sqlpara);
                    }
                    
                    if (pEntContentModule.ListRange.RequestedById != null)
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_REQUESTED_BY_ID, pEntContentModule.ListRange.RequestedById);
                        _sqlcmd.Parameters.Add(_sqlpara);
                    }
                }
                //if (!string.IsNullOrEmpty(pEntContentModule.LanguageId))
                //{
                //    _sqlpara = new SqlParameter(Schema.Language.PARA_LANGUAGE_ID, pEntContentModule.LanguageId);
                //    _sqlcmd.Parameters.Add(_sqlpara);
                //}
                if (pEntContentModule.IsActive != null)
                {
                    _sqlpara = new SqlParameter(Schema.ContentModule.PARA_IS_ACTIVE, pEntContentModule.IsActive);
                    _sqlcmd.Parameters.Add(_sqlpara);
                }
                _sqlreader = _sqlObject.SqlDataReader(_sqlcmd, false);
                while (_sqlreader.Read())
                {
                    _entContentModule = FillObjectAdminHome(_sqlreader, true);
                    entListContentModules.Add(_entContentModule);
                }
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;
            }
            finally
            {
                if (_sqlreader != null && !_sqlreader.IsClosed)
                    _sqlreader.Close();
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) sqlConnection.Close();
            }
            return entListContentModules;
        }

        /// <summary>
        /// Add All Modules (Bulk)
        /// </summary>
        /// <param name="pEntListContentModule"></param>
        /// <returns>List of ContentModule Object</returns>
        //public List<ContentModule> AddAllModules(List<ContentModule> pEntListContentModule)
        //{
        //    _sqlObject = new SQLObject();
        //    _sqladapter = new SqlDataAdapter();
        //    _dtable = new DataTable();
        //    List<ContentModule> entListContentModule = new List<ContentModule>();
        //    List<ContentModuleLanguages> entListContentModuleLanguages = new List<ContentModuleLanguages>();
        //    int iBatchSize = 0;
        //    try
        //    {
        //        if (pEntListContentModule.Count > 0)
        //        {
        //            _dtable = new DataTable();
        //            _dtable.Columns.Add(Schema.ContentModule.COL_CONTENT_MODULE_ID);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_CONTENT_MODULE_ENGLISH_NAME);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_CONTENT_MODULE_URL);
        //            _dtable.Columns.Add(Schema.Client.COL_CLIENT_ID);
        //            _dtable.Columns.Add(Schema.Common.COL_CREATED_BY);
        //            _dtable.Columns.Add(Schema.Common.COL_MODIFIED_BY);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_CONTENT_MODULE_TYPE);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_IS_ACTIVE);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_IS_UPLOADED);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_SUB_TYPE_ID);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_DEL_LANGUAGES);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_SCORE_TRACKING);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_QUESTION_RESPONSE_TRACKING);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_MASTERY_SCORE);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_AVPATH);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_COURSE_LAUNCH_SAME_WIND0W);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_COURSE_LAUNCH_NEW_WIND0W);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_ALLOW_SCROLL);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_ALLOW_RESIZE);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_COURSE_WINDOW_WIDTH);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_COURSE_WINDOW_HEIGHT);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_IS_PRINT_CERTIFICATE);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_IS_COURSE_SESSION_NO_EXPIRY);
                    
        //            _dtable.Columns.Add(Schema.ContentModule.COL_COURSE_GROUP_ID);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_IMANIFEST_URL);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_IS_SHORT_LANGUAGE_CODE);

        //            //-aw 6/15/2011 Added course protocol
        //            _dtable.Columns.Add(Schema.ContentModule.COL_PROTOCOL);

        //            _dtable.Columns.Add(Schema.ContentModule.COL_ISASSESSMENT);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_ISMIDDLEPAGE);

        //            ContentModuleLanguages entCML = new ContentModuleLanguages();
        //            int iLangCount = 0;
        //            foreach (ContentModule entCM in pEntListContentModule)
        //            {
                       
        //                if (_dtable.Select(Schema.ContentModule.COL_CONTENT_MODULE_ID + "='" + entCM.ID + "'").Length <= 0)
        //                {
        //                    if (iLangCount > 0) // CHANGE TO DELETE ALL LANGUAGES RELATED TO SINGLE CONTENT MODULE ON UPDATE
        //                    {
        //                        _dtable.Rows[_dtable.Rows.Count - 1][Schema.ContentModule.COL_DEL_LANGUAGES] = true;
        //                        iLangCount = 0;
        //                    }

        //                    if (String.IsNullOrEmpty(_strConnString))
        //                        _strConnString = _sqlObject.GetClientDBConnString(entCM.ClientId);

        //                    DataRow drow = _dtable.NewRow();
        //                    drow[Schema.ContentModule.COL_CONTENT_MODULE_ID] = entCM.ID;
        //                    drow[Schema.ContentModule.COL_CONTENT_MODULE_URL] = entCM.ContentModuleURL;
        //                    drow[Schema.Client.COL_CLIENT_ID] = entCM.ClientId;
        //                    drow[Schema.ContentModule.COL_CONTENT_MODULE_ENGLISH_NAME] = entCM.ContentModuleEnglishName;
        //                    drow[Schema.Common.COL_CREATED_BY] = entCM.CreatedById;
        //                    drow[Schema.Common.COL_MODIFIED_BY] = entCM.LastModifiedById;
        //                    drow[Schema.ContentModule.COL_CONTENT_MODULE_TYPE] = entCM.ContentModuleTypeId;
        //                    drow[Schema.ContentModule.COL_IS_ACTIVE] = entCM.IsActive;
        //                    drow[Schema.ContentModule.COL_IS_UPLOADED] = entCM.IsUploaded;
        //                    drow[Schema.ContentModule.COL_SUB_TYPE_ID] = entCM.ContentModuleSubTypeId;
        //                    drow[Schema.ContentModule.COL_SCORE_TRACKING] = entCM.ScoreTracking;
        //                    drow[Schema.ContentModule.COL_QUESTION_RESPONSE_TRACKING] = entCM.QuestionResponseTracking;
        //                    drow[Schema.ContentModule.COL_MASTERY_SCORE] = entCM.MasteryScore;
        //                    drow[Schema.ContentModule.COL_AVPATH] = entCM.AVPath;
        //                    drow[Schema.ContentModule.COL_COURSE_LAUNCH_SAME_WIND0W] = entCM.CourseLaunchSameWindow;
        //                    drow[Schema.ContentModule.COL_COURSE_LAUNCH_NEW_WIND0W] = entCM.CourseLaunchNewWindow;
        //                    drow[Schema.ContentModule.COL_ALLOW_SCROLL] = entCM.AllowScroll;
        //                    drow[Schema.ContentModule.COL_ALLOW_RESIZE] = entCM.AllowResize;
        //                    drow[Schema.ContentModule.COL_COURSE_WINDOW_WIDTH] = entCM.CourseWindowWidth;
        //                    drow[Schema.ContentModule.COL_COURSE_WINDOW_HEIGHT] = entCM.CourseWindowHeight;
        //                    drow[Schema.ContentModule.COL_IS_PRINT_CERTIFICATE] = entCM.IsPrintCertificate;
        //                    drow[Schema.ContentModule.COL_IS_COURSE_SESSION_NO_EXPIRY] = entCM.IsCourseSessionNoExpiry;
        //                    drow[Schema.ContentModule.COL_IS_SHORT_LANGUAGE_CODE] = entCM.IsShortLanguageCode;
        //                    drow[Schema.ContentModule.COL_COURSE_GROUP_ID]= entCM.CourseGroupId;
        //                    drow[Schema.ContentModule.COL_IMANIFEST_URL]= entCM.ImanifestUrl;

        //                    //-aw 6/15/2011 Added course protocol
        //                    drow[Schema.ContentModule.COL_PROTOCOL] = entCM.Protocol;

        //                    drow[Schema.ContentModule.COL_ISASSESSMENT] = entCM.IsAssessment;
        //                    drow[Schema.ContentModule.COL_ISMIDDLEPAGE] = entCM.IsMiddlePage;

        //                    if (!string.IsNullOrEmpty(entCM.LanguageId))
        //                        iLangCount++;
        //                    _dtable.Rows.Add(drow);
        //                    iBatchSize = iBatchSize + 1;
        //                    entListContentModule.Add(entCM);
        //                }
        //                else // CHANGE TO DELETE ALL LANGUAGES RELATED TO SINGLE CONTENT MODULE ON UPDATE
        //                {
        //                    iLangCount++;
        //                }

        //                //entCML = new ContentModuleLanguages();
        //                //entCML.ContentModuleName = entCM.ContentModuleName;
        //                //entCML.ContentModuleDescription = entCM.ContentModuleDescription;
        //                //entCML.LanguageId = entCM.LanguageId;
        //                //entCML.ContentModuleKeyWords = entCM.ContentModuleKeyWords;
        //                //entCML.ID = entCM.ID;
        //                //entCML.ClientId = entCM.ClientId;
        //                //entListContentModuleLanguages.Add(entCML);
        //            }
        //            if (iLangCount > 0) // CHANGE TO DELETE ALL LANGUAGES RELATED TO SINGLE CONTENT MODULE ON UPDATE
        //            {
        //                _dtable.Rows[_dtable.Rows.Count - 1][Schema.ContentModule.COL_DEL_LANGUAGES] = true;
        //                iLangCount = 0;
        //            }

        //            if (_dtable.Rows.Count > 0)
        //            {
        //                _sqlcmd = new SqlCommand();
        //                _sqlcmd.CommandText = Schema.ContentModule.PROC_UPDATE_CONTENT_MODULE;
        //                _sqlcmd.CommandType = CommandType.StoredProcedure;
        //                _sqlcon = new SqlConnection(_strConnString);
        //                _sqlcmd.Connection = _sqlcon;
        //                _sqladapter.InsertCommand = _sqlcmd;
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_CONTENT_MODULE_ID, SqlDbType.VarChar, 100, Schema.ContentModule.COL_CONTENT_MODULE_ID);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_CONTENT_MODULE_ENGLISH_NAME, SqlDbType.VarChar, 100, Schema.ContentModule.COL_CONTENT_MODULE_ENGLISH_NAME);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_CONTENT_MODULE_URL, SqlDbType.NVarChar, 100, Schema.ContentModule.COL_CONTENT_MODULE_URL);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_CONTENT_MODULE_TYPE, SqlDbType.VarChar, 100, Schema.ContentModule.COL_CONTENT_MODULE_TYPE);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.Client.PARA_CLIENT_ID, SqlDbType.VarChar, 100, Schema.Client.COL_CLIENT_ID);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.Common.PARA_CREATED_BY, SqlDbType.VarChar, 100, Schema.Common.COL_CREATED_BY);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.Common.PARA_MODIFIED_BY, SqlDbType.VarChar, 100, Schema.Common.COL_MODIFIED_BY);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_IS_ACTIVE, SqlDbType.Bit, 1, Schema.ContentModule.COL_IS_ACTIVE);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_IS_UPLOADED, SqlDbType.Bit, 1, Schema.ContentModule.COL_IS_UPLOADED);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_SUB_TYPE_ID, SqlDbType.VarChar, 100, Schema.ContentModule.COL_SUB_TYPE_ID);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_DEL_LANGUAGES, SqlDbType.Bit, 1, Schema.ContentModule.COL_DEL_LANGUAGES); // CHANGE TO DELETE ALL LANGUAGES RELATED TO SINGLE CONTENT MODULE ON UPDATE

        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_SCORE_TRACKING, SqlDbType.Bit, 1, Schema.ContentModule.COL_SCORE_TRACKING);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_QUESTION_RESPONSE_TRACKING, SqlDbType.Bit, 1, Schema.ContentModule.COL_QUESTION_RESPONSE_TRACKING);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_MASTERY_SCORE, SqlDbType.Int, 10, Schema.ContentModule.COL_MASTERY_SCORE);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_AVPATH, SqlDbType.VarChar, 100, Schema.ContentModule.COL_AVPATH);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_COURSE_LAUNCH_SAME_WIND0W, SqlDbType.Bit, 1, Schema.ContentModule.COL_COURSE_LAUNCH_SAME_WIND0W);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_COURSE_LAUNCH_NEW_WIND0W, SqlDbType.Bit, 1, Schema.ContentModule.COL_COURSE_LAUNCH_NEW_WIND0W);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_ALLOW_SCROLL, SqlDbType.Bit, 1, Schema.ContentModule.COL_ALLOW_SCROLL);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_ALLOW_RESIZE, SqlDbType.Bit, 1, Schema.ContentModule.COL_ALLOW_RESIZE);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_COURSE_WINDOW_WIDTH, SqlDbType.Int, 10, Schema.ContentModule.COL_COURSE_WINDOW_WIDTH);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_COURSE_WINDOW_HEIGHT, SqlDbType.Int, 10, Schema.ContentModule.COL_COURSE_WINDOW_HEIGHT);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_IS_PRINT_CERTIFICATE, SqlDbType.Bit, 10, Schema.ContentModule.COL_IS_PRINT_CERTIFICATE);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_IS_COURSE_SESSION_NO_EXPIRY, SqlDbType.Bit, 10, Schema.ContentModule.COL_IS_COURSE_SESSION_NO_EXPIRY);

        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_COURSE_GROUP_ID, SqlDbType.VarChar, 100, Schema.ContentModule.COL_COURSE_GROUP_ID);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_IMANIFEST_URL, SqlDbType.VarChar, 500, Schema.ContentModule.COL_IMANIFEST_URL);

        //                //-aw 6/15/2011 Added course protocol
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_PROTOCOL, SqlDbType.VarChar, 5, Schema.ContentModule.COL_PROTOCOL);

        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_ISASSESSMENT, SqlDbType.Bit, 1, Schema.ContentModule.COL_ISASSESSMENT);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_ISMIDDLEPAGE, SqlDbType.Bit, 1, Schema.ContentModule.COL_ISMIDDLEPAGE);

        //                _sqladapter.InsertCommand.Parameters.AddWithValue(Schema.Common.PARA_UPDATE_MODE, Schema.Common.VAL_INSERT_MODE);
        //                _sqladapter.InsertCommand.UpdatedRowSource = UpdateRowSource.None;
        //                _sqladapter.UpdateBatchSize = iBatchSize;
        //                _sqladapter.Update(_dtable);
        //                _sqladapter.Dispose();
        //                //entListContentModuleLanguages = AddAllModuleLanguages(entListContentModuleLanguages);
        //            }
        //        }
        //    }
        //    catch (Exception expCommon)
        //    {
        //        //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
        //        throw expCommon;
        //    }
        //    return entListContentModule;
        //}

        /// <summary>
        /// Add All Module Languages
        /// </summary>
        /// <param name="pEntListContentModuleLanguages"></param>
        /// <returns></returns>
        //public List<ContentModuleLanguages> AddAllModuleLanguages(List<ContentModuleLanguages> pEntListContentModuleLanguages)
        //{
        //    _sqlObject = new SQLObject();
        //    _sqladapter = new SqlDataAdapter();
        //    _dtable = new DataTable();
        //    List<ContentModuleLanguages> entListContentModuleLanguages = new List<ContentModuleLanguages>();
        //    int iBatchSize = 0;
        //    try
        //    {
        //        if (pEntListContentModuleLanguages.Count > 0)
        //        {
        //            _dtable = new DataTable();
        //            _dtable.Columns.Add(Schema.ContentModule.COL_CONTENT_MODULE_ID);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_CONTENT_MODULE_NAME);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_CONTENT_MODULE_DESC);
        //            _dtable.Columns.Add(Schema.Language.COL_LANGUAGE_ID);
        //            _dtable.Columns.Add(Schema.ContentModule.COL_KEY_WORDS);

        //            if (String.IsNullOrEmpty(_strConnString))
        //                _strConnString = _sqlObject.GetClientDBConnString(pEntListContentModuleLanguages[0].ClientId);
        //            foreach (BaseEntity objBase in pEntListContentModuleLanguages)
        //            {
        //                ContentModuleLanguages entCML = (ContentModuleLanguages)objBase;
        //                DataRow drow = _dtable.NewRow();
        //                drow[Schema.ContentModule.COL_CONTENT_MODULE_ID] = entCML.ID;
        //                drow[Schema.ContentModule.COL_CONTENT_MODULE_NAME] = entCML.ContentModuleName;
        //                drow[Schema.ContentModule.COL_CONTENT_MODULE_DESC] = Convert.ToString(entCML.ContentModuleDescription);
        //                drow[Schema.Language.COL_LANGUAGE_ID] = entCML.LanguageId;
        //                drow[Schema.ContentModule.COL_KEY_WORDS] = entCML.ContentModuleKeyWords;

        //                _dtable.Rows.Add(drow);
        //                iBatchSize = iBatchSize + 1;
        //                entListContentModuleLanguages.Add(entCML);
        //            }

        //            if (_dtable.Rows.Count > 0)
        //            {
        //                _sqlcmd = new SqlCommand();
        //                _sqlcmd.CommandText = Schema.ContentModuleLanguages.PROC_UPDATE_CONTENT_MODULE_LANGUAGES;
        //                _sqlcmd.CommandType = CommandType.StoredProcedure;
        //                _sqlcon = new SqlConnection(_strConnString);
        //                _sqlcmd.Connection = _sqlcon;
        //                _sqladapter.InsertCommand = _sqlcmd;
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_CONTENT_MODULE_ID, SqlDbType.VarChar, 100, Schema.ContentModule.COL_CONTENT_MODULE_ID);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_CONTENT_MODULE_NAME, SqlDbType.NVarChar, 100, Schema.ContentModule.COL_CONTENT_MODULE_NAME);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_CONTENT_MODULE_DESC, SqlDbType.NVarChar, 2000, Schema.ContentModule.COL_CONTENT_MODULE_DESC);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.Language.PARA_LANGUAGE_ID, SqlDbType.VarChar, 100, Schema.Language.COL_LANGUAGE_ID);
        //                _sqladapter.InsertCommand.Parameters.Add(Schema.ContentModule.PARA_KEY_WORDS, SqlDbType.NVarChar, 2000, Schema.ContentModule.COL_KEY_WORDS);
        //                _sqladapter.InsertCommand.Parameters.AddWithValue(Schema.Common.PARA_UPDATE_MODE, Schema.Common.VAL_INSERT_MODE);
        //                _sqladapter.InsertCommand.UpdatedRowSource = UpdateRowSource.None;
        //                _sqladapter.UpdateBatchSize = iBatchSize;
        //                _sqladapter.Update(_dtable);
        //                _sqladapter.Dispose();
        //            }
        //        }
        //    }
        //    catch (Exception expCommon)
        //    {
        //       // _expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
        //        throw expCommon;
        //    }
        //    return entListContentModuleLanguages;
        //}

        /// <summary>
        /// Find Content Module
        /// </summary>
        /// <param name="pEntSearch"></param>
        /// <returns></returns>
        //public List<ContentModule> FindContentModule(Search pEntSearch)
        //{
        //    _sqlObject = new SQLObject();
        //    BVLMS.Entity.ContentModule entContModule = null;
        //    List<ContentModule> entListContModules = new List<ContentModule>();
        //    SqlConnection sqlMasterConnection = new SqlConnection(_sqlObject.GetClientDBConnString(pEntSearch.ClientId));
        //    _sqlcmd = new SqlCommand(Schema.ContentModule.PROC_FIND_CONTENT_MODULE, sqlMasterConnection);
        //    if (!String.IsNullOrEmpty(pEntSearch.KeyWord))
        //        _sqlpara = new SqlParameter(Schema.Common.PARA_KEY_WORD, pEntSearch.KeyWord);
        //    else
        //        _sqlpara = new SqlParameter(Schema.Common.PARA_KEY_WORD, null);
        //    _sqlcmd.Parameters.Add(_sqlpara);

        //    if (!String.IsNullOrEmpty(pEntSearch.CreatedById))
        //        _sqlpara = new SqlParameter(Schema.ContentModule.PARA_REQUESTED_BY_ID, pEntSearch.CreatedById);
        //    else
        //        _sqlpara = new SqlParameter(Schema.ContentModule.PARA_REQUESTED_BY_ID, null);
        //    _sqlcmd.Parameters.Add(_sqlpara);
            
        //    if (!String.IsNullOrEmpty(pEntSearch.ClientId))
        //    {
        //        _sqlpara = new SqlParameter(Schema.Client.PARA_CLIENT_ID, pEntSearch.ClientId);
        //        _sqlcmd.Parameters.Add(_sqlpara);
        //    }
        //    if (pEntSearch.ListRange != null)
        //    {
        //        if (pEntSearch.ListRange.PageIndex > 0)
        //            _sqlpara = new SqlParameter(Schema.Common.PARA_PAGE_INDEX, pEntSearch.ListRange.PageIndex);
        //        else
        //            _sqlpara = new SqlParameter(Schema.Common.PARA_PAGE_INDEX, null);
        //        _sqlcmd.Parameters.Add(_sqlpara);

        //        if (pEntSearch.ListRange.PageSize > 0)
        //            _sqlpara = new SqlParameter(Schema.Common.PARA_PAGE_SIZE, pEntSearch.ListRange.PageSize);
        //        else
        //            _sqlpara = new SqlParameter(Schema.Common.PARA_PAGE_SIZE, null);
        //        _sqlcmd.Parameters.Add(_sqlpara);

        //        if (!string.IsNullOrEmpty(pEntSearch.ListRange.SortExpression))
        //            _sqlpara = new SqlParameter(Schema.Common.PARA_SORT_EXP, pEntSearch.ListRange.SortExpression);
        //        else
        //            _sqlpara = new SqlParameter(Schema.Common.PARA_SORT_EXP, null);
        //        _sqlcmd.Parameters.Add(_sqlpara);
        //    }
        //    if (pEntSearch.SearchObject != null && pEntSearch.SearchObject.Count > 0)
        //    {
        //        entContModule = new ContentModule();
        //        entContModule = (ContentModule)pEntSearch.SearchObject[0];
        //        if (entContModule.IsActive.HasValue)
        //        {
        //            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_IS_ACTIVE, entContModule.IsActive);
        //            _sqlcmd.Parameters.Add(_sqlpara);
        //        }
        //        if (entContModule.ContentModuleTypeId != null)
        //        {
        //            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_TYPE, entContModule.ContentModuleTypeId);
        //            _sqlcmd.Parameters.Add(_sqlpara);
        //        }
        //        if (entContModule.ContentModuleSubTypeId != null)
        //        {
        //            _sqlpara = new SqlParameter(Schema.ContentModule.PARA_SUB_TYPE_ID, entContModule.ContentModuleSubTypeId);
        //            _sqlcmd.Parameters.Add(_sqlpara);
        //        }

        //        if (!string.IsNullOrEmpty(entContModule.CategoryId ))
        //        {
        //            _sqlpara = new SqlParameter(Schema.Category.PARA_CATEGORYID, entContModule.CategoryId);
        //            _sqlcmd.Parameters.Add(_sqlpara);
        //        }

        //        if (!string.IsNullOrEmpty(entContModule.SubCategoryId))
        //        {
        //            _sqlpara = new SqlParameter(Schema.SubCategory.PARA_SUBCATEGORYID, entContModule.SubCategoryId);
        //            _sqlcmd.Parameters.Add(_sqlpara);
        //        }

        //    }
        //    try
        //    {
        //        _sqlreader = _sqlObject.ExecuteMasterReader(_sqlcmd, false);
        //        while (_sqlreader.Read())
        //        {
        //            entContModule = FillFindObject(_sqlreader, true);
        //            entListContModules.Add(entContModule);
        //        }
        //    }
        //    catch (Exception expCommon)
        //    {
        //        //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
        //        throw expCommon;
        //    }
        //    finally
        //    {
        //        if (_sqlreader != null && !_sqlreader.IsClosed)
        //            _sqlreader.Close();
        //        if (sqlMasterConnection != null && sqlMasterConnection.State != ConnectionState.Closed)
        //            sqlMasterConnection.Close();
        //    }
        //    return entListContModules;
        //}

        #region Interface Methods
        /// <summary>
        /// Get By ID
        /// </summary>
        /// <param name="pEntContentModule"></param>
        /// <returns></returns>
        public ContentModule Get(ContentModule pEntContentModule)
        {
            return GetContentModuleByID(pEntContentModule);
        }
        /// <summary>
        /// Update ContentModule
        /// </summary>
        /// <param name="pEntContentModule"></param>
        /// <returns></returns>
        public ContentModule Update(ContentModule pEntContentModule)
        {
            return EditContentModule(pEntContentModule);
        }
        #endregion

        public ContentModule GetById(string clientId, string courseId)
        {
            return GetContentModuleByID(new ContentModule {ClientId = clientId, ID = courseId});
        }

        public ContentModule GetByIdForCoursePlayer(string courseId)
        {
            return GetContentModuleByID_CoursePlayer(new ContentModule {  ID = courseId });
        }

        /// <summary>
        /// Get All Content Module for Assessment Questions
        /// </summary>
        /// <param name="pEntContentModule"></param>
        /// <returns>List of Assessment Content Module Object</returns>
        public List<ContentModule> GetAssessmentContentModuleList(ContentModule pEntContentModule)
        {
            _sqlObject = new SQLObject();
            List<ContentModule> entListContentModules = new List<ContentModule>();
            SqlConnection sqlConnection = null;
            try
            {
                _strConnString = _sqlObject.GetClientDBConnString(pEntContentModule.ClientId);
                sqlConnection = new SqlConnection(_strConnString);
                _sqlcmd = new SqlCommand(Schema.ContentModule.PROC_GET_ALL_ASSESSMENT_CONTENT_MODULE, sqlConnection);
                if (pEntContentModule.ListRange != null)
                {
                    if (pEntContentModule.ListRange.PageIndex > 0)
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_PAGE_INDEX, pEntContentModule.ListRange.PageIndex);
                        //_sqlcmd.Parameters.Add(_sqlpara);
                    }
                    if (pEntContentModule.ListRange.PageSize > 0)
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_PAGE_SIZE, pEntContentModule.ListRange.PageSize);
                        //_sqlcmd.Parameters.Add(_sqlpara);
                    }
                    if (!string.IsNullOrEmpty(pEntContentModule.ListRange.SortExpression))
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_SORT_EXP, pEntContentModule.ListRange.SortExpression);
                        //_sqlcmd.Parameters.Add(_sqlpara);
                    }
                    
                    if (pEntContentModule.ListRange.RequestedById != null)
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_REQUESTED_BY_ID, pEntContentModule.ListRange.RequestedById);
                        //_sqlcmd.Parameters.Add(_sqlpara);
                    }
                }
                if (!string.IsNullOrEmpty(pEntContentModule.ID))
                {
                    _sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_ID, pEntContentModule.ID);
                    _sqlcmd.Parameters.Add(_sqlpara);
                }
                _sqlreader = _sqlObject.SqlDataReader(_sqlcmd, false);
                while (_sqlreader.Read())
                {
                    _entContentModule = FillObject(_sqlreader, false);
                    entListContentModules.Add(_entContentModule);
                }
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;
            }
            finally
            {
                if (_sqlreader != null && !_sqlreader.IsClosed)
                    _sqlreader.Close();
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) sqlConnection.Close();
            }
            return entListContentModules;
        }

        /// <summary>
        /// Get All Content Module for Assessment Questions
        /// </summary>
        /// <param name="pEntContentModule"></param>
        /// <returns>List of Assessment Content Module Object</returns>
        public List<ContentModule> GetUserAssessmentContentModuleList(ContentModule pEntContentModule)
        {
            _sqlObject = new SQLObject();
            List<ContentModule> entListContentModules = new List<ContentModule>();
            SqlConnection sqlConnection = null;
            try
            {
                _strConnString = _sqlObject.GetClientDBConnString(pEntContentModule.ClientId);
                sqlConnection = new SqlConnection(_strConnString);
                _sqlcmd = new SqlCommand(Schema.ContentModule.PROC_GET_ALL_USER_ASSESSMENT_CONTENT_MODULE, sqlConnection);

                if (!String.IsNullOrEmpty(pEntContentModule.LastModifiedById))
                    _sqlpara = new SqlParameter(Schema.Learner.PARA_USER_ID, pEntContentModule.LastModifiedById);
                else
                    _sqlpara = new SqlParameter(Schema.Learner.PARA_USER_ID, null);
                _sqlcmd.Parameters.Add(_sqlpara);
              
              //  pEntContentModule.LastModifiedById
                if (pEntContentModule.ListRange != null)
                {
                    if (pEntContentModule.ListRange.PageIndex > 0)
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_PAGE_INDEX, pEntContentModule.ListRange.PageIndex);
                        //_sqlcmd.Parameters.Add(_sqlpara);
                    }
                    if (pEntContentModule.ListRange.PageSize > 0)
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_PAGE_SIZE, pEntContentModule.ListRange.PageSize);
                        //_sqlcmd.Parameters.Add(_sqlpara);
                    }
                    if (!string.IsNullOrEmpty(pEntContentModule.ListRange.SortExpression))
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_SORT_EXP, pEntContentModule.ListRange.SortExpression);
                        //_sqlcmd.Parameters.Add(_sqlpara);
                    }
                    
                    if (pEntContentModule.ListRange.RequestedById != null)
                    {
                        _sqlpara = new SqlParameter(Schema.Common.PARA_REQUESTED_BY_ID, pEntContentModule.ListRange.RequestedById);
                        //_sqlcmd.Parameters.Add(_sqlpara);
                    }
                }
                if (!string.IsNullOrEmpty(pEntContentModule.ID))
                {
                    _sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_ID, pEntContentModule.ID);
                    _sqlcmd.Parameters.Add(_sqlpara);
                }
                _sqlreader = _sqlObject.SqlDataReader(_sqlcmd, false);
                while (_sqlreader.Read())
                {
                    _entContentModule = FillObject(_sqlreader, false);
                    entListContentModules.Add(_entContentModule);
                }
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;
            }
            finally
            {
                if (_sqlreader != null && !_sqlreader.IsClosed)
                    _sqlreader.Close();
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) sqlConnection.Close();
            }
            return entListContentModules;
        }


    }
}