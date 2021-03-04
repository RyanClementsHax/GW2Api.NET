using GW2Api.NET.V1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Protected;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V1
{
    [TestClass, TestCategory("V1"), TestCategory("Small")]
    public class Gw2ApiV1Tests
    {
        private IGw2ApiV1 _api;
        private Mock<HttpMessageHandler> _mockHandler;

        [TestInitialize]
        public void Setup()
        {
            _mockHandler = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            _api = new Gw2ApiV1(new HttpClient());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Gw2ApiV1Ctor_NullHttpClient_ArgNullEx()
            => new Gw2ApiV1(null);
    }
}
