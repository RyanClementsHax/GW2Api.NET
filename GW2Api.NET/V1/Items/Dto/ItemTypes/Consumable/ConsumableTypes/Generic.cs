using GW2Api.NET.Json.Attributes;
using GW2Api.NET.Json.Converters;
using GW2Api.NET.V1.Files.Dto;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Consumable.ConsumableTypes
{
    [JsonDiscriminator("Generic")]
    public record Generic(
        [property: JsonConverter(typeof(StringToNullableIntConverter))] int? DurationMs,
        int? ApplyCount,
        string Name,
        Icon Icon,
        string Description
    ) : ConsumableSubDetail();
}
