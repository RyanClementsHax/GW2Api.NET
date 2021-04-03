using GW2Api.NET.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.Achievements
{
    [TestClass, TestCategory("Large"), TestCategory("V2"), TestCategory("V2 Achievements")]
    public class AchievementsTests
    {
        private IGw2ApiV2 _api;

        [TestInitialize]
        public void Setup()
            => _api = new Gw2ApiV2(new HttpClient());

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllAchievementIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllAchievementIdsAsync(cts?.Token ?? default);

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetAchievementAsync_TestData()
            => new List<object[]>
            {
                new object[] { 2258 },
                new [] { (null, "Mistward Legguards"), ("es", "Perneras de guardaniebla") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetAchievementAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetAchievementAsync_ValidId_ReturnsThatAchievement(int id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetAchievementAsync(id, lang, cts?.Token ?? default);

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAchievementsAsync_NullIds_ThrowsArgumentNullException(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetAchievementsAsync(ids: null, token: cts?.Token ?? default);
        }

        public static IEnumerable<object[]> GetAchievementsAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 1840, 910, 2258 } },
                new [] {
                    (null, new List<string> { "Daily Completionist", "Tequatl the Sunless", "Mistward Legguards" }.AsEnumerable()),
                    ("es", new List<string> { "Perfeccionista del día", "Tequatl el Sombrío", "Perneras de guardaniebla" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetAchievementsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetAchievementsAsync_ValidIds_ReturnsThoseAchievements(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetAchievementsAsync(ids, lang, cts?.Token ?? default);

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetTodaysDailyAchievementsAsync_AnyParams_ReturnsTodaysDailies(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetTodaysDailyAchievementsAsync(cts?.Token ?? default);

            Assert.IsTrue(result.Pve.Any());
            Assert.IsTrue(result.Pvp.Any());
            Assert.IsTrue(result.Wvw.Any());
            Assert.IsTrue(result.Fractals.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetTomorrowsDailyAchievementsAsync_AnyParams_ReturnsTomorrowsDailies(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetTomorrowsDailyAchievementsAsync(cts?.Token ?? default);

            Assert.IsTrue(result.Pve.Any());
            Assert.IsTrue(result.Pvp.Any());
            Assert.IsTrue(result.Wvw.Any());
            Assert.IsTrue(result.Fractals.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllAchievementGroupIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllAchievementGroupIdsAsync(cts?.Token ?? default);

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetAchievementGroupAsync_TestData()
            => new List<object[]>
            {
                new object[] { Guid.Parse("A4ED8379-5B6B-4ECC-B6E1-70C350C902D2") },
                new [] {(null, "Story Journal"), ("es", "Diario de historia") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetAchievementGroupAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetAchievementGroupAsync_ValidId_ReturnsThatAchievementGroup(Guid id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetAchievementGroupAsync(id, lang, cts?.Token ?? default);

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAchievementGroupsAsync_NullIds_ThrowsArgumentNullException(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetAchievementGroupsAsync(ids: null, token: cts?.Token ?? default);
        }

        public static IEnumerable<object[]> GetAchievementGroupsAsync_TestData()
            => new List<object[]>
            {
                new [] {
                    new List<Guid> {
                        Guid.Parse("AACBCEF3-BFEE-405B-967D-30A989589AD7"),
                        Guid.Parse("A4ED8379-5B6B-4ECC-B6E1-70C350C902D2"),
                        Guid.Parse("56A82BB9-6B07-4AB0-89EE-E4A6D68F5C47"),
                    }
                },
                new [] {
                    (null, new List<string> { "Bonus Events", "Story Journal", "General" }.AsEnumerable()),
                    ("es", new List<string> { "Eventos de bonificación", "Diario de historia", "Logros generales" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetAchievementGroupsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetAchievementGroupsAsync_ValidIds_ReturnsThoseAchievementGroups(IEnumerable<Guid> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetAchievementGroupsAsync(ids, lang, cts?.Token ?? default);

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllAchievementCategoryIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllAchievementCategoryIdsAsync(cts?.Token ?? default);

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetAchievementCategoryAsync_TestData()
            => new List<object[]>
            {
                new object [] { 1 },
                new [] { (null, "Slayer"), ("es", "Asesino") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetAchievementCategoryAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetAchievementCategoryAsync_ValidId_ReturnsThatAchievementCategory(int id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetAchievementCategoryAsync(id, lang, cts?.Token ?? default);

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAchievementCategoriesAsync_NullIds_ThrowsArgumentNullException(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetAchievementCategoriesAsync(ids: null, token: cts?.Token ?? default);
        }

        public static IEnumerable<object[]> GetAchievementCategoriesAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 1, 2, 3 } },
                new [] {
                    (null, new List<string> { "Slayer", "Hero", "PvP Conqueror" }.AsEnumerable()),
                    ("es", new List<string> { "Asesino", "Héroe", "Conquistador PvP" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetAchievementCategoriesAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetAchievementCategoriesAsync_ValidIds_ReturnsThoseAchievementCategories(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetAchievementCategoriesAsync(ids, lang, cts?.Token ?? default);

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }
    }
}
