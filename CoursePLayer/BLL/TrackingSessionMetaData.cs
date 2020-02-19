namespace HRS.CoursePlayer
{
    public class TrackingSessionMetaData
    {
        public string CourseId
        {
            get;
            set;
        }

        public string LearnerId
        {
            get;
            set;
        }

        public string ClientId
        {
            get;
            set;
        }

        public string SessionId
        {
            get;
            set;
        }

        public string SessionAttemptId
        {
            get;
            set;
        }

        public short? TotalNumberOfPages
        {
            get;
            set;
        }

        public bool IsForAdminPreview
        {
            get;
            set;
        }

        public string ContentType
        {
            get;
            set;
        }
        public string UserDataXml
        {
            get;
            set;
        }

    }
}