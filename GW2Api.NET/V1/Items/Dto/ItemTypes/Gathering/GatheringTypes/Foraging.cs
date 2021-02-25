using GW2Api.NET.Json.Attributes;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Gathering.GatheringTypes
{
    [JsonDiscriminator("Foraging")]
    public record Foraging() : GatheringSubDetail();
}
