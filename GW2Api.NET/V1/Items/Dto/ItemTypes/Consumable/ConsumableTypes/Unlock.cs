using GW2Api.NET.Json.Attributes;
using GW2Api.NET.Json.Converters;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Consumable.ConsumableTypes
{
    [JsonDiscriminator("Unlock")]
    [JsonConverter(typeof(AbstractClassConverter<Unlock>))]
    [JsonDiscriminatorFieldName("unlock_type")]
    public abstract record Unlock() : ConsumableSubDetail();
}
