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

            _api = new Gw2ApiV2(new HttpClient())
            {
                ApiKey = _config.ApiKey
            };
        }
    }
}
