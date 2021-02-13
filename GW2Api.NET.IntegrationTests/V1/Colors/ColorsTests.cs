using GW2Api.NET.V1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V1.Colors
{
    [TestClass, TestCategory("Large")]
    public class ColorsTests
    {
        private IGw2ApiV1 _api;
        private CultureInfo _cultureInfo;
        private string _enUsColorName;

        [TestInitialize]
        public void Setup()
        {
            _api = new Gw2ApiV1(new HttpClient());
            _cultureInfo = new CultureInfo("en-US");
            _enUsColorName = "Starry Night";
        }

        [TestMethod]
        public async Task GetAllColorsAsync_AnyCulture_ReturnsColorsInThatCulture()
        {
            var colors = await _api.GetAllColorsAsync(_cultureInfo);

            Assert.IsTrue(colors.Any());
            CollectionAssert.Contains(colors.Values.Select(x => x.Name).ToList(), _enUsColorName);
        }

        [TestMethod]
        public async Task GetAllColorsAsync_CancellationToken_ReturnsColorsInThatCulture()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var colors = await _api.GetAllColorsAsync(_cultureInfo, cts.Token);

            Assert.IsTrue(colors.Any());
            CollectionAssert.Contains(colors.Values.Select(x => x.Name).ToList(), _enUsColorName);
        }
    }
}
