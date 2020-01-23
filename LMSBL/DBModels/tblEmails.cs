using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBL.DBModels
{
    public class tblEmails
    {
        public int Id { get; set; }

        public string EmailTo { get; set; }

        public string EmailSubject { get; set; }

        public string EmailBody { get; set; }

        public DateTime DateCreated { get; set; }

        public bool isSent { get; set; }
        public DateTime DateSent { get; set; }

        public string SentStatus { get; set; }
    }
}
