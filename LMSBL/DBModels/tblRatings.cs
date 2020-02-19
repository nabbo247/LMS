using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBL.DBModels
{
    public class tblRatings
    {
        public int ActivityId { get; set; }

        public int UserId { get; set; }

        public int Attempt { get; set; }
        public string ActivityType { get; set; }
        public decimal Rating { get; set; }

        public string Comment { get; set; }

        public int TenantId { get; set; }
    }
}
