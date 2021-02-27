using GW2Api.NET.V1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V1.Wvw
{
    [TestClass, TestCategory("Large"), TestCategory("Wvw")]
    public class WvwTests
    {
        private IGw2ApiV1 _api;

        [TestInitialize]
        public void Setup() => _api = new Gw2ApiV1(new HttpClient());

        [TestMethod]
        public async Task GetAllWvwMatchesAsync_NoParams_ReturnsTheMatches()
        {
            var matches = await _api.GetAllWvwMatchesAsync();

            Assert.IsTrue(matches.Any());
        }

        [TestMethod]
        public async Task GetAllWvwMatchesAsync_CancellationToken_ReturnsTheMatches()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var matches = await _api.GetAllWvwMatchesAsync(cts.Token);

            Assert.IsTrue(matches.Any());
        }

        [TestMethod]
        public async Task GetWvwMatchDetailAsync_ValidMatchId_ReturnsThatMatchDetail()
        {
            var matchId = (await _api.GetAllWvwMatchesAsync()).First().WvwMatchId;

            var matchDetail = await _api.GetWvwMatchDetailAsync(matchId);

            Assert.IsTrue(matchDetail.Maps.Any());
        }

        [TestMethod]
        public async Task GetWvwMatchDetailAsync_ValidMatchIdAndCancellationToken_ReturnsThatMatchDetail()
        {
            using var cts = TestData.CreateDefaultTokenSource();
            var matchId = (await _api.GetAllWvwMatchesAsync()).First().WvwMatchId;

            var matchDetail = await _api.GetWvwMatchDetailAsync(matchId, cts.Token);

            Assert.IsTrue(matchDetail.Maps.Any());
        }

        [TestMethod]
        public async Task GetWvwObjectiveNamesAsync_NoParams_ReturnsAllObjectiveNames()
        {
            var anObjectiveName = "Temple of Lost Prayers";

            var objectiveNames = await _api.GetWvwObjectiveNamesAsync();

            Assert.IsTrue(objectiveNames.Any());
            CollectionAssert.Contains(objectiveNames.Select(x => x.Name).ToList(), anObjectiveName);
        }

        [TestMethod]
        public async Task GetWvwObjectiveNamesAsync_CancellationToken_ReturnsAllObjectiveNames()
        {
            using var cts = TestData.CreateDefaultTokenSource();
            var anObjectiveName = "Temple of Lost Prayers";

            var objectiveNames = await _api.GetWvwObjectiveNamesAsync(token: cts.Token);

            Assert.IsTrue(objectiveNames.Any());
            CollectionAssert.Contains(objectiveNames.Select(x => x.Name).ToList(), anObjectiveName);
        }

        [TestMethod]
        public async Task GetWvwObjectiveNamesAsync_AnyCulture_ReturnsAllObjectiveNames()
        {
            var lang = new CultureInfo("es-MX");
            var anObjectiveName = "Templo de las Plegarias Perdidas";

            var objectiveNames = await _api.GetWvwObjectiveNamesAsync(lang);

            Assert.IsTrue(objectiveNames.Any());
            CollectionAssert.Contains(objectiveNames.Select(x => x.Name).ToList(), anObjectiveName);
        }

        [TestMethod]
        public async Task GetWvwObjectiveNamesAsync_AnyCultureAndCancellationToken_ReturnsAllObjectiveNames()
        {
            using var cts = TestData.CreateDefaultTokenSource();
            var lang = new CultureInfo("es-MX");
            var anObjectiveName = "Templo de las Plegarias Perdidas";

            var objectiveNames = await _api.GetWvwObjectiveNamesAsync(lang, cts.Token);

            Assert.IsTrue(objectiveNames.Any());
            CollectionAssert.Contains(objectiveNames.Select(x => x.Name).ToList(), anObjectiveName);
        }
    }
}
