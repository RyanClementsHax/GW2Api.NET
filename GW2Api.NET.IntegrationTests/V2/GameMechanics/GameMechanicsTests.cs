using GW2Api.NET.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.GameMechanics
{
    [TestClass, TestCategory("Large"), TestCategory("V2"), TestCategory("V2 Game Mechanics")]
    public class GameMechanicsTests
    {
        private IGw2ApiV2 _api;

        [TestInitialize]
        public void Setup()
            => _api = new Gw2ApiV2(new HttpClient());

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllMasteryIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllMasteryIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetMasteryAsync_TestData()
            => new List<object[]>
            {
                new object[] { 1 },
                new [] { (null, "Exalted Lore"), ("es", "Conocimientos exaltados") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetMasteryAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetMasteryAsync_ValidId_ReturnsThatMastery(int id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetMasteryAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetMasteriesAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetMasteriesAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetMasteriesAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 1, 2, 3 } },
                new [] {
                    (null, new List<string> { "Exalted Lore", "Itzel Lore", "Nuhoch Lore" }.AsEnumerable()),
                    ("es", new List<string> { "Conocimientos exaltados", "Conocimientos itzel", "Conocimientos nuhoch" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetMasteriesAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetMasteriesAsync_ValidIds_ReturnsThoseMasteries(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetMasteriesAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllMasteriesAsync_AnyParams_ReturnsAllMasteries(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllMasteriesAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllMountSkinIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllMountSkinIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetMountSkinAsync_TestData()
            => new List<object[]>
            {
                new object[] { 2 },
                new [] { (null, "Skimmer"), ("es", "Mantarraya") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetMountSkinAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetMountSkinAsync_ValidId_ReturnsThatMountSkin(int id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetMountSkinAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetMountSkinsAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetMountSkinsAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetMountSkinsAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 2, 3, 4 } },
                new [] {
                    (null, new List<string> { "Skimmer", "Springer", "Griffon" }.AsEnumerable()),
                    ("es", new List<string> { "Mantarraya", "Saltarín", "Grifo" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetMountSkinsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetMountSkinsAsync_ValidIds_ReturnsThoseMountSkins(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetMountSkinsAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllMountSkinsAsync_AnyParams_ReturnsAllMountSkins(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllMountSkinsAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetMountSkinsAsync_ValidId_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetMountSkinsAsync(lang: lang, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }
    }
}
