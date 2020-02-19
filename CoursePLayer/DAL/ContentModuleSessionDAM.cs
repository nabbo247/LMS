using System;
using System.Data;
using System.Data.SqlClient;


namespace HRS.CoursePlayer
{
    public class ContentModuleSessionDAM : DataAccess
    {
        public ContentModuleSessionDAM()
            : base(true)
        {
        }

        public ContentModuleSession Save(string clientId, ContentModuleSession session)
        {
            const string storedProcedure = "sproc_ContentModuleSession_GetNew";

            SqlParameter contentModuleParameter = new SqlParameter("ContentModuleId", SqlDbType.VarChar, 100) {Value = session.ContentModuleId};
            SqlParameter userParameter = new SqlParameter("SystemUserGuid", SqlDbType.VarChar, 100) {Value=session.SystemUserGuid};
            SqlParameter gridPageParameter = new SqlParameter("GridPageSize", SqlDbType.Int);
            if (session.GridPageSize.HasValue)
            {
                gridPageParameter.Value = session.GridPageSize.Value;
            }
            else
            {
                gridPageParameter.Value = DBNull.Value;
            }
            SqlParameter attemptParameter = new SqlParameter("Attempt", SqlDbType.Int);
            if (session.Attempt.HasValue)
            {
                attemptParameter.Value = session.Attempt.Value;
            }
            else
            {
                attemptParameter.Value = DBNull.Value;
            }
            SqlParameter launchSiteParameter = new SqlParameter("LaunchSite", SqlDbType.Char, 1) { Value = (session.LaunchSite == LaunchSite.Admin) ? "A" : "L" };
            SqlParameter reviewParameter = new SqlParameter("IsReview", SqlDbType.Bit) { Value = session.IsReview };
            SqlParameter ssoParameter = new SqlParameter("SsoLogin", SqlDbType.Bit) { Value = session.SsoLogin };
            SqlParameter windowParameter = new SqlParameter("SameWindow", SqlDbType.Bit) { Value = session.SameWindow };
            SqlParameter returnParameter = new SqlParameter("ReturnUrl", SqlDbType.NVarChar, 500) { Value = session.ReturnUrl };
            SqlParameter expirationParameter = new SqlParameter("Expiration", SqlDbType.DateTime) { Value = session.Expiration };

            session.SessionId = ExecuteScalar<Guid>(storedProcedure, clientId, contentModuleParameter, userParameter,
                                                      gridPageParameter, attemptParameter, launchSiteParameter,
                                                      reviewParameter, ssoParameter, windowParameter, returnParameter,
                                                      expirationParameter).ToString();
            return session;
        }

        public void Extend(string clientId, string sessionId, TimeSpan extension)
        {
            const string storedProcedure = "sproc_ContentModuleSession_Extend";

            SqlParameter sessionIdParameter = new SqlParameter("SessionId", SqlDbType.VarChar, 100);
            sessionIdParameter.Value = sessionId;

            SqlParameter extensionParameter = new SqlParameter("ExtendSeconds", SqlDbType.Int);
            extensionParameter.Value = extension.TotalSeconds;

            ExecuteNonQuery(storedProcedure, clientId, sessionIdParameter, extensionParameter);
        }

        public void Expire(string clientId, string sessionId)
        {
            const string storedProcedure = "sproc_ContentModuleSession_Expire";

            SqlParameter parameter = new SqlParameter("SessionId", SqlDbType.VarChar, 100);
            parameter.Value = sessionId;

            ExecuteNonQuery(storedProcedure, clientId, parameter);
        }

        public ContentModuleSession GetById(string clientId, string sessionId)
        {
            const string storedProcedure = "sproc_ContentModuleSession_sel";

            SqlParameter parameter = new SqlParameter("SessionId", SqlDbType.VarChar, 100);
            parameter.Value = sessionId;

            ContentModuleSession session = null;

            Action<SqlDataReader> onReaderCreated = r => session = PopulateContentModuleSession(r);

            ExecuteReader(storedProcedure, clientId, onReaderCreated, parameter);

            return session;
        }

        private static ContentModuleSession PopulateContentModuleSession(SqlDataReader reader)
        {
            if (!reader.HasRows)
            {
                return null;
            }

            ContentModuleSession session = new ContentModuleSession();

            reader.Read();

            reader.SetValueForColumn<Guid>("SessionId", i => session.SessionId = i.ToString());
            reader.SetValueForColumn<string>("ContentModuleId", i => session.ContentModuleId = i);
            reader.SetValueForColumn<string>("SystemUserGuid", i => session.SystemUserGuid = i);
            reader.SetValueForColumn<int?>("Attempt", i => session.Attempt = i);
            reader.SetValueForColumn<int?>("GridPageSize", i => session.GridPageSize = i);
            reader.SetValueForColumn<string>("LaunchSite", i => session.LaunchSite = (i == "A") ? LaunchSite.Admin : LaunchSite.Learner);
            reader.SetValueForColumn<bool>("IsReview", i => session.IsReview = i);
            reader.SetValueForColumn<bool>("SsoLogin", i => session.SsoLogin = i);
            reader.SetValueForColumn<bool>("SameWindow", i => session.SameWindow = i);
            reader.SetValueForColumn<string>("ReturnUrl", i => session.ReturnUrl = i);
            reader.SetValueForColumn<DateTime>("Expiration", i => session.Expiration = i);

            return session;
        }

        public void AddAttemptNumber(string clientId, string sessionId, short attemptNumber)
        {
            const string storedProcedure = "sproc_ContentModuleSession_AddAttempt";

            SqlParameter sessionIdParameter = new SqlParameter("SessionId", SqlDbType.VarChar, 100);
            sessionIdParameter.Value = sessionId;

            SqlParameter attemptParameter = new SqlParameter("Attempt", SqlDbType.SmallInt);
            attemptParameter.Value = attemptNumber;

            ExecuteNonQuery(storedProcedure, clientId, sessionIdParameter, attemptParameter);
        }
    }
}
