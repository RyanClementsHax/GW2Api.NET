using GW2Api.NET.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.Wvw
{
    [TestClass, TestCategory("Large"), TestCategory("V2"), TestCategory("V2 Wvw")]
    public class WvwTests
    {
        private IGw2ApiV2 _api;

        [TestInitialize]
        public void Setup()
            => _api = new Gw2ApiV2(new HttpClient());

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllWvwAbilityIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllWvwAbilityIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetWvwAbilityAsync_TestData()
            => new List<object[]>
            {
                new object[] { 2 },
                new [] { (null, "Guard Killer"), ("es", "Homicida de guardias") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetWvwAbilityAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwAbilityAsync_ValidId_ReturnsThatWvwAbility(int id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetWvwAbilityAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwAbilitiesAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetWvwAbilitiesAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetWvwAbilitiesAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 2, 3, 4 } },
                new [] {
                    (null, new List<string> { "Guard Killer", "Defense Against Guards", "Mercenary's Bane" }.AsEnumerable()),
                    ("es", new List<string> { "Homicida de guardias", "Defensa contra guardias", "Azote del mercenario" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetWvwAbilitiesAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwAbilitiesAsync_ValidIds_ReturnsThoseWvwAbilities(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetWvwAbilitiesAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllWvwAbilitiesAsync_AnyParams_ReturnsAllWvwAbilities(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllWvwAbilitiesAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwAbilitiesAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetWvwAbilitiesAsync(lang: lang, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllWvwMatchIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllWvwMatchIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwMatchAsync_ValidWorldId_ReturnsThatWvwMatch(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var world = 2001;

            var result = await _api.GetWvwMatchAsync(world, cts.GetTokenOrDefault());

            Assert.IsTrue(result.AllWorlds.Values.SelectMany(x => x).Contains(world));
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwMatchAsync_ValidId_ReturnsThatWvwMatch(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = "2-1";

            var result = await _api.GetWvwMatchAsync(id, cts.GetTokenOrDefault());

            Assert.AreEqual(id, result.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwMatchesAsync_NullIds_ThrowsArgumentNullException(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetWvwMatchesAsync(ids: null, cts.GetTokenOrDefault());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwMatchesAsync_ValidIds_ReturnsThoseWvwMatches(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var ids = new List<string>
            {
                "2-1",
                "2-2",
                "2-3"
            };

            var result = await _api.GetWvwMatchesAsync(ids, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(ids, result.Select(x => x.Id).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllWvwMatchesAsync_AnyParams_ReturnsAllWvwMatches(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllWvwMatchesAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwMatchesAsync_NoIds_ReturnsAPage(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetWvwMatchesAsync(token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }
    }
}
