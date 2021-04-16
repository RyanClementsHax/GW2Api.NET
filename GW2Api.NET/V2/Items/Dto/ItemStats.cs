using GW2Api.NET.V2.Items.Dto.Common;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Items.Dto
{
    public record ItemStats(
        int Id,
        string Name,
        IList<ItemAttribute> Attributes
    );
}
