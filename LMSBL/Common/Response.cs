using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBL.Common
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Data { get; set; }
    }
}
