using System.Collections.Generic;

namespace GW2Api.NET.V2.Novelties.Dto
{
    public record Novelty(
        int Id,
        string Name,
        string Description,
        string Icon,
        NoveltySlotType Slot,
        IList<int> UnlockItem
    );
}
