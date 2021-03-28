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
        public async Task GetCharacterIdsAsync_ValidApiKey_ReturnsTheCharactersIds(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetCharacterIdsAsync(apiKey, cts?.Token ?? default);

            CollectionAssert.AreEquivalent(_charactersConfig.CharacterIds.ToList(), result.ToList());
        }
    }
}
