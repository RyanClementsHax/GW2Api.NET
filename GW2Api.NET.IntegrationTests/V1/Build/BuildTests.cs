using GW2Api.NET.V1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V1.Build
{
    [TestClass, TestCategory("Large"), TestCategory("Builds")]
    public class BuildTests
    {
        private IGw2ApiV1 _api;

        [TestInitialize]
        public void Setup()
        {
            _api = new Gw2ApiV1(new HttpClient());
        }

        [TestMethod]
        public async Task GetBuildAsync_NoParams_ReturnsBuild()
        {
            var build = await _api.GetBuildAsync();

            Assert.IsTrue(build.BuildId > 0);
        }

        [TestMethod]
        public async Task GetBuildAsync_CancellationToken_ReturnsBuild()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var build = await _api.GetBuildAsync(cts.Token);

            Assert.IsTrue(build.BuildId > 0);
        }
    }
}
