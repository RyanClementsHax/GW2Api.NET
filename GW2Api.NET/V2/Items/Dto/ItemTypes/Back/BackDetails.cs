using GW2Api.NET.V2.Items.Dto.Common;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Items.Dto.ItemTypes.Back
{
    public record BackDetails(
        IList<InfusionSlot> InfusionSlots,
        double AttributeAdjustment,
        InfixUpgrade InfixUpgrade,
        int? SuffixItemId,
        string SecondarySuffixItemId,
        IList<int> StatChoices
    );
}
