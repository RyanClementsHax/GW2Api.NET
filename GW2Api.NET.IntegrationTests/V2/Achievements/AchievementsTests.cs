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
        public async Task GetAchievementAsync_ValidAchievementId_ReturnsThatAchievement(int id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetAchievementAsync(id, lang, cts?.Token ?? default);

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task GetAchievementsAsync_NullIds_ThrowsArgumentNullException()
            => await _api.GetAchievementsAsync(ids: null);

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
        public async Task GetTodaysDailyAchievementsAsync_CancellationToken_ReturnsTodaysDailies(Func<CancellationTokenSource> ctsFactory)
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
        public async Task GetTomorrowsDailyAchievementsAsync_CancellationToken_ReturnsTodaysDailies(Func<CancellationTokenSource> ctsFactory)
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
        public async Task GetAchievementGroupAsync_ValidAchievementGroupId_ReturnsThatAchievementGroup(Guid id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetAchievementGroupAsync(id, lang, cts?.Token ?? default);

            Assert.AreEqual(name, result.Name);
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
        public async Task GetAchievementCategoryAsync_ValidAchievementCategoryId_ReturnsThatAchievementCategory(int id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetAchievementCategoryAsync(id, lang, cts?.Token ?? default);

            Assert.AreEqual(name, result.Name);
        }
    }
}
