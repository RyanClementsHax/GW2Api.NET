using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.Characters
{
    [TestClass, TestCategory("V2 Characters")]
    public class AuthenticatedCharactersTests : AuthenticatedTestsBase
    {
        private readonly CharactersTestConfig _charactersConfig = _config?.CharactersTestConfig;

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAllCharacterIdsAsync_ValidApiKey_ReturnsTheCharactersIds(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllCharacterIdsAsync(apiKey, cts.GetTokenOrDefault());

            CollectionAssert.IsSubsetOf(_charactersConfig.Ids.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharacterAsync_ValidApiKey_ReturnsTheCharacter(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = _charactersConfig.Id;

            var result = await _api.GetCharacterAsync(id, apiKey, cts.GetTokenOrDefault());

            Assert.AreEqual(id, result.Name);
        }

        [DataTestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharactersAsync_NullIds_ThrowsArgumentNullException(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetCharactersAsync(ids: null, apiKey, cts.GetTokenOrDefault());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharactersAsync_ValidIds_ReturnsTheCharacters(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            var ids = _charactersConfig.Ids;
            using var cts = ctsFactory();

            var result = await _api.GetCharactersAsync(ids, apiKey, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(ids.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAllCharactersAsync_ValidIds_ReturnsAllCharacters(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllCharactersAsync(apiKey, cts.GetTokenOrDefault());

            Assert.AreEqual(_charactersConfig.TotalCharacters, result.Count);
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharactersAsync_NoIds_ReturnsAPage(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetCharactersAsync(page: 0, accessToken: apiKey, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharacterBackstoryAsync_ValidId_ReturnsCharacterBackstory(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = _charactersConfig.Id;

            var result = await _api.GetCharacterBackstoryAsync(id, apiKey, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharacterCoreAsync_ValidId_ReturnsCharacterCore(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = _charactersConfig.Id;

            var result = await _api.GetCharacterCoreAsync(id, apiKey, cts.GetTokenOrDefault());

            Assert.AreEqual(id, result.Name);
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharacterCraftingAsync_ValidId_ReturnsCharacterCrafting(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = _charactersConfig.Id;

            var result = await _api.GetCharacterCraftingAsync(id, apiKey, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharacterEquipmentAsync_ValidId_ReturnsCharacterEquipment(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = _charactersConfig.Id;

            var result = await _api.GetCharacterEquipmentAsync(id, apiKey, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharacterHeroPointsAsync_ValidId_ReturnsCharacterHeropoints(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = _charactersConfig.Id;

            var result = await _api.GetCharacterHeroPointsAsync(id, apiKey, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharacterInventoryAsync_ValidId_ReturnsCharacterInventory(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = _charactersConfig.Id;

            var result = await _api.GetCharacterInventoryAsync(id, apiKey, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharacterRecipesAsync_ValidId_ReturnsCharacterRecipes(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = _charactersConfig.Id;

            var result = await _api.GetCharacterRecipesAsync(id, apiKey, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharacterSabAsync_ValidId_ReturnsCharacterSab(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = _charactersConfig.SabConfig.Id;

            var result = await _api.GetCharacterSabAsync(id, apiKey, cts.GetTokenOrDefault());

            CollectionAssert.IsSubsetOf(_charactersConfig.SabConfig.ZoneIds.ToList(), result.Zones.Select(x => x.Id).ToList());
            CollectionAssert.IsSubsetOf(_charactersConfig.SabConfig.UnlockIds.ToList(), result.Unlocks.Select(x => x.Id).ToList());
            CollectionAssert.IsSubsetOf(_charactersConfig.SabConfig.SongIds.ToList(), result.Songs.Select(x => x.Id).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharacterSkillsAsync_ValidId_ReturnsCharacterSkills(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = _charactersConfig.Id;

            var result = await _api.GetCharacterSkillsAsync(id, apiKey, cts.GetTokenOrDefault());

            Assert.IsNotNull(result);
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharacterSpecializationsAsync_ValidId_ReturnsCharacterSkills(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = _charactersConfig.Id;

            var result = await _api.GetCharacterSpecializationsAsync(id, apiKey, cts.GetTokenOrDefault());

            Assert.IsNotNull(result);
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharacterTrainingAsync_ValidId_ReturnsCharacterSkills(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = _charactersConfig.Id;

            var result = await _api.GetCharacterTrainingAsync(id, apiKey, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }
    }
}
