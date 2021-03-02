using GW2Api.NET.V1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V1.Maps
{
    [TestClass, TestCategory("Large"), TestCategory("V1"), TestCategory("V1 Maps")]
    public class MapsTests
    {
        private IGw2ApiV1 _api;

        [TestInitialize]
        public void Setup()
            => _api = new Gw2ApiV1(new HttpClient());

        [TestMethod]
        public async Task GetAllMapNamesAsync_NoParams_ReturnsMapNames()
        {
            var mapNames = await _api.GetAllMapNamesAsync();

            Assert.IsTrue(mapNames.Any());
        }

        [TestMethod]
        public async Task GetAllMapNamesAsync_AnyCulture_ReturnsMapNamesInThatCulture()
        {
            var lang = new CultureInfo("es-MX");
            var esMxMapName = "Valle de la Reina";

            var mapNames = await _api.GetAllMapNamesAsync(lang);

            Assert.IsTrue(mapNames.Any());
            CollectionAssert.Contains(mapNames.Select(x => x.Name).ToList(), esMxMapName);
        }

        [TestMethod]
        public async Task GetAllMapNamesAsync_CancellationToken_ReturnsMapNames()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var mapNames = await _api.GetAllMapNamesAsync(token: cts.Token);

            Assert.IsTrue(mapNames.Any());
        }

        [TestMethod]
        public async Task GetAllContinentsAsync_NoParams_ReturnsAllContinentsWithIdsMapped()
        {
            var contients = await _api.GetAllContinentsAsync();

            Assert.IsTrue(contients.Any());
            contients.ToList().ForEach(x => Assert.AreEqual(x.Key, x.Value.ContinentId));
        }

        [TestMethod]
        public async Task GetAllContinentsAsync_CancellationToken_ReturnsAllContinentsWithIdsMapped()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var contients = await _api.GetAllContinentsAsync(token: cts.Token);

            Assert.IsTrue(contients.Any());
            contients.ToList().ForEach(x => Assert.AreEqual(x.Key, x.Value.ContinentId));
        }

        [TestMethod]
        public async Task GetAllMapsAsync_NoParams_ReturnsMapsWithIdsMapped()
        {
            var maps = await _api.GetAllMapsAsync();

            Assert.IsTrue(maps.Any());
            maps.ToList().ForEach(x => Assert.AreEqual(x.Key, x.Value.MapId));
        }

        [TestMethod]
        public async Task GetAllMapsAsync_CancellationToken_ReturnsMapsWithIdsMapped()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var maps = await _api.GetAllMapsAsync(token: cts.Token);

            Assert.IsTrue(maps.Any());
            maps.ToList().ForEach(x => Assert.AreEqual(x.Key, x.Value.MapId));
        }

        [TestMethod]
        public async Task GetAllMapsAsync_AnyCulture_ReturnsMapsWithIdsMapped()
        {
            var lang = new CultureInfo("es-MX");
            var esMxMapName = "Valle de la Reina";

            var maps = await _api.GetAllMapsAsync(lang);

            Assert.IsTrue(maps.Any());
            CollectionAssert.Contains(maps.Select(x => x.Value.MapName).ToList(), esMxMapName);
        }

        [TestMethod]
        public async Task GetAllMapsAsync_AnyCultureAndCancellationToken_ReturnsMapsWithIdsMapped()
        {
            using var cts = TestData.CreateDefaultTokenSource();
            var lang = new CultureInfo("es-MX");
            var esMxMapName = "Valle de la Reina";

            var maps = await _api.GetAllMapsAsync(lang, token: cts.Token);

            Assert.IsTrue(maps.Any());
            CollectionAssert.Contains(maps.Select(x => x.Value.MapName).ToList(), esMxMapName);
        }

        [TestMethod]
        public async Task GetMapAsync_NoParams_ReturnsMapWithIdMapped()
        {
            var mapId = "15";
            var mapName = "Queensdale";

            var map = await _api.GetMapAsync(mapId);

            Assert.AreEqual(mapName, map.MapName);
        }

        [TestMethod]
        public async Task GetMapAsync_CancellationToken_ReturnsMapWithIdMapped()
        {
            using var cts = TestData.CreateDefaultTokenSource();
            var mapId = "15";
            var mapName = "Queensdale";

            var map = await _api.GetMapAsync(mapId, token: cts.Token);

            Assert.AreEqual(mapName, map.MapName);
        }

        [TestMethod]
        public async Task GetMapAsync_AnyCulture_ReturnsMapWithIdMapped()
        {
            var mapId = "15";
            var lang = new CultureInfo("es-MX");
            var esMxMapName = "Valle de la Reina";

            var map = await _api.GetMapAsync(mapId, lang);

            Assert.AreEqual(esMxMapName, map.MapName);
        }

        [TestMethod]
        public async Task GetMapAsync_AnyCultureAndCancellationToken_ReturnsMapWithIdMapped()
        {
            using var cts = TestData.CreateDefaultTokenSource();
            var mapId = "15";
            var lang = new CultureInfo("es-MX");
            var esMxMapName = "Valle de la Reina";

            var map = await _api.GetMapAsync(mapId, lang, cts.Token);

            Assert.AreEqual(esMxMapName, map.MapName);
        }

        [TestMethod]
        public async Task GetMapFloorAsync_ValidContinentIdAndFloor_ReturnsThatMapFloor()
        {
            var continentId = "1";
            var floor = 1;
            var aRegionName = "Shiverpeak Mountains";

            var mapFloor = await _api.GetMapFloorAsync(continentId, floor);

            if (mapFloor.Regions.TryGetValue("1", out var region))
            {
                Assert.AreEqual(aRegionName, region.Name);
            }
            else
            {
                Assert.Fail($"Could not find region with name {aRegionName}");
            }
        }

        [TestMethod]
        public async Task GetMapFloorAsync_ValidContinentIdAndFloorAndCancellationToken_ReturnsThatMapFloor()
        {
            using var cts = TestData.CreateDefaultTokenSource();
            var continentId = "1";
            var floor = 1;
            var aRegionName = "Shiverpeak Mountains";

            var mapFloor = await _api.GetMapFloorAsync(continentId, floor, token: cts.Token);

            if (mapFloor.Regions.TryGetValue("1", out var region))
            {
                Assert.AreEqual(aRegionName, region.Name);
            }
            else
            {
                Assert.Fail($"Could not find region with name {aRegionName}");
            }
        }

        [TestMethod]
        public async Task GetMapFloorAsync_ValidContinentIdAndFloorAnyCulture_ReturnsThatMapFloor()
        {
            var continentId = "1";
            var floor = 1;
            var lang = new CultureInfo("es-MX");
            var aRegionName = "Montañas Picosescalofriantes";

            var mapFloor = await _api.GetMapFloorAsync(continentId, floor, lang);

            if (mapFloor.Regions.TryGetValue("1", out var region))
            {
                Assert.AreEqual(aRegionName, region.Name);
            }
            else
            {
                Assert.Fail($"Could not find region with name {aRegionName}");
            }
        }

        [TestMethod]
        public async Task GetMapFloorAsync_ValidContinentIdAndFloorAnyCultureAndCancellationToken_ReturnsThatMapFloor()
        {
            using var cts = TestData.CreateDefaultTokenSource();
            var continentId = "1";
            var floor = 1;
            var lang = new CultureInfo("es-MX");
            var aRegionName = "Montañas Picosescalofriantes";

            var mapFloor = await _api.GetMapFloorAsync(continentId, floor, lang, cts.Token);

            if (mapFloor.Regions.TryGetValue("1", out var region))
            {
                Assert.AreEqual(aRegionName, region.Name);
            }
            else
            {
                Assert.Fail($"Could not find region with name {aRegionName}");
            }
        }
    }
}
