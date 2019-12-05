using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace cadastro_conta.webapi.Models
{
    [Serializable]
    public class HttpWebException : WebException
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Mensagem { get; set; }

        public HttpWebException(HttpStatusCode statusCode, string mensagem)
        {
            StatusCode = statusCode;
            Mensagem = mensagem;
        }
    }
}
