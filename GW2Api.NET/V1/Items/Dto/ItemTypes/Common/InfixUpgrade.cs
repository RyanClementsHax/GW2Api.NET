using System.Collections.Generic;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Common
{
    public record InfixUpgrade(
        int Id,
        Buff Buff,
        IReadOnlyCollection<ItemAttribute> Attributes
    );
}
