using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;


namespace HRS.CoursePlayer
{
    public class LearnerLoginDAL
    {
        /// <summary>
        /// Added by sreeja on 24-12-2014
        /// Will check whether the learner is valid (username and password match) and active
        /// </summary>
        /// <param name="objLeaner">Learner object which contain username and password</param>
        /// <returns>return true if the user is a valid user else false</returns>
        public static string ValidateLeanerLogin_old(Learner objLeaner)
        {
            DbProviderFactory fact = DbProviderFactories.GetFactory(Config.DbType);
            string LearnerID = "";
            using (DbConnection conn = Config.GetConnection())
            {

                DbCommand cmd = fact.CreateCommand();
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;


                cmd.CommandText = "SELECT LearnerId FROM  tblLearnerGeneral Where Upper(isActive)='TRUE' AND UserName=@UserName AND Password=@Password";
                cmd.Parameters.Add(Config.GetParameter(fact, "@UserName", objLeaner.UserName));
                cmd.Parameters.Add(Config.GetParameter(fact, "@Password", objLeaner.Password));
               

                cmd.CommandType = CommandType.Text;
                object Leanerid=cmd.ExecuteScalar();
                if (Leanerid != null)
                    LearnerID = Convert.ToString(Leanerid);
                return LearnerID;
            }            
           
        }

        /// <summary>
        /// Added by Abhay on 29-12-2014
        /// Will check whether the learner is valid (username and password match) and active
        /// </summary>
        /// <param name="objLeaner">Learner object which contain username and password</param>
        /// <returns>return Datareader</returns>
        public static Learner ValidateLeanerLogin(Learner objLeaner)
        {
            try
            {
            Learner objLearner = new Learner();
            DbProviderFactory fact = DbProviderFactories.GetFactory(Config.DbType);
            //string LearnerID = "";
            using (DbConnection conn = Config.GetConnection())
            {
                DbCommand cmd = fact.CreateCommand();
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                cmd.CommandText = "SELECT LearnerId,FirstName,UserName FROM  tblLearnerGeneral Where Upper(isActive)='TRUE' AND UserName=@UserName AND Password=@Password";
                cmd.Parameters.Add(Config.GetParameter(fact, "@UserName", objLeaner.UserName));
                cmd.Parameters.Add(Config.GetParameter(fact, "@Password", objLeaner.Password));
                cmd.CommandType = CommandType.Text;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            objLearner.LearnerId = reader["LearnerId"].ToString();
                            objLearner.FirstName = reader["FirstName"].ToString();
                            objLearner.UserName = reader["UserName"].ToString();
                        }
                    }
                    else
                    {
                        objLearner = null;
                    }
                }
                
            }
            return objLearner;
            }
            catch (Exception ex)
            {
                clsErrorhandling objerror = new clsErrorhandling();
                objerror.LogException(ex, "LearnerLogin", "ValidateLeanerLogin");
                return null;
            }
        }


    }
}
