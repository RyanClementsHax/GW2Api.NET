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
        public void Setup()
        {
            _api = new Gw2ApiV1(new HttpClient());
        }

        [TestMethod]
        public async Task GetGuildDetails_GuildIdThatExists_ReturnsThoseGuildDetails()
        {
            var guildId = new Guid("75FD83CF-0C45-4834-BC4C-097F93A487AF");

            var guildDetails = await _api.GetGuildDetails(guildId);

            Assert.AreEqual(guildId, guildDetails.GuildId);
        }

        [TestMethod]
        public async Task GetGuildDetails_GuildIdThatExistsAndCancellationToken_ReturnsThoseGuildDetails()
        {
            using var cts = TestData.CreateDefaultTokenSource();
            var guildId = new Guid("75FD83CF-0C45-4834-BC4C-097F93A487AF");

            var guildDetails = await _api.GetGuildDetails(guildId, cts.Token);

            Assert.AreEqual(guildId, guildDetails.GuildId);
        }

        [TestMethod]
        public async Task GetGuildDetails_GuildNameThatExists_ReturnsThoseGuildDetails()
        {
            var guildName = "Veterans Of Lions Arch";

            var guildDetails = await _api.GetGuildDetails(guildName);

            Assert.AreEqual(guildName, guildDetails.GuildName);
        }

        [TestMethod]
        public async Task GetGuildDetails_GuildNameThatExistsAndCancellationToken_ReturnsThoseGuildDetails()
        {
            using var cts = TestData.CreateDefaultTokenSource();
            var guildName = "Veterans Of Lions Arch";

            var guildDetails = await _api.GetGuildDetails(guildName, cts.Token);

            Assert.AreEqual(guildName, guildDetails.GuildName);
        }
    }
}
