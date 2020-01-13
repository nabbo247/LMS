using LMSBL.DBModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBL.Common
{
    public class Commonfunctions
    {
        public TblUser UserMapping(DataSet ds)
        {
            DateTime? nullDate = null;
            TblUser tbluser = new TblUser();
            tbluser.UserId = Convert.ToInt16(ds.Tables[0].Rows[0]["userId"]);
            tbluser.FirstName =Convert.ToString(ds.Tables[0].Rows[0]["firstName"]);
            tbluser.LastName= Convert.ToString(ds.Tables[0].Rows[0]["lastName"]);
            tbluser.EmailId = Convert.ToString(ds.Tables[0].Rows[0]["emailId"]);
            tbluser.DOB = (Convert.ToString(ds.Tables[0].Rows[0]["DOB"]) == null || Convert.ToString(ds.Tables[0].Rows[0]["DOB"]) == "") ? nullDate : Convert.ToDateTime(ds.Tables[0].Rows[0]["DOB"]);
            tbluser.ContactNo= Convert.ToString(ds.Tables[0].Rows[0]["contactNo"]);
            tbluser.RoleId= Convert.ToInt16(ds.Tables[0].Rows[0]["roleId"]);
            tbluser.TenantId= Convert.ToInt16(ds.Tables[0].Rows[0]["tenantId"]);
            return tbluser;
        }
    }
}
