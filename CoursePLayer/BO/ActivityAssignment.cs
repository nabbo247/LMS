
using System;
using System.ComponentModel;
namespace HRS.CoursePlayer
{
    /// <summary>
    ///  Serializable class ActivityAssignment:BaseEntity 
    /// </summary>
    [Serializable]
   public class ActivityAssignment : BaseEntity
    {
        /// <summary>
        /// Default Contructor
        /// </summary>
        public ActivityAssignment()
        { }

        /// <summary>
        ///  enum ListMethod
        /// </summary>
        public new enum ListMethod
        {
            GetAssignmentList,
            AddAll,
            BulkImportAssignment,
            EditSelected,
            GetActivityAssignments,
            FindActivityListByName,
            FindActivityListByNameOptimized,
            FindActivityForMarkCompletion,
            FindActivityForMarkCompletionOptimized,
            GetUserAssignmentForMark,
            GetCurrentAttempts,
            GetPreviousAttempts,
            GetUserAssignmentsForEdit,
            FindActivityForAssignment,
            FindActivityListForDelequencyHistory,
            GetUserAssignmentListForEmail,
            GetUserAssignmentListForEmailTemplate,
			FindActivityListForPendingReview,
            GetInnerActivity,
            GetAllActivityByCategoryMapping
        }

        /// <summary>
        /// enum Method
        /// </summary>
        public new enum Method
        {
            Get,
            Add,
            Update,
            GetActivityForPrint,
            CheckAssignment,
            CheckAssignmentOptimized,
            GroupEditAssignment,
            UnAssignByActivityId,
            CheckAssignment_CoursePlayer,
            IsProductLicenseExceed,
            GetCoursesCount
           
        }

        private ActivityAssignmentMode _strAssignmentModeForOverride;
        private ActivityAssignmentType _strAssignmentTypeId;
        private string _strRuleId;
        private string _strLicenseId;
        private Nullable<bool> _bIsCurrentlyAssigned;
        private bool _bIsEditfromUI;
      
        private string _strUserID;
        /// <summary>
        /// UserID
        /// </summary>
        public string UserID
        {
            get { return _strUserID; }
            set { if (this._strUserID != value) { _strUserID = value; } }
        }

        private string _strUserName;
        /// <summary>
        /// UserName
        /// </summary>
        public string UserName
        {
            get { return _strUserName; }
            set { if (this._strUserName != value) { _strUserName = value; } }
        }

        private ActivityCompletionCondition _strCompletionCondition;
        /// <summary>
        /// Completion Condition
        /// </summary>
        public ActivityCompletionCondition CompletionCondition
        {
            get { return _strCompletionCondition; }
            set { if (this._strCompletionCondition != value) { _strCompletionCondition = value; } }
        }

        private string _strActivityName;
        /// <summary>
        /// Activity Name
        /// </summary>
        public string ActivityName
        {
            get { return _strActivityName; }
            set { if (this._strActivityName != value) { _strActivityName = value; } }
        }

        //
        private string _strActivityID;
        public string ActivityID
        {
            get { return _strActivityID; }
            set { if (this._strActivityID != value) { _strActivityID = value; } }
        }
        //
        private string _strActivityDesc;
        /// <summary>
        /// Activity Description
        /// </summary>
        public string ActivityDescription
        {
            get { return _strActivityDesc; }
            set { if (this._strActivityDesc != value) { _strActivityDesc = value; } }
        }

        private string _strActivitySubTypeID;
        /// <summary>
        /// Activity Name
        /// </summary>
         public string ActivitySubTypeID
        {
            get { return _strActivitySubTypeID; }
            set { if (this._strActivitySubTypeID != value) { _strActivitySubTypeID = value; } }
        }        

        private string _strActivityURL;
        /// <summary>
        /// Activity URL
        /// </summary>
        public string ActivityURL
        {
            get { return _strActivityURL; }
            set { if (this._strActivityURL != value) { _strActivityURL = value; } }
        }

        private ActivityCompletionStatus _strActivityStatus;
        /// <summary>
        /// Activity Status
        /// </summary>
        public ActivityCompletionStatus ActivityStatus
        {
            get { return _strActivityStatus; }
            set { if (this._strActivityStatus != value) { _strActivityStatus = value; } }
        }

        private string  _strAssignmentStatus;
        public string AssignmentStatus 
        {
            get { return _strAssignmentStatus; }
            set { if (this._strAssignmentStatus != value) { _strAssignmentStatus = value; } }
        }


