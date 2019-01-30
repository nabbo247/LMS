﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LMSBL.DBModels;

namespace LMSBL
{
    public class ExecuteSPs
    {
        static string ConnectionString = "";//take from Web.Config
        SqlConnection con = new SqlConnection(ConnectionString);
        public ExecuteSPs()
        {

        }
        public Response ExecuteGetSp(string SPName, List<Param> Params, string ModelType)
        {
            Response response = new Response();
            response.ResponseStatus = false;
            try
            {
                SqlDataReader rdr = null;

                SqlCommand cmd = new SqlCommand(SPName, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                foreach (var param in Params)
                {
                    cmd.Parameters.Add(new SqlParameter(param.Name, param.Value));
                }
                con.Open();
                rdr = cmd.ExecuteReader();
                switch (ModelType)
                {
                    case "tblTenant":
                        response.tblTenant = BindTenantData(rdr);
                        if(response.tblTenant!=null)                        
                            response.ResponseStatus = true;                        
                        break;
                    case "ListActiveTenant":
                        response.lstTenants = BindAllActiveInActiveTenantData(rdr);
                        if(response.lstTenants.Count>0)
                            response.ResponseStatus = true;
                        break;
                    case "ListInActiveTenant":
                        response.lstTenants = BindAllActiveInActiveTenantData(rdr);
                        if (response.lstTenants.Count > 0)
                            response.ResponseStatus = true;
                        break;

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return response;
        }
        public tblTenant BindTenantData(SqlDataReader dr)
        {
            tblTenant objTenant = new tblTenant();
            while (dr.Read())
            {
                
                objTenant.tenantId = Convert.ToInt32(dr["tenantId"]);
                objTenant.tenantName = Convert.ToString(dr["tenantName"]);
                objTenant.tenantDomain = Convert.ToString(dr["tenantDomain"]);
                objTenant.activationFrom = Convert.ToDateTime(dr["activationFrom"]);
                objTenant.activationTo = Convert.ToDateTime(dr["activationTo"]);
                objTenant.isActive = Convert.ToBoolean(dr["isActive"]);
                objTenant.createdBy = Convert.ToInt32(dr["createdBy"]);
                objTenant.createdOn = Convert.ToDateTime(dr["createdOn"]);
                objTenant.noOfUserAllowed = Convert.ToInt32(dr["noOfUserAllowed"]);
                
            }
            return objTenant;
        }

        public List<tblTenant> BindAllActiveInActiveTenantData(SqlDataReader dr)
        {
            List<tblTenant> lstTenants = new List<tblTenant>();
            while (dr.Read())
            {
                tblTenant objTenant = new tblTenant();
                objTenant.tenantId = Convert.ToInt32(dr["tenantId"]);
                objTenant.tenantName = Convert.ToString(dr["tenantName"]);
                objTenant.tenantDomain = Convert.ToString(dr["tenantDomain"]);
                objTenant.activationFrom = Convert.ToDateTime(dr["activationFrom"]);
                objTenant.activationTo = Convert.ToDateTime(dr["activationTo"]);
                objTenant.isActive = Convert.ToBoolean(dr["isActive"]);
                objTenant.createdBy = Convert.ToInt32(dr["createdBy"]);
                objTenant.createdOn = Convert.ToDateTime(dr["createdOn"]);
                objTenant.noOfUserAllowed = Convert.ToInt32(dr["noOfUserAllowed"]);

                lstTenants.Add(objTenant);

            }
            return lstTenants;
        }
    }
}
