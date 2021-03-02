using GW2Api.NET.V1.Recipes.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial class Gw2ApiV1
    {
        private static readonly string _recipesResource = "recipes.json";
        private static readonly string _recipeDetailsResource = "recipe_details.json";

        public async Task<IReadOnlyCollection<int>> GetAllRecipeIdsAsync(CancellationToken token = default)
            => (await GetAsync<GetAllRecipeIdsResponse>(
                _recipesResource,
                token
            )).Recipes;

        public Task<RecipeDetail> GetRecipeDetailAsync(int recipeId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<RecipeDetail>(
                    _recipeDetailsResource,
                    new Dictionary<string, string>
                    {
                        { "recipe_id", recipeId.ToString() },
                        { "lang", lang?.TwoLetterISOLanguageName }
                    },
                    token
                );
    }
}
