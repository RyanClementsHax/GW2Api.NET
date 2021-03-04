using GW2Api.NET.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Protected;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2
{
    [TestClass, TestCategory("V2"), TestCategory("Small")]
    public class Gw2ApiV2Tests
    {
        private IGw2ApiV2 _api;
        private Mock<HttpMessageHandler> _mockHandler;

        [TestInitialize]
        public void Setup()
        {
            _mockHandler = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            _api = new Gw2ApiV2(new HttpClient(_mockHandler.Object));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Gw2ApiV1Ctor_NullHttpClient_ArgNullEx()
            => new Gw2ApiV2(null);

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task GetAsync_WithQueryParamsThatSpecifyVersion_ThrowsInvalidOperationException()
        {
            var paramMap = new Dictionary<string, string>
            {
                { "v", "some version" }
            };
            var api = new Gw2ApiV2(new HttpClient(_mockHandler.Object));

            await api.GetAsync<object>("/some/resource", paramMap);
        }
    }
}
