using System;
namespace HRS.CoursePlayer
{
    /// <summary>
    ///  class Task 
    /// </summary>
    [Serializable]
   public class AVPathSetting : BaseEntity
    {


        public AVPathSetting()
        { }
        /// <summary>
        /// enum ListMethod
        /// </summary>
        public new enum ListMethod
        {
            GetAll,
            BulkAdd
        }

        /// <summary>
        /// enum Method
        /// </summary>
        public new enum Method
        {
            Get,
            Add,
            Update,
            Delete
        }

        private string _strCustomFieldId;
        /// <summary>
        /// CustomFieldId
        /// </summary>
        public string CustomFieldId
        {
            get { return _strCustomFieldId; }
            set { if (this._strCustomFieldId != value) { _strCustomFieldId = value; } }
        }

        private string _strCustomFieldItemId;
        /// <summary>
        /// CustomFieldItemId
        /// </summary>
        public string CustomFieldItemId
        {
            get { return _strCustomFieldItemId; }
            set { if (this._strCustomFieldItemId != value) { _strCustomFieldItemId = value; } }
        }

        private string _strItemPath;
        /// <summary>
        /// ItemPath
        /// </summary>
        public string ItemPath
        {
            get { return _strItemPath; }
            set { if (this._strItemPath != value) { _strItemPath = value; } }
        }

        private bool _isSubFolder;
        /// <summary>
        /// IsSubFolder
        /// </summary>
        public bool IsSubFolder
        {
            get { return _isSubFolder; }
            set { if (this._isSubFolder != value) { _isSubFolder = value; } }
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

    }
}
