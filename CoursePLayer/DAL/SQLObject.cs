
using System;
using System.Data;
using System.Data.SqlClient;


namespace HRS.CoursePlayer
{
    public class SQLObject
    {
        //private SqlConnection sqlConnectionImport;

        #region SQLHelper Methods

        // These methods are all forwarded to static methods in SQLHelper
        // Future refactoring would be to decide where they should go
        // and remove forwarding calls

        public  SqlDataReader ExecuteMasterReader(SqlCommand pCommand,bool pisConOpen)
        {
            return SQLHelper.ExecuteMasterReader(pCommand, pisConOpen);
        }

        public Object ExecuteMasterScalar(SqlCommand pCommand)
        {
            return SQLHelper.ExecuteMasterScalar(pCommand);
        }

        public  Object ExecuteScalar(SqlCommand pCommand, bool pIsConnOpen)
        {
            return SQLHelper.ExecuteScalar(pCommand, pIsConnOpen);
        }

        public  SqlDataReader SqlDataReader(SqlCommand pCommand, bool pIsConnOpen)
        {
            return SQLHelper.SqlDataReader(pCommand, pIsConnOpen);
        }

        public  int ExecuteNonQuery(SqlCommand pCommand, string pConnString)
        {
            return SQLHelper.ExecuteNonQuery(pCommand, pConnString);
        }

        public  bool ExecuteNonQuery(SqlCommand pCommand, string pConnString, bool pIsExecuted)
        {           
            return SQLHelper.ExecuteNonQuery(pCommand, pConnString, pIsExecuted);
        }

        public  bool ExecuteNonQuery(SqlCommand pCommand)
        {
            return SQLHelper.ExecuteNonQuery(pCommand);
        }

        public int ExecuteNonQueryCount(SqlCommand pCommand)
        {
            return SQLHelper.ExecuteNonQueryCount(pCommand);
        }

        public  string GetMasterDBConnString()
        {
            return SQLHelper.GetMasterDBConnString();  
        }

        public string GetClientDBConnString(string pClientId)
        {
            return SQLHelper.GetMasterDBConnString(); 
        }

        //public string GetClientDBConnString(Client pClient)
        //{
        //    return SQLHelper.GetClientDBConnString(pClient);
        //}

        public  DataSet SqlDataAdapter(SqlCommand pCommand, string pConnString)
        {
            return SQLHelper.SqlDataAdapter(pCommand, pConnString);
        }

        public  bool ReaderHasColumn(IDataReader reader, string pColumnName)
        {
            return SQLHelper.ReaderHasColumn(reader, pColumnName);
        }

        #endregion
    }
}