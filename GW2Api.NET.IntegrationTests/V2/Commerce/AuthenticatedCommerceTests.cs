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
        public async Task GetCurrentBuyTransactionsAsync_ValidApiKey_ReturnsTheTransactions(string apiKey, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetCurrentBuyTransactionsAsync(apiKey, token: cts?.Token ?? default);

            Assert.IsNotNull(result.Data);
        }
    }
}
