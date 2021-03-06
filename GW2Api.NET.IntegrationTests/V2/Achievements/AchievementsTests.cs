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

        [TestMethod]
        public async Task GetAllAchievementIdsAsync_NoParams_ReturnsAllIds()
        {
            var result = await _api.GetAllAchievementIdsAsync();

            Assert.IsTrue(result.Any());
        }

        [TestMethod]
        public async Task GetAllAchievementIdsAsync_CancellationToken_ReturnsAllIds()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var result = await _api.GetAllAchievementIdsAsync(cts.Token);

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetAchievementAsync_TestData()
            => new List<object>
            {
                2258,
                new [] { null, new CultureInfo("ex-MX") },
                new Func<CancellationTokenSource>[] { () => null, () => TestData.CreateDefaultTokenSource() }.ToObjectArray(),
                "Mistward Legguards"
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetAchievementAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetAchievementAsync_ValidAchievementId_ReturnsThatAchievement(int id, CultureInfo lang, Func<CancellationTokenSource> ctsFactory, string name)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAchievementAsync(id, lang, cts?.Token ?? default);

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task GetAchievementsAsync_NullIds_ThrowsArgumentNullException()
            => await _api.GetAchievementsAsync(ids: null);

        public static IEnumerable<object[]> GetAchievementsAsync_TestData()
            => new List<object>
            {
                new List<int> { 1840, 910, 2258 },
                new [] { null, new CultureInfo("ex-MX") },
                new Func<CancellationTokenSource>[] { () => null, () => TestData.CreateDefaultTokenSource() }.ToObjectArray(),
                new List<string> { "Daily Completionist", "Tequatl the Sunless", "Mistward Legguards" }
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetAchievementsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetAchievementsAsync_ValidIds_ReturnsThoseAchievements(IEnumerable<int> ids, CultureInfo lang, Func<CancellationTokenSource> ctsFactory, IEnumerable<string> names)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAchievementsAsync(ids, lang, cts?.Token ?? default);

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [TestMethod]
        public async Task GetTodaysDailyAchievementsAsync_NoParams_ReturnsTodaysDailies()
        {
            var result = await _api.GetTodaysDailyAchievementsAsync();

            Assert.IsTrue(result.Pve.Any());
            Assert.IsTrue(result.Pvp.Any());
            Assert.IsTrue(result.Wvw.Any());
            Assert.IsTrue(result.Fractals.Any());
        }

        [TestMethod]
        public async Task GetTodaysDailyAchievementsAsync_CancellationToken_ReturnsTodaysDailies()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var result = await _api.GetTodaysDailyAchievementsAsync(cts.Token);

            Assert.IsTrue(result.Pve.Any());
            Assert.IsTrue(result.Pvp.Any());
            Assert.IsTrue(result.Wvw.Any());
            Assert.IsTrue(result.Fractals.Any());
        }

        [TestMethod]
        public async Task GetTomorrowsDailyAchievementsAsync_NoParams_ReturnsTodaysDailies()
        {
            var result = await _api.GetTomorrowsDailyAchievementsAsync();

            Assert.IsTrue(result.Pve.Any());
            Assert.IsTrue(result.Pvp.Any());
            Assert.IsTrue(result.Wvw.Any());
            Assert.IsTrue(result.Fractals.Any());
        }

        [TestMethod]
        public async Task GetTomorrowsDailyAchievementsAsync_CancellationToken_ReturnsTodaysDailies()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var result = await _api.GetTomorrowsDailyAchievementsAsync(cts.Token);

            Assert.IsTrue(result.Pve.Any());
            Assert.IsTrue(result.Pvp.Any());
            Assert.IsTrue(result.Wvw.Any());
            Assert.IsTrue(result.Fractals.Any());
        }

        [TestMethod]
        public async Task GetAllAchievementGroupIdsAsync_NoParams_ReturnsAllIds()
        {
            var result = await _api.GetAllAchievementGroupIdsAsync();

            Assert.IsTrue(result.Any());
        }

        [TestMethod]
        public async Task GetAllAchievementGroupIdsAsync_CancellationToken_ReturnsAllIds()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var result = await _api.GetAllAchievementGroupIdsAsync(cts.Token);

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetAchievementGroupAsync_TestData()
            => new List<object>
            {
                Guid.Parse("A4ED8379-5B6B-4ECC-B6E1-70C350C902D2"),
                new [] { null, new CultureInfo("ex-MX") },
                new Func<CancellationTokenSource>[] { () => null, () => TestData.CreateDefaultTokenSource() }.ToObjectArray(),
                "Story Journal"
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetAchievementGroupAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetAchievementGroupAsync_ValidAchievementGroupId_ReturnsThatAchievementGroup(Guid id, CultureInfo lang, Func<CancellationTokenSource> ctsFactory, string name)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAchievementGroupAsync(id, lang, cts?.Token ?? default);

            Assert.AreEqual(name, result.Name);
        }

        // TODO: remove need for .ToObjectArray()
        // TODO: convert the rest of these tests to use factories
    }
}
