using GW2Api.NET.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.Guilds
{
    [TestClass, TestCategory("Large"), TestCategory("V2"), TestCategory("V2 Guilds")]
    public class GuildsTests
    {
        private IGw2ApiV2 _api;

        [TestInitialize]
        public void Setup()
            => _api = new Gw2ApiV2(new HttpClient());

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetGuildAsync_ValidId_ReturnsThatGuild(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = Guid.Parse("7FDC213A-9488-E811-81A9-CEE44FED0C20");
            var name = "Snowcrows";

            var result = await _api.GetGuildAsync(id, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }
    }
}
