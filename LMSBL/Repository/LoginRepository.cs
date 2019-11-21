﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMSBL.DBModels;
using System.Data;
using LMSBL.Common;

namespace LMSBL.Repository
{
    public class LoginRepository
    {
        DataRepository db = new DataRepository();
        Exceptions newException = new Exceptions();

        public List<TblUser> Login(TblLogin objLogin)
        {
            try
            {
                db.AddParameter("@EmailId", SqlDbType.Text, objLogin.EmailId);
                db.AddParameter("@Password", SqlDbType.Text, objLogin.Password);
                DataSet ds = db.FillData("Login");
                List<TblUser> loginDetails = ds.Tables[0].AsEnumerable().Select(dr => new TblUser
                {
                    UserId = Convert.ToInt32(dr["userId"]),
                    FirstName = Convert.ToString(dr["firstName"]),
                    LastName = Convert.ToString(dr["lastName"]),
                    EmailId = Convert.ToString(dr["emailId"]),
                    Password = Convert.ToString(dr["password"]),
                    DOB = Convert.ToDateTime(dr["DOB"]),
                    ContactNo = Convert.ToString(dr["contactNo"]),
                    TenantId = Convert.ToInt32(dr["tenantId"]),
                    TenantName = Convert.ToString(dr["tenantName"]),
                    RoleId = Convert.ToInt32(dr["roleId"]),
                    RoleName = Convert.ToString(dr["roleName"]),
                    IsActive = Convert.ToBoolean(dr["isActive"]),
                    CreatedBy = Convert.ToInt32(dr["createdBy"]),
                    CreatedOn = Convert.ToDateTime(dr["createdOn"])
                }).ToList();

                return loginDetails;

            }
            catch(Exception ex)
            {
                newException.AddException(ex.Message, ex.StackTrace);
                return null;
            }
        }
    }
}
