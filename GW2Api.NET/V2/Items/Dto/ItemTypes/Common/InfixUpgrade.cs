using System.Collections.Generic;

namespace GW2Api.NET.V2.Items.Dto.ItemTypes.Common
{
    public record InfixUpgrade(
        int Id,
        Buff Buff,
        IList<ItemAttribute> Attributes
    );
}
