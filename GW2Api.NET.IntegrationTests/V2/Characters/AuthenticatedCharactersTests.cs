﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var id = _charactersConfig.Ids.FirstOrDefault();
            if (id is null) Assert.Fail("You must configure at least one character id in v2.config.json to run this test");

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
    }
}