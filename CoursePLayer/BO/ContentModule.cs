
using System;
using System.Linq;
using System.Collections.Generic;

namespace HRS.CoursePlayer
{
    /// <summary>
    /// class ContentModule:BaseEntity 
    /// </summary>
   [Serializable] public class ContentModule : BaseEntity
    {
        /// <summary>
        /// Default Contructor
        ///</summary>

        public ContentModule()
        {
            //_entListContentModuleLanguages = new List<ContentModuleLanguages>();
            Sections = new Dictionary<string, CourseSection>();
        }

        /// <summary>
        /// enum ListMethod
        /// </summary>
        public new enum ListMethod
        {
            GetContentModuleList,
            GetContentModuleListAdminHome,
            AddAll,
            UpdateAll,
            BulkDelete,
            GetAllAssessmentContentModules,
            GetAllUserAssessContentModules,
            GetUserCurrentAssignedModules,
            GetContentModuleListNotCompleted
        }

        /// <summary>
        /// enum Method
        /// </summary>
        public new enum Method
        {
            FindByName,
            Get,
            GetByIDLearner,
            GetByIDCoursePlayer,
            GetContentModuleURL,
            Add,
            Update,
            GetActivityStatus
        }

        private string _strContentModuleEnglishName;
        /// <summary>
        /// Content Module Name
        /// </summary>
        public string ContentModuleEnglishName
        {
            get { return _strContentModuleEnglishName; }
            set { if (this._strContentModuleEnglishName != value) { _strContentModuleEnglishName = value; } }
        }

        private string _strContentModuleURL;
        /// <summary>
        /// Content Module URL
        /// </summary>
        public string ContentModuleURL
        {
            get { return _strContentModuleURL; }
            set { if (this._strContentModuleURL != value) { _strContentModuleURL = value; } }
        }

        public string AbsoluteFolderUrl { get; set; }

        //private List<ContentModuleLanguages> _entListContentModuleLanguages;
        ///// <summary>
        ///// List of Theme Languages
        ///// </summary>
        //public List<ContentModuleLanguages> ContentModuleLanguages
        //{
        //    get { return _entListContentModuleLanguages; }
        //    set { if (this._entListContentModuleLanguages != value) { _entListContentModuleLanguages = value; } }
        //}

        private string _strContentModuleTypeId;
        /// <summary>
        /// Content Module Type Id
        /// </summary>
        public string ContentModuleTypeId
        {
            get { return _strContentModuleTypeId; }
            set { if (this._strContentModuleTypeId != value) { _strContentModuleTypeId = value; } }
        }

        private string _strContentModuleSubTypeId;
        /// <summary>
        /// ContentModuleSubTypeId
        /// </summary>
        public string ContentModuleSubTypeId
        {
            get { return _strContentModuleSubTypeId; }
            set { if (this._strContentModuleSubTypeId != value) { _strContentModuleSubTypeId = value; } }
        }

        private bool _bIsAllocated;
        /// <summary>
        /// Is Allowcated
        /// </summary>
        public bool IsAllocated
        {
            get { return _bIsAllocated; }
            set { if (this._bIsAllocated != value) { _bIsAllocated = value; } }
        }

        private Nullable<bool> _bIsActive;
        /// <summary>
        /// Is Active
        /// </summary>
        public Nullable<bool> IsActive
        {
            get { return _bIsActive; }
            set { if (this._bIsActive != value) { _bIsActive = value; } }
        }

        private bool _bIsUploaded;
        /// <summary>
        /// Is Uploaded
        /// </summary>
        public bool IsUploaded
        {
            get { return _bIsUploaded; }
            set { if (this._bIsUploaded != value) { _bIsUploaded = value; } }
        }

        private bool _bScoreTracking;
        /// <summary>
        /// ScoreTracking
        /// </summary>
        public bool ScoreTracking
        {
            get { return _bScoreTracking; }
            set { if (this._bScoreTracking != value) { _bScoreTracking = value; } }
        }

        private bool _bQuestionResponseTracking;
        /// <summary>
        ///QuestionResponseTracking
        /// </summary>
        public bool QuestionResponseTracking
        {
            get { return _bQuestionResponseTracking; }
            set { if (this._bQuestionResponseTracking != value) { _bQuestionResponseTracking = value; } }
        }

        private int _iMasteryScore;
        /// <summary>
        /// MasteryScore
        /// </summary>
        public int MasteryScore
        {
            get { return _iMasteryScore; }
            set { if (this._iMasteryScore != value) { _iMasteryScore = value; } }
        }

        private string _strAVPath;
        /// <summary>
        /// AVPath
        /// </summary>
        public string AVPath
        {
            get { return _strAVPath; }
            set { if (this._strAVPath != value) { _strAVPath = value; } }
        }

        private bool _bCourseLaunchSameWindow;
        /// <summary>
        ///CourseLaunchSameWindow
        /// </summary>
        public bool CourseLaunchSameWindow
        {
            get { return _bCourseLaunchSameWindow; }
            set { if (this._bCourseLaunchSameWindow != value) { _bCourseLaunchSameWindow = value; } }
        }

        private bool _bCourseLaunchNewWindow;
        /// <summary>
        ///CourseLaunchNewWindow
        /// </summary>
        public bool CourseLaunchNewWindow
        {
            get { return _bCourseLaunchNewWindow; }
            set { if (this._bCourseLaunchNewWindow != value) { _bCourseLaunchNewWindow = value; } }
        }

        private bool _bAllowScroll;
        /// <summary>
        ///AllowScroll
        /// </summary>
        public bool AllowScroll
        {
            get { return _bAllowScroll; }
            set { if (this._bAllowScroll != value) { _bAllowScroll = value; } }
        }

        private bool _bAllowResize;
        /// <summary>
        ///AllowResize
        /// </summary>
        public bool AllowResize
        {
            get { return _bAllowResize; }
            set { if (this._bAllowResize != value) { _bAllowResize = value; } }
        }

        private int _iCourseWindowWidth;
        /// <summary>
        /// CourseWindowWidth
        /// </summary>
        public int CourseWindowWidth
        {
            get { return _iCourseWindowWidth; }
            set { if (this._iCourseWindowWidth != value) { _iCourseWindowWidth = value; } }
        }

        private int _iCourseWindowHeight;
        /// <summary>
        /// CourseWindowHeight
        /// </summary>
        public int CourseWindowHeight
        {
            get { return _iCourseWindowHeight; }
            set { if (this._iCourseWindowHeight != value) { _iCourseWindowHeight = value; } }
        }

        private bool _bIsPrintCertificate;
        /// <summary>
        ///IsPrintCertificate
        /// </summary>
        public bool IsPrintCertificate
        {
            get { return _bIsPrintCertificate; }
            set { if (this._bIsPrintCertificate != value) { _bIsPrintCertificate = value; } }
        }

        private bool _bIsCourseSessionNoExpiry;
        /// <summary>
        /// IsCourseSessionNoExpiry
        /// </summary>
        public bool IsCourseSessionNoExpiry
        {
            get { return _bIsCourseSessionNoExpiry; }
            set { if (this._bIsCourseSessionNoExpiry != value) { _bIsCourseSessionNoExpiry = value; } }
        }

        private string _strImanifestUrl;
        /// <summary>
        /// ImanifestUrl
        /// </summary>
        public string ImanifestUrl
        {
            get { return _strImanifestUrl; }
            set { if (this._strImanifestUrl != value) { _strImanifestUrl = value; } }
        }

        private string _strCourseGroupId;
        /// <summary>
        /// CourseGroupId
        /// </summary>
        public string CourseGroupId
        {
            get { return _strCourseGroupId; }
            set { if (this._strCourseGroupId != value) { _strCourseGroupId = value; } }
        }

        private bool _IsShortLanguageCode;
        /// <summary>
        /// Content Module Name
        /// </summary>
        public bool IsShortLanguageCode
        {
            get { return _IsShortLanguageCode; }
            set { if (this._IsShortLanguageCode != value) { _IsShortLanguageCode = value; } }
        }


        private bool _IsCourseModifiedByAdmin;
        /// <summary>
        /// Content Module Name
        /// </summary>
        public bool IsCourseModifiedByAdmin
        {
            get { return _IsCourseModifiedByAdmin; }
            set { if (this._IsCourseModifiedByAdmin != value) { _IsCourseModifiedByAdmin = value; } }
        }

		private string _protocol;

		public string Protocol
		{
			get { return _protocol; }
			set { if (this._protocol != value) { _protocol = value; } }
		}

        private bool _IsAssessment;
               public bool IsAssessment
        {
            get { return _IsAssessment; }
            set { if (this._IsAssessment != value) { _IsAssessment = value; } }
        }

        private bool _IsMiddlePage;
        public bool IsMiddlePage
        {
            get { return _IsMiddlePage; }
            set { if (this._IsMiddlePage != value) { _IsMiddlePage = value; } }
        }

       private string _systemUserGUID;
       public string SystemUserGUID
		{
            get { return _systemUserGUID; }
            set { if (this._systemUserGUID != value) { _systemUserGUID = value; } }
		}

       private bool _bIsHTML5;
       /// <summary>
       /// Is Uploaded
       /// </summary>
       public bool IsHTML5
       {
           get { return _bIsHTML5; }
           set { if (this._bIsHTML5 != value) { _bIsHTML5 = value; } }
       }


       private bool _bKeepZipFile;
       /// <summary>
       /// Is Uploaded
       /// </summary>
       public bool KeepZipFile
       {
           get { return _bKeepZipFile; }
           set { if (this._bKeepZipFile != value) { _bKeepZipFile = value; } }
       }

        /// <summary>
        /// Validate
        /// </summary>
        /// <param name="pIsUpdate"></param>
        /// <returns></returns>
        //public bool ValidateChild(bool pIsUpdate)
        //{
        //    if (pIsUpdate)
        //    {
        //        if (String.IsNullOrEmpty(ID))
        //            return false;
        //    }
        //    else
        //    {

        //        if (String.IsNullOrEmpty(ContentModuleURL))
        //            return false;

        //        if (String.IsNullOrEmpty(ContentModuleTypeId))
        //            return false;

        //        if (String.IsNullOrEmpty(ClientId))
        //            return false;


        //        if (String.IsNullOrEmpty(CreatedById))
        //            return false;
        //    }

        //    if (String.IsNullOrEmpty(LastModifiedById))
        //        return false;

        //    return true;
        //}

       public Dictionary<string, CourseSection> Sections { get; set; }

       public Lesson GetLessonById(string id)
       {
           return (from section in Sections.Values where section.Lessons.ContainsKey(id) select section.Lessons[id]).FirstOrDefault();
       }

       public int TotalLessons { get { return Sections.Values.Sum(s => s.Lessons.Count); } }

        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }

        public string CategoryId { get; set; }
        public string SubCategoryId { get; set; }
    }
}