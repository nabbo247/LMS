using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using LMSBL.DBModels;
using LMSBL.Common;

namespace LMSBL.Repository
{
    public class RolesRepository
    {
        DataRepository db = new DataRepository();
        Exceptions newException = new Exceptions();
        public List<TblUserRole> GetAllRoles()
        {
            try
            {
                DataSet ds = db.FillData("RolesGetAll");
                List<TblUserRole> roleDetails = ds.Tables[0].AsEnumerable().Select(dr => new TblUserRole
                {
                    RoleId = Convert.ToInt32(dr["roleId"]),
                    RoleName = Convert.ToString(dr["roleName"])
                }).ToList();
                return roleDetails;
            }
            catch (Exception ex)
            {
                newException.AddException(ex.Message, ex.StackTrace);
                return null;
            }
        }
    }
}
