using GW2Api.NET.V1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V1.Maps
{
    [TestClass, TestCategory("Large"), TestCategory("Maps")]
    public class MapsTests
    {
        private IGw2ApiV1 _api;

        [TestInitialize]
        public void Setup()
        {
            _api = new Gw2ApiV1(new HttpClient());
        }

        [TestMethod]
        public async Task GetAllMapNames_NoParams_ReturnsMapNames()
        {
            var mapNames = await _api.GetAllMapNames();

            Assert.IsTrue(mapNames.Any());
        }

        [TestMethod]
        public async Task GetAllMapNames_AnyCulture_ReturnsMapNamesInThatCulture()
        {
            var lang = new CultureInfo("es-MX");
            var esMxMapName = "Valle de la Reina";

            var mapNames = await _api.GetAllMapNames(lang);

            Assert.IsTrue(mapNames.Any());
            CollectionAssert.Contains(mapNames.Select(x => x.Name).ToList(), esMxMapName);
        }

        [TestMethod]
        public async Task GetAllMapNames_CancellationToken_ReturnsMapNames()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var mapNames = await _api.GetAllMapNames(token: cts.Token);

            Assert.IsTrue(mapNames.Any());
        }
    }
}
