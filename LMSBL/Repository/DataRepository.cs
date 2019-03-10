using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LMSBL.Repository
{
    public class DataRepository
    {
        private static string constr = ConfigurationManager.ConnectionStrings["LMSContext"].ConnectionString;
        //private static string constr = "Data Source=.;Initial Catalog=LMSDB;Integrated Security=True";//take from Web.Config:
        public List<SqlParameter> parameters = new List<SqlParameter>();

        public void AddParameter(string parameterName, SqlDbType dbType, object value)
        {
            SqlParameter param = new SqlParameter(parameterName, dbType);
            param.Value = value;
            parameters.Add(param);
        }

        public void AddParameter(string parameterName, SqlDbType dbType, ParameterDirection direction)
        {
            SqlParameter param = new SqlParameter(parameterName, dbType);
            param.Direction = direction;
            parameters.Add(param);
        }

        public DataSet FillData(string cmdText)
        {
            SqlConnection con = new SqlConnection(constr);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters.ToArray());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

        public int ExecuteQuery(string cmdText)
        {
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters.ToArray());
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

        public int ExecuteReader(string cmdText)
        {
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(cmdText, con);
                SqlDataReader dr;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters.ToArray());
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

    }
}