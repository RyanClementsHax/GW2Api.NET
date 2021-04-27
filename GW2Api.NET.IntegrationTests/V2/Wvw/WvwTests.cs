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

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllWvwOverviewIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllWvwOverviewIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwOverviewAsync_ValidWorldId_ReturnsThatWvwOverview(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var world = 2001;

            var result = await _api.GetWvwOverviewAsync(world, cts.GetTokenOrDefault());

            Assert.IsTrue(result.AllWorlds.Values.SelectMany(x => x).Contains(world));
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwOverviewAsync_ValidId_ReturnsThatWvwOverview(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = "2-1";

            var result = await _api.GetWvwOverviewAsync(id, cts.GetTokenOrDefault());

            Assert.AreEqual(id, result.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwOverviewsAsync_NullIds_ThrowsArgumentNullException(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetWvwOverviewsAsync(ids: null, cts.GetTokenOrDefault());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwOverviewsAsync_ValidIds_ReturnsThoseWvwOverviewes(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var ids = new List<string>
            {
                "2-1",
                "2-2",
                "2-3"
            };

            var result = await _api.GetWvwOverviewsAsync(ids, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(ids, result.Select(x => x.Id).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllWvwOverviewsAsync_AnyParams_ReturnsAllWvwOverviewes(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllWvwOverviewsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwOverviewsAsync_NoIds_ReturnsAPage(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetWvwOverviewsAsync(token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllWvwScoreIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllWvwScoreIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwScoreAsync_ValidWorldId_ReturnsThatWvwScore(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var world = 2001;

            var result = await _api.GetWvwScoreAsync(world, cts.GetTokenOrDefault());

            Assert.IsNotNull(result);
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwScoreAsync_ValidId_ReturnsThatWvwScore(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = "2-1";

            var result = await _api.GetWvwScoreAsync(id, cts.GetTokenOrDefault());

            Assert.AreEqual(id, result.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwScoresAsync_NullIds_ThrowsArgumentNullException(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetWvwScoresAsync(ids: null, cts.GetTokenOrDefault());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwScoresAsync_ValidIds_ReturnsThoseWvwScorees(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var ids = new List<string>
            {
                "2-1",
                "2-2",
                "2-3"
            };

            var result = await _api.GetWvwScoresAsync(ids, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(ids, result.Select(x => x.Id).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllWvwScoresAsync_AnyParams_ReturnsAllWvwScorees(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllWvwScoresAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwScoresAsync_NoIds_ReturnsAPage(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetWvwScoresAsync(token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllWvwStatsIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllWvwStatsIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwStatsAsync_ValidWorldId_ReturnsThatWvwStats(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var world = 2001;

            var result = await _api.GetWvwStatsAsync(world, cts.GetTokenOrDefault());

            Assert.IsNotNull(result);
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwStatsAsync_ValidId_ReturnsThatWvwStats(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = "2-1";

            var result = await _api.GetWvwStatsAsync(id, cts.GetTokenOrDefault());

            Assert.AreEqual(id, result.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwStatsAsync_NullIds_ThrowsArgumentNullException(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetWvwStatsAsync(ids: null, cts.GetTokenOrDefault());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwStatsAsync_ValidIds_ReturnsThoseWvwStatses(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var ids = new List<string>
            {
                "2-1",
                "2-2",
                "2-3"
            };

            var result = await _api.GetWvwStatsAsync(ids, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(ids, result.Select(x => x.Id).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllWvwStatsAsync_AnyParams_ReturnsAllWvwStatses(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllWvwStatsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwStatsAsync_NoIds_ReturnsAPage(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetWvwStatsAsync(token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllWvwObjectiveIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllWvwObjectiveIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetWvwObjectiveAsync_TestData()
            => new List<object[]>
            {
                new object[] { "968-98" },
                new [] { (null, "Wurm Tunnel"), ("es", "Túnel de la Sierpe") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetWvwObjectiveAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwObjectiveAsync_ValidId_ReturnsThatWvwObjective(string id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetWvwObjectiveAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwObjectivesAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetMountSkinsAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetWvwObjectivesAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<string> { "968-98", "968-96", "968-82" } },
                new [] {
                    (null, new List<string> { "Wurm Tunnel", "Airport", "Thunder Hollow Reactor" }.AsEnumerable()),
                    ("es", new List<string> { "Túnel de la Sierpe", "Aeropuerto", "Reactor de Hondonada del Trueno" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetWvwObjectivesAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwObjectivesAsync_ValidIds_ReturnsThoseWvwObjectives(IEnumerable<string> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetWvwObjectivesAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllWvwObjectivesAsync_AnyParams_ReturnsAllWvwObjectives(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllWvwObjectivesAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwObjectivesAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetWvwObjectivesAsync(lang: lang, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllWvwRankIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllWvwRankIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetWvwRankAsync_TestData()
            => new List<object[]>
            {
                new object[] { 1 },
                new [] { (null, "Invader"), ("es", "Invasor") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetWvwRankAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwRankAsync_ValidId_ReturnsThatWvwRank(int id, (CultureInfo, string) langTitleTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, title) = langTitleTuple;

            var result = await _api.GetWvwRankAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(title, result.Title);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwRanksAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetWvwRanksAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetWvwRanksAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 1, 2, 3 } },
                new [] {
                    (null, new List<string> { "Invader", "Assaulter", "Raider" }.AsEnumerable()),
                    ("es", new List<string> { "Invasor", "Asaltante", "Atracador" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetWvwRanksAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwRanksAsync_ValidIds_ReturnsThoseWvwRanks(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langTitlesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, titles) = langTitlesTuple;

            var result = await _api.GetWvwRanksAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(titles.ToList(), result.Select(x => x.Title).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllWvwRanksAsync_AnyParams_ReturnsAllWvwRanks(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllWvwRanksAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWvwRanksAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetWvwRanksAsync(lang: lang, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }
    }
}
