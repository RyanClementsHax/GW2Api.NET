using GW2Api.NET.Json.Converters;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Recipes.Dto
{
    public record RecipeDetail(
        [property: JsonConverter(typeof(StringToIntConverter))] int RecipeId,
        RecipeType Type,
        string OutputItemId,
        string OutputItemCount,
        string MinRating,
        string TimeToCraftMs,
        string VendorValue,
        IReadOnlyCollection<Discipline> Disciplines,
        IReadOnlyCollection<RecipeFlag> Flags,
        IReadOnlyCollection<Ingredient> Ingredients
    );
}