        private DateTime _dateOfStart;
        /// <summary>
        /// Date Of Start
        /// </summary>
        public DateTime DateOfStart
        {
            get { return _dateOfStart; }
            set { if (this._dateOfStart != value) { _dateOfStart = value; } }
        }

        private DateTime _dateOfCompletion;
        /// <summary>
        /// Date Of Completion
        /// </summary>
        public DateTime DateOfCompletion
        {
            get { return _dateOfCompletion; }
            set { if (this._dateOfCompletion != value) { _dateOfCompletion = value; } }
        }

        private DateTime _assignmentDateOfCompletion;
        /// <summary>
        /// Date Of Completion
        /// </summary>
        public DateTime AssignmentDateOfCompletion
        {
            get { return _assignmentDateOfCompletion; }
            set { if (this._assignmentDateOfCompletion != value) { _assignmentDateOfCompletion = value; } }
        }

        private ActivityContentType _strActivityType;
        /// <summary>
        /// Activity Type
        /// </summary>
        public ActivityContentType ActivityType
        {
            get { return _strActivityType; }
            set { if (this._strActivityType != value) { _strActivityType = value; } }
        }

        private bool _bIsPrintCertificate;
        /// <summary>
        /// To know the Print Certificate is allowed or not
        /// </summary>
        public bool IsPrintCertificate
        {
            get { return _bIsPrintCertificate; }
            set { if (this._bIsPrintCertificate != value) { _bIsPrintCertificate = value; } }
        }
        private string _strAssignmentMode;
        public string AssignmentMode
        {
            get { return _strAssignmentMode; }
            set { if (this._strAssignmentMode != value) { _strAssignmentMode = value; } }
        }
       
        private int _iAttemptCount;
        /// <summary>
        /// Totot Attempts 
        /// </summary>
        public int AttemptCount
        {
            get { return _iAttemptCount; }
            set { if (this._iAttemptCount != value) { _iAttemptCount = value; } }
        }

        private bool _IsOverridePreviousAssignments;
        public bool OverridePreviousAssignments
        {
            get { return _IsOverridePreviousAssignments; }
            set { if (this._IsOverridePreviousAssignments != value) { _IsOverridePreviousAssignments = value; } }
        }

        private string _strPreviousAssignmentId;
        public string PreviousAssignmentId
        {
            get { return _strPreviousAssignmentId; }
            set { if (this._strPreviousAssignmentId != value) { _strPreviousAssignmentId = value; } }
        }

        /*** Added by Bajirao for Course Count and Curriculum Percentage ***/
        private int _iTotalRowsCompleted;
        /// <summary>
        /// Totot Attempts 
        /// </summary>
        public int TotalRowsCompleted
        {
            get { return _iTotalRowsCompleted; }
            set { if (this._iTotalRowsCompleted != value) { _iTotalRowsCompleted = value; } }
        }

        private int _iTotalRowsAssigned;
        /// <summary>
        /// Totot Attempts 
        /// </summary>
        public int TotalRowsAssigned
        {
            get { return _iTotalRowsAssigned; }
            set { if (this._iTotalRowsAssigned != value) { _iTotalRowsAssigned = value; } }
        }

        private decimal _iCurriculumCompletionPercentage;
        /// <summary>
        /// Totot Attempts 
        /// </summary>
        public decimal CurriculumCompletionPercentage
        {
            get { return _iCurriculumCompletionPercentage; }
            set { if (this._iCurriculumCompletionPercentage != value) { _iCurriculumCompletionPercentage = value; } }
        }
        /*** End of - Added by Bajirao for Course Count and Curriculum Percentage ***/


        //***** Actual AssignmentTable Fields

        private string _strActivityMode;
        public string ActivityMode
        {
            get { return _strActivityMode; }
            set { if (this._strActivityMode != value) { _strActivityMode = value; } }
        }
        
        private string _strActivityTypeId;
        /// <summary>
        /// Activity Type Id
        /// </summary>
        public string ActivityTypeId
        {
            get { return _strActivityTypeId; }
            set { if (this._strActivityTypeId != value) { _strActivityTypeId = value; } }
        }
        private ActivityCompletionCondition _strCompletionConditionId;
        /// <summary>
        /// Completion Condition Id
        /// </summary>
        public ActivityCompletionCondition CompletionConditionId
        {
            get { return _strCompletionConditionId; }
            set { if (this._strCompletionConditionId != value) { _strCompletionConditionId = value; } }
        }
       
