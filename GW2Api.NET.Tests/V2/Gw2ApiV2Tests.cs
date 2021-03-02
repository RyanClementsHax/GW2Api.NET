using GW2Api.NET.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;

namespace GW2Api.NET.IntegrationTests.V2
{
    [TestClass, TestCategory("V2"), TestCategory("Small")]
    public class Gw2ApiV2Tests
    {
        private Gw2ApiV2 _api;

        [TestInitialize]
        public void Setup()
            => _api = new Gw2ApiV2(new HttpClient());

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Gw2ApiV1Ctor_NullHttpClient_ArgNullEx()
            => new Gw2ApiV2(null);
    }
}
