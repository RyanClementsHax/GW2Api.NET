using GW2Api.NET.V1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V1.World
{
    [TestClass, TestCategory("Large"), TestCategory("World")]
    public class WorldTests
    {
        private IGw2ApiV1 _api;

        [TestInitialize]
        public void Setup() => _api = new Gw2ApiV1(new HttpClient());

        [TestMethod]
        public async Task GetAllWorldNamesAsync_NoParams_ReturnsWorldNames()
        {
            var worldNames = await _api.GetAllWorldNamesAsync();

            Assert.IsTrue(worldNames.Any());
        }

        [TestMethod]
        public async Task GetAllWorldNamesAsync_AnyCulture_ReturnsWorldNamesInThatCulture()
        {
            var lang = new CultureInfo("es-MX");
            var esMxWorldName = "Roca del Yunque";

            var worldNames = await _api.GetAllWorldNamesAsync(lang);

            Assert.IsTrue(worldNames.Any());
            CollectionAssert.Contains(worldNames.Select(x => x.Name).ToList(), esMxWorldName);
        }

        [TestMethod]
        public async Task GetAllWorldNamesAsync_CancellationToken_ReturnsWorldNames()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var worldNames = await _api.GetAllWorldNamesAsync(token: cts.Token);

            Assert.IsTrue(worldNames.Any());
        }
    }
}
