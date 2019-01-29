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
        public List<tblTenant> GetTenantById(int tenantId)
        {
            Response response = new Response();
            ExecuteSPs executeSPs = new ExecuteSPs();
            List<Param> lstParam = new List<Param>();
            Param param = new Param();

            param.Name = "tenantId";
            param.Value = tenantId.ToString();
            lstParam.Add(param);

            List<tblTenant> lstTanent = new List<tblTenant>();
            response = executeSPs.ExecuteGetSp("TenantGetById", lstParam, "tblTenant");
            if (response.ResponseStatus)
                lstTanent = response.lstTenants;

            return lstTanent;
        }
    }
}
