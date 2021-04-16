using System.Collections.Generic;

namespace GW2Api.NET.V2.Items.Dto.Common
{
    public record InfusionSlot(
        int? ItemId,
        IList<InfusionType> Flags
    );
}
