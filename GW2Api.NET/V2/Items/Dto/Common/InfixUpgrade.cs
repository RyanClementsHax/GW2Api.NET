using System.Collections.Generic;

namespace GW2Api.NET.V2.Items.Dto.Common
{
    public record InfixUpgrade(
        int Id,
        Buff Buff,
        IList<ItemAttribute> Attributes
    );
}
