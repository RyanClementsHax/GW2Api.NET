using GW2Api.NET.IntegrationTests.V2.Config;
using GW2Api.NET.V2;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Net.Http;

namespace GW2Api.NET.IntegrationTests.V2
{
    [TestClass, TestCategory("Large"), TestCategory("V2"), TestCategory("Authenticated")]
    public class AuthenticatedTestsBase
    {
        protected static TestConfig _config;
        protected static object[] DefaultApiKeys => new[] { null, _config?.ApiKey };

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext _)
            => _config = new ConfigurationBuilder()
                .AddJsonFile("v2.config.json", optional: true)
                .Build()
                .Get<TestConfig>();

        public static IEnumerable<object[]> DefaultAuthenticatedTestData()
            => new List<object[]>
            {
                DefaultApiKeys,
                TestData.DefaultCtsFactories
            }.Permute();

        protected IGw2ApiV2 _api;

        [TestInitialize]
        public void Setup()
        {
            if (_config is null)
                Assert.Fail("You must create a v2.config.json file to run authenticated tests. See the README for instructions on how to run these tests.");

            _config = _config with
            {
                AccountConfig = _config.AccountConfig with
                {
                    AchievementIds = _config.AccountConfig.AchievementIds ?? new List<int>(),
                    FinisherIds = _config.AccountConfig.FinisherIds ?? new List<int>(),
                    DailyCraftingIds = _config.AccountConfig.DailyCraftingIds ?? new List<int>(),
                    DungeonIds = _config.AccountConfig.DungeonIds ?? new List<int>(),
                    DyeIds = _config.AccountConfig.DyeIds ?? new List<int>(),
                    GliderIds = _config.AccountConfig.GliderIds ?? new List<int>(),
                    HomeCatIds = _config.AccountConfig.HomeCatIds ?? new List<int>(),
                    HomeNodeIds = _config.AccountConfig.HomeNodeIds ?? new List<string>(),
                    SharedInventoryItemIds = _config.AccountConfig.SharedInventoryItemIds ?? new List<int>(),
                    MailCarrierIds = _config.AccountConfig.MailCarrierIds ?? new List<int>(),
                    MapChestIds = _config.AccountConfig.MapChestIds ?? new List<string>(),
                }
            };

            _api = new Gw2ApiV2(new HttpClient())
            {
                ApiKey = _config.ApiKey
            };
        }
    }
}
