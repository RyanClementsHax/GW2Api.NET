using System.Collections.Generic;

namespace GW2Api.NET.V2.Characters.Dto
{
    internal record GetCharacterRecipesResponse(
        IList<int> Recipes
    );
}
