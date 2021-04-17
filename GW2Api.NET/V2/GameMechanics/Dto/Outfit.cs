﻿using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto
{
    public record Outfit(
        int Id,
        string Name,
        string Icon,
        IList<int> UnlockItems
    );
}
