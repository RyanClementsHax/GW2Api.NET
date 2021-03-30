using System.Collections.Generic;

namespace GW2Api.NET.V2.Characters.Dto
{
    public record Bag(
        int Id,
        int Size,
        IList<InventoryItem> Inventory
    );
}
