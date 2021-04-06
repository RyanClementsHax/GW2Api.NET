using System.Collections.Generic;

namespace GW2Api.NET.V2.Items.Dto.ItemTypes.Common
{
    public record InfusionSlot(
        int? ItemId,
        IList<InfusionType> Flags
    );
}
