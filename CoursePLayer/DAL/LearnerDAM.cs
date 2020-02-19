
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;



namespace HRS.CoursePlayer
{
    /// <summary>
    /// class LearnerDAM
    /// </summary>
    public class LearnerDAM : IDataManager<Learner>
    {
        #region Global Declaration
        string _strConnString = string.Empty;
        //CustomException _expCustom;
        SqlCommand _sqlcmd = null;
        SqlParameter _sqlpara;
        SqlDataReader _sqlreader = null;
        SqlConnection _sqlcon = null;
        Learner _entLearner = null;
        List<Learner> _entListLearner = null;
        EntityRange _entRange = null;
        DataSet _dset = null;
        //UserAdminRole entUserAdminRole = null;
        string _strMessageId = "LEARNER_ERROR";
        static int iRecordsUpdated = 0;
        SQLObject _sqlObject = null;

        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        public LearnerDAM()
        {
        }
        /// <summary>
        /// To get user details by user id.
        /// </summary>
        /// <param name="pEntLearner"></param>
        /// <returns>Learner</returns>
        public Learner GetUserByID(Learner pEntLearner)
        {
            SqlConnection sqlConnection = null;
            _sqlcmd = new SqlCommand();
            _sqlcmd.CommandText = Schema.Learner.PROC_GET_USER;
            _sqlObject = new SQLObject();
            if (!String.IsNullOrEmpty(pEntLearner.ID))
                _sqlpara = new SqlParameter(Schema.Learner.PARA_USER_ID, pEntLearner.ID.ToString());
            else
                _sqlpara = new SqlParameter(Schema.Learner.PARA_USER_ID, null);
            _sqlcmd.Parameters.Add(_sqlpara);
            try
            {
                _strConnString = _sqlObject.GetClientDBConnString(pEntLearner.ClientId);
                sqlConnection = new SqlConnection(_strConnString);
                _sqlcmd.Connection = sqlConnection;
                _sqlreader = _sqlObject.SqlDataReader(_sqlcmd, false);
                _sqlreader.Read();
                _entLearner = FillUserObject(_sqlreader, false, _sqlObject);
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;
            }
            finally
            {
                if (_sqlreader != null && !_sqlreader.IsClosed) _sqlreader.Close();
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                    sqlConnection.Close();
            }
            return _entLearner;
        }

