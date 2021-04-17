using GW2Api.NET.V2.Items.Dto.Common;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Items.Dto.Skins.SkinTypes.Armor
{
    public record DyeSlots(
        IList<DyeSlot> Default,
        IDictionary<RaceGender, IList<DyeSlot>> Overrides
    );
}
