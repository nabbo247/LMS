using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using LMSBL.Common;
using LMSBL.DBModels;

namespace LMSBL.Repository
{
    public class UserRepository
    {
        DataRepository db = new DataRepository();
        Exceptions newException = new Exceptions();
        Commonfunctions common;
        public List<TblUser> GetUserById(int userId)
        {
            try
            {
                db.parameters.Clear();
                DateTime? nullDate = null;
                db.AddParameter("@userId", SqlDbType.Int, userId);
                DataSet ds = db.FillData("sp_UserGetById");
                List<TblUser> userDetails = ds.Tables[0].AsEnumerable().Select(dr => new TblUser
                {
                    UserId = Convert.ToInt32(dr["userId"]),
                    FirstName = Convert.ToString(dr["firstName"]),
                    LastName = Convert.ToString(dr["lastName"]),
                    EmailId = Convert.ToString(dr["emailId"]),
                    Password = Convert.ToString(dr["password"]),
                    DOB = (Convert.ToString(dr["DOB"]) == null || Convert.ToString(dr["DOB"]) == "") ? nullDate : Convert.ToDateTime(dr["DOB"]),
                    ContactNo = Convert.ToString(dr["contactNo"]),
                    TenantId = Convert.ToInt32(dr["tenantId"]),
                    //TenantName=Convert.ToString(dr["tenantName"]),
                    RoleId = Convert.ToInt32(dr["roleId"]),
                    RoleName = Convert.ToInt32(dr["roleId"]) == 2 ? Roles.Admin.ToString() : Roles.Learner.ToString(),//Convert.ToString(dr["roleName"]),
                    IsActive = Convert.ToBoolean(dr["isActive"]),
                    CreatedBy = Convert.ToInt32(dr["createdBy"]),
                    CreatedOn = Convert.ToDateTime(dr["createdOn"]),
                    profileImage = Convert.ToString(dr["profileImage"])

                }).ToList();
                return userDetails;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TblUser> GetAllUsers(int tenantId)
        {
            try
            {
                db.parameters.Clear();
                db.AddParameter("@tenantId", SqlDbType.Int, tenantId);
                DataSet ds = db.FillData("sp_UserGet");
                List<TblUser> userDetails = ds.Tables[0].AsEnumerable().Select(dr => new TblUser
                {
                    UserId = Convert.ToInt32(dr["userId"]),
                    FirstName = Convert.ToString(dr["firstName"]),
                    LastName = Convert.ToString(dr["lastName"]),
                    EmailId = Convert.ToString(dr["emailId"]),
                    Password = Convert.ToString(dr["password"]),
                    //DOB = (DBNull.Value.Equals(dr["DOB"])) ? Convert.ToDateTime(dr["DOB"]):,
                    ContactNo = Convert.ToString(dr["contactNo"]),
                    TenantId = Convert.ToInt32(dr["tenantId"]),
                    //TenantName = Convert.ToString(dr["tenantName"]),
                    RoleId = Convert.ToInt32(dr["roleId"]),
                    RoleName = Convert.ToInt32(dr["roleId"]) == 2 ? Roles.Admin.ToString() : Roles.Learner.ToString(),//Convert.ToString(dr["roleName"]),
                    IsActive = Convert.ToBoolean(dr["isActive"]),
                    CreatedBy = Convert.ToInt32(dr["createdBy"]),
                    CreatedOn = Convert.ToDateTime(dr["createdOn"])

                }).ToList();
                return userDetails;
            }
            catch (Exception ex)
            {

                newException.AddException(ex);
                return null;
            }

        }

        public int AddUser(TblUser obj)
        {
            int result = 0;
            try
            {
                db.parameters.Clear();
                db.AddParameter("@firstName", SqlDbType.Text, obj.FirstName);
                db.AddParameter("@lastName", SqlDbType.Text, obj.LastName);
                db.AddParameter("@emailId", SqlDbType.Text, obj.EmailId);
                db.AddParameter("@password", SqlDbType.Text, obj.Password);
                db.AddParameter("@DOB", SqlDbType.DateTime, obj.DOB);
                db.AddParameter("@contactNo", SqlDbType.Text, obj.ContactNo);
                db.AddParameter("@createdBy", SqlDbType.Int, obj.CreatedBy);
                db.AddParameter("@tenantId", SqlDbType.Int, obj.TenantId);
                db.AddParameter("@roleId", SqlDbType.Int, obj.RoleId);
                db.AddParameter("@profileImage", SqlDbType.Text, obj.profileImage);
                //db.AddParameter("@isActive", SqlDbType.Bit, obj.IsActive);
                db.AddParameter("@UserId", SqlDbType.Int, ParameterDirection.Output);
                result = db.ExecuteQuery("sp_UserAdd");

                if (Convert.ToInt32(db.parameters[10].Value) > 0)
                {
                    result = Convert.ToInt32(db.parameters[10].Value);
                }
                if (Convert.ToInt32(db.parameters[10].Value) == -2)
                {
                    result = Convert.ToInt32(db.parameters[10].Value);
                }
            }
            catch (Exception ex)
            {

                newException.AddException(ex);
            }
            return result;
        }

        public int EditUser(TblUser obj)
        {
            try
            {
                db.parameters.Clear();
                db.AddParameter("@userId", SqlDbType.Int, obj.UserId);
                db.AddParameter("@firstName", SqlDbType.Text, obj.FirstName);
                db.AddParameter("@lastName", SqlDbType.Text, obj.LastName);
                db.AddParameter("@emailId", SqlDbType.Text, obj.EmailId);
                //db.AddParameter("@password", SqlDbType.Text, obj.Password);
                db.AddParameter("@DOB", SqlDbType.DateTime, obj.DOB);
                db.AddParameter("@contactNo", SqlDbType.Text, obj.ContactNo);
                db.AddParameter("@createdBy", SqlDbType.Int, obj.CreatedBy);
                db.AddParameter("@tenantId", SqlDbType.Int, obj.TenantId);
                db.AddParameter("@roleId", SqlDbType.Int, obj.RoleId);
                db.AddParameter("@profileImage", SqlDbType.Text, obj.profileImage);
                return db.ExecuteQuery("sp_UserUpdate");
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                throw ex;
            }
        }

        public int DeleteUser(TblUser obj)
        {
            try
            {
                db.parameters.Clear();
                db = new DataRepository();
                db.AddParameter("@userId", SqlDbType.Int, obj.UserId);
                db.AddParameter("@isActive", SqlDbType.Bit, obj.IsActive);
                return db.ExecuteQuery("sp_UserActivateDeactivate");
            }
            catch (Exception ex)
            {

                newException.AddException(ex);
                return 0;
            }
        }

        public TblUser IsValidUser(string Username, string Password, string DomainName)
        {
            try
            {
                db.parameters.Clear();
                common = new Commonfunctions();
                TblUser tblUser = new TblUser();
                DataSet ds = new DataSet();
                db = new DataRepository();
                db.AddParameter("@EmailId", SqlDbType.NVarChar, Username);
                db.AddParameter("@Password", SqlDbType.NVarChar, Password);
                db.AddParameter("@DomainName", SqlDbType.NVarChar, DomainName);
                ds = db.FillData("sp_Login");
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            tblUser = common.UserMapping(ds);
                        }
                    }
                }

                return tblUser;
            }
            catch (Exception ex)
            {

                newException.AddException(ex);
                return null;
            }
        }

