using GW2Api.NET.V2.Items.Dto.Common;
using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Pvp.Dto
{
    public record PvpAmulet(
        int Id,
        string Name,
        Uri Icon,
        IDictionary<AttributeType, int> Attributes
    );
}