        public ActivityAssignmentMode AssignmentModeForOverride
        {
            get { return _strAssignmentModeForOverride; }
            set { if (this._strAssignmentModeForOverride != value) { _strAssignmentModeForOverride = value; } }
        }
        public ActivityAssignmentType AssignmentTypeId
        {
            get { return _strAssignmentTypeId; }
            set { if (this._strAssignmentTypeId != value) { _strAssignmentTypeId = value; } }
        }
        public string RuleId
        {
            get { return _strRuleId; }
            set { if (this._strRuleId != value) { _strRuleId = value; } }
        }
        public string LicenseId
        {
            get { return _strLicenseId; }
            set { if (this._strLicenseId != value) { _strLicenseId = value; } }
        }
        public Nullable<bool> IsCurrentlyAssigned
        {
            get { return _bIsCurrentlyAssigned; }
            set { if (this._bIsCurrentlyAssigned != value) { _bIsCurrentlyAssigned = value; } }
        }
        public bool IsEditfromUI
        {
            get { return _bIsEditfromUI; }
            set { if (this._bIsEditfromUI != value) { _bIsEditfromUI = value; } }
        }

        private bool _bIsAssignmentBasedOnHireDate;
        public bool IsAssignmentBasedOnHireDate
        {
            get { return _bIsAssignmentBasedOnHireDate; }
            set { if (this._bIsAssignmentBasedOnHireDate != value) { _bIsAssignmentBasedOnHireDate = value; } }
        }
        private bool _bIsAssignmentBasedOnCreationDate;
        public bool IsAssignmentBasedOnCreationDate
        {
            get { return _bIsAssignmentBasedOnCreationDate; }
            set { if (this._bIsAssignmentBasedOnCreationDate != value) { _bIsAssignmentBasedOnCreationDate = value; } }
        }
        private int _iAssignAfterDaysOf;
        public int AssignAfterDaysOf
        {
            get { return _iAssignAfterDaysOf; }
            set { if (this._iAssignAfterDaysOf != value) { _iAssignAfterDaysOf = value; } }
        }
        private DateTime _assignmentDateSet;
        public DateTime AssignmentDateSet
        {
            get { return _assignmentDateSet; }
            set { if (this._assignmentDateSet != value) { _assignmentDateSet = value; } }
        }

        private bool _bIsNoDueDate;
        public bool IsNoDueDate
        {
            get { return _bIsNoDueDate; }
            set { if (this._bIsNoDueDate != value) { _bIsNoDueDate = value; } }
        }
        private bool _bIsDueBasedOnAssignDate;
        public bool IsDueBasedOnAssignDate
        {
            get { return _bIsDueBasedOnAssignDate; }
            set { if (this._bIsDueBasedOnAssignDate != value) { _bIsDueBasedOnAssignDate = value; } }
        }
        private bool _bIsDueBasedOnHireDate;
        public bool IsDueBasedOnHireDate
        {
            get { return _bIsDueBasedOnHireDate; }
            set { if (this._bIsDueBasedOnHireDate != value) { _bIsDueBasedOnHireDate = value; } }
        }
        private bool _bIsDueBasedOnCreationDate;
        public bool IsDueBasedOnCreationDate
        {
            get { return _bIsDueBasedOnCreationDate; }
            set { if (this._bIsDueBasedOnCreationDate != value) { _bIsDueBasedOnCreationDate = value; } }
        }

        private bool _bIsDueBasedOnStartDate;
        public bool IsDueBasedOnStartDate
        {
            get { return _bIsDueBasedOnStartDate; }
            set { if (this._bIsDueBasedOnStartDate != value) { _bIsDueBasedOnStartDate = value; } }
        }
        private int _iDueAfterDaysOf;
        public int DueAfterDaysOf
        {
            get { return _iDueAfterDaysOf; }
            set { if (this._iDueAfterDaysOf != value) { _iDueAfterDaysOf = value; } }
        }
       
        private DateTime _dateDueSet;
        public DateTime DueDateSet
        {
            get { return _dateDueSet; }
            set { if (this._dateDueSet != value) { _dateDueSet = value; } }
        }

        private bool _bIsNoExpiryDate;
        public bool IsNoExpiryDate
        {
            get { return _bIsNoExpiryDate; }
            set { if (this._bIsNoExpiryDate != value) { _bIsNoExpiryDate = value; } }
        }

