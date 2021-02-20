using System.Collections.Generic;

namespace GW2Api.NET.V1.Items.Dto
{
    internal record ItemsResponse(
        IReadOnlyCollection<int> Items
    );
}
