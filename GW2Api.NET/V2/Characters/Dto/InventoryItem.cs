using System.Collections.Generic;

namespace GW2Api.NET.V2.Characters.Dto
{
    public record InventoryItem(
        int Id,
        int Count,
        IList<int> Infusions,
        IList<int> Upgrades,
        int? Skin,
        EquipmentStats Stats,
        Binding? Binding,
        string BoundTo
    );
}