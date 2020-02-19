using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;


namespace HRS.CoursePlayer
{
   public class TrackingDAL
    {
       public static void ManageTracking(Tracking track)
       {
           try
           {
               DbProviderFactory fact = DbProviderFactories.GetFactory(Config.DbType);
               using (DbConnection conn = Config.GetConnection())
               {
                   DbCommand cmd = fact.CreateCommand();
                   cmd.CommandTimeout = 0;
                   cmd.Connection = conn;
                   cmd.CommandText = "sp_ManageTracking";
                   cmd.Parameters.Add(Config.GetParameter(fact, "@LearnerId", track.LearnerId));
                   cmd.Parameters.Add(Config.GetParameter(fact, "@ContentModuleId", track.ContentModuleId));
                   cmd.Parameters.Add(Config.GetParameter(fact, "@CurriculumId", track.CurriculumId));
                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.ExecuteNonQuery();
               }
           }
           catch (Exception ex)
           {
               clsErrorhandling objerror = new clsErrorhandling();
               objerror.LogException(ex, "Tracking", "ManageTracking");
           }
       }
    }
}
