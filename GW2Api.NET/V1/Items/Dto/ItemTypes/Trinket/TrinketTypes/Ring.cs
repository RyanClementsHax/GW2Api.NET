using GW2Api.NET.Json.Attributes;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Common;
using System.Collections.Generic;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Trinket.TrinketTypes
{
    [JsonDiscriminator("Ring")]
    public record Ring(
        IList<InfusionSlot> InfusionSlots,
        double AttributeAdjustment,
        InfixUpgrade InfixUpgrade,
        int? SuffixItemId,
        int? SecondarySuffixItemId
    ) : TrinketSubDetail(
        InfusionSlots,
        AttributeAdjustment,
        InfixUpgrade,
        SuffixItemId,
        SecondarySuffixItemId
    );
}
