using GW2Api.NET.V1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V1.Skins
{
    [TestClass, TestCategory("Large"), TestCategory("Skins")]
    public class SkinsTests
    {
        private IGw2ApiV1 _api;

        [TestInitialize]
        public void Setup() => _api = new Gw2ApiV1(new HttpClient());

        [TestMethod]
        public async Task GetAllSkinIdsAsync_NoParams_ReturnsIds()
        {
            var skinIds = await _api.GetAllSkinIdsAsync();

            Assert.IsTrue(skinIds.Any());
        }

        [TestMethod]
        public async Task GetAllSkinIdsAsync_CancellationToken_ReturnsIds()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var skinIds = await _api.GetAllSkinIdsAsync(token: cts.Token);

            Assert.IsTrue(skinIds.Any());
        }

        // some types are missing test coverage due to the difficulty of obtaining sample data from this api
        [TestMethod]
        public async Task GetSkinDetailAsync_ValidRecipeId_ReturnsThatDetail()
        {
            var skinId = 1350;
            var skinName = "Zodiac Light Vest";

            var skinDetail = await _api.GetSkinDetailAsync(skinId);

            Assert.AreEqual(skinDetail.Name, skinName);
        }

        [TestMethod]
        public async Task GetSkinDetailAsync_ValidRecipeIdAndCancellationToken_ReturnsThatDetail()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var skinId = 1350;
            var skinName = "Zodiac Light Vest";

            var skinDetail = await _api.GetSkinDetailAsync(skinId, token: cts.Token);

            Assert.AreEqual(skinDetail.Name, skinName);
        }

        [TestMethod]
        public async Task GetSkinDetailAsync_AnyCulture_ReturnsThatDetail()
        {
            var skinId = 1350;
            var lang = new CultureInfo("es-MX");
            var skinName = "Chaleco del zodiaco ligero";

            var skinDetail = await _api.GetSkinDetailAsync(skinId, lang);

            Assert.AreEqual(skinDetail.Name, skinName);
        }

        [TestMethod]
        public async Task GetSkinDetailAsync_AnyCultureAndCancellationToken_ReturnsThatDetail()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var skinId = 1350;
            var lang = new CultureInfo("es-MX");
            var skinName = "Chaleco del zodiaco ligero";

            var skinDetail = await _api.GetSkinDetailAsync(skinId, lang, cts.Token);

            Assert.AreEqual(skinDetail.Name, skinName);
        }
    }
}
