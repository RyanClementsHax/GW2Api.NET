using GW2Api.NET.Json.Attributes;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Trait
{
    [JsonDiscriminator("Trait")]
    public record TraitDetail();
}
