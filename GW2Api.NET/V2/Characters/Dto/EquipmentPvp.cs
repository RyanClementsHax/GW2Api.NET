using System.Collections.Generic;

namespace GW2Api.NET.V2.Characters.Dto
{
    public record EquipmentPvp(
        int? Amulet,
        int? Rune,
        IList<int?> Sigils
    );
}
