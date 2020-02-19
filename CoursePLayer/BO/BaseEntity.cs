
using System;
namespace HRS.CoursePlayer
{
    /// <summary>
    /// Serializable - BaseEntity Class (Parent Class)
    /// </summary>
    [Serializable]
    public abstract class BaseEntity : ICloneable
    {       

        /// <summary>
        /// Base entity Method ENUM declaration
        /// </summary>
        public  enum Method
        {
            Get
        }

        /// <summary>
        /// Base Entity ListMethos ENUM declaration
        /// </summary>
        public enum ListMethod
        {

        }

        private string _strId;
        /// <summary>
        /// To Get Entity object ID
        /// </summary>
        public string ID
        {
            get { return _strId; }
            set { if (this._strId != value) { _strId = value; } }
        }

        private string _clientId;
        /// <summary>
        /// To Get Entity object ClientId
        /// </summary>
        public string ClientId
        {
            get { return _clientId; }
            set { if (this._clientId != value) { _clientId = value; } }
        }

        private string _strCreatedById;
        /// <summary>
        /// Created By Id
        /// </summary>
        public string CreatedById
        {
            get { return _strCreatedById; }
            set { if (this._strCreatedById != value) { _strCreatedById = value; } }
        }

        private DateTime _dateCreated;
        /// <summary>
        /// Date Created
        /// </summary>
        public DateTime DateCreated
        {
            get { return _dateCreated; }
            set { if (this._dateCreated != value) { _dateCreated = value; } }
        }

        private string _strLastModifiedById;
        /// <summary>
        /// Last Modified By Id
        /// </summary>
        public string LastModifiedById
        {
            get { return _strLastModifiedById; }
            set { if (this._strLastModifiedById != value) { _strLastModifiedById = value; } }
        }

        private DateTime _dateLastModified;
        /// <summary>
        /// Last Modified Date
        /// </summary>
        public DateTime LastModifiedDate
        {
            get { return _dateLastModified; }
            set { if (this._dateLastModified != value) { _dateLastModified = value; } }
        }

        private string _strCreatedByName;
        public string CreatedByName
        {
            get { return _strCreatedByName; }
            set { if (this._strCreatedByName != value) { _strCreatedByName = value; } }
        }

        private string _strLastModifiedByName;
        public string LastModifiedByName
        {
            get { return _strLastModifiedByName; }
            set { if (this._strLastModifiedByName != value) { _strLastModifiedByName = value; } }
        }
        private string _strRetMessage;
        public string RetMessage
        {
            get { return _strRetMessage; }
            set { if (this._strRetMessage != value) { _strRetMessage = value; } }
        }

        ////private string _strUserProfileImg;
        ////public string UserProfileImg
        ////{
        ////    get { return _strUserProfileImg; }
        ////    set { if (this._strUserProfileImg != value) { _strUserProfileImg = value; } }
        ////}

        private EntityRange _listRange;
        /// <summary>
        /// Specify expected records list range.
        /// </summary>
        public EntityRange ListRange
        {
            get { return _listRange; }
            set { _listRange = value;}
        }
        /// <summary>
        /// Crete Clone
        /// </summary>
        /// <returns>Clone of current object</returns>
        public object Clone()
        {
            // call clone method
            return this.MemberwiseClone();      
        }


    }

    [Serializable]
    public class EntityRange
    {
        /// <summary>
        /// default value 
        /// </summary>
        private int _iPageIndex;
        /// <summary>
        /// PageIndex
        /// </summary>
        public int PageIndex
        {
            get { return _iPageIndex; }
            set { if (this._iPageIndex != value) { _iPageIndex = value; } }
        }

        /// <summary>
        /// default 
        /// </summary>
        private int _iPageSize;
        /// <summary>
        /// PageSize
        /// </summary>
        public int PageSize
        {
            get { return _iPageSize; }
            set { if (this._iPageSize != value) { _iPageSize = value; } }
        }

        private int _iTotalRows;
        /// <summary>
        /// PageSize
        /// </summary>
        public int TotalRows
        {
            get { return _iTotalRows; }
            set { if (this._iTotalRows != value) { _iTotalRows = value; } }
        }

        private string _strSortExpression;
        /// <summary>
        /// SortExpression
        /// </summary>
        public string SortExpression
        {
            get { return _strSortExpression; }
            set { if (this._strSortExpression != value) { _strSortExpression = value; } }
        }
        private string _strRequestedById;
        /// <summary>
        /// Requested By Id
        /// </summary>
        public string RequestedById
        {
            get { return _strRequestedById; }
            set { if (this._strRequestedById != value) { _strRequestedById = value; } }
        }
    }

    public enum DataAction
    {
        Insert,
        Update,
        Delete
    }
}