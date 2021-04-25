using GW2Api.NET.V2;
using GW2Api.NET.V2.Pvp.Dto;
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
        public async Task GetAllPvpAmuletsAsync_AnyParams_ReturnsAllPvpAmulets(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
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

            var result = await _api.GetPvpAmuletsAsync(lang: lang, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllPvpRankIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllPvpRankIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetPvpRankAsync_TestData()
            => new List<object[]>
            {
                new object[] { 1 },
                new [] { (null, "Rabbit"), ("es", "Conejo") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetPvpRankAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetPvpRankAsync_ValidId_ReturnsThatPvpRank(int id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetPvpRankAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetPvpRanksAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetPvpRanksAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetPvpRanksAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 1, 2, 3 } },
                new [] {
                    (null, new List<string> { "Rabbit", "Deer", "Dolyak" }.AsEnumerable()),
                    ("es", new List<string> { "Conejo", "Ciervo", "Dolyak" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetPvpRanksAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetPvpRanksAsync_ValidIds_ReturnsThosePvpRanks(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetPvpRanksAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllPvpRanksAsync_AnyParams_ReturnsAllPvpRanks(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllPvpRanksAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetPvpRanksAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetPvpRanksAsync(lang: lang, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllPvpSeasonIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllPvpSeasonIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetPvpSeasonAsync_TestData()
            => new List<object[]>
            {
                new object[] { Guid.Parse("9C7BB4A2-71DF-4189-80FC-96A4A14DD46C") },
                new [] { (null, "PvP League Season Eighteen"), ("es", "18.ª temporada de liga PvP") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetPvpSeasonAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetPvpSeasonAsync_ValidId_ReturnsThatPvpSeason(Guid id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetPvpSeasonAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetPvpSeasonsAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetPvpSeasonsAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetPvpSeasonsAsync_TestData()
            => new List<object[]>
            {
                new [] {
                    new List<Guid> {
                        Guid.Parse("9C7BB4A2-71DF-4189-80FC-96A4A14DD46C"),
                        Guid.Parse("07D11E7E-F63C-451D-84F4-D96D369DE5BF"),
                        Guid.Parse("2B2E80D3-0A74-424F-B0EA-E221500B323C"),
                    }
                },
                new [] {
                    (null, new List<string> { "PvP League Season Eighteen", "PvP League Season Sixteen", "PvP League Season Four" }.AsEnumerable()),
                    ("es", new List<string> { "18.ª temporada de liga PvP", "16.ª temporada de liga PvP", "4.ª temporada de liga PvP" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetPvpSeasonsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetPvpSeasonsAsync_ValidIds_ReturnsThosePvpSeasons(IEnumerable<Guid> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetPvpSeasonsAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllPvpSeasonsAsync_AnyParams_ReturnsAllPvpSeasons(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllPvpSeasonsAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetPvpSeasonsAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetPvpSeasonsAsync(lang: lang, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllPvpLeaderboardResultsAsync_AnyParams_ReturnsAllLeaderboards(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var seasonId = Guid.Parse("95D5B290-798A-421E-A919-1C2A75F74B72");
            var leaderboardType = LeaderboardType.Legendary;
            var leagueType = LeagueType.NA;
            var firstPlaceAccountName = "Juice.3710";

            var result = await _api.GetAllPvpLeaderboardResultsAsync(seasonId, leaderboardType, leagueType, cts.GetTokenOrDefault());

            Assert.AreEqual(firstPlaceAccountName, result.Single(x => x.Rank == 1).Name);
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetPvpLeaderboardResultsAsync_NoIds_ReturnsAPage(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var seasonId = Guid.Parse("2B2E80D3-0A74-424F-B0EA-E221500B323C");
            var leaderboardType = LeaderboardType.Guild;
            var leagueType = LeagueType.NA;
            var firstPlaceAccountName = "Ironclad Losers";

            var result = await _api.GetPvpLeaderboardResultsAsync(seasonId, leaderboardType, leagueType, token: cts.GetTokenOrDefault());

            Assert.AreEqual(firstPlaceAccountName, result.Data.Single(x => x.Rank == 1).Name);
        }
    }
}
