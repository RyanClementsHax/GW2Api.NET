using GW2Api.NET.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllListingIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllListingIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetListingAsync_ValidId_ReturnsThatListing(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = 24;

            var result = await _api.GetListingAsync(id, cts.GetTokenOrDefault());

            Assert.AreEqual(id, result.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetListingsAsync_NullIds_ThrowsArgumentNullException(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetListingsAsync(ids: null, cts.GetTokenOrDefault());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetListingsAsync_ValidIds_ReturnsThoseListings(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var ids = new List<int> { 24, 68, 69 };

            var result = await _api.GetListingsAsync(ids, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(ids, result.Select(x => x.Id).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetListingsAsync_NoIds_ReturnsAPage(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetListingsAsync(token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }
    }
}
