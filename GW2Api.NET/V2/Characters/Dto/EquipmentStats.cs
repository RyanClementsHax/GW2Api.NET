using GW2Api.NET.V2.Items.Dto.Common;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Characters.Dto
{
    public record EquipmentStats(
        int Id,
        IDictionary<AttributeType, int> Attributes
    );
}