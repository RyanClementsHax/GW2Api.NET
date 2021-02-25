using GW2Api.NET.Json.Attributes;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Gathering.GatheringTypes
{
    [JsonDiscriminator("Mining")]
    public record Mining() : GatheringSubDetail();
}
