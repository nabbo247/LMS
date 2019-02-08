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

            db.AddParameter("@tenantId", SqlDbType.Int, tenantId);
            DataSet ds = db.FillData("TenantGetById");
            List<TblTenant> tanentDetails = ds.Tables[0].AsEnumerable().Select(dr => new TblTenant
            {
                TenantId = Convert.ToInt32(dr["tenantId"]),
                TenantName = Convert.ToString(dr["tenantName"]),
                TenantDomain = Convert.ToString(dr["tenantDomain"]),
                ActivationFrom = Convert.ToDateTime(dr["activationFrom"]),
                ActivationTo = Convert.ToDateTime(dr["activationTo"]),
                IsActive = Convert.ToBoolean(dr["isActive"]),
                CreatedBy = Convert.ToInt32(dr["createdBy"]),
                CreatedOn = Convert.ToDateTime(dr["createdOn"]),
                NoOfUserAllowed = Convert.ToInt32(dr["noOfUserAllowed"])

            }).ToList();
            return tanentDetails;
        }

        public List<TblTenant> GetAllActiveTenants()
        {
            DataSet ds = db.FillData("TenantGetAll");
            List<TblTenant> tanentDetails = ds.Tables[0].AsEnumerable().Select(dr => new TblTenant
            {
                TenantId = Convert.ToInt32(dr["tenantId"]),
                TenantName = Convert.ToString(dr["tenantName"]),
                TenantDomain = Convert.ToString(dr["tenantDomain"]),
                ActivationFrom = Convert.ToDateTime(dr["activationFrom"]),
                ActivationTo = Convert.ToDateTime(dr["activationTo"]),
                IsActive = Convert.ToBoolean(dr["isActive"]),
                CreatedBy = Convert.ToInt32(dr["createdBy"]),
                CreatedOn = Convert.ToDateTime(dr["createdOn"]),
                NoOfUserAllowed = Convert.ToInt32(dr["noOfUserAllowed"])

            }).ToList();
            return tanentDetails;
        }

        public List<TblTenant> GetAllInActiveTenants()
        {
            DataSet ds = db.FillData("TenantGetAllInactive");
            List<TblTenant> tanentDetails = ds.Tables[0].AsEnumerable().Select(dr => new TblTenant
            {
                TenantId = Convert.ToInt32(dr["tenantId"]),
                TenantName = Convert.ToString(dr["tenantName"]),
                TenantDomain = Convert.ToString(dr["tenantDomain"]),
                ActivationFrom = Convert.ToDateTime(dr["activationFrom"]),
                ActivationTo = Convert.ToDateTime(dr["activationTo"]),
                IsActive = Convert.ToBoolean(dr["isActive"]),
                CreatedBy = Convert.ToInt32(dr["createdBy"]),
                CreatedOn = Convert.ToDateTime(dr["createdOn"]),
                NoOfUserAllowed = Convert.ToInt32(dr["noOfUserAllowed"])

            }).ToList();
            return tanentDetails;
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
                return db.ExecuteQuery("TenantAdd");
            }
            catch (Exception ex)
            {
                throw ex;
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
                db.AddParameter("@noOfUserAllowed", SqlDbType.Int, obj.NoOfUserAllowed);
                return db.ExecuteQuery("TenantUpdate");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteTenants(TblTenant obj)
        {
            try
            {
                db = new DataRepository();
                db.AddParameter("@tenantId", SqlDbType.Int, obj.TenantId);
                db.AddParameter("@isActive", SqlDbType.Bit, obj.IsActive);
                return db.ExecuteQuery("TenantActivateDeactivate");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
