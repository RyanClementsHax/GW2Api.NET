using GW2Api.NET.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.Dailies
{
    [TestClass, TestCategory("Large"), TestCategory("V2"), TestCategory("V2 Dailies")]
    public class DailiesTests
    {
        private IGw2ApiV2 _api;

        [TestInitialize]
        public void Setup()
            => _api = new Gw2ApiV2(new HttpClient());

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllAvailableTimeGatedRecipeIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllTimeGatedRecipeIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetTimeGatedRecipeAsync_ValidId_ReturnsThatTimeGatedRecipe(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = "charged_quartz_crystal";

            var result = await _api.GetTimeGatedRecipeAsync(id, cts.GetTokenOrDefault());

            Assert.AreEqual(id, result.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetTimeGatedRecipesAsync_NullIds_ThrowsArgumentNullException(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetTimeGatedRecipesAsync(ids: null, cts.GetTokenOrDefault());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetTimeGatedRecipesAsync_ValidIds_ReturnsThoseTimeGatedRecipes(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var ids = new List<string>
            {
                "charged_quartz_crystal",
                "glob_of_elder_spirit_residue",
                "lump_of_mithrilium"
            };

            var result = await _api.GetTimeGatedRecipesAsync(ids, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(ids, result.Select(x => x.Id).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllTimeGatedRecipesAsync_AnyParams_ReturnsAllTimeGatedRecipes(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllTimeGatedRecipesAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetTimeGatedRecipesAsync_NoIds_ReturnsAPage(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetTimeGatedRecipesAsync(token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllAvailableMapChestIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllMapChestIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetMapChestAsync_ValidId_ReturnsThatMapChest(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = "auric_basin_heros_choice_chest";

            var result = await _api.GetMapChestAsync(id, cts.GetTokenOrDefault());

            Assert.AreEqual(id, result.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetMapChestsAsync_NullIds_ThrowsArgumentNullException(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetMapChestsAsync(ids: null, cts.GetTokenOrDefault());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetMapChestsAsync_ValidIds_ReturnsThoseMapChests(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var ids = new List<string>
            {
                "auric_basin_heros_choice_chest",
                "crystal_oasis_heros_choice_chest",
                "domain_of_vabbi_heros_choice_chest"
            };

            var result = await _api.GetMapChestsAsync(ids, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(ids, result.Select(x => x.Id).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllMapChestsAsync_AnyParams_ReturnsAllTimeGatedRecipes(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllMapChestsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetMapChestsAsync_NoIds_ReturnsAPage(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetMapChestsAsync(token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllWorldBossIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllWorldBossIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWorldBossAsync_ValidId_ReturnsThatWorldBoss(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = "admiral_taidha_covington";

            var result = await _api.GetWorldBossAsync(id, cts.GetTokenOrDefault());

            Assert.AreEqual(id, result.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWorldBossesAsync_NullIds_ThrowsArgumentNullException(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetWorldBossesAsync(ids: null, cts.GetTokenOrDefault());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWorldBossesAsync_ValidIds_ReturnsThoseWorldBosses(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var ids = new List<string>
            {
                "admiral_taidha_covington",
                "claw_of_jormag",
                "drakkar"
            };

            var result = await _api.GetWorldBossesAsync(ids, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(ids, result.Select(x => x.Id).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllWorldBossesAsync_AnyParams_ReturnsAllWorldBosses(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllWorldBossesAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetWorldBossesAsync_NoIds_ReturnsAPage(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetWorldBossesAsync(token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }
    }
}
