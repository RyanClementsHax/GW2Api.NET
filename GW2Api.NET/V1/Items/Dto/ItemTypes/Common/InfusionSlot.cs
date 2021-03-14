using System.Collections.Generic;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Common
{
    public record InfusionSlot(
        int ItemId,
        IList<InfusionType> Flags
    );
}
