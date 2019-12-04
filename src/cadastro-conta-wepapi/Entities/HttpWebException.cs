using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace cadastro_conta_wepapi.Entities
{
    public class HttpWebException : WebException
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
