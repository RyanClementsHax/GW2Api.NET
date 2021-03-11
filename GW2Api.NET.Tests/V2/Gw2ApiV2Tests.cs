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
            _mockHandler.Protected()
               .Setup<Task<HttpResponseMessage>>(
                  "SendAsync",
                  ItExpr.IsAny<HttpRequestMessage>(),
                  ItExpr.IsAny<CancellationToken>()
               )
               .ReturnsAsync(new HttpResponseMessage()
               {
                   StatusCode = HttpStatusCode.OK,
                   Content = new StringContent("{}"),
               })
               .Verifiable();

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

        [TestMethod]
        public async Task GetAuthenticatedAsync_NoToken_UsesDefault()
        {
            var api = new Gw2ApiV2(new HttpClient(_mockHandler.Object))
            {
                ApiKey = "default_key"
            };

            await api.GetAuthenticatedAsync<object>("/some/resource");

            _mockHandler.Protected().Verify(
                "SendAsync",
                Times.Exactly(1),
                ItExpr.Is<HttpRequestMessage>(req =>
                    req.Method == HttpMethod.Get
                    && req.RequestUri.ToString().Contains($"access_token={api.ApiKey}")
                ),
                ItExpr.IsAny<CancellationToken>()
            );
        }

        [TestMethod]
        public async Task GetAuthenticatedAsync_Token_UsesThatToken()
        {
            var api = new Gw2ApiV2(new HttpClient(_mockHandler.Object))
            {
                ApiKey = "default_key"
            };
            var token = $"not_{api.ApiKey}";

            await api.GetAuthenticatedAsync<object>("/some/resource", token);

            _mockHandler.Protected().Verify(
                "SendAsync",
                Times.Exactly(1),
                ItExpr.Is<HttpRequestMessage>(req =>
                    req.Method == HttpMethod.Get
                    && req.RequestUri.ToString().Contains($"access_token={token}")
                ),
                ItExpr.IsAny<CancellationToken>()
            );
        }
    }
}
