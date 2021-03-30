using System.Collections.Generic;

namespace GW2Api.NET.V2.Characters.Dto
{
    public record Equipment(
        int Id,
        EquipmentSlot Slot,
        IList<int> Infusions,
        IList<int> Upgrades,
        int? Skin,
        EquipmentStats Stats,
        Binding? Binding,
        int? Charges,
        string BoundTo,
        IList<int?> Dyes
    );
}
