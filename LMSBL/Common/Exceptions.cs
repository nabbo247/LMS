using LMSBL.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBL.Common
{
    public class Exceptions
    {
        public void AddException(string message,string stackTrace)
        {
            DataRepository db = new DataRepository();
            db.AddParameter("@message", SqlDbType.NText, message);
            db.AddParameter("@stackTrace", SqlDbType.NText, stackTrace);
            db.ExecuteQuery("AddError");
        }
    }
}
