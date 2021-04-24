using GW2Api.NET.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.Home
{
    [TestClass, TestCategory("Large"), TestCategory("V2"), TestCategory("V2 Home")]
    public class HomeTests
    {
        private IGw2ApiV2 _api;

        [TestInitialize]
        public void Setup()
            => _api = new Gw2ApiV2(new HttpClient());

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllHomeCatIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllHomeCatIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetHomeCatAsync_ValidId_ReturnsThatHomeCat(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = 1;

            var result = await _api.GetHomeCatAsync(id, cts.GetTokenOrDefault());

            Assert.AreEqual(id, result.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetHomeCatsAsync_NullIds_ThrowsArgumentNullException(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetHomeCatsAsync(ids: null, cts.GetTokenOrDefault());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetHomeCatsAsync_ValidIds_ReturnsThoseHomeCats(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var ids = new List<int> { 1, 2, 3 };

            var result = await _api.GetHomeCatsAsync(ids, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(ids, result.Select(x => x.Id).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllHomeCatsAsync_AnyParams_ReturnsAllHomeCats(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllHomeCatsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetHomeCatsAsync_NoIds_ReturnsAPage(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetHomeCatsAsync(page: 1, pageSize: 1, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }
    }
}
