using GW2Api.NET.V1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V1.Items
{
    [TestClass, TestCategory("Large"), TestCategory("Items")]
    public class ItemsTests
    {
        private IGw2ApiV1 _api;

        [TestInitialize]
        public void Setup()
        {
            _api = new Gw2ApiV1(new HttpClient());
        }

        [TestMethod]
        public async Task GetAllItemIds_NoParams_ReturnsItemIds()
        {
            var itemIds = await _api.GetAllItemIds();

            Assert.IsTrue(itemIds.Any());
        }

        [TestMethod]
        public async Task GetAllItemIds_CancellationToken_ReturnsItemIds()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var itemIds = await _api.GetAllItemIds(token: cts.Token);

            Assert.IsTrue(itemIds.Any());
        }
    }
}
