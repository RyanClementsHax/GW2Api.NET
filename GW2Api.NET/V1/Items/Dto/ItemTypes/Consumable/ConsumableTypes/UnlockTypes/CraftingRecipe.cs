using GW2Api.NET.Json.Attributes;
using GW2Api.NET.Json.Converters;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Consumable.ConsumableTypes.UnlockTypes
{
    [JsonDiscriminator("CraftingRecipe")]
    public record CraftingRecipe(
        [property: JsonConverter(typeof(StringToIntConverter))] int RecipeId
    ) : Unlock();
}
