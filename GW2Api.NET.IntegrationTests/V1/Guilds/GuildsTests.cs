using GW2Api.NET.V1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V1.Guilds
{
    [TestClass, TestCategory("Large"), TestCategory("Guilds")]
    public class GuildsTests
    {
        private IGw2ApiV1 _api;

        [TestInitialize]
        public void Setup() => _api = new Gw2ApiV1(new HttpClient());

        [TestMethod]
        public async Task GetGuildDetailAsync_GuildIdThatExists_ReturnsThatGuildDetail()
        {
            var guildId = new Guid("75FD83CF-0C45-4834-BC4C-097F93A487AF");

            var guildDetail = await _api.GetGuildDetailAsync(guildId);

            Assert.AreEqual(guildId, guildDetail.GuildId);
        }

        [TestMethod]
        public async Task GetGuildDetailAsync_GuildIdThatExistsAndCancellationToken_ReturnsThatGuildDetail()
        {
            using var cts = TestData.CreateDefaultTokenSource();
            var guildId = new Guid("75FD83CF-0C45-4834-BC4C-097F93A487AF");

            var guildDetail = await _api.GetGuildDetailAsync(guildId, cts.Token);

            Assert.AreEqual(guildId, guildDetail.GuildId);
        }

        [TestMethod]
        public async Task GetGuildDetailAsync_GuildNameThatExists_ReturnsThatGuildDetail()
        {
            var guildName = "Veterans Of Lions Arch";

            var guildDetail = await _api.GetGuildDetailAsync(guildName);

            Assert.AreEqual(guildName, guildDetail.GuildName);
        }

        [TestMethod]
        public async Task GetGuildDetailAsync_GuildNameThatExistsAndCancellationToken_ReturnsThatGuildDetail()
        {
            using var cts = TestData.CreateDefaultTokenSource();
            var guildName = "Veterans Of Lions Arch";

            var guildDetail = await _api.GetGuildDetailAsync(guildName, cts.Token);

            Assert.AreEqual(guildName, guildDetail.GuildName);
        }
    }
}
