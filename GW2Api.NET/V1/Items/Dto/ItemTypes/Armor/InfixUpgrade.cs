using System.Collections.Generic;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Armor
{
    public record InfixUpgrade(
        Buff Buff,
        IReadOnlyCollection<ItemAttribute> Attributes
    );
}
