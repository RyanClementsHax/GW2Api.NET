using GW2Api.NET.V2.Tokens;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.Tokens
{
    [TestClass, TestCategory("V2 Tokens")]
    public class AuthenticatedTokensTests : AuthenticatedTestsBase
    {
        public static IEnumerable<object[]> CreateSubTokenAsync_TestData()
            => new List<object[]>
            {
                new object [] { Permissions.None, Permissions.Account | Permissions.Inventories },
                new [] { null, new List<string> { "/v2/account/bank", "/v2/account/inventory" } },
                DefaultApiKeys,
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(CreateSubTokenAsync_TestData), DynamicDataSourceType.Method)]
        public async Task CreateSubTokenAsync_ValidApiKey_ReturnsTheTransactions(Permissions permissions, IEnumerable<string> urls, string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.CreateSubTokenAsync(TestData.DefaultExpire, permissions, urls, apiKey, cts?.Token ?? default);

            Assert.IsFalse(string.IsNullOrWhiteSpace(result));
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetTokenInfoAsync_ValidApiKey_ReturnsTheTransactions(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetTokenInfoAsync(apiKey, token: cts?.Token ?? default);

            Assert.IsNotNull(result);
        }
    }
}
