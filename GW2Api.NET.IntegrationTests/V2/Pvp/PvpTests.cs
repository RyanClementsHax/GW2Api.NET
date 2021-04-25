using GW2Api.NET.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.Pvp
{
    [TestClass, TestCategory("Large"), TestCategory("V2"), TestCategory("V2 Pvp")]
    public class PvpTests
    {
        private IGw2ApiV2 _api;

        [TestInitialize]
        public void Setup()
            => _api = new Gw2ApiV2(new HttpClient());

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllPvpAmuletIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllPvpAmuletIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetPvpAmuletAsync_TestData()
            => new List<object[]>
            {
                new object[] { 4 },
                new [] { (null, "Assassin Amulet"), ("es", "Amuleto de asesino") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetPvpAmuletAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetPvpAmuletAsync_ValidId_ReturnsThatPvpAmulet(int id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetPvpAmuletAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetPvpAmuletsAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetPvpAmuletsAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetPvpAmuletsAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 4, 8, 9 } },
                new [] {
                    (null, new List<string> { "Assassin Amulet", "Berserker Amulet", "Carrion Amulet" }.AsEnumerable()),
                    ("es", new List<string> { "Amuleto de asesino", "Amuleto de berserker", "Amuleto de carroñero" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetPvpAmuletsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetPvpAmuletsAsync_ValidIds_ReturnsThosePvpAmulets(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetPvpAmuletsAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllPvpAmuletsAsync_AnyParams_ReturnsAllFinishers(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllPvpAmuletsAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetPvpAmuletsAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetPvpAmuletsAsync(page: 1, pageSize: 1, lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }
    }
}
