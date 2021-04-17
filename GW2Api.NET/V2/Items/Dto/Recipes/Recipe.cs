using System.Collections.Generic;

namespace GW2Api.NET.V2.Items.Dto.Recipes
{
    public record Recipe(
        int Id,
        RecipeType Type,
        int OutputItemId,
        int OutputItemCount,
        int TimeToCraftMs,
        IList<Discipline> Disciplines,
        int MinRating,
        IList<RecipeFlag> Flags,
        IList<Ingredient> Ingredients,
        IList<GuildUpgrade> GuildIngredients,
        int? OutputUpgradeId,
        string ChatLink
    );
}
