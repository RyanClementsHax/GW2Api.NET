using System.Collections.Generic;

namespace GW2Api.NET.V1.Items.Dto
{
    internal record GetAllItemIdsResponse(
        IList<int> Items
    );
}
