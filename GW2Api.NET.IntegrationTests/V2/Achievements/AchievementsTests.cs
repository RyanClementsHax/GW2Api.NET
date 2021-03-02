using GW2Api.NET.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
