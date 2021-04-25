using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.Pvp
{
    [TestClass, TestCategory("V2 Pvp")]
    public class AuthenticatedPvpTests : AuthenticatedTestsBase
    {
        private readonly PvpTestConfig _pvpConfig = _config?.PvpTestConfig;

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetPvpStatsAsync_ValidApiKey_ReturnsTheTransactions(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetPvpStatsAsync(apiKey, token: cts.GetTokenOrDefault());

            Assert.IsNotNull(result);
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAllPvpGameIdsAsync_ValidApiKey_ReturnsAllIds(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllPvpGameIdsAsync(apiKey, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetPvpGameAsync_ValidId_ReturnsThatGame(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            var id = _pvpConfig.Id;
            using var cts = ctsFactory();

            var result = await _api.GetPvpGameAsync(id, apiKey, cts.GetTokenOrDefault());

            Assert.AreEqual(id, result.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetPvpGamesAsync_NullIds_ThrowsArgumentNullException(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetPvpGamesAsync(ids: null, apiKey, cts.GetTokenOrDefault());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetPvpGamesAsync_ValidId_ReturnsThoseGames(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var ids = _pvpConfig.Ids;

            var result = await _api.GetPvpGamesAsync(ids, apiKey, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(ids.ToList(), result.Select(x => x.Id).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task Get10MostRecentPvpGamesAsync_ValidApiKey_Returns10MostRecentGames(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.Get10MostRecentPvpGamesAsync(apiKey, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetPvpGamesAsync_NoIds_ReturnsAPage(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetPvpGamesAsync(accessToken: apiKey, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }
    }
}
