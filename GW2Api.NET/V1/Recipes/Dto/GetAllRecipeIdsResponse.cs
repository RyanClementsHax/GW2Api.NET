using System.Collections.Generic;

namespace GW2Api.NET.V1.Recipes.Dto
{
    internal record GetAllRecipeIdsResponse(
        IList<int> Recipes
    );
}