        public void AddLoginLog(int UserId)
        {
            try
            {
                db.parameters.Clear();
                db.AddParameter("@userId", SqlDbType.Int, UserId);
                db.ExecuteQuery("sp_AddLoginLog");
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
            }
        }

        public int AddToken(string EmailId, string token)
        {
            db.parameters.Clear();
            db.AddParameter("@emailId", SqlDbType.Text, EmailId);
            db.AddParameter("@token", SqlDbType.Text, token);
            return db.ExecuteQuery("sp_AddToken");
        }

        public string VerifyToken(string token)
        {
            string result = string.Empty;
            db.parameters.Clear();
            db.AddParameter("@token", SqlDbType.Text, token);
            DataSet ds = db.FillData("sp_VerifyToken");
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        result = Convert.ToString(ds.Tables[0].Rows[0][0]);
                    }
                }
            }

            return result;
        }

        public int UpdatePassword(TblUser obj)
        {
            //int result = 0;
            db.parameters.Clear();
            db.AddParameter("@emailId", SqlDbType.Text, obj.EmailId);
            db.AddParameter("@password", SqlDbType.Text, obj.Password);

            return db.ExecuteQuery("sp_PasswordUpdate");
            //return result;
        }

        public int ChangePassword(TblUser obj, string NewPassword)
        {
            int result = 0;
            db.parameters.Clear();
            db.AddParameter("@UserID", SqlDbType.Int, obj.UserId);
            db.AddParameter("@OldPassword", SqlDbType.Text, obj.OldPassword);
            db.AddParameter("@Password", SqlDbType.Text, NewPassword);
            db.AddParameter("@Status", SqlDbType.Int, ParameterDirection.Output);

            result = db.ExecuteQuery("sp_PasswordChange");

            if (Convert.ToInt32(db.parameters[3].Value) > 0)
            {
                result = Convert.ToInt32(db.parameters[3].Value);
            }
            return result;
        }


        public int InsertEmails(DataTable dt)
        {
            int result = 0;
            string constr = ConfigurationManager.ConnectionStrings["LMSContext"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            try
            {

                SqlBulkCopy objbulk = new SqlBulkCopy(con);
                objbulk.DestinationTableName = "tblEmails";

                objbulk.ColumnMappings.Add("EmailTo", "EmailTo");
                objbulk.ColumnMappings.Add("EmailSubject", "EmailSubject");
                objbulk.ColumnMappings.Add("EmailBody", "EmailBody");
                objbulk.ColumnMappings.Add("DateCreated", "DateCreated");
                objbulk.ColumnMappings.Add("isSent", "isSent");
                objbulk.ColumnMappings.Add("DateSent", "DateSent");
                objbulk.ColumnMappings.Add("SentStatus", "SentStatus");

                con.Open();
                //insert bulk Records into DataBase.  
                objbulk.WriteToServer(dt);
                con.Close();
                result = 1;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                con.Close();

            }
            return result;
        }

        public int InsertEmail(tblEmails objEmail)
        {
            int result = 0;
            db.parameters.Clear();
            db.AddParameter("@EmailTo", SqlDbType.Text, objEmail.EmailTo);
            db.AddParameter("@EmailSubject", SqlDbType.Text, objEmail.EmailSubject);
            db.AddParameter("@EmailBody", SqlDbType.Text, objEmail.EmailBody);
            result = db.ExecuteQuery("sp_AddEmail");

            return result;
        }

    }
}
