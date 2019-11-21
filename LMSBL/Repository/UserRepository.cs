using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using LMSBL.DBModels;
using LMSBL.Common;

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
                db.AddParameter("@userId", SqlDbType.Int, userId);
                DataSet ds = db.FillData("UserGetById");
                List<TblUser> userDetails = ds.Tables[0].AsEnumerable().Select(dr => new TblUser
                {
                    UserId = Convert.ToInt32(dr["userId"]),
                    FirstName = Convert.ToString(dr["firstName"]),
                    LastName = Convert.ToString(dr["lastName"]),
                    EmailId = Convert.ToString(dr["emailId"]),
                    Password = Convert.ToString(dr["password"]),
                    DOB = Convert.ToDateTime(dr["DOB"]),
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
            catch (Exception ex)
            {
                newException.AddException(ex.Message, ex.StackTrace);
                return null;
            }
        }

        public List<TblUser> GetAllActiveUsers(int tenantId)
        {
            try
            {
                db.AddParameter("@tenantId", SqlDbType.Int, tenantId);
                DataSet ds = db.FillData("UserGetAll");
                List<TblUser> userDetails = ds.Tables[0].AsEnumerable().Select(dr => new TblUser
                {
                    UserId = Convert.ToInt32(dr["userId"]),
                    FirstName = Convert.ToString(dr["firstName"]),
                    LastName = Convert.ToString(dr["lastName"]),
                    EmailId = Convert.ToString(dr["emailId"]),
                    Password = Convert.ToString(dr["password"]),
                    DOB = Convert.ToDateTime(dr["DOB"]),
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
                newException.AddException(ex.Message, ex.StackTrace);
                return null;
            }

        }

        public List<TblUser> GetAllInActiveUsers(int tenantId)
        {
            try
            {
                db.AddParameter("@tenantId", SqlDbType.Int, tenantId);

                DataSet ds = db.FillData("UserGetAllInactive");
                List<TblUser> userDetails = ds.Tables[0].AsEnumerable().Select(dr => new TblUser
                {
                    UserId = Convert.ToInt32(dr["userId"]),
                    FirstName = Convert.ToString(dr["firstName"]),
                    LastName = Convert.ToString(dr["lastName"]),
                    EmailId = Convert.ToString(dr["emailId"]),
                    Password = Convert.ToString(dr["password"]),
                    DOB = Convert.ToDateTime(dr["DOB"]),
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
                newException.AddException(ex.Message, ex.StackTrace);
                return null;
            }
        }

        public int AddUser(TblUser obj)
        {
            try
            {
                db.AddParameter("@firstName", SqlDbType.Text, obj.FirstName);
                db.AddParameter("@lastName", SqlDbType.Text, obj.LastName);
                db.AddParameter("@emailId", SqlDbType.Text, obj.EmailId);
                db.AddParameter("@password", SqlDbType.Text, obj.Password);
                db.AddParameter("@DOB", SqlDbType.DateTime, obj.DOB);
                db.AddParameter("@contactNo", SqlDbType.Text, obj.ContactNo);
                db.AddParameter("@createdBy", SqlDbType.Int, obj.CreatedBy);
                db.AddParameter("@tenantId", SqlDbType.Int, obj.TenantId);
                db.AddParameter("@roleId", SqlDbType.Int, obj.RoleId);
                db.AddParameter("@isActive", SqlDbType.Bit, obj.IsActive);
                return db.ExecuteQuery("UserAdd");
            }
            catch (Exception ex)
            {
                newException.AddException(ex.Message, ex.StackTrace);
                return 0;
            }
        }

        public int EditUser(TblUser obj)
        {
            try
            {
                db.AddParameter("@userId", SqlDbType.Int, obj.UserId);
                db.AddParameter("@firstName", SqlDbType.Text, obj.FirstName);
                db.AddParameter("@lastName", SqlDbType.Text, obj.LastName);
                db.AddParameter("@emailId", SqlDbType.Text, obj.EmailId);
                db.AddParameter("@password", SqlDbType.Text, obj.Password);
                db.AddParameter("@DOB", SqlDbType.DateTime, obj.DOB);
                db.AddParameter("@contactNo", SqlDbType.Text, obj.ContactNo);
                db.AddParameter("@createdBy", SqlDbType.Int, obj.CreatedBy);
                db.AddParameter("@tenantId", SqlDbType.Int, obj.Tenants[0].TenantId);
                db.AddParameter("@roleId", SqlDbType.Int, obj.UserRoles[0].RoleId);
                return db.ExecuteQuery("UserUpdate");
            }
            catch (Exception ex)
            {
                newException.AddException(ex.Message, ex.StackTrace);
                return 0;
            }
        }

        public int DeleteUser(TblUser obj)
        {
            try
            {
                db = new DataRepository();
                db.AddParameter("@userId", SqlDbType.Int, obj.UserId);
                db.AddParameter("@isActive", SqlDbType.Bit, obj.IsActive);
                return db.ExecuteQuery("UserActivateDeactivate");
            }
            catch (Exception ex)
            {
                newException.AddException(ex.Message, ex.StackTrace);
                return 0;
            }
        }

        public TblUser IsValidUser(string Username, string Password)
        {
            try
            {
                common = new Commonfunctions();

                DataSet ds = new DataSet();
                db = new DataRepository();
                db.AddParameter("@EmailId", SqlDbType.NVarChar, Username);
                db.AddParameter("@Password", SqlDbType.NVarChar, Password);
                ds = db.FillData("Login");
                var tblUser = common.UserMapping(ds);

                return tblUser;
            }
            catch (Exception ex)
            {
                newException.AddException(ex.Message, ex.StackTrace);
                return null;
            }
        }
    }
}