        private bool _bIsExpiryBasedOnAssignDate;
        public bool IsExpiryBasedOnAssignDate
        {
            get { return _bIsExpiryBasedOnAssignDate; }
            set { if (this._bIsExpiryBasedOnAssignDate != value) { _bIsExpiryBasedOnAssignDate = value; } }
        }

        private bool _bIsExpiryBasedOnStartDate;
        public bool IsExpiryBasedOnStartDate
        {
            get { return _bIsExpiryBasedOnStartDate; }
            set { if (this._bIsExpiryBasedOnStartDate != value) { _bIsExpiryBasedOnStartDate = value; } }
        }

        private bool _bIsExpiryBasedOnDueDate;
        public bool IsExpiryBasedOnDueDate
        {
            get { return _bIsExpiryBasedOnDueDate; }
            set { if (this._bIsExpiryBasedOnDueDate != value) { _bIsExpiryBasedOnDueDate = value; } }
        }
        private int _iExpireAfterDaysOf;
        public int ExpireAfterDaysOf
        {
            get { return _iExpireAfterDaysOf; }
            set { if (this._iExpireAfterDaysOf != value) { _iExpireAfterDaysOf = value; } }
        }
        private DateTime _dateExpirySet;
        public DateTime ExpiryDateSet
        {
            get { return _dateExpirySet; }
            set { if (this._dateExpirySet != value) { _dateExpirySet = value; } }
        }
       
        private bool _bSendEmail;
        public bool SendEmail
        {
            get { return _bSendEmail; }
            set { if (this._bSendEmail != value) { _bSendEmail = value; } }
        }

        private string _strSendEmailType;
        public string SendEmailType
        {
            get { return _strSendEmailType; }
            set { if (this._strSendEmailType != value) { _strSendEmailType = value; } }
        }
        
        private string _strEmailTemplateId;
        public string EmailTemplateId
        {
            get { return _strEmailTemplateId; }
            set { if (this._strEmailTemplateId != value) { _strEmailTemplateId = value; } }
        }

        //-- New Properties for Re-Assignment

        private bool _bIsReAssignmentBasedOnAssignmentDate;
        public bool IsReAssignmentBasedOnAssignmentDate
        {
            get { return _bIsReAssignmentBasedOnAssignmentDate; }
            set { if (this._bIsReAssignmentBasedOnAssignmentDate != value) { _bIsReAssignmentBasedOnAssignmentDate = value; } }
        }

        private bool _bIsReAssignmentBasedOnAssignmentCompletionDate;
        public bool IsReAssignmentBasedOnAssignmentCompletionDate
        {
            get { return _bIsReAssignmentBasedOnAssignmentCompletionDate; }
            set { if (this._bIsReAssignmentBasedOnAssignmentCompletionDate != value) { _bIsReAssignmentBasedOnAssignmentCompletionDate = value; } }
        }

        private int _iReassignmentCount;
        /// <summary>
        /// Reassignment Count
        /// </summary>
        public int ReassignmentCount
        {
            get { return _iReassignmentCount; }
            set { if (this._iReassignmentCount != value) { _iReassignmentCount = value; } }
        }

        private int _iReAssignAfterDaysOf;
        /// <summary>
        /// Reassignment after days of 
        /// </summary>
        public int ReAssignAfterDaysOf
        {
            get { return _iReAssignAfterDaysOf; }
            set { if (this._iReAssignAfterDaysOf != value) { _iReAssignAfterDaysOf = value; } }
        }
        private DateTime _reAssignmentDateSet;
        /// <summary>
        /// ReAssignment Data Set
        /// </summary>
        public DateTime ReAssignmentDateSet
        {
            get { return _reAssignmentDateSet; }
            set { if (this._reAssignmentDateSet != value) { _reAssignmentDateSet = value; } }
        }
        private bool _bIsReassignNoDueDate;
        /// <summary>
        /// iS no Due Date
        /// </summary>
        public bool IsReassignNoDueDate
        {
            get { return _bIsReassignNoDueDate; }
            set { if (this._bIsReassignNoDueDate != value) { _bIsReassignNoDueDate = value; } }
        }

