using System.Collections.Generic;

namespace GW2Api.NET.V2.Commerce.Dto
{
    public record Delivery(
        int Coins,
        IList<DeliveredItem> Items
    );
}
