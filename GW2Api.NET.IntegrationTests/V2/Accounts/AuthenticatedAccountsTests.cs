using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.Accounts
{
    [TestClass, TestCategory("V2 Accounts")]
    public class AuthenticatedAccountsTests : AuthenticatedTestsBase
    {
        private readonly AccountConfig _accountConfig = _config?.AccountConfig;

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountAsync_ValidApiKey_ReturnsTheAccount(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountAsync(apiKey, cts?.Token ?? default);

            Assert.AreEqual(_accountConfig.Name, result.Name);
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAllAccountAchievementsAsync_ValidApiKey_ReturnsTheAccountAchievements(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllAccountAchievementsAsync(apiKey, cts?.Token ?? default);

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountAchievementAsync_ValidId_ReturnsThatAchievement(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            var id = _accountConfig.AchievementIds.First();
            using var cts = ctsFactory();

            var result = await _api.GetAccountAchievementAsync(id, apiKey, cts?.Token ?? default);

            Assert.AreEqual(id, result.Id);
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountAchievementsAsync_ValidId_ReturnsThatAchievement(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            var ids = _accountConfig.AchievementIds;
            using var cts = ctsFactory();

            var result = await _api.GetAccountAchievementsAsync(ids, apiKey, cts?.Token ?? default);

            CollectionAssert.AreEquivalent(ids.ToList(), result.Select(x => x.Id).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountBankAsync_ValidApiKey_ReturnsTheBank(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountBankAsync(apiKey, cts?.Token ?? default);

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountDailyCraftingIdsAsync_ValidApiKey_ReturnsTheAccountsDailyCrafting(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountDailyCraftingIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.DailyCraftingIds.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountDungeonIdsAsync_ValidApiKey_ReturnsTheAccountsDungeons(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountDungeonIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.DungeonIds.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountDyeIdsAsync_ValidApiKey_ReturnsTheAccountsDyes(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountDyeIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.DyeIds.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountFinishersAsync_ValidApiKey_ReturnsTheAccountsFinishers(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountFinishersAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.FinisherIds.ToList(), result.Select(x => x.Id).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountGliderIdsAsync_ValidApiKey_ReturnsTheAccountsGliders(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountGliderIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.GliderIds.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountHomeCatIdsAsync_ValidApiKey_ReturnsTheAccountsHomeCats(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountHomeCatIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.HomeCatIds.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountHomeNodeIdsAsync_ValidApiKey_ReturnsTheAccountsHomeNodes(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountHomeNodeIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.HomeNodeIds.ToList(), result.ToList());
        }
    }
}
