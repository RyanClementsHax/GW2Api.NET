using GW2Api.NET.V1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V1
{
    [TestClass, TestCategory("Small")]
    public class Gw2ApiV1Tests
    {
        private IGw2ApiV1 _api;

        [TestInitialize]
        public void Setup()
        {
            _api = new Gw2ApiV1(new HttpClient());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Gw2ApiV1Ctor_NullHttpClient_ArgNullEx()
        {
            new Gw2ApiV1(null);
        }
    }
}
