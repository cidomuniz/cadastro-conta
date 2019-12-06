using cadastro_conta.webapi.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace cadastro_conta.test.Models
{
    [TestClass]
    public class HttpWebExceptionTest
    {
        private const string message = "";
        private const HttpStatusCode httpStatusCode = HttpStatusCode.BadRequest;


        [TestMethod]
        public void HttpWebException()
        {
            HttpWebException httpWebException = new HttpWebException(httpStatusCode, message);

            Assert.AreEqual(message, httpWebException.Mensagem);
            Assert.AreEqual(httpStatusCode, httpWebException.StatusCode);
        }

    }
}
