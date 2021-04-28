using GW2Api.NET.V2.Items.Dto.Common;
using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto.Mounts
{
    public record MountSkin(
        int Id,
        string Name,
        Uri Icon,
        string Mount,
        IList<DyeSlot> DyeSlots
    );
}
