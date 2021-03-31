using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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
        public async Task GetCharacterIdsAsync_ValidApiKey_ReturnsTheCharactersIds(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetCharacterIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.AreEquivalent(_charactersConfig.Ids.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharacterAsync_ValidApiKey_ReturnsTheCharacter(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = _charactersConfig.Id;

            var result = await _api.GetCharacterAsync(id, apiKey, cts?.Token ?? default);

            Assert.AreEqual(id, result.Name);
        }

        [DataTestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharactersAsync_NullIds_ThrowsArgumentNullException(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            List<string> ids = null;
            using var cts = ctsFactory();

            await _api.GetCharactersAsync(ids, apiKey, cts?.Token ?? default);
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharactersAsync_ValidIds_ReturnsTheCharacters(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            var ids = _charactersConfig.Ids;
            using var cts = ctsFactory();

            var result = await _api.GetCharactersAsync(ids, apiKey, cts?.Token ?? default);

            CollectionAssert.AreEquivalent(ids.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetAllCharactersAsync_ValidIds_ReturnsAllCharacters(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllCharactersAsync(apiKey, cts?.Token ?? default);

            Assert.AreEqual(_charactersConfig.TotalCharacters, result.Count);
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharacterBackstoryAsync_ValidId_ReturnsCharacterBackstory(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = _charactersConfig.Id;

            var result = await _api.GetCharacterBackstoryAsync(id, apiKey, cts?.Token ?? default);

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharacterCoreAsync_ValidId_ReturnsCharacterCore(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = _charactersConfig.Id;

            var result = await _api.GetCharacterCoreAsync(id, apiKey, cts?.Token ?? default);

            Assert.AreEqual(id, result.Name);
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharacterCraftingAsync_ValidId_ReturnsCharacterCrafting(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = _charactersConfig.Id;

            var result = await _api.GetCharacterCraftingAsync(id, apiKey, cts?.Token ?? default);

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCharacterEquipmentAsync_ValidId_ReturnsCharacterEquipment(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = _charactersConfig.Id;

            var result = await _api.GetCharacterEquipmentAsync(id, apiKey, cts?.Token ?? default);

            Assert.IsTrue(result.Any());
        }
    }
}