        private bool _bIsReassignDueBasedOnAssignmentCompletionDate;
        public bool IsReassignDueBasedOnAssignmentCompletionDate
        {
            get { return _bIsReassignDueBasedOnAssignmentCompletionDate; }
            set { if (this._bIsReassignDueBasedOnAssignmentCompletionDate != value) { _bIsReassignDueBasedOnAssignmentCompletionDate = value; } }
        }

        private bool _bIsReassignDueBasedOnReassignmentDate;
        public bool IsReassignDueBasedOnReassignmentDate
        {
            get { return _bIsReassignDueBasedOnReassignmentDate; }
            set { if (this._bIsReassignDueBasedOnReassignmentDate != value) { _bIsReassignDueBasedOnReassignmentDate = value; } }
        }

        private int _iReassignDueAfterDaysOf;
        /// <summary>
        /// Reassignment Due After Days of 
        /// </summary>
        public int ReassignDueAfterDaysOf
        {
            get { return _iReassignDueAfterDaysOf; }
            set { if (this._iReassignDueAfterDaysOf != value) { _iReassignDueAfterDaysOf = value; } }
        }
        private DateTime _reassignDueDateSet;
        /// <summary>
        /// ReAssignment Due Date
        /// </summary>
        public DateTime ReassignDueDateSet
        {
            get { return _reassignDueDateSet; }
            set { if (this._reassignDueDateSet != value) { _reassignDueDateSet = value; } }
        }

        private bool _bIsReassignNoExpiryDate;
        /// <summary>
        /// Is No Expiry Date for ReAssignment 
        /// </summary>
        public bool IsReassignNoExpiryDate
        {
            get { return _bIsReassignNoExpiryDate; }
            set { if (this._bIsReassignNoExpiryDate != value) { _bIsReassignNoExpiryDate = value; } }
        }

        private bool _bIsReassignExpiryBasedOnReassignmentDueDate;
        public bool IsReassignExpiryBasedOnReassignmentDueDate
        {
            get { return _bIsReassignExpiryBasedOnReassignmentDueDate; }
            set { if (this._bIsReassignExpiryBasedOnReassignmentDueDate != value) { _bIsReassignExpiryBasedOnReassignmentDueDate = value; } }
        }

        private bool _bIsReassignExpiryBasedOnReassignmentDate;
        public bool IsReassignExpiryBasedOnReassignmentDate
        {
            get { return _bIsReassignExpiryBasedOnReassignmentDate; }
            set { if (this._bIsReassignExpiryBasedOnReassignmentDate != value) { _bIsReassignExpiryBasedOnReassignmentDate = value; } }
        }

        private bool _bIsReassignExpiryBasedOnAssignmentCompletionDate;
        public bool IsReassignExpiryBasedOnAssignmentCompletionDate
        {
            get { return _bIsReassignExpiryBasedOnAssignmentCompletionDate; }
            set { if (this._bIsReassignExpiryBasedOnAssignmentCompletionDate != value) { _bIsReassignExpiryBasedOnAssignmentCompletionDate = value; } }
        }

        private int _iReassignExpireAfterDaysOf;
        /// <summary>
        /// Expiry after days for Reassignment
        /// </summary>
        public int ReassignExpireAfterDaysOf
        {
            get { return _iReassignExpireAfterDaysOf; }
            set { if (this._iReassignExpireAfterDaysOf != value) { _iReassignExpireAfterDaysOf = value; } }
        }

        private DateTime _reassignExpiryDateSet;
        /// <summary>
        /// Expiry Date for Reassignment
        /// </summary>
        public DateTime ReassignExpiryDateSet
        {
            get { return _reassignExpiryDateSet; }
            set { if (this._reassignExpiryDateSet != value) { _reassignExpiryDateSet = value; } }
        }
     
        private string _strParaLanguageId;
        /// <summary>
        /// Language Id for Parameter
        /// </summary>
        public string ParaLanguageId
        {
            get { return _strParaLanguageId; }
            set { if (this._strParaLanguageId != value) { _strParaLanguageId = value; } }
        }

        private bool _bIsActiveActivity;
        /// <summary>
        /// Activity Is Active
        /// </summary>
        public bool IsActiveActivity
        {
            get { return _bIsActiveActivity; }
            set { if (this._bIsActiveActivity != value) { _bIsActiveActivity = value; } }
        }

        private string _strUserDataXML;
        /// <summary>
        /// User Data XML
        /// </summary>
        public string UserDataXML
        {
            get { return _strUserDataXML; }
            set { if (this._strUserDataXML != value) { _strUserDataXML = value; } }
        }

