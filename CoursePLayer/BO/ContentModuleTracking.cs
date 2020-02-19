
using System;
using System.Collections.Generic;
namespace HRS.CoursePlayer
{ 
    /// <summary>
    /// class ContentModuleTracking:BaseEntity  
    /// </summary>
   [Serializable] public class ContentModuleTracking : BaseEntity
    {
        /// <summary>
        /// Default Contructor
        /// </summary>
        public ContentModuleTracking()
        { 
			ExtendExpirationMinutes = 120;
		}

        /// <summary>
        ///  enum Method
        /// </summary>
        public new enum Method
        {
            Get,
            GetUserDataXML,
            GetStatusByID,
            Add,
            Update,
            UpdateScannedFileName,
            GenerateLog
        }

        /// <summary>
        /// enum ListMethod
        /// </summary>
        public new enum ListMethod
        {
            MarkCompleted,
            BulkMarkCompleted
        }

        private string _strContentModuleId;
        /// <summary>
        /// Content Module Id
        /// </summary>
        public string ContentModuleId
        {
            get { return _strContentModuleId; }
            set { if (this._strContentModuleId != value) { _strContentModuleId = value; } }
        }

        private string _strLearnerId;
        /// <summary>
        /// Content Module Id
        /// </summary>
        public string LearnerId
        {
            get { return _strLearnerId; }
            set { if (this._strLearnerId != value) { _strLearnerId = value; } }
        }

        private bool _IsResumes;
        public bool  IsResume
        {
            get { return _IsResumes; }
            set { if (this._IsResumes != value) { _IsResumes = value; } }
        }    


        private string _strUserID;
        /// <summary>
        /// User ID
        /// </summary>
        public string UserID
        {
            get { return _strUserID; }
            set { if (this._strUserID != value) { _strUserID = value; } }
        }

        public string ContentType { get; set; }

        private DateTime _dateOfStart;
        /// <summary>
        /// Date Of Start
        /// </summary>
        public DateTime DateOfStart
        {
            get { return _dateOfStart; }
            set { if (this._dateOfStart != value) { _dateOfStart = value; } }
        }

        private Nullable<DateTime> _dateOfCompletion;
        /// <summary>
        /// DateOfCompletion
        /// </summary>
        public Nullable<DateTime> DateOfCompletion
        {
            get { return _dateOfCompletion; }
            set { if (this._dateOfCompletion != value) { _dateOfCompletion = value; } }
        }

        private int _iTotalNoOfPages;
        /// <summary>
        /// Total No Of Pages
        /// </summary>
        public int TotalNoOfPages
        {
            get { return _iTotalNoOfPages; }
            set { if (this._iTotalNoOfPages != value) { _iTotalNoOfPages = value; } }
        }

        private int _iNoOfPagesCompleted;
        /// <summary>
        /// No Of Pages Completed
        /// </summary>
        public int NoOfPagesCompleted
        {
            get { return _iNoOfPagesCompleted; }
            set { if (this._iNoOfPagesCompleted != value) { _iNoOfPagesCompleted = value; } }
        }

        private ActivityCompletionStatus _strCompletionStatus;
        /// <summary>
        /// Completion Status
        /// </summary>
        public ActivityCompletionStatus CompletionStatus
        {
            get { return _strCompletionStatus; }
            set { if (this._strCompletionStatus != value) { _strCompletionStatus = value; } }
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

        private string _strScore;
        /// <summary>
        /// Score
        /// </summary>
        public string Score
        {
            get { return _strScore; }
            set { if (this._strScore != value) { _strScore = value; } }
        }

        private string _strMarkedCompletedById;
        /// <summary>
        /// Marked Completed By Id
        /// </summary>
        public string MarkedCompletedById
        {
            get { return _strMarkedCompletedById; }
            set { if (this._strMarkedCompletedById != value) { _strMarkedCompletedById = value; } }
        }

        private string _strScannedCertificationFileName;
        /// <summary>
        /// Scanned Certification File Name
        /// </summary>
        public string ScannedCertificationFileName
        {
            get { return _strScannedCertificationFileName; }
            set { if (this._strScannedCertificationFileName != value) { _strScannedCertificationFileName = value; } }
        }

        private string _strActivityName;
        /// <summary>
        /// Activity Name : Read only
        /// </summary>
        public string ActivityName
        {
            set { if (this._strActivityName != value) { _strActivityName = value; } }
        }

        public string ActivityId { get; set; }

        private string _strUserFirstLastName;
        /// <summary>
        /// User First and Last Name : Read only
        /// </summary>
        public string UserFirstLastName
        {
            set { if (this._strUserFirstLastName != value) { _strUserFirstLastName = value; } }
            get { return _strUserFirstLastName; }
        }

        private string _strRegionViewInfo;
        /// <summary>
        /// Region View Info
        /// </summary>
        public string RegionViewInfo
        {
            get { return _strRegionViewInfo; }
            set { if (this._strRegionViewInfo != value) { _strRegionViewInfo = value; } }
        }

        private string _strReviewComments;
        /// <summary>
        /// Review Comments
        /// </summary>
        public string ReviewComments
        {
            get { return _strReviewComments; }
            set { if (this._strReviewComments != value) { _strReviewComments = value; } }
        }
        private string _strVendorCode;
        /// <summary>
        /// Review Comments
        /// </summary>
        public string VendorCode
        {
            get { return _strVendorCode; }
            set { if (this._strVendorCode != value) { _strVendorCode = value; } }
        }

        private bool _strIsForAdminPreview;
        /// <summary>
        /// Is For Admin Preview
        /// </summary>
        public  bool IsForAdminPreview
        {
            get { return _strIsForAdminPreview; }
            set { if (this._strIsForAdminPreview != value) { _strIsForAdminPreview = value; } }
        }

        private bool _strIsBulkMarkCompleted;
        /// <summary>
        /// Is Bulk Mark Completed
        /// </summary>
        public bool IsBulkMarkCompleted
        {
            get { return _strIsBulkMarkCompleted; }
            set { if (this._strIsBulkMarkCompleted != value) { _strIsBulkMarkCompleted = value; } }
        }
        
        public string SessionId { get; set; }

        public bool CheckExpiredSession { get; set; }
        public int ExtendExpirationMinutes { get; set; }
        
        public bool IsCompleted()
        {
            return CompletionStatus == ActivityCompletionStatus.Completed ||
                   CompletionStatus == ActivityCompletionStatus.CompletedByProxy ||
                   CompletionStatus == ActivityCompletionStatus.CompletedByAdmin;
        }

        public Dictionary<string, LessonTracking> LessonTracking { get; set; }

        public string Bookmark { get; set; }

        /// <summary>
        /// Validate
        /// </summary>
        /// <param name="pIsUpdate"></param>
        /// <returns></returns>
        public bool Validate(bool pIsUpdate)
        {
            if (String.IsNullOrEmpty(ContentModuleId))
                return false;

            if (String.IsNullOrEmpty(UserID))
                return false;

            if (!pIsUpdate)
            {
                if (DateTime.MinValue.CompareTo(DateOfStart) > 0)
                    return false;

                if (String.IsNullOrEmpty(CompletionStatus.ToString()))
                    return false;
            }
            return true;
        }
    }
}