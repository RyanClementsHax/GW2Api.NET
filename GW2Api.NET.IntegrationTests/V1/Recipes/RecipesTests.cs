using GW2Api.NET.V1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V1.Recipes
{
    [TestClass, TestCategory("Large"), TestCategory("Recipes")]
    public class RecipesTests
    {
        private IGw2ApiV1 _api;

        [TestInitialize]
        public void Setup() => _api = new Gw2ApiV1(new HttpClient());

        [TestMethod]
        public async Task GetAllRecipeIdsAsync_NoParams_ReturnsIds()
        {
            var recipeIds = await _api.GetAllRecipeIdsAsync();

            Assert.IsTrue(recipeIds.Any());
        }

        [TestMethod]
        public async Task GetAllRecipeIdsAsync_CancellationToken_ReturnsIds()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var recipeIds = await _api.GetAllRecipeIdsAsync(token: cts.Token);

            Assert.IsTrue(recipeIds.Any());
        }

        [TestMethod]
        public async Task GetRecipeDetailAsync_ValidRecipeId_ReturnsThatDetail()
        {
            var recipeId = 1275;
            var recipeOutputItemId = "11541";

            var recipeDetail = await _api.GetRecipeDetailAsync(recipeId);

            Assert.AreEqual(recipeDetail.OutputItemId, recipeOutputItemId);
        }

        [TestMethod]
        public async Task GetRecipeDetailAsync_ValidRecipeIdAndCancellationToken_ReturnsThatDetail()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var recipeId = 1275;
            var recipeOutputItemId = "11541";

            var recipeDetail = await _api.GetRecipeDetailAsync(recipeId, token: cts.Token);

            Assert.AreEqual(recipeDetail.OutputItemId, recipeOutputItemId);
        }
    }
}