        private string _strReviewerComments;
        /// <summary>
        /// ReviewerComments
        /// </summary>
        public string ReviewerComments
        {
            get { return _strReviewerComments; }
            set { if (this._strReviewerComments != value) { _strReviewerComments = value; } }
        }

        private string _strAttemptId;
        /// <summary>
        /// AttemptId
        /// </summary>
        public string AttemptId
        {
            get { return _strAttemptId; }
            set { if (this._strAttemptId != value) { _strAttemptId = value; } }
        }

        private bool _isAdminAssignment;
        public bool IsAdminAssignment
        {
            get { return _isAdminAssignment; }
            set { if (this._isAdminAssignment != value) { _isAdminAssignment = value; } }
        }

        private bool _bIsForAdminPreview;
        public bool IsForAdminPreview
        {
            get { return _bIsForAdminPreview; }
            set { if (this._bIsForAdminPreview != value) { _bIsForAdminPreview = value; } }
        }

        private string _strDisplayActivityStatus;
        /// <summary>
        /// Display Activity Status
        /// </summary>
        public string DisplayActivityStatus
        {
            get { return _strDisplayActivityStatus; }
            set { if (this._strDisplayActivityStatus != value) { _strDisplayActivityStatus = value; } }
        }

        private string _strScore;
        /// <summary>
        /// Display Score
        /// </summary>
        public string Score
        {
            get { return _strScore; }
            set { if (this._strScore != value) { _strScore = value; } }
        }

        private DateTime _assignFromDate;
        /// <summary>
        /// ReAssignment Due Date
        /// </summary>
        public DateTime AssignFromDate
        {
            get { return _assignFromDate; }
            set { if (this._assignFromDate != value) { _assignFromDate = value; } }
        }
        private DateTime _assignToDate;
        /// <summary>
        /// ReAssignment Due Date
        /// </summary>
        public DateTime AssignToDate
        {
            get { return _assignToDate; }
            set { if (this._assignToDate != value) { _assignToDate = value; } }
        }


        private bool _bForceReAssignment;
        /// <summary>
        /// To know the Print Certificate is allowed or not
        /// </summary>
        public bool ForceReAssignment
        {
            get { return _bForceReAssignment; }
            set { if (this._bForceReAssignment != value) { _bForceReAssignment = value; } }
        }

        public bool Validate(bool pIsUpdate)
        {
            
            if (String.IsNullOrEmpty(UserID))
                return false;

            if (String.IsNullOrEmpty(ID))
                return false;

            if (String.IsNullOrEmpty(LastModifiedById))
                return false;

            if (!pIsUpdate)
            {
                if (String.IsNullOrEmpty(ActivityTypeId))
                    return false;

                if (String.IsNullOrEmpty(CompletionConditionId.ToString()))
                    return false;
            }

            return true;
        }
        //added by Gitanjali 16.10.2010
        private string _strCustomReportId;
        public string CustomReportId
        {
            get { return _strCustomReportId; }
            set { if (this._strCustomReportId != value) { _strCustomReportId = value; } }
        }

        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public string CategoryId { get; set; }
        public string SubCategoryId { get; set; }
    }

    public enum ActivityContentType
    { 
        None,
        [Description("Scorm 1.2")]
        Scorm12,
        [Description("Scorm 2004")]
        Scorm2004,
        AICC,
        [Description("Non Compliant")]
        NonCompliant,
        Curriculum,
        Asset,
        Certification,
        Policy,
        Questionnaire,
        Course,
        Assessment
    }
    public enum ActivityAssignmentType
    {
        OneTimeAssignment,
        DynamicAssignment
    }
    public enum ActivityAssignmentMode
    {
        UI,
        BulkImport,
        BusinessRule,
        DefaultCourse
    }
    public enum ActivityCompletionCondition
    {
        Optional,
        Mandatory
    }
    public enum ActivityCompletionStatus
    {
        None,
        Completed,
        Started,
        [Description("Not Started")]
        NotStarted,
        [Description("In Progress")]
        InProgress,
        [Description("Pending Review")]
        PendingReview,
        [Description("Not Completed")]
        NotCompleted,
        [Description("Completed By Admin")]
        CompletedByAdmin,
        [Description("Completed By Proxy")]
        CompletedByProxy,
        [Description("Failed")]
        Failed
    }
    public enum MarkCompletionStatus
    {
       Completed,
       NotCompleted
    }
    
       
    
}