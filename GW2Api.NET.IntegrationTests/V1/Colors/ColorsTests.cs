using GW2Api.NET.V1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V1.Colors
{
    [TestClass, TestCategory("Large"), TestCategory("Colors")]
    public class ColorsTests
    {
        private IGw2ApiV1 _api;

        [TestInitialize]
        public void Setup()
        {
            _api = new Gw2ApiV1(new HttpClient());
        }

        [TestMethod]
        public async Task GetAllColorsAsync_NoParams_ReturnsColorsWithColorIds()
        {
            var colors = await _api.GetAllColorsAsync();

            Assert.IsTrue(colors.Any());
            colors.ToList().ForEach(x => Assert.AreEqual(x.Key, x.Value.Id));
        }

        [TestMethod]
        public async Task GetAllColorsAsync_AnyCulture_ReturnsColorsInThatCultureWithColorIds()
        {
            var lang = new CultureInfo("es-MX");
            var esMxColorName = "Tiza";

            var colors = await _api.GetAllColorsAsync(lang);

            Assert.IsTrue(colors.Any());
            CollectionAssert.Contains(colors.Values.Select(x => x.Name).ToList(), esMxColorName);
            colors.ToList().ForEach(x => Assert.AreEqual(x.Key, x.Value.Id));
        }

        [TestMethod]
        public async Task GetAllColorsAsync_CancellationToken_ReturnsColorsWithColorIds()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var colors = await _api.GetAllColorsAsync(token: cts.Token);

            Assert.IsTrue(colors.Any());
            colors.ToList().ForEach(x => Assert.AreEqual(x.Key, x.Value.Id));
        }
    }
}
