using System;
using System.Collections.Generic;
using System.Data;
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
                    CreatedOn = Convert.ToDateTime(dr["createdOn"])

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
                    //ContactNo = Convert.ToString(dr["contactNo"]),
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
                //db.AddParameter("@isActive", SqlDbType.Bit, obj.IsActive);
                db.AddParameter("@UserId", SqlDbType.Int, ParameterDirection.Output);
                result = db.ExecuteQuery("sp_UserAdd");

                if (Convert.ToInt32(db.parameters[9].Value) > 0)
                {
                    result = Convert.ToInt32(db.parameters[9].Value);
                }
                if (Convert.ToInt32(db.parameters[9].Value) == -2)
                {
                    result = Convert.ToInt32(db.parameters[9].Value);
                }
            }
            catch (Exception)
            {
                throw;
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
                return db.ExecuteQuery("sp_UserUpdate");
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
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
            catch (Exception)
            {
                throw;
            }
        }

        public TblUser IsValidUser(string Username, string Password)
        {
            try
            {
                db.parameters.Clear();
                common = new Commonfunctions();

                DataSet ds = new DataSet();
                db = new DataRepository();
                db.AddParameter("@EmailId", SqlDbType.NVarChar, Username);
                db.AddParameter("@Password", SqlDbType.NVarChar, Password);
                ds = db.FillData("sp_Login");
                var tblUser = common.UserMapping(ds);

                return tblUser;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AddToken(string EmailId, string token)
        {
            //int result = 0;
            db.parameters.Clear();
            db.AddParameter("@emailId", SqlDbType.Text, EmailId);
            db.AddParameter("@token", SqlDbType.Text, token);

            return db.ExecuteQuery("sp_AddToken");
            //return result;
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

        public int ChangetePassword(TblUser obj, string NewPassword)
        {
            int result = 0;
            db.parameters.Clear();
            db.AddParameter("@UserID", SqlDbType.Int, obj.UserId);
            db.AddParameter("@OldPassword", SqlDbType.Text, obj.Password);
            db.AddParameter("@Password", SqlDbType.Text, NewPassword);
            db.AddParameter("@Status", SqlDbType.Int, ParameterDirection.Output);

            result= db.ExecuteQuery("sp_PasswordChange");

            if (Convert.ToInt32(db.parameters[3].Value) > 0)
            {
                result = Convert.ToInt32(db.parameters[3].Value);
            }
            return result;
        }

    }
}
