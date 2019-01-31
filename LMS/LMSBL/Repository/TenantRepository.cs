using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMSBL.DBModels;
using LMSBL.Repository;

namespace LMSBL.Repository
{
    public class TenantRepository
    {
        DataRepository db = new DataRepository();

        public List<tblTenant> GetTenantById(int tenantId)
        {

            db.AddParameter("@tenantId", SqlDbType.Int, tenantId);
            DataSet ds = db.FillData("TenantGetById");
            List<tblTenant> tanentDetails = ds.Tables[0].AsEnumerable().Select(dr => new tblTenant
            {
                tenantId = Convert.ToInt32(dr["tenantId"]),
                tenantName = Convert.ToString(dr["tenantName"]),
                tenantDomain = Convert.ToString(dr["tenantDomain"]),
                activationFrom = Convert.ToDateTime(dr["activationFrom"]),
                activationTo = Convert.ToDateTime(dr["activationTo"]),
                isActive = Convert.ToBoolean(dr["isActive"]),
                createdBy = Convert.ToInt32(dr["createdBy"]),
                createdOn = Convert.ToDateTime(dr["createdOn"]),
                noOfUserAllowed = Convert.ToInt32(dr["noOfUserAllowed"])

            }).ToList();
            return tanentDetails;
        }

        public List<tblTenant> GetAllActiveTenants()
        {
            DataSet ds = db.FillData("TenantGetAll");
            List<tblTenant> tanentDetails = ds.Tables[0].AsEnumerable().Select(dr => new tblTenant
            {
                tenantId = Convert.ToInt32(dr["tenantId"]),
                tenantName = Convert.ToString(dr["tenantName"]),
                tenantDomain = Convert.ToString(dr["tenantDomain"]),
                activationFrom = Convert.ToDateTime(dr["activationFrom"]),
                activationTo = Convert.ToDateTime(dr["activationTo"]),
                isActive = Convert.ToBoolean(dr["isActive"]),
                createdBy = Convert.ToInt32(dr["createdBy"]),
                createdOn = Convert.ToDateTime(dr["createdOn"]),
                noOfUserAllowed = Convert.ToInt32(dr["noOfUserAllowed"])

            }).ToList();
            return tanentDetails;
        }

        public List<tblTenant> GetAllInActiveTenants()
        {
            DataSet ds = db.FillData("TenantGetAllInactive");
            List<tblTenant> tanentDetails = ds.Tables[0].AsEnumerable().Select(dr => new tblTenant
            {
                tenantId = Convert.ToInt32(dr["tenantId"]),
                tenantName = Convert.ToString(dr["tenantName"]),
                tenantDomain = Convert.ToString(dr["tenantDomain"]),
                activationFrom = Convert.ToDateTime(dr["activationFrom"]),
                activationTo = Convert.ToDateTime(dr["activationTo"]),
                isActive = Convert.ToBoolean(dr["isActive"]),
                createdBy = Convert.ToInt32(dr["createdBy"]),
                createdOn = Convert.ToDateTime(dr["createdOn"]),
                noOfUserAllowed = Convert.ToInt32(dr["noOfUserAllowed"])

            }).ToList();
            return tanentDetails;
        }
    }
}