        /// <summary>
        /// This method does not Fill Child List
        /// </summary>
        /// <param name="pSqlReader"></param>
        /// <returns>Learner</returns>
        public Learner FillUserObject(SqlDataReader pSqlReader, bool pRangeList, SQLObject pSqlObject)
        {
            _entLearner = new Learner();
            //UserCustomFieldValue entUserCustomFieldValue;
            int index;
            if (pSqlReader.HasRows)
            {
                index = pSqlReader.GetOrdinal(Schema.Learner.COL_USER_ID);
                if (!pSqlReader.IsDBNull(index))
                    _entLearner.ID = pSqlReader.GetString(index);

                index = pSqlReader.GetOrdinal(Schema.Learner.COL_FIRST_NAME);
                if (!pSqlReader.IsDBNull(index))
                    _entLearner.FirstName = pSqlReader.GetString(index);
                else
                    _entLearner.FirstName = "";

                index = pSqlReader.GetOrdinal(Schema.Learner.COL_MIDDLE_NAME);
                if (!pSqlReader.IsDBNull(index))
                    _entLearner.MiddleName = pSqlReader.GetString(index);

                if (string.IsNullOrEmpty(_entLearner.MiddleName))
                    _entLearner.MiddleName = "";

                index = pSqlReader.GetOrdinal(Schema.Learner.COL_LAST_NAME);
                if (!pSqlReader.IsDBNull(index))
                    _entLearner.LastName = pSqlReader.GetString(index);
                else
                    _entLearner.LastName = "";

                index = pSqlReader.GetOrdinal(Schema.Learner.COL_EMAIL_ID);
                if (!pSqlReader.IsDBNull(index))
                    _entLearner.Email = pSqlReader.GetString(index);

                if (string.IsNullOrEmpty(_entLearner.Email))
                    _entLearner.Email = "";

               


                //if (pSqlObject.ReaderHasColumn(pSqlReader, Schema.Learner.COL_PHONE_NO))
                //{
                //    index = pSqlReader.GetOrdinal(Schema.Learner.COL_PHONE_NO);
                //    if (!pSqlReader.IsDBNull(index))
                //        _entLearner.PhoneNo = pSqlReader.GetString(index);
                //}

                index = pSqlReader.GetOrdinal(Schema.Learner.COL_USER_NAME_ALIAS);
                if (!pSqlReader.IsDBNull(index))
                    _entLearner.UserName = pSqlReader.GetString(index);
                else
                    _entLearner.UserName= "";

                index = pSqlReader.GetOrdinal(Schema.Learner.COL_USER_PASSWORD);
                if (!pSqlReader.IsDBNull(index))
                {
                    _entLearner.Password = pSqlReader.GetString(index);
                    _entLearner.Password = EncryptionManager.Decrypt(_entLearner.Password);
                }
                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_ADDRESS);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.Address = pSqlReader.GetString(index);

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_DATE_OF_BIRTH);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.DateOfBirth = pSqlReader.GetDateTime(index);

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_DATE_OF_REGISTRATION);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.DateOfRegistration = pSqlReader.GetDateTime(index);

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_DATE_OF_TERMINATION);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.DateOfTermination = pSqlReader.GetDateTime(index);

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_USER_TYPE_ID);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.UserTypeId = pSqlReader.GetString(index);
                //else
                //    _entLearner.UserTypeId = "";

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_DEFAULT_LANGUAGE_ID);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.DefaultLanguageId = pSqlReader.GetString(index);

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_DEFAULT_THEME_ID);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.DefaultThemeID = pSqlReader.GetString(index);

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_GENDER);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.Gender = pSqlReader.GetBoolean(index);

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_MANAGER_ID);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.ManagerId = pSqlReader.GetString(index);

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_MANAGER_EMAIL);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.ManagerEmailId = pSqlReader.GetString(index);


                //if (pSqlObject.ReaderHasColumn(pSqlReader, Schema.Learner.COL_MANAGER_NAME))
                //{
                //    index = pSqlReader.GetOrdinal(Schema.Learner.COL_MANAGER_NAME);
                //    if (!pSqlReader.IsDBNull(index))
                //        _entLearner.ManagerName = pSqlReader.GetString(index);
                //}

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_DATE_LAST_LOGIN);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.DateLastLogin = pSqlReader.GetDateTime(index);

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_IS_ACTIVE);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.IsActive = pSqlReader.GetBoolean(index);

                index = pSqlReader.GetOrdinal(Schema.Client.COL_CLIENT_ID);
                if (!pSqlReader.IsDBNull(index))
                    _entLearner.ClientId = pSqlReader.GetString(index);

                index = pSqlReader.GetOrdinal(Schema.Common.COL_CREATED_BY);
                if (!pSqlReader.IsDBNull(index))
                    _entLearner.CreatedById = pSqlReader.GetString(index);

                index = pSqlReader.GetOrdinal(Schema.Common.COL_CREATED_ON);
                if (!pSqlReader.IsDBNull(index))
                    _entLearner.DateCreated = pSqlReader.GetDateTime(index);

                index = pSqlReader.GetOrdinal(Schema.Common.COL_MODIFIED_BY);
                if (!pSqlReader.IsDBNull(index))
                    _entLearner.LastModifiedById = pSqlReader.GetString(index);

                index = pSqlReader.GetOrdinal(Schema.Common.COL_MODIFIED_ON);
                if (!pSqlReader.IsDBNull(index))
                    _entLearner.LastModifiedDate = pSqlReader.GetDateTime(index);


                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_UNIT_ID);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.UnitId = pSqlReader.GetString(index);

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_LEVEL_ID);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.LevelId = pSqlReader.GetString(index);

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_DEFAULT_RV);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.DefaultRegionView = pSqlReader.GetString(index);

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_CURRENT_RV);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.CurrentRegionView = pSqlReader.GetString(index);

                //if (pSqlObject.ReaderHasColumn(pSqlReader, Schema.Learner.COL_IS_FIRST_LOGIN))
                //{
                //    index = pSqlReader.GetOrdinal(Schema.Learner.COL_IS_FIRST_LOGIN);
                //    if (!pSqlReader.IsDBNull(index))
                //        _entLearner.IsFirstLogin = pSqlReader.GetBoolean(index);
                //}
                //if (pSqlObject.ReaderHasColumn(pSqlReader, Schema.Learner.COL_IS_PASSWORD_EXPIRED))
                //{
                //    index = pSqlReader.GetOrdinal(Schema.Learner.COL_IS_PASSWORD_EXPIRED);
                //    if (!pSqlReader.IsDBNull(index))
                //        _entLearner.IsPasswordExpired = pSqlReader.GetBoolean(index);
                //}
                //if (pSqlObject.ReaderHasColumn(pSqlReader, Schema.Learner.COL_USER_SCOPE))
                //{
                //    index = pSqlReader.GetOrdinal(Schema.Learner.COL_USER_SCOPE);
                //    if (!pSqlReader.IsDBNull(index))
                //        _entLearner.UserScope = pSqlReader.GetString(index);
                //}
                //if (pSqlObject.ReaderHasColumn(pSqlReader, Schema.Learner.COL_USER_DEFAULT_ORG))
                //{
                //    index = pSqlReader.GetOrdinal(Schema.Learner.COL_USER_DEFAULT_ORG);
                //    if (!pSqlReader.IsDBNull(index))
                //        _entLearner.UserDefaultOrg = pSqlReader.GetString(index);
                //}

                //if (pSqlObject.ReaderHasColumn(pSqlReader, Schema.Learner.COL_UserExpiryDate))
                //{
                //    index = pSqlReader.GetOrdinal(Schema.Learner.COL_UserExpiryDate);
                //    if (!pSqlReader.IsDBNull(index))
                //        _entLearner.userExpiryDate = pSqlReader.GetDateTime(index);
                //}

                if (pRangeList)
                {
                    _entRange = new EntityRange();
                    index = pSqlReader.GetOrdinal(Schema.Common.COL_TOTAL_COUNT);
                    if (!pSqlReader.IsDBNull(index))
                        _entRange.TotalRows = pSqlReader.GetInt32(index);
                    _entLearner.ListRange = _entRange;
                    return _entLearner;
                }
                // Below code to retrieve the list of current user roles.
                //pSqlReader.NextResult();

                //while (pSqlReader.Read())
                //{
                //    entUserAdminRole = new UserAdminRole();

                //    //User Id
                //    index = pSqlReader.GetOrdinal(Schema.Learner.COL_USER_ID);
                //    if (!pSqlReader.IsDBNull(index))
                //        entUserAdminRole.ID = pSqlReader.GetString(index);

                //    //Role Id
                //    index = pSqlReader.GetOrdinal(Schema.AdminRole.COL_ROLE_ID);
                //    if (!pSqlReader.IsDBNull(index))
                //        entUserAdminRole.RoleId = pSqlReader.GetString(index);
                //    //Level Id
                //    index = pSqlReader.GetOrdinal(Schema.Learner.COL_LEVEL_ID);
                //    if (!pSqlReader.IsDBNull(index))
                //        entUserAdminRole.LevelId = pSqlReader.GetString(index);

                //    //Unit Id
                //    index = pSqlReader.GetOrdinal(Schema.Learner.COL_UNIT_ID);
                //    if (!pSqlReader.IsDBNull(index))
                //        entUserAdminRole.UnitId = pSqlReader.GetString(index);

                //    //Unit Id
                //    index = pSqlReader.GetOrdinal(Schema.CustomGroup.COL_CSG_ID);
                //    if (!pSqlReader.IsDBNull(index))
                //        entUserAdminRole.CustomGroupId = pSqlReader.GetString(index);

                //    if (pSqlObject.ReaderHasColumn(pSqlReader, Schema.RuleRoleScope.COL_RULE_ID))
                //    {
                //        index = pSqlReader.GetOrdinal(Schema.RuleRoleScope.COL_RULE_ID);
                //        if (!pSqlReader.IsDBNull(index))
                //            entUserAdminRole.RuleId = pSqlReader.GetString(index);
                //    }

                //    //Admin Role Type
                //    index = pSqlReader.GetOrdinal(Schema.AdminRole.COL_ROLE_TYPE);
                //    if (!pSqlReader.IsDBNull(index))
                //        entUserAdminRole.AdminRoleType = (RoleType)Enum.Parse(typeof(RoleType), pSqlReader.GetString(index));


                //    //Role Is Active
                //    index = pSqlReader.GetOrdinal(Schema.AdminRole.COL_IS_ACTIVE);
                //    if (!pSqlReader.IsDBNull(index))
                //        entUserAdminRole.IsRoleActive = pSqlReader.GetBoolean(index);

                //    _entLearner.UserAdminRole.Add(entUserAdminRole);
                //}

                //pSqlReader.NextResult();

                //while (pSqlReader.Read())
                //{
                //    entUserCustomFieldValue = new UserCustomFieldValue();

                //    index = pSqlReader.GetOrdinal(Schema.UserCustomFieldValue.COL_CUSTOM_FIELD_ITEM_ID);
                //    if (!pSqlReader.IsDBNull(index))
                //        entUserCustomFieldValue.CustomFieldItemId = pSqlReader.GetString(index);

                //    index = pSqlReader.GetOrdinal(Schema.Learner.COL_USER_ID);
                //    if (!pSqlReader.IsDBNull(index))
                //        entUserCustomFieldValue.SystemUserGUID = pSqlReader.GetString(index);

                //    entUserCustomFieldValue.ID = entUserCustomFieldValue.CustomFieldItemId + entUserCustomFieldValue.SystemUserGUID;

                //    index = pSqlReader.GetOrdinal(Schema.UserCustomFieldValue.COL_ENTERED_VALUE);
                //    if (!pSqlReader.IsDBNull(index))
                //        entUserCustomFieldValue.EnteredValue = pSqlReader.GetString(index);

                //    index = pSqlReader.GetOrdinal(Schema.Common.COL_CREATED_BY);
                //    if (!pSqlReader.IsDBNull(index))
                //        entUserCustomFieldValue.CreatedById = pSqlReader.GetString(index);

                //    index = pSqlReader.GetOrdinal(Schema.Common.COL_CREATED_ON);
                //    if (!pSqlReader.IsDBNull(index))
                //        entUserCustomFieldValue.DateCreated = pSqlReader.GetDateTime(index);

                //    index = pSqlReader.GetOrdinal(Schema.Common.COL_MODIFIED_BY);
                //    if (!pSqlReader.IsDBNull(index))
                //        entUserCustomFieldValue.LastModifiedById = pSqlReader.GetString(index);

                //    index = pSqlReader.GetOrdinal(Schema.Common.COL_MODIFIED_ON);
                //    if (!pSqlReader.IsDBNull(index))
                //        entUserCustomFieldValue.LastModifiedDate = pSqlReader.GetDateTime(index);

                //    index = pSqlReader.GetOrdinal(Schema.CustomField.COL_CUSTOM_FIELD_ID);
                //    if (!pSqlReader.IsDBNull(index))
                //        entUserCustomFieldValue.CustomFieldId = pSqlReader.GetString(index);

                //    _entLearner.UserCustomFieldValue.Add(entUserCustomFieldValue);
                //}
            }
            return _entLearner;
        }
        /// <summary>
        /// To get user details by user id.
        /// </summary>
        /// <param name="pEntLearner"></param>
        /// <returns>Learner</returns>
        public Learner GetUserByID_CoursePlayer(Learner pEntLearner)
        {
            SqlConnection sqlConnection = null;
            _sqlcmd = new SqlCommand();
            _sqlcmd.CommandText = Schema.Learner.PROC_GET_USER_COURSE_PLAYER;
            _sqlObject = new SQLObject();
            if (!String.IsNullOrEmpty(pEntLearner.ID))
                _sqlpara = new SqlParameter(Schema.Learner.PARA_USER_ID, pEntLearner.ID.ToString());
            else
                _sqlpara = new SqlParameter(Schema.Learner.PARA_USER_ID, null);
            _sqlcmd.Parameters.Add(_sqlpara);
            try
            {
                _strConnString = _sqlObject.GetMasterDBConnString();
                sqlConnection = new SqlConnection(_strConnString);
                _sqlcmd.Connection = sqlConnection;
                _sqlreader = _sqlObject.SqlDataReader(_sqlcmd, false);
                _sqlreader.Read();
                _entLearner = FillUserObject_CoursePlayer(_sqlreader);
            }
            catch (Exception expCommon)
            {
                //_expCustom = new CustomException(_strMessageId, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, expCommon, true);
                throw expCommon;
            }
            finally
            {
                if (_sqlreader != null && !_sqlreader.IsClosed) _sqlreader.Close();
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                    sqlConnection.Close();
            }
            return _entLearner;
        }
        public Learner FillUserObject_CoursePlayer(SqlDataReader pSqlReader)
        {
            _entLearner = new Learner();
            int index;
            if (pSqlReader.HasRows)
            {
                if (_sqlObject.ReaderHasColumn(pSqlReader, Schema.Learner.COL_USER_ID))
                {
                    index = pSqlReader.GetOrdinal(Schema.Learner.COL_USER_ID);
                    if (!pSqlReader.IsDBNull(index))
                        _entLearner.ID = pSqlReader.GetString(index);
                }

                if (_sqlObject.ReaderHasColumn(pSqlReader, Schema.Learner.COL_LEARNERID))
                {
                    index = pSqlReader.GetOrdinal(Schema.Learner.COL_LEARNERID);
                    if (!pSqlReader.IsDBNull(index))
                        _entLearner.LearnerId = pSqlReader.GetString(index);
                }

                index = pSqlReader.GetOrdinal(Schema.Learner.COL_FIRST_NAME);
                if (!pSqlReader.IsDBNull(index))
                    _entLearner.FirstName = pSqlReader.GetString(index);
                else
                    _entLearner.FirstName = "";

                index = pSqlReader.GetOrdinal(Schema.Learner.COL_LAST_NAME);
                if (!pSqlReader.IsDBNull(index))
                    _entLearner.LastName = pSqlReader.GetString(index);
                else
                    _entLearner.LastName = "";

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_USER_NAME_ALIAS);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.UserName = pSqlReader.GetString(index);
                //else
                //    _entLearner.UserName = "";

                ////index = pSqlReader.GetOrdinal(Schema.Learner.COL_USER_MANAGEREMAIL);
                ////if (!pSqlReader.IsDBNull(index))
                ////    _entLearner.ManagerEmailId = pSqlReader.GetString(index);
                ////else
                ////    _entLearner.ManagerEmailId = "";

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_USER_STUDENTEMAIL);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.Email = pSqlReader.GetString(index);
                //else
                //    _entLearner.Email = "";

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_DEFAULT_LANGUAGE_ID);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.DefaultLanguageId = pSqlReader.GetString(index);

                //index = pSqlReader.GetOrdinal(Schema.Client.COL_CLIENT_ID);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.ClientId = pSqlReader.GetString(index);

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_DEFAULT_RV);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.DefaultRegionView = pSqlReader.GetString(index);

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_CURRENT_RV);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.CurrentRegionView = pSqlReader.GetString(index);

                //index = pSqlReader.GetOrdinal(Schema.Learner.COL_RV_NAME);
                //if (!pSqlReader.IsDBNull(index))
                //    _entLearner.RegionViewName = pSqlReader.GetString(index);
                //else
                //    _entLearner.RegionViewName = String.Empty;

                //if (_sqlObject.ReaderHasColumn(pSqlReader, Schema.Learner.COL_AV_PATH))
                //{
                //    index = pSqlReader.GetOrdinal(Schema.Learner.COL_AV_PATH);
                //    if (!pSqlReader.IsDBNull(index))
                //        _entLearner.AvPath = pSqlReader.GetString(index);
                //    else
                //        _entLearner.AvPath = String.Empty;
                //}
            }
            return _entLearner;
        }

        #region Interface Methods
        /// <summary>
        /// Get By ID
        /// </summary>
        /// <param name="pEntLearner"></param>
        /// <returns></returns>
        public Learner Get(Learner pEntLearner)
        {
            return GetUserByID(pEntLearner);
        }

        
        /// <summary>
        /// Update Learner
        /// </summary>
        /// <param name="pEntLearner"></param>
        /// <returns></returns>
        public Learner Update(Learner pEntLearner)
        {
            Learner o = new Learner();
            return o;//UpdateUser(pEntLearner,false);
        }
        #endregion

    }

}
