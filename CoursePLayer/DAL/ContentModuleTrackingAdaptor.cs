
using System;
using System.Data;
using System.Data.SqlClient;


using System.Collections.Generic;

namespace HRS.CoursePlayer
{
    public interface IContentModuleTrackingAdaptor
    {
        ContentModuleTracking GetContentModuleTrackingByID(ContentModuleTracking pEntContModTracking);
        ContentModuleTrackingAdaptor.ContentModuleTrackingUpdateResult EditContentModuleTracking(ContentModuleTracking pEntContModTracking);
        
    }

    public class ContentModuleTrackingAdaptor : IContentModuleTrackingAdaptor, IDataManager<ContentModuleTracking>
    {
        #region Declaration
        //CustomException _expCustom = null;
        SqlDataReader sqlreader = null;
        SqlDataReader _sqlreader = null;
        SqlCommand sqlcmd = null;
        SqlCommand _sqlcmd = null;
        SqlParameter _sqlpara = null;
        SqlParameter sqlpara = null;       
        DataTable _dtable = null;
        SQLObject _sqlObject = null;
        //string _strMessageId = Services.Messages.Content.CONT_MOD_TRACK_ERROR;
        string _strConnString = string.Empty;
        #endregion

        /// <summary>
        /// To Get Content Module Tracking details by condent module id and User Id.
        /// </summary>
        /// <param name="pEntContModTracking"></param>
        /// <returns>ContentModuleTracking object </returns>
        public ContentModuleTracking GetContentModuleTrackingByID(ContentModuleTracking pEntContModTracking)
        {
            _sqlObject = new SQLObject();
            ContentModuleTracking entContModTracking = new ContentModuleTracking();
            SqlConnection sqlConnection = null;
            try
            {
                _strConnString = _sqlObject.GetClientDBConnString(pEntContModTracking.ClientId);
                sqlConnection = new SqlConnection(_strConnString);
                sqlcmd = new SqlCommand(Schema.ContentModuleTracking.PROC_GET_CONTENT_MODULE_TRACKING, sqlConnection);
                sqlpara = new SqlParameter(Schema.Common.PARA_ATTEMPT_ID, pEntContModTracking.ID);
                sqlcmd.Parameters.Add(sqlpara);

                sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_ID, pEntContModTracking.ContentModuleId);
                sqlcmd.Parameters.Add(sqlpara);

                sqlpara = new SqlParameter(Schema.Learner.PARA_USER_ID, pEntContModTracking.UserID);
                sqlcmd.Parameters.Add(sqlpara);

                sqlpara = new SqlParameter("SessionId", pEntContModTracking.SessionId);
                sqlcmd.Parameters.Add(sqlpara);

                sqlreader = _sqlObject.SqlDataReader(sqlcmd, false);
                entContModTracking = FillObject(sqlreader, _sqlObject);
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                //throw _expCustom;
            }
            finally
            {
                if (sqlreader != null && !sqlreader.IsClosed) sqlreader.Close();
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) sqlConnection.Close();
            }
            entContModTracking.ClientId = pEntContModTracking.ClientId;
            entContModTracking.SessionId = pEntContModTracking.SessionId;
            return entContModTracking;
        }

        /// <summary>
        /// To Get Content Module Tracking details by condent module id and User Id.
        /// </summary>
        /// <param name="pEntContModTracking"></param>
        /// <returns>ContentModuleTracking object </returns>
        public ContentModuleTracking GetContentModuleTrackingStatusById_Learner(ContentModuleTracking pEntContModTracking)
        {
            _sqlObject = new SQLObject();
            ContentModuleTracking entContModTracking = new ContentModuleTracking();
            SqlConnection sqlConnection = null;
            try
            {
                _strConnString = _sqlObject.GetClientDBConnString(pEntContModTracking.ClientId);
                sqlConnection = new SqlConnection(_strConnString);
                sqlcmd = new SqlCommand(Schema.ContentModuleTracking.PROC_GET_USER_COURSE_COMPLETION_STATUS, sqlConnection);

                //sqlpara = new SqlParameter(Schema.Common.PARA_ATTEMPT_ID, pEntContModTracking.ID);
                //sqlcmd.Parameters.Add(sqlpara);

                sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_ID, pEntContModTracking.ContentModuleId);
                sqlcmd.Parameters.Add(sqlpara);

                sqlpara = new SqlParameter(Schema.Learner.PARA_USER_ID, pEntContModTracking.UserID);
                sqlcmd.Parameters.Add(sqlpara);

                sqlreader = _sqlObject.SqlDataReader(sqlcmd, false);
                entContModTracking = FillObjectLearner(sqlreader, _sqlObject);
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                //throw _expCustom;
            }
            finally
            {
                if (sqlreader != null && !sqlreader.IsClosed) sqlreader.Close();
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) sqlConnection.Close();
            }
            return entContModTracking;
        }

        /// <summary>
        /// Get tracking after update
        /// </summary>
        /// <param name="pEntContModTracking"></param>
        /// <returns></returns>
        public ContentModuleTracking GetContentModuleTrackingAfterUpdate(ContentModuleTracking pEntContModTracking)
        {
            _sqlObject = new SQLObject();
            ContentModuleTracking entContModTracking = new ContentModuleTracking();
            SqlConnection sqlConnection = null;
            try
            {
                _strConnString = _sqlObject.GetClientDBConnString(pEntContModTracking.ClientId);
                sqlConnection = new SqlConnection(_strConnString);
                sqlcmd = new SqlCommand(Schema.ContentModuleTracking.PROC_GET_CONTENT_MODULE_TRACKING_UPDATE, sqlConnection);
                sqlpara = new SqlParameter(Schema.Common.PARA_ATTEMPT_ID, pEntContModTracking.ID);
                sqlcmd.Parameters.Add(sqlpara);

                sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_ID, pEntContModTracking.ContentModuleId);
                sqlcmd.Parameters.Add(sqlpara);

                sqlpara = new SqlParameter(Schema.Learner.PARA_USER_ID, pEntContModTracking.UserID);
                sqlcmd.Parameters.Add(sqlpara);

                sqlreader = _sqlObject.SqlDataReader(sqlcmd, false);
                entContModTracking = FillObject(sqlreader, _sqlObject);
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                //throw _expCustom;
            }
            finally
            {
                if (sqlreader != null && !sqlreader.IsClosed) sqlreader.Close();
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) sqlConnection.Close();
            }
            return entContModTracking;
        }

        /// <summary>
        ///  To Fill Content module tracking object properties valus from reader data 
        /// </summary>
        /// <param name="pReader"></param>
        /// <returns>ContentModuleTracking object</returns>
        private ContentModuleTracking FillObjectLearner(SqlDataReader pReader, SQLObject pSqlObject)
        {
            ContentModuleTracking entContModuleTracking = new ContentModuleTracking();
            int iIndex;
            if (pReader.HasRows)
            {
                while (pReader.Read())
                {
                    iIndex = pReader.GetOrdinal(Schema.Common.COL_ATTEMPT_ID);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.ID = pReader.GetString(iIndex);

                    iIndex = pReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_ID);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.ContentModuleId = pReader.GetString(iIndex);

                    iIndex = pReader.GetOrdinal(Schema.Learner.COL_USER_ID);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.UserID = pReader.GetString(iIndex);

                    iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_DATE_OF_START);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.DateOfStart = pReader.GetDateTime(iIndex);

                    iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_DATE_OF_COMPLETION);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.DateOfCompletion = pReader.GetDateTime(iIndex);                  

                    iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_COMPLETION_STATUS);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.CompletionStatus = (ActivityCompletionStatus)Enum.Parse(typeof(ActivityCompletionStatus), pReader.GetString(iIndex));
                   
                    iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_MARKED_COMPLETED_BY_ID);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.MarkedCompletedById = pReader.GetString(iIndex);                  
                }
            }
            return entContModuleTracking;
        }

        /// <summary>
        ///  To Fill Content module tracking object properties valus from reader data 
        /// </summary>
        /// <param name="pReader"></param>
        /// <returns>ContentModuleTracking object</returns>
        private ContentModuleTracking FillObjectUserDataXML(SqlDataReader pReader, SQLObject pSqlObject)
        {
            ContentModuleTracking entContModuleTracking = new ContentModuleTracking();
            int iIndex;
            if (pReader.HasRows)
            {
                while (pReader.Read())
                {
                    iIndex = pReader.GetOrdinal(Schema.Common.COL_ATTEMPT_ID);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.ID = pReader.GetString(iIndex);
                    
                    iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_USER_DATA_XML);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.UserDataXML = pReader.GetString(iIndex);
                }
            }
            return entContModuleTracking;
        }

        /// <summary>
        ///  To Fill Content module tracking object properties valus from reader data 
        /// </summary>
        /// <param name="pReader"></param>
        /// <returns>ContentModuleTracking object</returns>
        private ContentModuleTracking FillObject(SqlDataReader pReader, SQLObject pSqlObject)
        {
            ContentModuleTracking entContModuleTracking = new ContentModuleTracking();
            int iIndex;
            if (pReader.HasRows)
            {
                while (pReader.Read())
                {
                    iIndex = pReader.GetOrdinal(Schema.Common.COL_ATTEMPT_ID);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.ID = pReader.GetString(iIndex);

                    iIndex = pReader.GetOrdinal(Schema.ContentModule.COL_CONTENT_MODULE_ID);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.ContentModuleId = pReader.GetString(iIndex);

                    iIndex = pReader.GetOrdinal(Schema.Learner.COL_USER_ID);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.UserID = pReader.GetString(iIndex);

                    iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_DATE_OF_START);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.DateOfStart = pReader.GetDateTime(iIndex);

                    iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_DATE_OF_COMPLETION);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.DateOfCompletion = pReader.GetDateTime(iIndex);

                    iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_TOTAL_NO_OF_PAGES);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.TotalNoOfPages = pReader.GetInt32(iIndex);

                    iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_NO_OF_PAGES_COMPLETED);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.NoOfPagesCompleted = pReader.GetInt32(iIndex);

                    iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_COMPLETION_STATUS);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.CompletionStatus = (ActivityCompletionStatus)Enum.Parse(typeof(ActivityCompletionStatus), pReader.GetString(iIndex));

                    iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_USER_DATA_XML);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.UserDataXML = pReader.GetString(iIndex);

                    iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_SCORE);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.Score = pReader.GetString(iIndex);

                    iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_MARKED_COMPLETED_BY_ID);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.MarkedCompletedById = pReader.GetString(iIndex);

                    iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_SCANNED_CERTIFICATION_FILE_NAME);
                    if (!pReader.IsDBNull(iIndex))
                        entContModuleTracking.ScannedCertificationFileName = pReader.GetString(iIndex);

                    if (pSqlObject.ReaderHasColumn(pReader, Schema.ContentModuleTracking.COL_ACTIVITY_NAME))
                    {
                        iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_ACTIVITY_NAME);
                        if (!pReader.IsDBNull(iIndex))
                            entContModuleTracking.ActivityName = pReader.GetString(iIndex);
                    }
                    if (pSqlObject.ReaderHasColumn(pReader, Schema.ContentModuleTracking.COL_USER_FIRST_LAST_NAME))
                    {
                        iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_USER_FIRST_LAST_NAME);
                        if (!pReader.IsDBNull(iIndex))
                            entContModuleTracking.UserFirstLastName = pReader.GetString(iIndex);
                    }
                    if (pSqlObject.ReaderHasColumn(pReader, Schema.ContentModuleTracking.COL_REVIEWER_COMMENTS))
                    {
                        iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_REVIEWER_COMMENTS);
                        if (!pReader.IsDBNull(iIndex))
                            entContModuleTracking.ReviewComments = pReader.GetString(iIndex);
                    }
                    if (pSqlObject.ReaderHasColumn(pReader, Schema.ContentModuleTracking.COL_REGION_VIEW_INFO))
                    {
                        iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_REGION_VIEW_INFO);
                        if (!pReader.IsDBNull(iIndex))
                            entContModuleTracking.RegionViewInfo = pReader.GetString(iIndex);
                    }
                    if (pSqlObject.ReaderHasColumn(pReader, Schema.ContentModuleTracking.COL_IS_FOR_ADMIN_PREVIEW))
                    {
                        iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_IS_FOR_ADMIN_PREVIEW);
                        if (!pReader.IsDBNull(iIndex))
                            entContModuleTracking.IsForAdminPreview = pReader.GetBoolean(iIndex);
                    }

                    if (pSqlObject.ReaderHasColumn(pReader, Schema.ContentModuleTracking.COL_VENDORCODE))
                    {
                        iIndex = pReader.GetOrdinal(Schema.ContentModuleTracking.COL_VENDORCODE);
                        if (!pReader.IsDBNull(iIndex))
                            entContModuleTracking.VendorCode = pReader.GetString(iIndex);
                    }

                }
            }
            return entContModuleTracking;
        }

        /// <summary>
        /// To Add new content module tracking
        /// </summary>
        /// <param name="pEntContModTracking"></param>
        /// <returns>ContentModuleTracking object</returns>
        public ContentModuleTrackingUpdateResult AddContentModuleTracking(ContentModuleTracking pEntContModTracking)
        {
            ContentModuleTrackingUpdateResult result = null;
            try
            {
                result = Update(pEntContModTracking, Schema.Common.VAL_INSERT_MODE);
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                //throw _expCustom;
            }
            return result;
        }

        /// <summary>
        /// To Edit the content module tracking data 
        /// </summary>
        /// <param name="pEntContModTracking"></param>
        /// <returns>ContentModuleTracking object</returns>
        public ContentModuleTrackingUpdateResult EditContentModuleTracking(ContentModuleTracking pEntContModTracking)
        {
            ContentModuleTrackingUpdateResult result = new ContentModuleTrackingUpdateResult();
            try
            {
                result = Update(pEntContModTracking, Schema.Common.VAL_UPDATE_MODE);
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                //throw _expCustom;
            }
            return result;
        }

        /// <summary>
        /// To Edit the content module tracking data 
        /// </summary>
        /// <param name="pEntContModTracking"></param>
        /// <returns>ContentModuleTracking object</returns>
        public void GenerateLog(ContentModuleTracking pEntContModTracking)
        {
            ContentModuleTrackingUpdateResult result = new ContentModuleTrackingUpdateResult();
            try
            {
                fGenerateLog(pEntContModTracking);
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                //throw _expCustom;
            }
            
        }
        /// <summary>
        /// private method to support both Add and Edit content module tracking transactions.
        /// </summary>
        /// <param name="pEntContModTracking"></param>
        /// <param name="pUpdateMode"></param>
        /// <returns>ContentModuleTracking object</returns>
        private ContentModuleTrackingUpdateResult Update(ContentModuleTracking pEntContModTracking, string pStrUpdateMode)
        {
            _sqlObject = new SQLObject();
            sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = Schema.ContentModuleTracking.PROC_UPDATE_CONTENT_MODULE_TRACKING;
            _strConnString = _sqlObject.GetClientDBConnString(pEntContModTracking.ClientId);
            //if (pStrUpdateMode == Schema.Common.VAL_INSERT_MODE)
            //{
            //    sqlpara = new SqlParameter(Schema.Common.PARA_UPDATE_MODE, Schema.Common.VAL_INSERT_MODE);
            //}
            //else
            //    sqlpara = new SqlParameter(Schema.Common.PARA_UPDATE_MODE, Schema.Common.VAL_UPDATE_MODE);
            //sqlcmd.Parameters.Add(sqlpara);

            if (string.IsNullOrEmpty(pEntContModTracking.ID))
            {
                pEntContModTracking.ID = pEntContModTracking.LearnerId + IDGenerator.GetUniqueKey(16);
            }

            sqlpara = new SqlParameter(Schema.Common.PARA_CONTENTTRACKID, pEntContModTracking.ID);
            sqlcmd.Parameters.Add(sqlpara);

            sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_ID, pEntContModTracking.ContentModuleId);
            sqlcmd.Parameters.Add(sqlpara);

            //sqlpara = new SqlParameter(Schema.Common.PARA_IS_BULK_MARK_COMPLETED, pEntContModTracking.IsBulkMarkCompleted);
            //sqlcmd.Parameters.Add(sqlpara);

            sqlpara = new SqlParameter(Schema.Learner.PARA_LEARNERID, pEntContModTracking.UserID);
            sqlcmd.Parameters.Add(sqlpara);
            
            //if (!string.IsNullOrEmpty(pEntContModTracking.SessionId))
            //{
            //    sqlcmd.Parameters.Add(new SqlParameter(Schema.Learner.PARA_SESSION_ID, pEntContModTracking.SessionId));
            //}
            
            //sqlcmd.Parameters.Add(new SqlParameter(Schema.ContentModuleTracking.PARA_EXTEND_EXPIRATION_MINUTES, pEntContModTracking.ExtendExpirationMinutes));
            //sqlcmd.Parameters.Add(new SqlParameter(Schema.ContentModuleTracking.PARA_CHECK_EXPIRED_SESSION, pEntContModTracking.CheckExpiredSession));

            if (DateTime.MinValue.CompareTo(pEntContModTracking.DateOfStart) < 0)
                sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_DATE_OF_START, pEntContModTracking.DateOfStart);
            else
                sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_DATE_OF_START, null);
            sqlcmd.Parameters.Add(sqlpara);

            if (pEntContModTracking.DateOfCompletion != null)
                sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_DATE_OF_COMPLETION, pEntContModTracking.DateOfCompletion);
            else
                sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_DATE_OF_COMPLETION, null);
            sqlcmd.Parameters.Add(sqlpara);

            sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_TOTAL_NO_OF_PAGES, pEntContModTracking.TotalNoOfPages);
            sqlcmd.Parameters.Add(sqlpara);

            sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_NO_OF_PAGES_COMPLETED, pEntContModTracking.NoOfPagesCompleted);
            sqlcmd.Parameters.Add(sqlpara);

            sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_COMPLETION_STATUS, pEntContModTracking.CompletionStatus.ToString());
            sqlcmd.Parameters.Add(sqlpara);

            if (!string.IsNullOrEmpty(pEntContModTracking.Score))
                sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_SCORE, pEntContModTracking.Score);
            else
                sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_SCORE, null);
            sqlcmd.Parameters.Add(sqlpara);

            if (!string.IsNullOrEmpty(pEntContModTracking.UserDataXML))
                sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_USER_DATA_XML, pEntContModTracking.UserDataXML);
            else
                sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_USER_DATA_XML, null);
            sqlcmd.Parameters.Add(sqlpara);

            //if (!string.IsNullOrEmpty(pEntContModTracking.Score))
            //    sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_SCORE, pEntContModTracking.Score);
            //else
            //    sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_SCORE, null);
            //sqlcmd.Parameters.Add(sqlpara);

            //if (!string.IsNullOrEmpty(pEntContModTracking.MarkedCompletedById))
            //    sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_MARKED_COMPLETED_BY_ID, pEntContModTracking.MarkedCompletedById);
            //else
            //    sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_MARKED_COMPLETED_BY_ID, null);
            //sqlcmd.Parameters.Add(sqlpara);

            //if (!string.IsNullOrEmpty(pEntContModTracking.ScannedCertificationFileName))
            //    sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_SCANNED_CERTIFICATION_FILE_NAME, pEntContModTracking.ScannedCertificationFileName);
            //else
            //    sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_SCANNED_CERTIFICATION_FILE_NAME, null);
            //sqlcmd.Parameters.Add(sqlpara);

            //sqlcmd.Parameters.AddWithValue(Schema.ContentModuleTracking.PARA_ACTIVITY_NAME, null);
            //sqlcmd.Parameters.AddWithValue(Schema.ContentModuleTracking.PARA_USER_FIRST_LAST_NAME, null);
            //sqlcmd.Parameters.AddWithValue(Schema.ContentModuleTracking.PARA_REVIEWER_COMMENTS, pEntContModTracking.ReviewComments);
            //sqlcmd.Parameters.AddWithValue(Schema.ContentModuleTracking.PARA_REGION_VIEW_INFO, pEntContModTracking.RegionViewInfo);
            //sqlcmd.Parameters.AddWithValue(Schema.ContentModuleTracking.PARA_IS_FOR_ADMIN_PREVIEW, pEntContModTracking.IsForAdminPreview);

            ContentModuleTrackingUpdateResult result = null;

            using(SqlConnection conn = new SqlConnection(_strConnString))
            {
                conn.Open();

                sqlcmd.Connection = conn;
                
                using(var reader = sqlcmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();

                        result = new ContentModuleTrackingUpdateResult();

                        //reader.SetValueForColumn<string>("PreviousCompletionStatus", s => result.PreviousCompletionStatus = s);
                        //reader.SetValueForColumn<string>("CurrentCompletionStatus", s => result.CurrentCompletionStatus = s);
                        //reader.SetValueForColumn<string>("LearnerId", s => result.LearnerId = s);
                    }
                }
            }

            return result;
        }

        private void fGenerateLog(ContentModuleTracking pEntContModTracking)
        {
            _sqlObject = new SQLObject();
            sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = Schema.ContentModuleTracking.PROC_GENERATELOG;
            _strConnString = _sqlObject.GetClientDBConnString(pEntContModTracking.ClientId);

            sqlpara = new SqlParameter(Schema.ContentModule.PARA_CONTENT_MODULE_ID, pEntContModTracking.ContentModuleId);
            sqlcmd.Parameters.Add(sqlpara);

            sqlpara = new SqlParameter(Schema.Learner.PARA_LEARNERID, pEntContModTracking.UserID);
            sqlcmd.Parameters.Add(sqlpara);
            
            if (DateTime.MinValue.CompareTo(pEntContModTracking.DateOfStart) < 0)
                sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_DATE_OF_START, pEntContModTracking.DateOfStart);
            else
                sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_DATE_OF_START, null);
            sqlcmd.Parameters.Add(sqlpara);

            if (pEntContModTracking.DateOfCompletion != null)
                sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_DATE_OF_COMPLETION, pEntContModTracking.DateOfCompletion);
            else
                sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_DATE_OF_COMPLETION, null);
            sqlcmd.Parameters.Add(sqlpara);

            sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_TOTAL_NO_OF_PAGES, pEntContModTracking.TotalNoOfPages);
            sqlcmd.Parameters.Add(sqlpara);

            sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_NO_OF_PAGES_COMPLETED, pEntContModTracking.NoOfPagesCompleted);
            sqlcmd.Parameters.Add(sqlpara);

            sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_COMPLETION_STATUS, pEntContModTracking.CompletionStatus.ToString());
            sqlcmd.Parameters.Add(sqlpara);

            if (!string.IsNullOrEmpty(pEntContModTracking.Score))
                sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_SCORE, pEntContModTracking.Score);
            else
                sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_SCORE, null);
            sqlcmd.Parameters.Add(sqlpara);

            if (!string.IsNullOrEmpty(pEntContModTracking.UserDataXML))
                sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_USER_DATA_XML, pEntContModTracking.UserDataXML);
            else
                sqlpara = new SqlParameter(Schema.ContentModuleTracking.PARA_USER_DATA_XML, null);
            sqlcmd.Parameters.Add(sqlpara);

            using(SqlConnection conn = new SqlConnection(_strConnString))
            {
                conn.Open();

                sqlcmd.Connection = conn;
                sqlcmd.ExecuteNonQuery();

            }

        }
        public class ContentModuleTrackingUpdateResult
        {
            public string PreviousCompletionStatus { get; set; }
            public string CurrentCompletionStatus { get; set; }
            public string LearnerId { get; set; }
        }

        /// <summary>
        /// Bulk Update
        /// </summary>
        /// <param name="pEntListTracking"></param>
        /// <param name="pIsBulkMarkCompleted"></param>
        /// <returns></returns>
        public List<ContentModuleTracking> BulkUpdate(List<ContentModuleTracking> pEntListTracking, bool pIsBulkMarkCompleted)
        {
            _sqlObject = new SQLObject();
            List<ContentModuleTracking> entListTracking = new List<ContentModuleTracking>();           
            int iBatchSize = 0;
            SqlCommand _sqlcmd = null;
            SqlConnection _sqlcon = null;           
            SqlDataAdapter _sqladapter = null;
            try
            {
                if (pEntListTracking.Count > 0)
                {
                    _dtable = new DataTable();
                    _dtable.Columns.Add(Schema.ContentModuleTracking.COL_ATTEMPT_ID);
                    _dtable.Columns.Add(Schema.ContentModule.COL_CONTENT_MODULE_ID);
                    _dtable.Columns.Add(Schema.Learner.COL_USER_ID);
                    _dtable.Columns.Add(Schema.ContentModuleTracking.COL_DATE_OF_COMPLETION);
                    _dtable.Columns.Add(Schema.ContentModuleTracking.COL_MARKED_COMPLETED_BY_ID);
                    _dtable.Columns.Add(Schema.ContentModuleTracking.COL_COMPLETION_STATUS);
                    _dtable.Columns.Add(Schema.ContentModuleTracking.COL_REVIEWER_COMMENTS);
                    _dtable.Columns.Add(Schema.ContentModuleTracking.COL_SCANNED_CERTIFICATION_FILE_NAME);
                    _dtable.Columns.Add(Schema.Common.COL_IS_BULK_MARK_COMPLETED);

                    foreach ( ContentModuleTracking entAttempt in pEntListTracking)
                    {                     
                        DataRow drow = _dtable.NewRow();

                        if (String.IsNullOrEmpty(_strConnString))
                            _strConnString = _sqlObject.GetClientDBConnString(entAttempt.ClientId);
                        if (string.IsNullOrEmpty(entAttempt.ID))
                            entAttempt.ID = IDGenerator.GetStringGUID();

                        drow[Schema.ContentModuleTracking.COL_ATTEMPT_ID] = entAttempt.ID;
                        drow[Schema.ContentModule.COL_CONTENT_MODULE_ID] = entAttempt.ContentModuleId;
                        drow[Schema.Learner.COL_USER_ID] = entAttempt.UserID;
                        drow[Schema.ContentModuleTracking.COL_DATE_OF_COMPLETION] = entAttempt.DateOfCompletion;
                        drow[Schema.ContentModuleTracking.COL_MARKED_COMPLETED_BY_ID] = entAttempt.MarkedCompletedById;
                        drow[Schema.ContentModuleTracking.COL_COMPLETION_STATUS] = entAttempt.CompletionStatus.ToString();
                        drow[Schema.ContentModuleTracking.COL_REVIEWER_COMMENTS] = entAttempt.ReviewComments;
                        drow[Schema.ContentModuleTracking.COL_SCANNED_CERTIFICATION_FILE_NAME] = entAttempt.ScannedCertificationFileName;
                        drow[Schema.Common.COL_IS_BULK_MARK_COMPLETED] = entAttempt.IsBulkMarkCompleted;

                        iBatchSize = iBatchSize + 1;
                        _dtable.Rows.Add(drow);
                        entListTracking.Add(entAttempt);
                    }

                    if (_dtable.Rows.Count > 0)
                    {
                        _sqlcmd = new SqlCommand();
                        _sqlcmd.CommandText = Schema.ContentModuleTracking.PROC_UPDATE_MARK_COMPLETED;
                        _sqlcmd.CommandType = CommandType.StoredProcedure;
                        _sqlcon = new SqlConnection(_strConnString);
                        _sqlcmd.Connection = _sqlcon;

                        _sqlcmd.Parameters.Add(Schema.ContentModuleTracking.PARA_ATTEMPT_ID, SqlDbType.VarChar, 100, Schema.ContentModuleTracking.COL_ATTEMPT_ID);
                        _sqlcmd.Parameters.Add(Schema.ContentModule.PARA_CONTENT_MODULE_ID, SqlDbType.VarChar, 100, Schema.ContentModule.COL_CONTENT_MODULE_ID);
                        _sqlcmd.Parameters.Add(Schema.Learner.PARA_USER_ID, SqlDbType.VarChar, 100, Schema.Learner.COL_USER_ID);
                        _sqlcmd.Parameters.Add(Schema.ContentModuleTracking.PARA_COMPLETED_DATE, SqlDbType.DateTime, 20, Schema.ContentModuleTracking.COL_DATE_OF_COMPLETION);
                        _sqlcmd.Parameters.Add(Schema.ContentModuleTracking.PARA_MARKED_COMPLETED_BY_ID, SqlDbType.VarChar, 100, Schema.ContentModuleTracking.COL_MARKED_COMPLETED_BY_ID);
                        _sqlcmd.Parameters.Add(Schema.ContentModuleTracking.PARA_COMPLETION_STATUS, SqlDbType.NVarChar, 100, Schema.ContentModuleTracking.COL_COMPLETION_STATUS);
                        _sqlcmd.Parameters.Add(Schema.ContentModuleTracking.PARA_REVIEWER_COMMENTS, SqlDbType.NVarChar, 2000, Schema.ContentModuleTracking.COL_REVIEWER_COMMENTS);
                        _sqlcmd.Parameters.Add(Schema.ContentModuleTracking.PARA_SCANNED_CERTIFICATION_FILE_NAME, SqlDbType.VarChar, 500, Schema.ContentModuleTracking.COL_SCANNED_CERTIFICATION_FILE_NAME);
                        _sqlcmd.Parameters.Add(Schema.Common.PARA_IS_BULK_MARK_COMPLETED, SqlDbType.Bit, 1, Schema.Common.COL_IS_BULK_MARK_COMPLETED);

                        _sqladapter = new SqlDataAdapter();                        
                        _sqladapter.InsertCommand = _sqlcmd;
                        _sqladapter.InsertCommand.CommandTimeout = 0;
                        _sqladapter.InsertCommand.UpdatedRowSource = UpdateRowSource.None;
                        _sqladapter.UpdateBatchSize = iBatchSize;
                        _sqladapter.Update(_dtable);
                        _sqladapter.Dispose();
                    }
                }
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                //throw _expCustom;
            }

            return entListTracking;
        }

        /// <summary>
        /// To update FileName
        /// </summary>
        /// <param name="pEntContentModuleTracking"></param>        
        /// <returns>ContentModuleTracking object</returns>
        public ContentModuleTracking UpdateScannedFileName(ContentModuleTracking pEntContentModuleTracking)
        {
            _sqlObject = new SQLObject();
            sqlcmd = new SqlCommand();
            sqlcmd.CommandText = Schema.Common.PROC_UPDATE_SCANNED_FILE_NAME;
            try
            {
                _strConnString = _sqlObject.GetClientDBConnString(pEntContentModuleTracking.ClientId);
                if (!string.IsNullOrEmpty(pEntContentModuleTracking.ContentModuleId))
                {
                    sqlpara = new SqlParameter(Schema.Common.PARA_ACTIVITY_ID, pEntContentModuleTracking.ContentModuleId);
                    sqlcmd.Parameters.Add(sqlpara);
                }
                if (!string.IsNullOrEmpty(pEntContentModuleTracking.UserID))
                {
                    sqlpara = new SqlParameter(Schema.Common.PARA_SYSTEM_USER_GUID, pEntContentModuleTracking.UserID);
                    sqlcmd.Parameters.Add(sqlpara);
                }
                if (!string.IsNullOrEmpty(pEntContentModuleTracking.ScannedCertificationFileName))
                {
                    sqlpara = new SqlParameter(Schema.Common.PARA_SCANNED_FILE_NAME, pEntContentModuleTracking.ScannedCertificationFileName);
                    sqlcmd.Parameters.Add(sqlpara);
                }

                sqlpara = new SqlParameter(Schema.Common.PARA_ACTIVITY_TYPE, ActivityContentType.Course.ToString());
                sqlcmd.Parameters.Add(sqlpara);

                _sqlObject.ExecuteNonQuery(sqlcmd, _strConnString);
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                //throw _expCustom;
            }
            return pEntContentModuleTracking;
        }

        public ContentModuleTracking GetActivityStatus(ContentModuleTracking pEntActivityAssignment)
        {
            _sqlObject = new SQLObject();
            ContentModuleTracking entActivityAssignment = new ContentModuleTracking();
            SqlConnection sqlConnection = null;
            int iIndex;

            try
            {
                _strConnString = _sqlObject.GetClientDBConnString(pEntActivityAssignment.ClientId);
                sqlConnection = new SqlConnection(_strConnString);
                _sqlcmd = new SqlCommand(Schema.ActivityAssignment.PROC_GET_ACTIVITY_STATUS, sqlConnection);

                _sqlpara = new SqlParameter(Schema.ActivityAssignment.PARA_ACTIVITY_ID, pEntActivityAssignment.ContentModuleId);
                _sqlcmd.Parameters.Add(_sqlpara);

                _sqlpara = new SqlParameter(Schema.Learner.PARA_USER_ID, pEntActivityAssignment.UserID);
                _sqlcmd.Parameters.Add(_sqlpara);

                _sqlpara = new SqlParameter(Schema.ActivityAssignment.PARA_ACTIVITY_TYPE, ActivityContentType.Course.ToString());
                _sqlcmd.Parameters.Add(_sqlpara);

                _sqlreader = _sqlObject.SqlDataReader(_sqlcmd, false);
                _sqlreader.Read();

                if (_sqlreader.HasRows)
                {
                    iIndex = _sqlreader.GetOrdinal(Schema.ActivityAssignment.COL_ACTIVITY_STATUS);
                    if (!_sqlreader.IsDBNull(iIndex))
                    {
                        entActivityAssignment.CompletionStatus = (ActivityCompletionStatus)Enum.Parse(typeof(ActivityCompletionStatus), _sqlreader.GetString(iIndex));
                    }
                }

                // //return entActivityAssignment;
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                //throw _expCustom;
            }
            finally
            {
                if (_sqlreader != null && !_sqlreader.IsClosed) _sqlreader.Close();
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) sqlConnection.Close();
            }
            return entActivityAssignment;
        }

        #region Interface Methods
        /// <summary>
        /// Get By ID
        /// </summary>
        /// <param name="pEntContentModuleTracking"></param>
        /// <returns></returns>
        public ContentModuleTracking Get(ContentModuleTracking pEntContentModuleTracking)
        {
            return GetContentModuleTrackingByID(pEntContentModuleTracking);
        }
        /// <summary>
        /// Update ContentModuleTracking
        /// </summary>
        /// <param name="pEntContentModuleTracking"></param>
        /// <returns></returns>
        public ContentModuleTracking Update(ContentModuleTracking pEntContentModuleTracking)
        {
			EditContentModuleTracking(pEntContentModuleTracking);

            return pEntContentModuleTracking;
        }
        #endregion
    }
}