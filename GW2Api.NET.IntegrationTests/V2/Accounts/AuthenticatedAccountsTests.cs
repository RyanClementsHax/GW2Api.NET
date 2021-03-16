using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.Accounts
{
    [TestClass, TestCategory("V2 Accounts")]
    public class AuthenticatedAccountsTests : AuthenticatedTestsBase
    {
        private readonly AccountTestConfig _accountConfig = _config?.AccountTestConfig;

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
            var id = (_accountConfig.AchievementIds ?? new List<int>()).First();
            using var cts = ctsFactory();

            var result = await _api.GetAccountAchievementAsync(id, apiKey, cts?.Token ?? default);

            Assert.AreEqual(id, result.Id);
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountAchievementsAsync_ValidId_ReturnsThatAchievement(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            var ids = _accountConfig.AchievementIds ?? new List<int>();
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
        public async Task GetAccountFinisherSummariesAsync_ValidApiKey_ReturnsTheAccountsFinishers(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountFinisherSummariesAsync(apiKey, cts?.Token ?? default);

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

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountSharedInventorySlotsAsync_ValidApiKey_ReturnsTheAccountsSharedInventorySlots(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountSharedInventorySlotsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.SharedInventoryItemIds.ToList(), result.Select(x => x.Id).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountLuckAsync_ValidApiKey_ReturnsTheAccountsLuck(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountLuckAsync(apiKey, cts?.Token ?? default);

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountMailCarrierIdsAsync_ValidApiKey_ReturnsTheMailCarriers(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountMailCarrierIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.MailCarrierIds.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountMapChestIdsAsync_ValidApiKey_ReturnsTheAccountsMapChests(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountMapChestIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.MapChestIds.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountMasterySummariesAsync_ValidApiKey_ReturnsTheAccountsMasteries(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountMasterySummariesAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.MasteryIds.ToList(), result.Select(x => x.Id).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountMasteryPointSummaryAsync_ValidApiKey_ReturnsTheAccountsMasteryPointSummary(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountMasteryPointSummaryAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.MasteryPointSummaryData.Regions.ToList(), result.Totals.Select(x => x.Region).ToList());
            CollectionAssert.IsSubsetOf(_accountConfig.MasteryPointSummaryData.MasteryIds.ToList(), result.Unlocked.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountMaterialSummariesAsync_ValidApiKey_ReturnsTheAccountsMaterialSummaries(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountMaterialSummariesAsync(apiKey, cts?.Token ?? default);

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountMinisIdsAsync_ValidApiKey_ReturnsTheAccountsMinis(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountMinisIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.MinisIds.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountMountSkinIdsAsync_ValidApiKey_ReturnsTheAccountsMountSkins(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountMountSkinIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.MountSkinIds.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountMountTypeIdsAsync_ValidApiKey_ReturnsTheAccountsMountTypes(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountMountTypeIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.MountTypes.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountNoveltyIdsAsync_ValidApiKey_ReturnsTheAccountsNovelties(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountNoveltyIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.NoveltyIds.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountOutfitIdsAsync_ValidApiKey_ReturnsTheAccountsOutfits(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountOutfitIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.OutfitIds.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountPvpHeroIdsAsync_ValidApiKey_ReturnsTheAccountsPvpHeros(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountPvpHeroIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.PvpHeroIds.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountRaidIdsAsync_ValidApiKey_ReturnsTheAccountsRaids(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountRaidIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.RaidIds.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountRecipeIdsAsync_ValidApiKey_ReturnsTheAccountsRecipes(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountRecipeIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.RecipeIds.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountSkinIdsAsync_ValidApiKey_ReturnsTheAccountsSkins(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountSkinIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.SkinIds.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountTitleIdsAsync_ValidApiKey_ReturnsTheAccountsTitles(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountTitleIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.TitleIds.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountWalletAsync_ValidApiKey_ReturnsTheAccountsWallet(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountWalletAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.CurrencyIds.ToList(), result.Select(x => x.Id).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAccountWorldBossIdsAsync_ValidApiKey_ReturnsTheAccountsWorldBosses(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAccountWorldBossIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.IsSubsetOf(_accountConfig.WorldBossIds.ToList(), result.ToList());
        }
    }
}
