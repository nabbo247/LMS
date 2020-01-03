using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using LMSBL.DBModels;

namespace LMSBL.Repository
{
    public class TenantRepository
    {
        DataRepository db = new DataRepository();

        public List<TblTenant> GetTenantById(int tenantId)
        {
            try
            {
                db.AddParameter("@tenantId", SqlDbType.Int, tenantId);
                DataSet ds = db.FillData("sp_TenantGetById");
                List<TblTenant> tanentDetails = ds.Tables[0].AsEnumerable().Select(dr => new TblTenant
                {
                    TenantId = Convert.ToInt32(dr["tenantId"]),
                    TenantName = Convert.ToString(dr["tenantName"]),
                    TenantDomain = Convert.ToString(dr["tenantDomain"]),
                    //DomainUrl = Convert.ToString(dr["domainUrl"]),
                    ActivationFrom = Convert.ToDateTime(dr["activationFrom"]),
                    ActivationTo = Convert.ToDateTime(dr["activationTo"]),
                    IsActive = Convert.ToBoolean(dr["isActive"]),
                    CreatedBy = Convert.ToInt32(dr["createdBy"]),
                    CreatedOn = Convert.ToDateTime(dr["createdOn"]),
                    NoOfUserAllowed = Convert.ToInt32(dr["noOfUserAllowed"]),
                    Logo = Convert.ToString(dr["Logo"])

                }).ToList();
                return tanentDetails;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool GetTenantByName(string tenantName)
        {
            Boolean result = true;
            try
            {
                db.AddParameter("@tenantName", SqlDbType.Text, tenantName);
                DataSet ds = db.FillData("sp_TenantGetByName");
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if(ds.Tables[0].Rows.Count>0)
                        {
                            result = false;
                        }
                    }
                }
                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int VerifyTenent(string TenantName)
        {
            int score = 0;
            try
            {
                db.parameters.Clear();
                db.AddParameter("@tenantName", SqlDbType.Int, TenantName);
                DataSet ds = db.FillData("sp_TenantGetByName");
                if (ds.Tables.Count > 0)
                {
                    score = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                }
                return score;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public List<TblTenant> GetAllTenants()
        {
            try
            {
                DataSet ds = db.FillData("sp_TenantGet");
                List<TblTenant> tanentDetails = ds.Tables[0].AsEnumerable().Select(dr => new TblTenant
                {
                    TenantId = Convert.ToInt32(dr["tenantId"]),
                    TenantName = Convert.ToString(dr["tenantName"]),
                    TenantDomain = Convert.ToString(dr["tenantDomain"]),
                    //DomainUrl = Convert.ToString(dr["domainUrl"]),
                    ActivationFrom = Convert.ToDateTime(dr["activationFrom"]),
                    ActivationTo = Convert.ToDateTime(dr["activationTo"]),
                    IsActive = Convert.ToBoolean(dr["isActive"]),
                    CreatedBy = Convert.ToInt32(dr["createdBy"]),
                    CreatedOn = Convert.ToDateTime(dr["createdOn"]),
                    NoOfUserAllowed = Convert.ToInt32(dr["noOfUserAllowed"])

                }).ToList();
                return tanentDetails;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AddTenant(TblTenant obj)
        {
            try
            {
                obj.CreatedBy = 1;//hardcoded put loginid here
                db.AddParameter("@tenantName", SqlDbType.Text, obj.TenantName);
                db.AddParameter("@tenantDomain", SqlDbType.Text, obj.TenantDomain);
                db.AddParameter("@activationFrom", SqlDbType.DateTime, obj.ActivationFrom);
                db.AddParameter("@activationTo", SqlDbType.DateTime, obj.ActivationTo);
                db.AddParameter("@createdBy", SqlDbType.Int, obj.CreatedBy);
                db.AddParameter("@noOfUserAllowed", SqlDbType.Int, obj.NoOfUserAllowed);
                db.AddParameter("@logo", SqlDbType.Text, obj.Logo);
                return db.ExecuteQuery("sp_TenantAdd");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int EditTenants(TblTenant obj)
        {
            try
            {
                db.AddParameter("@tenantId", SqlDbType.Int, obj.TenantId);
                db.AddParameter("@tenantName", SqlDbType.Text, obj.TenantName);
                db.AddParameter("@tenantDomain", SqlDbType.Text, obj.TenantDomain);
                db.AddParameter("@activationFrom", SqlDbType.DateTime, obj.ActivationFrom);
                db.AddParameter("@activationTo", SqlDbType.DateTime, obj.ActivationTo);
                //db.AddParameter("@createdBy", SqlDbType.Int, obj.CreatedBy);
                db.AddParameter("@noOfUserAllowed", SqlDbType.Int, obj.NoOfUserAllowed);
                db.AddParameter("@logo", SqlDbType.Text, obj.Logo);
                return db.ExecuteQuery("sp_TenantUpdate");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int DeleteTenants(TblTenant obj)
        {
            try
            {
                db = new DataRepository();
                db.AddParameter("@tenantId", SqlDbType.Int, obj.TenantId);
                db.AddParameter("@isActive", SqlDbType.Bit, obj.IsActive);
                return db.ExecuteQuery("sp_TenantActivateDeactivate");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int VerifyTenantDomain(string DomainName)
        {
            try
            {
                db = new DataRepository();
                db.AddParameter("@tenantDomain", SqlDbType.VarChar, DomainName);
                return db.ExecuteReader("sp_TenantVerify");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
