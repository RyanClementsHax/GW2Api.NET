using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.Commerce
{
    [TestClass, TestCategory("V2 Commerce")]
    public class AuthenticatedCommerceTests : AuthenticatedTestsBase
    {
        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCurrentBuyTransactionsAsync_ValidApiKey_ReturnsTheCurrentBuyTransactions(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetCurrentBuyTransactionsAsync(accessToken: apiKey, token: cts.GetTokenOrDefault());

            Assert.IsNotNull(result.Data);
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetCurrentSellTransactionsAsync_ValidApiKey_ReturnsTheCurrentSellTransactions(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetCurrentSellTransactionsAsync(accessToken: apiKey, token: cts.GetTokenOrDefault());

            Assert.IsNotNull(result.Data);
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetHistoricalBuyTransactionsAsync_ValidApiKey_ReturnsTheHistoricalBuyTransactions(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetHistoricalBuyTransactionsAsync(accessToken: apiKey, token: cts.GetTokenOrDefault());

            Assert.IsNotNull(result.Data);
        }

        [DataTestMethod]
        [DynamicData(nameof(DefaultAuthenticatedTestData), typeof(AuthenticatedTestsBase), DynamicDataSourceType.Method)]
        public async Task GetHistoricalSellTransactionsAsync_ValidApiKey_ReturnsTheHistoricalSellTransactions(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetHistoricalSellTransactionsAsync(accessToken: apiKey, token: cts.GetTokenOrDefault());

            Assert.IsNotNull(result.Data);
        }
    }
}
