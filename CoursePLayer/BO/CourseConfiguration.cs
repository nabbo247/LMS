
using System.Collections.Generic;
using System;

namespace HRS.CoursePlayer
{
    /// <summary>
    /// 
    /// </summary>
   [Serializable] public class CourseConfiguration : BaseEntity
    {
        /// <summary>
        /// Default Contructor
        /// <summary>
        public CourseConfiguration()
        { }

        /// <summary>
        /// enum Method
        /// </summary>
        public new enum Method
        {
            Get,
            GetAVPath,
            GetMasteryScore,
            Update,
        }

        private bool _isCourseSessionNoExpiry;
        /// <summary>
        /// Course Session No Expiry
        /// </summary>
        public bool IsCourseSessionNoExpiry
        {
            get { return _isCourseSessionNoExpiry; }
            set { if (this._isCourseSessionNoExpiry != value) { _isCourseSessionNoExpiry = value; } }
        }

        private int _maxFileUploadSizeMB;
        /// <summary>
        /// Max File Upload Size
        /// </summary>
        public int MaxFileUploadSizeMB
        {
            get { return _maxFileUploadSizeMB; }
            set { if (this._maxFileUploadSizeMB != value) { _maxFileUploadSizeMB = value; } }
        }

        private bool _scoreTracking;
        /// <summary>
        /// Score tracking
        /// </summary>
        public bool ScoreTracking
        {
            get { return _scoreTracking; }
            set { if (this._scoreTracking != value) { _scoreTracking = value; } }
        }

        private bool _questionResponseTracking;
        /// <summary>
        /// Question Response Tracking
        /// </summary>
        public bool QuestionResponseTracking
        {
            get { return _questionResponseTracking; }
            set { if (this._questionResponseTracking != value) { _questionResponseTracking = value; } }
        }

        private int _masteryScore;
        /// <summary>
        /// Mastery Score
        /// </summary>
        public int MasteryScore
        {
            get { return _masteryScore; }
            set { if (this._masteryScore != value) { _masteryScore = value; } }
        }

        private string _aVPath;
        /// <summary>
        /// AVPath
        /// </summary>
        public string AVPath
        {
            get { return _aVPath; }
            set { if (this._aVPath != value) { _aVPath = value; } }
        }

        private bool _courseLaunchSameWindow;
        /// <summary>
        /// Course Launch Same Window
        /// </summary>
        public bool CourseLaunchSameWindow
        {
            get { return _courseLaunchSameWindow; }
            set { if (this._courseLaunchSameWindow != value) { _courseLaunchSameWindow = value; } }
        }

        private bool _courseLaunchNewWindow;
        /// <summary>
        /// Course launch New Window
        /// </summary>
        public bool CourseLaunchNewWindow
        {
            get { return _courseLaunchNewWindow; }
            set { if (this._courseLaunchNewWindow != value) { _courseLaunchNewWindow = value; } }
        }

        private bool _allowScroll;
        /// <summary>
        /// Allow Scroll
        /// </summary>
        public bool AllowScroll
        {
            get { return _allowScroll; }
            set { if (this._allowScroll != value) { _allowScroll = value; } }
        }

        private bool _allowResize;
        /// <summary>
        /// Allow Re-size
        /// </summary>
        public bool AllowResize
        {
            get { return _allowResize; }
            set { if (this._allowResize != value) { _allowResize = value; } }
        }

        private int _courseWindowWidth;
        /// <summary>
        /// Course Window Width
        /// </summary>
        public int CourseWindowWidth
        {
            get { return _courseWindowWidth; }
            set { if (this._courseWindowWidth != value) { _courseWindowWidth = value; } }
        }

        private int _courseWindowHeight;
        /// <summary>
        /// Course Window Height
        /// </summary>
        public int CourseWindowHeight
        {
            get { return _courseWindowHeight; }
            set { if (this._courseWindowHeight != value) { _courseWindowHeight = value; } }
        }

        private bool _isSameAVPathForAll;
        /// <summary>
        /// _isSameAVPathForAll
        /// </summary>
        public bool IsSameAVPathForAll
        {
            get { return _isSameAVPathForAll; }
            set { if (this._isSameAVPathForAll != value) { _isSameAVPathForAll = value; } }
        }

        private List<AVPathSetting> _entListAVSetting;
        /// <summary>
        /// AVSettingId
        /// </summary>
        public List<AVPathSetting> AVPathSettingList
        {
            get { return _entListAVSetting; }
            set { if (this._entListAVSetting != value) { _entListAVSetting = value; } }
        }

		//-aw 6/15/2011 Added course protocol
    	private string _protocol;

    	public string Protocol
		{
			get { return _protocol; }
			set { if (this._protocol != value) { _protocol = value; } }
		}
    }
}