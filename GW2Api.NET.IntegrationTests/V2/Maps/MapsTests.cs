using GW2Api.NET.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.Maps
{
    [TestClass, TestCategory("Large"), TestCategory("V2"), TestCategory("V2 Maps")]
    public class MapsTests
    {
        private IGw2ApiV2 _api;

        [TestInitialize]
        public void Setup()
            => _api = new Gw2ApiV2(new HttpClient());

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllContinentIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllContinentIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetContinentAsync_TestData()
            => new List<object[]>
            {
                new object[] { 2 },
                new [] { (null, "Mists"), ("es", "La Niebla") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetContinentAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetContinentAsync_ValidId_ReturnsThatContinent(int id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetContinentAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetContinentsAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetContinentsAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetContinentsAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 1, 2 } },
                new [] {
                    (null, new List<string> { "Tyria", "Mists" }.AsEnumerable()),
                    ("es", new List<string> { "Tyria", "La Niebla" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetContinentsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetContinentsAsync_ValidIds_ReturnsThoseContinents(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetContinentsAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllContinentsAsync_AnyParams_ReturnsAllContinents(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllContinentsAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetContinentsAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetContinentsAsync(page: 1, pageSize: 1, lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllFloorIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;

            var result = await _api.GetAllFloorIdsAsync(continentId, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetFloorAsync_TestData()
            => new List<object[]>
            {
                new object[] { 0 },
                new [] { (null, "Shiverpeak Mountains"), ("es", "Montañas Picosescalofriantes") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetFloorAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetFloorAsync_ValidId_ReturnsThatFloor(int floorId, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var (lang, name) = langNameTuple;

            var result = await _api.GetFloorAsync(continentId, floorId, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(floorId, result.Id);
            Assert.IsTrue(result.Regions.Values.Select(x => x.Name).Contains(name));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetFloorsAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;

            await _api.GetFloorsAsync(continentId, floorIds: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetFloorsAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 0, 1 } },
                new [] {
                    (null, new List<string> { "Shiverpeak Mountains", "Shiverpeak Mountains" }.AsEnumerable()),
                    ("es", new List<string> { "Montañas Picosescalofriantes", "Montañas Picosescalofriantes" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetFloorsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetFloorsAsync_ValidIds_ReturnsThoseFloors(IEnumerable<int> floorIds, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var (lang, names) = langNamesTuple;

            var result = await _api.GetFloorsAsync(continentId, floorIds, lang, cts.GetTokenOrDefault());

            CollectionAssert.IsSubsetOf(names.ToList(), result.SelectMany(x => x.Regions.Values).Select(x => x.Name).ToList());
        }

        public static IEnumerable<object[]> GetAllFloorsAsync_TestData()
            => new List<object[]>
            {
                new object[] { 1, 2 },
                TestData.DefaultLangs,
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetAllFloorsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetAllFloorsAsync_AnyParams_ReturnsAllFloors(int continentId, CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllFloorsAsync(continentId, lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetFloorsAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;

            var result = await _api.GetFloorsAsync(continentId, page: 1, pageSize: 1, lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllFloorRegionIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;

            var result = await _api.GetAllFloorRegionIdsAsync(continentId, floorId, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetFloorRegionAsync_TestData()
            => new List<object[]>
            {
                new object[] { 1 },
                new [] { (null, "Shiverpeak Mountains"), ("es", "Montañas Picosescalofriantes") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetFloorRegionAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetFloorRegionAsync_ValidId_ReturnsThatFloorRegion(int regionId, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var (lang, name) = langNameTuple;

            var result = await _api.GetFloorRegionAsync(continentId, floorId, regionId, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetFloorRegionsAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;

            await _api.GetFloorRegionsAsync(continentId, floorId, regionIds: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetFloorRegionsAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 1, 3 } },
                new [] {
                    (null, new List<string> { "Shiverpeak Mountains", "Ruins of Orr" }.AsEnumerable()),
                    ("es", new List<string> { "Montañas Picosescalofriantes", "Ruinas de Orr" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetFloorRegionsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetFloorRegionsAsync_ValidIds_ReturnsThoseFloorRegions(IEnumerable<int> regionIds, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var (lang, names) = langNamesTuple;

            var result = await _api.GetFloorRegionsAsync(continentId, floorId, regionIds, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllFloorRegionsAsync_AnyParams_ReturnsAllFloorRegions(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;

            var result = await _api.GetAllFloorRegionsAsync(continentId, floorId, lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetFloorRegionsAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;

            var result = await _api.GetFloorRegionsAsync(continentId, floorId, page: 1, pageSize: 1, lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllRegionMapIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var regionId = 1;

            var result = await _api.GetAllRegionMapIdsAsync(continentId, floorId, regionId, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetRegionMapAsync_TestData()
            => new List<object[]>
            {
                new object[] { 26 },
                new [] { (null, "Dredgehaunt Cliffs"), ("es", "Acantilados de Guaridadraga") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetRegionMapAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetRegionMapAsync_ValidId_ReturnsThatRegionMap(int mapId, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var regionId = 1;
            var (lang, name) = langNameTuple;

            var result = await _api.GetRegionMapAsync(continentId, floorId, regionId, mapId, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetRegionMapsAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var regionId = 1;

            await _api.GetRegionMapsAsync(continentId, floorId, regionId, mapIds: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetRegionMapsAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 26, 27, 28 } },
                new [] {
                    (null, new List<string> { "Dredgehaunt Cliffs", "Lornar's Pass", "Wayfarer Foothills" }.AsEnumerable()),
                    ("es", new List<string> { "Acantilados de Guaridadraga", "Paso de Lornar", "Colinas del Caminante" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetRegionMapsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetRegionMapsAsync_ValidIds_ReturnsThoseRegionMaps(IEnumerable<int> mapIds, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var regionId = 1;
            var (lang, names) = langNamesTuple;

            var result = await _api.GetRegionMapsAsync(continentId, floorId, regionId, mapIds, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllRegionMapsAsync_AnyParams_ReturnsAllRegionMaps(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var regionId = 1;

            var result = await _api.GetAllRegionMapsAsync(continentId, floorId, regionId, lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetRegionMapsAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var regionId = 1;

            var result = await _api.GetRegionMapsAsync(continentId, floorId, regionId, page: 1, pageSize: 1, lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllSectorIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var regionId = 1;
            var mapId = 26;

            var result = await _api.GetAllSectorIdsAsync(continentId, floorId, regionId, mapId, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetSectorAsync_TestData()
            => new List<object[]>
            {
                new object[] { 513 },
                new [] { (null, "Tribulation Rift"), ("es", "Abismo de la Tribulación") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetSectorAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetSectorAsync_ValidId_ReturnsThatSector(int sectorId, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var regionId = 1;
            var mapId = 26;
            var (lang, name) = langNameTuple;

            var result = await _api.GetSectorAsync(continentId, floorId, regionId, mapId, sectorId, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetSectorsAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var regionId = 1;
            var mapId = 26;

            await _api.GetSectorsAsync(continentId, floorId, regionId, mapId, sectorIds: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetSectorsAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 513, 514, 515 } },
                new [] {
                    (null, new List<string> { "Tribulation Rift", "De Molish Post", "Dissun's Mine" }.AsEnumerable()),
                    ("es", new List<string> { "Abismo de la Tribulación", "Puesto de Ribar", "Mina de Dissun" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetSectorsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetSectorsAsync_ValidIds_ReturnsThoseSectors(IEnumerable<int> sectorIds, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var regionId = 1;
            var mapId = 26;
            var (lang, names) = langNamesTuple;

            var result = await _api.GetSectorsAsync(continentId, floorId, regionId, mapId, sectorIds, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllSectorsAsync_AnyParams_ReturnsAllSectors(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var regionId = 1;
            var mapId = 26;

            var result = await _api.GetAllSectorsAsync(continentId, floorId, regionId, mapId, lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetSectorsAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var regionId = 1;
            var mapId = 26;

            var result = await _api.GetSectorsAsync(continentId, floorId, regionId, mapId, page: 1, pageSize: 1, lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllPointOfInterestIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var regionId = 1;
            var mapId = 26;

            var result = await _api.GetAllPointOfInterestIdsAsync(continentId, floorId, regionId, mapId, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetPointOfInterestAsync_TestData()
            => new List<object[]>
            {
                new object[] { 554 },
                new [] { (null, "Leaning Grade"), ("es", "Lenin Grada") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetPointOfInterestAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetPointOfInterestAsync_ValidId_ReturnsThatPointOfInterest(int pointOfInterestId, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var regionId = 1;
            var mapId = 26;
            var (lang, name) = langNameTuple;

            var result = await _api.GetPointOfInterestAsync(continentId, floorId, regionId, mapId, pointOfInterestId, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetPointsOfInterestAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var regionId = 1;
            var mapId = 26;

            await _api.GetPointsOfInterestAsync(continentId, floorId, regionId, mapId, pointOfInterestIds: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetPointsOfInterestAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 554, 555, 556 } },
                new [] {
                    (null, new List<string> { "Leaning Grade", "Fridgardr Lodge", "Mantelet Refuge" }.AsEnumerable()),
                    ("es", new List<string> { "Lenin Grada", "Albergue de Fridgardr", "Refugio Mantelet" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetPointsOfInterestAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetPointsOfInterestAsync_ValidIds_ReturnsThosePointsOfInterest(IEnumerable<int> pointOfInterestIds, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var regionId = 1;
            var mapId = 26;
            var (lang, names) = langNamesTuple;

            var result = await _api.GetPointsOfInterestAsync(continentId, floorId, regionId, mapId, pointOfInterestIds, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllPointsOfInterestAsync_AnyParams_ReturnsAllPointsOfInterest(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var regionId = 1;
            var mapId = 26;

            var result = await _api.GetAllPointsOfInterestAsync(continentId, floorId, regionId, mapId, lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetPointsOfInterestAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var floorId = 0;
            var regionId = 1;
            var mapId = 26;

            var result = await _api.GetPointsOfInterestAsync(continentId, floorId, regionId, mapId, page: 1, pageSize: 1, lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }
    }
}
