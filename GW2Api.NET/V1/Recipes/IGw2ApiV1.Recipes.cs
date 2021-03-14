using GW2Api.NET.V1.Recipes.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<IList<int>> GetAllRecipeIdsAsync(CancellationToken token = default);
        Task<RecipeDetail> GetRecipeDetailAsync(int recipeId, CultureInfo lang = null, CancellationToken token = default);
    }
}
