
namespace HRS.CoursePlayer.Schema
{
    #region AppSettings

    /// <summary>
    /// AppSettings constants
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// APP SET MASTERDB CONN
        /// </summary>
       
    }
    #endregion

    public class StandardReportSP
    {
        public const string DETAILED_CERTIFICATION_USER_RESPONSES = "sproc_Report_DetailedCertificationUserResponses";
        public const string DETAILED_CERTIFICATION_USER_RESPONSES_FOR_PDF = "sproc_GetCertificationResponse_ForPDF";
        public const string DETAILED_CERTIFICATION_RESULTS_BY_USER = "sproc_Report_DetailedCertificationResultsbyUser";
        public const string DETAILED_CERTIFICATION_GET_QUESTIONNAIRE_RESPONSE_TYPE = "sproc_GetCeertQuestionnaireResponseType";
        public const string USER_NON_PREFERRED_ANSWERS_FOR_CERTIFICATION = "sproc_Report_UserNonpreferredAnswersForCertification";
        public const string NON_PREFERRED_ANSWERS_FOR_CERTIFICATION = "sproc_Report_NonpreferredAnswersForCertification";
        public const string AGGREGATE_RESULTS_BY_QUESTION = "sproc_Report_AggregateResultsByQuestion";
        public const string ACTIVITY_COMPLETION_PROGRESS = "sproc_Report_ActivityCompletionProgress";
        public const string LEARNER_DUMP = "sproc_Report_LearnerDumpReport";
        public const string LEARNER_LIST_BY_ORG_GROUP = "sproc_Report_LearnerListByOrgGroup";
        public const string ASSIGNED_USERS_BY_ACTIVITY_STATUS = "sproc_Report_AssignedUsersByActivityStatus";
        public const string ASSIGNED_USERS_BY_ACTIVITY_STATUS_NEW = "sproc_Report_AssignedUsersByActivityStatus";
        public const string USERS_BY_ROLE = "sproc_Report_UsersByRole";
        public const string NOT_ASSIGNED_USERS_BY_ACTIVITY = "sproc_Report_NotAssignedUsersByActivity";
        public const string DELINQUENCY_HISTORY = "sproc_Report_DelinquencyHistory";
        public const string COURSE_LICENSING_BY_COURSE = "sproc_Report_CourseLicensingbyCourse";
        public const string COURSE_LICENSING_BY_CLIENT_ENROLLMENT_CONSUMED = "sproc_Report_CourseLicensingbyClientEnrollmentConsumed";
        public const string COURSE_LICENSING_BY_CLIENT_ENROLLMENT_BASIS = "sproc_Report_CourseLicensingbyClientEnrollmentBasis";
        public const string COURSE_LICENSING_BY_CLIENT_SUBSCRIPTION_BASIS = "sproc_Report_CourseLicensingbyClientSubScriptionBasis";
        public const string SYSTEM_ERROR_LOG = "sproc_Report_SystemErrorLog";
        public const string CLIENT_CONTACT = "sproc_Report_ClientContact";
        public const string CLIENT_CONTACT_ADMIN_HOME = "sproc_Report_ClientContact_AdminHome";
        public const string CLIENT_SUMMARY = "sproc_Report_ClientSummary";
        public const string COURSE_LIBRARY = "sproc_Report_CourseLibrary";

        public const string CLIENT_EXPIRES_WITHIN_MONTH = "sproc_GetClientList_ExpiresIWithinMonth";
        public const string CLIENT_EXPIRES_WITHIN_MONTH_ADMIN_HOME = "sproc_GetClientList_ExpiresIWithinMonth_AdminHome";
        //-- Dashboard
        public const string PROC_DASHBOARD_STATISTICS = "sproc_Dashboard_GetTotalStatistics";
        public const string PROC_COURSE_ASSIGNMENT_DASHBOARD = "sproc_CourseAssignment_Dashboard";
        public const string PROC_COURSE_ASSIGNMENT_DASHBOARD_ADMIN_HOME = "sproc_CourseAssignment_Dashboard_AdminHome";
        public const string PROC_CERTIFICATION_ASSIGNMENT_DASHBOARD = "sproc_CertificationAssignment_Dashboard";
        public const string PROC_CERTIFICATION_ASSIGNMENT_DASHBOARD_ADMIN_HOME = "sproc_CertificationAssignment_Dashboard_AdminHome";
        public const string PROC_CURRICULUM_ASSIGNMENT_DASHBOARD = "sproc_CurriculumAssignment_Dashboard";
        public const string PROC_CURRICULUM_ASSIGNMENT_DASHBOARD_ADMIN_HOME = "sproc_CurriculumAssignment_Dashboard_AdminHome";
        public const string PROC_USER_ASSIGNMENTS_FOR_MARK = "sproc_UserAssignments_MarkCompleted";
        public const string PROC_USER_ASSIGNMENTS_FOR_MARK_CALENDAR = "sproc_UserAssignments_CalenderWP";
        public const string PROC_GET_USER_CERTIFICATION_RESPONSES = "sproc_UserAssignments_Certification_SearchResponses";
        public const string PROC_GET_CLIENT_SUMMARY_DASHBOARD = "sproc_Dashboard_ClientSummary";
        public const string PROC_GET_CLIENT_SUMMARY_DASHBOARD_ADMIN_HOME = "sproc_Dashboard_ClientSummary_AdminHome";

        public const string PROC_ACTIVITY_COMPLETION_CHART = "sproc_Report_ActivityCompletionProgress_Sel_ForChart";
        public const string PROC_ACTIVITY_COMPLETION_CHART_MULTIPLE = "sproc_Report_ActivityCompletionProgress_Graph_Multiple";

        public const string PROC_REPORTING_TOOL_RUN = "sproc_ReportingTool_Run";
        public const string PROC_REPORTING_TOOL_RUN_WITH_WHERE = "sproc_ReportingTool_Run_Search";
        public const string PROC_REPORTING_TOOL_GROUP_BY = "sproc_ReportingTool_Run_Search_GroupBy";
        public const string PROC_REPORTING_TOOL_GROUP_DTLS = "sproc_ReportingTool_Run_Search_GroupByDetails";
        public const string PROC_QUESTIONNAIRE_RESPONSE = "sproc_GetQuestionnaireResponse";
        public const string PROC_ASSESSMENT_RESPONSE = "sproc_GetAssessmentResponse";
        public const string PROC_CERTIFICATION_QUEST_RESPONSE = "sproc_GetCertQuestionnaireResponse";
        public const string PROC_MARKCOMPLETE_BY_USER = "[sproc_UserAssignments_MarkCompleted_By_USer]";

        public const string PROC_USER_ACTIVITY_ASSIGNMENT_NOTCOMPLETED_MAINPAGE = "sproc_UserActivityAssignment_sel_ByLearner_NotCompleted_MainPage";
        public const string PROC_USER_ACTIVITY_ASSIGNMENT_NOTCOMPLETED_DASHBOARD = "sproc_UserActivityAssignment_sel_ByLearner_NotCompleted_Dashboard";
        public const string PROC_USER_ACTIVITY_ASSIGNMENT_COMPLETED_MAINPAGE = "sproc_UserActivityAssignment_sel_ByLearner_Completed_MainPage";
        public const string PROC_USER_ACTIVITY_ASSIGNMENT_COMPLETED_DASHBOARD = "sproc_UserActivityAssignment_sel_ByLearner_Completed_Dashboard";
        public const string PROC_CURRICULUM_ACTIVITY_LSTALL_LEARNER = "sproc_CurriculumActivity_LstAll_Learner";
        public const string PROC_CERTIFICATION_ACTIVITY_LSTALL_LEARNER = "sproc_CertificationActivity_LstAll_Learner";
        public const string PROC_SHOW_ACTIVITY_ASSIGNED_LEARNER = "sproc_UserAssignments_DashBoardView";
        public const string PROC_LOOKUP_VALUE_LSTALL = "sproc_LookupValue_LstAll";
        public const string PROC_GET_ALL_FREE_FORM_TEXT = "sproc_Report_AggregateResultsByQuestion_FreeformResponses";

        public const string PROC_ASSESSMENT_INDIVIDUAL_RESULT = "sproc_AssessmentIndividualResultByQuestion_Main_rpt";
        public const string PROC_ASSESSMENT_INDIVIDUAL_RESULT_BY_QUESTION = "sproc_AssessmentIndividualResultByQuestion_rpt";
        public const string PROC_ASSESSMENT_COMPLETION = "sproc_AssessmentCompletionReport_rpt";
        public const string PROC_ASSESSMENT_INPROGRESS = "sproc_AssessmentInProgressReport_rpt";
        public const string PROC_AGGREGATE_RESULT_BY_ASSESSMENT = "sproc_AggregateResultByAssessment_rpt";
        public const string PROC_AGGREGATE_RESULT_BY_ASSESSMENT_USERS = "sproc_AggregateResultByAssessmentUsers_rpt";

        public const string PROC_GET_ALL_SESSIONMASTER = "sproc_SessionMaster_LstAll";
        public const string PROC_GET_ALL_SESSIONMASTER_Nomination = "sproc_SessionMaster_LstAll_Nomination";
        public const string PROC_GET_SESSIONMASTER = "sproc_SessionMaster_Sel";
        public const string PROC_GET_ALL_USERSESSIONREGISTRATION = "sproc_UserSessionRegistration_LstAll";

        public const string PROC_GET_ALL_ORDERHISTORY = "sproc_OrderHistoryReport_rpt";
        public const string PROC_GET_ALL_COURSE_ASSESMENT_RESULT = "sproc_UserAssessmentQuestions_LstAll";

        public const string PROC_QUESTIONNAIRE_INDIVIDUAL_RESULT = "sproc_Report_QuestionnaireIndividualResult";
        public const string PROC_QUESTIONNAIRE_COMPLETION = "sproc_Report_QuestionnaireCompletionReport";
        public const string PROC_QUESTIONNAIRE_INPROGRESS = "sproc_Report_QuestionnaireInProgressReport";
        public const string PROC_QUESTIONNAIRE_INDIVIDUAL_RESULT_BY_QUESTION = "sproc_Report_QuestionnnaireIndividualResultByQuestion";
        public const string PROC_AGGREGATE_RESULT_BY_QUESTIONNAIRE = "sproc_Report_QuestionnaireAggregateResult";
        public const string PROC_AGGREGATE_RESULT_BY_QUESTIONNAIRE_USERS = "sproc_Report_QuestionnaireAggregateResultByUsers";
        public const string DETAILED_QUESTIONNAIRE_GET_QUESTION_RESPONSE_TYPE = "sproc_GetQuestionnaireQuestResponseType";
        public const string DETAILED_QUESTIONNAIRE_USER_RESPONSES_FOR_PDF = "sproc_GetQuestionnaireResponse_ForPDF";
        public const string PROC_QUESTIONNAIRE_QUEST_RESPONSE = "sproc_GetQuestionnaireQuestionResponse";
        public const string PROC_DETAILED_QUESTIONNAIRE_RESULTS_BY_USER = "sproc_Report_DetailedQuestionnaireResultsbyUser";
        public const string PROC_VIRTUALTRAINING_STATUS = "sproc_VirtualTrainingStatusReport";
        public const string PROC_VirtualTrainingAttendeeResult = "sproc_VirtualTrainingSessionAttendeeReport";
    }

    #region Client
    /// <summary>
    /// Constants for Client object
    /// </summary>
    public class Client
    {
        public const string VAL_CLIENT_DB_NAME_PREFIX = "LMS";

        //PROCEDURES 
        /// <summary>
        /// procedure to get client details
        /// </summary>  
        /// 
        public const string PROC_GET_CLIENT_ACCESS_URL = "sproc_GetClientAccessURL";
        public const string PROC_GET_CLIENT_MASTER_ID = "sproc_GetClientDtls_ByClientID";
        public const string PROC_GET_CLIENT_MASTER_ID_BY_URL = "sproc_GetClientDtls_ByURL_GetId";
        public const string PROC_GET_CLIENT_MASTER_FEED_BACK_EMAIL = "sproc_ClientMaster_sel_FeedBackEmail";
        public const string PROC_GET_CLIENT_MASTER_ID_BY_NAME = "sproc_ClientMaster_selByName";
        public const string PROC_GET_CLIENT_MASTER_ALLOW_USER = "sproc_ClientMaster_sel_AllowUser";
        public const string PROC_GET_CLIENT_MASTER_CLIENT_EXISTS_BY_URL = "sproc_ClientMaster_ClientExistsByURL";
        public const string PROC_UPDATE_CLIENT = "sproc_ClientMaster_ups";
        public const string PROC_DELETE_CLIENT = "sproc_ClientMaster_del";
        public const string PROC_GET_ALL_CLIENTS = "sproc_ClientMaster_LstAll";
        public const string PROC_DROP_CLIENT_DATABASE = "sproc_DropDatabase";
        public const string PROC_CREATE_CLIENT_DATABASE = "sproc_CreateClientDatabase";
        public const string PROC_CREATE_CLIENT_DATABASE_SCHEMA = "sproc_CreateClientDatabaseSchema";
        public const string PROC_SEARCH_CLIENTS = "sproc_ClientMaster_Sel_Search";
        public const string PROC_UPDATE_IS_ANNOUNCEMENTS_ENABLED = "sproc_ClientMaster_ups_IsAnnouncementsEnabled";
        public const string PROC_UPDATE_HTTPSALLOWED = "sproc_ClientMaster_ups_HTTPSAllowed";
        public const string PROC_GET_HTTPSALLOWED = "sproc_ClientMaster_sel_HTTPSAllowed";
        public const string PROC_UPDATE_SESSION_TIME_OUT = "sproc_SetSessionTimeoutValues";
        public const string PROC_UPDATE_SYSTEM_LOCK_UNLOCK = "sproc_LockUnlockSystem";
        public const string PROC_SET_DEFAULT_THEME = "sproc_SetDefaultTheme";
        public const string PROC_MANAGE_FORGOT_PWD_LINK = "sproc_ManageForgotPasswordLink";
        public const string PROC_SET_LOGOUT_REDIRECTION_URL = "sproc_SetLogoutRedirectionURL";
        public const string PROC_SET_MAX_UPLOAD_FILE_SIZE = "sproc_SetMaxUploadFileSize";
        public const string PROC_SET_SELF_REGISTRATION_TYPE = "sproc_SetSelfRegistrationType";
        public const string PROC_SET_NON_RESTRICTED_DOMAIN = "sproc_SetNonRestrictedDomain";
        public const string PROC_SET_SSO_TYPE = "sproc_SetSSOType";
        public const string PROC_SET_IS_RSS_ENABLED = "sproc_SetIsRSSEnabled";
        public const string PROC_SET_DEFAULT_LOGO = "sproc_SystemConfigurationMaster_ups_Logo";
        public const string PROC_ACTIVATE_DEACTIVATE_CLIENT = "sproc_ClientMaster_ups_status";
        public const string PROC_UPDATE_FEEDBACK_RECEIVER_EMAILID = "sproc_ClientMaster_ups_FeedbackReceiverEmailId";
        public const string PROC_UPDATE_ALLOW_USER = "sproc_ClientMaster_ups_AllowUser";
        public const string PROC_SET_DEFAULT_PAGE_SIZE = "sproc_SetDefaultPagesize";
        public const string PROC_CHECKISCLIENTVALIDBYID = "sproc_CheckIsClientValidById";
        public const string PROC_GetClientDetailsFromCourseIdForBenecke = "sproc_GetClientDetailsFromCourseIdForBenecke";
        public const string PROC_UPDATE_USER_PHOTO_ISDISPLAY = "sproc_UserPhotoMaster_ups_IsDisplay";
        public const string PROC_GET_USER_PHOTO_ISDISPLAY_SETTINGS = "sproc_UserPhotoMaster_Lst_IsDisplay";
        public const string PROC_UPDATE_USER_PHOTO_ISALLOWUPLOADPHOTO = "sproc_UserPhotoMaster_ups_IsAllowedUploadPhoto";
        public const string PROC_GET_USER_PHOTO_ISALLOWUPLOADPHOTO_SETTINGS = "sproc_UserPhotoMaster_Lst_IsAllowUploadPhoto";
        public const string PROC_GET_ALL_CLIENTS_VIRTUAL_TRAINING = "sproc_GetAllClientsVirtualTraining";
        //PARAMETERS
        public const string PARA_CLIENT_ID = "@ClientId";
        public const string PARA_CLIENT_NAME = "@ClientName";
        public const string PARA_DBIP_ADDRESS = "@DBIPAddress";
        public const string PARA_ACCESS_URL = "@ClientAccessURL";
        public const string PARA_DEFAULT_LANGUAGE_ID = "@DefaultLanguageId";
        public const string PARA_DEFAULT_LAOUT_ID = "@DefaultLayoutId";
        public const string PARA_DEFAULT_THEME_ID = "@DefaultThemeId";
        public const string PARA_CLIENT_DESCRIPTION = "@ClientDescription";
        public const string PARA_DATABASE_NAME = "@DatabaseName";
        public const string PARA_DB_UID = "@DBUID";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_DB_PASSWORD = "@DBPassword";
        public const string PARA_CONTENT_SERVER_URL = "@ContentServerURL";
        public const string PARA_NUMBER_OF_USER_LICENSES = "@NumberOfUserLicenses";
        public const string PARA_SESSION_TIME_OUT = "@SessionTimeOut";
        public const string PARA_IS_SELF_REGISTRATION = "@IsSelfRegistration";
        public const string PARA_IS_PASSCODE_BASED = "@IsPassCodeBased";
        public const string PARA_IS_EMAIL_DOMAIN_NASED = "@IsEmailDomainBased";
        public const string PARA_IS_SSO_CONFIGURED = "@IsSSOConfigured";
        public const string PARA_SSO_TYPE_ID = "@SSOTypeId";
        public const string PARA_LOGOUT_URL = "@LogoutRedirectionURL";
        public const string PARA_IS_LOCKED = "@IsLocked";
        public const string PARA_IS_FORGOT_PWD_ENABLED = "@IsForgotPasswordEnabled";
        public const string PARA_IS_CONTACT_US_ENABLED = "@IsContactUsEnabled";
        public const string PARA_IS_FEEDBACK_ENABLED = "@IsFeedbackEnabled";
        public const string PARA_IS_RSS_ENABLED = "@IsRSSEnabled";
        public const string PARA_IS_ANNOUNCEMENTS_ENABLED = "@IsAnnouncementsEnabled";
        public const string PARA_IS_HTTPS_ALLOWED = "@IsHTTPSAllowed";

        public const string PARA_MAX_FILEUPLOAD_SIZEMB = "@MaxFileUploadSizeMB";
        public const string PARA_CONTRACT_START_DATE = "@ContractStartDate";
        public const string PARA_CONTRACT_END_DATE = "@ContractEndDate";
        public const string PARA_MAX_CONCURRENT_SESSIONS = "@MaxConcurrentSessions";
        public const string PARA_SMTP_SERVER_IP = "@SMTPServerIP";
        public const string PARA_SMTP_USER_NAME = "@SMTPUserName";
        public const string PARA_SMTP_PWD = "@SMTPPassword";
        public const string PARA_SITE_SUB_DOMAIN_NAME = "@SiteSubDomainName";
        public const string PARA_SAI_SERVICE_MANAGER = "@SAIConsultingServiceManager";
        public const string PARA_ALLOWED_DOMAINS_LIST = "@AllowedDomainsList";
        public const string PARA_NON_RESTRICTED_DOMAIN_LIST = "@NonRestrictedDomainsList";
        public const string PARA_ALLOW_USER_PROFILE_EDIT = "@AllowUserProfileEdit";
        public const string PARA_FEED_BACK_RECEIVER_EMAIL_ID = "@FeedbackReceiverEmailId";
        public const string PARA_ISCERTIFCATIONENABLED = "@IsCertifcationEnabled";
        public const string COL_ISCERTIFCATIONENABLED = "IsCertifcationEnabled";

        public const string PARA_ISDISPLAY = "@IsDisplay";
        public const string PARA_ISALLOWUPLOADPHOTO = "@IsAllowedUploadPhoto";

        public const string COL_IS_HTTPS_ALLOWED = "IsHTTPSAllowed";

        //FIELDS
        /// <summary>
        /// COL_CLIENT_ID
        /// </summary>
        public const string COL_CLIENT_ID = "ClientId";
        /// <summary>
        /// COL_CLIENT_NAME
        /// </summary>
        public const string COL_CLIENT_NAME = "ClientName";
        /// <summary>
        /// COL_CLIENT_DESC
        /// </summary>
        public const string COL_CLIENT_DESC = "ClientDescription";
        /// <summary>
        /// COL_ACCESS_URL
        /// </summary>
        public const string COL_ACCESS_URL = "ClientAccessURL";
        /// COL_ACCESS_URL
        /// </summary>
        public const string COL_ACCESS_COURSE_PLAYER_URL = "CoursePlayerURL";
        /// <summary>
        /// COL_DBIP_ADDRESS
        /// </summary>
        public const string COL_DBIP_ADDRESS = "DBIPAddress";
        /// <summary>
        /// COL_DB_NAME
        /// </summary>
        public const string COL_DB_NAME = "DatabaseName";
        /// <summary>
        /// COL_DB_UID
        /// </summary>
        public const string COL_DB_UID = "DBUID";
        /// <summary>
        /// COL_DB_PWD
        /// </summary>
        public const string COL_DB_PWD = "DBPassword";
        /// <summary>
        /// COL_DEFAULT_LANG_ID
        /// </summary>
        public const string COL_DEFAULT_LANG_ID = "DefaultLanguageId";
        /// <summary>
        /// COL_DEFAULT_LAOUT_ID
        /// </summary>
        public const string COL_DEFAULT_LAOUT_ID = "DefaultLayoutId";
        /// <summary>
        /// COL_DEFAULT_THEME_ID
        /// </summary>
        public const string COL_DEFAULT_THEME_ID = "DefaultThemeId";
        /// <summary>
        /// COL_CONT_SRVR_URL
        /// </summary>
        public const string COL_CONT_SRVR_URL = "ContentServerURL";
        /// <summary>
        /// COL_NO_USER_LICS
        /// </summary>
        public const string COL_NO_USER_LICS = "NumberOfUserLicenses";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_SESSION_TIME_OUT = "SessionTimeOut";
        public const string COL_IS_SELF_REGISTRATION = "IsSelfRegistration";
        public const string COL_IS_PASSCODE_BASED = "IsPassCodeBased";
        public const string COL_IS_EMAIL_DOMAIN_NASED = "IsEmailDomainBased";
        public const string COL_IS_SSO_CONFIGURED = "IsSSOConfigured";
        public const string COL_SSO_TYPE_ID = "SSOTypeId";
        public const string COL_LOGOUT_URL = "LogoutRedirectionURL";
        public const string COL_IS_LOCKED = "IsLocked";
        public const string COL_IS_FORGOT_PWD_ENABLED = "IsForgotPasswordEnabled";
        public const string COL_IS_CONTACT_US_ENABLED = "IsContactUsEnabled";
        public const string COL_IS_FEEDBACK_ENABLED = "IsFeedbackEnabled";
        public const string COL_IS_RSS_ENABLED = "IsRSSEnabled";
        public const string COL_IS_ANNOUNCEMENTS_ENABLED = "IsAnnouncementsEnabled";
        public const string COL_MAX_FILEUPLOAD_SIZEMB = "MaxFileUploadSizeMB";
        public const string COL_CONTRACT_START_DATE = "ContractStartDate";
        public const string COL_CONTRACT_END_DATE = "ContractEndDate";
        public const string COL_MAX_CONCURRENT_SESSIONS = "MaxConcurrentSessions";
        public const string COL_SMTP_SERVER_IP = "SMTPServerIP";
        public const string COL_SMTP_USER_NAME = "SMTPUserName";
        public const string COL_SMTP_PWD = "SMTPPassword";
        public const string COL_SITE_SUB_DOMAIN_NAME = "SiteSubDomainName";
        public const string COL_SAI_SERVICE_MANAGER = "SAIConsultingServiceManager";
        public const string COL_SEARCH_ADMIN_NAME = "AdminName";
        public const string COL_ADMIN_EMAIL_ID = "AdminEmail";
        public const string COL_TOTAL_USERS = "TotalUsers";
        public const string COL_TOTAL_ALLOCATION = "TotalAllocation";
        public const string COL_ALLOW_USER_PROFILE_EDIT = "AllowUserProfileEdit";
        public const string COL_FEED_BACK_RECEIVER_EMAIL_ID = "FeedbackReceiverEmailId";
        public const string COL_IS_CONTRACT_STARTED = "IsClientContractStarted";
        public const string COL_IS_CONTRACT_EXPIRED = "IsClientContractExpired";
        public const string COL_LU_CLIENTID = "LUClientId";
        public const string COL_LU_CLIENT_NAME = "LUClientName";
        public const string COL_DEFAULT_PAGE_SIZE = "DefaultPageSize";

        public const string COL_ISDISPLAY = "IsDisplay";
        public const string COL_ISALLOWUPLOADPHOTO = "IsAllowedUploadPhoto";
        public const string COL_DEFAULT_LOGIN_LAYOUTID = "DefaultLoginLayoutId";
        public const string COL_DEFAULT_LOGIN_THEMEID = "DefaultLoginThemeId";
    }
    #endregion

    #region ClientFeature
    public class ClientFeature
    {
        //PROCEDURES
        public const string PROC_DELETE_CLIENTFEATURE = "sproc_ClientFeature_del";
        public const string PROC_UPDATE_CLIENTFEATURE = "sproc_ClientFeature_ups";
        public const string PROC_GET_ALL_CLIENTFEATURE = "sproc_ClientFeature_LstAll";
        public const string PROC_GET_CLIENTFEATURE = "sproc_ClientFeature_Sel";

        //PARAMETERS
        public const string PARA_FEATUREID = "@FeatureID";
        public const string PARA_ISACTIVE = "@IsActive";
        public const string PARA_CLIENTID = "@ClientId";
        public const string PARA_CLIENTFEATUREID = "@ClientFeatureId";

        //FIELDS
        public const string COL_FEATUREID = "FeatureID";
        public const string COL_ISACTIVE = "IsActive";
        public const string COL_CLIENTID = "ClientId";
        public const string COL_CLIENTFEATUREID = "ClientFeatureId";
    }
    #endregion
    #region ClientFeatureMaster
    public class ClientFeatureMaster
    {
        //PROCEDURES
        public const string PROC_GET_ALL_CLIENTFEATUREMASTER = "sproc_ClientFeatureMaster_LstAll";
        public const string PROC_GET_CLIENTFEATUREMASTER = "sproc_ClientFeatureMaster_Sel";

        //PARAMETERS
        public const string PARA_CLIENTFEATUREID = "@ClientFeatureID";
        public const string PARA_FEATURENAME = "@FeatureName";

        //FIELDS
        public const string COL_CLIENTFEATUREID = "ClientFeatureID";
        public const string COL_FEATURENAME = "FeatureName";
    }
    #endregion

    #region Theme
    public class Theme
    {
        //PROCEDURES
        public const string PROC_GET_THEME = "sproc_ThemesMaster_sel";
        public const string PROC_UPDATE_THEME = "sproc_ThemesMaster_ups";
        public const string PROC_GET_ALL_THEMES = "sproc_ThemesMaster_LstAll";

        //PARAMETERS
        public const string PARA_THEME_ID = "@ThemeId";
        public const string PARA_LAYOUT_ID = "@LayoutId";
        public const string PARA_THEME_NAME = "@ThemeName";
        public const string PARA_THEME_BASE_URL = "@ThemeBaseURL";

        //FIELDS
        public const string COL_THEME_ID = "ThemeID";
        public const string COL_THEME_NAME = "ThemeName";
        public const string COL_LAYOUT_ID = "LayoutID";
        public const string COL_BASE_URL = "ThemeBaseURL";
        public const string COL_CREATED_BY = "CreatedById";
        public const string COL_CREATED_ON = "DateCreated";
        public const string COL_MODIFIED_BY = "LastModifiedById";
        public const string COL_MODIFIED_ON = "LastModifiedDate";
    }
    #endregion
    /*Add Admin Theme Class
    * Author:Bharat Mohane
    * Created:22/02/13
    * Last Modified:<dd/mm/yy>
    */
    #region AdminTheme
    public class AdminTheme
    {
        //PROCEDURES
        public const string PROC_GET_ADMINTHEME = "sproc_AdminThemesMaster_sel";
        public const string PROC_UPDATE_ADMINTHEME = "sproc_AdminThemesMaster_ups";
        public const string PROC_GET_ALL_ADMINTHEMES = "sproc_AdminThemesMaster_LstAll";

        //PARAMETERS
        public const string PARA_THEME_ID = "@ThemeId";
        public const string PARA_LAYOUT_ID = "@LayoutId";
        public const string PARA_THEME_NAME = "@ThemeName";
        public const string PARA_THEME_BASE_URL = "@ThemeBaseURL";

        //FIELDS
        public const string COL_THEME_ID = "ThemeID";
        public const string COL_THEME_NAME = "ThemeName";
        public const string COL_LAYOUT_ID = "LayoutID";
        public const string COL_BASE_URL = "ThemeBaseURL";
        public const string COL_CREATED_BY = "CreatedById";
        public const string COL_CREATED_ON = "DateCreated";
        public const string COL_MODIFIED_BY = "LastModifiedById";
        public const string COL_MODIFIED_ON = "LastModifiedDate";
        public const string COL_TYPE = "Type";
    }
    #endregion
    /*Add Admin Layout Class
    * Author:Bharat Mohane
    * Created:22/02/13
    * Last Modified:<dd/mm/yy>
    */
    #region AdminLayout

    public class AdminLayout
    {
        //PROCEDURES
        public const string PROC_GET_ADMINLAYOUT = "sproc_AdminLayoutMaster_sel";
        public const string PROC_UPDATE_ADMINLAYOUT = "sproc_AdminLayoutMaster_ups";
        public const string PROC_DELETE_ADMINLAYOUT = "sproc_AdminLayoutMaster_del";
        public const string PROC_GET_ALL_ADMINLAYOUTS = "sproc_AdminLayoutMaster_LstAll";

        //PARAMETERS
        public const string PARA_LAYOUT_ID = "@LayoutId";
        public const string PARA_LAYOUT_NAME = "@LayoutName";
        public const string PARA_MASTER_PAGE_URL = "@MasterPageURL";
        public const string PARA_MASTER_PAGE_URL_RTL = "@MasterPageURLRTL";
        public const string PARA_DEFAULT_THEME_ID = "@DefaultThemeId";
        public const string PARA_CLIENT_ID = "@ClientID";

        //FIELDS
        public const string COL_LAYOUT_ID = "LayoutId";
        public const string COL_LAYOUT_NAME = "LayoutName";
        public const string COL_MST_PAGE_URL = "MasterPageURL";
        public const string COL_MST_PAGE_URL_RTL = "MasterPageURLRTL";
        public const string COL_DEFAULT_THEME_ID = "DefaultThemeId";
        public const string COL_CLIENT_ID = "ClientID";
        public const string COL_Type = "ClientID";
    }

    #endregion
    /*Add AdminLayoutConfig Class
    * Author:Bharat Mohane
    * Created:22/02/13
    * Last Modified:<dd/mm/yy>
    */
    #region AdminLayoutConfig
    public class AdminLayoutConfig
    {
        //PROCEDURES
        public const string PROC_GET_ADMINLAYOUTCONFIG = "sproc_AdminLayoutConfig_sel";
        public const string PROC_UPDATE_ADMINLAYOUTCONFIG = "sproc_AdminLayoutConfig_ups";
        public const string PROC_GET_ALL_ADMINLAYOUTCONFIG = "sproc_AdminLayoutConfigMaster_LstAll";

        //PARAMETERS
        public const string PARA_THEME_ID = "@ThemeId";
        public const string PARA_LAYOUT_ID = "@LayoutId";
        public const string PARA_CLIENT_ID = "@ClientId";

        //FIELDS
        public const string COL_THEME_ID = "DefaultThemeID";
        public const string COL_LAYOUT_ID = "DefaultLayoutID";
        public const string COL_CLIENT_ID = "ClientId";
    }
    #endregion

    #region ThemeLanguages
    public class ThemeLanguages
    {
        //PROCEDURES
        public const string PROC_GET_THEME_LANG = "sproc_ThemeLanguages_sel";
        public const string PROC_UPDATE_THEMES_LANGUAGE = "sproc_ThemeLanguages_ups";
        public const string PROC_GET_ALL_THEMES_LANGUAGE = "sproc_ThemeLanguages_LstAll";

        //PARAMETERS

        //FIELDS
        public const string COL_CSS_FILENAME_1 = "CSSFileName1";
        public const string COL_CSS_FILENAME_2 = "CSSFileName2";
        public const string COL_CSS_FILENAME_3 = "CSSFileName3";
        public const string COL_CSS_FILENAME_4 = "CSSFileName4";

        public const string COL_CSS_FILENAME_5 = "CSSFileName5";
        public const string COL_CSS_FILENAME_6 = "CSSFileName6";
        public const string COL_CSS_FILENAME_7 = "CSSFileName7";
        public const string COL_CSS_FILENAME_8 = "CSSFileName8";
        public const string COL_CSS_FILENAME_9 = "CSSFileName9";
        public const string COL_CSS_FILENAME_10 = "CSSFileName10";
    }
    #endregion

    #region Configuration
    public class Configuration
    {

        //PARAMETERS
        public const string PARA_DEFAULT_SITE_LOGO = "@DefaultSiteLogo";

        //FIELDS
        public const string COL_CONFIG_ID = "ConfigurationId";
        public const string COL_CONFIG_XML = "ConfigXML";
        public const string COL_ALLOWED_DOMAIN_LIST = "AllowedDomainsList";
        public const string COL_NONRESTRICTED_DOMAIN_LIST = "NonRestrictedDomainList";
        public const string COL_DEFAULT_SITE_LOGO = "DefaultSiteLogo";
    }
    #endregion

    #region SSOConfigurationUrl
    public class SSOConfigurationUrl
    {
        //PROCEDURES
        public const string PROC_GET_CLIENT_SSO_CONF = "sproc_ClientSSOConfigurationMaster_sel";
        public const string PROC_UPDATE_CLIENT_SSO_CONF = "sproc_ClientSSOConfigurationMaster_ups";
        public const string PROC_GET_ALL_CLIENT_SSO_CONF = "sproc_ClientSSOConfigurationMaster_LstAll";

        //PARAMETERS
        public const string PARA_SSO_CONF_ID = "@SSOConfigurationId";
        public const string PARA_URL = "@URL";
        public const string PARA_SSO_LOGOUT_URL = "@SSOLogoutURL";


        //FIELDS        
        public const string COL_SSO_CONF_ID = "SSOConfigurationId";
        public const string COL_URL = "URL";
        public const string COL_SSO_LOGOUT_URL = "SSOLogoutURL";
    }
    #endregion

    #region SSOConfigurationField
    public class SSOConfigurationField
    {
        //PROCEDURES
        public const string PROC_GET_CLIENT_SSO_CONF_FIELD = "sproc_ClientSSOConfiguration_sel";
        public const string PROC_UPDATE_CLIENT_SSO_CONF_FIELD = "sproc_ClientSSOConfiguration_ups";
        public const string PROC_GET_ALL_CLIENT_SSO_CONF_FIELD = "sproc_ClientSSOConfiguration_LstAll";

        //PARAMETERS
        public const string PARA_SSO_CONF_FIELD_ID = "@SSOConfigurationFieldId";
        public const string PARA_SSO_FIELD_NAME = "@SSOFieldName";
        public const string PARA_IDFID = "@IDFID";
        public const string PARA_IMPORT_DEFINITION_ID = "@ImportDefinitionID";
        public const string PARA_IS_INCLUDED = "@IsIncluded";
        public const string PARA_SSO_CONFIGURATION_ID = "@SSOConfigurationId";
        public const string PARA_CLIENT_ID = "@ClientID";


        //FIELDS        
        public const string COL_SSO_CONF_FIELD_ID = "SSOConfigurationFieldId";
        public const string COL_SSO_FIELD_NAME = "SSOFieldName";
        public const string COL_IDFID = "IDFID";
        public const string COL_IMPORT_DEFINITION_ID = "ImportDefinitionID";
        public const string COL_IS_INCLUDED = "IsIncluded";
        public const string COL_SSO_CONFIGURATION_ID = "SSOConfigurationId";
        public const string COL_CLIENT_ID = "ClientID";
    }
    #endregion

    #region Language
    public class Language
    {
        //PROCEDURES
        public const string PROC_GET_LANGUAGE = "sproc_LanguageMaster_sel";
        public const string PROC_INSERT_SELECTED_CLIENT_LANG = "sproc_CreateClientDatabaseSchema_ByLanguageId";

        public const string PROC_GET_ALL_CLIENT_LANGS = "sproc_ClientLanguage_LstAll";
        public const string PROC_GET_ALL_MASTER_LANGS = "sproc_LanguageMaster_LstAll";

        //PARAMETERS
        public const string PARA_LANGUAGE_ID = "@LanguageId";
        public const string PARA_LANGUAGE_IDS = "@LanguageIds";

        //FIELDS
        public const string COL_LANGUAGE_ID = "LanguageId";
        public const string COL_LANG_ENG_NAME = "LanguageEnglishName";
        public const string COL_LANG_NAME = "LanguageName";
        public const string COL_CHAR_SET_TYPE = "CharacterSetType";
        public const string COL_TEXT_DIRECTION = "TextDirection";
    }
    #endregion

    #region Layout
    public class Layout
    {
        //PROCEDURES
        public const string PROC_GET_LAYOUT = "sproc_LayoutMaster_sel";
        public const string PROC_UPDATE_LAYOUT = "sproc_LayoutMaster_ups";
        public const string PROC_DELETE_LAYOUT = "sproc_LayoutMaster_del";
        public const string PROC_GET_ALL_LAYOUTS = "sproc_LayoutMaster_LstAll";

        //PARAMETERS
        public const string PARA_LAYOUT_ID = "@LayoutId";
        public const string PARA_LAYOUT_NAME = "@LayoutName";
        public const string PARA_MASTER_PAGE_URL = "@MasterPageURL";
        public const string PARA_MASTER_PAGE_URL_RTL = "@MasterPageURLRTL";
        public const string PARA_DEFAULT_THEME_ID = "@DefaultThemeId";
        public const string PARA_CLIENT_ID = "@ClientID";

        //FIELDS
        public const string COL_LAYOUT_ID = "LayoutId";
        public const string COL_LAYOUT_NAME = "LayoutName";
        public const string COL_MST_PAGE_URL = "MasterPageURL";
        public const string COL_MST_PAGE_URL_RTL = "MasterPageURLRTL";
        public const string COL_DEFAULT_THEME_ID = "DefaultThemeId";
        public const string COL_CLIENT_ID = "ClientID";
    }
    #endregion

    #region Learner
    public class Learner
    {
        //PROCEDURES
        public const string PROC_GET_USER_PREFERED_DATETIME = "sproc_UserMaster_sel_Preferred_DateTime";
        public const string PROC_GET_USER = "sproc_UserMaster_sel";
        public const string PROC_GET_USER_COURSE_PLAYER = "procGetUserDetails";
        public const string PROC_GET_USER_FOR_REQ_BY_ID = "sproc_UserMaster_sel_For_Req_By_Id";
        public const string PROC_GET_USER_DEFAULT_LANG_ID_BY_TYPE_ID = "sproc_UserMaster_Sel_DefaultLangId_ByUserType";
        public const string PROC_GET_USER_BY_TYPE_ID = "sproc_UserMaster_Sel_UserType";
        public const string PROC_GET_USER_BY_PWD = "sproc_UserMaster_selByPWD";
        public const string PROC_UPDATE_USER = "sproc_UserMaster_ups";
        public const string PROC_UPDATE_USER_IMPORT = "sproc_UserMaster_ups_ForBulkImport";
        public const string PROC_SET_USER_INITIAL_SETTINGS = "sproc_setUserIntialSettings";
        public const string PROC_UPDATE_USER_BY_ADMINSCOPE = "sproc_UserUpdate_ByAdminScope";
        public const string PROC_DELETE_USER = "sproc_UserMaster_del";
        public const string PROC_DELETE_USER_CF_VALUES = "sproc_UserCustomFieldValue_del_ByLearner";
        public const string PROC_UPDATE_FIRST_LOGIN = "sproc_UserMaster_ups_FirstLogin";
        public const string PROC_GET_USER_SCOPE = "sproc_GetUserScope";

        public const string PROC_DELETE_SEL_USER = "sproc_UserMaster_Multidel";
        public const string PROC_GET_USER_BY_ALIAS = "sproc_UserMaster_selByAlias";
        public const string PROC_GET_USER_BY_ALIAS_FORGOTPASSWORD = "sproc_UserMaster_selByAlias_Forgotpassword";
        public const string PROC_USER_CHECK_BY_ALIAS = "sproc_UserMaster_Check_ByAlias";
        public const string PROC_GET_USER_BY_EMAIL = "sproc_UserMaster_selBy_EmailId";
        public const string PROC_GET_SELECTED_USERS = "sproc_UserMaster_Multisel";
        public const string PROC_FIND_USERS_WITH_RANGE = "sproc_UserMaster_Sel_Search";
        public const string PROC_FIND_USERS_FOR_ROLE_ASSIGNMENT = "sproc_UserMaster_Sel_Search_ForRole";
        public const string PROC_FIND_BUSSINESS_RULE_USERS_WITH_RANGE = "sproc_UserMaster_LstRule_ExcludeInclude";
        public const string PROC_SEARCH_LEARNERS = "sproc_UserMaster_Sel_dtls";
        public const string PROC_CHECK_NEW_PWD = "sproc_CheckNewPassword";
        public const string PROC_FIND_USERS_FOR_ALL_ROLE_ASSIGNMENT = "sproc_UserMaster_Sel_Search_ForAllRoles";
        public const string PROC_UPDATE_DATEFORMAT = "Sproc_UserDateFormat_ups";

        public const string PROC_SEARCH_LEARNERS_FOR_ASSIGNMENTS = "sproc_UserMaster_Sel_FLID";
        public const string PROC_SEARCH_LEARNERS_FOR_ASSIGNMENTS_OPTIMIZED = "sproc_UserMaster_Sel_FLID_Assignment";
        public const string PROC_SEARCH_LEARNERS_FOR_UNASSIGNMENTS = "sproc_UserMaster_Sel_WithAssignment";
        public const string PROC_SEARCH_LEARNERS_FOR_UNASSIGNMENTS_OPTIMIZED = "sproc_UserMaster_Sel_WithAssignment_UnAssignment";

        public const string PROC_UPDATE_USER_STATUS = "sproc_UserMaster_ups_StatusByClientID";
        public const string PROC_UPDATE_USER_LANGUAGE = "sproc_SetUserLanguage";

        public const string PROC_ASSIGN_MANAGERS = "sproc_AssignManagers";
        public const string PROC_VALIDATE_IMPORT_USER = "sproc_ImportedUsers_validation";

        public const string PROC_BULK_UPDATE_CHANGE_ID = "sproc_UserMaster_ups_UserNameAlias";
        public const string PROC_BULK_ACTIVATE_DEACTIVATE = "sproc_UserMaster_ups_Activate";

        public const string PROC_CUSTOM_FIELD_BULK_IMPORT = "sproc_CustomField_BulkImport";
        public const string PROC_ORG_TREE_BULK_IMPORT = "sproc_OrgTree_BulkImport";

        public const string PROC_CREATE_UD_INDEXES = "sproc_CreateUDIndexes";
        public const string PROC_DROP_UD_INDEXES = "sproc_DropUDIndexes";
        public const string PROC_SYNC_RULEUSERS_AFTER_IMPORT = "sproc_SyncUsersInRule_AfterUserImport";
        public const string PROC_SET_USERINITIAL_SETTINGS_AFTER_IMPORT = "sproc_SetUserInitialSettings_AfterImport";
        public const string PROC_SEARCH_LEARNERS_FOR_SESSIONID = "sproc_UserMaster_Sel_FLID_SessionId";

        public const string PROC_GET_USER_LIST = "sproc_UserMaster_sel";
        //public const string PROC_GET_USER_TRAINING_LIST = "sproc_UserMaster_Training_Learner_LstAll";
        //public const string PROC_GET_USER_ASSIGNEDTRAINING_LIST = "sproc_UserMaster_AssignedTraining_LstAll";

        //PARAMETERS

        public const string PARA_DO_DELETE_CUSTOMFILEDS = "@DoNotDeleteFromMyProfile";


        public const string PARA_PREFERREDDATE_FORMAT = "@PreferredDateFormat";
        public const string PARA_PREFERREDTIMEZONE = "@PreferredTimeZone";
        public const string PARA_USER_ID = "@SystemUserGUID";
        public const string PARA_LEARNERID = "@LearnerId";
        public const string PARA_SESSION_ID = "@SessionId";
        public const string PARA_PROGRAM_ID = "@ProgramId";

        public const string PARA_MULTI_USER_IDS = "@SystemUserGUIDString";
        public const string PARA_USER_NAME_ALIAS = "@UserNameAlias";
        public const string PARA_USER_PASSWORD = "@UserPassword";
        public const string PARA_USER_NEW_PASSWORD = "@NewPassword";
        public const string PARA_FIRST_NAME = "@FirstName";
        public const string PARA_MIDDLE_NAME = "@MiddleName";
        public const string PARA_LAST_NAME = "@LastName";
        public const string PARA_ADDRESS = "@Address";
        public const string PARA_EMAIL_ID = "@EmailId";
        public const string PARA_DATE_OF_BIRTH = "@DateOfBirth";
        public const string PARA_DATE_OF_REGISTRATION = "@DateOfRegistration";
        public const string PARA_DATE_OF_TERMINATION = "@DateOfTermination";
        public const string PARA_USER_TYPE_ID = "@UserTypeId";
        public const string PARA_DEFAULT_LANGUAGE_ID = "@DefaultLanguageId";
        public const string PARA_GENDER = "@Gender";
        public const string PARA_DATE_LAST_LOGIN = "@DateLastLogin";
        public const string PARA_DEFAULT_THEME_ID = "@DefaultThemeID";
        public const string PARA_MANAGER_ID = "@ManagerId";
        public const string PARA_MANAGER_NAME = "@ManagerName";
        public const string PARA_MANAGER_EMAIL_ID = "@ManagerEmailId";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_UNIT_ID = "@UnitId";
        public const string PARA_UNITS = "@Units";
        public const string PARA_LEVEL_ID = "@LevelId";
        public const string PARA_CURRENT_RV = "@CurrentRegionView";
        public const string PARA_PHONE_NO = "@PhoneNo";
        //below mention Parameters used in Search Users functions.
        public const string PARA_HIRE_DATE_FROM = "@HireDateFrom";
        public const string PARA_HIRE_DATE_TO = "@HireDateTo";
        public const string PARA_TERMINATION_DATE_FROM = "@TerminationDateFrom";
        public const string PARA_TERMINATION_DATE_TO = "@TerminationDateTo";
        //For Scope
        public const string PARA_REQUESTED_BY_ID = "@RequestedById";
        public const string PARA_IS_FIRST_LOGIN = "@IsFirstLogin";
        public const string PARA_DYNAMIC_WH_CFIELDS = "@DynamicWhereCustomFields";
        public const string PARA_CFIELDS_ARRAY = "@CustomFields";
        public const string PARA_RULE_ID = "@RuleId";
        public const string PARA_ROLE_ID = "@RoleId";
        public const string PARA_CONTENT_MODULE_ID = "@ContentModuleId";
        public const string PARA_PASSWORD_CHANGED = "@PasswordChanged";
        public const string PARA_RESULTMSG = "@ResultMsg";

        public const string PARA_ISREASSIGN = "@IsReassign";
        //FIELDS
        public const string COL_USER_ID = "SystemUserGUID";
        public const string COL_LEARNERID = "LearnerId";
        public const string COL_USER_NAME_ALIAS = "UserNameAlias";
        public const string COL_USER_MANAGEREMAIL = "ManagerEmail";
        public const string COL_USER_STUDENTEMAIL = "StudentEmail";
        public const string COL_USER_PASSWORD = "UserPassword";
        public const string COL_FIRST_NAME = "FirstName";
        public const string COL_MIDDLE_NAME = "MiddleName";
        public const string COL_LAST_NAME = "LastName";
        public const string COL_ADDRESS = "Address";
        public const string COL_EMAIL_ID = "EmailId";
        public const string COL_DATE_OF_BIRTH = "DateOfBirth";
        public const string COL_DATE_OF_REGISTRATION = "DateOfRegistration";
        public const string COL_DATE_OF_TERMINATION = "DateOfTermination";
        public const string COL_USER_TYPE_ID = "UserTypeId";
        public const string COL_DEFAULT_LANGUAGE_ID = "DefaultLanguageId";
        public const string COL_DEFAULT_THEME_ID = "DefaultThemeID";
        public const string COL_GENDER = "Gender";
        public const string COL_MANAGER_ID = "ManagerId";
        public const string COL_MANAGER_EMAIL = "ManagerEmailId";
        public const string COL_MANAGER_NAME = "ManagerName";
        public const string COL_TIMEZONE_ID = "TimeZoneId";
        public const string COL_DATE_LAST_LOGIN = "DateLastLogin";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_UNIT_ID = "UnitId";
        public const string COL_LEVEL_ID = "LevelId";
        public const string COL_DEFAULT_RV = "DefaultRegionView";
        public const string COL_CURRENT_RV = "CurrentRegionView";
        public const string COL_RV_NAME = "RegionViewName";
        public const string COL_AV_PATH = "AvPath";
        public const string COL_IS_FIRST_LOGIN = "IsFirstLogin";
        public const string COL_PHONE_NO = "PhoneNo";
        public const string COL_IS_PASSWORD_EXPIRED = "IsPasswordExpired";
        public const string COL_IS_INSCOPE = "IsInScope";
        public const string COL_USER_ORG_HIERARCHY = "UserOrgHierarchy";
        public const string COL_USER_SCOPE = "UserScope";
        public const string COL_USER_DEFAULT_ORG = "UserDefaultOrg";
        public const string COL_PREFERRED_DATE_FORMAT = "PreferredDateFormat";
        public const string COL_PREFERREDTIMEZONE = "PreferredTimeZone";
        public const string COL_UserExpiryDate = "UserExpiryDate";
        public const string COL_ActivityId = "ActivityId";
    }
    #endregion

    #region ActivityAssignment

    public class ActivityAssignment
    {
        //PROCEDURES
        public const string PROC_GET_LEARNER_ASSIGNMENT_PRINT = "sproc_UserActivityAssignment_ByLearner_Print";
        public const string PROC_SEARCH_ACTIVITY_BY_NAME = "sproc_Activity_sel_Search";
        public const string PROC_SEARCH_ACTIVITY_BY_NAME_OPTIMZED = "sproc_Activity_sel_Search_Assignment";
        public const string PROC_SEARCH_ACTIVITY_DELEQUENCY_HISTORY = "sproc_Activity_Search_DelequencyHistory";
        public const string PROC_SEARCH_ACTIVITY_ONETIMEASSIGNMENT = "sproc_Activity_SearchOneTimeAssignment";
        public const string PROC_SEARCH_ACTIVITY_FOR_MARK_COMPLETION = "sproc_Activity_Search_MarkCompletion";
        public const string PROC_SEARCH_ACTIVITY_FOR_MARK_COMPLETION_OPTIMIZED = "sproc_Activity_Search_MarkCompletion_UnAssignment";
        public const string PROC_UPDATE_ACTIVITY_ASSIGN = "sproc_UserActivityAssignment_ups";
        public const string PROC_BULK_IMPORT_ASSIGNMENTS = "sproc_UserActivityAssignment_ups_UsingRule";
        public const string PROC_UPDATE_ACTIVITY_ASSIGNMENT = "sproc_UserActivityAssignment_ups_assignment";
        public const string PROC_GET_LEARNER_ACTIVITY_ASSIGN = "sproc_UserActivityAssignment_sel_ByLearner";
        public const string PROC_GET_LEARNER_ASSIGNMENT = "sproc_UserActivityAssignment_ByLearner";
        public const string PROC_GET_LEARNER_ASSIGNMENT_FOR_EDIT = "sproc_UserActivityAssignment_sel_ByLearner_ForEdit";
        public const string PROC_BULK_IMPORT_UNASSIGNMENT_ONE_BY_ONE = "sproc_UserActivityUnassignment_UsingBulkImport_One_By_One";
        public const string PROC_GET_RULE_USER_ACTIVITY_EMAIL = "sproc_GetRuleUserActivity_Email";
        public const string PROC_GET_ACTIVITY_STATUS = "sproc_GetActivityStatus";
        public const string PROC_GET_LEARNER_ASSIGNMENT_FOREMAILTEMPLATE = "sproc_UserActivityAssignment_ByLearner_ForEmailTemplate";

        public const string PROC_CHECK_USER_ASSIGNMENT = "sproc_UserActivityAssignment_sel_ForLaunch";
        public const string PROC_CHECK_USER_ASSIGNMENT_COURSE_PLAYER = "sproc_UserActivityAssignment_sel_ForLaunch_CoursePlayer";
        public const string PROC_GETACTIVITYDETAILS = "procGetActivityDetails";
        
        public const string PROC_CHECK_USER_ASSIGNMENT_OPTIMIZED = "sproc_UserActivityAssignment_sel_ForLaunch_Assignment";

        public const string PROC_GET_CURRENT_ATTEMTPS = "sproc_UserActivityAttempts_LstAll";

        public const string PROC_GROUP_ASSIGNMENT_EDIT = "sproc_UserActivityAssignment_Update_DtlsALL";

        public const string PROC_UNASSIGN_BY_ACTIVITY = "sproc_UserActivityAssignment_unassign";
        public const string PROC_PRODUCT_LICENSE_EXCEED = "sproc_IsProductExceedLicense";

        //-aw 9/7/2011 LCP-21088
        public const string PROC_REFRESH_DYNAMIC_ASSIGNMENT = "sproc_DynamicAssignment_refresh";
        public const string PROC_GET_INNER_ACTIVITY_OFCURRIANDCERTIFICATION = "sproc_GetInnerActivityOfCurriAndCertification";

        public const string PROC_SEARCH_ACTIVITY_BY_CATEGORY_MAPPING = "sproc_Activity_Search_ByCategoryMapping";
        public const string PROC_MAIN_PAGE_COURSE_COUNT = "sproc_UserActivityAssignment_sel_ByLearner_NotCompleted_And_Completed_CurriculumPercentage_Dashboard";

        //PARAMETERS
        public const string PARA_ACTIVITY_ID = "@ActivityId";
        public const string PARA_LEARNER_ID = "@LearnerId";
        public const string PARA_ACTIVITY_TYPE_ID = "@ActivityTypeId";
        public const string PARA_ACTIVITY_NAME = "@ActivityName";
        public const string PARA_ACTIVITY_STATUS = "@ActivityStatus";
        public const string PARA_ACTIVITY_TYPE = "@ActivityType";

        public const string PARA_COMPLETION_CONDITION_ID = "@CompletionConditionId";
        public const string PARA_ASSIGNED_BY_ID = "@CreatedById";
        public const string PARA_USER_ID = "@SystemUserGUID";
        public const string PARA_REQUESTEDBY_ID = "@RequestedByID";

        public const string PARA_DATE_OF_ASSIGNMENT = "@AssignmentDateSet";
        public const string PARA_DUE_DATE = "@DueDateSet";
        public const string PARA_EXPIRY_DATE = "@ExpiryDateSet";
        public const string PARA_SEND_EMAIL = "@SendEmail";
        public const string PARA_SEND_EMAIL_TYPE = "@SendEmailType";
        public const string PARA_EMAIL_TEMPLATE_ID = "@EmailTemplateId";

        public const string PARA_ASSIGNMENT_MODE_FOR_OVERRIDE = "@AssignmentModeForOverride";
        public const string PARA_ASSIGNMENT_TYPE_ID = "@AssignmentTypeId";

        public const string PARA_RULE_ID = "@RuleId";
        public const string PARA_LICENSE_ID = "@LicenseId";
        public const string PARA_IS_CURRENTLY_ASSIGNED = "@IsCurrentlyAssigned";
        public const string PARA_IS_EDIT_FROM_UI = "@IsEditfromUI";
        public const string PARA_IS_ASSIGNMENT_BASED_ON_HIRE_DATE = "@IsAssignmentBasedOnHireDate";
        public const string PARA_IS_ASSIGNMENT_BASED_ON_CREATION_DATE = "@IsAssignmentBasedOnCreationDate";
        public const string PARA_IS_ASSIGNMENT_BASED_ON_CURRENT_DATE = "@IsAssignmentBasedOnCurrentDate";

        public const string PARA_IS_ASSIGNMENT_BASED_ON_NEWHIRECURRENT_DATE = "@IsNewHireAssignmentBasedOnCurrentDate";

        public const string PARA_ASSIGN_AFTER_DAYS_OF = "@AssignAfterDaysOf";

        public const string PARA_IS_NO_DUE_DATE = "@IsNoDueDate";
        public const string PARA_IS_DUE_BASED_ON_ASSIGN_DATE = "@IsDueBasedOnAssignDate";
        public const string PARA_IS_DUE_BASED_ON_HIRE_DATE = "@IsDueBasedOnHireDate";
        public const string PARA_IS_DUE_BASED_ON_CREATION_DATE = "@IsDueBasedOnCreationDate";
        public const string PARA_IS_DUE_BASED_ON_START_DATE = "@IsDueBasedOnStartDate";
        public const string PARA_DUE_AFTER_DAYS_OF = "@DueAfterDaysOf";

        public const string PARA_IS_NO_EXPIRY_DATE = "@IsNoExpiryDate";
        public const string PARA_IS_EXPIRY_BASED_ON_ASSIGN_DATE = "@IsExpiryBasedOnAssignDate";
        public const string PARA_IS_EXPIRY_BASED_ON_START_DATE = "@IsExpiryBasedOnStartDate";
        public const string PARA_IS_EXPIRY_BASED_ON_DUE_DATE = "@IsExpiryBasedOnDueDate";
        public const string PARA_EXPIRY_AFTER_DAYS_OF = "@ExpireAfterDaysOf";

        //- New Property added.
        public const string PARA_REASSIGN_AFTER_DAYS_OF = "@ReAssignAfterDaysOf";
        public const string PARA_REASSIGNMENT_DATE_SET = "@ReAssignmentDateSet";

        public const string PARA_IS_REASSIGN_NO_DUE_DATE = "@IsReassignNoDueDate";
        public const string PARA_REASSIGN_DUE_AFTER_DAYS_OF = "@ReassignDueAfterDaysOf";
        public const string PARA_REASSIGN_DUE_DATE = "@ReassignDueDateSet";

        public const string PARA_IS_REASSIGN_NO_EXPIRY_DATE = "@IsReassignNoExpiryDate";
        public const string PARA_REASSIGN_EXPIRY_AFTER_DAYS_OF = "@ReassignExpireAfterDaysOf";
        public const string PARA_REASSIGN_EXPIRY_DATE = "@ReassignExpiryDateSet";


        // NEW FIELDS ADDED  as on 23-Nov-09
        public const string PARA_IS_REASSIGN_BASED_ON_ASSIGN_DATE = "@IsReAssignmentBasedOnAssignmentDate";
        public const string PARA_IS_REASSIGN_BASED_ON_ASSIGN_COMPL_DATE = "@IsReAssignmentBasedOnAssignmentCompletionDate";
        public const string PARA_IS_REASSIGN_DUE_BASED_ON_ASSIGN_COMPL_DATE = "@IsReassignDueBasedOnAssignmentCompletionDate";
        public const string PARA_IS_REASSIGN_DUE_BASED_ON_REASSIGN_DATE = "@IsReassignDueBasedOnReassignmentDate";
        public const string PARA_IS_REASSIGN_EXPIRY_BASED_ON_REASSIGN_DUE_DATE = "@IsReassignExpiryBasedOnReassignmentDueDate";
        public const string PARA_IS_REASSIGN_EXPIRY_BASED_ON_REASSIGN_DATE = "@IsReassignExpiryBasedOnReassignmentDate";
        public const string PARA_IS_REASSIGN_EXPIRY_BASED_ON_ASSIGN_COMPL_DATE = "@IsReassignExpiryBasedOnAssignmentCompletionDate";

        public const string PARA_PREVIOUS_ASSIGNMENT_ID = "@PreviousAssignmentId";
        public const string PARA_ATTEMPT_ID = "@AttemptId";
        public const string PARA_IS_OVER_RIDE = "@IsOverRide";

        public const string PARA_ASSIGNMENT_DATE_FROM = "@AssignmentDateFrom";
        public const string PARA_ASSIGNMENT_DATE_TO = "@AssignmentDateTo";

        public const string PARA_IS_ADMIN_ASSIGNMENT = "@IsAdminAssignment";
        public const string PARA_FORCE_REASSIGNMENT = "@ForceReAssignment";
        public const string PARA_CREATED_BY_ID = "@CreatedById";

        //FIELDS
        public const string COL_DISPLAY_ACTIVITY_STATUS = "DisplayActivityStatus";
        public const string COL_ACTIVITY_ID = "ActivityId";
        public const string COL_ACTIVITY_NAME = "ActivityName";
        public const string COL_ACTIVITY_DESC = "ActivityDescription";
        public const string COL_ACTIVITY_URL = "ActivityURL";

        public const string COL_DISPLAY_ACTIVITY_PROGRESS = "Progress";

        public const string COL_ACTIVITY_STATUS = "ActivityStatus";
        public const string COL_ACTIVITY_TYPE = "ActivityType";
        public const string COL_ACTIVITY_TYPE_ID = "ActivityTypeId";
        public const string COL_ASSIGNMENT_COMPLETION_DATE = "AssignmentDateOfCompletion";

        public const string COL_ASSIGNMENT_STATUS = "AssignmentStatus";

        public const string COL_COURSE_HOME_PAGE_URL = "CourseHomePageURL";
        public const string COL_ACTIVITY_SUBTYPE_ID = "ActivitySubTypeID";

        public const string COL_DATE_OF_ASSIGNMENT = "AssignmentDateSet";
        public const string COL_DUE_DATE = "DueDateSet";
        public const string COL_EXPIRY_DATE = "ExpiryDateSet";
        public const string COL_SEND_EMAIL = "SendEmail";
        public const string COL_SEND_EMAIL_TYPE = "SendEmailType";
        public const string COL_EMAIL_TEMPLATE_ID = "EmailTemplateId";

        public const string COL_COMPLETION_CONDITION_ID = "CompletionConditionId";
        public const string COL_ASSIGNED_BY_ENTITY_ID = "RuleId";
        public const string COL_ASSIGNED_BY_ID = "CreatedById";
        public const string COL_USER_Name = "UserName";
        public const string COL_LEARNER_NAME = "LearnerName";
        public const string COL_USER_ID = "SystemUserGUID";

        public const string COL_ASSIGNMENT_MODE_FOR_OVERRIDE = "AssignmentModeForOverride";
        public const string COL_ASSIGNMENT_TYPE_ID = "AssignmentTypeId";
        //public const string COL_COMPLETION_CONDITION_ID = "CompletionConditionId";
        public const string COL_RULE_ID = "RuleId";
        public const string COL_LICENSE_ID = "LicenseId";
        public const string COL_IS_CURRENTLY_ASSIGNED = "IsCurrentlyAssigned";
        public const string COL_IS_EDIT_FROM_UI = "IsEditfromUI";
        public const string COL_IS_ASSIGNMENT_BASED_ON_HIRE_DATE = "IsAssignmentBasedOnHireDate";
        public const string COL_IS_ASSIGNMENT_BASED_ON_CREATION_DATE = "IsAssignmentBasedOnCreationDate";

        public const string COL_IS_ASSIGNMENT_BASED_ON_CUURENT_DATE = "IsAssignmentBasedOnCurrentDate";

        public const string COL_IS_ASSIGNMENT_BASED_ON_NEWHIRECURRENT_DATE = "IsNewHireAssignmentBasedOnCurrentDate";


        public const string COL_ASSIGN_AFTER_DAYS_OF = "AssignAfterDaysOf";

        public const string COL_IS_NO_DUE_DATE = "IsNoDueDate";
        public const string COL_IS_DUE_BASED_ON_ASSIGN_DATE = "IsDueBasedOnAssignDate";
        public const string COL_IS_DUE_BASED_ON_HIRE_DATE = "IsDueBasedOnHireDate";
        public const string COL_IS_DUE_BASED_ON_CREATION_DATE = "IsDueBasedOnCreationDate";
        public const string COL_IS_DUE_BASED_ON_START_DATE = "IsDueBasedOnStartDate";
        public const string COL_DUE_AFTER_DAYS_OF = "DueAfterDaysOf";
        //public const string COL_DUE_DATE = "DueDateSet";
        public const string COL_IS_NO_EXPIRY_DATE = "IsNoExpiryDate";
        public const string COL_IS_EXPIRY_BASE_ON_ASSIGN_DATE = "IsExpiryBasedOnAssignDate";
        public const string COL_IS_EXPIRY_BASE_ON_START_DATE = "IsExpiryBasedOnStartDate";
        public const string COL_IS_EXPIRY_BASE_ON_DUE_DATE = "IsExpiryBasedOnDueDate";
        public const string COL_EXPIRY_AFTER_DAYS_OF = "ExpireAfterDaysOf";
        //public const string COL_EXPIRY_DATE = "ExpiryDateSet";
        public const string COL_ATTEMPT_COUNT = "AttemptCount";
        public const string COL_ATTEMPT_ID = "AttemptId";

        public const string COL_SCORE = "Score";

        public const string COL_REASSIGN_AFTER_DAYS_OF = "ReAssignAfterDaysOf";
        public const string COL_REASSIGNMENT_DATE_SET = "ReAssignmentDateSet";

        public const string COL_IS_REASSIGN_NO_DUE_DATE = "IsReassignNoDueDate";
        public const string COL_IS_REASSIGN_DUE_BASED_ON_ASSIGN_DATE = "IsReassignDueBasedOnAssignDate";
        public const string COL_REASSIGN_DUE_AFTER_DAYS_OF = "ReassignDueAfterDaysOf";
        public const string COL_REASSIGN_DUE_DATE = "ReassignDueDateSet";

        public const string COL_IS_REASSIGN_NO_EXPIRY_DATE = "IsReassignNoExpiryDate";
        public const string COL_IS_REASSIGN_EXPIRY_BASED_ON_ASSIGN_DATE = "IsReassignExpiryBasedOnAssignDate";
        public const string COL_REASSIGN_EXPIRY_AFTER_DAYS_OF = "ReassignExpireAfterDaysOf";
        public const string COL_REASSIGN_EXPIRY_DATE = "ReassignExpiryDateSet";

        // NEW FIELDS ADDED  as on 23-Nov-09
        public const string COL_IS_REASSIGN_BASED_ON_ASSIGN_DATE = "IsReAssignmentBasedOnAssignmentDate";
        public const string COL_IS_REASSIGN_BASED_ON_ASSIGN_COMPL_DATE = "IsReAssignmentBasedOnAssignmentCompletionDate";
        public const string COL_IS_REASSIGN_DUE_BASED_ON_ASSIGN_COMPL_DATE = "IsReassignDueBasedOnAssignmentCompletionDate";
        public const string COL_IS_REASSIGN_DUE_BASED_ON_REASSIGN_DATE = "IsReassignDueBasedOnReassignmentDate";
        public const string COL_IS_REASSIGN_EXPIRY_BASED_ON_REASSIGN_DUE_DATE = "IsReassignExpiryBasedOnReassignmentDueDate";
        public const string COL_IS_REASSIGN_EXPIRY_BASED_ON_REASSIGN_DATE = "IsReassignExpiryBasedOnReassignmentDate";
        public const string COL_IS_REASSIGN_EXPIRY_BASED_ON_ASSIGN_COMPL_DATE = "IsReassignExpiryBasedOnAssignmentCompletionDate";

        public const string COL_PREVIOUS_ASSIGNMENT_ID = "PreviousAssignmentId";
        public const string COL_IS_OVER_RIDE = "IsOverRide";
        public const string COL_IS_ADMIN_ASSIGNMENT = "IsAdminAssignment";
        public const string COL_REASSIGNMENT_COUNT = "ReassignmentCount";
        public const string COL_FORCE_REASSIGNMENT = "ForceReAssignment";
        public const string COL_CREATED_BY_ID = "CreatedById";

        public const string COL_TOTAL_ROWS_ASSIGNED = "TotalRowsAssigned";
        public const string COL_TOTAL_ROWS_COMPLETED = "TotalRowsCompleted";
        public const string COL_CURRICULUM_COMPLETION_PERCENTAGE = "CurriculumCompletionPercentage";
    }
    #endregion

    #region ContentModule
    public class ContentModule
    {
        //PROCEDURES
        public const string PROC_GET_CONTENT_MODULE_LEARNER = "sproc_ContentModuleMaster_sel_Learner";
        public const string PROC_GET_CONTENT_MODULE_COURSE_PLAYER = "procGetScormDetails";
        public const string PROC_GET_CONTENT_MODULE_URL = "sproc_ContentModuleMaster_sel_ContentModuleURL";
        public const string PROC_GET_CONTENT_MODULE = "sproc_ContentModuleMaster_sel";
        public const string PROC_FIND_CONTENT_MODULE_NAME = "sproc_ContentModuleMaster_selByName";
        public const string PROC_FIND_CONTENT_MODULE = "sproc_ContentModuleMaster_sel_search";
        public const string PROC_UPDATE_CONTENT_MODULE = "sproc_ContentModuleMaster_ups";
        public const string PROC_DELETE_CONTENT_MODULE = "sproc_ContentModuleMaster_del";
        public const string PROC_GET_ALL_CONTENT_MODULES = "sproc_ContentModuleMaster_LstAll";
        public const string PROC_GET_ALL_CONTENT_MODULES_ADMIN_HOME = "sproc_ContentModuleMaster_LstAll_AdminHome";
        public const string PROC_GET_SHORT_LANGUAGE_CODE = "sproc_GetShortLanguageCode";
        public const string PROC_GET_ALL_ASSESSMENT_CONTENT_MODULE = "sproc_AssessmentContentModule_LstAll";
        public const string PROC_GET_ALL_USER_ASSESSMENT_CONTENT_MODULE = "sproc_UserAssessmentContentModule_LstAll";
        public const string PROC_GET_USER_ASSIGN_ACTIVITY_LIST = "sproc_GetUserAssignActivityList";

        //PARAMETERS
        public const string PARA_IS_RESUME = "@isResume";
        public const string PARA_CONTENT_MODULE_ID = "@ContentModuleId";
        public const string PARA_CONTENT_MODULE_NAME = "@ContentModuleName";
        public const string PARA_CONTENT_MODULE_ENGLISH_NAME = "@ContentModuleEnglishName";
        public const string PARA_CONTENT_MODULE_DESC = "@ContentModuleDescription";
        public const string PARA_CONTENT_MODULE_URL = "@PointToURL";
        public const string PARA_CONTENT_MODULE_TYPE = "@ContentModuleTypeId";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_IS_UPLOADED = "@IsUploaded";
        public const string PARA_KEY_WORDS = "@ContentModuleKeyWords";
        public const string PARA_SUB_TYPE_ID = "@ContentModuleSubTypeId";
        public const string PARA_DEL_LANGUAGES = "@IsDelLanguages";
        public const string PARA_SCORE_TRACKING = "@ScoreTracking";
        public const string PARA_QUESTION_RESPONSE_TRACKING = "@QuestionResponseTracking";
        public const string PARA_MASTERY_SCORE = "@MasteryScore";
        public const string PARA_AVPATH = "@AVPath";
        public const string PARA_COURSE_LAUNCH_SAME_WIND0W = "@CourseLaunchSameWindow";
        public const string PARA_COURSE_LAUNCH_NEW_WIND0W = "@CourseLaunchNewWindow";
        public const string PARA_ALLOW_SCROLL = "@AllowScroll";
        public const string PARA_ALLOW_RESIZE = "@AllowResize";
        public const string PARA_COURSE_WINDOW_WIDTH = "@CourseWindowWidth";
        public const string PARA_COURSE_WINDOW_HEIGHT = "@CourseWindowHeight";
        public const string PARA_IS_PRINT_CERTIFICATE = "@IsPrintCertificate";
        public const string PARA_IS_COURSE_SESSION_NO_EXPIRY = "@IsCourseSessionNoExpiry";
        public const string PARA_COURSE_GROUP_ID = "@CourseGroupId";
        public const string PARA_IMANIFEST_URL = "@ImanifestUrl";
        //-aw 6/15/2011 Added course protocol
        public const string PARA_PROTOCOL = "@Protocol";
        public const string PARA_ISASSESSMENT = "@IsAssessment";
        public const string PARA_ISMIDDLEPAGE = "@IsMiddlePage";
        public const string PARA_ISHTML5 = "@IsHTML5";
        public const string PARA_KEEPZIPFILE = "@KeepZipFile";

        //public const string PARA_IS_USED = "@IsUsed";
        public const string PARA_IS_SHORT_LANGUAGE_CODE = "@IsShortLanguageCode";
        public const string PARA_LANGUAGE_LONG_NAME = "@LongName";
        public const string PARA_IS_COURSE_MODIFIED_BY_ADMIN = "@IsCourseModifiedByAdmin";
        public const string PARA_SYSTEM_USER_GUID = "@SystemUserGUID";
        public const string PARA_REQUESTED_BY_ID = "@RequestedById";

        //FIELDS
        public const string COL_CONTENT_MODULE_ID = "ContentModuleId";
        public const string COL_CONTENT_MODULE_NAME = "ContentModuleName";
        public const string COL_CONTENT_MODULE_ENGLISH_NAME = "ContentModuleEnglishName";
        public const string COL_CONTENT_MODULE_DESC = "ContentModuleDescription";
        public const string COL_CONTENT_MODULE_URL = "PointToURL";
        public const string COL_CONTENT_MODULE_TYPE = "ContentModuleTypeId";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_IS_UPLOADED = "IsUploaded";
        public const string COL_KEY_WORDS = "ContentModuleKeyWords";
        public const string COL_SUB_TYPE_ID = "ContentModuleSubTypeId";
        public const string COL_DEL_LANGUAGES = "IsDelLanguages";
        public const string COL_SCORE_TRACKING = "ScoreTracking";
        public const string COL_QUESTION_RESPONSE_TRACKING = "QuestionResponseTracking";
        public const string COL_MASTERY_SCORE = "MasteryScore";
        public const string COL_AVPATH = "AVPath";
        public const string COL_COURSE_LAUNCH_SAME_WIND0W = "CourseLaunchSameWindow";
        public const string COL_COURSE_LAUNCH_NEW_WIND0W = "CourseLaunchNewWindow";
        public const string COL_ALLOW_SCROLL = "AllowScroll";
        public const string COL_ALLOW_RESIZE = "AllowResize";
        public const string COL_COURSE_WINDOW_WIDTH = "CourseWindowWidth";
        public const string COL_COURSE_WINDOW_HEIGHT = "CourseWindowHeight";
        public const string COL_IS_ALLOCATED = "IsAllocated";
        public const string COL_IS_PRINT_CERTIFICATE = "IsPrintCertificate";
        public const string COL_IS_COURSE_SESSION_NO_EXPIRY = "IsCourseSessionNoExpiry";
        public const string COL_IS_COURSE_MODIFIED_BY_ADMIN = "IsCourseModifiedByAdmin";
        //-aw 6/13/2011 Added course protocol
        public const string COL_PROTOCOL = "Protocol";
        public const string COL_ISASSESSMENT = "IsAssessment";
        public const string COL_ISMIDDLEPAGE = "IsMiddlePage";

        public const string COL_COURSE_GROUP_ID = "CourseGroupId";
        public const string COL_IMANIFEST_URL = "ImanifestUrl";

        //public const string COL_IS_USED = "IsUsed";
        public const string COL_IS_SHORT_LANGUAGE_CODE = "IsShortLanguageCode";
        public const string COL_LANGUAGE_LONG_NAME = "LongName";
        public const string COL_LANGUAGE_SHORT_NAME = "ShortName";

        public const string COL_SYSTEM_USER_GUID = "SystemUserGUID";
        public const string COL_REQUESTED_BY_ID = "@RequestedById";
        public const string COL_IS_HTML_5 = "IsHTML5";
        public const string COL_KEEP_ZIP_FILE = "KeepZipFile";
    }
    #endregion

    #region Cluster
    public class Cluster
    {
        //PROCEDURES
        public const string PROC_UPDATE_CLUSTER = "sproc_ClusterMaster_ups";
        public const string PROC_GET_ALL_CLUSTERS = "sproc_ClusterMaster_LstAll";

        //PARAMETERS
        public const string PARA_CLUSTER_ID = "@ClusterId";
        public const string PARA_CLUSTER_DNSSERVER_USERNAME = "@DNSServerUserName";
        public const string PARA_LU_WEBSERVICEURL = "@LUWebServiceURL";
        public const string PARA_LU_APPLICATIONLAUNCH_URL = "@LUApplicationLaunchURL";


        //FIELDS
        public const string COL_CLUSTER_ID = "ClusterId";
        public const string COL_CLUSTER_NAME = "ClusterName";
        public const string COL_CLUSTER_IP = "ClusterIP";
        public const string COL_CLUSTER_DNSSERVER_IP = "DNSServerIP";
        public const string COL_CLUSTER_DNSSERVER_USERNAME = "DNSServerUserName";
        public const string COL_CLUSTER_DNSSERVER_PASSWORD = "DNSServerPassword";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_CONTENT_SERVER_IP = "ContentServerIP";
        public const string COL_DATABASE_IP = "DatabaseIP";
        public const string COL_DATABASE_USERNAME = "DatabaseUserName";
        public const string COL_DATABASE_PASSWORD = "DatabasePassword";
        public const string COL_DOMAIN_NAME = "DomainName";
        public const string COL_CONTENT_FOLDER_PATH = "ContentFolderPath";
        public const string COL_CONTENT_FOLDER_URL = "ContentFolderURL";
        public const string COL_FTP_UPLOAD_PATH = "FTPUploadPath";
        public const string COL_FTP_USER_NAME = "FTPUserName";
        public const string COL_FTP_PASSWORD = "FTPPassword";
        public const string COL_COURSE_PLAYERURL = "CoursePlayerURL";
        public const string COL_LU_WEBSERVICEURL = "LUWebServiceURL";
        public const string COL_LU_APPLICATIONLAUNCH_URL = "LUApplicationLaunchURL";
    }
    #endregion

    #region ContentModuleTracking
    public class ContentModuleTracking
    {
        //PROCEDURES
        public const string PROC_GET_USER_COURSE_COMPLETION_STATUS = "sproc_GetUserCourseCompletionStatus";
        public const string PROC_GET_CONTENT_MODULE_TRACKING = "procScormTrackingDetails";
        public const string PROC_GET_USER_DATA_XML_CONTENT_MODULE_TRACKING = "sproc_UserContentModuleTracking_sel_UserDataXML";
        public const string PROC_GET_CONTENT_MODULE_TRACKING_UPDATE = "sproc_UserContentModuleTracking_sel_OnUpdate";
        public const string PROC_UPDATE_CONTENT_MODULE_TRACKING = "procUpdateTracking";
        public const string PROC_GENERATELOG = "procGenerateLog";
        public const string PROC_UPDATE_MARK_COMPLETED = "sproc_UserContentModuleTracking_ups_MarkCompleted";

        //PARAMETERS
        public const string PARA_ATTEMPT_ID = "@AttemptId";
        public const string PARA_DATE_OF_START = "@DateOfStart";
        public const string PARA_DATE_OF_COMPLETION = "@DateOfCompletion";
        public const string PARA_COMPLETED_DATE = "@CompletedDate";
        public const string PARA_TOTAL_NO_OF_PAGES = "@TotalNoOfPages";
        public const string PARA_NO_OF_PAGES_COMPLETED = "@NoOfPagesCompleted";
        public const string PARA_COMPLETION_STATUS = "@CompletionStatus";
        public const string PARA_USER_DATA_XML = "@UserDataXML";
        public const string PARA_SCORE = "@Score";
        public const string PARA_MARKED_COMPLETED_BY_ID = "@MarkedCompletedById";
        public const string PARA_SCANNED_CERTIFICATION_FILE_NAME = "@scannedcertificationFileName";
        public const string PARA_ACTIVITY_NAME = "@ActivityName";
        public const string PARA_USER_FIRST_LAST_NAME = "@UserFirstLastName";
        public const string PARA_REVIEWER_COMMENTS = "@ReviewerComments";
        public const string PARA_REGION_VIEW_INFO = "@RegionViewInfo";
        public const string PARA_IS_FOR_ADMIN_PREVIEW = "@IsForAdminPreview";
        public const string PARA_EXTEND_EXPIRATION_MINUTES = "@ExtendExpirationMinutes";
        public const string PARA_CHECK_EXPIRED_SESSION = "@CheckExpiredSession";


        //FIELDS
        public const string COL_ATTEMPT_ID = "AttemptId";
        public const string COL_DATE_OF_START = "DateOfStart";
        public const string COL_DATE_OF_COMPLETION = "DateOfCompletion";
        public const string COL_TOTAL_NO_OF_PAGES = "TotalNoOfPages";
        public const string COL_NO_OF_PAGES_COMPLETED = "NoOfPagesCompleted";
        public const string COL_COMPLETION_STATUS = "CompletionStatus";
        public const string COL_USER_DATA_XML = "UserDataXML";
        public const string COL_SCORE = "Score";
        public const string COL_MARKED_COMPLETED_BY_ID = "MarkedCompletedById";
        public const string COL_SCANNED_CERTIFICATION_FILE_NAME = "scannedcertificationFileName";
        public const string COL_ACTIVITY_NAME = "ActivityName";
        public const string COL_USER_FIRST_LAST_NAME = "UserFirstLastName";
        public const string COL_REVIEWER_COMMENTS = "ReviewerComments";
        public const string COL_REGION_VIEW_INFO = "RegionViewInfo";
        public const string COL_IS_FOR_ADMIN_PREVIEW = "IsForAdminPreview";
        public const string COL_VENDORCODE = "VendorCode";
    }
    #endregion

    #region Common
    public class Common
    {
        //PARAMETERS        
        public const string PARA_UPDATE_MODE = "@UpdateMode";
        public const string PARA_CREATED_BY_NAME = "@CreatedByName";
        public const string PARA_CREATED_BY = "@CreatedById";
        public const string PARA_MODIFIED_ON = "@LastModifiedDate";
        public const string PARA_MODIFIED_BY = "@LastModifiedById";
        public const string PARA_MODIFIED_BY_ID = "@ModifiedById";
        public const string PARA_DATABASE_NAME = "@DBName";
        public const string PARA_IS_ACTIVE = "@IsActive";

        public const string PARA_IS_IN_PROCESS = "@IsInProcess";

        public const string PARA_MANAGER_NAME = "@ManagerName";
        public const string PARA_REPORT_ID = "@ReportId";

        #region  For ScannedFileName Update - Common for all ActivityType
        public const string PARA_ACTIVITY_ID = "@ActivityID";
        public const string PARA_ACTIVITY_TYPE = "@ActivityType";
        public const string PARA_SYSTEM_USER_GUID = "@SystemUserGUID";
        public const string PARA_SCANNED_FILE_NAME = "@scannedcertificationFileName";
        public const string PROC_UPDATE_SCANNED_FILE_NAME = "sproc_UserAssignments_MarkCompleted_UpdateFilename";
        #endregion

        public const string PARA_PAGE_INDEX = "@PageIndex";
        public const string PARA_PAGE_SIZE = "@PageSize";
        public const string PARA_KEY_WORD = "@KeyWord";
        public const string PARA_QUERY_TYPE = "@QueryTypeIn";
        public const string PARA_SORT_EXP = "@SortExp";
        public const string PARA_SORT_DIR = "@SortDir";
        public const string PARA_DATE_FROM = "@DateFrom";
        public const string PARA_DATE_TO = "@DateTo";
        public const string PARA_FROM_DATE = "@FromDate";
        public const string PARA_WHERE_CLAUSE = "@WhereClause";
        //-- Updated Date From - To
        public const string PARA_UPDATED_DATE_TO = "@UpdatedDateTo";
        public const string PARA_UPDATED_DATE_FROM = "@UpdatedFromDate";

        //-- Created Date From - To
        public const string PARA_CREATED_DATE_TO = "@DateCreatedTo";
        public const string PARA_CREATED_DATE_FROM = "@DateCreatedFrom";

        public const string PARA_TO_DATE = "@ToDate";
        public const string PARA_IS_PRINT_CERTIFICATE = "@IsPrintCertificate";
        public const string PARA_ATTEMPT_ID = "@AttemptId";
        public const string PARA_IS_BULK_MARK_COMPLETED = "@IsBulkMarkCompleted";
        public const string PARA_REQUESTED_BY_ID = "@RequestedById";
        public const string PARA_SHARED = "@Shared";

        public const string PARA_CLIENT_ID = "@ClientId";
        public const string PARA_CONTENTTRACKID = "@ContentTrackId";

        //FIELDS
        public const string COL_CREATED_ON = "DateCreated";
        public const string COL_CREATED_BY = "CreatedById";
        public const string COL_MODIFIED_ON = "LastModifiedDate";
        public const string COL_MODIFIED_BY = "LastModifiedById";
        public const string COL_TOTAL_COUNT = "TotalCount";
        public const string COL_UPDATE_MODE = "UpdateMode";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_CREATED_BY_NAME = "CreatedByName";
        public const string COL_MODIFIED_BY_NAME = "LastModifiedByName";
        public const string COL_IS_USED = "IsUsed";
        public const string COL_ATTEMPT_ID = "AttemptId";
        public const string COL_IS_PRINT_CERTIFICATE = "IsPrintCertificate";
        public const string COL_CHILD_COUNT = "ChildCount";
        public const string COL_IS_BULK_MARK_COMPLETED = "IsBulkMarkCompleted";
        public const string COL_PAGE_SIZE = "PageSize";
        public const string COL_CLIENT_ID = "ClientId";
        public const string COL_USER_PROFILE_IMG = "UserProfileImg";

        //VALUES
        public const string VAL_UPDATE_MODE = "ED";
        public const string VAL_INSERT_MODE = "IN";
        public const string VAL_DELETE_MODE = "DL";
        public const string VAL_UPDATEALL_MODE = "EDA";

        //UNIQUE ID GENERATION ASSUMPTIONS 
        //PasswordPolicyConfiguration
        public const int VAL_PWD_POLICY_CONFIG_ID_LENGTH = 8;
        //Rule
        public const string VAL_RULE_ID_PREFIX = "RUL";
        public const int VAL_RULE_ID_LENGTH = 8;
        //REPORT
        public const string VAL_REPORT_ID_PREFIX = "REP";
        public const int VAL_REPORT_ID_LENGTH = 8;
        //Policy Library
        public const string VAL_POLICY_FOLDER_ID_PREFIX = "PFO";
        public const int VAL_POLICY_FOLDER_ID_LENGTH = 8;
        //Policy
        public const string VAL_POLICY_ID_PREFIX = "POL";
        public const int VAL_POLICY_ID_LENGTH = 8;
        //Asset Library
        public const string VAL_ASSET_FOLDER_ID_PREFIX = "AFO";
        public const int VAL_ASSET_FOLDER_ID_LENGTH = 8;
        //Asset
        public const string VAL_ASSET_ID_PREFIX = "ASS";
        public const int VAL_ASSET_ID_LENGTH = 8;
        //Content Module
        public const string VAL_CONTENT_MODULE_ID_PREFIX = "COU";
        public const int VAL_CONTENT_MODULE_ID_LENGTH = 8;
        //Client
        public const string VAL_CLIENT_ID_PREFIX = "CLI";
        public const int VAL_CLIENT_ID_LENGTH = 12;
        //Admin Role
        public const string VAL_ROLE_ID_PREFIX = "ROL";
        public const int VAL_ROLE_ID_LENGTH = 8;
        // User
        public const string VAL_USER_ID_PREFIX = "USR";
        //System Configuration
        public const string VAL_SSO_CONFIG_ID_PREFIX = "SSO";
        public const int VAL_SSO_CONFIG_ID_LENGTH = 8;
        //Layouts
        public const string VAL_LAYOUT_ID_PREFIX = "LAY";
        public const int VAL_LAYOUT_ID_LENGTH = 8;
        //Theme
        public const string VAL_THEME_ID_PREFIX = "THM";
        public const int VAL_THEME_ID_LENGTH = 8;
        //Attempt Id
        public const string VAL_ATTEMPT_ID_PREFIX = "ATM";
        public const int VAL_ATTEMPT_ID_LENGTH = 12;
        //Organization Level
        public const string VAL_ORGNIZATION_BASE_LEVEL_NAME = "RootNode";
        public const string VAL_ORGNIZATION_BASE_UNIT_NAME = "Organization";
        public const string VAL_ORGNIZATION_BASE_PARENT_UNIT_ID = "0";

        //Question Category
        public const string VAL_QUESTIONCATEGORY_ID_PREFIX = "QNC";
        public const int VAL_QUESTIONCATEGORY_ID_LENGTH = 8;

        //Question SubCategory
        public const string VAL_QUESTIONSUBCATEGORY_ID_PREFIX = "QNSC";
        public const int VAL_QUESTIONSUBCATEGORY_ID_LENGTH = 8;

        //Question Bank
        public const string VAL_QUESTIONBANK_ID_PREFIX = "QNB";
        public const int VAL_QUESTIONBANK_ID_LENGTH = 8;

        //Question Bank Options
        public const string VAL_QUESTIONBANKOPTIONS_ID_PREFIX = "QBO";
        public const int VAL_QUESTIONBANKOPTIONS_ID_LENGTH = 8;

        //Product  Category
        public const string VAL_PRODUCT_CATEGORY_ID_PREFIX = "PDC";
        public const int VAL_PRODUCT_CATEGORY_ID_LENGTH = 8;

        //Product  Category
        public const string VAL_PRODUCT_SUBCATEGORY_ID_PREFIX = "PDSC";
        public const int VAL_PRODUCT_SUBCATEGORY_ID_LENGTH = 8;

        //Product  Location
        public const string VAL_PRODUCT_LOCATION_ID_PREFIX = "PDL";
        public const int VAL_PRODUCT_LOCATION_ID_LENGTH = 8;

        //Reference Document
        public const string VAL_REF_DOCUMENT_ID_PREFIX = "RD";
        public const int VAL_REF_DOCUMENT_ID_LENGTH = 8;

        //Product 
        public const string VAL_PRODUCT_ID_PREFIX = "PDC";
        public const int VAL_PRODUCT_ID_LENGTH = 8;

        //Questionnaire
        public const string VAL_QUESTIONNAIRE_ID_PREFIX = "QNR";
        public const int VAL_QUESTIONNAIRE_ID_LENGTH = 8;

        //Assessment
        public const string VAL_ASSESSMENT_ID_PREFIX = "ASMT";
        public const int VAL_ASSESSMENT_ID_LENGTH = 8;

        public const string VAL_TASK_ID_PREFIX = "TSK";
        public const string VAL_REPORT_DEL_DASH_ID_PREFIX = "RDD";

        public const string VAL_ASSESMENT_QUESTION_ID_PREFIX = "ASSQ";
        public const int VAL_ASSESMENT_QUESTION_ID_LENGTH = 8;
        public const string VAL_USER_ASSESMENT_QUESTION_TRACKING_ID_PREFIX = "ASSQTRACK";
        public const int VAL_USER_ASSESMENT_QUESTION_TRACKING_ID_LENGTH = 8;

        //Asset Question Id
        public const string VAL_ASSET_QUESTION_ID_PREFIX = "AQU";
        public const int VAL_ASSET_QUESTION_ID_LENGTH = 8;



        //BlogPost
        public const string VAL_BLOG_POST_ID_PREFIX = "BPOS";
        public const int VAL_BLOG_POST_ID_LENGTH = 8;

        //BlogPostCategories
        public const string VAL_BLOG_POST_CATEGORY_ID_PREFIX = "BCAT";
        public const int VAL_BLOG_POST_CATEGORY_ID_LENGTH = 8;

        //BlogPostComments
        public const string VAL_BLOG_POST_COMMENT_ID_PREFIX = "BCOM";
        public const int VAL_BLOG_POST_COMMNET_ID_LENGTH = 8;

        //ForumCategories
        public const string VAL_FORUM_CATEGORY_ID_PREFIX = "FCAT";
        public const int VAL_FORUM_CATEGORY_ID_LENGTH = 8;

        //ForumSubCategories
        public const string VAL_FORUM_SUBCATEGORY_ID_PREFIX = "FSCAT";
        public const int VAL_FORUM_SUBCATEGORY_ID_LENGTH = 8;

        //ForumThread
        public const string VAL_FORUM_THREAD_ID_PREFIX = "FTHRD";
        public const int VAL_FORUM_THREAD_ID_LENGTH = 12;

        //ForumThreadPost
        public const string VAL_FORUM_POST_ID_PREFIX = "FPOST";
        public const int VAL_FORUM_POST_ID_LENGTH = 12;

        //Discount Coupon Code      
        public const string VAL_DISCOUNT_COUPON_ID_PREFIX = "DCC";
        public const int VAL_DISCOUNT_COUPON_ID_LENGTH = 8;


        //WEB SERVICE DETAILS
        public const string VAL_SERVICE_ID_PREFIX = "SERV";
        public const int VAL_SERVICE_ID_LENGTH = 8;

        //ParticipantCompletionRequest
        public const string VAL_REQUEST_ID_PREFIX = "PREQ";
        public const int VAL_REQUEST_ID_LENGTH = 8;

        //ParticipantDetails
        public const string VAL_PARTICIPANT_REQUEST_ID_PREFIX = "PARQ";
        public const int VAL_PARTICIPANT_REQUEST_ID_LENGTH = 8;

        //FeatureList
        public const string VAL_FEATURELIST_ID_PREFIX = "FL";
        public const int VAL_FEATURELIST_ID_LENGTH = 8;

        //Browser
        public const string VAL_BROWSER_ID_PREFIX = "BWS";
        public const int VAL_BROWSER_ID_LENGTH = 8;

        //Curriculam Section
        public const string VAL_CURRICULUM_SECTION_ID_PREFIX = "CSEC";
        public const int VAL_CURRICULUM_SECTION_ID_LENGTH = 8;

        //Merchant Info
        public const string VAL_PAYMENT_GATEWAY_ID_PREFIX = "PAYG";
        public const int VAL_PAYMENT_GATEWAY_ID_LENGTH = 8;

        //Document Library
        public const string VAL_DOCUMENT_FOLDER_ID_PREFIX = "DFO";
        public const int VAL_DOCUMENT_FOLDER_ID_LENGTH = 8;

        //Bookmark
        public const string VAL_BOOKMARK_ID_PREFIX = "BM";
        public const int VAL_BOOKMARK_ID_LENGTH = 8;

        //Message
        public const string VAL_Messages_ID_PREFIX = "MSG";
        public const int VAL_Messages_ID_LENGTH = 8;

        //MessageDetails
        public const string VAL_MessagesDetails_ID_PREFIX = "MD";
        public const int VAL_MessagesDetails_ID_LENGTH = 8;

        //MessageTemplate
        public const string VAL_MessagesTemplate_ID_PREFIX = "MT";
        public const int VAL_MessagesTemplate_ID_LENGTH = 8;

        //Activity Licenses
        public const string VAL_LICENSE_ID_PREFIX = "LIC";
        public const int VAL_LICENSE_ID_LENGTH = 8;

    }
    #endregion

    #region CustomGroup
    public class CustomGroup
    {
        //PARAMETERS
        public const string PARA_CSG_ID = "@CustomGroupId";
        //FIELDS
        public const string COL_CSG_ID = "CustomGroupId";
    }
    #endregion

    #region OrganizationLevel
    public class OrganizationLevel
    {
        //PROCEDURES        
        public const string PROC_GET_ORGANIZATION_LEVEL_MASTER_ID = "sproc_OrganizationLevelMaster_sel";
        public const string PROC_UPDATE_ORGANIZATION_LEVEL = "sproc_OrganizationLevelMaster_ups";
        public const string PROC_DELETE_ORGANIZATION_LEVEL = "sproc_OrganizationLevelMaster_delMultiple";
        public const string PROC_GET_ALL_ORGANIZATION_LEVELS = "sproc_OrganizationLevelMaster_LstAll";
        public const string PROC_GET_ALL_ORGANIZATION_UNITS = "sproc_OrganizationLevelUnits_LstAll";
        public const string PROC_CAA_ORGANIZATION_LEVEL = "sproc_OrganizationLevelMaster_CheckandCreate";
        public const string PROC_GET_ORGANIZATION_TREE_LIST = "sproc_get_orgtree_Lst";

        //PARAMETERS
        public const string PARA_LEVEL_ID = "@LevelId";
        public const string PARA_LEVEL_IDS = "@LevelIds";
        public const string PARA_LEVEL_NAME = "@LevelName";
        public const string PARA_LEVEL_ORDER = "@LevelOrder";
        public const string PARA_CLIENT_ID = "@ClientId";

        //FIELDS
        public const string COL_LEVEL_ID = "LevelId";
        public const string COL_LEVEL_NAME = "LevelName";
        public const string COL_LEVEL_ORDER = "LevelOrder";
        public const string COL_CLIENT_ID = "ClientId";
    }
    #endregion

    #region OrganizationLevelUnit
    public class OrganizationLevelUnit
    {
        //PROCEDURES        
        public const string PROC_GET_ORGANIZATION_LEVEL_UNIT_MASTER_ID = "sproc_OrganizationLevelUnitsMaster_sel";
        public const string PROC_UPDATE_ORGANIZATION_LEVEL_UNIT = "sproc_OrganizationLevelUnitsMaster_ups";
        public const string PROC_DELETE_ORGANIZATION_LEVEL_UNIT = "sproc_OrganizationLevelUnitsMaster_delMultiple";
        public const string PROC_GET_ALL_ORGANIZATION_LEVEL_UNITS = "sproc_OrganizationLevelUnitsMaster_LstAll";
        public const string PROC_GET_ALL_ORGANIZATION_LEVEL_UNITS_FOR_IMPORT = "sproc_OrganizationLevelUnitsMaster_LstAll_ForImport";
        public const string PROC_GET_ORG_LEVELUNIT_BYNAME = "sproc_OrganizationLevelUnitsMaster_selByName";
        public const string PROC_FIND_ALL_UNITS = "sproc_OrganizationLevelUnitsMaster_sel_search";
        public const string PROC_CAA_ORGANIZATION_UNIT = "sproc_OrganizationLevelUnitsMaster_CheckandCreate";
        public const string PROC_UPDATE_ORGANIZATION_LEVEL_UNIT_RESET = "sproc_OrganizationLevelUnitsMaster_ups_reset";

        //PARAMETERS
        public const string PARA_UNIT_ID = "@UnitId";
        public const string PARA_UNIT_IDS = "@UnitIds";
        public const string PARA_UNIT_NAME = "@UnitName";
        public const string PARA_UNIT_ORDER = "@SequenceOrder";
        public const string PARA_LEVEL_ID = "@LevelId";
        public const string PARA_UNIT_PARENT_ID = "@ParentUnitId";
        public const string PARA_UNIT_ISACTIVE = "@IsActive";
        public const string PARA_CLIENT_ID = "@ClientId";
        public const string PARA_ORGTREE_UNIT_ID = "@OrgTreeUnitId";
        public const string PARA_ORGTREE_PARENT_UNIT_ID = "@OrgTreeParentUnitId";

        //FIELDS
        public const string COL_UNIT_ID = "UnitId";
        public const string COL_UNIT_NAME = "UnitName";
        public const string COL_UNIT_ORDER = "SequenceOrder";
        public const string COL_LEVEL_ID = "LevelId";
        public const string COL_UNIT_PARENT_ID = "ParentUnitId";
        public const string COL_UNIT_CLIENT_ID = "ClientId";
        public const string COL_UNIT_ISACTIVE = "IsActive";
        public const string COL_ORGTREE_PARENT_UNIT_ID = "OrgTreeParentUnitId";
        public const string COL_ORGTREE_UNIT_ID = "OrgTreeUnitId";
        public const string COL_PARENT_UNITS = "ParentUnits";
        public const string COL_CHILD_UNITS = "ChildUnits";



    }
    #endregion

    #region AdminRoleFeature
    public class AdminRoleFeatures
    {
        //PROCEDURES
        public const string PROC_GET_ROLE_WISE_FEATURES = "sproc_AdminRoleFeatures_selByRole";
        public const string PROC_UPDATE_ROLE_FEATURE = "sproc_AdminRoleFeatures_ups";

        //PARAMETERS
        public const string PARA_FEATURE_ID = "@FeatureId";
        public const string PARA_CAN_VIEW = "@CanView";
        public const string PARA_CAN_ADD = "@CanAdd";
        public const string PARA_CAN_EDIT = "@CanEdit";
        public const string PARA_CAN_DELETE = "@CanDelete";
        public const string PARA_CAN_PRINT = "@CanPrint";
        public const string PARA_CAN_EXPORT = "@CanExport";
        public const string PARA_CAN_UPLOAD = "@CanUpload";
        public const string PARA_CAN_IMPORT = "@CanImport";
        public const string PARA_CAN_EMAIL = "@CanEmail";
        public const string PARA_CAN_COPY = "@CanCopy";
        public const string PARA_CAN_ACTIVATE = "@CanActivate";
        public const string PARA_CAN_DEACTIVATE = "@CanDeActivate";

        //FIELDS
        public const string COL_FEATURE_ID = "FeatureId";
        public const string COL_CAN_VIEW = "CanView";
        public const string COL_CAN_ADD = "CanAdd";
        public const string COL_CAN_EDIT = "CanEdit";
        public const string COL_CAN_DELETE = "CanDelete";
        public const string COL_CAN_PRINT = "CanPrint";
        public const string COL_CAN_EXPORT = "CanExport";
        public const string COL_CAN_UPLOAD = "CanUpload";
        public const string COL_CAN_IMPORT = "CanImport";
        public const string COL_CAN_EMAIL = "CanEmail";
        public const string COL_CAN_COPY = "CanCopy";
        public const string COL_CAN_ACTIVATE = "CanActivate";
        public const string COL_CAN_DEACTIVATE = "CanDeActivate";
    }
    #endregion

    #region AdminRole
    public class AdminRole
    {
        //PROCEDURES
        public const string PROC_GET_ROLE_MASTER_SEL_NAME = "sproc_AdminRoleMaster_sel_Name";
        public const string PROC_GET_ROLE_MASTER = "sproc_AdminRoleMaster_sel";
        public const string PROC_UPDATE_ROLE_MASTER = "sproc_AdminRoleMaster_ups";
        public const string PROC_DELETE_ROLE_MASTER = "sproc_AdminRoleMaster_del";
        public const string PROC_GET_ALL_ROLE_MASTER = "sproc_AdminRoleMaster_LstAll";
        public const string PROC_UPDATE_USER_ADMIN_ROLE = "sproc_UserAdminRoleScope_ups";
        public const string PROC_GET_ROLE_NAME = "sproc_AdminRoleMaster_sel_ByName";
        public const string PROC_GET_ALL_ROLE_MASTER_FOR_REPORT = "sproc_AdminRoleMaster_LstAll_ForReport";

        //PARAMETERS
        public const string PARA_ROLE_ID = "@RoleId";
        public const string PARA_ROLE_NAME = "@RoleName";
        public const string PARA_ROLE_DESC = "@RoleDescription";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_ROLE_TYPE = "@RoleType";

        //FIELDS
        public const string COL_ROLE_ID = "RoleId";
        public const string COL_ROLE_NAME = "RoleName";
        public const string COL_ROLE_DESC = "RoleDescription";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_ROLE_TYPE = "RoleType";
        public const string COL_USER_SCOPE = "UserScope";
        public const string COL_RULE_SCOPE = "RuleScope";
    }
    #endregion

    #region AdminFeatures
    public class AdminFeatures
    {
        //PROCEDURES
        public const string PROC_GET_FEATURE_MASTER = "sproc_AdminRoleFeaturesMaster_sel";
        public const string PROC_UPDATE_FEATURE_MASTER = "sproc_AdminRoleFeaturesMaster_ups";
        public const string PROC_GET_ALL_FEATURE_MASTER = "sproc_AdminRoleFeaturesMaster_LstAll";
        public const string PROC_UPDATE_ISVISIBLE_FEATURE_MASTER = "sproc_AdminRoleFeaturesMaster_ups_IsVisible";

        //PARAMETERS
        public const string PARA_IS_VISIBLE = "@IsVisible";
        public const string PARA_FEATURE_ID = "@FeatureId";
        public const string PARA_FEATURE_NAME = "@FeatureName";
        public const string PARA_FEATURE_DESC = "@FeatureDescription";
        public const string PARA_FEATURE_PARENT_ID = "@ParentFeatureId";

        //FIELDS
        public const string COL_FEATURE_ID = "FeatureId";
        public const string COL_FEATURE_NAME = "FeatureName";
        public const string COL_FEATURE_DESC = "FeatureDescription";
        public const string COL_FEATURE_PARENT_ID = "ParentFeatureId";

        public const string COL_IS_CB_VIEW_VISIBLE = "IsCBViewVisible";
        public const string COL_IS_CB_CAN_ADD_VISIBLE = "IsCBAddVisible";
        public const string COL_IS_CB_CAN_EDIT_VISIBLE = "IsCBEditVisible";
        public const string COL_IS_CB_CAN_DELETE_VISIBLE = "IsCBDeleteVisible";
        public const string COL_IS_CB_CAN_PRINT_VISIBLE = "IsCBPrintVisible";
        public const string COL_IS_CB_CAN_EXPORT_VISIBLE = "IsCBExportVisible";
        public const string COL_IS_CB_CAN_UPLOAD_VISIBLE = "IsCBUploadVisible";
        public const string COL_IS_CB_CAN_IMPORT_VISIBLE = "IsCBImportVisible";
        public const string COL_IS_CB_CAN_EMAIL_VISIBLE = "IsCBEmailVisible";
        public const string COL_IS_CB_CAN_COPY_VISIBLE = "IsCBCopyVisible";
        public const string COL_IS_CB_CAN_ACTIVATE_VISIBLE = "IsCBActivateVisible";
        public const string COL_IS_CB_CAN_DEACTIVATE_VISIBLE = "IsCBDeActivateVisible";
    }
    #endregion

    #region CustomFieldType
    public class CustomFieldType
    {
        //FIELDS
        public const string COL_TYPE_NAME = "TypeName";
    }
    #endregion

    #region CustomField
    internal class CustomField
    {
        //PROCEDURES
        public const string PROC_UPDATE_CUSTOM_FIELD = "sproc_CustomFieldMaster_ups";
        public const string PROC_DELETE_CUSTOM_FIELD = "sproc_CustomFieldMaster_del";
        public const string PROC_GET_CUSTOM_FIELD_DTLS = "sproc_CustomFieldMaster_LstDtls";
        public const string PROC_GET_CUSTOM_FIELD_BY_NAME = "sproc_CustomFieldMaster_selByName";
        public const string PROC_GET_CUSTOM_FIELD_DTLS_WITH_RANGE = "sproc_CustomFieldMaster_LstDtls_CustomFieldWithRange";
        public const string PROC_FIND_CUSTOM_FIELDS = "sproc_CustomFieldMaster_Lst_Search";

        //PARAMETERS
        public const string PARA_CUSTOM_FIELD_ID = "@CustomFieldId";
        public const string PARA_CUSTOM_FIELDS = "@CustomFields";
        public const string PARA_CUSTOM_FIELD_TYPE_ID = "@CustomFieldTypeId";
        public const string PARA_SORT_ORDER = "@SortOrder";
        public const string PARA_IS_MANDATORY = "@IsMandatory";
        public const string PARA_IS_ACTIVE = "@IsActive";

        //FIELDS
        public const string COL_CUSTOM_FIELD_ID = "CustomFieldId";
        public const string COL_CUSTOM_FIELD_TYPE_ID = "CustomFieldTypeId";
        public const string COL_SORT_ORDER = "SortOrder";
        public const string COL_IS_MANDATORY = "IsMandatory";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_IS_USED = "IsUsed";
    }
    #endregion

    #region CustomFieldLanguage
    internal class CustomFieldLanguage
    {
        //PROCEDURES
        public const string PROC_GET_CUSTOM_FIELD_LANGUAGE_LST = "sproc_CustomFieldLanguage_Lst";
        public const string PROC_UPDATE_CUSTOM_FIELD_LANGUAGE = "sproc_CustomFieldLanguage_ups";

        //PARAMETERS
        public const string PARA_CF_DISPLAY_TEXT = "@CustomFieldDisplayText";
        public const string PARA_CFL_DESCRIPTION = "@Description";

        // FOR ONLY SEARH
        public const string PARA_CF_NAME = "@CustomFieldName";

        //FIELDS
        public const string COL_CF_DISPLAY_TEXT = "CustomFieldDisplayText";
        public const string COL_CFL_DESCRIPTION = "Description";
    }
    #endregion

    #region CFUIControlType
    internal class CFUIControlType
    {
        //PROCEDURES
        public const string PROC_GET_CUSTOM_FIELD_TYPE = "sproc_CFUIControlTypeMaster_sel";
        public const string PROC_GET_ALL_CUSTOM_FIELD_TYPES = "sproc_CFUIControlTypeMaster_LstAll";

        //PARAMETERS
        public const string PARA_CUSTOM_FIELD_TYPE_ID = "@CustomFieldTypeId";

        //FIELDS
        public const string COL_CUSTOM_FIELD_TYPE_ID = "CustomFieldTypeId";
        public const string COL_CUSTOM_FIELD_TYPE_NAME = "TypeName";
        public const string COL_CF_DATA_TYPE = "CustomFieldDataType";
    }
    #endregion

    #region UserCustomFieldValue
    internal class UserCustomFieldValue
    {
        //PROCEDURES
        public const string PROC_UPDATE_CUSTOM_FIELD_VALUE = "sproc_UserCustomFieldValue_ups";
        public const string PROC_DELETE_NOT_IN_CFVALUES = "sproc_UserCustomFieldValue_delMultiple";

        //PARAMETERS
        public const string PARA_CUSTOM_FIELD_ITEM_ID = "@CustomFieldItemId";
        public const string PARA_ENTERED_VALUE = "@EnteredValue";

        //FIELDS
        public const string COL_CUSTOM_FIELD_ITEM_ID = "CustomFieldItemId";
        public const string COL_ENTERED_VALUE = "EnteredValue";
    }
    #endregion

    #region  CustomFieldItem
    internal class CustomFieldItem
    {
        //PROCEDURE
        public const string PROC_GET_CUSTOM_FIELD_ITEM = "sproc_CustomFieldItemsMaster_sel";
        public const string PROC_GET_CUSTOM_FIELD_ITEM_BY_NAME = "sproc_CustomFieldItemsMaster_selByName";
        public const string PROC_GET_ALL_CUSTOM_FIELD_ITEM = "sproc_CustomFieldItemsMaster_LstAll";
        public const string PROC_UPDATE_CUSTOM_FIELD_ITEM = "sproc_CustomFieldItemsMaster_ups";
        public const string PROC_DELETE_CUSTOM_FIELD_ITEM = "sproc_CustomFieldItemsMaster_del";
        public const string PROC_GET_ALL_CUSTOM_FIELD_ITEM_BY_CF = "sproc_CustomFieldItemsMaster_LstByCF";
        public const string PROC_GET_CUSTOM_FIELD_ITEMS_WITH_RANGE = "sproc_CustomFieldItemsMaster_LstByCF_WithRange";
        public const string PROC_FIND_CUSTOM_FIELD_ITEMS = "sproc_CustomFieldItemsMaster_sel_search";

        //PARAMETERS
        public const string PARA_CUSTOM_FIELD_ITEM_ID = "@CustomFieldItemId";
        public const string PARA_IS_DEFAULT = "@IsDefault";

        //FIELDS
        public const string COL_CUSTOM_FIELD_ITEM_ID = "CustomFieldItemId";
        public const string COL_IS_DEFAULT = "IsDefault";
        public const string COL_IS_USED = "IsUsed";
    }
    #endregion

    #region CustomFieldItemLanguage
    internal class CustomFieldItemLanguage
    {
        //PROCEDURE
        public const string PROC_GET_CUSTOM_FIELD_ITEM_LANG_LST = "sproc_CustomFieldItemLanguage_Lst";
        public const string PROC_UPDATE_CUSTOM_FIELD_ITEM_LANG = "sproc_CustomFieldItemLanguage_ups";

        //PARAMETERS
        public const string PARA_CUSTOM_FIELD_ITEM_DISPLAY_TEXT = "@CustomFieldItemDisplayText";

        // For search purpose only.
        public const string PARA_CUSTOM_FIELD_ITEM_NAME = "@CustomFieldItemName";
        //FIELDS
        public const string COL_CUSTOM_FIELD_ITEM_DISPLAY_TEXT = "CustomFieldItemDisplayText";
    }
    #endregion

    #region LookUp
    internal class Lookup
    {
        //Procedure 
        public const string PROC_GET_LOOKUPS = "sproc_LookupMaster_LstAll";
        public const string PROC_UPDATE_LOOKUP = "sproc_LookupMaster_ups";
        public const string PROC_GET_LOOKUP_TYPE = "sproc_LookupTypeMaster_sel";
        public const string PROC_GET_LOOKUP = "sproc_LookupMaster_sel";
        public const string PROC_GET_LOOKUPTEXT = "sproc_GetLookupText";

        //PARAMETERS
        public const string PARA_LOOKUP_TYPE = "@LookupType";
        public const string PARA_LOOKUP_ID = "@LookupId";
        public const string PARA_LOOKUP_TEXT = "@LookupText";
        public const string PARA_LOOKUP_VALUE = "@LookupValue";
        public const string PARA_LOOKUP_TYPE_ID = "@LookupTypeId";
        public const string PARA_IS_DEFAULT = "@IsDefault";

        //FIELDS
        public const string COL_LOOKUP_ID = "LookupId";
        public const string COL_LOOKUP_TEXT = "LookupText";
        public const string COL_LOOKUP_VALUE = "LookupValue";
        public const string COL_LOOKUP_TYPE_ID = "LookupTypeId";
        public const string COL_LOOKUP_TYPE = "LookupType";
        public const string COL_LOOKUP_LANGUAGEID = "LanguageId";
        public const string COL_IS_DEFAULT = "IsDefault";
    }
    #endregion

    #region ImportDefinition
    internal class ImportDefinition
    {
        //Procedure 
        public const string PROC_UPDATE_IMPORT_DEF = "sproc_ImportDefinitionMaster_ups";
        public const string PROC_GET_IMPORT_DEF = "sproc_ImportDefinitionMaster_sel";
        public const string PROC_GET_ALL_IMPORT_DEF = "sproc_ImportDefinitionMaster_LstAll";
        public const string PROC_GET_REPORT_IMPORT_DEF = "sproc_ReportingTool_ImportDefinitionMaster_LstAll";

        public const string PROC_GET_ACTIVATE_IMPORT_DEF = "sproc_ImportDefinitionMaster_CSVActivate";
        public const string PROC_GET_DEACTIVATE_IMPORT_DEF = "sproc_ImportDefinitionMaster_CSVDeactivate";
        public const string PROC_GET_CHANGED_ID_IMPORT_DEF = "sproc_ImportDefinitionMaster_CSVChangeId";
        public const string PROC_GET_CURRENT_IMPORT_DEF = "sproc_ImportDefinitionMaster_CurrentLstAll";


        //PARAMETERS
        public const string PARA_IMPORT_DEF_ID = "@ImportDefinitionID";
        public const string PARA_FIELD_NAME = "@FieldName";
        public const string PARA_MIN_LENGTH = "@MinLength";
        public const string PARA_MAX_LENGTH = "@MaxLength";
        public const string PARA_FIELD_DATA_TYPE = "@FieldDataType";
        public const string PARA_ALLOW_BLANKS = "@AllowBlanks";
        public const string PARA_ERROR_LEVEL = "@ErrorLevel";
        public const string PARA_INCLUDE = "@Include";

        public const string PARA_IS_DEFAULT = "@IsDefault";
        public const string PARA_DEFAULT_VALUE = "@DefaultValue";

        //FIELDS
        public const string COL_IMPORT_DEF_ID = "ImportDefinitionID";
        public const string COL_FIELD_NAME = "FieldName";
        public const string COL_MIN_LENGTH = "MinLength";
        public const string COL_MAX_LENGTH = "MaxLength";
        public const string COL_FIELD_DATA_TYPE = "FieldDataType";
        public const string COL_ALLOW_BLANKS = "AllowBlanks";
        public const string COL_ERROR_LEVEL = "ErrorLevel";
        public const string COL_INCLUDE = "Include";
        public const string COL_IS_MANDATORY = "IsMandatory";
        public const string COL_FIELD_TYPE = "FieldType";
        public const string COL_MAX_LENGHT_IN_DB = "MaxLengthinDB";
        public const string COL_IS_DEFAULT = "IsDefault";
        public const string COL_DEFAULT_VALUE = "DefaultValue";

    }
    #endregion

    #region UserPassCode
    internal class UserPassCode
    {
        //Procedure 
        public const string PROC_GET_PASSCODE = "sproc_PassCodeMaster_sel";
        public const string PROC_GET_ALL_PASSCODE = "sproc_PassCodeMaster_LstAll";
        public const string PROC_GET_USERPASSCODE = "sproc_UserPassCodeTracking_sel";
        public const string PROC_UPDATE_USERPASSCODE = "sproc_UserPassCodeTracking_ups";

        //PARAMETERS
        public const string PARA_PASS_CODE = "@Passcode";
        public const string PARA_PASS_ACTUALUSAGE = "@ActualUsage";
        public const string PARA_AUTH_CODE = "@AuthCode";
        public const string PARA_NO_OF_MONTHS = "@NoOfMonths";
        public const string PARA_MAXIMUM_USAGE = "@MaximumUsage";
        public const string PARA_IS_CONSUMED = "@Isconsumed";

        //FIELDS
        public const string COL_PASS_CODE = "PassCode";
        public const string COL_MAXIMUM_USAGE = "MaximumUsage";
        public const string COL_ACTUAL_USAGE = "ActualUsage";
        public const string COL_NO_OF_MONTHS = "NoOfMonths";
        public const string COL_EXPIRY_DATE = "ExpiryDate";
        public const string COL_PASS_CODE_INSTANCE_ID = "PassCodeInstanceId";
        public const string COL_STATUS = "status";

    }
    #endregion

    #region ImportHistory
    internal class ImportHistory
    {
        //Procedure 
        public const string PROC_GET_IMPORT_HISTORY = "sproc_ImportHistory_sel";
        public const string PROC_GET_ALL_IMPORT_HISTORY = "sproc_ImportHistory_LstAll";
        public const string PROC_GET_ALL_IMPORT_HISTORY_ASSIGNMENT = "sproc_ImportHistory_LstAssignment";
        public const string PROC_GET_ALL_IMPORT_HISTORY_QUESTIONS = "sproc_ImportHistory_LstQuestions";

        public const string PROC_UPDATE_IMPORT_HISTORY = "sproc_ImportHistory_ups";
        public const string PROC_UPDATE_IMPORT_HISTORY_BULK_ASSIGNMENT = "sproc_ImportHistory_ups_BulkAssignment";
        public const string PROC_UPDATE_IMPORT_HISTORY_DETAILS = "sproc_ImportHistory_ups_dtls";
        public const string PROC_DELETE_SELECTED_IMPORT_HISTORY = "sproc_ImportHistory_delMultiple";

        //PARAMETERS
        public const string PARA_IMPORT_ID = "@ImportId";
        public const string PARA_FILE_NAME = "@FileName";
        public const string PARA_FILE_PATH = "@FilePath";
        public const string PARA_IMPORT_TYPE = "@ImportType";
        public const string PARA_IMPORT_ACTION = "@ImportAction";
        public const string PARA_IMPORT_LOG = "@ImportLog";
        public const string PARA_STATUS = "@Status";
        public const string PARA_IMPORT_BY_ID = "@ImportByID";
        public const string PARA_IMPORT_DATE_FROM = "@ImportDateFrom";
        public const string PARA_IMPORT_DATE_TO = "@ImportDateTo";

        //FIELDS
        public const string COL_IMPORT_ID = "ImportId";
        public const string COL_FILE_NAME = "FileName";
        public const string COL_FILE_PATH = "FilePath";
        public const string COL_IMPORT_TYPE = "ImportType";
        public const string COL_IMPORT_ACTION = "ImportAction";
        public const string COL_IMPORT_LOG = "ImportLog";
        public const string COL_IMPORT_DATE = "ImportDate";
        public const string COL_STATUS = "Status";
        public const string COL_IMPORT_BY_ID = "ImportByID";
        public const string COL_CLIENT_ID = "ClientID";
        public const string COL_ADMINISTRATOR_NAME = "AdministratorName";
    }
    #endregion

    #region MenuItems
    internal class MenuItems
    {
        //Procedure 
        public const string PROC_GET_MENU_ITEMS = "sproc_MenuItemsMaster_sel";
        public const string PROC_GET_ALL_MENU_ITEMS = "sproc_MenuItemsMaster_LstAll";
        public const string PROC_GET_ALL_MENU_ITEMS_WithGroup = "sproc_MenuItemsMasterWithGroup_LstAll";
        public const string PROC_UPDATE_MENU_ITEM = "sproc_MenuItemsMaster_ups";
        public const string PROC_UPDATE_STATUS = "sproc_MenutItem_Status";

        //PARAMETERS
        public const string PARA_MENU_LINK_ID = "@MenuLinkId";
        public const string PARA_FEATURE_ID = "@FeatureId";
        public const string PARA_MENU_ITEM_ENG_NAME = "@MenuItemName";
        public const string PARA_PARENT_MENU_ID = "@ParentMenuID";
        public const string PARA_PAGE_FILE_URL = "@PageFileURL";

        //FIELDS
        public const string COL_MENU_LINK_ID = "MenuLinkId";
        public const string COL_FEATURE_ID = "FeatureId";
        public const string COL_MENU_ITEM_ENG_NAME = "MenuItemName";
        public const string COL_PARENT_MENU_ID = "ParentMenuID";
        public const string COL_PAGE_FILE_URL = "PageFileURL";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_LANGUAGE_ID = "LanguageId";

        // For Group Menu Item
        public const string COL_GROUP_MENU_LINK_ID = "GroupMenuLinkId";
        public const string COL_GROUP_MENU_ITEM_ENG_NAME = "GroupMenuItemName";
        public const string COL_GROUP_MENU_LANGUAGE_ID = "GroupLanguageID";
        public const string COL_GROUP_MENU_DISPLAY_ORDER = "GroupDisplayOrder";
        public const string COL_GROUP_MENU_CSS_NAME = "GroupMenuCSSName";
        public const string COL_GROUP_MENU_CSS_NAME_STYLE = "GroupMenuCSSNameStyle";


    }
    #endregion

    #region Announcement
    internal class Announcement
    {
        //Procedure 
        public const string PROC_GET_ALL_ANNOUNCEMENTS = "sproc_Announcements_LstAll";
        public const string PROC_GET_ALL_ANNOUNCEMENTS_ADMIN = "sproc_Announcements_Lst";
        public const string PROC_GET_ALL_ANNOUNCEMENTS_LEARNER = "sproc_Announcements_LstAll_Learner";
        public const string PROC_UPDATE_ANNOUNCEMENT = "sproc_Announcements_ups";
        public const string PROC_UPDATE_ANNOUNCEMENT_LANGUAGE = "sproc_Announcements_language_ups";
        public const string PROC_DELETE_ANNOUNCEMENT = "sproc_Announcements_del";
        public const string PROC_DELETE_ANNOUNCEMENT_LANGUAGE = "sproc_Announcements_del_Language";

        //PARAMETERS
        public const string PARA_ANNOUNCEMENT_ID = "@AnnouncementId";
        public const string PARA_START_DATE = "@StartDate";
        public const string PARA_EXPIRY_DATE = "@ExpiryDate";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_IS_FOR_LEARNER = "@IsForLearner";
        public const string PARA_TITLE = "@Title";
        public const string PARA_DESCRIPTION = "@Description";
        public const string PARA_URL = "@Url";
        //FIELDS
        public const string COL_ANNOUNCEMENT_ID = "AnnouncementId";
        public const string COL_START_DATE = "StartDate";
        public const string COL_EXPIRY_DATE = "ExpiryDate";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_TITLE = "Title";
        public const string COL_DESCRIPTION = "Description";
        public const string COL_URL = "Url";


    }
    #endregion

    #region ReportPerformanceTracking
    internal class ReportPerformanceTracking
    {
        //Procedure 
        public const string PROC_ADD_ReportPerformanceTracking = "sproc_ReportPerformanceTraking_ups";

        //PARAMETERS
        public const string PARA_USER_ID = "@SystemUserGuid ";
        public const string PARA_REPORT_NAME = "@ReportName";

    }
    #endregion

    #region FeedBack
    internal class FeedBack
    {
        //Procedure 
        public const string PROC_UPDATE_FEEDBACK = "sproc_FeedBack_ups";

        //PARAMETERS
        public const string PARA_FEEDBACK_ID = "@FeedBackId";
        public const string PARA_NAME = "@Name";
        public const string PARA_EMAIL = "@Email";
        public const string PARA_COMMENTS = "@Comments";
    }
    #endregion

    #region SystemMessage
    internal class SystemMessage
    {
        //Procedure 
        public const string PROC_GET_SYS_MESSAGE = "sproc_SystemMessageMaster_sel";
        public const string PROC_GET_SYS_MESSAGE_SINGLE = "sproc_SystemMessageMaster_sel_single";
        public const string PROC_UPDATE_MESSAGE = "sproc_SystemMessageMaster_ups";

        //PARAMETERS
        public const string PARA_MESSAGE_ID = "@MessageId";
        public const string PARA_MESSAGE_TEXT = "@MessageText";
        public const string PARA_MESSAGE_TYPE = "@MessageType";
        public const string PARA_MESSAGE_DESC = "@MessageDescription";
        public const string PARA_MESSAGE_FOR = "@MessageFor";
        //FIELDS
        public const string COL_MESSAGE_ID = "MessageId";
        public const string COL_MESSAGE_TEXT = "MessageText";
        public const string COL_MESSAGE_DESC = "MessageDescription";
        public const string COL_MESSAGE_TYPE = "MessageType";
        public const string COL_MESSAGE_FOR = "MessageFor";


    }
    #endregion

    #region Region VIew
    internal class RegionView
    {
        //Procedure 
        public const string PROC_GET_REGION_VIEW = "sproc_RegionViewMaster_sel";
        public const string PROC_GET_REGION_VIEW_BY_NAME = "sproc_RegionViewMaster_selByName";
        public const string PROC_GET_ALL_REGION_VIEW = "sproc_RegionViewMaster_LstAll";
        public const string PROC_FIND_REGION_VIEW = "sproc_RegionViewMaster_sel_Search";
        public const string PROC_UPDATE_REGION_VIEW = "sproc_RegionViewMaster_ups";
        public const string PROC_DELETE_REGION_VIEW = "sproc_RegionViewMaster_del";

        //PARAMETERS
        public const string PARA_REGION_VIEW_ID = "@RegionViewId";
        public const string PARA_REGION_VIEW_NAME = "@RegionViewName";
        public const string PARA_REGION_VIEW_DESC = "@RegionViewDescription";
        public const string PARA_RULE_ID = "@RuleId";
        //FIELDS
        public const string COL_REGION_VIEW_ID = "RegionViewId";
        public const string COL_REGION_VIEW_NAME = "RegionViewName";
        public const string COL_REGION_VIEW_DESC = "RegionViewDescription";
        public const string COL_RULE_ID = "RuleId";
        public const string COL_CLIENT_ID = "ClientID";

    }
    #endregion

    #region Asset Library
    internal class AssetLibrary
    {
        //Procedure         
        public const string PROC_GET_ASSET_LIB_CHILDREN_COUNT = "sproc_AssetLibraryMaster_ChildrenCount";
        public const string PROC_GET_ASSET_LIBRARY = "sproc_AssetLibraryMaster_sel";
        public const string PROC_GET_ALL_ASSET_LIBRARY = "sproc_AssetLibraryMaster_LstAll";
        public const string PROC_UPDATE_ASSET_LIBRARY = "sproc_AssetLibraryMaster_ups";
        public const string PROC_DELETE_CHILD_ASSET_LIBRARY = "sproc_AssetLibraryMaster_DelChildren";

        //PARAMETERS        
        public const string PARA_ASSET_FOLDER_ID = "@AssetFolderId";
        public const string PARA_ASSET_FOLDER_NAME = "@AssetFolderName";
        public const string PARA_ASSET_FOLDER_DESC = "@AssetFolderDescription";
        public const string PARA_PARENT_FOLDER_ID = "@ParentFolderId";
        public const string PARA_EMAIL_ID_STRING = "@EmailIDString";
        public const string PARA_IS_VISIBLE = "@IsVisible";
        public const string PARA_RELATIVE_PATH = "@RelativePath";
        public const string PARA_CLIENT_ID = "@ClientID";
        public const string PARA_CREATED_BY_ID = "@CreatedById";
        //FIELDS
        public const string COL_ASSET_FOLDER_ID = "AssetFolderId";
        public const string COL_ASSET_FOLDER_NAME = "AssetFolderName";
        public const string COL_ASSET_FOLDER_DESC = "AssetFolderDescription";
        public const string COL_PARENT_FOLDER_ID = "ParentFolderId";
        public const string COL_EMAIL_ID_STRING = "EmailIDString";
        public const string COL_IS_VISIBLE = "IsVisible";
        public const string COL_RELATIVE_PATH = "RelativePath";
        public const string COL_CLIENT_ID = "ClientId";
        public const string COL_CREATED_BY_ID = "CreatedById";
    }
    #endregion

    #region Asset
    public class Asset
    {
        //Procedure
        public const string PROC_GET_ASSET_RELATIVE_PATH = "sproc_AssetMaster_sel_RelativePath";
        public const string PROC_GET_ASSET = "sproc_AssetMaster_sel";
        public const string PROC_GET_ALL_ASSET = "sproc_AssetMaster_LstAll";
        public const string PROC_UPDATE_ASSET = "sproc_AssetMaster_ups";
        public const string PROC_UPDATE_ASSET_LANGUAGE = "sproc_AssetMaster_ups_Language";
        public const string PROC_DELETE_ASSET = "sproc_AssetMaster_del";
        public const string PROC_GET_ASSETS_LANGUAGES = "sproc_AssetLanguage_sel_List";
        public const string PROC_DELETE_ASSETLANGUAGE = "sproc_AssetLanguageMaster_del";

        //PARAMETERS
        public const string PARA_ASSET_ID = "@AssetId";
        public const string PARA_ASSET_NAME = "@AssetName";
        public const string PARA_ASSET_DESCRIPTION = "@AssetDescription";
        public const string PARA_ASSET_KEYWORDS = "@AssetKeywords";
        public const string PARA_ASSET_FOLDER_ID = "@AssetFolderId";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_ASSET_FILE_NAME = "@AssetFileName";
        public const string PARA_ASSET_FILE_TYPE = "@AssetFileType";
        public const string PARA_RELATIVE_PATH = "@RelativePath";
        public const string PARA_IS_PRINT_CERTIFICATE = "@IsPrintCertificate";

        //FIELDS
        public const string COL_ASSET_ID = "AssetId";
        public const string COL_ASSET_NAME = "AssetName";
        public const string COL_ASSET_DESCRIPTION = "AssetDescription";
        public const string COL_ASSET_KEYWORDS = "AssetKeywords";
        public const string COL_ASSET_FOLDER_ID = "AssetFolderId";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_ASSET_FILE_NAME = "AssetFileName";
        public const string COL_ASSET_FILE_TYPE = "AssetFileType";
        public const string COL_RELATIVE_PATH = "RelativePath";
        public const string COL_CLIENT_ID = "ClientId";
        public const string COL_IS_PRINT_CERTIFICATE = "IsPrintCertificate";
        public const string COL_IS_ASSIGNED = "IsAssigned";
    }
    #endregion

    #region Policy
    internal class Policy
    {
        //Procedure
        public const string PROC_GET_POLICY = "sproc_PolicyMaster_sel";
        public const string PROC_GET_POLICY_FOR_LEARNER = "sproc_PolicyMaster_sel_Learner";
        public const string PROC_GET_ALL_POLICY = "sproc_PolicyMaster_LstAll";
        public const string PROC_UPDATE_POLICY = "sproc_PolicyMaster_ups";
        public const string PROC_UPDATE_POLICY_STATUS = "sproc_PolicyMaster_ups_IsActive";
        public const string PROC_DELETE_POLICY = "sproc_PolicyMaster_del";
        public const string PROC_GET_POLICY_LANGUAGES = "sproc_PolicyLanguage_sel_List";
        public const string PROC_UPDATE_POLICY_LANGUAGE = "sproc_PolicyMaster_ups_Language";
        public const string PROC_DELETE_POLICYLANGUAGE = "sproc_PolicyLanguageMaster_del";

        //PARAMETERS
        public const string PARA_POLICY_ID = "@PolicyId";
        public const string PARA_POLICY_NAME = "@PolicyName";
        public const string PARA_POLICY_FOLDER_ID = "@PolicyFolderId";
        public const string PARA_POLICY_DESCRIPTION = "@PolicyDescription";
        public const string PARA_POLICY_KEYWORDS = "@PolicyKeywords";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_POLICY_FILE_NAME_LINK = "@PolicyFileNameLink";
        public const string PARA_POLICY_FILE_TYPE = "@PolicyFileType";
        public const string PARA_IS_LINK = "@IsLink";
        public const string PARA_IS_SECURED = "@IsSecured";
        public const string PARA_RELATIVE_PATH = "@RelativePath";
        public const string PARA_IS_PRINT_CERTIFICATE = "@IsPrintCertificate";

        //FIELDS
        public const string COL_POLICY_ID = "PolicyId";
        public const string COL_POLICY_NAME = "PolicyName";
        public const string COL_POLICY_FOLDER_ID = "PolicyFolderId";
        public const string COL_POLICY_DESCRIPTION = "PolicyDescription";
        public const string COL_POLICY_KEYWORDS = "PolicyKeywords";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_IS_LINK = "IsLink";
        public const string COL_IS_SECURED = "IsSecured";
        public const string COL_POLICY_FILE_NAME_LINK = "PolicyFileNameLink";
        public const string COL_POLICY_FILE_TYPE = "PolicyFileType";
        public const string COL_RELATIVE_PATH = "RelativePath";
        public const string COL_CLIENT_ID = "ClientId";
        public const string COL_IS_PRINT_CERTIFICATE = "IsPrintCertificate";
    }
    #endregion

    #region Policy Library
    internal class PolicyLibrary
    {
        //Procedure         
        public const string PROC_GET_POLICY_LIBRARY = "sproc_PolicyLibraryMaster_sel";
        public const string PROC_GET_ALL_POLICY_LIBRARY = "sproc_PolicyLibraryMaster_LstAll";
        public const string PROC_GET_POLICY_LIB_CHILDREN_COUNT = "sproc_PolicyLibraryMaster_ChildrenCount";
        public const string PROC_UPDATE_POLICY_LIBRARY = "sproc_PolicyLibraryMaster_ups";
        public const string PROC_DELETE_POLICY_LIBRARY = "sproc_PolicyLibraryMaster_DelChildren";

        //PARAMETERS        
        public const string PARA_POLICY_FOLDER_ID = "@PolicyFolderId";
        public const string PARA_POLICY_FOLDER_NAME = "@PolicyFolderName";
        public const string PARA_POLICY_FOLDER_DESCRIPTION = "@PolicyFolderDescription";
        public const string PARA_PARENT_FOLDER_ID = "@ParentFolderId";
        public const string PARA_EMAIL_ID_STRING = "@EmailIDString";
        public const string PARA_IS_VISIBLE = "@IsVisible";
        public const string PARA_RELATIVE_PATH = "@RelativePath";
        public const string PARA_CREATED_BY_ID = "@CreatedById";
        //FIELDS
        public const string COL_POLICY_FOLDER_ID = "PolicyFolderId";
        public const string COL_POLICY_FOLDER_NAME = "PolicyFolderName";
        public const string COL_POLICY_FOLDER_DESCRIPTION = "PolicyFolderDescription";
        public const string COL_PARENT_FOLDER_ID = "ParentFolderId";
        public const string COL_EMAIL_ID_STRING = "EmailIDString";
        public const string COL_IS_VISIBLE = "IsVisible";
        public const string COL_RELATIVE_PATH = "RelativePath";
        public const string COL_CLIENT_ID = "ClientId";
        public const string COL_CREATED_BY_ID = "CreatedById";

    }
    #endregion

    #region GroupRule
    internal class GroupRule
    {
        //Procedure 
        public const string PROC_GET_RULE = "sproc_RuleMaster_sel";
        public const string PROC_GET_RULE_BY_NAME = "sproc_RuleMaster_sel_ByName";
        public const string PROC_GET_RULE_BY_RULE_PARENTID = "sproc_RuleMaster_sel_ByParentId";
        public const string PROC_GET_RULE_FOR_DISTRIBUTIONLIST = "sproc_RuleMaster_LstAll_For_DistributionList";
        public const string PROC_GET_RULE_ID_BY_NAME = "sproc_RuleMaster_GetID_ByName";
        public const string PROC_GET_ALL_RULES = "sproc_RuleMaster_LstAll";
        public const string PROC_UPDATE_RULE = "sproc_RuleMaster_ups";
        public const string PROC_UPDATE_RULE_STATUS = "sproc_RuleMaster_ups_Status";
        public const string PROC_DELETE_RULE = "sproc_RuleMaster_del";
        public const string PROC_RULE_ADDEDIT_IMPACT = "sproc_RuleAddEditImpacts";
        public const string PROC_CREATE_RULE_QUERY_TEXT = "sproc_GetRuleQueryText";

        //PARAMETERS
        public const string PARA_RULE_ID = "@RuleId";
        public const string PARA_RULE_NAME = "@RuleName";
        public const string PARA_RULE_DESC = "@RuleDescription";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_IS_FOR_DISTRIBUTION_LIST = "@IsForDistributionList";
        public const string PARA_RULE_PARENT_ID = "@RuleParentId";
        public const string PARA_CREATED_BY_ID = "@CreatedByID";

        //FIELDS
        public const string COL_RULE_ID = "RuleId";
        public const string COL_RULE_NAME = "RuleName";
        public const string COL_RULE_DESC = "RuleDescription";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_IS_USED = "IsUsed";
        public const string COL_IS_FOR_DISTRIBUTION_LIST = "IsForDistributionList";
        public const string COL_RULE_PARENT_ID = "RuleParentId";
        public const string COL_CREATED_BY_ID = "CreatedByID";
    }
    #endregion

    #region RuleParameters
    internal class RuleParameters
    {
        //Procedure 
        public const string PROC_UPDATE_RULE_PARA = "sproc_RuleParameters_ups";
        public const string PROC_DEL_MULTI_RULE_PARA = "sproc_RuleParameters_delMultiple";

        //PARAMETERS
        public const string PARA_PARAMETER_ID = "@ParameterId";
        public const string PARA_PARA_NAME = "@ParameterName";
        public const string PARA_LEFT_COND_ID = "@LeftConditionID";
        public const string PARA_LEFT_COND_VALUE = "@LeftConditionValue";
        public const string PARA_CONDITION = "@Condition";
        public const string PARA_RIGHT_COND_ID = "@RightConditionId";
        public const string PARA_CONDITION_ID = "@ConditionId";
        public const string PARA_RIGHT_COND_VALUE = "@RightConditionValue";
        public const string PARA_NEXT_CONDITION = "@NextCondition";
        public const string PARA_PARA_FIELD_TYPE = "@ParameterFieldType";
        public const string PARA_GROUP_TYPE = "@GroupType";

        //FIELDS
        public const string COL_PARAMETER_ID = "ParameterId";
        public const string COL_PARA_NAME = "ParameterName";
        public const string COL_LEFT_COND_ID = "LeftConditionID";
        public const string COL_LEFT_COND_VALUE = "LeftConditionValue";
        public const string COL_CONDITION = "Condition";
        public const string COL_CONDITION_ID = "ConditionId";
        public const string COL_RIGHT_COND_ID = "RightConditionId";
        public const string COL_RIGHT_COND_VALUE = "RightConditionValue";
        public const string COL_NEXT_CONDITION = "NextCondition";
        public const string COL_PARA_FIELD_TYPE = "ParameterFieldType";
        public const string COL_GROUP_TYPE = "GroupType";
    }
    #endregion

    #region RuleParameterGroup
    internal class RuleParameterGroup
    {

        //FIELDS
        public const string COL_PARAMETER_GROUP_ID = "ParameterGroupId";
        public const string COL_PARA_GROUP_NAME = "ParameterGroupName";
        public const string COL_SORT_ORDER = "SortOrder";
        //Para
        public const string PARA_PARAMETER_GROUP_ID = "@ParameterGroupId";
        public const string PARA_PARA_GROUP_NAME = "@ParameterGroupName";
        public const string PARA_SORT_ORDER = "@SortOrder";
        //PROC    
        public const string PROC_DEL_MULTI_RULE_PARA_GRP = "sproc_RuleParameterGroup_delMultiple";
        public const string PROC_UPS_RULE_PARA_GRP = "sproc_RuleParameterGroup_ups";

    }
    #endregion

    #region ReportConfig
    internal class ReportConfig
    {
        //Procedure 
        public const string PROC_GET_REPORT_CONFIG = "sproc_ReportConfig_sel";

        //PARAMETERS
        public const string PARA_FEATURE_ID = "@FeatureId";
        public const string PARA_REPORT_NAME = "@ReportName";
        public const string PARA_COLUMN_DATA_TYPES = "@ColumnDataTypes";
        public const string PARA_COLUMNS = "@Columns";
        public const string PARA_COLUMNSHT = "@ColumnsHT";
        public const string PARA_COLUMN_WIDTH = "@ColumnWidth";
        public const string PARA_ALIGN = "@Align";
        public const string PARA_REPORT_WIDTH = "@ReportWidth";

        //FIELDS
        public const string COL_FEATURE_ID = "FeatureId";
        public const string COL_REPORT_NAME = "ReportName";
        public const string COL_COLUMN_DATA_TYPES = "ColumnDataTypes";
        public const string COL_COLUMNS = "Columns";
        public const string COL_COLUMNSHT = "ColumnsHT";
        public const string COL_COLUMN_WIDTH = "ColumnWidth";
        public const string COL_ALIGN = "Align";
        public const string COL_REPORT_WIDTH = "ReportWidth";
    }
    #endregion

    #region GroupReport
    internal class GroupReport
    {
        //Procedure 
        public const string PROC_GET_REPORT = "sproc_ReportMaster_sel";
        public const string PROC_GET_REPORT_BY_NAME = "sproc_ReportMaster_sel_ByName";
        public const string PROC_UPDATE_REPORT = "sproc_ReportMaster_ups";
        public const string PROC_UPDATE_REPORT_STATUS = "sproc_ReportMaster_ups_Status";
        public const string PROC_DELETE_REPORT = "sproc_ReportMaster_del";
        public const string PROC_UPDATE_ALL_STATUS = "sproc_ReportMaster_ups_AllStatus";
        public const string PROC_UPDATE_IS_PRIVATE = "sproc_ReportMaster_ups_IsPrivate";
        public const string PROC_SEARCH_REPORT = "sproc_ReportMaster_sel_search";

        //PARAMETERS
        public const string PARA_REPORT_ID = "@ReportId";
        public const string PARA_REPORT_NAME = "@ReportName";
        public const string PARA_REPORT_DESC = "@ReportDescription";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_IS_PRIVATE = "@IsPrivate";
        public const string PARA_IS_PRINT = "@IsPrint";
        public const string PARA_IS_HTML = "@IsHTML";
        public const string PARA_IS_PDF = "@IsPDF";
        public const string PARA_IS_CSV = "@IsCSV";
        public const string PARA_IS_EXCEL = "@IsExcel";
        public const string PARA_IS_EMAIL = "@IsEmail";

        //FIELDS
        public const string COL_REPORT_ID = "ReportId";
        public const string COL_REPORT_NAME = "ReportName";
        public const string COL_REPORT_DESC = "ReportDescription";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_IS_PRIVATE = "IsPrivate";
        public const string COL_IS_PRINT = "IsPrint";
        public const string COL_IS_HTML = "IsHTML";
        public const string COL_IS_PDF = "IsPDF";
        public const string COL_IS_CSV = "IsCSV";
        public const string COL_IS_EXCEL = "IsExcel";
        public const string COL_IS_EMAIL = "IsEmail";
    }
    #endregion

    #region ReportSelectedColumns
    internal class ReportSelectedColumns
    {
        //Procedure 
        public const string PROC_GET_ALL_REPORTS_SELECTED_COLUMNS = "sproc_ReportSelectedColumns_LstAll";
        public const string PROC_UPDATE_REPORT_SELECTED_COLUMNS = "sproc_ReportSelectedColumns_ups";
        public const string PROC_REPORT_SELECTED_COLUMNS_DEL_MULTI = "sproc_ReportSelectedColumns_delMultiple";
        public const string PROC_UPDATE_REPORT_SELECTED_COLUMNS_DISP_ORDER = "sproc_ReportSelectedColumns_dispOrderUps";
        public const string PROC_GET_REPORT_SELECTED_COLUMNS_WITHDATATYPE = "sproc_ReportingTool_SelectedColumns_Sel";


        //PARAMETERS
        public const string PARA_REPORT_COLUMN_ID = "@ReportColumnID";
        public const string PARA_REPORT_ID = "@ReportId";
        public const string PARA_IS_SORT_BY = "@IsSortBy";
        public const string PARA_IS_GROUP_BY = "@IsGroupBy";
        public const string PARA_IS_FILTERED = "@IsFiltered";
        public const string PARA_IS_CONFIGURABLE = "@IsConfigurable";
        public const string PARA_COL_DISPLAY_ORDER = "@ColumnDisplayOrder";//added by gitanjali 2.12.2010

        //FIELDS
        public const string COL_REPORT_COLUMN_ID = "ReportColumnID";
        public const string COL_REPORT_ID = "ReportId";
        public const string COL_IS_SORT_BY = "IsSortBy";
        public const string COL_IS_GROUP_BY = "IsGroupBy";
        public const string COL_IS_FILTERED = "IsFiltered";
        public const string COL_IS_CONFIGURABLE = "IsConfigurable";
        public const string COL_FIELD_NAME = "FieldName";
        public const string COL_DISPLAY_ORDER = "ColumnDisplayOrder";//added by gitanjali 2.12.2010
        public const string COL_FIELD_DATA_TYPE = "FieldDataType";//added by gitanjali 12.12.2010
    }
    #endregion

    #region ReportParameters
    internal class ReportParameters
    {
        //Procedure 
        public const string PROC_UPDATE_REPORT_PARA = "sproc_ReportParameters_ups";
        public const string PROC_DEL_MULTI_REPORT_PARA = "sproc_ReportParameters_delMultiple";

        //PARAMETERS
        public const string PARA_PARAMETER_ID = "@ParameterId";
        public const string PARA_PARA_NAME = "@ParameterName";
        public const string PARA_LEFT_COND_ID = "@LeftConditionID";
        public const string PARA_LEFT_COND_VALUE = "@LeftConditionValue";
        public const string PARA_CONDITION = "@Condition";
        public const string PARA_RIGHT_COND_ID = "@RightConditionId";
        public const string PARA_CONDITION_ID = "@ConditionId";
        public const string PARA_RIGHT_COND_VALUE = "@RightConditionValue";
        public const string PARA_NEXT_CONDITION = "@NextCondition";
        public const string PARA_PARA_FIELD_TYPE = "@ParameterFieldType";
        public const string PARA_GROUP_TYPE = "@GroupType";

        //FIELDS
        public const string COL_PARAMETER_ID = "ParameterId";
        public const string COL_PARA_NAME = "ParameterName";
        public const string COL_LEFT_COND_ID = "LeftConditionID";
        public const string COL_LEFT_COND_VALUE = "LeftConditionValue";
        public const string COL_CONDITION = "Condition";
        public const string COL_CONDITION_ID = "ConditionId";
        public const string COL_RIGHT_COND_ID = "RightConditionId";
        public const string COL_RIGHT_COND_VALUE = "RightConditionValue";
        public const string COL_NEXT_CONDITION = "NextCondition";
        public const string COL_PARA_FIELD_TYPE = "ParameterFieldType";
        public const string COL_GROUP_TYPE = "GroupType";
    }
    #endregion

    #region ReportParameterGroup
    internal class ReportParameterGroup
    {

        //FIELDS
        public const string COL_PARAMETER_GROUP_ID = "ParameterGroupId";
        public const string COL_PARA_GROUP_NAME = "ParameterGroupName";
        public const string COL_SORT_ORDER = "SortOrder";
        //Para
        public const string PARA_PARAMETER_GROUP_ID = "@ParameterGroupId";
        public const string PARA_PARA_GROUP_NAME = "@ParameterGroupName";
        public const string PARA_SORT_ORDER = "@SortOrder";
        //PROC    
        public const string PROC_DEL_MULTI_REPORT_PARA_GRP = "sproc_ReportParameterGroup_delMultiple";
        public const string PROC_UPS_REPORT_PARA_GRP = "sproc_ReportParameterGroup_ups";

    }
    #endregion

    #region BusinessRuleUsers
    internal class BusinessRuleUsers
    {
        //Procedure 
        public const string PROC_UPDATE_BUSINESS_RULE_USERS = "sproc_BusinessRuleUsers_ups";
        public const string PROC_DELETE_MULTI_BUSINESS_RULE_USERS = "sproc_BusinessRuleUsers_delMultiple";
        public const string PROC_GET_BUSINESS_RULE_RESULT_USERS = "sproc_UserMaster_sel_RuleUsers";

        // added by Gitanjali 09.08.2010
        public const string PROC_GET_BUSINESS_RULE_ACTIVE_USERS = "sproc_BusinessRuleUsers_selActive";


        //PARAMETERS

        public const string PARA_BUSINESS_RULE_ID = "@RuleId";
        public const string PARA_PARAMETER_GROUP_ID = "@ParameterGroupId";
        public const string PARA_IS_INCLUDED = "@IsIncluded";

        //FIELDS

        public const string COL_BUSINESS_RULE_ID = "RuleId";
        public const string COL_PARAMETER_GROUP_ID = "ParameterGroupId";
        public const string COL_IS_INCLUDED = "IsIncluded";
    }
    #endregion

    #region Curriculum
    public class Curriculum
    {
        //PROCEDURES        
        public const string PROC_GET_CURRICULUM_MASTER_ID_LEARNER = "sproc_CurriculumMaster_sel_Learner";
        public const string PROC_GET_CURRICULUM_MASTER_ID = "sproc_CurriculumMaster_sel";
        public const string PROC_GET_CURRICULUM_BY_NAME = "sproc_CurriculumMaster_selByName";
        public const string PROC_FIND_CURRICULUMS = "sproc_CurriculumMaster_Sel_Search";
        public const string PROC_UPDATE_CURRICULUM = "sproc_CurriculumMaster_ups";
        public const string PROC_DELETE_CURRICULUM = "sproc_CurriculumMaster_del";
        public const string PROC_GET_ALL_CURRICULUMS = "sproc_CurriculumMaster_LstAll";
        public const string PROC_GET_ALL_CURRICULUM_ACTIVITIES = "sproc_CurriculumActivity_LstAll";
        public const string PROC_UPDATE_CURRICULUM_OPTIONS = "sproc_CurriculumMaster_ups_Options";
        public const string PROC_GET_ALL_CURRICULUM_ACTIVITIES_LEARNER = "sproc_CurriculumActivity_LstAll_Learner";

        //PARAMETERS
        public const string PARA_CURRICULUM_ID = "@CurriculumId";
        public const string PARA_CURRICULUM_NAME = "@CurriculumName";
        public const string PARA_CURRICULUM_DESC = "@CurriculumDescription";
        public const string PARA_CURRICULUM_INSTRUCTION = "@CurriculumInstruction";
        public const string PARA_ENFORCE_SEQUENCING = "@EnforceSequencing";
        public const string PARA_IS_PRINT_CERTIFICATE = "@IsPrintCertificate";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_COMPLETION_CONDITION_ID = "@CompletionConditionId";
        public const string PARA_CLIENT_ID = "@ClientId";
        public const string PARA_LANGUAGE_ID = "@LanguageId";
        public const string PARA_ENFORCE_SECTION_SEQUENCING = "@EnforceSectionSequencing";
        public const string PARA_IS_CONTAIN_SECTIONS = "@IsContainSections";
        public const string PARA_IS_SEQUENCEORDER = "@IsSequenceOrder";

        //FIELDS
        public const string COL_CURRICULUM_ID = "CurriculumId";
        public const string COL_CURRICULUM_NAME = "CurriculumName";
        public const string COL_CURRICULUM_DESC = "CurriculumDescription";
        public const string COL_CURRICULUM_INSTRUCTION = "CurriculumInstruction";
        public const string COL_ENFORCE_SEQUENCING = "EnforceSequencing";
        public const string COL_IS_PRINT_CERTIFICATE = "IsPrintCertificate";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_IS_USED = "IsUsed";
        public const string COL_CLIENT_ID = "ClientId";
        public const string COL_LANGUAGE_ID = "LanguageId";
        public const string COL_STATUS = "Status";
        public const string COL_ENFORCE_SECTION_SEQUENCING = "EnforceSectionSequencing";
        public const string COL_IS_CONTAIN_SECTIONS = "IsContainSections";
        public const string COL_IS_SEQUENCEORDER = "IsSequenceOrder";
        public const string COL_PROGRESS = "Progress";

    }
    #endregion

    #region CurriculumActivity
    public class CurriculumActivity
    {
        //PROCEDURES        
        public const string PROC_GET_CURRICULUM_ACTIVITY_MASTER_ID = "sproc_CurriculumActivity_sel";
        public const string PROC_UPDATE_CURRICULUM_ACTIVITY = "sproc_CurriculumActivity_ups";
        public const string PROC_DELETE_NOT_IN_ACTIVITY = "sproc_CurriculumActivity_delMultiple";
        public const string PROC_GET_ALL_CURRICULUM_ACTIVITIES = "sproc_CurriculumActivity_LstAll";
        public const string PROC_GET_ALL_CURRICULUM_ACTIVITIES_ATTEMPT = "sproc_CurriculumActivity_LstAll_Attempt";

        //PARAMETERS
        public const string PARA_CURRICULUM_ID = "@CurriculumId";
        public const string PARA_ACTIVITY_ID = "@ActivityId";
        public const string PARA_LANGUAGE_ID = "@LanguageId";
        public const string PARA_ACTIVITY_NAME = "@ActivityName";
        public const string PARA_ACTIVITY_MESSAGE = "@ActivityMessage";
        public const string PARA_ACTIVITY_COMPLETION_CONDITION_ID = "@ActivityCompletionConditionId";

        public const string PARA_ACTIVITY_TYPE = "@ActivityType";
        public const string PARA_SORT_ORDER = "@SortOrder";
        public const string PARA_SECTIONID = "@SectionId";//NEW CHANGE

        //FIELDS
        public const string COL_CURRICULUM_ID = "CurriculumId";
        public const string COL_ACTIVITY_ID = "ActivityId";
        public const string COL_LANGUAGE_ID = "LanguageId";
        public const string COL_ACTIVITY_NAME = "ActivityName";
        public const string COL_ACTIVITY_MESSAGE = "ActivityMessage";
        public const string COL_ACTIVITY_COMPLETION_CONDITION_ID = "ActivityCompletionConditionId";
        //public const string COL_ADDITIONAL_LINKS = "AdditionalLinks";
        public const string COL_ACTIVITY_TYPE = "ActivityType";
        public const string COL_SORT_ORDER = "SortOrder";
        public const string COL_ORG_ACTIVITY_NAME = "OrgActivityName";
        public const string COL_SECTIONID = "SectionId";//NEW CHANGE
        public const string COL_COMPLETION_STATUS_FOR_BOOKMARK = "CompletionStatusForBookMark";//NEW CHANGE
        public const string COL_BOOKMARKID = "BookmarkId";
    }
    #endregion


    #region DefaultAssignmentValue
    public class DefaultAssignmentValue
    {
        //PROCEDURES        
        public const string PROC_GET_ALL_DEFAULT_ASSIGNMENT_SETTING = "sproc_GetAllDefaultAssignmentSetting";
        public const string sproc_DEFAULT_ASSIGNMENT_SETTING_UPS = "sproc_DefaultAssignmentSetting_ups";
        public const string sproc_DELETEDEFAULT_ASSIGNMENT_SETTING = "sproc_DeleteDefaultAssignmentSetting";
        //PARAMETERS
        public const string PARA_DEFAULTVALUE_ID = "@DefaultValueId";
        public const string PARA_MODULENAME = "@ModuleName";
        public const string PARA_FIELDNAME = "@FieldName";
        public const string PARA_DATA_tYPEE = "@DataTypee";
        public const string PARA_DEFAULTVALUE = "@DefaultValue";
        public const string PARA_CONDITION = "@Condition";
        public const string PARA_IS_USED_FOR_DYNAMIC_ASSIGNMENT = "@IsUsedForDynamicAssignment";

        //FIELDS
        public const string COL_DEFAULTVALUE_ID = "DefaultValueId";
        public const string COL_MODULENAME = "ModuleName";
        public const string COL_FIELDNAME = "FieldName";
        public const string COL_DATA_tYPEE = "DataTypee";
        public const string COL_DEFAULTVALUE = "DefaultValue";
        public const string COL_CONDITION = "Condition";
        public const string COL_CurrntDate = "CurrentDate";
        public const string COL_IS_USED_FOR_DYNAMIC_ASSIGNMENT = "IsUsedForDynamicAssignment";
    }
    #endregion

    #region DefaultAssignmentValue
    public class UserExpiry
    {
        //PROCEDURES        
        public const string PROC_GET_USER_EXPIRY_BY_EXPIRY_TYPE = "sproc_Get_User_Expiry_By_Expiry_Type";
        public const string PROC_GET_USERLIST_NOTASSIGNEDSPECIFICUSEREXPIRY = "sproc_Get_UserList_NotAssignedSpecificUserExpiry";
        public const string PROC_USEREXPIRY_UPS = "sproc_UserExpiry_ups";
        public const string PROC_DELETE_USER_EXPIRY = "sproc_DeleteUserExpiry";
        public const string PROC_ADD_USER_EXPIRYTYPE_AGAINSTCLIENT = "sproc_AddUserExpiryTypeAgainstClient";
        public const string PROC_USEREXPIRYSETTINGS_UPS = "sproc_UserExpirySettings_ups";
        public const string PROC_GET_USEREXPIRYASSIGNED_BUSINESSRULE = "sproc_Get_UserExpiryAssigned_BusinessRule";
        public const string PROC_GET_BUSINESSRULE_USEREXPIRY = "sproc_Get_BUSINESS_RULE_USER_EXPIRY";
        public const string PROC_DELETEUSEREXPIRYBUSINESSRULE = "sproc_DeleteUserExpiryBusinessRule";
        public const string PROC_VIEWUSEROFBUSINESSRULE = "sproc_Get_USERLIST_OFBUSINESSRULE_USER_EXPIRY";
        public const string PROC_Get_User_Expiry_Type = "sproc_Get_UserExpiryType";
        public const string PROC_ADDEDITUSEREXPIRYWHILEEDITINGRULE = "sproc_AddEditUserExpiryWhileEditingRule";
        public const string PROC_INSERT_USEREXPIRY_WHILE_ADDEDITUSER = "sproc_InsertUserExpiryWhilAddEditUser";
        //PARAMETERS
        public const string PARA_IsSpecificUser = "@IsSpecificUser";
        public const string PARA_IsBusinessRule = "@IsBusinessRule";
        public const string PARA_IsGlobalSettings = "@IsGlobalSettings";
        public const string PARA_BusinessRuleId = "@BusinessRuleId";
        public const string PARA_ExpiryDate = "@ExpiryDate";
        public const string PARA_Days = "@Days";
        public const string PARA_IsIncludeAdminUser = "@IsIncludeAdminUser";

        public const string PARA_IsBusinessOrGlobalSettings = "@IsBusinessOrGlobalSettings";
        public const string PARA_SystemUserGUID = "@SystemUserGUID";
        public const string PARA_ExpiryType = "@ExpiryType";
        public const string PARA_ClientId = "@ClientId";
        public const string PARA_CREATED_BY_ID = "@CreatedByID";

        //FIELDS
        public const string COL_IsSpecificUser = "IsSpecificUser";
        public const string COL_IsBusinessRule = "IsBusinessRule";
        public const string COL_IsGlobalSettings = "IsGlobalSettings";
        public const string COL_BusinessRuleId = "BusinessRuleId";
        public const string COL_ExpiryDate = "ExpiryDate";
        public const string COL_Days = "Days";
        public const string COL_IsIncludeAdminUser = "IsIncludeAdminUser";
        public const string COL_IsBusinessOrGlobalSettings = "IsBusinessOrGlobalSettings";

        public const string COL_SystemUserGUID = "SystemUserGUID";
        public const string COL_ExpiryType = "ExpiryType";
        public const string COL_RuleName = "RuleName";
        public const string COL_CREATED_BY_ID = "CreatedByID";
    }
    #endregion



    #region Questionnaire
    public class Questionnaire
    {
        //PROCEDURES        
        public const string PROC_GET_ALL_QUESTIONNAIRE = "sproc_QuestionnaireMaster_LstAll";
        public const string PROC_GET_QUESTIONNAIRE_FOR_ASSIGNMENT = "sproc_QuestionnaireMaster_LstForAssignment";
        public const string PROC_GET_QUESTIONNAIRE_DTLS = "sproc_QuestionnaireMaster_LstDtls";
        public const string PROC_FIND_QUESTIONNAIRE = "sproc_QuestionnaireMaster_Sel_Search";
        public const string PROC_GET_QUESTIONNAIRE_TRACKING = "sproc_QuestionnaireMaster_LstTracking";
        public const string PROC_UPDATE_QUESTIONNAIRE = "sproc_QuestionnaireMaster_ups";
        public const string PROC_UPDATE_QUESTN_LANGUAGE = "sproc_QuestionnaireLanguage_ups";
        public const string PROC_SELECT_QUESTIONNAIRE = "sproc_QuestionnaireMaster_sel";
        public const string PROC_SELECT_QUESTIONNAIRE_TYPE_LEARNER = "sproc_QuestionnaireMaster_GetQuestionnaireType_Learner";
        public const string PROC_CHECK_QUESTIONNAIRE_BY_NAME = "sproc_QuestionnaireMaster_selByName";
        public const string PROC_DELET_QUESTIONNAIRE = "sproc_QuestionnaireMaster_del";
        public const string PROC_DELET_QUESTIONNAIRE_LANGUAGE = "sproc_QuestionnaireLanguage_del";
        public const string PROC_GET_QUESTIONNAIRE_TRACKING_WITHOUT_PAGING = "sproc_QuestionnaireMaster_LstTracking_Learner";
        public const string PROC_SELECT_QUESTIONNAIRE_QUEST_NUMBER = "sproc_QuestionnaireMaster_IsShowQuestionNumber";


        public const string PROC_SELECT_QUESTIONNAIRE_DEFAULT_SEQ = "sproc_QuestionnaireMaster_DefaultSeq_Get";
        public const string PROC_UPDATE_QUESTIONNAIRE_DEFAULT_SEQ = "sproc_QuestionnaireMaster_DefaultSeq_ups";

        public const string PROC_APPROVE_QUESTIONNAIRE = "sproc_QuestionnaireLanguage_ups_Approve";
        public const string PROC_ACTIVE_QUESTIONNAIRE = "sproc_QuestionnaireMaster_ups_IsActive";

        public const string PROC_GET_IMPORT_LANGUAGE = "sproc_LanguageMaster_LstQuestImport";
        public const string PROC_GET_EXPORT_LANGUAGE = "sproc_LanguageMaster_LstQuestExport";

        public const string PROC_GET_QUESTIONNAIRE_LANGUAGES = "sproc_QuestionnaireLanguage_sel";

        public const string PROC_ADD_IMPORT_LANGUAGE = "sproc_QuestionnaireLanguage_ImportCopy";
        //FIELDS
        public const string COL_QUESTIONNAIRE_ID = "QuestionnaireID";
        public const string COL_QUESTIONNAIRE_TYPE = "QuestionnaireType";
        public const string COL_BGCOLOR = "BGColor";
        public const string COL_DEFAULTLOGOPATH = "DefaultLogoPath";
        public const string COL_IS_LOGO_ONALL = "IsLogoOnAll";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_IS_PARTIAL_SUBMITALLOWED = "IsPartialSubmitAllowed";
        public const string COL_IS_MULTI_SUBMITALLOWED = "IsMultiSubmitAllowed";
        public const string COL_IS_REVIEW_ANSWER = "IsReviewAnswer";
        public const string COL_ALLOW_USER_LANGSELECTION = "AllowUserLangSelection";
        public const string COL_ALLOW_SEQUENCING = "AllowSequencing";
        public const string COL_LOGO_POSITION = "LogoPosition";
        public const string COL_TRACKING_TYPE = "TrackingType";

        public const string COL_IS_PRINT_CERTIFICATE = "IsPrintCertificate";
        public const string COL_QUESTN_LANG_TITLE = "QuestionnaireTitle";
        public const string COL_QUESTN_LANG_DESC = "QuestionnaireDescription";
        public const string COL_QUESTN_LANG_INST_TOP = "QuestionnaireInstructionTop";
        public const string COL_QUESTN_LANG_INST_BOT = "QuestionnaireInstructionBottom";
        public const string COL_QUESTN_LANG_CF_REVIEW_EMAIL = "CFForReviewEmail";
        public const string COL_QUESTN_LANG_REVIEW_SENT_DATE = "DateLastReviewSent";
        public const string COL_QUESTN_LANG_REVIEW_EMAIL = "ReviewEmail";
        public const string COL_QUESTN_LANG_APPROVAL_STATUS = "ApprovalStatus";
        public const string COL_QUESTN_LANG_APPROVED_BY_ID = "ApprovedById";
        public const string COL_QUESTN_LANG_DATE_APPROVED = "DateApproved";
        public const string COL_QUESTN_LANG_BTN_NEXT_TXT = "ButtonNextTxt";
        public const string COL_QUESTN_LANG_BTN_PREVIOUS_TXT = "ButtonPreviousTxt";
        public const string COL_QUESTN_LANG_BTN_SUBMIT_TXT = "ButtonSubmitTxt";
        public const string COL_BTN_SAVE_TXT = "ButtonSaveTxt";
        public const string COL_QUESTN_LANG_BTN_EXIT_TXT = "ButtonExitTxt";
        public const string COL_QUESTN_LANG_LOGO_PATH = "LanguageLogoPath";
        public const string COL_IS_LOCKED = "IsLocked";
        public const string COL_MAX_RESPONSE_LENGTH = "MaxResponseLength";
        public const string COL_QUESTION_COUNT = "QuestionCount";
        public const string COL_IS_DEFAULT_SEQ = "IsDefaultSequence";
        public const string COL_IS_SHOW_QUESTIONNUMBER = "IsShowQuestionNumber";

        public const string COL_IS_USESECTIONS = "IsUseSections";
        public const string COL_BGHEADER_HF = "BGHeaderHF";
        public const string COL_IS_LOGOHIDE = "IsLogoHide";
        public const string COL_IS_LOGOONFIRSTPAGEONLY = "IsLogoOnFirstPageOnly";
        public const string COL_IS_ALL_ANSWER_MUST = "IsAllAnswerMust";
        public const string COL_FONT_NAME = "FontName";
        public const string COL_FONT_SIZE = "FontSize";
        public const string COL_FONT_COLOR = "FontColor";
        public const string COL_QUEBG_COLOR = "QuestionaireBGColor";

        //Change for 193
        public const string COL_IS_LEARNERPRINTABLE = "IsLearnerPrintable";
        public const string COL_BUTTONPRINTTXT = "ButtonPrintTxt";
        public const string COL_CREATED_BY_ID = "CreatedById";
        //Change for 193

        public const string PARA_QUESTIONNAIRE_ID = "@QuestionnaireID";
        public const string PARA_BASE_LANGUAGE_ID = "@BaseLanguageId";
        public const string PARA_QUESTIONNAIRE_TYPE = "@QuestionnaireType";
        public const string PARA_BGCOLOR = "@BGColor";
        public const string PARA_DEFAULTLOGOPATH = "@DefaultLogoPath";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_IS_LOGO_ONALL = "@IsLogoOnAll";
        public const string PARA_IS_PARTIAL_SUBMITALLOWED = "@IsPartialSubmitAllowed";
        public const string PARA_IS_MULTI_SUBMITALLOWED = "@IsMultiSubmitAllowed";
        public const string PARA_IS_REVIEW_ANSWER = "@IsReviewAnswer";
        public const string PARA_ALLOW_USER_LANGSELECTION = "@AllowUserLangSelection";
        public const string PARA_ALLOW_SEQUENCING = "@AllowSequencing";
        public const string PARA_LOGO_POSITION = "@LogoPosition";
        public const string PARA_TRACKING_TYPE = "@TrackingType";

        public const string PARA_IS_DEFAULT_SEQ = "@IsDefaultSequence";
        public const string PARA_IS_SHOW_QUESTIONNUMBER = "@IsShowQuestionNumber";

        public const string PARA_QUESTN_LANG_TITLE = "@QuestionnaireTitle";
        public const string PARA_QUESTN_LANG_DESC = "@QuestionnaireDescription";
        public const string PARA_QUESTN_LANG_INST_TOP = "@QuestionnaireInstructionTop";
        public const string PARA_QUESTN_LANG_INST_BOT = "@QuestionnaireInstructionBottom";
        public const string PARA_QUESTN_LANG_CF_REVIEW_EMAIL = "@CFForReviewEmail";
        public const string PARA_QUESTN_LANG_REVIEW_SENT_DATE = "@DateLastReviewSent";
        public const string PARA_QUESTN_LANG_REVIEW_EMAIL = "@ReviewEmail";
        public const string PARA_QUESTN_LANG_APPROVAL_STATUS = "@ApprovalStatus";
        public const string PARA_QUESTN_LANG_APPROVED_BY_ID = "@ApprovedById";
        public const string PARA_QUESTN_LANG_DATE_APPROVED = "@DateApproved";
        public const string PARA_QUESTN_LANG_BTN_NEXT_TXT = "@ButtonNextTxt";
        public const string PARA_QUESTN_LANG_BTN_PREVIOUS_TXT = "@ButtonPreviousTxt";
        public const string PARA_QUESTN_LANG_BTN_SUBMIT_TXT = "@ButtonSubmitTxt";
        public const string PARA_BTN_SAVE_TXT = "@ButtonSaveTxt";
        public const string PARA_QUESTN_LANG_BTN_EXIT_TXT = "@ButtonExitTxt";
        public const string PARA_QUESTN_LANG_LOGO_PATH = "@LanguageLogoPath";
        public const string PARA_MAX_RESPONSE_LENGTH = "@MaxResponseLength";

        public const string PARA_IS_USESECTIONS = "@IsUseSections";
        public const string PARA_BGHEADER_HF = "@BGHeaderHF";
        public const string PARA_IS_LOGOHIDE = "@IsLogoHide";
        public const string PARA_IS_LOGOONFIRSTPAGEONLY = "@IsLogoOnFirstPageOnly";

        public const string PARA_IS_ALL_ANSWER_MUST = "@IsAllAnswerMust";
        public const string PARA_FONT_NAME = "@FontName";
        public const string PARA_FONT_SIZE = "@FontSize";
        public const string PARA_FONT_COLOR = "@FontColor";
        public const string PARA_QUEBG_COLOR = "@QuestionaireBGColor";

        //Change for 193
        public const string PARA_IS_LEARNERPRINTABLE = "@IsLearnerPrintable";
        public const string PARA_BUTTONPRINTTXT = "@ButtonPrintTxt";
        public const string PARA_CREATED_BY_ID = "@CreatedById";
        //Change for 193
    }
    #endregion

    #region Assessment
    public class Assessment
    {
        //PROCEDURES
        public const string PROC_GET_ALL_ASSESSMENT = "sproc_AssessmentMaster_LstAll";
        public const string PROC_GET_ASSESSMENT_FOR_ASSIGNMENT = "sproc_AssessmentMaster_LstForAssignment";
        public const string PROC_GET_ASSESSMENT_DTLS = "sproc_AssessmentMaster_LstDtls";
        public const string PROC_FIND_ASSESSMENT = "sproc_AssessmentMaster_Sel_Search";
        public const string PROC_GET_ASSESSMENT_TRACKING = "sproc_AssessmentMaster_LstTracking";
        public const string PROC_UPDATE_ASSESSMENT = "sproc_AssessmentMaster_ups";
        public const string PROC_UPDATE_ASSESSMENT_LANGUAGE = "sproc_AssessmentLanguage_ups";
        public const string PROC_SELECT_ASSESSMENT = "sproc_AssessmentMaster_sel";
        public const string PROC_SELECT_ASSESSMENT_TYPE_LEARNER = "sproc_AssessmentMaster_GetAssessmentType_Learner";
        public const string PROC_CHECK_ASSESSMENT_BY_NAME = "sproc_AssessmentMaster_selByName";
        public const string PROC_DELET_ASSESSMENT = "sproc_AssessmentMaster_del";
        public const string PROC_DELET_ASSESSMENTLANGUAGE = "sproc_AssessmentLanguage_del";
        public const string PROC_GET_ASSESSMENT_TRACKING_WITHOUT_PAGING = "sproc_AssessmentMaster_LstTracking_Learner";
        public const string PROC_SELECT_ASSESSMENT_QUEST_NUMBER = "sproc_AssessmentMaster_IsShowQuestionNumber";


        public const string PROC_SELECT_ASSESSMENT_DEFAULT_SEQ = "sproc_AssessmentMaster_DefaultSeq_Get";
        public const string PROC_UPDATE_ASSESSMENT_DEFAULT_SEQ = "sproc_AssessmentMaster_DefaultSeq_ups";

        public const string PROC_APPROVE_ASSESSMENT = "sproc_AssessmentLanguage_ups_Approve";
        public const string PROC_ACTIVE_ASSESSMENT = "sproc_AssessmentMaster_ups_IsActive";

        public const string PROC_GET_IMPORT_LANGUAGE = "sproc_LanguageMaster_LstAssessmentImport";
        public const string PROC_GET_EXPORT_LANGUAGE = "sproc_LanguageMaster_LstAssessmentExport";

        public const string PROC_GET_ASSESSMENT_LANGUAGES = "sproc_AssessmentLanguage_sel";

        public const string PROC_ADD_IMPORT_LANGUAGE = "sproc_AssessmentLanguage_ImportCopy";
        public const string PROC_GET_ASSESSMENT_TRACKING_PREVIEWASSESSMENT = "sproc_AssessmentMaster_LstTracking_PreviewAssessment";
        //FIELDS
        public const string COL_ASSESSMENT_ID = "AssessmentID";
        public const string COL_ASSESSMENT_TYPE = "AssessmentType";
        public const string COL_BGCOLOR = "BGColor";
        public const string COL_DEFAULTLOGOPATH = "DefaultLogoPath";
        public const string COL_IS_LOGO_ONALL = "IsLogoOnAll";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_IS_PARTIAL_SUBMITALLOWED = "IsPartialSubmitAllowed";
        public const string COL_IS_MULTI_SUBMITALLOWED = "IsMultiSubmitAllowed";
        public const string COL_IS_REVIEW_ANSWER = "IsReviewAnswer";
        public const string COL_ALLOW_USER_LANGSELECTION = "AllowUserLangSelection";
        public const string COL_ALLOW_SEQUENCING = "AllowSequencing";
        public const string COL_LOGO_POSITION = "LogoPosition";
        public const string COL_TRACKING_TYPE = "TrackingType";

        public const string COL_IS_PRINT_CERTIFICATE = "IsPrintCertificate";
        public const string COL_ASSESSMENT_LANG_TITLE = "AssessmentTitle";
        public const string COL_ASSESSMENT_LANG_DESC = "AssessmentDescription";
        public const string COL_ASSESSMENT_LANG_INST_TOP = "AssessmentInstructionTop";
        public const string COL_ASSESSMENT_LANG_INST_BOT = "AssessmentInstructionBottom";
        public const string COL_ASSESSMENT_LANG_CF_REVIEW_EMAIL = "CFForReviewEmail";
        public const string COL_ASSESSMENT_LANG_REVIEW_SENT_DATE = "DateLastReviewSent";
        public const string COL_ASSESSMENT_LANG_REVIEW_EMAIL = "ReviewEmail";
        public const string COL_ASSESSMENT_LANG_APPROVAL_STATUS = "ApprovalStatus";
        public const string COL_ASSESSMENT_LANG_APPROVED_BY_ID = "ApprovedById";
        public const string COL_ASSESSMENT_LANG_DATE_APPROVED = "DateApproved";
        public const string COL_ASSESSMENT_LANG_BTN_NEXT_TXT = "ButtonNextTxt";
        public const string COL_ASSESSMENT_LANG_BTN_PREVIOUS_TXT = "ButtonPreviousTxt";
        public const string COL_ASSESSMENT_LANG_BTN_SUBMIT_TXT = "ButtonSubmitTxt";
        public const string COL_BTN_SAVE_TXT = "ButtonSaveTxt";
        public const string COL_ASSESSMENT_LANG_BTN_EXIT_TXT = "ButtonExitTxt";
        public const string COL_ASSESSMENT_LANG_LOGO_PATH = "LanguageLogoPath";
        public const string COL_IS_LOCKED = "IsLocked";
        public const string COL_MAX_RESPONSE_LENGTH = "MaxResponseLength";
        public const string COL_QUESTION_COUNT = "QuestionCount";
        public const string COL_IS_DEFAULT_SEQ = "IsDefaultSequence";
        public const string COL_IS_SHOW_QUESTIONNUMBER = "IsShowQuestionNumber";

        public const string COL_IS_USESECTIONS = "IsUseSections";
        public const string COL_BGHEADER_HF = "BGHeaderHF";
        public const string COL_IS_LOGOHIDE = "IsLogoHide";
        public const string COL_IS_LOGOONFIRSTPAGEONLY = "IsLogoOnFirstPageOnly";
        public const string COL_IS_ALL_ANSWER_MUST = "IsAllAnswerMust";
        public const string COL_FONT_NAME = "FontName";
        public const string COL_FONT_SIZE = "FontSize";
        public const string COL_FONT_COLOR = "FontColor";
        public const string COL_QUEBG_COLOR = "QuestionaireBGColor";

        //Change for 193
        public const string COL_IS_LEARNERPRINTABLE = "IsLearnerPrintable";
        public const string COL_BUTTONPRINTTXT = "ButtonPrintTxt";
        //Change for 193

        public const string COL_NUMBER_OF_ATTEMPTS = "NumberOfAttempts";
        public const string COL_ASSESSMENTTIME = "AssessmentTime";
        public const string COL_ASSESSMENTALERTTIME = "AlertTime";
        public const string COL_ASSESSMENT_ATTEMPT_EXCEED = "IsAssementAttempExceeded";
        public const string COL_MULTIPLE_SUBMIT_ALLOWED = "MultiSubmitAllowed4mDBfOREveryLearner";

        public const string COL_SHOW_ASSESSMENT_RESULT = "ShowAssessmentResult";
        public const string COL_QUESTIONCOUNT = "QuestionCount";
        public const string COL_QUESTIONMAPPINGCOUNT = "QuestionMappingCount";
        public const string COL_SEND_EMAIL_OF_RESULT = "IsSendEmailOfResult";
        public const string COL_Is_Complete_Assignment_Dep_On_Scrore = "IsCompleteAssignmentDepOnScrore";
        public const string COL_Passing_Score = "PassingScore";
        public const string COL_CREATED_BY_ID = "CreatedById";
        public const string COL_FEATURE_CREATED_BY_ID = "FeatureCreatedById";
        public const string PARA_IsCompleteAssignmentDepOnScrore = "@IsCompleteAssignmentDepOnScrore";
        public const string PARA_PassingScore = "@PassingScore";

        public const string PARA_IsSendEmailOfResult = "@IsSendEmailOfResult";
        public const string PARA_QUESTIONCOUNT = "@QuestionCount";
        public const string PARA_ASSESSMENT_ID = "@AssessmentID";
        public const string PARA_BASE_LANGUAGE_ID = "@BaseLanguageId";
        public const string PARA_ASSESSMENT_TYPE = "@AssessmentType";
        public const string PARA_BGCOLOR = "@BGColor";
        public const string PARA_DEFAULTLOGOPATH = "@DefaultLogoPath";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_IS_LOGO_ONALL = "@IsLogoOnAll";
        public const string PARA_IS_PARTIAL_SUBMITALLOWED = "@IsPartialSubmitAllowed";
        public const string PARA_IS_MULTI_SUBMITALLOWED = "@IsMultiSubmitAllowed";
        public const string PARA_IS_REVIEW_ANSWER = "@IsReviewAnswer";
        public const string PARA_ALLOW_USER_LANGSELECTION = "@AllowUserLangSelection";
        public const string PARA_ALLOW_SEQUENCING = "@AllowSequencing";
        public const string PARA_LOGO_POSITION = "@LogoPosition";
        public const string PARA_TRACKING_TYPE = "@TrackingType";

        public const string PARA_IS_DEFAULT_SEQ = "@IsDefaultSequence";
        public const string PARA_IS_SHOW_QUESTIONNUMBER = "@IsShowQuestionNumber";

        public const string PARA_ASSESSMENT_LANG_TITLE = "@AssessmentTitle";
        public const string PARA_ASSESSMENT_LANG_DESC = "@AssessmentDescription";
        public const string PARA_ASSESSMENT_LANG_INST_TOP = "@AssessmentInstructionTop";
        public const string PARA_ASSESSMENT_LANG_INST_BOT = "@AssessmentInstructionBottom";
        public const string PARA_ASSESSMENT_LANG_CF_REVIEW_EMAIL = "@CFForReviewEmail";
        public const string PARA_ASSESSMENT_LANG_REVIEW_SENT_DATE = "@DateLastReviewSent";
        public const string PARA_ASSESSMENT_LANG_REVIEW_EMAIL = "@ReviewEmail";
        public const string PARA_ASSESSMENT_LANG_APPROVAL_STATUS = "@ApprovalStatus";
        public const string PARA_ASSESSMENT_LANG_APPROVED_BY_ID = "@ApprovedById";
        public const string PARA_ASSESSMENT_LANG_DATE_APPROVED = "@DateApproved";
        public const string PARA_ASSESSMENT_LANG_BTN_NEXT_TXT = "@ButtonNextTxt";
        public const string PARA_ASSESSMENT_LANG_BTN_PREVIOUS_TXT = "@ButtonPreviousTxt";
        public const string PARA_ASSESSMENT_LANG_BTN_SUBMIT_TXT = "@ButtonSubmitTxt";
        public const string PARA_BTN_SAVE_TXT = "@ButtonSaveTxt";
        public const string PARA_ASSESSMENT_LANG_BTN_EXIT_TXT = "@ButtonExitTxt";
        public const string PARA_ASSESSMENT_LANG_LOGO_PATH = "@LanguageLogoPath";
        public const string PARA_MAX_RESPONSE_LENGTH = "@MaxResponseLength";

        public const string PARA_IS_USESECTIONS = "@IsUseSections";
        public const string PARA_BGHEADER_HF = "@BGHeaderHF";
        public const string PARA_IS_LOGOHIDE = "@IsLogoHide";
        public const string PARA_IS_LOGOONFIRSTPAGEONLY = "@IsLogoOnFirstPageOnly";

        public const string PARA_IS_ALL_ANSWER_MUST = "@IsAllAnswerMust";
        public const string PARA_FONT_NAME = "@FontName";
        public const string PARA_FONT_SIZE = "@FontSize";
        public const string PARA_FONT_COLOR = "@FontColor";
        public const string PARA_QUEBG_COLOR = "@QuestionaireBGColor";

        //Change for 193
        public const string PARA_IS_LEARNERPRINTABLE = "@IsLearnerPrintable";
        public const string PARA_BUTTONPRINTTXT = "@ButtonPrintTxt";
        //Change for 193

        public const string PARA_ASSESSMENTTIME = "@AssessmentTime";
        public const string PARA_ASSESSMENTALERTTIME = "@AlertTime";
        public const string PARA_NUMBER_OF_ATTEMPTS = "@NumberOfAttempts";

        public const string PARA_SHOW_ASSESSMENT_RESULT = "@ShowAssessmentResult";
        public const string PARA_REQUESTED_BY_ID = "@RequestedById";
        public const string PARA_CREATED_BY_ID = "@CreatedById";
        public const string PARA_FEATURE_CREATED_BY_ID = "@FeatureCreatedById";

    }
    #endregion

    #region ContentModuleLanguages
    public class ContentModuleLanguages
    {
        //PROCEDURES
        public const string PROC_UPDATE_CONTENT_MODULE_LANGUAGES = "sproc_ContentModuleLanguage_ups";
    }
    #endregion

    #region QuestionnaireSections
    public class QuestionnaireSections
    {
        //PROCEDURES        
        public const string PROC_UPDATE_QUESTNN_SCTION = "sproc_QuestionnaireSectionsMaster_ups";
        public const string PROC_GET_SCTION = "sproc_QuestionnaireSectionsMaster_sel";
        public const string PROC_DELETE_SCTION = "sproc_QuestionnaireSectionsMaster_del";
        public const string PROC_UPDATE_QUESTNN_SCT_LANGUAGE = "sproc_QuestionnaireSectionsLanguage_ups";
        public const string PROC_UPDATE_SEQUENCE = "sproc_QuestionnaireSectionMaster_ups_Sequence";
        public const string PROC_GET_SECTIONS_LANGUAGES = "sproc_QuestionnaireSectionLanguage_sel_List";
        public const string PROC_DELETE_SECTIONLANGUAGE = "sproc_QuestionnaireSectionsLanguage_del";
        public const string PROC_GET_IMPORT_LANGUAGE = "sproc_LanguageMaster_LstQuestSecImport";
        public const string PROC_GET_SECTONS_BY_QUESTIONNAIREID_WISE = "sproc_QuestionnaireSectionLanguage_sel_QuestionnaireId_Wise";

        //PARAMETERS
        public const string COL_QUESTIONNAIRE_ID = "QuestionnaireID";
        public const string COL_SECTION_ID = "SectionID";
        public const string COL_SEQUENCE_ORDER = "SequenceOrder";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_SECTION_TITLE = "SectionTitle";
        public const string COL_SECTION_NAME = "SectionName";
        public const string COL_SECTION_DESC = "SectionDescription";
        //FIELDS
        public const string PARA_QUESTIONNAIRE_ID = "@QuestionnaireID";
        public const string PARA_SECTION_ID = "@SectionID";
        public const string PARA_SEQUENCE_ORDER = "@SequenceOrder";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_SECTION_TITLE = "@SectionTitle";
        public const string PARA_SECTION_NAME = "@SectionName";
        public const string PARA_SECTION_DESC = "@SectionDescription";
    }
    #endregion

    #region AssessmentSections
    public class AssessmentSections
    {
        //PROCEDURES        
        public const string PROC_UPDATE_QUESTNN_SCTION = "sproc_AssessmentSectionsMaster_ups";
        public const string PROC_GET_SCTION = "sproc_AssessmentSectionsMaster_sel";
        public const string PROC_DELETE_SCTION = "sproc_AssessmentSectionsMaster_del";
        public const string PROC_UPDATE_QUESTNN_SCT_LANGUAGE = "sproc_AssessmentSectionsLanguage_ups";
        public const string PROC_UPDATE_SEQUENCE = "sproc_AssessmentSectionMaster_ups_Sequence";

        //PARAMETERS
        public const string COL_Assessment_ID = "AssessmentID";
        public const string COL_SECTION_ID = "SectionID";
        public const string COL_SEQUENCE_ORDER = "SequenceOrder";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_SECTION_TITLE = "SectionTitle";
        public const string COL_SECTION_NAME = "SectionName";
        public const string COL_SECTION_DESC = "SectionDescription";
        //FIELDS
        public const string PARA_Assessment_ID = "@AssessmentID";
        public const string PARA_SECTION_ID = "@SectionID";
        public const string PARA_SEQUENCE_ORDER = "@SequenceOrder";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_SECTION_TITLE = "@SectionTitle";
        public const string PARA_SECTION_NAME = "@SectionName";
        public const string PARA_SECTION_DESC = "@SectionDescription";
    }
    #endregion

    #region QuestionnaireOptions
    public class QuestionnaireOptions
    {
        //PROCEDURES        
        public const string PROC_UPDATE_QUESTNN_OPTION = "sproc_QuestionOptionsMaster_ups";
        public const string PROC_UPDATE_OPTION_MASTER = "sproc_QuestionOptionsMaster_upsByOptionID";
        public const string PROC_DELETE_OPTIONS = "sproc_QuestionOptionsMaster_delByQuestion";
        public const string PROC_UPDATE_QUESTNN_OPT_LANGUAGE = "sproc_QuestionnaireOptionsLanguage_ups";
        //FIELDS
        public const string COL_OPTION_ID = "QuestionOptionsID";
        public const string COL_QUESTIONNAIRE_ID = "QuestionnaireID";
        public const string COL_SECTION_ID = "SectionID";
        public const string COL_QUESTION_ID = "QuestionID";
        public const string COL_IS_EXPLANATION = "IsExplanation";
        public const string COL_GO_TO_QUESTION = "GoToQuestion";
        public const string COL_OPTION_TYPE = "OptionType";
        public const string COL_SEQUENCE_ORDER = "SequenceOrder";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_IS_ALERT = "IsAlert";
        public const string COL_OPTION_TITLE = "OptionTitle";
        public const string COL_OPTION_DESC = "OptionDescription";
        public const string COL_EXPLAINATION_TITLE = "ExplainationTitle";
        public const string COL_IS_LAUNCH_LU = "IsLaunchLU";

        //PARAMETERS
        public const string PARA_OPTION_ID = "@QuestionOptionsID";
        public const string PARA_QUESTIONNAIRE_ID = "@QuestionnaireID";
        public const string PARA_SECTION_ID = "@SectionID";
        public const string PARA_QUESTION_ID = "@QuestionID";
        public const string PARA_IS_EXPLANATION = "@IsExplanation";
        public const string PARA_GO_TO_QUESTION = "@GoToQuestion";
        public const string PARA_OPTION_TYPE = "@OptionType";
        public const string PARA_SEQUENCE_ORDER = "@SequenceOrder";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_IS_ALERT = "@IsAlert";
        public const string PARA_OPTION_TITLE = "@OptionTitle";
        public const string PARA_OPTION_DESC = "@OptionDescription";
        public const string PARA_EXPLAINATION_TITLE = "@ExplainationTitle";
        public const string PARA_IS_LAUNCH_LU = "@IsLaunchLU";
    }
    #endregion

    #region AssessmentOptions
    public class AssessmentOptions
    {
        //PROCEDURES        
        public const string PROC_UPDATE_ASSESSMENT_OPTION = "sproc_AssessmentOptionsMaster_ups";
        public const string PROC_UPDATE_OPTION_MASTER = "sproc_AssessmentOptionsMaster_upsByOptionID";
        public const string PROC_DELETE_OPTIONS = "sproc_AssessmentOptionsMaster_delByQuestion";
        public const string PROC_UPDATE_QUESTNN_OPT_LANGUAGE = "sproc_AssessmentOptionsLanguage_ups";
        //FIELDS
        public const string COL_OPTION_ID = "AssessmentOptionsID";
        public const string COL_ASSESSMENT_ID = "AssessmentID";
        public const string COL_SECTION_ID = "SectionID";
        public const string COL_QUESTION_ID = "QuestionID";
        public const string COL_IS_EXPLANATION = "IsExplanation";
        public const string COL_GO_TO_QUESTION = "GoToQuestion";
        public const string COL_OPTION_TYPE = "OptionType";
        public const string COL_SEQUENCE_ORDER = "SequenceOrder";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_IS_ALERT = "IsAlert";
        public const string COL_OPTION_TITLE = "OptionTitle";
        public const string COL_OPTION_DESC = "OptionDescription";
        public const string COL_EXPLAINATION_TITLE = "ExplainationTitle";

        //PARAMETERS
        public const string PARA_OPTION_ID = "@AssessmentOptionsID";
        public const string PARA_ASSESSMENT_ID = "@AssessmentID";
        public const string PARA_SECTION_ID = "@SectionID";
        public const string PARA_QUESTION_ID = "@QuestionID";
        public const string PARA_IS_EXPLANATION = "@IsExplanation";
        public const string PARA_GO_TO_QUESTION = "@GoToQuestion";
        public const string PARA_OPTION_TYPE = "@OptionType";
        public const string PARA_SEQUENCE_ORDER = "@SequenceOrder";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_IS_ALERT = "@IsAlert";
        public const string PARA_OPTION_TITLE = "@OptionTitle";
        public const string PARA_OPTION_DESC = "@OptionDescription";
        public const string PARA_EXPLAINATION_TITLE = "@ExplainationTitle";
    }
    #endregion

    #region UserQuestionnaireTracking
    public class UserQuestionnaireTracking
    {
        //PROCEDURES        
        public const string PROC_CREATE_CURRENT_ATTEMPT = "sproc_UserQuestionnaireTracking_ups_sel";
        public const string PROC_GET_CURRENT_ATTEMPT = "sproc_UserQuestionnaireTracking_sel";
        public const string PROC_GET_TRACKING_STATUS = "sproc_GetUserQuestionnaireCompletionStatus";
        public const string PROC_UPDATE_CURRENT_ATTEMPT = "sproc_UserQuestionnaireTracking_ups";
        public const string PROC_UPDATE_MARK_COMPLETED = "sproc_UserQuestionnaireTracking_ups_MarkCompleted";

        //PROCS FOR ADMIN
        public const string PROC__QUESTIONNAIRE_TRACKING_FOR_ADMIN_PREVIEW_DEL = "sproc_QuestionnaireTrackingForAdminPreview_Del";

        //FIELDS
        public const string COL_QUESTIONNAIRE_ID = "QuestionnaireID";
        public const string COL_ATTEMPT_ID = "QuestionnaireAttemptId";
        public const string COL_SUBMISSION_STATUS = "SubmissionStatus";
        public const string COL_START_DATE = "StartDate";
        public const string COL_COMPLETED_DATE = "CompletatedDate";
        public const string COL_ATTEMP_LANGUAGE_ID = "AttemptLanguageId";
        public const string COL_MARKED_COMPLETED_BY_ID = "MarkedCompletedById";
        public const string COL_SCANNED_CERTIFICATION_FILE_NAME = "scannedcertificationFileName";
        public const string COL_ACTIVITY_NAME = "ActivityName";
        public const string COL_USER_FIRST_LAST_NAME = "UserFirstLastName";
        public const string COL_REVIEWER_COMMENTS = "ReviewerComments";
        public const string COL_IS_FOR_ADMIN_PREVIEW = "IsForAdminPreview";

        //PARAMETERS
        public const string PARA_QUESTIONNAIRE_ID = "@QuestionnaireID";
        public const string PARA_ATTEMPT_ID = "@QuestionnaireAttemptId";
        public const string PARA_SUBMISSION_STATUS = "@SubmissionStatus";
        public const string PARA_START_DATE = "@StartDate";
        public const string PARA_COMPLETED_DATE = "@CompletedDate";
        public const string PARA_ATTEMP_LANGUAGE_ID = "@AttemptLanguageId";
        public const string PARA_MARKED_COMPLETED_BY_ID = "@MarkedCompletedById";
        public const string PARA_SCANNED_CERTIFICATION_FILE_NAME = "@scannedcertificationFileName";
        public const string PARA_ACTIVITY_NAME = "@ActivityName";
        public const string PARA_USER_FIRST_LAST_NAME = "@UserFirstLastName";
        public const string PARA_REVIEWER_COMMENTS = "@ReviewerComments";
        public const string PARA_IS_FOR_ADMIN_PREVIEW = "@IsForAdminPreview";

    }
    #endregion

    #region UserAssessmentTracking
    public class UserAssessmentTracking
    {
        //PROCEDURES        
        public const string PROC_ASSESSMENT_ATTEMPTALLOW = "sproc_Assessment_AttemptAllow";
        public const string PROC_CREATE_CURRENT_ATTEMPT = "sproc_UserAssessmentTracking_ups_sel";
        public const string PROC_GET_CURRENT_ATTEMPT = "sproc_UserAssessmentTracking_sel";
        public const string PROC_GET_ASSESSMENT_SUMMARY = "sproc_GetAssessmentResponseSummary";
        public const string PROC_GET_TRACKING_STATUS = "sproc_GetUserAssessmentCompletionStatus";
        public const string PROC_UPDATE_CURRENT_ATTEMPT = "sproc_UserAssessmentTracking_ups";
        public const string PROC_UPDATE_MARK_COMPLETED = "sproc_UserAssessmentTracking_ups_MarkCompleted";

        //PROCS FOR ADMIN
        public const string PROC__Assessment_TRACKING_FOR_ADMIN_PREVIEW_DEL = "sproc_AssessmentTrackingForAdminPreview_Del";

        //FIELDS
        public const string COL_ASSESSMENT_ID = "AssessmentID";
        public const string COL_ATTEMPT_ID = "AssessmentAttemptId";
        public const string COL_SUBMISSION_STATUS = "SubmissionStatus";
        public const string COL_START_DATE = "StartDate";
        public const string COL_COMPLETED_DATE = "CompletatedDate";
        public const string COL_ATTEMP_LANGUAGE_ID = "AttemptLanguageId";
        public const string COL_MARKED_COMPLETED_BY_ID = "MarkedCompletedById";
        public const string COL_SCANNED_CERTIFICATION_FILE_NAME = "scannedcertificationFileName";
        public const string COL_ACTIVITY_NAME = "ActivityName";
        public const string COL_USER_FIRST_LAST_NAME = "UserFirstLastName";
        public const string COL_REVIEWER_COMMENTS = "ReviewerComments";
        public const string COL_IS_FOR_ADMIN_PREVIEW = "IsForAdminPreview";

        public const string COL_TOTAL_QUESTIONCOUNT = "TotalQuestionCount";
        public const string COL_CORRECT_QUESTIONCOUNT = "CorrectQuestionCount";
        public const string COL_INCORRECT_QUESTIONCOUNT = "InCorrectQuestionCount";
        public const string COL_SCORE = "Score";

        //PARAMETERS
        public const string PARA_ASSESSMENT_ID = "@AssessmentID";
        public const string PARA_ATTEMPT_ID = "@AssessmentAttemptId";
        public const string PARA_SUBMISSION_STATUS = "@SubmissionStatus";
        public const string PARA_START_DATE = "@StartDate";
        public const string PARA_COMPLETED_DATE = "@CompletedDate";
        public const string PARA_ATTEMP_LANGUAGE_ID = "@AttemptLanguageId";
        public const string PARA_MARKED_COMPLETED_BY_ID = "@MarkedCompletedById";
        public const string PARA_SCANNED_CERTIFICATION_FILE_NAME = "@scannedcertificationFileName";
        public const string PARA_ACTIVITY_NAME = "@ActivityName";
        public const string PARA_USER_FIRST_LAST_NAME = "@UserFirstLastName";
        public const string PARA_REVIEWER_COMMENTS = "@ReviewerComments";
        public const string PARA_IS_FOR_ADMIN_PREVIEW = "@IsForAdminPreview";

    }
    #endregion

    #region UserQuestSessionResponse
    public class UserQuestSessionResponse
    {
        //PROCEDURES        

        public const string PROC_UPDATE_USER_RESPONSE = "sproc_UserQuestionnaireSessionResponses_ups";
        public const string PROC_DELETE_MULTIPE_ADMIN_RESPONSE = "sproc_UserQuestionnaireSessionResponses_delMultiple";


        //FIELDS
        public const string COL_QUESTIONNAIRE_ID = "QuestionnaireID";
        public const string COL_ATTEMPT_ID = "QuestionnaireAttemptId";
        public const string COL_OPTION_ID = "QuestionOptionsID";
        public const string COL_SECTION_ID = "SectionID";
        public const string COL_QUESTION_ID = "QuestionID";
        public const string COL_EXPLANATION_TEXT = "ExplanationText";
        public const string COL_DATE_SUBMITTED = "DateSubmitted";
        public const string COL_REVIEWER_COMMENTS = "ReviewerComments";
        public const string COL_IS_FOR_ADMIN_PREVIEW = "IsForAdminPreview";

        //PARAMETERS
        public const string PARA_QUESTIONNAIRE_ID = "@QuestionnaireID";
        public const string PARA_ATTEMPT_ID = "@QuestionnaireAttemptId";
        public const string PARA_OPTION_ID = "@QuestionOptionsID";
        public const string PARA_SECTION_ID = "@SectionID";
        public const string PARA_QUESTION_ID = "@QuestionID";
        public const string PARA_EXPLANATION_TEXT = "@ExplanationText";
        public const string PARA_DATE_SUBMITTED = "@DateSubmitted";
        public const string PARA_REVIEWER_COMMENTS = "@ReviewerComments";
        public const string PARA_IS_FOR_ADMIN_PREVIEW = "@IsForAdminPreview";


    }
    #endregion

    #region UserAssessmentSessionResponse
    public class UserAssessmentSessionResponse
    {
        //PROCEDURES        

        public const string PROC_UPDATE_USER_RESPONSE = "sproc_UserAssessmentSessionResponses_ups";
        public const string PROC_DELETE_MULTIPE_ADMIN_RESPONSE = "sproc_UserAssessmentSessionResponses_delMultiple";


        //FIELDS
        public const string COL_ASSESSMENT_ID = "AssessmentID";
        public const string COL_ATTEMPT_ID = "AssessmentAttemptId";
        public const string COL_OPTION_ID = "AssessmentOptionsID";
        public const string COL_SECTION_ID = "SectionID";
        public const string COL_QUESTION_ID = "QuestionID";
        public const string COL_EXPLANATION_TEXT = "ExplanationText";
        public const string COL_DATE_SUBMITTED = "DateSubmitted";
        public const string COL_REVIEWER_COMMENTS = "ReviewerComments";
        public const string COL_IS_FOR_ADMIN_PREVIEW = "IsForAdminPreview";
        public const string COL_SEQ_NO = "SeqNo";

        //PARAMETERS
        public const string PARA_ASSESSMENT_ID = "@AssessmentID";
        public const string PARA_ATTEMPT_ID = "@AssessmentAttemptId";
        public const string PARA_OPTION_ID = "@AssessmentOptionsID";
        public const string PARA_SECTION_ID = "@SectionID";
        public const string PARA_QUESTION_ID = "@QuestionID";
        public const string PARA_EXPLANATION_TEXT = "@ExplanationText";
        public const string PARA_DATE_SUBMITTED = "@DateSubmitted";
        public const string PARA_REVIEWER_COMMENTS = "@ReviewerComments";
        public const string PARA_IS_FOR_ADMIN_PREVIEW = "@IsForAdminPreview";
        public const string PARA_SEQ_NO = "@SeqNo";


    }
    #endregion

    #region QuestionnaireQuestion
    public class QuestionnaireQuestion
    {
        //PROCEDURES        
        public const string PROC_UPDATE_QUESTNN_QUESTION = "sproc_QuestionnaireQuestionMaster_ups";
        public const string PROC_DELETE_QUESTION = "sproc_QuestionnaireQuestionMaster_del";
        public const string PROC_UPDATE_QUESTNN_QUEST_LANGUAGE = "sproc_QuestionnaireQuestionLanguage_ups";

        public const string PROC_UPDATE_SEQUENCE = "sproc_QuestionnaireQuestionMaster_ups_Sequence";
        public const string PROC_GET_QUESTIONS_LANGUAGES = "sproc_QuestionnaireQuestionLanguage_sel_List";
        public const string PROC_DELETE_QUESTION_LANGUAGE = "sproc_QuestionnaireQuestionLanguage_del";
        public const string PROC_GET_QUESTIONS_BY_SECTIONID_WISE = "sproc_QuestionnaireQuestionLanguage_sel_SectionId_Wise";

        //FIELDS
        public const string COL_QUESTION_ID = "QuestionID";
        public const string COL_QUESTIONNAIRE_ID = "QuestionnaireID";
        public const string COL_SECTION_ID = "SectionID";
        public const string COL_QUESTION_TYPE = "QuestionType";
        public const string COL_SEQUENCE_ORDER = "SequenceOrder";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_IS_REVIEW_ALERT = "IsReviewAlert";


        public const string COL_QUESTION_TITLE = "QuestionTitle";
        public const string COL_QUESTION_DESC = "QuestionDescription";

        //PARAMETERS
        public const string PARA_QUESTION_ID = "@QuestionID";
        public const string PARA_QUESTIONNAIRE_ID = "@QuestionnaireID";
        public const string PARA_SECTION_ID = "@SectionID";
        public const string PARA_QUESTION_TYPE = "@QuestionType";
        public const string PARA_SEQUENCE_ORDER = "@SequenceOrder";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_IS_REVIEW_ALERT = "@IsReviewAlert";
        public const string PARA_QUESTION_TITLE = "@QuestionTitle";
        public const string PARA_QUESTION_DESC = "@QuestionDescription";
        public const string PARA_IS_UP = "@IsUp";
    }
    #endregion

    #region CourseAssessmentQuestion

    public class CourseAssessmentQuestion
    {
        //Procs name constants
        public const string PROC_UPDATE = "sproc_AssessmentQuestions_ups";
        public const string PROC_GET = "sproc_AssessmentQuestions_sel";
        public const string PROC_DEL = "sproc_AssessmentQuestions_del";
        public const string PROC_GET_ALL = "sproc_AssessmentQuestions_LstAll";

        //Parameters constants
        public const string PARA_ASSESSMENTQUESTION_ID = "@AssessmentQuestion_Id";
        public const string PARA_QUESTION_ID = "@QuestionId";
        public const string PARA_CONTENTMODULE_ID = "@ContentModuleId";
        public const string PARA_QUESTION_TEXT = "@QuestionText";
        public const string PARA_QUESTION_UNIQUE_INDX_NUM = "@QuestionUniqueIndxNum";

        //Column constants
        public const string COL_QUESTION_ID = "QuestionId";
        public const string COL_CONTENTMODULE_ID = "ContentModuleId";
        public const string COL_QUESTION_TEXT = "QuestionText";
        public const string COL_QUESTION_UNIQUE_INDX_NUM = "QuestionUniqueIndxNum";
    }
    #endregion
    #region AssessmentQuestion
    public class AssessmentQuestion
    {
        //PROCEDURES        
        public const string PROC_UPDATE_ASSESSMENT_QUESTION = "sproc_AssessmentQuestionMaster_ups";
        public const string PROC_DELETE_QUESTION = "sproc_AssessmentQuestionMaster_del";
        public const string PROC_UPDATE_ASSESSMENT_QUEST_LANGUAGE = "sproc_AssessmentQuestionLanguage_ups";

        public const string PROC_UPDATE_SEQUENCE = "sproc_AssessmentQuestionMaster_ups_Sequence";


        //FIELDS
        public const string COL_QUESTION_ID = "QuestionID";
        public const string COL_ASSESSMENT_ID = "AssessmentID";
        public const string COL_SECTION_ID = "SectionID";
        public const string COL_QUESTION_TYPE = "QuestionType";
        public const string COL_SEQUENCE_ORDER = "SequenceOrder";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_IS_MAPPING_ACTIVE = "IsMappingActive";

        public const string COL_QUESTION_TITLE = "QuestionTitle";
        public const string COL_QUESTION_DESC = "QuestionDescription";

        //PARAMETERS
        public const string PARA_QUESTION_ID = "@QuestionID";
        public const string PARA_ASSESSMENT_ID = "@AssessmentID";
        public const string PARA_SECTION_ID = "@SectionID";
        public const string PARA_QUESTION_TYPE = "@QuestionType";
        public const string PARA_SEQUENCE_ORDER = "@SequenceOrder";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_QUESTION_TITLE = "@QuestionTitle";
        public const string PARA_QUESTION_DESC = "@QuestionDescription";
        public const string PARA_IS_UP = "@IsUp";
    }
    #endregion


    #region Certification
    public class Certification
    {
        //PROCEDURES
        public const string PROC_GET_CERTIFICATION_MASTER_ID = "sproc_CertificationMaster_sel";
        public const string PROC_GET_CERTIFICATION_BY_NAME = "sproc_CertificationMaster_selByName";
        public const string PROC_UPDATE_CERTIFICATION = "sproc_CertificationMaster_ups";
        public const string PROC_FIND_CERTIFICATIONS = "sproc_CertificationMaster_Sel_Search";
        public const string PROC_DELETE_CERTIFICATION = "sproc_CertificationMaster_del";
        public const string PROC_DELETE_CERTIFICATION_LANGUAGE = "sproc_CertificationLanguageMaster_del_Language";
        public const string PROC_GET_ALL_CERTIFICATION = "sproc_CertificationMaster_LstAll";
        public const string PROC_GET_ALL_CERTIFICATION_ACTIVITIES = "sproc_CertificationActivity_LstAll";
        public const string PROC_CERTIFICATIONPENDINGREVIEW_LSTREVIEWEREMAIL = "sproc_CertificationPendingReview_LstReviewerEmail";
        public const string PROC_GET_CERTIFICATION_LANGUAGES = "sproc_CertificationLanguage_sel_List";
        public const string PROC_UPDATE_CERTIFICATION_LANGUAGE = "sproc_CertificationMaster_ups_Language";

        //PARAMETERS
        public const string PARA_CERTIFICATION_ID = "@CertificationId";
        public const string PARA_CERTIFICATION_NAME = "@CertificationName";
        public const string PARA_CERTIFICATION_DESC = "@CertificationDescription";
        public const string PARA_CERTIFICATION_INSTRUCTION = "@CertificationInstruction";
        public const string PARA_IS_REVIEW_LOCKED = "@IsReviewLocked";
        public const string PARA_IS_PRINT_CERTIFICATE = "@IsPrintCertificate";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_COMPLETION_CONDITION_ID = "@CompletionConditionId";
        public const string PARA_ADDITIONAL_LINKS = "@AdditionalLinks";
        public const string PARA_IS_USED = "@IsUsed";
        public const string PARA_LU_CLASSIFICATION_ID = "@LUClassificationId";
        public const string PARA_LU_CLASSIFICATION_NAME = "@LUClassificationName";
        public const string PARA_LU_ISENABLED = "@IsEnabled";
        public const string PARA_LU_ISLAUNCHIN_NEWWINDOW = "@IsLaunchInNewWindow";
        public const string PARA_CERTIFICATIONPENDINGREVIEW_ACTIVITYIDS = "@ActivityID";
        public const string PARA_CREATED_BY_ID = "@CreatedById";
        //FIELDS
        public const string COL_CERTIFICATION_ID = "CertificationId";
        public const string COL_CERTIFICATION_NAME = "CertificationName";
        public const string COL_CERTIFICATION_DESC = "CertificationDescription";
        public const string COL_CERTIFICATION_INSTRUCTION = "CertificationInstruction";
        public const string COL_IS_REVIEW_LOCKED = "IsReviewLocked";
        public const string COL_IS_PRINT_CERTIFICATE = "IsPrintCertificate";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_COMPLETION_CONDITION_ID = "CompletionConditionId";
        public const string COL_ADDITIONAL_LINKS = "AdditionalLinks";
        public const string COL_LU_CLASSIFICATION_ID = "LUClassificationId";
        public const string COL_LU_CLASSIFICATION_NAME = "LUClassificationName";
        public const string COL_LU_ISENABLED = "IsEnabled";
        public const string COL_LU_ISLAUNCHIN_NEWWINDOW = "IsLaunchInNewWindow";
        public const string COL_CREATED_BY_ID = "CreatedById";

    }
    #endregion

    #region CertificationActivity
    public class CertificationActivity
    {
        //PROCEDURES
        public const string PROC_GET_CERTIFICATION_ACTIVITY_ISQUESTIONNAIREACTIVE_LEARNER = "sproc_CertificationActivity_IsQuestionnaireActive_Learner";
        public const string PROC_GET_CERTIFICATION_ACTIVITY_MASTER_ID = "sproc_CertificationActivity_sel";
        public const string PROC_UPDATE_CERTIFICATION_ACTIVITY = "sproc_CertificationActivity_ups";
        public const string PROC_DELETE_NOT_IN_ACTIVITY = "sproc_CertificationActivity_delMultiple";
        public const string PROC_GET_ALL_CERTIFICATION_ACTIVITIES = "sproc_CertificationActivity_LstAll";
        public const string PROC_GET_ALL_CERTIFICATION_ACTIVITIES_BY_ATTEMPT = "sproc_CertificationActivity_LstAll_By_Attempt";



        //PARAMETERS
        public const string PARA_CERTIFICATION_ID = "@CertificationId";
        public const string PARA_ACTIVITY_ID = "@CertificationActivityId";
        public const string PARA_ACTIVITY_COMPLETION_CONDITION_ID = "@ActivityCompletionConditionId";
        public const string PARA_ACTIVITY_TYPE = "@CertificationActivityType";
        public const string PARA_ACTIVITY_NAME = "@ActivityName";
        public const string PARA_SORT_ORDER = "@DisplayOrder";

        //FIELDS
        public const string COL_CERTIFICATION_ID = "CertificationId";
        public const string COL_CERTIFICATION_ACTIVITY_ID = "CertificationActivityId";
        public const string COL_ACTIVITY_COMPLETION_CONDITION_ID = "ActivityCompletionConditionId";
        public const string COL_ACTIVITY_TYPE = "CertificationActivityType";
        public const string COL_ACTIVITY_NAME = "ActivityName";
        public const string COL_SORT_ORDER = "DisplayOrder";
        public const string COL_IS_QUESTIONNAIRE_ACTIVE = "IsQuestionnaireActive";

    }
    #endregion

    #region Task
    public class Task
    {
        //PROCEDURES        
        public const string PROC_GET_TASK_BY_ID = "sproc_TaskMaster_sel";
        public const string PROC_UPDATE_TASK = "sproc_TaskMaster_ups";
        public const string PROC_DELETE_TASK = "sproc_TaskMaster_del";
        public const string PROC_GET_ALL_TASK = "sproc_TaskMaster_LstAll";
        public const string PROC_UPDATE_TASK_STATUS = "sproc_TaskMaster_ups_Status";
        public const string PROC_GET_INPROGRESS_TASK_COUNT = "sproc_TaskMaster_sel_InProgress";
        public const string PROC_UPDATE_TASK_SET_ABORT = "sproc_TaskMaster_ups_SetAbort";



        //PARAMETERS
        public const string PARA_TASK_ID = "@TaskId";
        public const string PARA_TASK_NAME = "@TaskName";
        public const string PARA_TASK_DESC = "@TaskDescription";
        public const string PARA_IS_ONE_TIME = "@IsOneTime";
        public const string PARA_IS_IMMEDIATE = "@IsImmediate";
        public const string PARA_IS_DAILY = "@IsDaily";
        public const string PARA_IS_WEEKLY = "@IsWeekly";
        public const string PARA_IS_MONTHLY = "@IsMonthly";
        public const string PARA_IS_WEEK_DAYS_ONLY = "@IsWeekDaysOnly";
        public const string PARA_TASK_START_DATE = "@TaskStartDate";
        public const string PARA_TASK_END_DATE = "@TaskEndDate";
        public const string PARA_TASK_TYPE = "@TaskType";
        public const string PARA_IS_ENABLED = "@IsEnabled";
        public const string PARA_CLIENT_ID = "@ClientId";

        public const string PARA_EXECUTION_STATUS = "@ExecutionStatus";

        public const string PARA_DAY_OF_WEEK = "@DayOfWeek";
        public const string PARA_DAY_OF_MONTH = "@DayOftheMonth";
        public const string PARA_RECURRENCE = "@Recurrence";

        //FIELDS
        public const string COL_TASK_ID = "TaskId";
        public const string COL_TASK_NAME = "TaskName";
        public const string COL_TASK_DESC = "TaskDescription";
        public const string COL_IS_ONE_TIME = "IsOneTime";
        public const string COL_IS_IMMEDIATE = "IsImmediate";
        public const string COL_IS_DAILY = "IsDaily";
        public const string COL_IS_WEEKLY = "IsWeekly";
        public const string COL_IS_MONTHLY = "IsMonthly";
        public const string COL_IS_WEEK_DAYS_ONLY = "IsWeekDaysOnly";
        public const string COL_TASK_START_DATE = "TaskStartDate";
        public const string COL_TASK_END_DATE = "TaskEndDate";
        public const string COL_TASK_TYPE = "TaskType";
        public const string COL_IS_ENABLED = "IsEnabled";
        public const string COL_CLIENT_ID = "ClientId";
        public const string COL_LAST_MODIFIED_BY_ID = "LastModifiedById";
        public const string COL_DATE_CREATED = "DateCreated";

        public const string COL_EXECUTION_STATUS = "ExecutionStatus";

        public const string COL_DAY_OF_WEEK = "DayOfWeek";
        public const string COL_DAY_OF_MONTH = "DayOftheMonth";
        public const string COL_RECURRENCE = "Recurrence";
        public const string COL_RUN_END_TIME = "RunEndTime";
        public const string COL_BASE_REPORT_NAME = "BaseReport";
        public const string COL_CREATED_BY_NAME = "CreatedByName";
        public const string COL_REPORT_INSTANCE_ID = "ReportInstanceId";

    }
    #endregion

    #region MasterTaskJob
    public class MasterTaskJob
    {
        //PROCEDURES
        public const string PROC_UPS_MASTER_TASK = "sproc_MasterTaskJob_ups";
        public const string PROC_GET_ALL_OPENEMAIL = "sproc_MasterTaskJob_ListAll_OpenEmail";
        public const string PROC_GET_ALL_OPENIMPORT = "sproc_MasterTaskJob_ListAll_OpenImport";
        public const string PROC_GET_ALL_OPENREPORT = "sproc_MasterTaskJob_ListAll_OpenReport";


        //PARAMETERS
        public const string PARA_JOB_ID = "@JobId";
        public const string PARA_TASK_TYPE = "@TaskType";
        public const string PARA_TASK_STATUS = "@TaskStatus";


        //FIELDS
        public const string COL_JOB_ID = "JobId";
        public const string COL_TASK_TYPE = "TaskType";
        public const string COL_TASK_STATUS = "TaskStatus";
        public const string COL_CLIENT_ID = "ClientId";
        public const string COL_SCHEDULEDDATETIME = "ScheduledDateTime";
    }
    #endregion

    #region SourceCluster
    public class SourceCluster
    {
        //PROCEDURES        
        public const string PROC_UPS_SOURCE_CLUSTER = "sproc_SourceClusterMaster_Ups";
        public const string PROC_GET_SOURCE_CLUSTER = "sproc_SourceClusterMaster_Sel";

        //PARAMETERS
        public const string PARA_CLIENTID = "@ClientId";
        public const string PARA_FTPFOLDERNAME = "@FTPFolderName";

        //FIELDS
        public const string COL_CLIENTID = "ClientId";
        public const string COL_FTPUPLOADPATH = "FTPUploadPath";
        public const string COL_FTPUSERNAME = "FTPUserName";
        public const string COL_FTPPASSWORD = "FTPPassword";
        public const string COL_FTPFOLDERNAME = "FTPFolderName";
        public const string COL_CONTENTFOLDERPATH = "ContentFolderPath";
    }
    #endregion

    #region TaskRunHistory
    public class TaskRunHistory
    {
        //PROCEDURES        
        public const string PROC_GET_TASK_RUN_HISTORY_BY_ID = "sproc_TaskRunHistory_sel";
        public const string PROC_UPDATE_TASK_RUN_HISTORY = "sproc_TaskRunHistory_ups";
        public const string PROC_GET_ALL_TASK_RUN_HISTORY = "sproc_TaskRunHistory_LstAll";

        //PARAMETERS
        public const string PARA_RUN_HISTORY_ID = "@RunHistoryId";
        public const string PARA_TASK_ID = "@TaskId";
        public const string PARA_RUN_START_TIME = "@RunStartTime";
        public const string PARA_RUN_END_TIME = "@RunEndTime";
        public const string PARA_EXECUTION_STATUS = "@ExecutionStatus";
        public const string PARA_GENERATED_REPORT_FILENAME = "@GeneratedReportFileName";

        //FIELDS
        public const string COL_RUN_HISTORY_ID = "RunHistoryId";
        public const string COL_TASK_ID = "TaskId";
        public const string COL_RUN_START_TIME = "RunStartTime";
        public const string COL_RUN_END_TIME = "RunEndTime";
        public const string COL_EXECUTION_STATUS = "ExecutionStatus";
        public const string COL_GENERATED_REPORT_FILENAME = "GeneratedReportFileName";

    }
    #endregion

    #region ContentModuleAllocationLicensing
    public class ContentModuleAllocationLicensing
    {
        //PROCEDURES
        public const string PROC_GET_CONTENT_MODULE_ALLOCATION = "sproc_ContentModuleAllocationLicensing_sel";
        public const string PROC_GET_BY_NAME_CONTENT_MODULE_ALLOCATION = "sproc_ContentModuleAllocationLicensing_sel_ByName";
        public const string PROC_UPDATE_CONTENT_MODULE_ALLOCATION = "sproc_ContentModuleAllocationLicensing_ups";
        public const string PROC_DELETE_CONTENT_MODULE_ALLOCATION = "sproc_ContentModuleAllocationLicensing_del";
        public const string PROC_GET_ALL_CONTENT_MODULE_ALLOCATIONS = "sproc_ContentModuleAllocationLicensing_LstAll";
        public const string PROC_UPDATE_CONTENT_MODULE = "sproc_ContentModuleAllocation_ups";
        public const string PROC_DELETE_SEL_CONTENT_MODULE = "sproc_ContentModuleAllocation_delMultiple";

        //PARAMETERS
        public const string PARA_LICENSE_ID = "@LicenseId";
        public const string PARA_ENROLLMENT_NAME = "@EnrollmentName";
        public const string PARA_ALLOCATION_TYPE = "@AllocationType";
        public const string PARA_ALLOCATION_DATE = "@AllocationDate";
        public const string PARA_EXPIRY_DATE = "@ExpiryDate";
        public const string PARA_NUMBER_OF_LICENSES = "@NumberOfLicenses";
        public const string PARA_IS_DEFAULT = "@IsDefault";
        public const string PARA_IS_ACTIVE = "@IsActive";



        //FIELDS
        public const string COL_LICENSE_ID = "LicenseId";
        public const string COL_ENROLLMENT_NAME = "EnrollmentName";
        public const string COL_ALLOCATION_TYPE = "AllocationType";
        public const string COL_ALLOCATION_DATE = "AllocationDate";
        public const string COL_EXPIRY_DATE = "ExpiryDate";
        public const string COL_NUMBER_OF_LICENSES = "NumberOfLicenses";
        public const string COL_LICENSES_CONSUMED = "LicensesConsumed";
        public const string COL_IS_DEFAULT = "IsDefault";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_COURSE_NAME = "CourseName";
    }
    #endregion

    #region ContentModuleAllocationDetails
    public class ContentModuleAllocationDetails
    {
        //PROCEDURES
        public const string PROC_GET_CONTENT_MODULE_ALLOCATION_DETAILS = "sproc_ContentModuleAllocationDetails_sel";
        public const string PROC_UPDATE_CONTENT_MODULE_ALLOCATION_DETAILS = "sproc_ContentModuleAllocationDetails_ups";
        public const string PROC_DELETE_CONTENT_MODULE_ALLOCATION_DETAILS = "sproc_ContentModuleAllocationDetails_del";
        public const string PROC_GET_ALL_CONTENT_MODULE_DEFAULT_ASSIGNMENT_DETAILS = "sproc_ContentModuleDefaultAssignment_LstAll";
        public const string PROC_UPDATE_CONTENT_MODULE_ALLOCATION_DETAILS_ADMIN = "sproc_ContentModuleDefaultAllocatiion_ups_Admin";
        public const string PROC_GET_CONTENT_MODULE_ALLOCATION_DETAILS_AT_SITE_ADMIN = "sproc_ContentModuleDefaultAssignment_Admin_Sel";

        //PARAMETERS
        public const string PARA_LICENSE_ID = "@LicenseId";
        public const string PARA_CONTENT_MODULE_ID = "@ContentModuleId";
        public const string PARA_IS_DEFAULT = "@IsDefault";
        public const string PARA_CONTENT_MODULE_ENGLISH_NAME = "@ContentModuleEnglishName";

        //FIELDS
        public const string COL_LICENSE_ID = "LicenseId";
        public const string COL_CONTENT_MODULE_ID = "ContentModuleId";
        public const string COL_CONTENT_MODULE_ENGLISH_NAME = "ContentModuleEnglishName";
        public const string COL_IS_DEFAULT = "IsDefault";

        public const string COL_IS_ASSIGNMENT_BASED_ON_HIRE_DATE = "IsAssignmentBasedOnHireDate";
        public const string COL_IS_ASSIGNMENT_BASED_ON_CREATION_DATE = "IsAssignmentBasedOnCreationDate";
        public const string COL_ASSIGN_AFTER_DAYS_OF = "AssignAfterDaysOf";
        public const string COL_ASSIGNMENT_DATE_SET = "AssignmentDateSet";
        public const string COL_IS_NO_DUE_DATE = "IsNoDueDate";
        public const string COL_IS_DUE_BASED_ON_ASSIGN_DATE = "IsDueBasedOnAssignDate";
        public const string COL_IS_DUE_BASED_ON_HIRE_DATE = "IsDueBasedOnHireDate";
        public const string COL_IS_DUE_BASED_ON_CREATION_DATE = "IsDueBasedOnCreationDate";
        public const string COL_IS_DUE_BASED_ON_START_DATE = "IsDueBasedOnStartDate";
        public const string COL_DUE_AFTER_DAYS_OF = "DueAfterDaysOf";
        public const string COL_DUE_DATE_SET = "DueDateSet";
        public const string COL_IS_NO_EXPIRY_DATE = "IsNoExpiryDate";
        public const string COL_IS_EXPIRY_BASED_ON_ASSIGN_DATE = "IsExpiryBasedOnAssignDate";
        public const string COL_IS_EXPIRY_BASED_ON_START_DATE = "IsExpiryBasedOnStartDate";
        public const string COL_IS_EXPIRY_BASED_ON_DUE_DATE = "IsExpiryBasedOnDueDate";
        public const string COL_EXPIRE_AFTER_DAYS_OF = "ExpireAfterDaysOf";
        public const string COL_EXPIRY_DATE_SET = "ExpiryDateSet";
    }
    #endregion

    #region PasswordPolicyConfiguration
    public class PasswordPolicyConfiguration
    {
        //PROCEDURES
        public const string PROC_UPDATE_PASSWORD_POLICY_CONFIGURATION = "sproc_ClientPasswordPolicyConfiguration_ups";
        public const string PROC_GET_ALL_PASSWORD_POLICY_CONFIGURATION = "sproc_ClientPasswordPolicyConfiguration_LstAll";

        //PARAMETERS
        public const string PARA_PWD_POLICY_ID = "@PasswordPolicyId";
        public const string PARA_MAX_PWD_LEN = "@MaxPaswordLength";
        public const string PARA_MIN_PWD_LEN = "@MinPaswordLength";
        public const string PARA_DEFAULT_PWD = "@DefaultPassword";
        public const string PARA_IS_CONFIRM_PWD = "@IsConfirmPassword";
        public const string PARA_PWD_EXPIRY_DURATION = "@PasswordExpiryDuration";
        public const string PARA_MAX_LOGIN_ATTEMPTS = "@MaxLoginAttempts";
        public const string PARA_PWD_NEVER_EXPIRES = "@PasswordNeverExpires";
        public const string PARA_PWD_CAN_NOT_CHANGE = "@PasswordCannotChange";
        public const string PARA_IS_PRE_PWD_ALLOWED = "@IsPrevPasswordAllowed";
        public const string PARA_PRE_PWD_HISTORY_COUNT = "@PrevPasswordHistoryCount";
        public const string PARA_IS_UPPER_CASE = "@IsUpperCase";
        public const string PARA_IS_LOWER_CASE = "@IsLowerCase";
        public const string PARA_IS_NUMBER = "@IsNumber";
        public const string PARA_IS_SPECIAL_CHAR = "@IsSpecialCaracter";
        public const string PARA_IS_PASSWORD_CHANGE = "@IsPasswordChange";
        public const string PARA_IS_DEFALUTPASSWORD_FORUI = "@IsDefaultPasswordforUi";

        //FIELDS        
        public const string COL_PWD_POLICY_ID = "PasswordPolicyId";
        public const string COL_MAX_PWD_LEN = "MaxPaswordLength";
        public const string COL_MIN_PWD_LEN = "MinPaswordLength";
        public const string COL_DEFAULT_PWD = "DefaultPassword";
        public const string COL_IS_CONFIRM_PWD = "IsConfirmPassword";
        public const string COL_PWD_EXPIRY_DURATION = "PasswordExpiryDuration";
        public const string COL_MAX_LOGIN_ATTEMPTS = "MaxLoginAttempts";
        public const string COL_PWD_NEVER_EXPIRES = "PasswordNeverExpires";
        public const string COL_PWD_CAN_NOT_CHANGE = "PasswordCannotChange";
        public const string COL_IS_PRE_PWD_ALLOWED = "IsPrevPasswordAllowed";
        public const string COL_PRE_PWD_HISTORY_COUNT = "PrevPasswordHistoryCount";
        public const string COL_IS_UPPER_CASE = "IsUpperCase";
        public const string COL_IS_LOWER_CASE = "IsLowerCase";
        public const string COL_IS_NUMBER = "IsNumber";
        public const string COL_IS_SPECIAL_CHAR = "IsSpecialCaracter";
        public const string COL_IS_PasswordChange = "IsPasswordChange";
        public const string COL_IS_DEFALUTPASSWORD_FORUI = "IsDefaultPasswordforUi";
    }
    #endregion

    #region CourseConfiguration
    public class CourseConfiguration
    {
        //PROCEDURES        
        public const string PROC_GET_COURSE_CONFIGURATION_BY_ID = "sproc_ClientCourseConfiguration_sel";
        public const string PROC_UPDATE_COURSE_CONFIGURATION = "sproc_ClientCourseConfiguration_ups";
        public const string PROC_GET_ALL_COURSE_CONFIGURATION = "sproc_ClientCourseConfiguration_LstAll";
        public const string PROC_GET_AV_PATH_COURSE_CONFIGURATION = "sproc_ClientCourseConfiguration_AVPath";
        public const string PROC_GET_MASTERY_SCORE_COURSE_CONFIGURATION = "sproc_ClientCourseConfiguration_MasteryScore";

        //PARAMETERS
        public const string PARA_COURSE_CONFIGURATION_ID = "@CourseConfigurationId";
        public const string PARA_IS_COURSE_SESSION_NO_EXPIRY = "@IsCourseSessionNoExpiry";
        public const string PARA_COURSE_SESSION_NEVER_EXPIRES = "@CourseSessionNeverExpires";

        public const string PARA_MAX_FILE_UPLOAD_SIZE_MB = "@MaxFileUploadSizeMB";
        public const string PARA_SCORE_TRACKING = "@ScoreTracking";
        public const string PARA_QUESTION_RESPONSE_TRACKING = "@QuestionResponseTracking";
        public const string PARA_MASTERY_SCORE = "@MasteryScore";
        public const string PARA_AV_PATH = "@AVPath";
        public const string PARA_COURSE_LAUNCH_SAME_WINDOW = "@CourseLaunchSameWindow";
        public const string PARA_COURSE_LAUNCH_NEW_WINDOW = "@CourseLaunchNewWindow";
        public const string PARA_ALLOW_SCROLL = "@AllowScroll";
        public const string PARA_ALLOW_RESIZE = "@AllowResize";
        public const string PARA_COURSE_WINDOW_WIDTH = "@CourseWindowWidth";
        public const string PARA_COURSE_WINDOW_HEIGHT = "@CourseWindowHeight";
        public const string PARA_CLIENT_ID = "@ClientId";
        //-aw 6/15/2011 Added course protocol
        public const string PARA_PROTOCOL = "@Protocol";

        //FIELDS
        public const string COL_COURSE_CONFIGURATION_ID = "CourseConfigurationId";
        public const string COL_IS_COURSE_SESSION_NO_EXPIRY = "IsCourseSessionNoExpiry";
        public const string COL_MAX_FILE_UPLOAD_SIZE_MB = "MaxFileUploadSizeMB";
        public const string COL_SCORE_TRACKING = "ScoreTracking";
        public const string COL_QUESTION_RESPONSE_TRACKING = "QuestionResponseTracking";
        public const string COL_MASTERY_SCORE = "MasteryScore";
        public const string COL_AV_PATH = "AVPath";
        public const string COL_COURSE_LAUNCH_SAME_WINDOW = "CourseLaunchSameWindow";
        public const string COL_COURSE_LAUNCH_NEW_WINDOW = "CourseLaunchNewWindow";
        public const string COL_ALLOW_SCROLL = "AllowScroll";
        public const string COL_ALLOW_RESIZE = "AllowResize";
        public const string COL_COURSE_WINDOW_WIDTH = "CourseWindowWidth";
        public const string COL_COURSE_WINDOW_HEIGHT = "CourseWindowHeight";
        public const string COL_CLIENT_ID = "ClientId";
        //-aw 6/15/2011 Added course protocol
        public const string COL_PROTOCOL = "Protocol";
    }
    #endregion

    #region RssFeedConfiguration
    public class RSSFeedConfiguration
    {
        //PROCEDURES        
        public const string PROC_GET_RSS_FEED_CONFIGURATION_BY_ID = "sproc_ClientRSSFeedConfiguration_sel";
        public const string PROC_UPDATE_RSS_FEED_CONFIGURATION = "sproc_ClientRSSFeedConfiguration_ups";
        public const string PROC_GET_ALL_RSS_FEED_CONFIGURATION = "sproc_ClientRSSFeedConfiguration_LstAll";
        public const string PROC_GET_CLIENT_RSS_URL = "sproc_GetClientRSS_URL";

        //PARAMETERS
        public const string PARA_RSS_FEED_ID = "@RSSFeedId";
        public const string PARA_RSS_FEED_URL = "@RSSFeedURL";
        public const string PARA_CLIENT_ID = "@ClientId";

        //FIELDS
        public const string COL_RSS_FEED_ID = "RSSFeedId";
        public const string COL_RSS_FEED_URL = "RSSFeedURL";
        public const string COL_CLIENT_ID = "ClientId";

    }
    #endregion

    #region LearnerProfileAccessConfiguration
    public class LearnerProfileAccessConfiguration
    {
        //PROCEDURES        
        public const string PROC_GET_ALL_LEARNER_PROFILE_CONFIG = "sproc_LearnerProfileAccessConfiguration_LstAll";
        public const string PROC_UPDATE_LEARNER_PROFILE_CONFIG = "sproc_LearnerProfileAccessConfiguration_ups";
        public const string PROC_DELETE_PROFILE_CONFIG = "sproc_LearnerProfileAccessConfiguration_del";

        //PARAMETERS
        public const string PARA_PROFILE_ACCESS_CONFIGURATION_ID = "@ProfileAccessConfigurationId";
        public const string PARA_PROFILE_FIELD_ID = "@ProfileFieldID";
        public const string PARA_FIELD_NAME = "@FieldName";
        public const string PARA_IS_READ_ONLY = "@IsReadOnly";
        public const string PARA_IS_MANDATORY = "@IsMandatory";
        public const string PARA_IS_VISIBLE_TO_USER = "@IsVisibletoUser";
        public const string PARA_FIELD_TYPE = "@FieldType";

        //FIELDS
        public const string COL_PROFILE_ACCESS_CONFIGURATION_ID = "ProfileAccessConfigurationId";
        public const string COL_PROFILE_FIELD_ID = "ProfileFieldID";
        public const string COL_FIELD_NAME = "FieldName";
        public const string COL_IS_READ_ONLY = "IsReadOnly";
        public const string COL_IS_MANDATORY = "IsMandatory";
        public const string COL_IS_MANDATORY_DISABLED = "IsMandatoryDisabled";
        public const string COL_IS_VISIBLE_TO_USER = "IsVisibletoUser";
        public const string COL_FIELD_TYPE = "FieldType";


    }
    #endregion

    #region UserPage
    public class UserPage
    {

        //PROCEDURES        
        public const string PROC_GET_ALL_USER_PAGES = "sproc_UserPageMaster_LstAll";
        public const string PROC_GET_USER_PAGE = "sproc_UserPageMaster_sel";
        public const string PROC_GET_ALL_PAGE_ELEMENTS = "sproc_UserPageElementLanguage_LstAll";
        public const string PROC_GET_ALL_ELEMENTS = "sproc_UserPageElementLanguage_LstDtls";
        public const string PROC_UPDATE_PAGE_ELEMENTS = "sproc_UserPageElementLanguage_ups";
        public const string PROC_UPDATE_ELEMENTS = "sproc_UserPageElementLanguage_ups_text";

        //PARAMETERS
        public const string PARA_PAGE_ID = "@PageId";
        public const string PARA_ELEMENT_TYPE = "@ElementType";
        public const string PARA_VALIDATION_ID = "@ValidationId";
        public const string PARA_ELEMENT_DISPLAY_NAME = "@ElementDisplayName";
        public const string PARA_IS_MANDATORY = "@IsMandatory";
        public const string PARA_IS_READ_ONLY = "@IsReadOnly";

        public const string PARA_PAGE_ELEMENT_ID = "@PageElementId";
        public const string PARA_ELEMENT_NAME = "@ElementName";
        public const string PARA_ELEMENT_TEXT = "@ElementText";
        public const string PARA_IS_IMAGE_AVAIL = "@IsImageAvailable";
        public const string PARA_ELEMENT_IMAGE_FILE_NAME = "@ElementImageFileName";
        public const string PARA_ELEMENT_IMAGE_WIDTH = "@ImageWidth";
        public const string PARA_ELEMENT_IMAGE_HEIGHT = "@ImageHeight";
        public const string PARA_ELEMENT_IMAGE_OVERRIDE = "@IsImageOverride";


        //FIELDS
        public const string COL_PAGE_ID = "PageId";
        public const string COL_PAGE_ENGLISH_NAME = "PageEnglishName";
        public const string COL_PAGE_FILE_URL = "PageFileURL";
        public const string COL_DISPLAY_ORDER = "DisplayOrder";

        public const string COL_CONFIG_TYPE = "ConfigType";
        public const string COL_ELEMENT_TYPE = "ElementType";
        public const string COL_VALIDATION_ID = "ValidationId";
        public const string COL_ELEMENT_DISPLAY_NAME = "ElementDisplayName";
        public const string COL_IS_MANDATORY = "IsMandatory";
        public const string COL_IS_READ_ONLY = "IsReadOnly";

        public const string COL_PAGE_ELEMENT_ID = "PageElementId";
        public const string COL_ELEMENT_NAME = "ElementName";
        public const string COL_ELEMENT_TEXT = "ElementText";
        public const string COL_IS_IMAGE_AVAIL = "IsImageAvailable";
        public const string COL_ELEMENT_IMAGE_FILE_NAME = "ElementImageFileName";
        public const string COL_ELEMENT_IMAGE_WIDTH = "ImageWidth";
        public const string COL_ELEMENT_IMAGE_HEIGHT = "ImageHeight";

    }
    #endregion

    #region UserPassCodeInstance
    public class UserPassCodeInstance
    {

        //PROCEDURES        
        public const string PROC_UPDATE_USER_PASSCODE_INSTANCE = "sproc_PasscodeInstanceMaster_ups";
        public const string PROC_GET_ALL_USER_PASSCODE_INSTANCE = "sproc_PasscodeInstanceMaster_LstAll";
        public const string PROC_GET_BY_ID_USER_PASSCODE_INSTANCE = "sproc_PasscodeInstanceMaster_sel";
        public const string PROC_UPDATE_STATUS_USER_PASSCODE_INSTANCE = "sproc_PasscodeInstanceMaster_ups_Status";
        public const string PROC_DELETE_USER_PASSCODE_INSTANCE = "sproc_PasscodeInstanceMaster_del";
        public const string PROC_GET_BY_NAME_USER_PASSCODE_INSTANCE = "sproc_PasscodeInstanceMaster_selByName";

        //PARAMETERS
        public const string PARA_PASS_CODE_INSTANCE_ID = "@PassCodeInstanceId";
        public const string PARA_INSTANCE_TITLE = "@InstanceTitle";
        public const string PARA_NO_OF_PASSCODES = "@NoOfPassCodes";
        public const string PARA_EMAIL_LIST = "@EmailList";
        public const string PARA_CREATED_BY_ID = "@CreatedByID";
        //FIELDS
        public const string COL_PASS_CODE_INSTANCE_ID = "PassCodeInstanceId";
        public const string COL_INSTANCE_TITLE = "InstanceTitle";
        public const string COL_NO_OF_PASSCODES = "NoOfPassCodes";
        public const string COL_EMAIL_LIST = "EmailList";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_TOTAL_CONSUMED = "TotalConsumed";
        public const string COL_CREATED_BY_ID = "CreatedByID";
    }
    #endregion

    #region EmailTemplate
    public class EmailTemplate
    {
        //PROCEDURES
        public const string PROC_GET_EMAIL_TEMPLATE_EMAIL_TYPE = "sproc_EmailTemplateMaster_sel_EmailType";
        public const string PROC_GET_EMAIL_TEMPLATE = "sproc_EmailTemplateMaster_sel";
        public const string PROC_GET_EMAIL_TEMPLATE_BY_NAME = "sproc_EmailTemplateMaster_selByName";
        public const string PROC_UPDATE_EMAIL_TEMPLATE_LANGUAGE = "sproc_EmailTemplateLanguage_ups";
        public const string PROC_UPDATE_EMAIL_TEMPLATE = "sproc_EmailTemplateMaster_ups";
        public const string PROC_DELETE_EMAIL_TEMPLATE = "sproc_EmailTemplateMaster_del";
        public const string PROC_DELETE_EMAIL_TEMPLATE_LANGUAGE = "sproc_EmailTemplateLanguage_del";
        public const string PROC_GET_ALL_EMAIL_TEMPLATE = "sproc_EmailTemplateMaster_LstAll";
        public const string PROC_GET_ALL_EMAIL_TEMPLATE_LANGUAGE = "sproc_EmailTemplateLanguage_LstAll";
        public const string PROC_FIND_EMAIL_TEMPLATE = "sproc_EmailTemplateMaster_LstAll_search";

        //PARAMETERS        
        public const string PARA_EMAIL_TEMPLATE_ID = "@EmailTemplateId";
        public const string PARA_EMAIL_TEMPLATE_DEFAULT_TITLE = "@EmailTemplateDefaultTitle";
        public const string PARA_LANGUAGE_ID = "@LanguageId";
        public const string PARA_DISPLAY_NAME = "@DisplayName";
        public const string PARA_EMAIL_SUBJECT_TEXT = "@EmailSubjectText";
        public const string PARA_EMAIL_BODY_TEXT = "@EmailBodyText";
        public const string PARA_RTL_TYPE = "@RTLType";
        public const string PARA_APPROVAL_STATUS = "@ApprovalStatus";
        public const string PARA_EMAIL_ADDRESS_STRING = "@EmailAddressString";
        public const string PARA_EMAIL_TYPE = "@EmailType";
        public const string PARA_IS_PRIVATE = "@IsPrivate";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_EMAIL_FROM_ID = "@EmailFromId";
        public const string PARA_EMAIL_REPLY_TO_ID = "@EmailReplyToId";
        public const string PARA_APPROVED_BY_ID = "@ApprovedById";
        public const string PARA_IS_DEFAULT = "@IsDefault";

        //FIELDS
        public const string COL_EMAIL_TEMPLATE_ID = "EmailTemplateId";
        public const string COL_EMAIL_TEMPLATE_DEFAULT_TITLE = "EmailTemplateDefaultTitle";
        public const string COL_LANGUAGE_ID = "LanguageId";
        public const string COL_DISPLAY_NAME = "DisplayName";
        public const string COL_EMAIL_SUBJECT_TEXT = "EmailSubjectText";
        public const string COL_EMAIL_BODY_TEXT = "EmailBodyText";
        public const string COL_RTL_TYPE = "RTLType";
        public const string COL_APPROVAL_STATUS = "ApprovalStatus";
        public const string COL_EMAIL_ADDRESS_STRING = "EmailAddressString";
        public const string COL_EMAIL_TYPE = "EmailType";
        public const string COL_IS_PRIVATE = "IsPrivate";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_EMAIL_FROM_ID = "EmailFromId";
        public const string COL_EMAIL_REPLY_TO_ID = "EmailReplyToId";
        public const string COL_APPROVED_BY_ID = "ApprovedById";
        public const string COL_USED_COUNT = "NoOfTimesUsed";
        public const string COL_IS_USED = "IsUsed";
        public const string COL_IS_DEFAULT = "IsDefault";
    }
    #endregion

    #region EmailSentLog
    public class EmailSentLog
    {
        //PROCEDURES
        public const string PROC_GET_EMAIL_SENT_LOG = "sproc_EmailSentLog_sel";
        public const string PROC_UPDATE_EMAIL_SENT_LOG = "sproc_EmailSentLog_ups";
        public const string PROC_FIND_EMAIL_SENT_LOG = "sproc_EmailSentLog_sel_search";

        //PARAMETERS
        public const string PARA_EMAIL_DISPATCH_ID = "@EmailDispatchId";
        public const string PARA_EMAIL_DELIVERY_INSTANCE_ID = "@EmailDeliveryInstanceId";
        public const string PARA_AUTO_EMAIL_EVENT_ID = "@AutoEmailEventId";
        public const string PARA_RECIPIANT_EMAIL_ADDRESS = "@RecipiantEmailAddress";
        public const string PARA_RECIPIANT_CC_EMAIL_ADDRESS = "@RecipiantCCEmailAddress";
        public const string PARA_RECIPIANT_BCC_EMAIL_ADDRESS = "@RecipiantBCCEmailAddress";
        public const string PARA_DATE_SENT = "@DateSent";
        public const string PARA_EMAIL_TEMPLATE_ID = "@EmailTemplateId";
        public const string PARA_EMAIL_MSG_FILE_NAME_PATH = "@EmailMsgFileNamePath";
        public const string PARA_LOG = "@EmailLog";
        public const string PARA_EMAIL_DELIVERY_TITLE = "@EmailDeliveryTitle";
        public const string PARA_EMAIL_TEMPLATE_DEFAULT_TITLE = "@EmailTemplateDefaultTitle";
        public const string PARA_EMAIL_ID = "@EmailID";

        //FIELDS
        public const string COL_EMAIL_DISPATCH_ID = "EmailDispatchId";
        public const string COL_EMAIL_DELIVERY_INSTANCE_ID = "EmailDeliveryInstanceId";
        public const string COL_AUTO_EMAIL_EVENT_ID = "AutoEmailEventId";
        public const string COL_RECIPIANT_EMAIL_ADDRESS = "RecipiantEmailAddress";
        public const string COL_RECIPIANT_CC_EMAIL_ADDRESS = "RecipiantCCEmailAddress";
        public const string COL_RECIPIANT_BCC_EMAIL_ADDRESS = "RecipiantBCCEmailAddress";
        public const string COL_DATE_SENT = "DateSent";
        public const string COL_EMAIL_TEMPLATE_ID = "EmailTemplateId";
        public const string COL_EMAIL_MSG_FILE_NAME_PATH = "EmailMsgFileNamePath";
        public const string COL_LOG = "EmailLog";
    }
    #endregion

    #region Assignment
    public class Assignment
    {
        //PROCEDURES
        public const string PROC_GET_ASSIGNMENT = "sproc_MasterActivityAssignment_sel";
        public const string PROC_UPDATE_ASSIGNMENT = "sproc_MasterActivityAssignment_ups";
        public const string PROC_GET_RULES = "sproc_RuleMaster_LstAll_NotInActivity";
        public const string PROC_GET_ROLE_USERS = "sproc_UserMaster_sel_RuleUsers";
        public const string PROC_DEACTIVATE_ASSIGMENT = "sproc_MasterActivityAssignment_deactivate";
        public const string PROC_DELETE_MULTIPLE_ASSIGMENTS = "sproc_MasterActivityAssignment_delMultiple";
        public const string PROC_GET_ALL_ASSIGNMENT = "sproc_MasterActivityAssignment_LstAll";
        public const string PROC_GET_ASSIGNMENT_BY_NAME = "sproc_MasterActivityAssignment_sel_ByActivityName";

        public const string PROC_DYNAMIC_USERLIST = "sproc_DynamicAssignment_UsersList";
        public const string PROC_ONETIME_USERLIST = "sproc_OneTimeAssignment_UsersList";
        public const string PROC_GET_ALL_ASSIGNMENT_FOREMAILTEMPLATE = "sproc_MasterActivityAssignment_LstAll_ForEmailTemplate";
        public const string PROC_GET_ALL_USER_ASSESSMENT_COURSE = "sproc_UserMaster_LstAllAssessmentQuestions";

        //PARAMETERS        
        public const string PARA_RULE_ID = "@RuleId";
        public const string PARA_ID = "@AssignmentId";
        public const string PARA_ASSIGNMENT_NAME = "@AssignmentName";
        public const string PARA_ASSIGNMENT_DESC = "@AssignmentDescription";
        public const string PARA_COMPLETION_CONDITION_ID = "@CompletionConditionId";
        public const string PARA_OVERRIDE_PREVIOUS_ASSIGNMENTS = "@OverridePreviousAssignments";
        public const string PARA_SEND_EMAIL = "@SendEmail";
        public const string PARA_SEND_EMAIL_TYPE = "@SendEmailType";
        public const string PARA_EMAIL_TEMPLATE_ID = "@EmailTemplateId";
        public const string PARA_PREVIOUS_RULE_ID = "@PreviousRuleId";

        public const string PARA_ACTIVITY_TYPE = "@ActivityType";

        public const string PARA_NEWHIRE_FROM_DATE = "@NewHireFromDate";
        public const string PARA_NEWHIRE_TO_DATE = "@NewHireToDate";

        public const string PARA_IS_NEWHIRE_ASSIGNMENT_BASED_ON_HIRE_DATE = "@IsNewHireAssignmentBasedOnHireDate";
        public const string PARA_IS_NEWHIRE_ASSIGNMENT_BASED_ON_CREATION_DATE = "@IsNewHireAssignmentBasedOnCreationDate";
        public const string PARA_NEWHIRE_ASSIGN_AFTER_DAYS_OF = "@NewHireAssignAfterDaysOf";
        public const string PARA_NEWHIRE_ASSIGNMENT_DATE_SET = "@NewHireAssignmentDateSet";

        public const string PARA_IS_NO_NEWHIRE_DUE_DATE = "@IsNewHireNoDueDate";
        public const string PARA_IS_NEWHIRE_DUE_BASED_ON_ASSIGN_DATE = "@IsNewHireDueBasedOnAssignDate";
        public const string PARA_IS_NEWHIRE_DUE_BASED_ON_HIRE_DATE = "@IsNewHireDueBasedOnHireDate";
        public const string PARA_IS_NEWHIRE_DUE_BASED_ON_CREATION_DATE = "@IsNewHireDueBasedOnCreationDate";
        public const string PARA_IS_NEWHIRE_DUE_BASED_ON_START_DATE = "@IsNewHireDueBasedOnStartDate";
        public const string PARA_NEWHIRE_DUE_AFTER_DAYS_OF = "@NewHireDueAfterDaysOf";
        public const string PARA_NEWHIRE_DUE_DATE = "@NewHireDueDateSet";

        public const string PARA_IS_NO_NEWHIRE_EXPIRY_DATE = "@IsNewHireNoExpiryDate";
        public const string PARA_IS_NEWHIRE_EXPIRY_BASED_ON_ASSIGN_DATE = "@IsNewHireExpiryBasedOnAssignDate";
        public const string PARA_IS_NEWHIRE_EXPIRY_BASED_ON_START_DATE = "@IsNewHireExpiryBasedOnStartDate";
        public const string PARA_IS_NEWHIRE_EXPIRY_BASED_ON_DUE_DATE = "@IsNewHireExpiryBasedOnDueDate";
        public const string PARA_NEWHIRE_EXPIRY_AFTER_DAYS_OF = "@NewHireExpireAfterDaysOf";
        public const string PARA_NEWHIRE_EXPIRY_DATE = "@NewHireExpiryDateSet";

        public const string PARA_ACTIVITYNRULEID = "@ActivityNRuleId";
        public const string PARA_IS_ACTIVE = "@IsActive";

        //FIELDS

        public const string COL_RULE_ID = "RuleId";
        public const string COL_ASSIGNMENT_NAME = "AssignmentName";
        public const string COL_ASSIGNMENT_DESC = "AssignmentDescription";
        public const string COL_COMPLETION_CONDITION_ID = "CompletionConditionId";
        public const string COL_OVERRIDE_PREVIOUS_ASSIGNMENTS = "OverridePreviousAssignments";
        public const string COL_SEND_EMAIL = "SendEmail";
        public const string COL_SEND_EMAIL_TYPE = "SendEmailType";
        public const string COL_EMAIL_TEMPLATE_ID = "EmailTemplateId";
        public const string COL_ASSIGNMENTMODE = "AssignmentMode";
        public const string COL_TOTAL_ASSIGNMENTS = "TotalAssignments";
        public const string COL_TOTAL_COMPLETIONS = "TotalCompletions";
        public const string COL_ACTIVITY_TYPE = "ActivityType";

        public const string COL_NEWHIRE_FROM_DATE = "NewHireFromDate";
        public const string COL_NEWHIRE_TO_DATE = "NewHireToDate";

        public const string COL_IS_NEWHIRE_ASSIGNMENT_BASED_ON_HIRE_DATE = "IsNewHireAssignmentBasedOnHireDate";
        public const string COL_IS_NEWHIRE_ASSIGNMENT_BASED_ON_CREATION_DATE = "IsNewHireAssignmentBasedOnCreationDate";
        public const string COL_NEWHIRE_ASSIGN_AFTER_DAYS_OF = "NewHireAssignAfterDaysOf";
        public const string COL_NEWHIRE_ASSIGNMENT_DATE_SET = "NewHireAssignmentDateSet";

        public const string COL_IS_NO_NEWHIRE_DUE_DATE = "IsNewHireNoDueDate";
        public const string COL_IS_NEWHIRE_DUE_BASED_ON_ASSIGN_DATE = "IsNewHireDueBasedOnAssignDate";
        public const string COL_IS_NEWHIRE_DUE_BASED_ON_HIRE_DATE = "IsNewHireDueBasedOnHireDate";
        public const string COL_IS_NEWHIRE_DUE_BASED_ON_CREATION_DATE = "IsNewHireDueBasedOnCreationDate";
        public const string COL_IS_NEWHIRE_DUE_BASED_ON_START_DATE = "IsNewHireDueBasedOnStartDate";
        public const string COL_NEWHIRE_DUE_AFTER_DAYS_OF = "NewHireDueAfterDaysOf";
        public const string COL_NEWHIRE_DUE_DATE = "NewHireDueDateSet";

        public const string COL_IS_NO_NEWHIRE_EXPIRY_DATE = "IsNewHireNoExpiryDate";
        public const string COL_IS_NEWHIRE_EXPIRY_BASED_ON_ASSIGN_DATE = "IsNewHireExpiryBasedOnAssignDate";
        public const string COL_IS_NEWHIRE_EXPIRY_BASED_ON_START_DATE = "IsNewHireExpiryBasedOnStartDate";
        public const string COL_IS_NEWHIRE_EXPIRY_BASED_ON_DUE_DATE = "IsNewHireExpiryBasedOnDueDate";
        public const string COL_NEWHIRE_EXPIRY_AFTER_DAYS_OF = "NewHireExpireAfterDaysOf";
        public const string COL_NEWHIRE_EXPIRY_DATE = "NewHireExpiryDateSet";

        public const string COL_IS_ACTIVE = "IsActive";

    }
    #endregion

    #region EmailDistributionList
    public class EmailDistributionList
    {
        //PROCEDURES
        public const string PROC_GET_EMAIL_DISTRIBUTION_LIST = "sproc_EmailDistributionListMaster_sel";
        public const string PROC_GET_EMAIL_DISTRIBUTION_BY_NAME = "sproc_EmailDistributionListMaster_selByName";
        public const string PROC_UPDATE_DISTRIBUTION_LIST = "sproc_EmailDistributionListMaster_ups";
        public const string PROC_DELETE_DISTRIBUTION_LIST = "sproc_EmailDistributionListMaster_del";
        public const string PROC_GET_ALL_DISTRIBUTION_LIST = "sproc_EmailDistributionListMaster_LstAll";
        public const string PROC_SEARCH_EMAIL_TEMPLATE = "sproc_EmailDistributionListMaster_sel_search";
        public const string PROC_GET_BUSINESS_RULE_USERS = "sproc_EmailDistributionListMaster_sel_RuleUsers";
        public const string PROC_GET_EMAIL_DISTRIBUTION_LIST_USERS = "sproc_EmailDistributionListMaster_sel_Users";

        //PARAMETERS        
        public const string PARA_DISTRIBUTION_LIST_ID = "@DistributionListId";
        public const string PARA_DISTRIBUTION_LIST_TITLE = "@DistributionListTitle";
        public const string PARA_RULE_ID = "@RuleId";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_KEYWORD = "@keyword";
        public const string PARA_IS_PRIVATE = "@IsPrivate";
        public const string PARA_LIST_COUNT = "@ListCount";
        public const string PARA_IS_USED = "@IsUsed";

        //FIELDS
        public const string COL_DISTRIBUTION_LIST_ID = "DistributionListId";
        public const string COL_DISTRIBUTION_LIST_TITLE = "DistributionListTitle";
        public const string COL_RULE_ID = "RuleId";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_IS_PRIVATE = "IsPrivate";
        public const string COL_IS_USED = "IsUsed";
    }
    #endregion

    #region UserAssetTracking
    public class UserAssetTracking
    {
        //PROCEDURES
        public const string PROC_GET_USER_ASSET_TRACKING = "sproc_UserAssetTracking_sel";
        public const string PROC_UPDATE_USER_ASSET_TRACKING = "sproc_UserAssetTracking_ups";
        public const string PROC_MARK_COMPLETED = "sproc_UserAssetTracking_ups";

        //PARAMETERS
        public const string PARA_ASSET_ID = "@AssetId";
        public const string PARA_SYSTEM_USER_GUID = "@SystemUserGUID";
        public const string PARA_COMPLETION_STATUS = "@CompletionStatus";
        public const string PARA_DATE_OF_COMPLETION = "@DateOfCompletion";
        public const string PARA_MARKED_COMPLETED_BY_ID = "@MarkedCompletedById";
        public const string PARA_SCANNED_CERTIFICATION_FILE_NAME = "@scannedcertificationFileName";
        public const string PARA_ACTIVITY_NAME = "@ActivityName";
        public const string PARA_USER_FIRST_LAST_NAME = "@UserFirstLastName";
        public const string PARA_REVIEWER_COMMENTS = "@ReviewerComments";
        public const string PARA_IS_FOR_ADMIN_PREVIEW = "@IsForAdminPreview";

        //FIELDS
        public const string COL_ASSET_ID = "AssetId";
        public const string COL_SYSTEM_USER_GUID = "SystemUserGUID";
        public const string COL_COMPLETION_STATUS = "CompletionStatus";
        public const string COL_DATE_OF_COMPLETION = "DateOfCompletion";
        public const string COL_MARKED_COMPLETED_BY_ID = "MarkedCompletedById";
        public const string COL_SCANNED_CERTIFICATION_FILE_NAME = "scannedcertificationFileName";
        public const string COL_ACTIVITY_NAME = "ActivityName";
        public const string COL_USER_FIRST_LAST_NAME = "UserFirstLastName";
        public const string COL_REVIEWER_COMMENTS = "ReviewerComments";
        public const string COL_IS_FOR_ADMIN_PREVIEW = "IsForAdminPreview";
    }
    #endregion

    #region Background BRule Assignment
    public class BackgroundBRuleAssignment
    {
        public const string PARA_ACTIVITY_ID = "@ActivityId";
        public const string PARA_SYSTEM_USER_GUID = "@SystemUserGUID";
        public const string PARA_ACTIVITYTYPE = "@ActivityType";

        public const string PROC_PERFORM_BGDYNAMICASSIGNMENT = "SPROC_DYNAMICASSIGNMENT_ONCOMPLETION_MAIN";

    }
    #endregion

    #region UserCertificationTracking
    public class UserCertificationTracking
    {
        //PROCEDURES
        public const string PROC_GET_USER_CERTIFICATION_TRACKING = "sproc_UserCertificationTracking_sel";
        public const string PROC_GET_USER_CERTIFICATION_TRACKING_STATUS = "sproc_UserCertificationTracking_selStatus";
        public const string PROC_UPDATE_USER_CERTIFICATION_TRACKING = "sproc_UserCertificationTracking_ups";
        public const string PROC_MARK_COMPLETED_INDIVIDUAL = "sproc_UserCertificationTracking_ups_MarkCompleted_Indivisual";


        //PARAMETERS
        public const string PARA_CERTIFICATION_ID = "@CertificationId";
        public const string PARA_SYSTEM_USER_GUID = "@SystemUserGUID";
        public const string PARA_COMPLETION_STATUS = "@CompletionStatus";
        public const string PARA_DATE_OF_COMPLETION = "@DateOfCompletion";
        public const string PARA_DATE_OF_START = "@DateOfStart";
        public const string PARA_MARKED_COMPLETED_BY_ID = "@MarkedCompletedById";
        public const string PARA_SCANNED_CERTIFICATION_FILE_NAME = "@scannedcertificationFileName";
        public const string PARA_REVIEWER_COMMENTS = "@ReviewerComments";
        public const string PARA_ACTIVITY_NAME = "@ActivityName";
        public const string PARA_USER_FIRST_LAST_NAME = "@UserFirstLastName";
        public const string PARA_IS_FOR_ADMIN_PREVIEW = "@IsForAdminPreview";

        //FIELDS
        public const string COL_CERTIFICATION_ID = "CertificationId";
        public const string COL_SYSTEM_USER_GUID = "SystemUserGUID";
        public const string COL_COMPLETION_STATUS = "CompletionStatus";
        public const string COL_DATE_OF_START = "DateOfStart";
        public const string COL_DATE_OF_COMPLETION = "DateOfCompletion";
        public const string COL_MARKED_COMPLETED_BY_ID = "MarkedCompletedById";
        public const string COL_SCANNED_CERTIFICATION_FILE_NAME = "scannedcertificationFileName";
        public const string COL_REVIEWER_COMMENTS = "ReviewerComments";
        public const string COL_ACTIVITY_NAME = "ActivityName";
        public const string COL_USER_FIRST_LAST_NAME = "UserFirstLastName";
        public const string COL_IS_FOR_ADMIN_PREVIEW = "IsForAdminPreview";
        public const string COL_PROGRESS = "Progress";
    }
    #endregion

    #region UserPolicyTracking
    public class UserPolicyTracking
    {
        //PROCEDURES
        public const string PROC_GET_USER_POLICY_TRACKING = "sproc_UserPolicyTracking_sel";
        public const string PROC_UPDATE_USER_POLICY_TRACKING = "sproc_UserPolicyTracking_ups";

        //PARAMETERS
        public const string PARA_POLICY_ID = "@PolicyId";
        public const string PARA_SYSTEM_USER_GUID = "@SystemUserGUID";
        public const string PARA_COMPLETION_STATUS = "@CompletionStatus";
        public const string PARA_DATE_OF_COMPLETION = "@DateOfCompletion";
        public const string PARA_MARKED_COMPLETED_BY_ID = "@MarkedCompletedById";
        public const string PARA_SCANNED_CERTIFICATION_FILE_NAME = "@scannedcertificationFileName";
        public const string PARA_ACTIVITY_NAME = "@ActivityName";
        public const string PARA_USER_FIRST_LAST_NAME = "@UserFirstLastName";
        public const string PARA_REVIEWER_COMMENTS = "@ReviewerComments";
        public const string PARA_IS_FOR_ADMIN_PREVIEW = "@IsForAdminPreview";

        //FIELDS
        public const string COL_POLICY_ID = "PolicyId";
        public const string COL_SYSTEM_USER_GUID = "SystemUserGUID";
        public const string COL_COMPLETION_STATUS = "CompletionStatus";
        public const string COL_DATE_OF_COMPLETION = "DateOfCompletion";
        public const string COL_MARKED_COMPLETED_BY_ID = "MarkedCompletedById";
        public const string COL_SCANNED_CERTIFICATION_FILE_NAME = "scannedcertificationFileName";
        public const string COL_REVIEWER_COMMENTS = "ReviewerComments";
        public const string COL_IS_FOR_ADMIN_PREVIEW = "IsForAdminPreview";
    }
    #endregion

    #region AutoEmailTemplateSetting
    public class AutoEmailTemplateSetting
    {
        //PROCEDURES
        public const string PROC_GET_EMAIL_TEMP_ID_AUTO_EMAIL_EVENT = "sproc_AutoEmailTemplateSetting_sel_EmailTempId";
        public const string PROC_GET_AUTO_EMAIL_EVENT = "sproc_AutoEmailTemplateSetting_sel";
        public const string PROC_UPDATE_AUTO_EMAIL_EVENT = "sproc_AutoEmailTemplateSetting_ups";
        public const string PROC_GET_ALL_AUTO_EMAIL_EVENTS = "sproc_AutoEmailTemplateSetting_LstAll";

        //PARAMETERS
        public const string PARA_AUTO_EMAIL_EVENT_ID = "@AutoEmailEventId";
        public const string PARA_EVENT_NAME = "@EventName";
        public const string PARA_EMAIL_TEMPLATE_ID = "@EmailTemplateID";
        public const string PARA_FEATURE_ID = "@FeatureId";
        public const string PARA_IS_RECURRENCE_APPROVAL_REQUIRED = "@IsRecurrenceApprovalRequired";

        //FIELDS
        public const string COL_AUTO_EMAIL_EVENT_ID = "AutoEmailEventId";
        public const string COL_EVENT_NAME = "EventName";
        public const string COL_EMAIL_TEMPLATE_ID = "EmailTemplateID";
        public const string COL_FEATURE_ID = "FeatureId";
        public const string COL_IS_RECURRENCE_APPROVAL_REQUIRED = "IsRecurrenceApprovalRequired";
    }
    #endregion

    #region LiveSession
    public class LiveSession
    {
        //PROCEDURES
        public const string PROC_GET_COUNT = "sproc_LiveSession_LstCount";
        public const string PROC_UPDATE = "sproc_LiveSession_ups";
        public const string PROC_UPDATE_TIMESTAMP = "sproc_SetSessionTimeStamp";
        public const string PROC_GET = "sproc_LiveSession_sel";
        public const string PROC_DELETE = "sproc_LiveSession_del";

        //PARAMETERS
        public const string PARA_IIS_SESSIONID = "@IISSessionId";
        public const string PARA_SESSION_SERVERIP = "@SessionServerIP";
        public const string PARA_SESSION_STATUS = "@SessionStatus";
        public const string PARA_SESSION_STARTDATE = "@SessionStartDate";
        public const string PARA_SESSION_ENDTDATE = "@SessionEndDate";
        public const string PARA_USERTYPE = "@UserType";
        public const string PARA_IS_SSO_LOGIN = "@IsSSOLogin";

        public const string PARA_SESSION_TIMEOUT_SET = "@SessionTimeOutSet";
        public const string PARA_SESSION_OPERATING_SYSTEM = "@OperatingSystem";
        public const string PARA_BROWSER = "@Browser";
        public const string PARA_JAVASCRIPT_VERSION = "@JavascriptVersion";
        public const string PARA_FLASH_VERSION = "@FlashVersion";
        public const string PARA_SUPPORT_COOKIES = "@SupportCookies";
        public const string PARA_SUPPORT_ACTIVEX_CONTROLS = "@SupportActivexControls";

        //FIELDS
        public const string COL_IIS_SESSIONID = "IISSessionId";
        public const string COL_SESSION_SERVERIP = "SessionServerIP";
        public const string COL_SESSION_STATUS = "SessionStatus";
        public const string COL_SESSION_STARTDATE = "SessionStartDate";
        public const string COL_SESSION_ENDTDATE = "SessionEndDate";
        public const string COL_USERTYPE = "UserType";
        public const string COL_SESSION_TIME_STAMP = "SessionTimeStamp";
        public const string COL_IS_SSO_LOGIN = "IsSSOLogin";

        public const string COL_SESSION_OPERATING_SYSTEM = "OperatingSystem";
        public const string COL_BROWSER = "Browser";
        public const string COL_JAVASCRIPT_VERSION = "JavascriptVersion";
        public const string COL_FLASH_VERSION = "FlashVersion";
        public const string COL_SUPPORT_COOKIES = "SupportCookies";
        public const string COL_SUPPORT_ACTIVEX_CONTROLS = "SupportActivexControls";
    }
    #endregion


    #region SocialIntegration
    public class SocialIntegration
    {
        //PROCEDURES
        public const string PROC_GETMESSAGETEMPLATE_BY_ACTIVITY_TYPE = "sproc_GET_SocialIntegration_MesgTemp_By_ActivityType_ID";
        public const string PROC_GETFBApp_ID = "sproc_GetFBAppId";

        //PARAMETERS
        public const string PARA_Activity_Type = "@ActivityType";
        public const string PARA_ActivityID = "@ActivityID";
        public const string PARA_SYSTEM_USERGUID = "@SystemUserGUID";
        public const string PARA_LANG_ID = "@LanguageId";
        public const string PARA_CLIENT_ID = "@ClientId";

        //FIELDS
        public const string COL_TemplateId = "TemplateId";
        public const string COL_TemplateName = "TemplateName";
        public const string COL_ActivityType = "ActivityType";
        public const string COL_TemplateString = "TemplateString";
        public const string COL_FBAppId = "FBAppId";
    }
    #endregion

    #region EmailDeliveryDashboard
    public class EmailDeliveryDashboard
    {
        //PROCEDURES
        public const string PROC_DYNAMICASSIGNMENTUSER_EMAIL = "sproc_GetDynamicAssignmentUsers_ForEmail";

        public const string PROC_GET_EMAIL_DELIVERY_DASHBOARD = "sproc_EmailDeliveryDashboard_sel";
        public const string PROC_UPDATE_EMAIL_DELIVERY_DASHBOARD = "sproc_EmailDeliveryDashboard_ups";
        public const string PROC_FIND_EMAIL_DELIVERY_DASHBOARD = "sproc_EmailDeliveryDashboard_sel_search";
        public const string PROC_DELETE_EMAIL_DELIVERY_DASHBOARD = "sproc_EmailDeliveryDashboard_del";
        public const string PROC_EMAIL_DELIVERY_DASHBOARD_CHECK_BY_NAME = "sproc_EmailDeliveryDashboard_selByName";
        public const string PROC_FIND_EMAIL_DELIVERY_DASHBOARD_SCHEDULAR = "sproc_EmailDeliveryDashboard_search_schedular";


        //PARAMETERS
        public const string PARA_EMAIL_DELIVERY_INSTANCE_ID = "@EmailDeliveryInstanceId";
        public const string PARA_EMAIL_DELIVERY_TITLE = "@EmailDeliveryTitle";
        public const string PARA_Email_Template_ID = "@EmailTemplateID";
        public const string PARA_DISTRIBUTION_LIST_ID = "@DistributionListId";
        public const string PARA_IS_CCMANAGER = "@IsCCManager";
        public const string PARA_TO_LIST = "@ToList";
        public const string PARA_CC_LIST = "@CCList";
        public const string PARA_IS_BCC_MANAGER = "@IsBCCManager";
        public const string PARA_BCC_LIST = "@BCCList";
        public const string PARA_IS_SITE_DEFAULT_LANGUAGE = "@IsSiteDefaultLanguage";
        public const string PARA_IS_USER_PREFERRED_LANGUAGE = "@IsUserPreferredLanguage";
        public const string PARA_IS_ALL_LANGUAGES = "@IsAllLanguages";
        public const string PARA_IS_PERSONALIZED = "@IsPersonalized";
        public const string PARA_IS_IMMEDIATE = "@IsImmediate";
        public const string PARA_IS_ONETIME = "@IsOneTime";
        public const string PARA_ONETIME_DATESET = "@OneTimeDateSet";
        public const string PARA_IS_DAILY = "@IsDaily";
        public const string PARA_IS_WEEKLY = "@IsWeekly";
        public const string PARA_IS_MONTHLY = "@IsMonthly";
        public const string PARA_DATETIME_SET = "@DateTimeSet";
        public const string PARA_END_DATE = "@EndDate";
        public const string PARA_RECURRENCE = "@Recurrence";
        public const string PARA_IS_RECURRENCE_APPROVAL_REQUIRED = "@IsRecurrenceApprovalRequired";
        public const string PARA_DELIVERY_APPROVAL_STATUS = "@DeliveryApprovalStatus";
        public const string PARA_IS_IMMEDIATE_FOR_SCHEDULAR = "@IsImmediateForSchedular";
        public const string PARA_APPROVED_BY_ID = "@ApprovedById";
        public const string PARA_APPROVALDATE = "@ApprovalDate";

        public const string PARA_ACTIVITY_ID = "@ActivityId";
        public const string PARA_ASSIGNMENT_ID = "@AssignmentId";
        public const string PARA_ATTACHMENTPATHLIST = "@AttachmentPathList";
        public const string PARA_TASK_ID = "@TaskId";
        public const string PARA_LEARNER_ID = "@LearnerId";
        public const string PARA_ASSIGNMENTMODE = "@AssignmentMode";
        public const string PARA_IsDistributionToManager = "@IsDistributionToManager";
        public const string PARA_ManagerEmailId = "@ManagerEmailId";
        public const string PARA_ManagerName = "@ManagerName";
        public const string PARA_IS_WEEKDAYS_ONLY = "@IsWeekdaysOnly";
        public const string PARA_RULEID = "@RULEID";
        public const string PARA_ASSIGNMENTTYPEID = "@AssignmentTypeId";
        public const string PARA_ISFROM_VIEWRECEIPANTS = "@IsFromViewReceipants";
        public const string PARA_DYNAMICASSIGNMENT = "@IsDynamicAssignment";





        //FIELDS
        public const string COL_RULE_ID = "RuleID";
        public const string COL_ASSIGNMENTTYPEID = "ASSIGNMENTTYPEID";
        public const string COL_EMAIL_DELIVERY_INSTANCE_ID = "EmailDeliveryInstanceId";
        public const string COL_EMAIL_DELIVERY_TITLE = "EmailDeliveryTitle";
        public const string COL_Email_Template_ID = "EmailTemplateID";
        public const string COL_DISTRIBUTION_LIST_ID = "DistributionListId";
        public const string COL_IS_CCMANAGER = "IsCCManager";
        public const string COL_CC_LIST = "CCList";
        public const string COL_TO_LIST = "ToList";
        public const string COL_IS_BCC_MANAGER = "IsBCCManager";
        public const string COL_BCC_LIST = "BCCList";
        public const string COL_IS_SITE_DEFAULT_LANGUAGE = "IsSiteDefaultLanguage";
        public const string COL_IS_USER_PREFERRED_LANGUAGE = "IsUserPreferredLanguage";
        public const string COL_IS_ALL_LANGUAGES = "IsAllLanguages";
        public const string COL_IS_PERSONALIZED = "IsPersonalized";
        public const string COL_IS_IMMEDIATE = "IsImmediate";
        public const string COL_IS_ONETIME = "IsOneTime";
        public const string COL_ONETIME_DATESET = "OneTimeDateSet";
        public const string COL_IS_DAILY = "IsDaily";
        public const string COL_IS_WEEKLY = "IsWeekly";
        public const string COL_IS_MONTHLY = "IsMonthly";
        public const string COL_DATETIME_SET = "DateTimeSet";
        public const string COL_END_DATE = "EndDate";
        public const string COL_RECURRENCE = "Recurrence";
        public const string COL_IS_RECURRENCE_APPROVAL_REQUIRED = "IsRecurrenceApprovalRequired";
        public const string COL_DELIVERY_APPROVAL_STATUS = "DeliveryApprovalStatus";
        public const string COL_APPROVED_BY_ID = "ApprovedById";
        public const string COL_APPROVALDATE = "ApprovalDate";

        public const string COL_ACTIVITY_ID = "ActivityId";
        public const string COL_ASSIGNMENT_ID = "AssignmentId";
        public const string COL_ATTACHMENTPATHLIST = "AttachmentPathList";
        public const string COL_TASK_ID = "TaskId";
        public const string COL_LEARNER_ID = "LearnerId";
        public const string COL_ASSIGNMENTMODE = "AssignmentMode";
        public const string COL_IsDistributionToManager = "IsDistributionToManager";
        public const string COL_ManagerEmailId = "ManagerEmailId";
        public const string COL_ManagerName = "ManagerName";
        public const string COL_IS_WEEKDAYS_ONLY = "IsWeekdaysOnly";


    }
    #endregion

    #region CurriculumTracking
    public class CurriculumTracking
    {
        //PROCEDURES
        public const string PROC_GET_USER_CURRICULUM_TRACKING = "sproc_UserCurriculumTracking_sel";
        public const string PROC_GET_USER_CURRICULUM_TRACKING_STATUS = "sproc_UserCurriculumTracking_selStatus";
        public const string PROC_UPDATE_USER_CURRICULUM_TRACKING = "sproc_UserCurriculumTracking_ups";
        public const string PROC_UPDATE_MARK_COMPLTED = "sproc_UserCurriculumTracking_ups_MarkCompleted_Individual";

        //PROCEDURES
        public const string PROC_DELETE_ADMIN_CUURICULUM_TRACKING = "sproc_DeleteAdminCuuriculum_Tracking";
        public const string PROC_DELETE_ADMIN_PREVIEW_TRACKING = "sproc_DeleteAdminPreview_Tracking";

        //PARAMETERS
        public const string PARA_ATTEMPT_ID = "@AttemptId";
        public const string PARA_CURRICULUM_ID = "@CurriculumId";
        public const string PARA_SYSTEM_USER_ID = "@SystemUserGUID";
        public const string PARA_COMPLETION_STATUS = "@CompletionStatus";
        public const string PARA_DATE_OF_COMPLETION = "@DateOfCompletion";
        public const string PARA_COMPLETED_DATE = "@CompletedDate";
        public const string PARA_DATE_OF_START = "@DateOfStart";
        public const string PARA_MARKED_COMPLETED_BY_ID = "@MarkedCompletedById";
        public const string PARA_SCANNED_CERTIFICATION_FILE_NAME = "@scannedcertificationFileName";
        public const string PARA_REVIEWER_COMMENTS = "@ReviewerComments";
        public const string PARA_IS_FOR_ADMIN_PREVIEW = "@IsForAdminPreview";
        public const string PARA_ACTIVITY_ID = "@ACTIVITYID ";
        public const string PARA_ACTIVITY_TYPE = "@ACTIVITYTYPE";

        //FIELDS
        public const string COL_ATTEMPT_ID = "AttemptId";
        public const string COL_CURRICULUM_ID = "CurriculumId";
        public const string COL_COMPLETION_STATUS = "CompletionStatus";
        public const string COL_DATE_OF_COMPLETION = "DateOfCompletion";
        public const string COL_DATE_OF_START = "DateOfStart";
        public const string COL_MARKED_COMPLETED_BY_ID = "MarkedCompletedById";
        public const string COL_SCANNED_CERTIFICATION_FILE_NAME = "scannedcertificationFileName";
        public const string COL_ACTIVITY_NAME = "ActivityName";
        public const string COL_USER_FIRST_LAST_NAME = "UserFirstLastName";
        public const string COL_REVIEWER_COMMENTS = "ReviewerComments";
        public const string COL_IS_FOR_ADMIN_PREVIEW = "IsForAdminPreview";
    }
    #endregion

    #region RuleRoleScope
    public class RuleRoleScope
    {
        //PROCEDURES
        public const string PROC_GET_RULE_ROLE_SCOPE = "sproc_RuleRoleScope_sel";
        public const string PROC_UPDATE_RULE_ROLE_SCOPE = "sproc_RuleRoleScope_ups";
        public const string PROC_GET_ALL_RULE_ROLE_SCOPE = "sproc_RuleRoleScope_LstAll";
        public const string PROC_BY_ROLE_RULE_ROLE_SCOPE = "sproc_RuleRoleScope_LstAll_ByRole";

        public const string PROC_BY_ROLE_RULE_ROLE_SCOPE_ALL = "sproc_RuleRoleScope_LstAll_ByAllRole";

        //PARAMETERS
        public const string PARA_RULE_ID = "@RuleId";
        public const string PARA_ROLE_ID = "@RoleId";
        public const string PARA_SCOPEUNIT_ID = "@ScopeUnitId";
        public const string PARA_SCOPELEVEL_ID = "@ScopeLevelId";
        public const string PARA_SCOPE_RULE_ID = "@ScopeRuleId";
        public const string PARA_IS_DEFAULT_SCOPE = "@IsDefaultScope";
        public const string PARA_IS_DEFAULT = "@IsDefault";

        //FIELDS
        public const string COL_RULE_ID = "RuleId";
        public const string COL_ROLE_ID = "RoleId";
        public const string COL_SCOPEUNIT_ID = "ScopeUnitId";
        public const string COL_SCOPELEVEL_ID = "ScopeLevelId";
        public const string COL_SCOPE_RULE_ID = "ScopeRuleId";
        public const string COL_IS_DEFAULT_SCOPE = "IsDefaultScope";
        public const string COL_IS_DEFAULT = "IsDefault";
    }
    #endregion

    #region StandardReportColumns
    public class StandardReportColumns
    {
        //PARAMETERS
        public const string PARA_COLUMN_ID = "@ColumnId";

        //FIELDS
        public const string COL_COLUMN_ID = "ColumnId";
        public const string COL_COLUMN_HEADER_TEXT = "ColumnHeaderText";
        public const string COL_COLUMN_DB_FIELD_NAME = "ColumnDBFieldName";
        public const string COL_DATA_TYPE = "FieldType";

        public const string COL_DISP_ORDR = "ColumnDisplayOrder";
        public const string COL_TYPE = "ColumnType";

    }
    #endregion

    #region StandardReport
    public class StandardReport
    {
        //PROCEDURES
        public const string PROC_LSTALL_STANDARD_RPT = "sproc_StandardReportMaster_LstAll";
        public const string PROC_SEL_STANDARD_RPT = "sproc_StandardReportMaster_sel";

        //PARAMETERS
        public const string PARA_REPORT_ID = "@ReportId";
        public const string PARA_IS_SUPERADMIN = "@IsSuperAdmin";

        //FIELDS
        public const string COL_REPORT_NAME = "ReportName";
        public const string COL_REPORT_ID = "ReportId";
        public const string COL_FEATURE_ID = "FeatureId";
        public const string COL_PAGE_NAME = "PageName";
    }
    #endregion

    #region StandardCustomReport
    public class StandardCustomReport
    {
        //PROCEDURES
        public const string PROC_DEL_STANDARD_CUST_RPT = "sproc_StandardCustomReportMaster_del";
        public const string PROC_SEL_STANDARD_CUST_RPT = "sproc_StandardCustomReportMaster_sel";
        public const string PROC_UPS_STANDARD_CUST_RPT = "sproc_StandardCustomReportMaster_ups";
        public const string PROC_GET_All_CUSTOM_REPORTS = "sproc_AllCustomReports_LstAll";
        public const string PROC_GET_All_CUSTOM_REPORTS_ADMIN_HOME = "sproc_AllCustomReports_LstAll_AdminHome";
        public const string PROC_SEL_BY_NAME_STANDARD_CUST_RPT = "sproc_StandardCustomReportMaster_selByName";
        public const string PROC_GET_SHARED_CUSTOM_REPORTS_SEL_SEARCH = "sproc_AllSharedCustomReports_SelSearch";


        //PARAMETERS
        public const string PARA_CUS_RPT_ID = "@CustomReportId";
        public const string PARA_CUST_RPT_NAME = "@CustomReportName";
        public const string PARA_CUS_RPT_DESC = "@CustomReportDescription";
        public const string PARA_SORT_1_COL_ID = "@SortOn1ColumnId";
        public const string PARA_SORT_2_COL_ID = "@SortOn2ColumnId";
        public const string PARA_SORT_1_DIR = "@Sort1Direction";
        public const string PARA_SORT_2_DIR = "@Sort2Direction";
        public const string PARA_IS_PRIVATE = "@IsPrivate";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_PAGE_SIZE = "@PageSize";
        public const string PARA_DATE_CREATED_TO = "@DateCreatedTo";
        public const string PARA_DATE_MODIFIED_TO = "@LastModifiedDateTo";
        public const string PARA_IS_ALL_REPORT_VISIBLE = "@IsAllReportVisible";

        //FIELDS
        public const string COL_REPORT_ID = "ReportId";
        //public const string COL_REPORT_NAME = "ReportName";
        public const string COL_CUS_RPT_ID = "CustomReportId";
        public const string COL_CUST_RPT_NAME = "CustomReportName";
        public const string COL_CUS_RPT_DESC = "CustomReportDescription";
        public const string COL_SORT_1_COL_ID = "SortOn1ColumnId";
        public const string COL_SORT_2_COL_ID = "SortOn2ColumnId";
        public const string COL_SORT_1_DIR = "Sort1Direction";
        public const string COL_SORT_2_DIR = "Sort2Direction";
        public const string COL_REPORT_TYPE = "ReportType";
        public const string COL_IS_PRIVATE = "IsPrivate";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_PAGE_SIZE = "PageSize";
        public const string COL_PAGE_NAME = "PageName";
        public const string COL_CREATED_BY = "CreatedByName";
        public const string COL_BASE_REPORT = "BaseReport";
    }
    #endregion

    #region StandardCustomReportColumn
    public class StandardCustomReportColumn
    {
        //PROCEDURES
        public const string PROC_DEL_STANDARD_CUST_COL_RPT = "sproc_StandardCustomReportColumns_delMultiple";
        public const string PROC_UPS_STANDARD_CUST_COL_RPT = "sproc_StandardCustomReportColumns_ups";

        //PARAMETERS
        public const string PARA_CUST_COL_ID = "@CustomColumnId";
        public const string PARA_CUST_HDR_TXT = "@CustomColumnHeaderText";
        public const string PARA_CUS_SRT_ORDR = "@ColumnSortOrder";
        public const string PARA_CUS_DISP_ORDR = "@ColumnDisplayOrder";

        //FIELDS
        public const string COL_CUST_COL_ID = "CustomColumnId";
        public const string COL_CUST_HDR_TXT = "CustomColumnHeaderText";
        public const string COL_CUS_SRT_ORDR = "ColumnSortOrder";

    }
    #endregion

    #region BulkImport
    public class BulkImport
    {
        //PROCEDURES
        public const string PROC_DEL_BULK_IMP_MSTR = "sproc_BulkImportMaster_del";
        public const string PROC_LSTALL_BULK_IMP_MSTR = "sproc_BulkImportMaster_sel";
        public const string PROC_SEL_BULK_IMP_MSTR = "sproc_BulkImportMaster_sel";
        public const string PROC_UPS_BULK_IMP_MSTR = "sproc_BulkImportMaster_ups";
        public const string PROC_FIND_BULK_IMPORT_TASKS_SCHEDULAR = "sproc_BulkImportTasks_search_schedular";

        //PARAMETERS
        public const string PARA_IMPORT_ID = "@ImportId";
        public const string PARA_TITLE = "@Title";
        public const string PARA_IMPORT_FILE_PATH = "@ImportFilePath";
        public const string PARA_SCH_DATE_AND_TIME = "@ScheduledDateAndTime";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_CREATE_PWD = "@CreatePassword";
        public const string PARA_PWD = "@Password";
        public const string PARA_SEND_EMAIL = "@SendEmail";
        public const string PARA_DIRECT_SEND_EMAIL = "@DirectSendEmail";

        public const string PARA_SCHEDULED_EMAIL_TASK_ID = "@ScheduledEmailTaskId";
        public const string PARA_FIELD_MAPPING = "@FieldMapping";
        public const string PARA_IMPORT_ACTION = "@ImportAction";

        public const string PARA_KEEP_EXISTING_PWD = "@KeepExistingPassword";
        public const string PARA_ADD_NEW_CUSTOM_FIELDS = "@AddNewCustomFields";
        public const string PARA_ADD_NEW_ORG_LEVEL = "@AddNewOrganizationLevels";
        public const string PARA_UPLOAD_FILE_NAME = "@UploadedFileName";

        public const string PARA_EMAIL_TYPE = "@EmailType";
        public const string PARA_EMAIL_TEMPLATE_ID = "@EmailTemplateID";
        public const string PARA_IS_OVERRIDE_PREVIOUS_ASSGNMT = "@IsOverridePreviousAssignment";
        public const string PARA_IS_ASSIGNED = "@IsAssigned";
        public const string PARA_IMPORT_STATUS = "@ImportStatus";
        public const string PARA_IMPORT_TYPE = "@ImportType";
        public const string PARA_COMMENT = "@Comment";
        public const string PARA_COMPLETION_DATE = "@CompletionDate";
        public const string PARA_IS_IMMEDIATE_FOR_SCHEDULAR = "@IsImmediateForSchedular";
        //FIELDS
        public const string COL_IMPORT_ID = "ImportId";
        public const string COL_TITLE = "Title";
        public const string COL_IMPORT_FILE_PATH = "ImportFilePath";
        public const string COL_SCH_DATE_AND_TIME = "ScheduledDateAndTime";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_CREATE_PWD = "CreatePassword";
        public const string COL_PWD = "Password";
        public const string COL_SEND_EMAIL = "SendEmail";
        public const string COL_DIRECT_SEND_EMAIL = "DirectSendEmail";
        public const string COL_SCHEDULED_EMAIL_TASK_ID = "ScheduledEmailTaskId";
        public const string COL_FIELD_MAPPING = "FieldMapping";
        public const string COL_IMPORT_ACTION = "ImportAction";
        public const string COL_IMPORT_TYPE = "ImportType";
        public const string COL_COMMENT = "Comment";
        public const string COL_COMPLETION_DATE = "CompletionDate";

        public const string COL_KEEP_EXISTING_PWD = "KeepExistingPassword";
        public const string COL_ADD_NEW_CUSTOM_FIELDS = "AddNewCustomFields";
        public const string COL_ADD_NEW_ORG_LEVEL = "AddNewOrganizationLevels";
        public const string COL_UPLOAD_FILE_NAME = "UploadedFileName";


        public const string COL_EMAIL_TYPE = "EmailType";
        public const string COL_EMAIL_TEMPLATE_ID = "EmailTemplateID";
        public const string COL_IS_OVERRIDE_PREVIOUS_ASSGNMT = "IsOverridePreviousAssignment";
        public const string COL_IS_ASSIGNED = "IsAssigned";
        public const string COL_IMPORT_STATUS = "ImportStatus";
    }
    #endregion

    #region AVPathSetting
    public class AVPathSetting
    {
        //PROCEDURES
        public const string PROC_GET_ALL_AVPATH_SETTINGS = "sproc_AVPathSetting_LstAll";
        public const string PROC_UPDATE_AVPATH_SETTINGS = "sproc_AVPathSetting_ups";
        public const string PROC_DELETE_AVPATH_SETTINGS = "sproc_AVPathSetting_del";

        //PARAMETERS
        public const string PARA_AVPATHSETTING_ID = "@AVSettingId";
        public const string PARA_CUSTOM_FIELD_ID = "@CustomFieldId";
        public const string PARA_CF_ITEM_ID = "@CustomFieldItemId";
        public const string PARA_ITEM_PATH = "@ItemPath";
        public const string PARA_IS_SUB_FOLDER = "@IsSubFolder";
        public const string PARA_IS_SAME_FOR_ALL = "@IsSameAVPathForAll";

        //FIELDS
        public const string COL_AVPATHSETTING_ID = "AVSettingId";
        public const string COL_CUSTOM_FIELD_ID = "CustomFieldId";
        public const string COL_CF_ITEM_ID = "CustomFieldItemId";
        public const string COL_ITEM_PATH = "ItemPath";
        public const string COL_IS_SUB_FOLDER = "IsSubFolder";
        public const string COL_IS_SAME_FOR_ALL = "IsSameAVPathForAll";

    }
    #endregion

    #region LoginKey
    public class LoginKey
    {
        public const string PROC_UPDATE = "sproc_LoginKeyMaster_ups";
        public const string PROC_GET = "sproc_LoginKeyMaster_sel";

        public const string COL_LOGINKEY = "LoginKey";
        public const string COL_STARTURL = "StartURL";
        public const string PARA_LOGINKEY = "@LoginKey";

    }
    #endregion

    #region ReportDeliveryDashboard
    public class ReportDeliveryDashboard
    {
        //Procedure 
        public const string PROC_GET_ALL_RPT_DEL_DSHBRD = "sproc_ReportDeliveryDashboard_LstAll";
        public const string PROC_SEL_RPT_DEL_DSHBRD = "sproc_ReportDeliveryDashboard_sel";
        public const string PROC_UPS_RPT_DEL_DSHBRD = "sproc_ReportDeliveryDashboard_ups";
        public const string PROC_DEL_RPT_DEL_DSHBRD = "sproc_ReportDeliveryDashboard_del";
        public const string PROC_FIND_RPT_DEL_DASHBOARD_SCHEDULAR = "sproc_ReportDeliveryDashboard_schedular";


        //PARAMETERS
        public const string PARA_REPORT_INSTANCE_ID = "@ReportInstanceId";
        public const string PARA_REPORT_ID = "@ReportId";
        public const string PARA_REPORT_TYPE = "@ReportType";
        public const string PARA_FILE_EXP_FORMAT = "@FileExportFormat";
        public const string PARA_GEN_RPT_FILE_NAME = "@GeneratedReportFileName";
        public const string PARA_DIST_LIST_ID = "@DistributionListId";
        public const string PARA_EMAIL_TEMP_ID = "@EmailTemplateID";
        public const string PARA_PARAMETER_MAPPING = "@ParametersMapping";

        public const string PARA_TASK_START_FROM = "@TaskStartFromDate";
        public const string PARA_TASK_START_TO = "@TaskStartToDate";
        public const string PARA_TASK_END_FROM = "@TaskEndFromDate";
        public const string PARA_TASK_END_TO = "@TaskEndToDate";
        public const string PARA_IS_IMMEDIATE_FOR_SCHEDULAR = "@IsImmediateForSchedular";
        public const string PARA_IS_DISTRIBUTION_TO_MANAGER = "@IsDistributionToManager";
        public const string PARA_IS_EMAIL_DELIVERY_APPROVED = "@IsEmailDeliveryApproved";


        //FIELDS
        public const string COL_REPORT_INSTANCE_ID = "ReportInstanceId";
        public const string COL_REPORT_ID = "ReportId";
        public const string COL_REPORT_TYPE = "ReportType";
        public const string COL_FILE_EXP_FORMAT = "FileExportFormat";
        public const string COL_GEN_RPT_FILE_NAME = "GeneratedReportFileName";
        public const string COL_DIST_LIST_ID = "DistributionListId";
        public const string COL_EMAIL_TEMP_ID = "EmailTemplateID";
        public const string COL_REPORT_NAME = "ReportName";
        public const string COL_PARAMETER_MAPPING = "ParametersMapping";

        public const string COL_LAST_RUN_STATUS = "LastRunStatus";
        public const string COL_RUN_START_TIME = "RunStartTime";
        public const string COL_RUN_END_TIME = "RunEndTime";
        public const string COL_IS_DISTRIBUTION_TO_MANAGER = "IsDistributionToManager";
        public const string COL_IS_EMAIL_DELIVERY_APPROVED = "IsEmailDeliveryApproved";
    }
    #endregion

    #region UserAssessmentQuestionTracking
    public class UserAssessmentQuestionTracking
    {
        public const string PROC_UPDATE = "sproc_UserAssessmentQuestionTracking_ups";
        public const string PROC_GET = "sproc_UserAssessmentQuestionTracking_sel";
        public const string PROC_DEL = "sproc_UserAssessmentQuestionTracking_del";
        public const string PROC_GET_ALL = "sproc_UserAssessmentQuestionTracking_LstAll";
        public const string PROC_GETALL_ASSESSMENT_QUESTIONS_TRACK = "sproc_UserAssessmentQuestions_LstAll";

        //Parameters constants
        public const string PARA_SYSTEMUSERGUID = "@SystemUserGUID";
        public const string PARA_QUESTION_ID = "@QuestionId";
        public const string PARA_ATTEMPT_ID = "@AttemptId";
        public const string PARA_CONTENTMODULE_ID = "@ContentModuleId";
        public const string PARA_CORRECT_COUNT = "@CorrectCount";
        public const string PARA_INCORRECT_COUNT = "@InCorrectCount";
        public const string PARA_ATTEMPT_HISTORY = "@AttemptHistory";

        //Column constants
        public const string COL_SYSTEMUSERGUID = "SystemUserGUID";
        public const string COL_QUESTION_ID = "QuestionId";
        public const string COL_ATTEMPT_ID = "AttemptId";
        public const string COL_CONTENTMODULE_ID = "ContentModuleId";
        public const string COL_CORRECT_COUNT = "CorrectCount";
        public const string COL_INCORRECT_COUNT = "InCorrectCount";
        public const string COL_QUESTION_TEXT = "QuestionText";
        public const string COL_QUESTION_UNIQUE_INDX_NUM = "QuestionUniqueIndxNum";
        public const string COL_ATTEMPT_HISTORY = "AttemptHistory";
        public const string COL_TOTAL_ATTEMPT = "TotalAttempt";

    }
    #endregion

    #region SessionLocationMaster
    public class SessionLocationMaster
    {
        //PROCEDURES
        public const string PROC_DELETE_SESSIONLOCATIONMASTER = "sproc_SessionLocationMaster_del";
        public const string PROC_UPDATE_SESSIONLOCATIONMASTER = "sproc_SessionLocationMaster_ups";
        public const string PROC_UPDATE_SESSIONLocationMASTER_LANGUAGE = "sproc_SessionLocationMasterLanguage_ups";
        public const string PROC_GET_ALL_SESSIONLOCATIONMASTER = "sproc_SessionLocationMaster_LstAll";
        public const string PROC_GET_SESSIONLOCATIONMASTER = "sproc_SessionLocationMaster_Sel";
        public const string PROC_GET_SESSIONLOCATION_LANGUAGES = "sproc_SessionLocationLanguage_sel_List";
        public const string PROC_BULK_UPDATE_ACTIVE_SESSIONLOCATIONMASTER = "sproc_SessionLocationMaster_ups_IsActive";

        public const string PROC_DELETE_SESSIONLOCATIONLANGUAGEMASTER = "sproc_SessionLocationLanguageMaster_del";

        //PARAMETERS
        public const string PARA_SESSIONLOCATIONID = "@SessionLocationId";
        public const string PARA_LANGUAGEID = "@LanguageId";
        public const string PARA_LOCATIONNAME = "@LocationName";
        public const string PARA_LOCATIONVENUE = "@LocationVenue";
        public const string PARA_LOCATIONCOST = "@LocationCost";
        public const string PARA_ISACTIVE = "@IsActive";

        //FIELDS
        public const string COL_SESSIONLOCATIONID = "SessionLocationId";
        public const string COL_LANGUAGEID = "LanguageId";
        public const string COL_LOCATIONNAME = "LocationName";
        public const string COL_LOCATIONVENUE = "LocationVenue";
        public const string COL_LOCATIONCOST = "LocationCost";
        public const string COL_ISACTIVE = "IsActive";

        // Prefix
        public const string VAL_SESSION_LOCATION_ID_PREFIX = "SLID";

    }
    #endregion

    #region ProgramType
    #region ProgramTypeMaster
    public class ProgramTypeMaster
    {
        //PROCEDURES
        public const string PROC_DELETE_PROGRAMTYPEMASTER = "sproc_ProgramTypeMaster_del";
        public const string PROC_UPDATE_PROGRAMTYPEMASTER = "sproc_ProgramTypeMaster_ups";
        public const string PROC_GET_ALL_PROGRAMTYPEMASTER = "sproc_ProgramTypeMaster_LstAll";
        public const string PROC_GET_PROGRAMTYPEMASTER = "sproc_ProgramTypeMaster_Sel";

        //PARAMETERS
        public const string PARA_PROGRAMTYPEID = "@ProgramTypeId";
        public const string PARA_NAME = "@Name";
        public const string PARA_DESCRIPTION = "@Description";

        //FIELDS
        public const string COL_PROGRAMTYPEID = "ProgramTypeId";
        public const string COL_NAME = "Name";
        public const string COL_DESCRIPTION = "Description";

        // Prefix
        public const string VAL_PROGRAM_TYPE_ID_PREFIX = "PROGT";
    }
    #endregion
    public class ProgramMaster
    {
        //PROCEDURES
        public const string PROC_DELETE_PROGRAMMASTER = "sproc_ProgramMaster_del";
        public const string PROC_UPDATE_PROGRAMMASTER = "sproc_ProgramMaster_ups";
        public const string PROC_UPDATE_PROGRAMMASTER_LANGUAGE = "sproc_ProgramMasterLanguage_ups";
        public const string PROC_GET_ALL_PROGRAMMASTER = "sproc_ProgramMaster_LstAll";
        public const string PROC_GET_ALL_PROGRAMMASTER_LEARNER = "sproc_ProgramMaster_LstAll_Learner";
        public const string PROC_GET_ALL_PROGRAMMASTER_FORNOMINATION = "sproc_ProgramMaster_LstAll_ForNomination";
        public const string PROC_GET_PROGRAMMASTER = "sproc_ProgramMaster_Sel";
        public const string PROC_GET_PROGRAMS_LANGUAGES = "sproc_ProgramsLanguage_sel_List";

        //PARAMETERS
        public const string PARA_PROGRAMID = "@ProgramId";
        public const string PARA_LANGUAGEID = "@LanguageId";
        public const string PARA_PROGRAMTYPEID = "@ProgramTypeId";
        public const string PARA_PROGRAMTYPENAME = "@ProgramTypeName";
        public const string PARA_PROGRAMNAME = "@ProgramName";
        public const string PARA_PROGRAMDESCRIPTION = "@ProgramDescription";
        public const string PARA_PROGRAMTYPE = "@ProgramType";
        public const string PARA_PROGRAMDURATION = "@ProgramDuration";
        public const string PARA_PROGRAMCOST = "@ProgramCost";
        public const string PARA_CONTACTPERSONEMAILID = "@ContactPersonEmailID";
        public const string PARA_PROGRAMOPENFROM = "@ProgramOpenFrom";
        public const string PARA_PROGRAMOPENTILL = "@ProgramOpenTill";
        public const string PARA_LOCATIONID = "@LocationId";
        public const string PARA_INSTRUCTORID = "@InstructorId";
        public const string PARA_SELFNOMINATION = "@SelfNomination";
        public const string PARA_PROGRAM_PREWORK = "@ProgramPreWork";
        public const string PARA_PROGRAM_POSTWORK = "@ProgramPostWork";
        public const string PARA_DIRECT_APPROVE = "@DirectApprove";
        public const string PARA_INCLUDE_WAITLISTED = "@IncludeWaitlisted";
        public const string PARA_LASTDATEOFNOMINATION = "@LastDateOfNomination";
        public const string PARA_LASTDATEOFCANCELLATION = "@LastDateOfCancellation";
        public const string PARA_MAXREGISTRATIONS = "@MaxRegistrations";
        public const string PARA_MINREGISTRATIONS = "@MinRegistrations";
        public const string PARA_WAITLISTING = "@Waitlisting";
        public const string PARA_MAXWAITLISTING = "@MaxWaitlisting";
        public const string PARA_SESSIONSTATUS = "@SessionStatus";
        public const string PARA_SYSTEMUSERGUID = "@SystemUserGUID";
        public const string PARA_PREFERREDTIMEZONE = "@PreferredTimeZone";

        public const string PARA_EXINACTIVE = "@ExInactive";

        //FIELDS
        public const string COL_PROGRAMID = "ProgramId";
        public const string COL_LANGUAGEID = "LanguageId";
        public const string COL_PROGRAMTYPEID = "ProgramTypeId";
        public const string COL_PROGRAMTYPENAME = "ProgramTypeName";
        public const string COL_PROGRAMNAME = "ProgramName";
        public const string COL_PROGRAMDESCRIPTION = "ProgramDescription";
        public const string COL_PROGRAMTYPE = "ProgramType";
        public const string COL_PROGRAMDURATION = "ProgramDuration";
        public const string COL_PROGRAMCOST = "ProgramCost";
        public const string COL_CONTACTPERSONEMAILID = "ContactPersonEmailID";
        public const string COL_PROGRAMOPENFROM = "ProgramOpenFrom";
        public const string COL_PROGRAMOPENTILL = "ProgramOpenTill";
        public const string COL_LOCATIONID = "LocationId";
        public const string COL_LOCATIONNAME = "LocationName";
        public const string COL_INSTRUCTORID = "InstructorId";
        public const string COL_INSTRUCTORNAME = "InstructorName";
        public const string COL_SELFNOMINATION = "SelfNomination";
        public const string COL_PROGRAM_PREWORK = "ProgramPreWork";
        public const string COL_PROGRAM_POSTWORK = "ProgramPostWork";
        public const string COL_DIRECT_APPROVE = "DirectApprove";
        public const string COL_INCLUDE_WAITLISTED = "IncludeWaitlisted";
        public const string COL_LASTDATEOFNOMINATION = "LastDateOfNomination";
        public const string COL_LASTDATEOFCANCELLATION = "LastDateOfCancellation";
        public const string COL_MAXREGISTRATIONS = "MaxRegistrations";
        public const string COL_MINREGISTRATIONS = "MinRegistrations";
        public const string COL_WAITLISTING = "Waitlisting";
        public const string COL_MAXWAITLISTING = "MaxWaitlisting";
        public const string COL_SESSIONSTATUS = "SessionStatus";
        public const string COL_STATUS = "Status";
        public const string COL_PREFERREDTIMEZONE = "PreferredTimeZone";
        // Prefix
        public const string VAL_PROGRAM_ID_PREFIX = "PROG";
    }
    #endregion

    #region UserSessionRegistration
    public class UserSessionRegistration
    {
        //PROCEDURES
        public const string PROC_DELETE_USERSESSIONREGISTRATION = "sproc_UserSessionRegistration_del";
        public const string PROC_UPDATE_USERSESSIONREGISTRATION = "sproc_UserSessionRegistration_ups_temp2";
        public const string PROC_MARK_ATTENDENCE_USERSESSIONREGISTRATION = "sproc_UserSessionRegistration_MarkAttendence";
        public const string PROC_GET_ALL_USERSESSIONREGISTRATION = "sproc_UserSessionRegistration_LstAll";
        public const string PROC_GET_ALL_USERSESSIONREGISTRATION_COMPLETED = "sproc_UserSessionRegistration_LstAll_Completed";
        public const string PROC_GET_USERSESSIONREGISTRATION = "sproc_UserSessionRegistration_Sel";
        public const string PROC_GET_NOMINATIONCOUNTBYSESSIONID = "sproc_NominationCountBySessionId_sel";
        public const string PROC_GET_NOMINATION_REJECT_APPROVE_WAITLIST_BYSESSIONID = "sproc_UserSessionRegistration_reject_approve_waitlist";

        //PARAMETERS
        public const string PARA_SYSTEMUSERGUID = "@SystemUserGuId";
        public const string PARA_SESSIONID = "@SessionId";
        public const string PARA_LANGUAGEID = "@LanguageId";
        public const string PARA_PROGRAMID = "@ProgramId";
        public const string PARA_STATUS = "@Status";
        public const string PARA_MANAGERID = "@ManagerId";
        public const string PARA_MANAGERAPPROVALDATE = "@ManagerApprovalDate";
        public const string PARA_MANAGERAPPROVALSTATUS = "@ManagerApprovalStatus";
        public const string PARA_REJECTIONDATE = "@RejectionDate";

        public const string PARA_NOMINATED_BY_ID = "@NominatedById";

        //FIELDS
        public const string COL_SYSTEMUSERGUID = "SystemUserGuId";
        public const string COL_SESSIONID = "SessionId";
        public const string COL_PROGRAMID = "ProgramId";
        public const string COL_STATUS = "Status";
        public const string COL_FIRSTNAME = "FirstName";
        public const string COL_LASTNAME = "LastName";
        public const string COL_EmailID = "EmailID";
        public const string COL_MANAGERID = "ManagerId";
        public const string COL_MANAGERAPPROVALDATE = "ManagerApprovalDate";
        public const string COL_MANAGERAPPROVALSTATUS = "ManagerApprovalStatus";
        public const string COL_REJECTIONDATE = "RejectionDate";
        public const string COL_SESSIONNAME = "SessionName";
        public const string COL_MAXREGISTRATION = "MaxRegistrations";
        public const string COL_NOMINATIONCOUNT = "NominationCount";
        public const string COL_WAITLISTCOUNT = "WaitlistCount";
        public const string COL_WAITLISTSTATUS = "Waitlisting";
        public const string COL_USERNAME = "UserName";
        public const string COL_MAXWAITLISTSTATUS = "MaxWaitlisting";

        public const string COL_NOMINATED_BY_ID = "NominatedById";
        public const string COL_PROGRAMNAME = "ProgramName";
    }
    #endregion

    #region SessionMaster
    public class SessionMaster
    {
        //PROCEDURES
        public const string PROC_DELETE_SESSIONMASTER = "sproc_SessionMaster_del";
        public const string PROC_UPDATE_SESSIONMASTER = "sproc_SessionMaster_ups";
        public const string PROC_UPDATE_SESSIONMASTER_LANGUAGE = "sproc_SessionMasterLanguage_ups";
        public const string PROC_UPDATESTATUS_SESSIONMASTER = "sproc_SessionMaster_ups_IsActive";
        public const string PROC_GET_ALL_SESSIONMASTER = "sproc_SessionMaster_LstAll";
        public const string PROC_GET_ALL_SESSIONMASTER_Nomination = "sproc_SessionMaster_LstAll_Nomination";
        public const string PROC_GET_SESSIONMASTER = "sproc_SessionMaster_Sel";
        public const string PROC_GET_ALL_SESSIONMASTER_ProgramWise = "sproc_SessionMaster_sel_ProgramID_wise";
        public const string PROC_GET_SESSIONS_LANGUAGES = "sproc_SessionsLanguage_sel_List";

        //PARAMETERS
        public const string PARA_SESSIONID = "@SessionId";
        public const string PARA_LANGUAGEID = "@LanguageId";
        public const string PARA_PROGRAMID = "@ProgramId";
        public const string PARA_PROGRAMNAME = "@ProgramName";
        public const string PARA_INSTRUCTORNAME = "@InstructorName";
        public const string PARA_SESSIONNAME = "@SessionName";
        public const string PARA_SESSIONTYPEID = "@SessionTypeId";
        public const string PARA_SESSIONLOCATIONID = "@SessionLocationId";
        public const string PARA_SESSIONLOCATIONNAME = "@SessionLocationName";
        public const string PARA_SESSIONFROMDATE = "@SessionFromDate";
        public const string PARA_SESSIONTODATE = "@SessionToDate";
        public const string PARA_SESSIONSTATUS = "@SessionStatus";
        public const string PARA_INSTRUCTORID = "@InstructorId";
        public const string PARA_SESSIONREMINDER = "@SessionReminder";
        public const string PARA_SESSIONCOST = "@SessionCost";
        public const string PARA_SESSIONFROMTIME = "@SessionFromTime";
        public const string PARA_SESSIONTOTIME = "@SessionToTime";
        public const string PARA_SESSIONRESOURSEID = "@SupportResourceIds";
        public const string PARA_MAXWAITLISTING = "@MaxWaitlisting";
        public const string PARA_SESSION_DESCRIPTION = "@SessionDescription";
        public const string PARA_SESSION_Duration = "@Duration";
        public const string PARA_SESSION_PREWORK = "@SessionPrework";
        public const string PARA_SESSION_POSTWORK = "@SessionPostwork";

        //FIELDS
        public const string COL_SESSIONID = "SessionId";
        public const string COL_LANGUAGEID = "LanguageId";
        public const string COL_PROGRAMID = "ProgramId";
        public const string COL_PROGRAMNAME = "ProgramName";
        public const string COL_SESSIONNAME = "SessionName";
        public const string COL_SESSIONTYPEID = "SessionTypeId";
        public const string COL_SESSIONLOCATIONID = "SessionLocationId";
        public const string COL_SESSIONLOCATIONNAME = "LocationName";
        public const string COL_SESSIONFROMDATE = "SessionFromDate";
        public const string COL_SESSIONTODATE = "SessionToDate";
        public const string COL_SESSIONSTATUS = "SessionStatus";
        public const string COL_INSTRUCTORID = "InstructorId";
        public const string COL_INSTRUCTORNAME = "InstructorName";
        public const string COL_MAXREGISTRATIONS = "MaxRegistrations";
        public const string COL_MINREGISTRATIONS = "MinRegistrations";
        public const string COL_SELFNOMINATION = "SelfNomination";
        public const string COL_WAITLISTING = "Waitlisting";
        public const string COL_LASTDATEOFNOMINATION = "LastDateOfNomination";
        public const string COL_LASTDATEOFCANCELLATION = "LastDateOfCancellation";
        public const string COL_SESSIONREMINDER = "SessionReminder";
        public const string COL_SESSIONCOST = "SessionCost";
        public const string COL_SESSIONFROMTIME = "SessionFromTime";
        public const string COL_SESSIONTOTIME = "SessionToTime";
        public const string COL_SESSIONRESOURSEID = "SupportResourceId";
        public const string COL_MAXWAITLISTING = "MaxWaitlisting";
        public const string COL_SESSION_DESCRIPTION = "SessionDescription";
        public const string COL_SESSION_Duration = "Duration";
        public const string COL_SESSION_PREWORK = "SessionPrework";
        public const string COL_SESSION_POSTWORK = "SessionPostwork";
        // Prefix
        public const string VAL_SESSION_ID_PREFIX = "SES";
    }
    #endregion

    #region Vendor
    public class Vendor
    {
        //PROCESURES
        public const string PROC_UPDATE_VENDOR = "sproc_VendorMaster_ups";
        public const string PROC_DELETE_VENDOR = "sproc_VendorMaster_del";
        public const string PROC_GET_ALL_VENDOR = "sproc_VendorMaster_LstAll";
        public const string PROC_GET_VENDOR = "sproc_VendorMaster_sel";

        //PARAMETERS
        public const string PARA_VENDOR_ID = "@VendorId";
        public const string PARA_VENDOR_NAME = "@VendorName";
        public const string PARA_CONTACT_PERSON = "@ContactPerson";
        public const string PARA_CONTACT_ADDRESS = "@ContactAddress";
        public const string PARA_EMAIL_ID = "@EmailId";
        public const string PARA_PHONE_NO = "@PhoneNo";
        public const string PARA_REMARKS = "@Remarks";

        //FIELDS
        public const string COL_VENDOR_ID = "VendorId";
        public const string COL_VENDOR_NAME = "VendorName";
        public const string COL_CONTACT_PERSON = "ContactPerson";
        public const string COL_CONTACT_ADDRESS = "ContactAddress";
        public const string COL_EMAIL_ID = "EmailId";
        public const string COL_PHONE_NO = "PhoneNo";
        public const string COL_REMARKS = "Remarks";

        // PREFIX
        public const string VAL_VENDOR_ID_PREFIX = "VDR";
    }
    #endregion

    #region UserSessionFeedback
    public class UserSessionFeedback
    {
        //PROCEDURES
        public const string PROC_DELETE_USERSESSIONFEEDBACK = "sproc_UserSessionFeedback_del";
        public const string PROC_UPDATE_USERSESSIONFEEDBACK = "sproc_UserSessionFeedback_ups";
        public const string PROC_GET_ALL_USERSESSIONFEEDBACK = "sproc_UserSessionFeedback_LstAll";
        public const string PROC_GET_USERSESSIONFEEDBACK = "sproc_UserSessionFeedback_Sel";

        //PARAMETERS
        public const string PARA_SYSTEMUSERGUID = "@SystemUserGuId";
        public const string PARA_SESSIONID = "@SessionId";
        public const string PARA_QUESTIONNAIREID = "@QuestionnaireID";
        public const string PARA_COMMENTS = "@Comments";
        public const string PARA_USERFEEDBACKFILENAME = "@UserFeedBackFileName";

        //FIELDS
        public const string COL_SYSTEMUSERGUID = "SystemUserGuId";
        public const string COL_SESSIONID = "SessionId";
        public const string COL_QUESTIONNAIREID = "QuestionnaireID";
        public const string COL_COMMENTS = "Comments";
        public const string COL_USERFEEDBACKFILENAME = "UserFeedBackFileName";
    }
    #endregion

    #region UserSessionAttendence
    public class UserSessionAttendence
    {
        //PROCEDURES
        public const string PROC_DELETE_USERSESSIONATTENDENCE = "sproc_UserSessionAttendence_del";
        public const string PROC_UPDATE_USERSESSIONATTENDENCE = "sproc_UserSessionAttendence_ups";
        public const string PROC_GET_ALL_USERSESSIONATTENDENCE = "sproc_UserSessionAttendence_LstAll";
        public const string PROC_GET_USERSESSIONATTENDENCE = "sproc_UserSessionAttendence_Sel";
        //PARAMETERS
        public const string PARA_SYSTEMUSERGUID = "@SystemUserGuId";
        public const string PARA_SESSIONID = "@SessionId";
        public const string PARA_PROGRAMID = "@ProgramId";
        public const string PARA_ATTENDENCEFROMDATE = "@AttendenceFromDate";
        public const string PARA_ATTENDENCETODATE = "@AttendenceToDate";
        public const string PARA_ATTENDENCEDAYS = "@AttendenceDays";

        //FIELDS
        public const string COL_SYSTEMUSERGUID = "SystemUserGuId";
        public const string COL_SESSIONID = "SessionId";
        public const string COL_ATTENDENCEFROMDATE = "AttendenceFromDate";
        public const string COL_ATTENDENCETODATE = "AttendenceToDate";
        public const string COL_ATTENDENCEDAYS = "AttendenceDays";
    }
    #endregion

    #region UserSessionAttendenceDays
    public class UserSessionAttendenceDays
    {
        //PROCEDURES
        public const string PROC_DELETE_USERSESSIONATTENDENCEDAYS = "sproc_UserSessionAttendenceDays_del";
        public const string PROC_UPDATE_USERSESSIONATTENDENCEDAYS = "sproc_UserSessionAttendenceDays_ups";
        public const string PROC_GET_ALL_USERSESSIONATTENDENCEDAYS = "sproc_UserSessionAttendenceDays_LstAll";
        public const string PROC_GET_USERSESSIONATTENDENCEDAYS = "sproc_UserSessionAttendenceDays_Sel";

        //PARAMETERS
        public const string PARA_SESSIONID = "@SessionId";
        public const string PARA_PROGRAMID = "@ProgramId";
        public const string PARA_SYSTEMUSERGUID = "@SystemUserGuId";
        public const string PARA_ATTENDENCEDATE = "@AttendenceDate";
        public const string PARA_ATTENDENCE = "@attendence";

        //FIELDS
        public const string COL_SESSIONID = "SessionId";
        public const string COL_PROGRAMID = "ProgramId";
        public const string COL_SYSTEMUSERGUID = "SystemUserGuId";
        public const string COL_ATTENDENCEDATE = "AttendenceDate";
        public const string COL_ATTENDENCE = "attendence";
    }
    #endregion

    #region SupportResourceTypeMaster
    public class SupportResourceTypeMaster
    {
        //PROCEDURES
        public const string PROC_DELETE_SUPPORTRESOURCETYPEMASTER = "sproc_SupportResourceTypeMaster_del";
        public const string PROC_UPDATE_SUPPORTRESOURCETYPEMASTER = "sproc_SupportResourceTypeMaster_ups";
        public const string PROC_GET_ALL_SUPPORTRESOURCETYPEMASTER = "sproc_SupportResourceTypeMaster_LstAll";
        public const string PROC_GET_SUPPORTRESOURCETYPEMASTER = "sproc_SupportResourceTypeMaster_Sel";

        //PARAMETERS
        public const string PARA_SUPPORTRESOURCETYPEID = "@SupportResourceTypeId";
        public const string PARA_VENDORID = "@VendorId";
        public const string PARA_RESOURCETYPE = "@ResourceType";
        public const string PARA_FileUploadRights = "@FileUploadRights";

        //FIELDS
        public const string COL_SUPPORTRESOURCETYPEID = "SupportResourceTypeId";
        public const string COL_VENDORID = "VendorId";
        public const string COL_VENDORNAME = "VendorName";
        public const string COL_RESOURCETYPE = "ResourceType";
        public const string COL_FileUploadRights = "FileUploadRights";



        // PREFIX
        public const string VAL_ResourceType_ID_PREFIX = "REST";
    }
    #endregion

    #region RefMaterialMaster
    public class RefMaterialMaster
    {
        //PROCEDURES
        public const string PROC_DELETE_REFMATERIALMASTER = "sproc_RefMaterialMaster_del";
        public const string PROC_UPDATE_REFMATERIALMASTER = "sproc_RefMaterialMaster_ups";
        public const string PROC_UPDATE_REFMATERIALMASTER_LANGUAGE = "sproc_RefMaterialMasterLanguage_ups";
        public const string PROC_GET_ALL_REFMATERIALMASTER = "sproc_RefMaterialMaster_LstAll";
        public const string PROC_GET_REFMATERIALMASTER = "sproc_RefMaterialMaster_Sel";
        public const string PROC_GET_REFMATERIAL_LANGUAGES = "sproc_RefMaterialMasterLanguage_sel_List";
        public const string PROC_BULK_UPDATE_ACTIVE_REFMATERIALMASTER = "sproc_RefMaterialMaster_ups_IsAcive";

        public const string PROC_DELETE_REFMATERIALMASTER_LANGUAGE = "sproc_RefMaterialMasterLanguage_del";

        //PARAMETERS
        public const string PARA_REFMATERIAL_ID = "@RefmaterialId";
        public const string PARA_REFMATERIAL_LANGUAGEID = "@LanguageId";
        public const string PARA_REFMATERIAL_DOCUMENTNAME = "@DocumentName";
        public const string PARA_REFMATERIAL_DOCUMENTDESCRIPTION = "@DocumentDescription";
        public const string PARA_REFMATERIAL_FILENAME = "@FileName";
        public const string PARA_REFMATERIAL_ISACTIVE = "@IsActive";

        //FIELDS
        public const string COL_REFMATERIAL_ID = "RefmaterialId";
        public const string COL_REFMATERIAL_LANGUAGEID = "LanguageId";
        public const string COL_REFMATERIAL_DOCUMENTNAME = "DocumentName";
        public const string COL_REFMATERIAL_DOCUMENTDESCRIPTION = "DocumentDescription";
        public const string COL_REFMATERIAL_FILENAME = "FileName";
        public const string COL_REFMATERIAL_ISACTIVE = "IsActive";

        // PREFIX
        public const string VAL_ResourceID_PREFIX = "RES";
    }
    #endregion

    #region InstructorMaster
    public class InstructorMaster
    {
        //PROCEDURES
        public const string PROC_DELETE_INSTRUCTORMASTER = "sproc_InstructorMaster_del";
        public const string PROC_UPDATE_INSTRUCTORMASTER = "sproc_InstructorMaster_ups";
        public const string PROC_UPDATE_INSTRUCTORMASTER_LANGUAGE = "sproc_InstructorMasterLanguage_ups";
        public const string PROC_GET_ALL_INSTRUCTORMASTER = "sproc_InstructorMaster_LstAll";
        public const string PROC_GET_INSTRUCTORMASTER = "sproc_InstructorMaster_Sel";
        public const string PROC_GET_INSTRUCTOR_LANGUAGES = "sproc_InstructorLanguage_sel_List";
        public const string PROC_BULK_UPDATE_ACTIVE_INSTRUCTORMASTER = "sproc_InstructorMaster_ups_IsActive";

        public const string PROC_DELETE_INSTRUCTORLANGUAGEMASTER = "sproc_InstructorLanguageMaster_del";

        //PARAMETERS
        public const string PARA_INSTRUCTORID = "@InstructorId";
        public const string PARA_LANGUAGEID = "@LanguageId";
        public const string PARA_INSTRUCTORNAME = "@InstructorName";
        public const string PARA_INSTRUCTOREMAIL = "@InstructorEmail";
        public const string PARA_INSTRUCTORCOST = "@InstructorCost";
        public const string PARA_INSTRUCTORDETAILS = "@InstructorDetails";
        public const string PARA_INSTRUCTOR_ISACTIVE = "@IsActive";

        //FIELDS
        public const string COL_INSTRUCTORID = "InstructorId";
        public const string COL_LANGUAGEID = "LanguageId";
        public const string COL_INSTRUCTORNAME = "InstructorName";
        public const string COL_EMAIL = "InstructorEmail";
        public const string COL_INSTRUCTORCOST = "InstructorCost";
        public const string COL_INSTRUCTORDETAILS = "InstructorDetails";
        public const string COL_INSTRUCTOR_ISACTIVE = "IsActive";
        // Prefix
        public const string VAL_INSTRUCTOR_ID_PREFIX = "INST";

    }
    #endregion

    #region SessionTypeMaster
    public class SessionTypeMaster
    {
        //PROCEDURES
        public const string PROC_DELETE_SESSIONTYPEMASTER = "sproc_SessionTypeMaster_del";
        public const string PROC_UPDATE_SESSIONTYPEMASTER = "sproc_SessionTypeMaster_ups";
        public const string PROC_GET_ALL_SESSIONTYPEMASTER = "sproc_SessionTypeMaster_LstAll";
        public const string PROC_GET_SESSIONTYPEMASTER = "sproc_SessionTypeMaster_Sel";


        //PARAMETERS
        public const string PARA_SESSIONTYPEID = "@SessionTypeId";
        public const string PARA_SESSIONTYPE = "@SessionType";
        public const string PARA_SESSIONTYPEDESCRIPTION = "@SessionTypeDescription";

        //FIELDS
        public const string COL_SESSIONTYPEID = "SessionTypeId";
        public const string COL_SESSIONTYPE = "SessionType";
        public const string COL_SESSIONTYPEDESCRIPTION = "SessionTypeDescription";

        // PREFIX
        public const string SESSION_ID_PREFIX = "SEN";
    }
    #endregion

    #region SessionAllocatedSpeakers
    public class SessionAllocatedSpeakers
    {
        //PROCEDURES
        public const string PROC_DELETE_SESSIONALLOCATEDSPEAKERS = "sproc_SessionAllocatedSpeakers_del";
        public const string PROC_UPDATE_SESSIONALLOCATEDSPEAKERS = "sproc_SessionAllocatedSpeakers_ups";
        public const string PROC_GET_ALL_SESSIONALLOCATEDSPEAKERS = "sproc_SessionAllocatedSpeakers_LstAll";
        public const string PROC_GET_SESSIONALLOCATEDSPEAKERS = "sproc_SessionAllocatedSpeakers_Sel";

        //PARAMETERS
        public const string PARA_SPEAKERID = "@SpeakerId";
        public const string PARA_SESSIONID = "@SessionId";
        public const string PARA_SPEAKERSESSIONTIME = "@SpeakerSessionTime";

        //FIELDS
        public const string COL_SPEAKERID = "SpeakerId";
        public const string COL_SESSIONID = "SessionId";
        public const string COL_SPEAKERSESSIONTIME = "SpeakerSessionTime";
    }
    #endregion

    #region SessionAllocatedResources
    public class SessionAllocatedResources
    {
        //PROCEDURES
        public const string PROC_DELETE_SESSIONALLOCATEDRESOURCES = "sproc_SessionAllocatedResources_del";
        public const string PROC_UPDATE_SESSIONALLOCATEDRESOURCES = "sproc_SessionAllocatedResources_ups";
        public const string PROC_GET_ALL_SESSIONALLOCATEDRESOURCES = "sproc_SessionAllocatedResources_LstAll";
        public const string PROC_GET_SESSIONALLOCATEDRESOURCES = "sproc_SessionAllocatedResources_Sel";
        public const string PROC_GET_SESSIONALLOCATEDRESOURCESBYID = "sproc_SessionAllocatedResourcesBySessionId_sel";

        public const string PROC_GET_ALL_MAPPEDSESSIONALLOCATEDRESOURCES = "sproc_MappedSessionAllocatedResources_LstAll";

        //PARAMETERS
        public const string PARA_REFMATERIALID = "@RefMaterialId";
        public const string PARA_SESSIONID = "@SessionId";
        public const string PARA_PROGRAMID = "@ProgramId";

        //FIELDS
        public const string COL_REFMATERIALID = "RefMaterialId";
        public const string COL_REFMATERIALDOCUMENTNAME = "DocumentName";
        public const string COL_SESSIONID = "SessionId";
        public const string COL_PROGRAMID = "ProgramId";
        public const string COL_REFMATERIALFILENAME = "FileName";
    }
    #endregion

    /***************************************************************************************************************************/

    #region QuestionCategory
    public class QuestionCategory
    {
        //PROCEDURES
        public const string PROC_DELETE_QUESTIONCATEGORY = "sproc_QuestionCategory_del";
        public const string PROC_UPDATE_QUESTIONCATEGORY = "sproc_QuestionCategory_ups";
        public const string PROC_GET_ALL_QUESTIONCATEGORY = "sproc_QuestionCategory_LstAll";
        public const string PROC_GET_QUESTIONCATEGORY = "sproc_QuestionCategory_Sel";
        public const string PROC_GET_QUESTIONCATEGORY_BYNAME = "sproc_QuestionCategory_sel_ByName";
        public const string PROC_QUESTIONCATEGORY_ISAVAILABLE = "sproc_QuestionCategory_IsAvailable";
        public const string PROC_QUESTIONCATEGORY_ISEXITS = "sproc_QuestionCategory_IsExits";

        //PARAMETERS
        public const string PARA_CATEGORYID = "@CategoryID";
        public const string PARA_CATEGORYNAME = "@CategoryName";
        public const string PARA_CATEGORYDESCRIPTION = "@CategoryDescription";
        public const string PARA_CREATED_BY_ID = "@CreatedById";

        //FIELDS
        public const string COL_CATEGORYID = "CategoryID";
        public const string COL_CATEGORYNAME = "CategoryName";
        public const string COL_CATEGORYDESCRIPTION = "CategoryDescription";
        public const string COL_CREATED_BY_ID = "CreatedById";
    }
    #endregion

    #region QuestionSubCategory
    public class QuestionSubCategory
    {
        //PROCEDURES
        public const string PROC_DELETE_QUESTIONSUBCATEGORY = "sproc_QuestionSubCategory_del";
        public const string PROC_UPDATE_QUESTIONSUBCATEGORY = "sproc_QuestionSubCategory_ups";
        public const string PROC_GET_ALL_QUESTIONSUBCATEGORY = "sproc_QuestionSubCategory_LstAll";
        public const string PROC_GET_QUESTIONSUBCATEGORY = "sproc_QuestionSubCategory_Sel";
        public const string PROC_GET_QUESTIONSUBCATEGORY_BYNAME = "sproc_QuestionSubCategory_sel_ByName";
        public const string PROC_GET_QUESTIONSUBCATEGORY_CATEGORYID_WISE = "sproc_QuestionSubCategory_sel_CategoryID_Wise";
        public const string PROC_QUESTIONSUBCATEGORY_ISAVAILABLE = "sproc_QuestionSubCategory_IsAvailable";
        public const string PROC_QUESTIONSUBCATEGORY_ISEXITS = "sproc_QuestionSubCategory_IsExits";

        //PARAMETERS
        public const string PARA_CATEGORYID = "@CategoryID";
        public const string PARA_SUBCATEGORYID = "@SubCategoryID";
        public const string PARA_SUBCATEGORYNAME = "@SubCategoryName";
        public const string PARA_SUBCATEGORYDESCRIPTION = "@SubCategoryDescription";
        public const string PARA_CREATED_BY_ID = "@CreatedById";

        //FIELDS
        public const string COL_CATEGORYID = "CategoryID";
        public const string COL_SUBCATEGORYID = "SubCategoryID";
        public const string COL_SUBCATEGORYNAME = "SubCategoryName";
        public const string COL_CATEGORYNAME = "CategoryName";
        public const string COL_SUBCATEGORYDESCRIPTION = "SubCategoryDescription";
        public const string COL_CREATED_BY_ID = "CreatedById";
    }
    #endregion

    #region QuestionBank
    public class QuestionBank
    {
        //PROCEDURES
        public const string PROC_DELETE_QUESTIONBANK = "sproc_QuestionBank_del";
        public const string PROC_UPDATE_QUESTIONBANK = "sproc_QuestionBank_ups";
        public const string PROC_GET_ALL_QUESTIONBANK = "sproc_QuestionBank_LstAll";
        public const string PROC_GET_QUESTIONBANK = "sproc_QuestionBank_Sel";
        public const string PROC_FIND_QUESTIONBANK = "sproc_QuestionBank_Sel_Search";
        public const string PROC_ACTIVE_QUESTIONBANK = "sproc_QuestionBank_ups_IsActive";

        public const string PROC_GET_IMPORT_LANGUAGE = "sproc_LanguageMaster_LstQBImport";
        public const string PROC_GET_EXPORT_LANGUAGE = "sproc_LanguageMaster_LstQBExport";
        public const string PROC_GET_QUESTIONBANK_LANGUAGES = "sproc_QuestionBankLanguage_sel_List";
        public const string PROC_DELETE_QUESTIONBANKLANGUAGE = "sproc_QuestionBankLanguage_del";


        //PARAMETERS
        public const string PARA_QUESTIONID = "@QuestionId";
        public const string PARA_CATEGORYID = "@CategoryID";
        public const string PARA_SUBCATEGORYID = "@SubCategoryID";
        public const string PARA_QUESTIONTYPE = "@QuestionType";
        public const string PARA_ISACTIVE = "@IsActive";
        public const string PARA_KEYWARDS = "@Keywards";
        public const string PARA_CREATED_BY_ID = "@CreatedByID";


        //FIELDS
        public const string COL_QUESTIONID = "QuestionId";
        public const string COL_CATEGORYID = "CategoryID";
        public const string COL_SUBCATEGORYID = "SubCategoryID";
        public const string COL_QUESTIONTYPE = "QuestionType";
        public const string COL_ISACTIVE = "IsActive";
        public const string COL_KEYWARDS = "Keywards";
        public const string COL_CREATED_BY_ID = "CreatedByID";
    }
    #endregion

    #region QuestionBankLanguage
    public class QuestionBankLanguage
    {
        //PROCEDURES
        public const string PROC_DELETE_QUESTIONBANKLANGUAGE = "sproc_QuestionBankLanguage_del";
        public const string PROC_UPDATE_QUESTIONBANKLANGUAGE = "sproc_QuestionBankLanguage_ups";
        public const string PROC_GET_ALL_QUESTIONBANKLANGUAGE = "sproc_QuestionBankLanguage_LstAll";
        public const string PROC_GET_QUESTIONBANKLANGUAGE = "sproc_QuestionBankLanguage_Sel";

        //PARAMETERS
        public const string PARA_QUESTIONID = "@QuestionId";
        public const string PARA_LANGUAGEID = "@LanguageId";
        public const string PARA_QUESTIONTITLE = "@QuestionTitle";
        public const string PARA_QUESTIONDESCRIPTION = "@QuestionDescription";

        //FIELDS
        public const string COL_QUESTIONID = "QuestionId";
        public const string COL_LANGUAGEID = "LanguageId";
        public const string COL_QUESTIONTITLE = "QuestionTitle";
        public const string COL_QUESTIONDESCRIPTION = "QuestionDescription";
    }
    #endregion

    #region QuestionBankOptions
    public class QuestionBankOptions
    {
        //PROCEDURES
        public const string PROC_DELETE_QUESTIONBANKOPTIONS = "sproc_QuestionBankOptions_del";
        public const string PROC_UPDATE_QUESTIONBANKOPTIONS = "sproc_QuestionBankOptions_ups";
        public const string PROC_GET_ALL_QUESTIONBANKOPTIONS = "sproc_QuestionBankOptions_LstAll";
        public const string PROC_GET_QUESTIONBANKOPTIONS = "sproc_QuestionBankOptions_Sel";
        public const string PROC_DELETE_OPTIONS = "sproc_QuestionBankOptions_delByQuestion";

        //PARAMETERS
        public const string PARA_QUESTIONOPTIONSID = "@QuestionOptionsID";
        public const string PARA_QUESTIONID = "@QuestionID";
        public const string PARA_ISEXPLANATION = "@IsExplanation";
        public const string PARA_OPTIONTYPE = "@OptionType";
        public const string PARA_SEQUENCEORDER = "@SequenceOrder";
        public const string PARA_ISACTIVE = "@IsActive";
        public const string PARA_ISALERT = "@IsAlert";

        //FIELDS
        public const string COL_QUESTIONOPTIONSID = "QuestionOptionsID";
        public const string COL_QUESTIONID = "QuestionID";
        public const string COL_ISEXPLANATION = "IsExplanation";
        public const string COL_OPTIONTYPE = "OptionType";
        public const string COL_SEQUENCEORDER = "SequenceOrder";
        public const string COL_ISACTIVE = "IsActive";
        public const string COL_ISALERT = "IsAlert";
    }
    #endregion

    #region QuestionBankOptionsLanguage
    public class QuestionBankOptionsLanguage
    {
        //PROCEDURES
        public const string PROC_DELETE_QUESTIONBANKOPTIONSLANGUAGE = "sproc_QuestionBankOptionsLanguage_del";
        public const string PROC_UPDATE_QUESTIONBANKOPTIONSLANGUAGE = "sproc_QuestionBankOptionsLanguage_ups";
        public const string PROC_GET_ALL_QUESTIONBANKOPTIONSLANGUAGE = "sproc_QuestionBankOptionsLanguage_LstAll";
        public const string PROC_GET_QUESTIONBANKOPTIONSLANGUAGE = "sproc_QuestionBankOptionsLanguage_Sel";

        //PARAMETERS
        public const string PARA_QUESTIONOPTIONSID = "@QuestionOptionsID";
        public const string PARA_LANGUAGEID = "@LanguageId";
        public const string PARA_OPTIONTITLE = "@OptionTitle";
        public const string PARA_OPTIONDESCRIPTION = "@OptionDescription";
        public const string PARA_EXPLAINATIONTITLE = "@ExplainationTitle";

        //FIELDS
        public const string COL_QUESTIONOPTIONSID = "QuestionOptionsID";
        public const string COL_LANGUAGEID = "LanguageId";
        public const string COL_OPTIONTITLE = "OptionTitle";
        public const string COL_OPTIONDESCRIPTION = "OptionDescription";
        public const string COL_EXPLAINATIONTITLE = "ExplainationTitle";
    }
    #endregion

    #region MerchantInfo
    public class MerchantInfo
    {
        //PROCEDURES
        public const string PROC_GETALL_MERCHANTINFO = "sproc_MerchantInfo_LstAll";
        public const string PROC_GET_MERCHANTINFO = "sproc_MerchantInfo_sel";
        public const string PROC_DELETE_MERCHANTINFO = "sproc_MerchantInfo_del";
        public const string PROC_UPDATE_MERCHANTINFO = "sproc_MerchantInfo_ups";

        //PARAMETERS
        public const string PARA_PAYMENTGATEWAYID = "@PaymentGatewayId";
        public const string PARA_PAYMENTGATEWAYNAME = "@PaymentGatewayName";
        public const string PARA_MERCHANTID = "@MerchantID";
        public const string PARA_TOKEN = "@Token";
        public const string PARA_REDIRECTURL = "@RedirectURL";
        public const string PARA_TERMINALURL = "@terminalUrl";
        public const string PARA_ISACTIVE = "@IsActive";
        public const string PARA_PROTOCOL = "Protocol";

        //FIELDS
        public const string COL_PAYMENTGATEWAYID = "PaymentGatewayId";
        public const string COL_PAYMENTGATEWAYNAME = "PaymentGatewayName";
        public const string COL_MERCHANTID = "MerchantID";
        public const string COL_TOKEN = "Token";
        public const string COL_REDIRECTURL = "RedirectURL";
        public const string COL_TERMINALURL = "terminalUrl";
        public const string COL_ISACTIVE = "IsActive";
        public const string COL_PROTOCOL = "Protocol";
    }
    #endregion

    #region Category
    public class Category
    {
        //PROCEDURES
        public const string PROC_DELETE_PRODUCTCATEGORY = "sproc_ProductCategory_del";
        public const string PROC_UPDATE_PRODUCTCATEGORY = "sproc_ProductCategory_ups";
        public const string PROC_GET_ALL_PRODUCTCATEGORY = "sproc_ProductCategory_LstAll";
        public const string PROC_GET_PRODUCTCATEGORY = "sproc_ProductCategory_Sel";
        public const string PROC_GET_PRODUCTCATEGORY_ISNAMEAVAILABLE = "sproc_ProductCategory_IsnameAvailable";
        public const string PROC_GET_PRODUCTCATEGORY_LANGUAGES = "sproc_ProductCategoryLanguage_sel_List";
        public const string PROC_UPDATE_PRODUCTCATEGORY_STATUS = "sproc_ProductCategory_ups_Status";


        //PARAMETERS
        public const string PARA_CATEGORYID = "@CategoryID";
        public const string PARA_ISACTIVE = "@IsActive";
        public const string PARA_CATEGORYNAME = "@CategoryName";
        public const string PARA_DESCRIPTION = "@Description";


        //FIELDS
        public const string COL_CATEGORYID = "CategoryID";
        public const string COL_ISACTIVE = "IsActive";
        public const string COL_CATEGORYNAME = "CategoryName";
        public const string COL_DESCRIPTION = "Description";
    }
    #endregion

    #region CategoryMapping
    public class CategoryMapping
    {
        //PROCEDURES
        public const string PROC_DELETE_CATEGORY_MAPPING = "sproc_CategoryActivityMapping_del";
        public const string PROC_UPDATE_CATEGORY_MAPPING = "sproc_CategoryActivityMapping_ups";
        public const string PROC_GET_ALL_CATEGORY_MAPPING = "sproc_CategoryActivityMapping_LstAll";
        public const string PROC_GET_CATEGORY_MAPPING = "sproc_CategoryActivityMapping_Sel";
        public const string PROC_GET_ALL_CATEGORY_MAPPING_BY_CATEGORY = "sproc_CategoryActivityMapping_LstAll_ByCategory";

        //PARAMETERS
        public const string PARA_ACTIVITY_ID = "@ActivityId";
        public const string PARA_ACTIVITY_TYPE_ID = "@ActivityTypeId";
        public const string PARA_CATEGORY_ID = "@CategoryId";
        public const string PARA_SUBCATEGORY_ID = "@SubCategoryId";
        public const string PARA_ACTIVITY_NAME = "@ActivityName";

        //FIELDS
        public const string COL_ACTIVITY_ID = "ActivityId";
        public const string COL_ACTIVITY_TYPE_ID = "ActivityTypeId";
        public const string COL_CATEGORY_ID = "CategoryId";
        public const string COL_SUBCATEGORY_ID = "SubCategoryId";
        public const string COL_ACTIVITY_NAME = "ActivityName";
        public const string COL_CATEGORYNAME = "CategoryName";
        public const string COL_SUBCATEGORYNAME = "SubCategoryName";
    }
    #endregion

    #region CategoryLanguage
    public class CategoryLanguage
    {
        //PROCEDURES
        public const string PROC_DELETE_PRODUCTCATEGORYLANGUAGE = "sproc_ProductCategoryLanguage_del";
        public const string PROC_UPDATE_PRODUCTCATEGORYLANGUAGE = "sproc_ProductCategoryLanguage_ups";
        public const string PROC_GET_ALL_PRODUCTCATEGORYLANGUAGE = "sproc_ProductCategoryLanguage_LstAll";
        public const string PROC_GET_PRODUCTCATEGORYLANGUAGE = "sproc_ProductCategoryLanguage_Sel";

        //PARAMETERS
        public const string PARA_CATEGORYID = "@CategoryId";
        public const string PARA_LANGUAGEID = "@LanguageId";
        public const string PARA_CATEGORYNAME = "@CategoryName";
        public const string PARA_DESCRIPTION = "@Description";

        //FIELDS
        public const string COL_CATEGORYID = "CategoryId";
        public const string COL_LANGUAGEID = "LanguageId";
        public const string COL_CATEGORYNAME = "CategoryName";
        public const string COL_DESCRIPTION = "Description";
    }
    #endregion

    #region ProductLocation
    public class ProductLocation
    {
        //PROCEDURES
        public const string PROC_DELETE_PRODUCTLOCATION = "sproc_ProductLocation_del";
        public const string PROC_UPDATE_PRODUCTLOCATION = "sproc_ProductLocation_ups";
        public const string PROC_GET_ALL_PRODUCTLOCATION = "sproc_ProductLocation_LstAll";
        public const string PROC_GET_PRODUCTLOCATION = "sproc_ProductLocation_Sel";
        public const string PROC_GET_PRODUCTLOCATION_ISNAMEAVAILABLE = "sproc_ProductLocation_IsnameAvailable";
        public const string PROC_GET_PRODUCTLOCATION_LANGUAGES = "sproc_ProductLocationLanguage_sel_List";

        public const string PROC_UPDATE_PRODUCTLOCATION_STATUS = "sproc_ProductLocation_ups_Status";

        //PARAMETERS
        public const string PARA_LOCATIONID = "@LocationID";
        public const string PARA_ISACTIVE = "@IsActive";
        public const string PARA_LOCATIONNAME = "@LocationName";
        public const string PARA_DESCRIPTION = "@Description";

        //FIELDS
        public const string COL_LOCATIONID = "LocationID";
        public const string COL_ISACTIVE = "IsActive";
        public const string COL_LOCATIONNAME = "LocationName";
        public const string COL_DESCRIPTION = "Description";
    }
    #endregion

    #region ProductLocationLanguage
    public class ProductLocationLanguage
    {
        //PROCEDURES
        public const string PROC_DELETE_PRODUCTLOCATIONLANGUAGE = "sproc_ProductLocationLanguage_del";
        public const string PROC_UPDATE_PRODUCTLOCATIONLANGUAGE = "sproc_ProductLocationLanguage_ups";
        public const string PROC_GET_ALL_PRODUCTLOCATIONLANGUAGE = "sproc_ProductLocationLanguage_LstAll";
        public const string PROC_GET_PRODUCTLOCATIONLANGUAGE = "sproc_ProductLocationLanguage_Sel";

        //PARAMETERS
        public const string PARA_LOCATIONID = "@LocationId";
        public const string PARA_LANGUAGEID = "@LanguageId";
        public const string PARA_LOCATIONNAME = "@LocationName";
        public const string PARA_DESCRIPTION = "@Description";

        //FIELDS
        public const string COL_LOCATIONID = "LocationId";
        public const string COL_LANGUAGEID = "LanguageId";
        public const string COL_LOCATIONNAME = "LocationName";
        public const string COL_DESCRIPTION = "Description";
    }
    #endregion

    #region SubCategory
    public class SubCategory
    {
        //PROCEDURES
        public const string PROC_DELETE_PRODUCT_SUBCATEGORY = "sproc_ProductSubCategory_del";
        public const string PROC_UPDATE_PRODUCT_SUBCATEGORY = "sproc_ProductSubCategory_ups";
        public const string PROC_GET_ALL_PRODUCT_SUBCATEGORY = "sproc_ProductSubCategory_LstAll";
        public const string PROC_GET_PRODUCT_SUBCATEGORY = "sproc_ProductSubCategory_Sel";
        public const string PROC_GET_PRODUCT_SUBCATEGORY_ISNAMEAVAILABLE = "sproc_ProductSubCategory_IsnameAvailable";
        public const string PROC_GET_PRODUCT_SUBCATEGORY_LANGUAGES = "sproc_ProductSubCategoryLanguage_sel_List";

        public const string PROC_UPDATE_PRODUCT_SUBCATEGORY_STATUS = "sproc_ProductSubCategory_ups_Status";

        //PARAMETERS
        public const string PARA_CATEGORYID = "@CategoryID";
        public const string PARA_SUBCATEGORYID = "@SubCategoryID";
        public const string PARA_ISACTIVE = "@IsActive";
        public const string PARA_SUBCATEGORYNAME = "@SubCategoryName";
        public const string PARA_DESCRIPTION = "@Description";


        //FIELDS
        public const string COL_CATEGORYID = "CategoryID";
        public const string COL_SUBCATEGORYID = "SubCategoryID";
        public const string COL_ISACTIVE = "IsActive";
        public const string COL_SUBCATEGORYNAME = "SubCategoryName";
        public const string COL_DESCRIPTION = "Description";
    }
    #endregion

    #region SubCategoryLanguage
    public class SubCategoryLanguage
    {
        //PROCEDURES
        public const string PROC_DELETE_PRODUCT_SUBCATEGORY_LANGUAGE = "sproc_ProductSubCategoryLanguage_del";
        public const string PROC_UPDATE_PRODUCT_SUBCATEGORY_LANGUAGE = "sproc_ProductSubCategoryLanguage_ups";
        public const string PROC_GET_ALL_PRODUCT_SUBCATEGORY_LANGUAGE = "sproc_ProductSubCategoryLanguage_LstAll";
        public const string PROC_GET_PRODUCT_SUBCATEGORY_LANGUAGE = "sproc_ProductSubCategoryLanguage_Sel";

        //PARAMETERS
        public const string PARA_SUBCATEGORYID = "@SubCategoryId";
        public const string PARA_LANGUAGEID = "@LanguageId";
        public const string PARA_SUBCATEGORYNAME = "@SubCategoryName";
        public const string PARA_DESCRIPTION = "@Description";

        //FIELDS
        public const string COL_SUBCATEGORYID = "SubCategoryId";
        public const string COL_LANGUAGEID = "LanguageId";
        public const string COL_SUBCATEGORYNAME = "SubCategoryName";
        public const string COL_DESCRIPTION = "Description";
    }
    #endregion

    #region Products
    public class Products
    {
        //PROCEDURES
        public const string PROC_DELETE_PRODUCTS = "sproc_Products_del";
        public const string PROC_UPDATE_PRODUCTS = "sproc_Products_ups";
        public const string PROC_GET_ALL_PRODUCTS = "sproc_Products_LstAll";
        public const string PROC_GET_ALL_PRODUCTS_CATALOG = "sproc_Products_LstAll_Catalog";
        public const string PROC_GET_PRODUCTS = "sproc_Products_Sel";
        public const string PROC_ACTIVE_PRODUCTS = "sproc_Products_ups_IsActive";
        public const string PROC_GET_PRODUCT_BY_PRODUCTCODE = "sproc_Products_sel_By_ProductCode";
        public const string PROC_PUBLISH_PRODUCTS = "sproc_Products_ups_Publish";

        public const string PROC_GET_IMPORT_LANGUAGE = "sproc_LanguageMaster_LstProductImport";
        public const string PROC_GET_EXPORT_LANGUAGE = "sproc_LanguageMaster_LstProductExport";
        public const string PROC_GET_PRODUCTS_LANGUAGES = "sproc_ProductsLanguage_sel_List";
        public const string PROC_GET_PRODUCTS_CATALOG = "sproc_Products_Sel_Catalog";


        //PARAMETERS
        public const string PARA_PRODUCTID = "@ProductId";
        public const string PARA_LOCATIONID = "@LocationId";
        public const string PARA_PRODUCTCODE = "@ProductCode";
        public const string PARA_PRODUCTTITLE = "@ProductTitle";
        public const string PARA_PRODUCTDESCRIPTION = "@ProductDescription";
        public const string PARA_CATEGORYID = "@CategoryId";
        public const string PARA_PRODUCTTYPE = "@ProductType";
        public const string PARA_THUMBNAILIMAGE = "@ThumbnailImage";
        public const string PARA_ACTIVITYID = "@ActivityId";
        public const string PARA_ACTIVITYTYPEID = "@ActivityTypeId";
        public const string PARA_ISACTIVE = "@IsActive";
        public const string PARA_ISPUBLISHED = "@IsPublished";
        public const string PARA_PUBLISHDATE = "@PublishDate";
        public const string PARA_BASEPRICE = "@BasePrice";

        public const string PARA_SUBCATEGORYID = "@SubCategoryId";
        public const string PARA_ENROLLKEY = "@EnrollKey";
        public const string PARA_PRODUCTREGTYPE = "@ProductRegType";
        public const string PARA_ADMINEMAIL = "@AdminEmail";
        public const string PARA_SYSTEMUSERGUID = "@SystemUserGUID";

        //FIELDS
        public const string COL_PRODUCTID = "ProductId";
        public const string COL_PRODUCTCODE = "ProductCode";
        public const string COL_PRODUCTTITLE = "ProductTitle";
        public const string COL_PRODUCTDESCRIPTION = "ProductDescription";
        public const string COL_CATEGORYID = "CategoryId";
        public const string COL_PRODUCTTYPE = "ProductType";
        public const string COL_THUMBNAILIMAGE = "ThumbnailImage";
        public const string COL_ACTIVITYID = "ActivityId";
        public const string COL_ACTIVITYNAME = "ActivityName";
        public const string COL_ACTIVITYTYPEID = "ActivityTypeId";
        public const string COL_ISACTIVE = "IsActive";
        public const string COL_ISPUBLISHED = "IsPublished";
        public const string COL_PUBLISHDATE = "PublishDate";
        public const string COL_BASEPRICE = "BasePrice";

        public const string COL_SUBCATEGORYID = "SubCategoryId";
        public const string COL_ENROLLKEY = "EnrollKey";
        public const string COL_PRODUCTREGTYPE = "ProductRegType";
        public const string COL_ADMINEMAIL = "AdminEmail";
        public const string COL_ISASSIGNEDACTIVITY = "IsAssignedActivity";
        public const string COL_SUBMISSIONSTATUS = "SubmissionStatus";
        public const string COL_ISREQSENT = "IsReqSent";
    }
    #endregion

    #region ProductsLanguage
    public class ProductsLanguage
    {
        //PROCEDURES
        public const string PROC_UPDATE_PRODUCTS_LANGUAGE = "sproc_ProductsLanguage_ups";

        //PARAMETERS
        public const string PARA_PRODUCTID = "@ProductId";
        public const string PARA_PRODUCTTITLE = "@ProductTitle";
        public const string PARA_PRODUCTDESCRIPTION = "@ProductDescription";

        //FIELDS
        public const string COL_PRODUCTID = "ProductId";
        public const string COL_PRODUCTCODE = "ProductCode";
        public const string COL_PRODUCTTITLE = "ProductTitle";
        public const string COL_PRODUCTDESCRIPTION = "ProductDescription";
        public const string COL_LANGUAGEID = "LanguageId";
    }
    #endregion

    #region ProductLocationMapping
    public class ProductLocationMapping
    {
        //PROCEDURES
        public const string PROC_PRODUCTLOCATIONMAPPING_UPDATE = "sproc_ProductLocationMapping_ups";
        public const string PROC_GET_ALL_PRODUCTLOCATIONMAPPING = "sproc_ProductLocationMapping_LstAll";

        //PARAMETERS
        public const string PARA_PRODUCTID = "@ProductId";
        public const string PARA_LOCATIONID = "@LocationId";
        public const string PARA_LOCATIONNAME = "@LocationName";
        public const string PARA_PRICE = "@Price";
        public const string PARA_BASEPRICE = "@BasePrice";

        //FIELDS
        public const string COL_PRODUCTID = "ProductId";
        public const string COL_LOCATIONID = "LocationId";
        public const string COL_LOCATIONNAME = "LocationName";
        public const string COL_PRICE = "Price";
        public const string COL_BASEPRICE = "BasePrice";

    }
    #endregion

    #region ProductVoucherMapping
    public class ProductVoucherMapping
    {
        //PROCEDURES
        public const string PROC_PRODUCTVOUCHERMAPPING_UPDATE = "sproc_ProductCouponMapping_ups";
        public const string PROC_GET_ALL_PRODUCTVOUCHERMAPPING = "sproc_ProductCouponMapping_LstAll";

        //PARAMETERS
        public const string PARA_PRODUCTID = "@ProductId";
        public const string PARA_COUPONID = "@CouponId";
        public const string PARA_COUPONCODE = "@CouponCode";
        public const string PARA_COUPONTITLE = "@Tilte";
        public const string PARA_EXPIRYDATE = "@ExpiryDate";
        public const string PARA_PURCHASEDATE = "@PurchaseDate";

        //FIELDS
        public const string COL_PRODUCTID = "ProductId";
        public const string COL_COUPONID = "CouponID";
        public const string COL_COUPONCODE = "CouponCode";
        public const string COL_COUPONTITLE = "Title";
        public const string COL_EXPIRYDATE = "ExpiryDate";
        public const string COL_PURCHASEDATE = "PurchaseDate";

    }
    #endregion

    #region Calendar
    public class Calendar
    {
        public const string PROC_GET_CALENDAR_EVENTS = "sproc_Calendar_Events";

        //PARAMETERS
        public const string PARA_START_DATE = "@startDate";
        public const string PARA_END_DATE = "@endDate";
        public const string PARA_Activity_ID = "@activityID";
        public const string PARA_USER_SYSTEMUSERGUID = "@systemUserGUID";
        public const string PARA_DATETYPE = "DATETYPE";
        //FIELDS
        public const string COL_EVENT_ID = "eventid";
        public const string COL_EVENT_DESCRIPTION = "description";
        public const string COL_EVENT_TITLE = "title";
        public const string COL_EVENT_START = "event_start";
        public const string COL_EVENT_END = "event_end";
        public const string COL_Activity_ID = "Activity_ID";
        public const string COL_Event_Type = "event_type";
        public const string COL_Status = "CompletionStatus";
        public const string COL_URL = "URL";
        public const string COL_ACTIVITYTYPEID = "ActivityTypeId";
        public const string COL_CompletionStatus = "CompletionStatus";

    }
    #endregion



    #region ContentModuleLanguageTranslate
    public class ContentModuleLanguageTranslate
    {
        //PROCEDURES

        public const string PROC_UPDATE_CONTENT_MODULE_TRANSLATE = "sproc_ContentModuleLanguageTranslate_ups";
        public const string PROC_UPDATE_CONTENT_MODULE_TRANSLATE_APPROVE = "sproc_ContentModuleLanguageTranslate_ups_Approve";
        public const string PROC_GET_ALL_CONTENT_MODULE_TRANSLATE = "sproc_ContentModuleLanguageTranslate_LstAll";
        public const string PROC_GET_ALL_CONTENT_MODULE_TRANSLATE_UNAPPROVED = "sproc_ContentModuleLanguageTranslate_UnAppprove_LstAll";

        //PARAMETERS

        public const string PARA_CONTENT_MODULE_TRANS_ID = "@ContentModuleId";
        public const string PARA_CONTENT_MODULE_TRANS_NAME = "@ContentModuleName";
        public const string PARA_CONTENT_MODULE_TRANS_LANGUAGE_ID = "@LanguageId";
        public const string PARA_CONTENT_MODULE_TRANS_EXCEL_FILE_PATH = "@ExcelFilePath";
        public const string PARA_CONTENT_MODULE_TRANS_RECORDING_FILE_PATH = "@RecordingFilePath";
        public const string PARA_CONTENT_MODULE_TRANS_EXT_LINK_PATH = "@ExternalLink";
        public const string PARA_CONTENT_MODULE_TRANS_CREATEDBY_ID = "@CreatedById";
        public const string PARA_CONTENT_MODULE_TRANS_MODIFIEDBY_ID = "@LastModifiedById";


        //FIELDS
        public const string COL_CONTENT_MODULE_TRANS_ID = "ContentModuleId";
        public const string COL_CONTENT_MODULE_TRANS_NAME = "ContentModuleName";
        public const string COL_CONTENT_MODULE_TRANS_LANGUAGE_ID = "LanguageId";
        public const string COL_CONTENT_MODULE_TRANS_EXCEL_FILE_PATH = "ExcelFilePath";
        public const string COL_CONTENT_MODULE_TRANS_RECORDING_FILE_PATH = "RecordingFilePath";
        public const string COL_CONTENT_MODULE_TRANS_EXT_LINK_PATH = "ExternalLink";
        public const string COL_CONTENT_MODULE_TRANS_CREATEDBY_ID = "CreatedById";
        public const string COL_CONTENT_MODULE_TRANS_MODIFIEDBY_ID = "LastModifiedById";
        public const string COL_CONTENT_MODULE_TRANS_DATE_CREATED = "DateCreated";
        public const string COL_CONTENT_MODULE_TRANS_LAST_MODIFIED_DATE = "LastModifiedDate";
        public const string COL_CONTENT_MODULE_TRANS_CONTENT_FOLDER_URL = "ContentFolderURL";
        public const string COL_CONTENT_MODULE_TRANS_DraftEXCEL_FILE_PATH = "DraftExcelFilePath";
        public const string COL_CONTENT_MODULE_TRANS_DraftRECORDING_FILE_PATH = "DraftRecordingFilePath";
        public const string COL_CONTENT_MODULE_TRANS_DraftEXT_LINK_PATH = "DraftExternalLink";


    }
    #endregion

    #region BlogPost
    public class BlogPost
    {
        //PROCEDURES
        public const string PROC_DELETE_BLOGPOST = "sproc_BlogPost_del";
        public const string PROC_UPDATE_BLOGPOST = "sproc_BlogPost_ups";
        public const string PROC_GET_ALL_BLOGPOST = "sproc_BlogPost_LstAll";
        public const string PROC_GET_ALL_BLOGPOST_LEARNER = "sproc_BlogPost_LstAll_Learner";
        public const string PROC_GET_BLOGPOST = "sproc_BlogPost_Sel";

        //PARAMETERS
        public const string PARA_POSTID = "@PostID";
        public const string PARA_LANGUAGEID = "@LanguageID";
        public const string PARA_CATEGORYID = "@CategoryID";
        public const string PARA_TITLE = "@Title";
        public const string PARA_TAGS = "@Tags";
        public const string PARA_POSTCONTENT = "@PostContent";
        public const string PARA_ISPUBLISHED = "@IsPublished";
        public const string PARA_ISCOMMENTENABLED = "@IsCommentEnabled";
        public const string PARA_ISCOMMENTMODERATOR = "@IsCommentModerator";
        public const string PARA_ISFORALLLANGUAGE = "@IsForAllLanguage";
        public const string PARA_SYSTEMUSERGUID = "@SystemUserGUID";

        //FIELDS
        public const string COL_POSTID = "PostID";
        public const string COL_LANGUAGEID = "LanguageID";
        public const string COL_CATEGORYID = "CategoryID";
        public const string COL_TITLE = "Title";
        public const string COL_TAGS = "Tags";
        public const string COL_POSTCONTENT = "PostContent";
        public const string COL_ISPUBLISHED = "IsPublished";
        public const string COL_ISCOMMENTENABLED = "IsCommentEnabled";
        public const string COL_ISCOMMENTMODERATOR = "IsCommentModerator";
        public const string COL_ISFORALLLANGUAGE = "IsForAllLanguage";
        public const string COL_CATEGORYNAME = "CategoryName";
        public const string COL_COMMENT_COUNT = "CommentCount";
        public const string COL_SHORT_CONTENT = "ShortContent";
        public const string COL_CREATED_BY = "CreatedBy";
        public const string COL_RATING = "Rating";
        public const string COL_BOOKMARKID = "BookmarkId";
    }
    #endregion

    #region BlogPostComments
    public class BlogPostComments
    {
        //PROCEDURES
        public const string PROC_DELETE_BLOGPOSTCOMMENTS = "sproc_BlogPostComments_del";
        public const string PROC_UPDATE_BLOGPOSTCOMMENTS = "sproc_BlogPostComments_ups";
        public const string PROC_GET_ALL_BLOGPOSTCOMMENTS = "sproc_BlogPostComments_LstAll";
        public const string PROC_GET_ALL_BLOGPOSTCOMMENTS_LEARNER = "sproc_BlogPostComments_LstAll_Learner";
        public const string PROC_GET_BLOGPOSTCOMMENTS = "sproc_BlogPostComments_Sel";

        //PARAMETERS
        public const string PARA_POSTCOMMENTID = "@PostCommentID";
        public const string PARA_LANGUAGEID = "@LanguageID";
        public const string PARA_POSTID = "@PostID";
        public const string PARA_COMMENTDATE = "@CommentDate";
        public const string PARA_COMMENTBYUSERID = "@CommentByUserId";
        public const string PARA_COMMENT = "@Comment";
        public const string PARA_ISAPPROVED = "@IsApproved";
        public const string PARA_RATING = "@Rating";
        public const string PARA_TITLE = "@Title";

        //FIELDS
        public const string COL_POSTCOMMENTID = "PostCommentID";
        public const string COL_LANGUAGEID = "LanguageID";
        public const string COL_POSTID = "PostID";
        public const string COL_COMMENTDATE = "CommentDate";
        public const string COL_COMMENTBYUSERID = "CommentByUserId";
        public const string COL_COMMENT = "Comment";
        public const string COL_ISAPPROVED = "IsApproved";
        public const string COL_RATING = "Rating";

        public const string COL_LANGUAGE_NAME = "LanguageName";
        public const string COL_SHORT_TITLE = "ShortTitle";
        public const string COL_TITLE = "Title";
        public const string COL_SHORT_COMMENTS = "ShortComments";
        public const string COL_COMMENTBY = "CommentBy";
        public const string COL_APPROVEDBY = "ApprovedBy";
    }
    #endregion

    #region BlogCategories
    public class BlogCategories
    {
        //PROCEDURES
        public const string PROC_DELETE_BLOGCATEGORIES = "sproc_BlogCategories_del";
        public const string PROC_UPDATE_BLOGCATEGORIES = "sproc_BlogCategories_ups";
        public const string PROC_GET_ALL_BLOGCATEGORIES = "sproc_BlogCategories_LstAll";
        public const string PROC_GET_BLOGCATEGORIES = "sproc_BlogCategories_Sel";
        public const string PROC_GET_BLOGCATEGORY_ISNAMEAVAILABLE = "sproc_BlogCategory_IsNameAvailable";

        //PARAMETERS
        public const string PARA_CATEGORYID = "@CategoryID";
        //public const string PARA_LANGUAGEID = "@LanguageID";
        public const string PARA_CATEGORYNAME = "@CategoryName";
        public const string PARA_DESCRIPTION = "@Description";
        public const string PARA_PARENTID = "@ParentID";

        //FIELDS
        public const string COL_CATEGORYID = "CategoryID";
        //public const string COL_LANGUAGEID = "LanguageID";
        public const string COL_CATEGORYNAME = "CategoryName";
        public const string COL_DESCRIPTION = "Description";
        public const string COL_PARENTID = "ParentID";
    }
    #endregion

    #region BlogCategoriesLanguage
    public class BlogCategoriesLanguage
    {
        //PROCEDURES
        public const string PROC_DELETE_BLOGCATEGORIES = "sproc_BlogCategoriesLanguage_del";
        public const string PROC_UPDATE_BLOGCATEGORIES = "sproc_BlogCategoriesLanguage_ups";
        public const string PROC_GET_ALL_BLOGCATEGORIES = "sproc_BlogCategoriesLanguage_LstAll";
        public const string PROC_GET_BLOGCATEGORIES = "sproc_BlogCategoriesLanguage_Sel";

        //PARAMETERS
        public const string PARA_CATEGORYID = "@CategoryID";
        public const string PARA_LANGUAGEID = "@LanguageID";
        public const string PARA_CATEGORYNAME = "@CategoryName";
        public const string PARA_DESCRIPTION = "@Description";


        //FIELDS
        public const string COL_CATEGORYID = "CategoryID";
        public const string COL_LANGUAGEID = "LanguageID";
        public const string COL_CATEGORYNAME = "CategoryName";
        public const string COL_DESCRIPTION = "Description";
        public const string COL_LANGUAGENAME = "LanguageName";

    }
    #endregion

    #region BrandImages
    public class BrandImages
    {
        public const string PROC_BRAND_IMAGES_INSERT = "Sproc_ClientBrandImage_ups";
        public const string PROC_BRAND_IMAGES_GET = "sproc_clientBrandImages_Lst";
        public const string PROC_BRAND_IMAGES_DEL = "Sproc_ClientBrandImage_Del";
        //PARAMETERS
        public const string PARA_IMAGE_ID = "@BrandImageID";
        public const string PARA_CLIENT_ID = "@ClientID ";
        public const string PARA_IMAGE_POSITION = "@ImagePosition";
        public const string PARA_IMAGE_NAME = "@ImageName";
        public const string PARA_IS_DISPLAY = "@IsDisplay";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_CREATED_BY_ID = "@CreatedById";
        //FIELDS
        public const string COL_IMAGE_ID = "BrandImageID";
        public const string COL_CLIENT_ID = "ClientID ";
        public const string COL_IMAGE_POSITION = "ImagePosition";
        public const string COL_IMAGE_NAME = "ImageName";
        public const string COL_IS_DISPLAY = "IsDisplay";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_CREATED_BY_ID = "CreatedById";
    }
    #endregion

    #region LearnerComponentsSettings
    public class LearnerComponentsSettings
    {
        //PROCEDURES
        public const string PROC_GET_ALL_LEARNERCOMPONENTS = "sproc_LearnerComponents_LstAll";
        public const string PROC_GET_ALL_LEARNERCOMPONENTS_LEARNER = "sproc_LearnerComponents_LstAll_Learner";
        public const string PROC_UPDATE_LEARNERCOMPONENTS = "sproc_LearnerComponents_ups";

        //PARAMETERS
        public const string PARA_COMPONENTID = "@ComponentID";
        public const string PARA_COMPONENTNAME = "@ComponentName";
        public const string PARA_ISVISIBLE = "@IsVisible";
        public const string PARA_FEATUREID = "@FeatureId";
        public const string PARA_TOTALCOUNT = "@TotalCount";

        //FIELDS
        public const string COL_COMPONENTID = "ComponentID";
        public const string COL_COMPONENTNAME = "ComponentName";
        public const string COL_ISVISIBLE = "IsVisible";
        public const string COL_FEATUREID = "FeatureId";
        public const string COL_TOTALCOUNT = "TotalCount";
        public const string COL_ISACTIVE = "IsActive";
    }
    #endregion



    #region ForumCategory
    public class ForumCategory
    {
        //PROCEDURES
        public const string PROC_DELETE_FORUMCATEGORY = "sproc_ForumCategory_del";
        public const string PROC_UPDATE_FORUMCATEGORY = "sproc_ForumCategory_ups";
        public const string PROC_GET_ALL_FORUMCATEGORY = "sproc_ForumCategory_LstAll";
        public const string PROC_GET_FORUMCATEGORY = "sproc_ForumCategory_Sel";
        public const string PROC_GET_FORUMCATEGORY_ISNAMEAVAILABLE = "sproc_ForumCategory_IsNameAvailable";

        //PARAMETERS
        public const string PARA_CATEGORYID = "@CategoryID";
        public const string PARA_LANGUAGEID = "@LanguageID";
        public const string PARA_CATEGORYNAME = "@CategoryName";
        public const string PARA_DESCRIPTION = "@Description";

        //FIELDS
        public const string COL_CATEGORYID = "CategoryID";
        public const string COL_LANGUAGEID = "LanguageID";
        public const string COL_CATEGORYNAME = "CategoryName";
        public const string COL_DESCRIPTION = "Description";
    }
    #endregion

    #region ForumCategoryLanguage
    public class ForumCategoryLanguage
    {
        //PROCEDURES
        public const string PROC_DELETE_FORUMCATEGORYLANGUAGE = "sproc_ForumCategoryLanguage_del";
        public const string PROC_UPDATE_FORUMCATEGORYLANGUAGE = "sproc_ForumCategoryLanguage_ups";
        public const string PROC_GET_ALL_FORUMCATEGORYLANGUAGE = "sproc_ForumCategoryLanguage_LstAll";
        public const string PROC_GET_FORUMCATEGORYLANGUAGE = "sproc_ForumCategoryLanguage_Sel";

        //PARAMETERS
        public const string PARA_CATEGORYID = "@CategoryID";
        public const string PARA_LANGUAGEID = "@LanguageID";
        public const string PARA_CATEGORYNAME = "@CategoryName";
        public const string PARA_DESCRIPTION = "@Description";

        //FIELDS
        public const string COL_CATEGORYID = "CategoryID";
        public const string COL_LANGUAGEID = "LanguageID";
        public const string COL_CATEGORYNAME = "CategoryName";
        public const string COL_DESCRIPTION = "Description";
        public const string COL_LANGUAGENAME = "LanguageName";
    }
    #endregion


    #region ForumSubCategory
    public class ForumSubCategory
    {
        //PROCEDURES
        public const string PROC_DELETE_FORUMSUBCATEGORY = "sproc_ForumSubCategory_del";
        public const string PROC_UPDATE_FORUMSUBCATEGORY = "sproc_ForumSubCategory_ups";
        public const string PROC_GET_ALL_FORUMSUBCATEGORY = "sproc_ForumSubCategory_LstAll";
        public const string PROC_GET_FORUMSUBCATEGORY = "sproc_ForumSubCategory_Sel";
        public const string PROC_GET_FORUMSUBCATEGORY_ISNAMEAVAILABLE = "sproc_ForumSubCategory_IsNameAvailable";

        //PARAMETERS
        public const string PARA_SUBCATEGORYID = "@SubCategoryID";
        public const string PARA_CATEGORYID = "@CategoryID";
        public const string PARA_LANGUAGEID = "@LanguageID";
        public const string PARA_SUBCATEGORYNAME = "@SubCategoryName";
        public const string PARA_DESCRIPTION = "@Description";
        public const string PARA_ISMODERATIONREQUIRED = "@IsModerationRequired";

        //FIELDS
        public const string COL_SUBCATEGORYID = "SubCategoryID";
        public const string COL_CATEGORYID = "CategoryID";
        public const string COL_LANGUAGEID = "LanguageID";
        public const string COL_SUBCATEGORYNAME = "SubCategoryName";
        public const string COL_DESCRIPTION = "Description";
        public const string COL_ISMODERATIONREQUIRED = "IsModerationRequired";

        public const string COL_THREADID = "ThreadID";
        public const string COL_THREAD_DATE = "ThreadDate";
        public const string COL_THREAD_TITLE = "ThreadTitle";
        public const string COL_THREAD_CREATED_BY = "ThreadCreatedBy";
    }
    #endregion

    #region ForumSubCategoryLanguage
    public class ForumSubCategoryLanguage
    {
        //PROCEDURES
        public const string PROC_DELETE_FORUMSUBCATEGORYLANGUAGE = "sproc_ForumSubCategoryLanguagedel";
        public const string PROC_UPDATE_FORUMSUBCATEGORYLANGUAGE = "sproc_ForumSubCategoryLanguage_ups";
        public const string PROC_GET_ALL_FORUMSUBCATEGORYLANGUAGE = "sproc_ForumSubCategoryLanguage_LstAll";
        public const string PROC_GET_FORUMSUBCATEGORYLANGUAGE = "sproc_ForumSubCategoryLanguage_Sel";

        //PARAMETERS
        public const string PARA_SUBCATEGORYID = "@SubCategoryID";
        public const string PARA_CATEGORYID = "@CategoryID";
        public const string PARA_LANGUAGEID = "@LanguageID";
        public const string PARA_SUBCATEGORYNAME = "@SubCategoryName";
        public const string PARA_DESCRIPTION = "@Description";

        //FIELDS
        public const string COL_SUBCATEGORYID = "SubCategoryID";
        public const string COL_CATEGORYID = "CategoryID";
        public const string COL_LANGUAGEID = "LanguageID";
        public const string COL_SUBCATEGORYNAME = "SubCategoryName";
        public const string COL_DESCRIPTION = "Description";
        public const string COL_LANGUAGENAME = "LanguageName";

        public const string COL_THREADID = "ThreadID";
        public const string COL_THREAD_DATE = "ThreadDate";
        public const string COL_THREAD_TITLE = "ThreadTitle";
        public const string COL_THREAD_CREATED_BY = "ThreadCreatedBy";
    }
    #endregion

    #region ForumThread
    public class ForumThread
    {
        //PROCEDURES
        public const string PROC_DELETE_FORUMTHREAD = "sproc_ForumThread_del";
        public const string PROC_UPDATE_FORUMTHREAD = "sproc_ForumThread_ups";
        public const string PROC_GET_ALL_FORUMTHREAD = "sproc_ForumThread_LstAll";
        public const string PROC_GET_ALL_FORUMTHREAD_LEARNER = "sproc_ForumThread_LstAll_Learner";
        public const string PROC_GET_ALL_FORUMTHREAD_SUBCAT = "sproc_ForumThread_LstAll_BySubCategory";
        public const string PROC_GET_FORUMTHREAD = "sproc_ForumThread_Sel";
        public const string PROC_UPDATE_FORUMTHREADVIEWCOUNT = "sproc_ForumThread_ViewCount_Update";
        //PARAMETERS
        public const string PARA_THREADID = "@ThreadID";
        public const string PARA_SUBCATEGORYID = "@SubCategoryID";
        public const string PARA_LANGUAGEID = "@LanguageID";
        public const string PARA_TITLE = "@Title";
        public const string PARA_DESCRIPTION = "@Description";
        public const string PARA_VIEWCOUNT = "@ViewCount";
        public const string PARA_ISCLOSED = "@IsClosed";
        public const string PARA_ISREPLYMODERATION = "@IsReplyModeration";
        public const string PARA_STATUS = "@Status";
        public const string PARA_MODERATEDBYID = "@ModeratedById";
        public const string PARA_MODERATEDDATE = "@ModeratedDate";
        public const string PARA_SYSTEMUSERGUID = "@SystemUserGUID";

        //FIELDS
        public const string COL_THREADID = "ThreadID";
        public const string COL_SUBCATEGORYID = "SubCategoryID";
        public const string COL_SUBCATEGORYDESCRIPTION = "SubCategoryDescription";
        public const string COL_LANGUAGEID = "LanguageID";
        public const string COL_TITLE = "Title";
        public const string COL_DESCRIPTION = "Description";
        public const string COL_VIEWCOUNT = "ViewCount";
        public const string COL_ISCLOSED = "IsClosed";
        public const string COL_ISREPLYMODERATION = "IsReplyModeration";
        public const string COL_STATUS = "Status";
        public const string COL_MODERATEDBYID = "ModeratedById";
        public const string COL_MODERATEDDATE = "ModeratedDate";

        public const string COL_POST_COUNT = "PostCount";
        public const string COL_LAST_POST_BY_USER = "LastPostBy";
        public const string COL_LAST_POSTDATE = "LastPostDate";
        public const string COL_BOOKMARKID = "BookmarkId";
    }
    #endregion

    #region ForumPost
    public class ForumPost
    {
        //PROCEDURES
        public const string PROC_DELETE_FORUMPOST = "sproc_ForumPost_del";
        public const string PROC_UPDATE_FORUMPOST = "sproc_ForumPost_ups";
        public const string PROC_GET_ALL_FORUMPOST = "sproc_ForumPost_LstAll";
        public const string PROC_GET_FORUMPOST = "sproc_ForumPost_Sel";

        //PARAMETERS
        public const string PARA_POSTID = "@PostID";
        public const string PARA_THREADID = "@ThreadID";
        public const string PARA_LANGUAGEID = "@LanguageID";
        public const string PARA_POSTCONTENT = "@PostContent";
        public const string PARA_ISMARKASANSWER = "@IsMarkAsAnswer";
        public const string PARA_STATUS = "@Status";
        public const string PARA_MODERATEDBYID = "@ModeratedById";
        public const string PARA_MODERATEDDATE = "@ModeratedDate";

        //FIELDS
        public const string COL_POSTID = "PostID";
        public const string COL_THREADID = "ThreadID";
        public const string COL_LANGUAGEID = "LanguageID";
        public const string COL_POSTCONTENT = "PostContent";
        public const string COL_ISMARKASANSWER = "IsMarkAsAnswer";
        public const string COL_STATUS = "Status";
        public const string COL_MODERATEDBYID = "ModeratedById";
        public const string COL_MODERATEDDATE = "ModeratedDate";

        //newly added for view

        public const string COL_SUB_CATEGORY_ID = "SubCategoryId";
        public const string COL_CATEGORY_ID = "CategoryID";
        public const string COL_CREATED_BY = "CreatedBy";
        public const string COL_THREAD_TITLE = "ThreadTitle";
        public const string COL_POST_COUNT_BY_USER = "PostCountByUser";

    }
    #endregion

    #region UserPhoto
    public class UserPhoto
    {
        //PROCEDURES
        public const string PROC_GET_USER_PHOTO = "sproc_UserPhotoMaster_sel";
        public const string PROC_UPDATE_USER_PHOTO = "sproc_UserPhotoMaster_ups";

        //PARAMETERS
        public const string PARA_SYSTEMUSERGUID = "@SystemUserGUID";
        public const string PARA_IMAGENAME = "@ImageName";

        //FIELDS
        public const string COL_SYSTEMUSERGUID = "SystemUserGUID";
        public const string COL_IMAGENAME = "ImageName";

    }
    #endregion

    #region SignUp
    public class SignUp
    {
        //PROCEDURES
        public const string PROC_DELETE_SIGNUP = "sproc_SignUp_del";
        public const string PROC_UPDATE_SIGNUP = "sproc_SignUp_ups";
        public const string PROC_GET_ALL_SIGNUP = "sproc_SignUp_LstAll";
        public const string PROC_GET_SIGNUP = "sproc_SignUp_Sel";
        public const string PROC_GET_SIGNUP_USERNAMEALIAS = "sproc_SignUp_sel_UserNameAlias";
        public const string PROC_GET_SIGNUP_ISEMAIL = "sproc_SignUp_sel_IsEmail";
        public const string PROC_CUSTOM_FIELD_BULK_IMPORT = "sproc_SignUpCustomField_BulkImport";

        //PROCEDURES
        public const string PROC_UPDATE_CUSTOM_FIELD_VALUE = "sproc_SignUpCustomFieldValue_ups";
        public const string PROC_DELETE_NOT_IN_CFVALUES = "sproc_SignUpCustomFieldValue_delMultiple";

        public const string PROC_DELETE_USER_CF_VALUES = "sproc_SignUpCustomFieldValue_del_ByLearner";


        //PARAMETERS
        public const string PARA_SIGNUPID = "@SignUpID";
        public const string PARA_USERNAMEALIAS = "@UserNameAlias";
        public const string PARA_FIRSTNAME = "@FirstName";
        public const string PARA_MIDDLENAME = "@MiddleName";
        public const string PARA_LASTNAME = "@LastName";
        public const string PARA_ADDRESS = "@Address";
        public const string PARA_EMAILID = "@EmailID";
        public const string PARA_PHONENO = "@PhoneNo";
        public const string PARA_LOCATIONID = "@LocationID";
        public const string PARA_CURRENCYID = "@CurrencyID";
        public const string PARA_DATEOFBIRTH = "@DateOfBirth";
        public const string PARA_DATEOFREGISTRATION = "@DateOfRegistration";
        public const string PARA_DEFAULTLANGUAGEID = "@DefaultLanguageId";
        public const string PARA_CLIENTID = "@ClientId";

        //FIELDS
        public const string COL_SIGNUPID = "SignUpID";
        public const string COL_USERNAMEALIAS = "UserNameAlias";
        public const string COL_FIRSTNAME = "FirstName";
        public const string COL_MIDDLENAME = "MiddleName";
        public const string COL_LASTNAME = "LastName";
        public const string COL_ADDRESS = "Address";
        public const string COL_EMAILID = "EmailID";
        public const string COL_PHONENO = "PhoneNo";
        public const string COL_LOCATIONID = "LocationID";
        public const string COL_CURRENCYID = "CurrencyID";
        public const string COL_DATEOFBIRTH = "DateOfBirth";
        public const string COL_DATEOFREGISTRATION = "DateOfRegistration";
        public const string COL_DEFAULTLANGUAGEID = "DefaultLanguageId";

        public const string VAL_SIGNUP_ID_PREFIX = "SUP";
    }
    #endregion

    #region OrderHistory
    public class OrderHistory
    {
        //PROCEDURES
        public const string PROC_DELETE_ORDERHISTORY = "sproc_OrderHistory_del";
        public const string PROC_UPDATE_ORDERHISTORY = "sproc_OrderHistory_ups";
        public const string PROC_COMPLETE_ORDER = "sproc_CompleteOrder";
        public const string PROC_UPDATE_ORDERHISTORY_TRANSACTIONSTATUS = "sproc_OrderHistory_ups_TransactionStatus";
        public const string PROC_GET_ALL_ORDERHISTORY = "sproc_OrderHistory_LstAll";
        public const string PROC_GET_ORDERHISTORY = "sproc_OrderHistory_Sel";
        public const string PROC_GET_ORDERHISTORY_DEIAILS = "sproc_OrderHistory_Sel_Details";
        public const string PROC_GET_ORDERHISTORY_RECEIPT = "sproc_OrderHistory_Sel_Receipt";
        public const string PROC_GET_ORDERHISTORY_BYTRANSID = "sproc_OrderHistory_Sel_TransactionID";
        public const string PROC_IS_VOUCHER_AVAILABLE = "sproc_IsProductVoucherAvalable";
        public const string PROC_GET_ALL_ORDERHISTORY_DETAILS = "sproc_ManageOrders_LstAll";
        public const string PROC_GET_ALL_LICENSEDETAILS = "sproc_OrderHistory_LicenseDetails";
        public const string PROC_GET_ALL_ORDERHISTORY_RECEIPT = "sproc_OrderHistory_LstAll_OrderReceipt";

        //PARAMETERS
        public const string PARA_ORDERID = "@OrderID";
        public const string PARA_ORDERDATE = "@OrderDate";
        public const string PARA_TRANSACTIONID = "@TransactionID";
        public const string PARA_SYSTEMUSERGUID = "@SystemUserGUID";
        public const string PARA_SIGNUPID = "@SignUpID";
        public const string PARA_TRANSACTIONSTATUS = "@TransactionStatus";
        public const string PARA_PRODUCTID = "@ProductId";
        public const string PARA_LOCATIONID = "@LocationID";
        public const string PARA_COUPONCODE = "@CouponCode";
        public const string PARA_AMOUNT = "@Amount";
        public const string PARA_CURRENCY = "@Currency";
        public const string PARA_ORDERFEE = "@OrderFee";
        public const string PARA_ORDERDESCRIPTION = "@OrderDescription";
        public const string PARA_AMOUNTTOTAL = "@AmountTotal";
        //public const string PARA_LICENSETYPE = "@LicenseType";
        //public const string PARA_LICENSECOUNT = "@LicenseCount";
        public const string PARA_MERCHANTID = "@MerchantId";
        public const string PARA_CARDPAN = "@CardPAN";
        public const string PARA_CARDEXPIRYDATE = "@CardExpiryDate";
        public const string PARA_ISSUER = "@Issuer";
        public const string PARA_ISSUERCOUNTRY = "@IssuerCountry";
        public const string PARA_PAYMENTMETHOD = "@PaymentMethod";
        public const string PARA_CUSTOMERIPADDRESS = "@CustomerIPAddress";
        public const string PARA_ORDERTODATE = "@OrderToDate";
        public const string PARA_ORDERCOMPLETIONSTATUS = "@OrderCompletionStatus";
        public const string PARA_ISCOMPLETEBYMANUALLY = "@IsCompleteByManually";
        public const string PARA_COMPLETEDBYID = "@CompletedByID";
        public const string PARA_DISCOUNTTOTAL = "@DiscountTotal";

        //FIELDS
        public const string COL_ORDERID = "OrderID";
        public const string COL_ORDERDATE = "OrderDate";
        public const string COL_TRANSACTIONID = "TransactionID";
        public const string COL_SYSTEMUSERGUID = "SystemUserGUID";
        public const string COL_SIGNUPID = "SignUpID";
        public const string COL_TRANSACTIONSTATUS = "TransactionStatus";
        public const string COL_PRODUCTID = "ProductId";
        public const string COL_LOCATIONID = "LocationID";
        public const string COL_COUPONCODE = "CouponCode";
        public const string COL_AMOUNT = "Amount";
        public const string COL_CURRENCY = "Currency";
        public const string COL_ORDERFEE = "OrderFee";
        public const string COL_ORDERDESCRIPTION = "OrderDescription";
        public const string COL_AMOUNTTOTAL = "AmountTotal";
        //public const string COL_LICENSETYPE = "LicenseType";
        public const string COL_LICENSECOUNT = "LicenseCount";
        public const string COL_LICENSECONSUMED = "LicenseConsumed";
        public const string COL_MERCHANTID = "MerchantId";
        public const string COL_CARDPAN = "CardPAN";
        public const string COL_CARDEXPIRYDATE = "CardExpiryDate";
        public const string COL_ISSUER = "Issuer";
        public const string COL_ISSUERCOUNTRY = "IssuerCountry";
        public const string COL_PAYMENTMETHOD = "PaymentMethod";
        public const string COL_CUSTOMERIPADDRESS = "CustomerIPAddress";
        public const string COL_VOUCHERID = "VoucherID";
        public const string COL_PRODUCTCODE = "ProductCode";
        public const string COL_LOCATIONNAME = "LocationName";
        public const string COL_USERNAMEALIAS = "UserNameAlias";
        public const string COL_ORDERCOMPLETIONSTATUS = "IsOrderComplete";
        public const string COL_ISCOMPLETEBYMANUALLY = "IsCompleteByManually";
        public const string COL_COMPLETEDBYID = "CompletedByID";

        public const string COL_DISCOUNTTOTAL = "DiscountTotal";
        public const string COL_ISEXTERNALPRODUCT = "IsExternalProduct";

        public const string VAL_ORDER_ID_PREFIX = "POH";
    }
    #endregion
    #region TransactionErrorLog
    public class TransactionErrorLog
    {
        //PROCEDURES
        public const string PROC_DELETE_TRANSACTIONERRORLOG = "sproc_TransactionErrorLog_del";
        public const string PROC_UPDATE_TRANSACTIONERRORLOG = "sproc_TransactionErrorLog_ups";
        public const string PROC_GET_ALL_TRANSACTIONERRORLOG = "sproc_TransactionErrorLog_LstAll";
        public const string PROC_GET_TRANSACTIONERRORLOG = "sproc_TransactionErrorLog_Sel";

        //PARAMETERS
        public const string PARA_ORDERID = "@OrderID";
        public const string PARA_TRANSACTIONID = "@TransactionID";
        public const string PARA_ERRORDATE = "@ErrorDate";
        public const string PARA_OPERATION = "@Operation";
        public const string PARA_RESPONSECODE = "@ResponseCode";
        public const string PARA_RESPONSESOURCE = "@ResponseSource";
        public const string PARA_RESPONSETEXT = "@ResponseText";

        //FIELDS
        public const string COL_ORDERID = "OrderID";
        public const string COL_TRANSACTIONID = "TransactionID";
        public const string COL_ERRORDATE = "ErrorDate";
        public const string COL_OPERATION = "Operation";
        public const string COL_RESPONSECODE = "ResponseCode";
        public const string COL_RESPONSESOURCE = "ResponseSource";
        public const string COL_RESPONSETEXT = "ResponseText";

        public const string VAL_TRANSACTIONERRORLOG_ID_PREFIX = "TEL";
    }
    #endregion

    #region TransactionLog
    public class TransactionLog
    {
        //PROCEDURES
        public const string PROC_DELETE_TRANSACTIONLOG = "sproc_TransactionLog_del";
        public const string PROC_UPDATE_TRANSACTIONLOG = "sproc_TransactionLog_ups";
        public const string PROC_GET_ALL_TRANSACTIONLOG = "sproc_TransactionLog_LstAll";
        public const string PROC_GET_TRANSACTIONLOG = "sproc_TransactionLog_Sel";

        //PARAMETERS
        public const string PARA_ORDERID = "@OrderID";
        public const string PARA_TRANSACTIONID = "@TransactionID";
        public const string PARA_AMOUNT = "@Amount";
        public const string PARA_BATCHNUMBER = "@BatchNumber";
        public const string PARA_TRANSACTIONDATE = "@TransactionDate";
        public const string PARA_DESCRIPTION = "@Description";
        public const string PARA_OPERATION = "@Operation";
        public const string PARA_TRANSACTIONRECONREF = "@TransactionReconRef";

        //FIELDS
        public const string COL_ORDERID = "OrderID";
        public const string COL_TRANSACTIONID = "TransactionID";
        public const string COL_AMOUNT = "Amount";
        public const string COL_BATCHNUMBER = "BatchNumber";
        public const string COL_TRANSACTIONDATE = "TransactionDate";
        public const string COL_DESCRIPTION = "Description";
        public const string COL_OPERATION = "Operation";
        public const string COL_TRANSACTIONRECONREF = "TransactionReconRef";

        public const string VAL_TRANSACTIONLOG_ID_PREFIX = "TL";
    }
    #endregion

    #region TransactionSummary
    public class TransactionSummary
    {
        //PROCEDURES
        public const string PROC_DELETE_TRANSACTIONSUMMARY = "sproc_TransactionSummary_del";
        public const string PROC_UPDATE_TRANSACTIONSUMMARY = "sproc_TransactionSummary_ups";
        public const string PROC_GET_ALL_TRANSACTIONSUMMARY = "sproc_TransactionSummary_LstAll";
        public const string PROC_GET_TRANSACTIONSUMMARY = "sproc_TransactionSummary_Sel";

        //PARAMETERS
        public const string PARA_ORDERID = "@OrderID";
        public const string PARA_TRANSACTIONID = "@TransactionID";
        public const string PARA_AMOUNTCAPTURED = "@AmountCaptured";
        public const string PARA_AMOUNTCREDITED = "@AmountCredited";
        public const string PARA_ANNULLED = "@Annulled";
        public const string PARA_AUTHORIZATIONID = "@AuthorizationId";
        public const string PARA_AUTHORIZED = "@Authorized";

        //FIELDS
        public const string COL_ORDERID = "OrderID";
        public const string COL_TRANSACTIONID = "TransactionID";
        public const string COL_AMOUNTCAPTURED = "AmountCaptured";
        public const string COL_AMOUNTCREDITED = "AmountCredited";
        public const string COL_ANNULLED = "Annulled";
        public const string COL_AUTHORIZATIONID = "AuthorizationId";
        public const string COL_AUTHORIZED = "Authorized";

        public const string VAL_TRANSACTIONSUMMARY_ID_PREFIX = "TS";
    }
    #endregion

    #region CouponMaster
    public class CouponMaster
    {
        //PROCEDURES
        public const string PROC_GETALL_COUPON = "sproc_CouponMaster_LstAll";
        public const string PROC_GET_COUPON = "sproc_CouponMaster_sel";
        public const string PROC_GET_COUPON_CODES = "sproc_CouponMaster_sel_Codes";
        public const string PROC_GET_COUPON_BY_COUPONCODE = "sproc_CouponMaster_sel_By_CouponCode";
        public const string PROC_DELETE_COUPONMASTER = "sproc_CouponMaster_del";
        public const string PROC_UPDATE_COUPONMASTER = "sproc_CouponMaster_ups";

        //PARAMETERS
        public const string PARA_COUPONID = "@CouponID";
        public const string PARA_COUPONCODE = "@CouponCode";
        public const string PARA_TITLE = "@Title";
        public const string PARA_EXPIRYDATE = "@ExpiryDate";
        public const string PARA_PURCHASEDATE = "@PurchaseDate";
        public const string PARA_ISUSED = "@IsUsed";
        public const string PARA_EXPIRYDATE_FROM = "@ExpiryFromDate";
        public const string PARA_EXPIRYDATE_TO = "@ExpiryToDate";

        //FIELDS
        public const string COL_COUPONID = "CouponID";
        public const string COL_COUPONCODE = "CouponCode";
        public const string COL_TITLE = "Title";
        public const string COL_EXPIRYDATE = "ExpiryDate";
        public const string COL_PURCHASEDATE = "PurchaseDate";
        public const string COL_ISUSED = "IsUsed";

        public const string VAL_COUPON_ID_PREFIX = "COUP";
    }
    #endregion

    #region Manage Currency
    public class ManageCurrency
    {
        //PROCEDURES
        public const string PROC_ACTIVE_CURRENCY = "sproc_CurrencyActive_ups";
        public const string PROC_DEACTIVE_CURRENCY = "sproc_CurrencyDeactive_ups";
        public const string PROC_GET_ALL_CURRENCIES = "sproc_Currency_LstAll";
        public const string PROC_GET_ALL_CURRENCIES_CATALOG = "sproc_Currency_LstAll_Catalog";


        //PARAMETERS
        public const string PARA_LANGUAGEID = "@LanguageId";
        public const string PARA_CURRENCYNAME = "@CurrencyName";
        public const string PARA_ISOName = "@ISOName";


        //FIELDS
        public const string COL_CURRENCY_NAME = "CurrencyName";
        public const string COL_ISONAME = "ISOName";
        public const string COL_CURRENCY_SYMBOL = "CurrencySymbol";
        public const string COL_ISACTIVE = "IsActive";
        public const string COL_LANGUAGEID = "LanguageID";
        public const string COL_SEQ_NO = "SeqNo";
    }
    #endregion

    #region RefDocument
    public class RefDocument
    {
        //PROCEDURES
        public const string PROC_REFDOCUMENT_ISNAMEAVAILABLE_ = "sproc_RefDocument_IsnameAvailable";
        public const string PROC_DELETE_REFDOCUMENT = "sproc_RefDocument_del";
        public const string PROC_UPDATE_REFDOCUMENT = "sproc_RefDocument_ups";
        public const string PROC_GET_ALL_REFDOCUMENT = "sproc_RefDocument_LstAll";
        public const string PROC_GET_ALL_REFDOCUMENT_LEARNER = "sproc_RefDocument_LstAll_Learner";
        public const string PROC_GET_REFDOCUMENT = "sproc_RefDocument_Sel";

        //PARAMETERS
        public const string PARA_REFDOCUMENTID = "@RefDocumentId";
        public const string PARA_ACTIVITYID = "@ActivityId";
        public const string PARA_ACTIVITYTYPEID = "@ActivityTypeId";
        public const string PARA_REFDOCUMENTNAME = "@RefDocumentName";
        public const string PARA_REFDOCUMENTDESCRIPTION = "@RefDocumentDescription";
        public const string PARA_ISACTIVE = "@IsActive";
        public const string PARA_DISPLAYORDER = "@DisplayOrder";
        public const string PARA_REFDOCUMENTFILENAME = "@RefDocumentFileName";
        public const string PARA_REFDOCUMENTFILETYPE = "@RefDocumentFileType";

        //FIELDS
        public const string COL_REFDOCUMENTID = "RefDocumentId";
        public const string COL_ACTIVITYID = "ActivityId";
        public const string COL_ACTIVITYTYPEID = "ActivityTypeId";
        public const string COL_REFDOCUMENTNAME = "RefDocumentName";
        public const string COL_REFDOCUMENTDESCRIPTION = "RefDocumentDescription";
        public const string COL_ISACTIVE = "IsActive";
        public const string COL_DISPLAYORDER = "DisplayOrder";
        public const string COL_REFDOCUMENTFILENAME = "RefDocumentFileName";
        public const string COL_REFDOCUMENTFILETYPE = "RefDocumentFileType";
    }
    #endregion

    #region AssessmentQuestionMapping
    public class AssessmentQuestionMapping
    {
        //PROCEDURES
        public const string PROC_DELETE_ASSESSMENTQUESTIONMAPPING = "sproc_AssessmentQuestionMapping_del";
        public const string PROC_UPDATE_ASSESSMENTQUESTIONMAPPING = "sproc_AssessmentQuestionMapping_ups";
        public const string PROC_GET_ALL_ASSESSMENTQUESTIONMAPPING = "sproc_AssessmentQuestionMapping_LstAll";
        public const string PROC_GET_ASSESSMENTQUESTIONMAPPING = "sproc_AssessmentQuestionMapping_Sel";

        //PARAMETERS
        public const string PARA_QUESTIONID = "@QuestionId";
        public const string PARA_ASSESSMENTID = "@AssessmentID";
        public const string PARA_SECTIONID = "@SectionID";
        public const string PARA_SEQUENCEORDER = "@SequenceOrder";
        public const string PARA_ISACTIVE = "@IsActive";

        //FIELDS
        public const string COL_QUESTIONID = "QuestionId";
        public const string COL_ASSESSMENTID = "AssessmentID";
        public const string COL_SECTIONID = "SectionID";
        public const string COL_SEQUENCEORDER = "SequenceOrder";
        public const string COL_ISACTIVE = "IsActive";
    }
    #endregion

    #region Discount Coupon

    public class DiscountCoupon
    {
        //PROCEDURES
        public const string PROC_DELETE_DiscountCoupon = "sproc_DiscountCoupon_del";
        public const string PROC_UPDATE_DiscountCoupon = "sproc_DiscountCoupon_ups";
        public const string PROC_GET_ALL_DiscountCoupon = "sproc_DiscountCoupon_LstAll";
        public const string PROC_GET_DiscountCoupon = "sproc_DiscountCoupon_Sel";


        //PARAMETERS   
        public const string PARA_ISACTIVE = "@IsActive";
        public const string PARA_TITLE = "@Title";
        public const string PARA_COUPON_PREFIX = "@CouponPrefix";
        public const string PARA_EXPIRY_DATE = "@Expirydate";
        public const string PARA_NO_OF_COUPONS = "@NoOfCoupons";
        public const string PARA_DISCOUNT_TYPE = "@DiscountType";
        public const string PARA_DISCOUNT_PRICE = "@DiscountPrice";
        public const string PARA_COUPON_CODE = "@CouponCode";
        public const string PARA_IS_USED = "@IsUsed";


        //FIELDS     
        public const string COL_ISACTIVE = "IsActive";
        public const string COL_TITLE = "Title";
        public const string COL_COUPON_PREFIX = "CouponPrefix";
        public const string COL_EXPIRY_DATE = "Expirydate";
        public const string COL_NO_OF_COUPONS = "NoOfCoupons";
        public const string COL_DISCOUNT_TYPE = "DiscountType";
        public const string COL_DISCOUNT_PRICE = "DiscountPrice";
        public const string COL_COUPON_CODE = "CouponCode";
        public const string COL_IS_USED = "IsUsed";
    }
    #endregion

    #region FeatureList
    public class FeatureList
    {
        //PROCEDURES
        public const string PROC_DELETE_FEATURELIST = "sproc_FeatureList_del";
        public const string PROC_UPDATE_FEATURELIST = "sproc_FeatureList_ups";
        public const string PROC_GET_ALL_FEATURELIST = "sproc_FeatureList_LstAll";
        public const string PROC_GET_FEATURELIST = "sproc_FeatureList_Sel";

        //PARAMETERS
        public const string PARA_FEATUREID = "@FeatureID";
        public const string PARA_FEATURENAME = "@FeatureName";
        public const string PARA_FEATUREDESCRIPTION = "@FeatureDescription";
        public const string PARA_ISACTIVE = "@IsActive";

        //FIELDS
        public const string COL_FEATUREID = "FeatureID";
        public const string COL_FEATURENAME = "FeatureName";
        public const string COL_FEATUREDESCRIPTION = "FeatureDescription";
        public const string COL_ISACTIVE = "IsActive";
    }
    #endregion
    #region Browser
    public class Browser
    {
        //PROCEDURES
        public const string PROC_DELETE_BROWSER = "sproc_Browser_del";
        public const string PROC_UPDATE_BROWSER = "sproc_Browser_ups";
        public const string PROC_GET_ALL_BROWSER = "sproc_Browser_LstAll";
        public const string PROC_GET_ALL_BROWSER_SEARCH = "sproc_Browser_LstAll_Display";
        public const string PROC_GET_BROWSER = "sproc_Browser_Sel";
        public const string PROC_GET_BROWSER_BYNAME = "sproc_Browser_sel_ByBrowser";

        //PARAMETERS
        public const string PARA_BROWSERID = "@BrowserId";
        public const string PARA_OS = "@OS";
        public const string PARA_BROWSERNAME = "@BrowserName";
        public const string PARA_MAJORVERSION = "@MajorVersion";
        public const string PARA_MINORVERSION = "@MinorVersion";
        public const string PARA_FLASHVERSION = "@FlashVersion";
        public const string PARA_ISSUPPORT = "@IsSupport";

        //FIELDS
        public const string COL_BROWSERID = "BrowserId";
        public const string COL_OS = "OS";
        public const string COL_OSShortName = "OSShortName";
        public const string COL_BROWSERNAME = "BrowserName";
        public const string COL_MAJORVERSION = "MajorVersion";
        public const string COL_MINORVERSION = "MinorVersion";
        public const string COL_FLASHVERSION = "FlashVersion";
        public const string COL_ISSUPPORT = "IsSupport";
    }
    #endregion
    #region WebService-Request-Response

    #region WebServiceDetails

    public class WebServiceDetails
    {
        //PROCEDURES
        public const string PROC_DELETE_WEB_SERVICE_DETAILS = "sproc_WebServiceDetails_del";
        public const string PROC_UPDATE_WEB_SERVICE_DETAILS = "sproc_WebServiceDetails_ups";
        public const string PROC_GET_ALL_WEB_SERVICE_DETAILS = "sproc_WebServiceDetails_LstAll";
        public const string PROC_GET_WEB_SERVICE_DETAILS = "sproc_WebServiceDetails_Sel";
        public const string PROC_GET_WEB_SERVICE_DETAILS_EXT = "sproc_WebServiceDetails_sel_ext";


        //PARAMETERS   
        public const string PARA_SERVICEID = "@ServiceId";
        public const string PARA_SERVICEURL = "@ServiceUrl";
        public const string PARA_AUTHKEY = "@AuthKey";
        public const string PARA_ADMIN_EMAIL = "@AdminEmail";
        public const string PARA_VENDORCODE = "@VendorCode";



        //FIELDS     
        public const string COL_SERVICEID = "ServiceId";
        public const string COL_SERVICEURL = "ServiceUrl";
        public const string COL_AUTHKEY = "AuthKey";
        public const string COL_ADMIN_EMAIL = "AdminEmail";
        public const string COL_VENDORCODE = "VendorCode";
        public const string COL_MEDKEY_CODE = "MedKey_code";

    }
    #endregion

    #region ParticipantCompletionRequest

    public class ActivityAssignmentExt
    {

        public const string COL_PARTICIPANTID = "ParticipantId";
        public const string COL_COURSEID = "CourseId";
        public const string COL_TOKENKEY = "TokenKey";
        public const string COL_ISURLLAUNCHED = "IsURLLaunched";
        public const string COL_VENDORCODE = "VendorCode";
        public const string COL_SYSTEMUSERGUID = "SystemUserGUID";
    }
    public class ParticipantCompletionRequest
    {
        //PROCEDURES
        public const string PROC_DELETE_PARTCIPANT_COMP_REQ = "sproc_ParticipantCompletionRequest_del";
        public const string PROC_UPDATE_PARTCIPANT_COMP_REQ = "sproc_ParticipantCompletionRequest_ups";
        public const string PROC_GET_ALL_PARTCIPANT_COMP_REQ = "sproc_ParticipantCompletionRequest_LstAll";
        public const string PROC_GET_PARTCIPANT_COMP_REQ = "sproc_ParticipantCompletionRequest_Sel";


        //PARAMETERS   
        public const string PARA_REQUESTID = "@RequestId";
        public const string PARA_SYSTEMUSERGUID = "@SystemUserGUID";
        public const string PARA_COURSEID = "@CourseId";
        public const string PARA_COMPLETION_DATE = "@CompletionDate";
        public const string PARA_RESPONSE = "@Response";
        public const string PARA_REQUEST_DATE = "@RequestSentDate";
        public const string PARA_STATUS = "@Status";
        public const string PARA_PARTICIPANT_ID = "@ParticipantId";
        public const string PARA_RESPONSE_CODE = "@ResponseCode";
        public const string PARA_RESPONSE_MESSAGE = "@ResponseMessage";



        //FIELDS     
        public const string COL_REQUESTID = "RequestId";
        public const string COL_SYSTEMUSERGUID = "SystemUserGUID";
        public const string COL_COURSEID = "CourseId";
        public const string COL_COMPLETION_DATE = "CompletionDate";
        public const string COL_RESPONSE = "Response";
        public const string COL_REQUEST_DATE = "RequestSentDate";
        public const string COL_STATUS = "Status";
        public const string COL_PARTICIPANT_ID = "ParticipantId";
        public const string COL_RESPONSE_CODE = "ResponseCode";
        public const string COL_RESPONSE_MESSAGE = "ResponseMessage";

    }
    public class ParticipantCompletionRequestMedKey
    {
        //PROCEDURES
        public const string PROC_GET_PARTCIPANT_COMP_REQ_MEDKEY = "sproc_ParticipantCompletionRequest_ups";
        public const string PROC_GET_CHECK_IF_REQUEST_ALREADY_SENT = "sproc_ParticipantMedKey_CheckIfRequestAlreadySent";
        
        //PARAMETERS   
        public const string PARA_VENDORCODE = "@VendorCode";
        public const string PARA_QUERYCOMPLETIONSTATUS = "@QueryCompletionStatus";
        
        
        //FIELDS     
        public const string COL_ISCOMPLETIONSTATUSSENT = "IsCompletionStatusSent";
     

    }
    #endregion

    #region ParticipantDetails

    public class ParticipantDetails
    {
        //PROCEDURES
        public const string PROC_DELETE_PARTCIPANT_DETAILS = "sproc_ParticipantDetails_del";
        public const string PROC_UPDATE_PARTCIPANT_DETAILS = "sproc_ParticipantDetails_ups";
        public const string PROC_GET_ALL_PARTCIPANT_DETAILS = "sproc_ParticipantDetails_LstAll";
        public const string PROC_GET_PARTCIPANT_DETAILS = "sproc_ParticipantDetails_Sel";

        public const string PROC_REGISTER_USER_PARTICIPANT_DETAILS = "sproc_ParticipantDetails_ups_RegisterUser";
        public const string PROC_REGISTER_USER_PARTICIPANT_DETAILS_EXT = "sproc_ParticipantDetails_ups_RegisterUser_Ext";
        public const string PROC_PARTICIPANT_CHECK_COURSE_ALREADY_LAUNCH = "sproc_Participant_CheckCourseAlreadyLaunch";


        //PARAMETERS   
        public const string PARA_REQUESTID = "@ParticipantRequestId";
        public const string PARA_SYSTEMUSERGUID = "@SystemUserGUID";
        public const string PARA_COURSEID = "@CourseId";
        public const string PARA_REQUEST_DATE = "@RequestDate";
        public const string PARA_STATUS = "@Status";
        public const string PARA_PARTICIPANT_ID = "@ParticipantId";
        public const string PARA_PASSWORD = "@UserPassword";
        public const string PARA_TOKEN_KEY = "@TokenKey";
        public const string PARA_TOKEN_KEY_OUT = "@TokenKeyOut";
        public const string PARA_RESULTMSG = "@ResultMsg";
        public const string PARA_VENDOR_CODE = "@VendorCode";



        //FIELDS     
        public const string COL_REQUESTID = "ParticipantRequestId";
        public const string COL_SYSTEMUSERGUID = "SystemUserGUID";
        public const string COL_COURSEID = "CourseId";
        public const string COL_REQUEST_DATE = "RequestDate";
        public const string COL_STATUS = "Status";
        public const string COL_PARTICIPANT_ID = "ParticipantId";
        public const string COL_ISURLLAUNCHED = "IsURLLaunched";

        //Vendor List
        public const string VENDOR_MEDKEY = "MEDKEY";
        public const string VENDOR_SOLWARE = "SOLWARE";

        public const string VENDOR_COMPLETIONSTATUS_COMPLETED = "completed";
        public const string VENDOR_COMPLETIONSTATUS_UNCOMPLETED = "uncompleted";

        public const string VENDOR_COMPLETED_SENT = "COMPLETED_SENT";
        public const string VENDOR_COMPLETED_NOT_SENT = "COMPLETED_NOT_SENT";
        public const string VENDOR_UNCOMPLETED_SENT = "UNCOMPLETED_SENT";
        public const string VENDOR_UNCOMPLETED_NOT_SENT = "UNCOMPLETED_NOT_SENT";

        



    }
    #endregion


    #endregion

    #region FAQ
    public class FAQ
    {
        //Procedures
        public const string PROC_DELETE_FAQ = "sproc_FAQ_del";
        public const string PROC_UPDATE_FAQ = "sproc_FAQ_ups";
        public const string PROC_GET_ALL_FAQ = "sproc_FAQ_LstAll";
        public const string PROC_GET_FAQ = "sproc_FAQ_Sel";
        public const string PROC_GET_FAQ_LANGUAGES = "sproc_FAQLanguage_sel_List";

        //Parameters
        public const string PARA_FAQ_ID = "@FAQId";
        public const string PARA_CATEGORY_ID = "@CategoryId";
        public const string PARA_LANGUAGE_ID = "@LanguageId";
        public const string PARA_CLOSE_DATE = "@CloseDate";
        public const string PARA_QUESTION = "@Question";
        public const string PARA_ANSWER = "@Answer";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_ATTACHED_FILE = "@AttachedFile";
        public const string PARA_ATTACHED_LINK = "@AttachedLink";
        public const string PARA_IS_FOR_LEARNER = "@IsForLearner";
        public const string PARA_DISPLAY_ORDER = "@DisplayOrder";

        //Fields
        public const string COL_FAQ_ID = "FAQId";
        public const string COL_CATEGORY_ID = "CategoryId";
        public const string COL_CLOSE_DATE = "CloseDate";
        public const string COL_QUESTION = "Question";
        public const string COL_ANSWER = "Answer";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_ATTACHED_FILE = "AttachedFile";
        public const string COL_ATTACHED_LINK = "AttachedLink";
        public const string COL_DISPLAY_ORDER = "DisplayOrder";
    }
    #endregion

    #region FAQLanguage
    public class FAQLanguage
    {
        //PROCEDURES
        public const string PROC_UPDATE_FAQ_LANGUAGE = "sproc_FAQLanguage_ups";

        //PARAMETERS
        public const string PARA_FAQID = "@FAQId";
        public const string PARA_QUESTION = "@Question";
        public const string PARA_ANSWER = "@Answer";

        //FIELDS
        public const string COL_FAQID = "FAQId";
        public const string COL_QUESTION = "Question";
        public const string COL_ANSWER = "@Answer";
        public const string COL_LANGUAGEID = "LanguageId";
    }
    #endregion

    
    #region CurriculumLanguage
    public class CurriculumLanguage
    {
        //PROCEDURES
        public const string PROC_DELETE_CURRICULAM_LANGUAGE = "sproc_CurriculumLanguage_del";
        public const string PROC_UPDATE_CURRICULAM_LANGUAGE = "sproc_CurriculumLanguage_ups";
        public const string PROC_GET_ALL_CURRICULAM_LANGUAGE = "sproc_CurriculumLanguage_LstAll";
        public const string PROC_GET_CURRICULAM_LANGUAGE = "sproc_CurriculumLanguage_Sel";

        //PARAMETERS
        public const string PARA_CURRICULUM_ID = "@CurriculumId";
        public const string PARA_LANGUAGEID = "@LanguageId";
        public const string PARA_CURRICULUM_NAME = "@CurriculumName";
        public const string PARA_CURRICULUM_DESC = "@CurriculumDescription";
        public const string PARA_CURRICULUM_INSTRUCTION = "@CurriculumInstruction";

        //FIELDS
        public const string COL_CURRICULUM_ID = "CurriculumId";
        public const string COL_LANGUAGEID = "LanguageId";
        public const string COL_CURRICULUM_NAME = "CurriculumName";
        public const string COL_CURRICULUM_DESC = "CurriculumDescription";
        public const string COL_CURRICULUM_INSTRUCTION = "CurriculumInstruction";
    }
    #endregion

    #region CurriculumSection
    public class CurriculumSection
    {
        //PROCEDURES
        public const string PROC_DELETE_CURRICULAM_SECTION = "sproc_CurriculumSectionMaster_del";
        public const string PROC_UPDATE_CURRICULAM_SECTION = "sproc_CurriculumSectionMaster_ups";
        public const string PROC_GET_ALL_CURRICULAM_SECTION = "sproc_CurriculumSectionMaster_LstAll";
        public const string PROC_GET_CURRICULAM_SECTION = "sproc_CurriculumSectionMaster_sel";
        public const string PROC_GET_CURRICULAM_SECTION_IS_NAME_AVAILABLE = "sproc_CurriculumSectionMaster_Sel_IsNameAvailable";
        public const string PROC_UPDATE_CURRICULAM_SECTION_OPTIONS = "sproc_CurriculumSectionMaster_ups_Options";
        public const string PROC_UPDATE_CURRICULAM_SECTION_SEQUENCE_ORDER = "sproc_CurriculumSectionMaster_ups_SequenceOrder";

        //PARAMETERS
        public const string PARA_CURRICULUM_ID = "@CurriculumId";
        public const string PARA_SECTIONID = "@SectionId";
        public const string PARA_SEQUENCEORDER = "@SequenceOrder";
        public const string PARA_SORTORDER = "@SortOrder";
        public const string PARA_COMPLETION_ORDER = "@CompletionOrder";
        public const string PARA_ENFORECE_ACTIVITY_SEQUENCING = "@EnforceActivitySequencing";



        //FIELDS
        public const string COL_CURRICULUM_ID = "CurriculumId";
        public const string COL_SECTIONID = "SectionId";
        public const string COL_SEQUENCEORDER = "SequenceOrder";
        public const string COL_COMPLETION_ORDER = "CompletionOrder";
        public const string COL_ENFORECE_ACTIVITY_SEQUENCING = "EnforceActivitySequencing";
        public const string COL_PROGRESS = "Progress";

    }
    #endregion

    #region CurriculumSectionLanguage
    public class CurriculumSectionLanguage
    {
        //PROCEDURES
        public const string PROC_DELETE_CURRICULAM_SECTION_LANGUAGE = "sproc_CurriculumSectionLanguage_del";
        public const string PROC_UPDATE_CURRICULAM_SECTION_LANGUAGE = "sproc_CurriculumSectionLanguage_ups";
        public const string PROC_GET_ALL_CURRICULAM_SECTION_LANGUAGE = "sproc_CurriculumSectionLanguage_LstAll";
        public const string PROC_GET_CURRICULAM_SECTION_LANGUAGE = "sproc_CurriculumSectionLanguage_Sel";

        //PARAMETERS
        public const string PARA_SECTIONID = "@SectionId";
        public const string PARA_LANGUAGEID = "@LanguageId";
        public const string PARA_CURRICULUM_SECTION_NAME = "@SectionName";
        public const string PARA_CURRICULUM_SECTION_DESC = "@SectionDescription";
        public const string PARA_CURRICULUM_SECTION_INSTRUCTION = "@SectionInstruction";

        //FIELDS
        public const string COL_SECTIONID = "SectionId";
        public const string COL_LANGUAGEID = "LanguageId";
        public const string COL_CURRICULUM_SECTION_NAME = "SectionName";
        public const string COL_CURRICULUM_SECTION_DESC = "SectionDescription";
        public const string COL_CURRICULUM_SECTIONINSTRUCTION = "SectionInstruction";
    }
    #endregion

    

    #region OrderDetails
    public class OrderDetails
    {
        //PROCEDURES
        public const string PROC_DELETE_OrderDetails = "sproc_OrderDetails_del";
        public const string PROC_UPDATE_OrderDetails = "sproc_OrderDetails_ups";
        public const string PROC_GET_ALL_OrderDetails = "sproc_OrderDetails_LstAll";
        public const string PROC_GET_OrderDetails = "sproc_OrderDetails_Sel";
        public const string PROC_IS_VOUCHER_AVAILABLE = "sproc_IsProductVoucherAvalable";


        //PARAMETERS
        public const string PARA_ORDERID = "@OrderID";
        public const string PARA_PRODUCTID = "@ProductId";
        public const string PARA_PRICE = "@Price";
        public const string PARA_QTY = "@Qty";
        public const string PARA_VOUCHERID = "@VoucherId";
        public const string PARA_VOUCHER_CODE = "@VoucherCode";

        //FIELDS
        public const string COL_ORDERID = "OrderID";
        public const string COL_PRODUCTID = "ProductId";
        public const string COL_PRICE = "Price";
        public const string COL_QTY = "Qty";
        public const string COL_VOUCHERID = "VoucherId";
        public const string COL_VOUCHER_CODE = "VoucherCode";

    }
    #endregion

    #region SignUpProfileAccessConfiguration
    public class SignUpProfileAccessConfiguration
    {
        //PROCEDURES        
        public const string PROC_GET_ALL_SIGNUP_PROFILE_CONFIG = "sproc_SignUpProfileAccessConfiguration_LstAll";
        public const string PROC_UPDATE_SIGNUP_PROFILE_CONFIG = "sproc_SignUpProfileAccessConfiguration_ups";
        public const string PROC_DELETE_PROFILE_CONFIG = "sproc_SignUpProfileAccessConfiguration_del";

        //PARAMETERS
        public const string PARA_PROFILE_ACCESS_CONFIGURATION_ID = "@ProfileAccessConfigurationId";
        public const string PARA_PROFILE_FIELD_ID = "@ProfileFieldID";
        public const string PARA_FIELD_NAME = "@FieldName";
        public const string PARA_IS_READ_ONLY = "@IsReadOnly";
        public const string PARA_IS_MANDATORY = "@IsMandatory";
        public const string PARA_IS_VISIBLE_TO_USER = "@IsVisibletoUser";
        public const string PARA_FIELD_TYPE = "@FieldType";

        //FIELDS
        public const string COL_PROFILE_ACCESS_CONFIGURATION_ID = "ProfileAccessConfigurationId";
        public const string COL_PROFILE_FIELD_ID = "ProfileFieldID";
        public const string COL_FIELD_NAME = "FieldName";
        public const string COL_IS_READ_ONLY = "IsReadOnly";
        public const string COL_IS_MANDATORY = "IsMandatory";
        public const string COL_IS_MANDATORY_DISABLED = "IsMandatoryDisabled";
        public const string COL_IS_VISIBLE_TO_USER = "IsVisibletoUser";
        public const string COL_FIELD_TYPE = "FieldType";


    }
    #endregion

    #region ProductCatalogSettings
    public class ProductCatalogSettings
    {
        //PROCEDURES        
        public const string PROC_GET_ALL_PRODUCT_CATALOG_SETTING = "sproc_ProductCatalogSetting_LstAll";
        public const string PROC_UPDATE_PRODUCT_CATALOG_SETTING = "sproc_ProductCatalogSetting_ups";
        public const string PROC_DELETE_PRODUCT_CATALOG_SETTING = "sproc_ProductCatalogSetting_del";
        public const string PROC_GET_PRODUCT_CATALOG_SETTING = "sproc_ProductCatalogSetting_Sel";

        //PARAMETERS
        public const string PARA_SETTING_ID = "@SettingId";
        public const string PARA_SETTING_TITLE = "@SettingTitle";
        public const string PARA_SETTING_VALUE = "@Value";
        public const string PARA_IS_ACTIVE = "@IsActive";

        //FIELDS      
        public const string COL_SETTING_ID = "SettingId";
        public const string COL_SETTING_TITLE = "SettingTitle";
        public const string COL_SETTING_VALUE = "Value";
        public const string COL_IS_ACTIVE = "IsActive";


    }
    #endregion
    #region ProductCatalogRegRequest

    public class ProductCatalogRegRequest
    {
        //PROCEDURES
        public const string PROC_DELETE_PRODUCT_CATALOG_REG_REQ = "sproc_ProductCatalogRegRequest_del";
        public const string PROC_UPDATE_PRODUCT_CATALOG_REG_REQ = "sproc_ProductCatalogRegRequest_ups";
        public const string PROC_GET_ALL_PRODUCT_CATALOG_REG_REQ = "sproc_ProductCatalogRegRequest_LstAll";
        public const string PROC_GET_PRODUCT_CATALOG_REG_REQ = "sproc_ProductCatalogRegRequest_Sel";
        public const string PROC_GET_PRODUCT_CATALOG_REG_ACTIVITY_ASSIGNED = "sproc_ProductCatalogRegRequest_Sel_IsActivityAssigned";


        //PARAMETERS   
        public const string PARA_PRODUCTID = "@ProductId";
        public const string PARA_SYSTEMUSERGUID = "@SystemUserGUID";
        public const string PARA_STATUS = "@Status";


        //FIELDS     
        public const string COL_PRODUCTID = "ProductId";
        public const string COL_SYSTEMUSERGUID = "SystemUserGUID";
        public const string COL_STATUS = "Status";

    }
    #endregion

    #region Document Library
    internal class DocumentLibrary
    {
        //Procedure         
        public const string PROC_GET_DOCUMENT_LIB_CHILDREN_COUNT = "sproc_DocLibraryFolderMaster_ChildrenCount";
        public const string PROC_GET_DOCUMENT_LIBRARY = "sproc_DocLibraryFolderMaster_sel";
        public const string PROC_GET_ALL_DOCUMENT_LIBRARY = "sproc_DocLibraryFolderMaster_LstAll";
        public const string PROC_UPDATE_DOCUMENT_LIBRARY = "sproc_DocLibraryFolderMaster_ups";
        public const string PROC_DELETE_CHILD_DOCUMENT_LIBRARY = "sproc_DocLibraryFolderMaster_DelChildren";


        //PARAMETERS        
        public const string PARA_FOLDER_ID = "@FolderId";
        public const string PARA_FOLDER_NAME = "@FolderName";
        public const string PARA_FOLDER_DESC = "@FolderDescription";
        public const string PARA_PARENT_FOLDER_ID = "@ParentFolderId";
        public const string PARA_IS_VISIBLE = "@IsVisible";
        public const string PARA_RELATIVE_PATH = "@RelativePath";
        public const string PARA_CLIENT_ID = "@ClientID";
        public const string PARA_CREATED_BY_ID = "@CreatedById";
        //FIELDS
        public const string COL_FOLDER_ID = "FolderId";
        public const string COL_FOLDER_NAME = "FolderName";
        public const string COL_FOLDER_DESC = "FolderDescription";
        public const string COL_PARENT_FOLDER_ID = "ParentFolderId";
        public const string COL_IS_VISIBLE = "IsVisible";
        public const string COL_RELATIVE_PATH = "RelativePath";
        public const string COL_CLIENT_ID = "ClientId";
        public const string COL_CREATED_BY_ID = "CreatedById";
    }
    #endregion

    #region Document
    public class Document
    {
        //Procedure
        public const string PROC_GET_DOCUMENT_RELATIVE_PATH = "sproc_DocumentLibMaster_sel_RelativePath";
        public const string PROC_GET_DOCUMENT = "sproc_DocumentLibMaster_sel";
        public const string PROC_GET_DOCUMENT_LEARNER = "sproc_DocumentLibMaster_sel_Learner";
        public const string PROC_GET_ALL_DOCUMENT = "sproc_DocumentLibMaster_LstAll";
        public const string PROC_GET_ALL_DOCUMENT_LEARNER = "sproc_DocumentLibMaster_LstAll_For_Learner";
        public const string PROC_UPDATE_DOCUMENT = "sproc_DocumentLibMaster_ups";
        public const string PROC_UPDATE_DOCUMENT_LANGUAGE = "sproc_DocumentLibMaster_ups_Language";
        public const string PROC_DELETE_DOCUMENT = "sproc_DocumentLibMaster_del";
        public const string PROC_GET_DOCUMENTS_LANGUAGES = "sproc_DocumentLibLanguage_sel_List";
        public const string PROC_DELETE_DOCUMENT_LANGUAGE = "sproc_DocumentLibLanguage_del";
        public const string PROC_GET_DOCUMENT_VIDEOS = "sproc_DocumentLibMaster_LstVideos";
        public const string PROC_GET_DOCUMENT_VIDEOS_LEARNER = "sproc_DocumentLibMaster_LstVideos_Learner";

        //PARAMETERS
        public const string PARA_LIBRARY_ID = "@LibraryId";
        public const string PARA_DOCUMENT_NAME = "@DocumentName";
        public const string PARA_DOCUMENT_FILE_NAME = "@DocumentFileName";
        public const string PARA_DOCUMENT_DESCRIPTION = "@DocumentDescription";
        public const string PARA_DOCUMENT_KEYWORDS = "@Keywords";
        public const string PARA_DOCUMENT_FOLDER_ID = "@FolderId";
        public const string PARA_IS_ACTIVE = "@IsActive";
        public const string PARA_DOCUMENT_FILE_TYPE = "@FileType";
        public const string PARA_RELATIVE_PATH = "@RelativePath";
        public const string PARA_THUMBNAIL_PATH = "@ThumbnailPath";
        public const string PARA_AUTHOR = "@Author";
        public const string PARA_PUBLISH_DATE = "@PublishDate";
        public const string PARA_CATEGORYID = "@CategoryId";
        public const string PARA_SUBCATEGORYID = "@SubCategoryId";


        //FIELDS
        public const string COL_LIBRARY_ID = "LibraryId";
        public const string COL_DOCUMENT_NAME = "DocumentName";
        public const string COL_DOCUMENT_DESCRIPTION = "DocumentDescription";
        public const string COL_DOCUMENT_KEYWORDS = "Keywords";
        public const string COL_DOCUMENT_FOLDER_ID = "FolderId";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_DOCUMENT_FILE_TYPE = "FileType";
        public const string COL_RELATIVE_PATH = "RelativePath";
        public const string COL_CLIENT_ID = "ClientId";
        public const string COL_THUMBNAIL_PATH = "ThumbnailPath";
        public const string COL_AUTHOR = "Author";
        public const string COL_PUBLISH_DATE = "PublishDate";
        public const string COL_ICON_NAME = "IconName";
        public const string COL_CATEGORY_NAME = "CategoryName";
        public const string COL_SUBCATEGORY_NAME = "SubCategoryName";
    }
    #endregion

    #region UseDocumentTracking
    public class UserDocumentTracking
    {
        //PROCEDURES
        public const string PROC_GET_USER_DOCUMENT_TRACKING = "sproc_UserDocumentTracking_sel";
        public const string PROC_UPDATE_USER_DOCUMENT_TRACKING = "sproc_UserDocumentTracking_ups";
        public const string PROC_MARK_COMPLETED = "sproc_UserDocumentTracking_ups";

        //PARAMETERS
        public const string PARA_DOCUMENT_ID = "@DocumentId";
        public const string PARA_SYSTEM_USER_GUID = "@SystemUserGUID";
        public const string PARA_DATE_OF_COMPLETION = "@DateOfCompletion";

        //FIELDS
        public const string COL_DOCUMENT_ID = "DocumentId";
        public const string COL_SYSTEM_USER_GUID = "SystemUserGUID";

    }
    #endregion

    //*********************************Bookmark******************************************************
    #region Bookmark
    public class Bookmark
    {
        //Procedure
        public const string PROC_UPDATE_BOOKMARK = "sproc_BookmarkMaster_ups";
        public const string PROC_DELETE_BOOKMARK = "sproc_BookmarkMaster_del";
        public const string PROC_GET_BOOKMARK = "sproc_BookmarkMaster_sel";
        public const string PROC_GET_ALL_BOOKMARK = "sproc_BookmarkMaster_LstAll";

        //PARAMETERS
        public const string PARA_BOOKMARK_ID = "@BookmarkId";
        public const string PARA_ACTIVITY_ID = "@ActivityId";
        public const string PARA_ACTIVITY_TYPE = "@ActivityType";
        public const string PARA_LEARNER_ID = "@SystemUserGUID";
        public const string PARA_BOOKMARK_DATE = "@BookmarkDate";

        //FIELDS
        public const string COL_BOOKMARK_ID = "BookmarkId";
        public const string COL_ACTIVITY_ID = "ActivityId";
        public const string COL_ACTIVITY_TYPE = "ActivityType";
        public const string COL_ACTIVITY_NAME = "ActivityName";
        public const string COL_COMPLETION_STATUS = "CompletionStatus";
        public const string COL_LEARNER_ID = "SystemUserGUID";
        public const string COL_BOOKMARK_DATE = "BookmarkDate";
    }
    #endregion

    #region TimeZone
    public class TimeZoneMaster
    {
        public const string PROC_TIMEZONEMASTER_GETALL = "sproc_TimeZoneMaster_LstAll";
        public const string PROC_TIMEZONEMASTER_GET = "sproc_TimeZoneMaster_Sel";
        //PARAMETER
        public const string PARA_TIMEZONEMASTER_TIMEZONEID = "@TimezoneId";
        public const string PARA_TIMEZONEMASTER_TIMEZONEVALUE = "@Timezonevalue";
        public const string PARA_TIMEZONEMASTER_TIMEZONENAME = "@TimezoneName";
        public const string PARA_TIMEZONEMASTER_TIMEZONESTANDARD = "@TimezoneStandard";

        //COLUMN
        public const string COL_TIMEZONEMASTER_TIMEZONEID = "TimezoneId";
        public const string COL_TIMEZONEMASTER_TIMEZONEVALUE = "Timezonevalue";
        public const string COL_TIMEZONEMASTER_TIMEZONENAME = "TimezoneName";
        public const string COL_TIMEZONEMASTER_TIMEZONESTANDARD = "TimeZoneStandard";
    }
    #endregion


    ////******************added by Sujit for virtual training************************************************
    #region Virtual Training Session Master
    public class VirtualTrainingSessionMaster
    {
        //PROCEDURE 

        public const string PROC_VIRTUALTRAINING_GET_SESSION_KEY = "sproc_GetSessionKey_LstAll";
        public const string PROC_VIRTUALTRAINING_GET_SYSTEMUSERGUID = "sproc_GetSystemUserGUID_Lst";
        public const string PROC_VIRTUALTRAINING_COUNT_ATTEBDED_UPDATE = "sproc_VirtualTrainingCountAttended_ups";
        public const string PROC_VIRTUALTRAINING_UPDATE_REGISTER = "sproc_VirtualTrainingMaster_Registered_ups";
        public const string PROC_VIRTUALTRAINING_TOTAL_TIME_UPDATE = "sproc_VirtualTrainingTotalTime_ups";
        public const string PROC_VIRTUALTRAINING_CLIENT_LIST = "sproc_GetAllClientsVirtualTraining";


        public const string PROC_VIRTUALTRAINING_DELETE = "sproc_VirtualTrainingMaster_del";
        public const string PROC_VIRTUALTRAINING_UPDATE = "sproc_VirtualTrainingMaster_ups";
        public const string PROC_VIRTUALTRAINING_GET = "sproc_VirtualTrainingMaster_sel";
        public const string PROC_VIRTUALTRAINING_GETALL = "sproc_VirtualTrainingSessionMaster_LstAll";
        public const string PROC_VIRTUALTRAINING_GETALLSESSIONSUSERTATUS = "sproc_VirtualTrainingSessionUserMasterStatus_LstAll";
        public const string PROC_VIRTUALTRAINING_GETALLSESSIONSSELFSTATUS = "sproc_VirtualTrainingSessionSelfStatus_LstAll";
        public const string PROC_VIRTUALTRAINING_BULK_UPDATE_ACTIVE = "sproc_VirtualTrainingMaster_ups_IsActive";
        public const string PROC_FIND_VIRTUALTRAINING_NAMES = "sproc_VirtualTraining_Sel_Search";
        public const string PROC_VIRTUALTRAINING_GET_ADMIN_ACCOUNT_USERID = "sproc_VirtualTrainingMaster_sel_userid";
        //PARAMETER
        public const string PARA_VIRTUALTRAINING_TRAININGID = "@Training_Id";
        public const string PARA_VIRTUALTRAINING_TYPE = "@Training_Type";
        public const string PARA_VIRTUALTRAINING_TITLE = "@Training_Title";
        public const string PARA_VIRTUALTRAINING_SESSION_PASSWORD = "@Training_Session_Password";
        public const string PARA_VIRTUALTRAINING_AGENDA = "@Training_Agenda";
        public const string PARA_VIRTUALTRAINING_DESCRIPTION = "@Training_Description";
        public const string PARA_VIRTUALTRAINING_STARTDATE = "@Training_StartDate";
        public const string PARA_VIRTUALTRAINING_ENDDATE = "@Training_EndDate";
        public const string PARA_VIRTUALTRAINING_DURATION = "@Training_Duration";
        public const string PARA_VIRTUALTRAINING_TIMEZONE = "@Training_TimeZone";
        public const string PARA_VIRTUALTRAINING_TIMEZONEID = "@Training_TimeZoneId";
        public const string PARA_VIRTUALTRAINING_OCCURENCE = "@Training_Occurs";
        public const string PARA_VIRTUALTRAINING_SESSION_KEY = "@Session_key";
        public const string PARA_VIRTUALTRAINING_ISCANCELLED = "@Training_IsCancelled";
        public const string PARA_VIRTUALTRAINING_ISACTIVE = "@Training_IsActive";
        public const string PARA_VIRTUALTRAINING_ISSELFREGISTRATION = "@Training_IsSelfRegistration";
        public const string PARA_VIRTUALTRAINING_SYSTEMUSERGUID = "@Training_SystemUserGUID";
        public const string PARA_VIRTUALTRAINING_NOOFREGISTERED = "@NoOfRegistered";
        
        public const string PARA_VIRTUALTRAINING_MAXREGISTRATION = "@Training_MaxRegistration";
        public const string PARA_VIRTUALTRAINING_MINREGISTRAION = "@Training_MinRegistraion";
        public const string PARA_VIRTUALTRAINING_ISWAITLISTED = "@Training_ISWaitlisted";
        public const string PARA_VIRTUALTRAINING_MAXWAITLISTED = "@Training_MaxWaitlisted";
        public const string PARA_VIRTUALTRAINING_AUTOAPPROVE = "@Training_Autoapprove";
        public const string PARA_VIRTUALTRAINING_WEBEXUSERID = "@webexuserid";

        public const string PARA_VIRTUALTRAINING_EMAILID = "@EmailID";
        public const string PARA_VIRTUALTRAINING_NO_OF_ATTENDED = "@NoOfAttended";
        public const string PARA_VIRTUALTRAINING_REPORT_IMPORTED = "@ReportImported";
        public const string PARA_VIRTUALTRAINING_REPORT_TRAINING_STATUS = "@TrainingStatus";
        public const string PARA_VIRTUALTRAINING_REPORT_TRAINING_START_TIME = "@TrainingStartTime";
        public const string PARA_VIRTUALTRAINING_REPORT_TRAINING_END_TIME = "@TrainingEndTime";
        public const string PARA_VIRTUALTRAINING_REPORT_TRAINING_DURATION = "@TrainingDuration";

        //COLUMN
        public const string COL_VIRTUALTRAINING_TRAININGID = "Training_Id";
        public const string COL_VIRTUALTRAINING_TYPE = "Training_Type";
        public const string COL_VIRTUALTRAINING_TITLE = "Title";
        public const string COL_VIRTUALTRAINING_SESSION_PASSWORD = "Session_Password";
        public const string COL_VIRTUALTRAINING_AGENDA = "Agenda";
        public const string COL_VIRTUALTRAINING_DESCRIPTION = "Description";
        public const string COL_VIRTUALTRAINING_STARTDATE = "StartDate";
        public const string COL_VIRTUALTRAINING_ENDDATE = "EndDate";
        public const string COL_VIRTUALTRAINING_DURATION = "Duration";
        public const string COL_VIRTUALTRAINING_TIMEZONE = "TimeZone";
        public const string COL_VIRTUALTRAINING_TIMEZONEID = "TimeZoneId";
        public const string COL_VIRTUALTRAINING_OCCURENCE = "Occurence";
        public const string COL_VIRTUALTRAINING_SESSION_KEY = "Session_key";
        public const string COL_VIRTUALTRAINING_ISCANCELLED = "IsCancelled";
        public const string COL_VIRTUALTRAINING_ISACTIVE = "IsActive";
        
        public const string COL_VIRTUALTRAINING_MAXREGISTRATION = "MaxRegistration";
        public const string COL_VIRTUALTRAINING_MINREGISTRAION = "MinRegistration";
        public const string COL_VIRTUALTRAINING_ISWAITLISTED = "ISWaitlisted";
        public const string COL_VIRTUALTRAINING_MAXWAITLISTED = "MaxWaitlisted";
        public const string COL_VIRTUALTRAINING_AUTOAPPROVE = "AutoApprove";
        public const string COL_VIRTUALTRAINING_NOOFREGISTERED = "NoOfRegistered";
        public const string COL_VIRTUALTRAINING_ISSELFREGISTRATION = "IsSelfRegistration";
        public const string COL_VIRTUALTRAINING_SYSTEMUSERGUID = "SystemUserGUID";
        public const string COL_VIRTUALTRAINING_WEBEXUSERID = "webexuserid";

        public const string COL_VIRTUALTRAINING_REPORT_TRAINING_STATUS = "TrainingStatus";
        public const string COL_VIRTUALTRAINING_REPORT_TRAINING_START_TIME = "TrainingStartTime";
        public const string COL_VIRTUALTRAINING_REPORT_TRAINING_END_TIME = "TrainingEndTime";
        public const string COL_VIRTUALTRAINING_REPORT_TRAINING_DURATION = "TrainingDuration";

        /// Prefix
        public const string VAL_VIRTUALTRAINING_ID_PREFIX = "VTRN";
    }
    #endregion

    #region Virtual Training Attendee Master
    public class VirtualTrainingAttendeeMaster
    {
        //PROCEDURE 
        public const string PROC_VIRTUALTRAINING_ATTENDEE_DELETE = "sproc_VirtualTrainingAttendeeMaster_del";
        public const string PROC_VIRTUALTRAINING_ATTENDEE_UPDATE = "sproc_VirtualTrainingAttendeeMaster_ups";
        public const string PROC_VIRTUALTRAINING_ATTENDEE_GET = "sproc_VirtualTrainingAttendeeMaster_sel";
        public const string PROC_VIRTUALTRAINING_ATTENDEE_GET_ALL = "sproc_VirtualTrainingAttendeeMaster_LstAll";
        public const string PROC_VIRTUALTRAINING_ATTENDEE_GET_ALL_ACCEPTANDREJECT = "sproc_VirtualTrainingAttendeeMaster_ACCEPTREJECT_LstAll";

        public const string PROC_GET_USER_TRAINING_LIST = "sproc_UserMaster_Training_Learner_LstAll";
        public const string PROC_GET_USER_ASSIGNEDTRAINING_LIST = "sproc_UserMaster_AssignedTraining_LstAll";
        public const string PROC_VIRTUALTRAINING_SESSION_ATTENDEE_LIST_UPDATE = "sproc_VirtualTrainingSessionAttendeeList_ups";
        public const string PROC_VIRTUALTRAINING_ATTENDEE_EMAIL_EXIST = "sproc_VirtualTrainingAttendeeMaster_EmailExist";
        //PARAMETER
        public const string PARA_VIRTUALTRAINING_REPORT_TRAINING_IPADDRESS = "@Training_ipAddress";
        public const string PARA_VIRTUALTRAINING_REPORT_TRAINING_CLIENTAGENT = "@Training_clientAgent";
        public const string PARA_VIRTUALTRAINING_REPORT_TRAINING_ATTENEDSTATUS = "@Training_AttendedStatus";
        public const string PARA_VIRTUALTRAINING_STARTTIME = "@startTime";
        public const string PARA_VIRTUALTRAINING_ENDTIME = "@endTime";
        public const string PARA_VIRTUALTRAINING_DURATION = "@Training_Duration";
        public const string PARA_VIRTUALTRAINING_IPADDRESS = "@Training_ipAddress";
        public const string PARA_VIRTUALTRAINING_ATTENDEE_TRAININGID = "@TrainingId";
        public const string PARA_VIRTUALTRAINING__ATTENDEE_SYSTEMUSERGUID = "@SystemUserGUID";
        public const string PARA_VIRTUALTRAINING_SESSION_KEY = "@Session_key";
        public const string PARA_VIRTUALTRAINING_ISDELETED = "@IsDeleted";
        public const string PARA_VIRTUALTRAINING_ISADMINADDED = "@IsAdminAdded";
        public const string PARA_VIRTUALTRAINING_STATUS = "@Status";
        public const string PARA_VIRTUALTRAINING_ATTENDEEID = "@AttendeeID";
        public const string PARA_VIRTUALTRAINING_APPROVEPAGE = "@VTApprovePage";
        public const string PARA_VIRTUALTRAINING_ATTENDEE_EMAILID = "@EmailID";
        
        public const string PARA_VIRTUALTRAINING_REQUESTED_BY_ID = "@requestedById";
        public const string PARA_VIRTUALTRAINING_IS_ACTIVE = "@IsActive";
        public const string PARA_VIRTUALTRAINING_REGISTERID = "@RegisterID";


        //COLUMN
        public const string COL_VIRTUALTRAINING_TRAININGID = "TrainingId";
        public const string COL_VIRTUALTRAINING_ATTENDEE_SYSTEMUSERGUID = "SystemUserGUID";
        public const string COL_VIRTUALTRAINING_SESSION_KEY = "Sessionkey";
        public const string COL_VIRTUALTRAINING_IsDeleted = "IsDeleted";

        public const string COL_VIRTUALTRAINING_ISADMINADDED = "IsAdminAdded";

        public const string COL_VIRTUALTRAINING_STATUS = "Status";
        public const string COL_VIRTUALTRAINING_ATTENDEEID = "AttendeeID";
        public const string COL_VIRTUALTRAINING_ATTENDEE_EMAILID = "EmailID";
        public const string COL_VIRTUALTRAINING_ATTENDEE_REGISTERID = "RegistrationID";
        //// Prefix
        public const string VAL_VIRTUALTRAINING_ID_PREFIX = "VARTRNATT";
    }
    #endregion

    #region Virtual Training RefMaterialMaster
    public class VirtualTrainingRefMaterialMaster
    {
        //PROCEDURES
        public const string PROC_VIRTUALTRAINING_REFMATERIALMASTER_DELETE = "sproc_VirtualTrainingRefMaterialMaster_del";
        public const string PROC_VIRTUALTRAINING_REFMATERIALMASTER_UPDATE = "sproc_VirtualTrainingRefMaterialMaster_ups";
        public const string PROC_VIRTUALTRAINING_REFMATERIALMASTER_GET_ALL = "sproc_VirtualTrainingRefMaterialMaster_LstAll";
        public const string PROC_VIRTUALTRAINING_REFMATERIALMASTER_GET = "sproc_VirtualTrainingRefMaterialMaster_sel";
        public const string PROC_VIRTUALTRAINING_REFMATERIALMASTER__BULK_UPDATE_ACTIVE = "sproc_VirtualTrainingRefMaterialMaster_ups_IsAcive";
        public const string PROC_VIRTUALTRAINING_REFMATERIALMASTER_MAPPING = "sproc_VirtualTrainingRefDoumentMapping_ups";
        public const string PROC_VIRTUALTRAINING_REFMATERIALMASTER_MAPPING_DELETE = "sproc_VirtualTrainingRefDoumentMapping_del";
        public const string PROC_VIRTUALTRAINING_REFMATERIALMASTER_MAPPING_LIST = "sproc_VirtualTrainingRefDoumentMapping_LstAll";
        public const string PROC_VIRTUALTRAINING_REFMATERIALMASTER_NON_MAPPING_LIST = "sproc_VirtualTrainingRefMaterialMasterNonMapping_LstAll";
        //PARAMETERS
        public const string PARA_VIRTUALTRAINING_REFMATERIALID = "@RefmaterialId";
        public const string PARA_VIRTUALTRAINING__REFMATERIAL_DOCUMENTNAME = "@DocumentName";
        public const string PARA_VIRTUALTRAINING__REFMATERIAL_DOCUMENTDESCRIPTION = "@DocumentDescription";
        public const string PARA_VIRTUALTRAINING__REFMATERIAL_FILENAME = "@FileName";
        public const string PARA_VIRTUALTRAINING__REFMATERIAL_ISACTIVE = "@IsActive";
        public const string PARA_VIRTUALTRAINING__REFMATERIAL_TRAININGID = "@TrainingId";

        //FIELDS
        public const string COL_VIRTUALTRAINING__REFMATERIAL_ID = "RefmaterialId";
        public const string COL_VIRTUALTRAINING__REFMATERIAL_DOCUMENTNAME = "DocumentName";
        public const string COL_VIRTUALTRAINING__REFMATERIAL_DOCUMENTDESCRIPTION = "DocumentDescription";
        public const string COL_VIRTUALTRAINING__REFMATERIAL_FILENAME = "FileName";
        public const string COL_VIRTUALTRAINING__REFMATERIAL_ISACTIVE = "IsActive";
        public const string COL_VIRTUALTRAINING__REFMATERIAL_TRAININGID = "TrainingId";

        // PREFIX
        public const string VAL_ResourceID_PREFIX = "VARTARRES";
    }
    #endregion

    #region Virtual Training User Master
    public class VirtualTrainingUserMaster
    {
        //User Master
        public const string PROC_VIRTUALTRAINING_USER_UPDATE = "sproc_VirtualTrainingUserMaster_ups";
        public const string PROC_VIRTUALTRAINING_USER_GET = "sproc_VirtualTrainingUserMaster_sel";
        public const string PROC_VIRTUALTRAINING_USER_GETALL = "sproc_VirtualTrainingUserMaster_LstAll";
        public const string PROC_VIRTUALTRAINING_WEBSERVICE_DEFAULTUSER_GET = "sproc_VirtualTrainingWebServiceDefaultUser_sel";
        public const string PROC_VIRTUALTRAINING_USER_DELETE = "sproc_VirtualTrainingUserMaster_del";
        public const string PROC_VIRTUALTRAINING_USER_AVAILABLE = "sproc_VirtualTraining_UserNameAvailable";
        public const string PROC_VIRTUALTRAINING_GET_GROUP_ADMIN_USERLIST_ALL = "sproc_VirtualTraining_GroupAdminUserList_LstAll";
        public const string PROC_VIRTUALTRAINING_GET_GROUP_ADMIN_MAPPING_USERLIST_ALL = "sproc_VirtualTraining_GroupAdminUserListMapping_LstAll";
        public const string PROC_VIRTUALTRAINING_UPDATE_GROUP_ADMIN_MAPPING_USERLIST = "sproc_VirtualTrainingGroupAdminMapping_ups";
        public const string PROC_VIRTUALTRAINING_DELETE_GROUP_ADMIN_MAPPING_USERLIST = "sproc_VirtualTrainingGroupAdminMapping_del";
        public const string PROC_VIRTUALTRAINING_USER_MAPPING_GETALL = "sproc_VirtualTrainingUserMappingMaster_LstAll";
        //User Master
        public const string PARA_VIRTUALTRAINING_USERID = "@User_Id";
        public const string PARA_VIRTUALTRAINING_SYSTEM_USERID = "@System_User_Id";
        public const string PARA_VIRTUALTRAINING_TYPE = "@Training_Type";
        public const string PARA_VIRTUALTRAINING_USER_FIRST_NAME = "@User_First_Name";
        public const string PARA_VIRTUALTRAINING_USER_LAST_NAME = "@User_Last_Name";
        public const string PARA_VIRTUALTRAINING_USER_PASSWORD = "@User_Password";
        public const string PARA_VIRTUALTRAINING_USER_SITEID = "@User_SiteId";
        public const string PARA_VIRTUALTRAINING_USER_PARTNERID = "@User_PartnerId";
        public const string PARA_VIRTUALTRAINING_XMLSERVER = "@XMLServer";
        public const string PARA_VIRTUALTRAINING_USER_ISACTIVE = "@User_IsActive";
        public const string PARA_VIRTUALTRAINING_USER_EMAIL = "@User_Email";
        public const string PARA_VIRTUALTRAINING_SYSTEMUSERID = "@VirtualSystemUserId";
        public const string PARA_VIRTUALTRAINING_USERMASTER_USERTYPEID = "@UserTypeId";
        public const string PARA_VIRTUALTRAINING_USERMASTER_SYSTEMUSERGUID = "@SystemUserGUID";
        public const string PARA_VIRTUALTRAINING_USERMASTER_VIRTUALSYSTEMUSERID = "@VirtualSystemUserID";
        //User master
        public const string COL_VIRTUALTRAINING_USER_SYSTEMUSERID = "VirtualSystemUserID";
        public const string COL_VIRTUALTRAINING_USERID = "UserId";
        public const string COL_VIRTUALTRAINING_TYPE = "Type";
        public const string COL_VIRTUALTRAINING_USER_FIRST_NAME = "FirstName";
        public const string COL_VIRTUALTRAINING_USER_LAST_NAME = "LastName";
        public const string COL_VIRTUALTRAINING_USER_PASSWORD = "Password";
        public const string COL_VIRTUALTRAINING_USER_SITEID = "SiteId";
        public const string COL_VIRTUALTRAINING_USER_PARTNERID = "PartnerId";
        public const string COL_VIRTUALTRAINING_XMLSERVER = "XMLServer";
        public const string COL_VIRTUALTRAINING_USER_EMAIL = "Email";
        public const string COL_VIRTUALTRAINING_USER_ISACTIVE = "IsActive";
        public const string COL_VIRTUALTRAINING_USERMASTER_USERTYPEID = "UserTypeId";
        public const string COL_VIRTUALTRAINING_USERMASTER_SYSTEMUSERGUID = "SystemUserGUID";
        //Prefix
        public const string VAL_VIRTUALTRAINING_USERID_PREFIX = "VIRU";
    }
    #endregion

        #region Messages
        public class Messages
        {
            //Procedure
            public const string PROC_UPDATE_MESSAGE = "sproc_Messages_ups";
            public const string PROC_UPDATE_MESSAGE_DETAILS = "sproc_MessageDetails_ups";
            public const string PROC_DELETE_MESSAGE = "sproc_Messages_del";
            public const string PROC_GET_MESSAGE = "sproc_Messages_sel";
            public const string PROC_GET_ALL_MESSAGE = "sproc_MessagesMaster_LstAll";
            public const string PROC_GET_ALL_MESSAGE_LEARNER = "sproc_MessagesMaster_LstAll_Learner";
            public const string PROC_GET_TOP10_MESSAGE_LEARNER = "sproc_MessagesMaster_Lst_Top10_Learner";
            public const string PROC_GET_MESSAGE_COUNT = "sproc_Get_Messages_Count";
            public const string PROC_GET_TOTAL_MESSAGE_COUNT = "sproc_Get_TotalMessages_Count";
            public const string PROC_GET_CUSTOM_MESSAGE_COUNT = "sproc_Get_Unread_CustomMessages_Count";
            public const string PROC_GET_SYSTEM_MESSAGE_COUNT = "sproc_Get_Unread_SystemMessages_Count";

            //PARAMETERS
            public const string PARA_MESSAGE_ID = "@MessageID";
            public const string PARA_RECIPIENT_ID = "@RecipientID";
            public const string PARA_BUSINESS_RULE_ID = "@BusinessRuleID";
            public const string PARA_MESSAGE_TITLE = "@MessageTitle";
            public const string PARA_MESSAGE_BODY = "@MessageBody";
            public const string PARA_LEARNER_ID = "@SystemUserGUID";
            public const string PARA_ISREAD = "@IsRead";
            public const string PARA_ISDELETED = "@IsDeleted";
            public const string PARA_READDATE = "@ReadDate";
            public const string PARA_ISCUSTOM_MESSAGE = "@IsCustomMessage";

            //FIELDS
            public const string COL_MESSAGE_ID = "MessageID";
            public const string COL_RECIPIENT_ID = "RecipientID";
            public const string COL_BUSINESS_RULE_ID = "BusinessRuleID";
            public const string COL_MESSAGE_TITLE = "MessageTitle";
            public const string COL_MESSAGE_BODY = "MessageBody";
            public const string COL_ISREAD = "IsRead";
            public const string COL_ISDELETED = "IsDeleted";
            public const string COL_ISCUSTOM_MESSAGE = "IsCustomMessage";
            public const string COL_READDATE = "ReadDate";
            public const string COL_USERNAMEALIAS = "UsernameAlias";
            public const string COL_RECIPIENTS = "Recipients";
            public const string COL_CUSTOM_COUNT = "CustomMsgCount";
            public const string COL_SYSTEM_COUNT = "SystemMsgCount";
        }
        #endregion

        #region MessageTemplate
        public class MessageTemplate
        {
            //Procedure
            public const string PROC_UPDATE_MESSAGETEMPLATE = "sproc_MessageTemplate_ups";
            public const string PROC_UPDATE_MESSAGE_LANGUAGE = "sproc_MessageTemplate_ups_Language";
            public const string PROC_DELETE_MESSAGETEMPLATE = "sproc_MessageTemplate_del";
            public const string PROC_DELETE_MESSAGETEMPLATE_LANGUAGES = "sproc_MessateTemplateLanguage_del";
            public const string PROC_GET_MESSAGE_TEMPLATE = "sproc_MessageTemplate_sel";
            public const string PROC_GET_ALL_MESSAGE_TEMPLATE = "sproc_MessageTemplate_LstAll";
            public const string PROC_GET_ALL_MESSAGETEMPLATE_LANGUAGE = "sproc_MessageTemplateLanguage_sel_List";

            public const string PROC_GET_ALL_MESSAGE_TEMPLATE_AUTOMAPPING = "sproc_MessageAutoMapping_LstAll";
            public const string PROC_GET_MESSAGE_TEMPLATE_AUTOMAPPING = "sproc_MessageAutoMapping_sel";


            //PARAMETERS
            public const string PARA_TEMPLATE_ID = "@TemplateID";
            public const string PARA_TEMPLATE_TITLE = "@TemplateTitle";
            public const string PARA_MESSAGE_TITLE = "@MessageTitle";
            public const string PARA_MESSAGE_BODY = "@MessageBody";
            public const string PARA_IS_DEFAULT = "@IsDefault";
            public const string PARA_IS_ACTIVE = "@IsActive";
            public const string PARA_LANGUAGE_ID = "@LanguageId";

            public const string PARA_AUTO_EVENT_ID = "@AutoEventID";

            //FIELDS
            public const string COL_TEMPLATE_ID = "TemplateID";
            public const string COL_TEMPLATE_TITLE = "TemplateTitle";
            public const string COL_MESSAGE_TITLE = "MessageTitle";
            public const string COL_MESSAGE_BODY = "MessageBody";
            public const string COL_IS_DEFAULT = "IsDefault";
            public const string COL_IS_ACTIVE = "IsActive";
            public const string COL_LANGUAGE_ID = "LanguageId";
            public const string COL_AUTO_EVENT_ID = "AutoEventID";
            public const string COL_EVENT_NAME = "EventName";
        }
        #endregion


        #region UserOfflineCourseReg
        public class UserOfflineCourseReg
        {
            //PROCEDURES
            public const string PROC_GET_USER_OFFLINE_COURSE_REG = "sproc_UserOfflineCourseReg_sel";
            public const string PROC_UPDATE_USER_OFFLINE_COURSE_REG = "sproc_UserOfflineCourseReg_ups";
            public const string PROC_GET_USER_OFFLINE_COURSE_REG_IS_ACTIVE = "sproc_UserOfflineCourseReg_sel_IsActive";
            public const string PROC_UPDATE_USER_COURSE_DOWNLOAD_LOG = "sproc_UserCourseDownloadLog_ups";
            public const string PROC_GET_ALL_OFFLINE_COURSEID = "sproc_GetAllOfflineCourseID";

            //PARAMETERS
            public const string PARA_SYSTEMUSERGUID = "@SystemUserGUID";
            public const string PARA_CLIENTID = "@ClientId";
            public const string PARA_COURSEID = "@CourseId";
            public const string PARA_REGKEY = "@RegKey";
            public const string PARA_COURSE_KEY = "@CourseKey";
            public const string PARA_REGISTRATION_DATE = "@RegistrationDate";
            public const string PARA_EXPIRY_DATE = "@ExpiryDate";
            public const string PARA_ISCOMPLETED = "@IsCompleted";
            public const string PARA_ISACTIVE = "@IsActive";

            //FIELDS
            public const string COL_SYSTEMUSERGUID = "SystemUserGUID";
            public const string COL_CLIENTID = "ClientId";
            public const string COL_COURSEID = "CourseId";
            public const string COL_REGKEY = "RegKey";
            public const string COL_COURSE_KEY = "CourseKey";
            public const string COL_REGISTRATION_DATE = "RegistrationDate";
            public const string COL_EXPIRY_DATE = "ExpiryDate";
            public const string COL_ISCOMPLETED = "IsCompleted";
            public const string COL_ISACTIVE = "IsActive";
            public const string COL_COURSE_FILE_NAME = "CourseFileName";

        }
        #endregion
        #region ClientLicenseing
        public class ClientLicense
        {
            //PROCEDURES
            public const string PROC_UPDATE_CLIENT_LICENSE = "sproc_ClientLicense_ups";
            public const string PROC_FIND_CLIENT_LICENSE_ACTIVITIES = "sproc_ClientLicenseActivities_LstAll";
            public const string PROC_GET_CLIENT_LICENSE_ACTIVITIES = "sproc_ClientLicense_sel";
            public const string PROC_GET_CLIENT_LICENSE_NOT_UPDATED = "sproc_Activity_Search_NotUpdated";
            public const string PROC_GET_CLIENT_LICENSE_UPDATED = "sproc_Activity_Search_Updated";
            public const string PROC_GET_CLIENT_LICENSE_PREVIEW = "sproc_LicenseActivities_LstAll";

            //PARAMETERS
            public const string PARA_LICENSE_ID = "@LicenseId";
            public const string PARA_LICENSE_NAME = "@LicenseName";
            public const string PARA_UNIT_ID = "@UnitId";
            public const string PARA_UNIT_NAME = "@UnitName";
            public const string PARA_IS_UNLIMITED_LICENSE = "@IsUnlimitedLicense";
            public const string PARA_LICENSE_COUNT = "@LicenseCount";
            public const string PARA_LICENSE_ALLOCATION_COUNT = "@LicenseAllocatedCount";
            public const string PARA_LICENSE_ALLOCATION_DATE = "@LicenseAllocationDate";
            public const string PARA_LICENSE_EXPIRY_DATE = "@LicenseExpiryDate";
            public const string PARA_ACTIVITY_ID = "@ActivityId";
            public const string PARA_ACTIVITY_NAME = "@ActivityName";
            public const string PARA_ACTIVITY_TYPE = "@ActivityType";
            public const string PARA_ACTIVITY_PREVIEW = "@Preview";
            public const string PARA_ACTIVITY_ASSESSMENTTIME = "@AssessmentTime";
            public const string PARA_ACTIVITY_ASSESSMENALERTTTIME = "@AssessmentAlertTime";
            public const string PARA_ACTIVITY_QUESTIONNAIRETYPE = "@QuestionnaireType";
            public const string PARA_CREATED_BY_ID = "@CreatedById";
            //FIELDS
            public const string COL_LICENSE_ID = "LicenseId";
            public const string COL_LICENSE_NAME = "LicenseName";
            public const string COL_UNIT_ID = "UnitId";
            public const string COL_UNIT_NAME = "UnitName";
            public const string COL_IS_UNLIMITED_LICENSE = "IsUnlimitedLicense";
            public const string COL_LICENSE_COUNT = "LicenseCount";
            public const string COL_LICENSE_ALLOCATION_COUNT = "LicenseAllocatedCount";
            public const string COL_LICENSE_ALLOCATION_DATE = "LicenseAllocationDate";
            public const string COL_LICENSE_EXPIRY_DATE = "LicenseExpiryDate";
            public const string COL_ACTIVITY_ID = "ActivityId";
            public const string COL_ACTIVITY_NAME = "ActivityName";
            public const string COL_ACTIVITY_TYPE = "ActivityType";
            public const string COL_ACTIVITY_PREVIEW = "Preview";
            public const string COL_ACTIVITY_ASSESSMENTTIME = "AssessmentTime";
            public const string COL_ACTIVITY_ASSESSMENALERTTTIME = "AssessmentAlertTime";
            public const string COL_ACTIVITY_QUESTIONNAIRETYPE = "QuestionnaireType";
            public const string COL_CREATED_BY_ID = "CreatedById";
        }
        #endregion

        #region ClientLicenseActivities
        public class ClientLicenseActivities
        {
            //PROCEDURES
            public const string PROC_UPDATE_CLIENT_LICENSE_ACTIVITIES = "sproc_ClientLicenseActivities_ups";
            public const string PROC_CLIENT_LICENSE_DEL = "sproc_ClientLicenseActivities_del";
            //public const string PROC_FIND_SELECTED_LICENSE_ACTIVITIES = "sproc_SelectActivities_LstAll";
            //PARAMETERS
            public const string PARA_LICENSE_ID = "@LicenseId";
            public const string PARA_ACTIVITY_ID = "@ActivityId";
            public const string PARA_ACTIVITY_TYPE_ID = "@ActivityTypeId";
            //FIELDS
            public const string COL_LICENSE_ID = "LicenseId";
            public const string COL_ACTIVITY_ID = "ActivityId";
            public const string COL_ACTIVITY_TYPE_ID = "ActivityTypeId";
        }
        #endregion
    }
