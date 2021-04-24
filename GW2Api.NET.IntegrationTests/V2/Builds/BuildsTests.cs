using GW2Api.NET.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.Builds
{
    [TestClass, TestCategory("Large"), TestCategory("V2"), TestCategory("V2 Builds")]
    public class BuildsTests
    {
        private IGw2ApiV2 _api;

        [TestInitialize]
        public void Setup()
            => _api = new Gw2ApiV2(new HttpClient());

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetBuildAsync_AnyParams_ReturnsTheBuild(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetBuildAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result > 0);
        }
    }
}
