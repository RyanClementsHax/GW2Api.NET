using GW2Api.NET.Json.Attributes;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Consumable.ConsumableTypes.UnlockTypes
{
    [JsonDiscriminator("Content")]
    public record Content() : Unlock();
}
