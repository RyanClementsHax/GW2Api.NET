using System.Collections.Generic;

namespace GW2Api.NET.V2.Items.Dto
{
    public record Material(
        int Id,
        string Name,
        IList<int> Items,
        int Order
    );
}
