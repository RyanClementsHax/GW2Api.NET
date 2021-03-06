﻿using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Items.Dto
{
    public record Finisher(
        int Id,
        string UnlockDetails,
        IList<int> UnlockItems,
        int Order,
        Uri Icon,
        string Name
    );
}
