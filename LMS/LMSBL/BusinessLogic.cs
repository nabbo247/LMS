using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMSBL;
using LMSBL.DBModels;

namespace LMSBL
{
    public class BusinessLogic
    {
        public tblTenant GetTenantById(int tenantId)
        {
            Response response = new Response();
            ExecuteSPs executeSPs = new ExecuteSPs();
            List<Param> lstParam = new List<Param>();
            Param param = new Param();

            param.Name = "tenantId";
            param.Value = tenantId.ToString();
            lstParam.Add(param);

            tblTenant tanentDetails = new  tblTenant();
            response = executeSPs.ExecuteGetSp("TenantGetById", lstParam, "tblTenant");
            if (response.ResponseStatus)
                tanentDetails = response.tblTenant;

            return tanentDetails;
        }

        public List<tblTenant> GetAllActiveTenants()
        {
            Response response = new Response();
            ExecuteSPs executeSPs = new ExecuteSPs();
            List<Param> lstParam = new List<Param>();
           

            List<tblTenant> lstTanents = new List<tblTenant>();
            response = executeSPs.ExecuteGetSp("TenantGetAll", lstParam, "ListActiveTenant");
            if (response.ResponseStatus)
                lstTanents = response.lstTenants;

            return lstTanents;
        }
        public List<tblTenant> GetAllInActiveTenants()
        {
            Response response = new Response();
            ExecuteSPs executeSPs = new ExecuteSPs();
            List<Param> lstParam = new List<Param>();
            
            List<tblTenant> lstTanents = new List<tblTenant>();
            response = executeSPs.ExecuteGetSp("TenantGetAllInactive", lstParam, "ListInActiveTenant");
            if (response.ResponseStatus)
                lstTanents = response.lstTenants;

            return lstTanents;
        }
    }
}
