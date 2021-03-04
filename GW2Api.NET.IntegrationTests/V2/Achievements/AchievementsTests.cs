using GW2Api.NET.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
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

        [TestMethod]
        public async Task GetAchievementAsync_ValidAchievementId_ReturnsThatAchievement()
        {
            var id = 2258;
            var name = "Mistward Legguards";

            var result = await _api.GetAchievementAsync(id);

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        public async Task GetAchievementAsync_ValidAchievementIdAndAnyCulture_ReturnsThatAchievement()
        {
            var id = 2258;
            var lang = new CultureInfo("es-MX");
            var name = "Perneras de guardaniebla";

            var result = await _api.GetAchievementAsync(id, lang);

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        public async Task GetAchievementAsync_ValidAchievementIdAndCancellationToken_ReturnsThatAchievement()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var id = 2258;
            var name = "Mistward Legguards";

            var result = await _api.GetAchievementAsync(id, token: cts.Token);

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        public async Task GetAchievementAsync_ValidAchievementIdAndAnyCultureAndCancellationToken_ReturnsThatAchievement()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var id = 2258;
            var lang = new CultureInfo("es-MX");
            var name = "Perneras de guardaniebla";

            var result = await _api.GetAchievementAsync(id, lang, cts.Token);

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        public async Task GetAchievementsAsync_ValidIds_ReturnsThoseAchievements()
        {
            var ids = new List<int>
            {
                1840,
                910,
                2258
            };
            var names = new List<string>
            {
                "Daily Completionist",
                "Tequatl the Sunless",
                "Mistward Legguards"
            };

            var result = await _api.GetAchievementsAsync(ids);

            CollectionAssert.AreEquivalent(names, result.Select(x => x.Name).ToList());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task GetAchievementsAsync_NullIds_ThrowsArgumentNullException()
            => await _api.GetAchievementsAsync(ids: null);

        [TestMethod]
        public async Task GetAchievementsAsync_ValidIdsAndCancellationToken_ReturnsThoseAchievements()
        {
            using var cts = TestData.CreateDefaultTokenSource();
            var ids = new List<int>
            {
                1840,
                910,
                2258
            };
            var names = new List<string>
            {
                "Daily Completionist",
                "Tequatl the Sunless",
                "Mistward Legguards"
            };

            var result = await _api.GetAchievementsAsync(ids, token: cts.Token);

            CollectionAssert.AreEquivalent(names, result.Select(x => x.Name).ToList());
        }

        [TestMethod]
        public async Task GetAchievementsAsync_ValidIdsAndLangProvidedAndCancellationToken_ReturnsThoseAchievementsTranslated()
        {
            using var cts = TestData.CreateDefaultTokenSource();
            var ids = new List<int>
            {
                1840,
                910,
                2258
            };
            var lang = new CultureInfo("es-MX");
            var names = new List<string>
            {
                "Perfeccionista del día",
                "Tequatl el Sombrío",
                "Perneras de guardaniebla"
            };

            var result = await _api.GetAchievementsAsync(ids, lang, cts.Token);

            CollectionAssert.AreEquivalent(names, result.Select(x => x.Name).ToList());
        }

        [TestMethod]
        public async Task GetAchievementsAsync_ValidIdsAndLangProvided_ReturnsThoseAchievementsTranslated()
        {
            var ids = new List<int>
            {
                1840,
                910,
                2258
            };
            var lang = new CultureInfo("es-MX");
            var names = new List<string>
            {
                "Perfeccionista del día",
                "Tequatl el Sombrío",
                "Perneras de guardaniebla"
            };

            var result = await _api.GetAchievementsAsync(ids, lang);

            CollectionAssert.AreEquivalent(names, result.Select(x => x.Name).ToList());
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
    }
}
