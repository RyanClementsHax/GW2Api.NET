using GW2Api.NET.Json;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Consumable.ConsumableTypes.UnlockTypes
{
    [JsonDiscriminator("Dye")]
    public record Dye(
        [property: JsonConverter(typeof(StringToIntConverter))] int ColorId
    ) : Unlock();
}
