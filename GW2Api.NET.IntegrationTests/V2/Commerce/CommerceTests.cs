using GW2Api.NET.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


namespace GW2Api.NET.IntegrationTests.V2.Commerce
{
    [TestClass, TestCategory("Large"), TestCategory("V2"), TestCategory("V2 Commerce")]
    public class CommerceTests
    {
        private IGw2ApiV2 _api;

        [TestInitialize]
        public void Setup()
            => _api = new Gw2ApiV2(new HttpClient());

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetCoinsToGemsExchangeInfoAsync_AnyParams_ReturnsTheInfo(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var quantity = 100_000;

            var result = await _api.GetCoinsToGemsExchangeInfoAsync(quantity, cts.GetTokenOrDefault());

            Assert.IsTrue(result.CoinsPerGem > 0);
            Assert.IsTrue(result.Quantity > 0);
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetGemsToCoinsExchangeInfoAsync_AnyParams_ReturnsTheInfo(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var quantity = 100;

            var result = await _api.GetGemsToCoinsExchangeInfoAsync(quantity, cts.GetTokenOrDefault());

            Assert.IsTrue(result.CoinsPerGem > 0);
            Assert.IsTrue(result.Quantity > 0);
        }
    }
}
