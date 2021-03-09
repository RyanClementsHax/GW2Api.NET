using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
    }
}
