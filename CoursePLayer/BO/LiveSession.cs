
using System;
namespace HRS.CoursePlayer
{
    /// <summary>
    /// LiveSession to track Session tblLiveSession
    /// </summary>
   [Serializable] public class LiveSession : BaseEntity 
    {
        /// <summary>
        /// Default Contructor
        /// </summary>
        public LiveSession()
        { }
        /// <summary>
        /// ENUM Method
        /// </summary>
        public new enum Method
        {
            GetCount,
            Add,
            Delete,
            SetSessionTimeStamp
        }

        private string _strSystemUserGUID;
        /// <summary>
        /// User Id
        /// </summary>
        public string SystemUserGUID
        {
            get { return _strSystemUserGUID; }
            set { if (this._strSystemUserGUID != value) { _strSystemUserGUID = value; } }
        }

        private Nullable<bool> _bSessionStatus;
        /// <summary>
        /// SessionStatus
        /// </summary>
        public Nullable<bool> SessionStatus
        {
            get { return _bSessionStatus; }
            set { if (this._bSessionStatus != value) { _bSessionStatus = value; } }
        }
        private Nullable<DateTime> _dateSessionStartDate;
        /// <summary>
        /// Session Start Date
        /// </summary>
        public Nullable<DateTime> SessionStartDate
        {
            get { return _dateSessionStartDate; }
            set { if (this._dateSessionStartDate != value) { _dateSessionStartDate = value; } }
        }

        private Nullable<DateTime> _dateSessionEndDate;
        /// <summary>
        /// Session End Date
        /// </summary>
        public Nullable<DateTime> SessionEndDate
        {
            get { return _dateSessionEndDate; }
            set { if (this._dateSessionEndDate != value) { _dateSessionEndDate = value; } }
        }
        private string _strUserType;
        /// <summary>
        /// User Role ID
        /// </summary>
        public string UserType
        {
            get { return _strUserType; }
            set { if (this._strUserType != value) { _strUserType = value; } }
        }

        private string _strSessionServerIP;
        /// <summary>
        /// Session Server IP
        /// </summary>
        public string SessionServerIP
        {
            get { return _strSessionServerIP; }
            set { if (this._strSessionServerIP != value) { _strSessionServerIP = value; } }
        }

        private DateTime _dtSessionTimeStamp;
        /// <summary>
        /// Session Time Stamp
        /// </summary>
        public DateTime SessionTimeStamp
        {
            get { return _dtSessionTimeStamp; }
            set { if (this._dtSessionTimeStamp != value) { _dtSessionTimeStamp = value; } }
        }
        private bool _bIsSSOLogin;
        /// <summary>
        /// Is Singlie Sign On Login
        /// </summary>
        public bool IsSSOLogin
        {
            get { return _bIsSSOLogin; }
            set { if (this._bIsSSOLogin != value) { _bIsSSOLogin = value; } }
        }

        /// <summary>
        /// SessionTimeOut of client object.
        /// </summary>
        private int _iSessionTimeOut;
        /// <summary>
        /// Session Time out Value 
        /// </summary>
        public int SessionTimeOut
        {
            get { return _iSessionTimeOut; }
            set { if (this._iSessionTimeOut != value) { _iSessionTimeOut = value; } }
        }

        private string _strOperatingSystem;
        /// <summary>
        /// Session Server IP
        /// </summary>
        public string OperatingSystem
        {
            get { return _strOperatingSystem; }
            set { if (this._strOperatingSystem != value) { _strOperatingSystem = value; } }
        }

        private string _strBrowser;
        /// <summary>
        /// Session Server IP
        /// </summary>
        public string Browser
        {
            get { return _strBrowser; }
            set { if (this._strBrowser != value) { _strBrowser = value; } }
        }

        private string _strJavascriptVersion;
        /// <summary>
        /// Session Server IP
        /// </summary>
        public string JavascriptVersion
        {
            get { return _strJavascriptVersion; }
            set { if (this._strJavascriptVersion != value) { _strJavascriptVersion = value; } }
        }

        private string _strFlashVersion;
        /// <summary>
        /// Session Server IP
        /// </summary>
        public string FlashVersion
        {
            get { return _strFlashVersion; }
            set { if (this._strFlashVersion != value) { _strFlashVersion = value; } }
        }

        private bool _bSupportCookies;
        /// <summary>
        /// Is Singlie Sign On Login
        /// </summary>
        public bool SupportCookies
        {
            get { return _bSupportCookies; }
            set { if (this._bSupportCookies != value) { _bSupportCookies = value; } }
        }

        private bool _bSupportActivexControls;
        /// <summary>
        /// Is Singlie Sign On Login
        /// </summary>
        public bool SupportActivexControls
        {
            get { return _bSupportActivexControls; }
            set { if (this._bSupportActivexControls != value) { _bSupportActivexControls = value; } }
        }
    }
}