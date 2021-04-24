using GW2Api.NET.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.Worlds
{
    [TestClass, TestCategory("Large"), TestCategory("V2"), TestCategory("V2 Worlds")]
    public class WorldsTests
    {
        private IGw2ApiV2 _api;

        [TestInitialize]
        public void Setup()
            => _api = new Gw2ApiV2(new HttpClient());

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllWorldIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllWorldIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetWorldAsync_TestData()
            => new List<object[]>
            {
                new object[] { 1001 },
                new [] { (null, "Anvil Rock"), ("es", "Roca del Yunque") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetWorldAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetWorldAsync_ValidId_ReturnsThatWorld(int id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetWorldAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWorldsAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetWorldsAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetWorldsAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 1001 , 1002, 1003 } },
                new [] {
                    (null, new List<string> { "Anvil Rock", "Borlis Pass", "Yak's Bend" }.AsEnumerable()),
                    ("es", new List<string> { "Roca del Yunque", "Paso de Borlis", "Declive del Yak" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetWorldsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetWorldsAsync_ValidIds_ReturnsThoseWorlds(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetWorldsAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllWorldsAsync_AnyParams_ReturnsAllWorlds(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllWorldsAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWorldsAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetWorldsAsync(lang: lang, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }
    }
}
