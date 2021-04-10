using GW2Api.NET.V2.Items.Dto.ItemTypes.Common;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Items.Dto.ItemTypes.Trinket
{
    public record TrinketDetails(
        TrinketType Type,
        IList<InfusionSlot> InfusionSlots,
        double AttributeAdjustment,
        InfixUpgrade InfixUpgrade,
        int? SuffixItemId,
        string SecondarySuffixItemId,
        IList<int> StatChoices
    );
}
