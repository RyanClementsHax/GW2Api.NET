using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.Guilds
{
    [TestClass, TestCategory("V2 Guilds")]
    public class AuthenticatedGuildsTests : AuthenticatedTestsBase
    {
        private readonly GuildsTestConfig _guildsConfig = _config?.GuildsTestConfig;

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetGuildLogsAsync_ValidApiKeyAndNoSinceId_ReturnsTheGuildLogs(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetGuildLogsAsync(_guildsConfig.Id, accessToken: _guildsConfig.ApiKey, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetGuildLogsAsync_ValidApiKeyAndSinceId_ReturnsTheGuildLogsSineThatId(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var logs = await _api.GetGuildLogsAsync(_guildsConfig.Id, accessToken: _guildsConfig.ApiKey, token: cts.GetTokenOrDefault());

            var middleLog = logs.ElementAt(logs.Count / 2);
            var logsSinceMiddleLog = logs.Where(x => x.Time > middleLog.Time);

            var result = await _api.GetGuildLogsAsync(_guildsConfig.Id, since: middleLog.Id, _guildsConfig.ApiKey, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
            Assert.IsTrue(logs.Count > result.Count);
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetGuildMembersAsync_ValidApiKeyAndNoSinceId_ReturnsTheGuildMembers(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetGuildMembersAsync(_guildsConfig.Id, accessToken: _guildsConfig.ApiKey, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetGuildRanksAsync_ValidApiKeyAndNoSinceId_ReturnsTheGuildRanks(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetGuildRanksAsync(_guildsConfig.Id, accessToken: _guildsConfig.ApiKey, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetGuildStashAsync_ValidApiKeyAndNoSinceId_ReturnsTheGuildStash(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetGuildStashAsync(_guildsConfig.Id, accessToken: _guildsConfig.ApiKey, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetGuildStorageAsync_ValidApiKeyAndNoSinceId_ReturnsTheGuildStorage(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetGuildStorageAsync(_guildsConfig.Id, accessToken: _guildsConfig.ApiKey, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetGuildTreasuryAsync_ValidApiKeyAndNoSinceId_ReturnsTheGuildTreasury(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetGuildTreasuryAsync(_guildsConfig.Id, accessToken: _guildsConfig.ApiKey, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetGuildTeamsAsync_ValidApiKeyAndNoSinceId_ReturnsTheGuildTeams(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetGuildTeamsAsync(_guildsConfig.Id, accessToken: _guildsConfig.ApiKey, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }
    }
}
