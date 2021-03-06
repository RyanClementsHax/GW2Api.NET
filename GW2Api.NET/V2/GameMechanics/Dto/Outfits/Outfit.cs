﻿using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto.Outfits
{
    public record Outfit(
        int Id,
        string Name,
        Uri Icon,
        IList<int> UnlockItems
    );
}
