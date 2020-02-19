using System;
using System.Data;
using System.Data.SqlClient;


namespace HRS.CoursePlayer
{
    public abstract class DataAccess
    {
        readonly Func<string, string> m_GetDBConn;
        protected DataAccess(bool fromClientDatabase)
        {
            if (fromClientDatabase)
            {
                m_GetDBConn = clientId => new SQLObject().GetClientDBConnString(clientId);
            }
            else
            {
                m_GetDBConn = clientId => new SQLObject().GetMasterDBConnString();
            }
        }
    
        protected void ExecuteNonQuery(string storedProcedure, string clientId, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(m_GetDBConn(clientId)))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = storedProcedure;
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddRange(parameters);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex; // new CustomException(Services.Messages.SamlSsoConfiguration.DATAACCESS_ERROR, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, ex, true);
            }
        }

        protected T ExecuteScalar<T>(string storedProcedure, string clientId, params SqlParameter[] parameters)
        {
            T item = default(T);
            try
            {
                using (SqlConnection connection = new SqlConnection(m_GetDBConn(clientId)))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = storedProcedure;
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddRange(parameters);

                        object value = command.ExecuteScalar();
                        if (value != null && value != DBNull.Value)
                        {
                            item = (T)value;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex; // new CustomException(Services.Messages.SamlSsoConfiguration.DATAACCESS_ERROR, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, ex, true);
            }

            return item;
        }

        protected void ExecuteReader(string storedProcedure, string clientId, Action<SqlDataReader> onReaderCreated, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(m_GetDBConn(clientId)))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = storedProcedure;
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddRange(parameters);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            onReaderCreated(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;// new CustomException(Services.Messages.SamlSsoConfiguration.DATAACCESS_ERROR, CustomException.WhoCallsMe(), ExceptionSeverityLevel.Critical, ex, true);
            }
        }
    
    }
}